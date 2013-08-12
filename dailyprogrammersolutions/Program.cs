using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyprogrammersolutions
{
    class Program
    {        
        delegate int del(int n);
        static void Main(string[] args)
        {
            ChallengeNumber134(args[0], args[1]);  
        }

        private static void ChallengeNumber134(string c, string d)
        {
            //www.reddit.com/r/dailyprogrammer
            //[08/06/13] Challenge #134 [Easy] N-Divisible Digits

            int a = Convert.ToInt32(c);
            int b = Convert.ToInt32(d);

            del myDelegate = (n) => (((int)Math.Pow(10, n) - 1));

            int answer = myDelegate(a) - (myDelegate(a) % b);

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
