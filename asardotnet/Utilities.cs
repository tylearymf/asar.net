﻿/*
 *  asar.net Copyright (c) 2015 Jiiks | http://jiiks.net
 * 
 *  https://github.com/Jiiks/asar.net
 * 
 *  For: https://github.com/atom/asar
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 * */

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace asardotnet
{
    public class Utilities
    {

        public static string ByteArrayToHexString(byte[] bytes)
        {
            StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);

            foreach (byte b in bytes)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }

            return stringBuilder.ToString();
        }

        public static string HexStringToText(String hex)
        {

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hex.Length; i += 2)
            {
                String b = hex.Substring(i, 2);
                uint decimalValue = Convert.ToUInt32(b, 16);
                char character = Convert.ToChar(decimalValue);

                stringBuilder.Append(character);
            }

            return stringBuilder.ToString();
        }

        public static void WriteFile(byte[] bytes, String destination)
        {
           // Debug.Print("Writing bytes to : " + destination);

            String dirPath = Path.GetDirectoryName(destination);
            String filename = Path.GetFileName(destination);

            Directory.CreateDirectory(dirPath);

            File.WriteAllBytes(destination, bytes);
        }

    }
}
