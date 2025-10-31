using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        List<int> kaprekars = new List<int>();

        for (int i = p; i <= q; i++)
        {
            long square = (long)i * i;
            string s = square.ToString();
            int d = i.ToString().Length;

            string rightPart = s.Substring(Math.Max(0, s.Length - d));
            string leftPart = s.Length > d ? s.Substring(0, s.Length - d) : "0";

            long leftNum = long.Parse(leftPart);
            long rightNum = long.Parse(rightPart);

            if (leftNum + rightNum == i)
            {
                kaprekars.Add(i);
            }
        }

        if (kaprekars.Count == 0)
        {
            Console.WriteLine("INVALID RANGE");
        }
        else
        {
            Console.WriteLine(string.Join(" ", kaprekars));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
