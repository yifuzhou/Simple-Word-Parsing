//@author Yifu Zhou
//created by Feb 24 2017
//output the number of words when provided in camel-case format in English only.
//In C#

using System;

class MainClass
{
	public static void Main(string[] args)
	{
		string input = Console.ReadLine();

		//convert to char array
		char[] cs = input.ToCharArray();
		int count = 0;
		for (int i = 0; i < input.Length; i++)
		{
			if (i == 0 && Char.IsLower(cs[i]))
				count = 1;
			if (Char.IsUpper(cs[i]))
				count++;
		}
		Console.WriteLine("{0}\n", count);
	}
}
