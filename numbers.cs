using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number numbers = new number();
            numbers.CariNilaiMin(55, 15);
            numbers.CariNilaiMin(32, 97, 42);
            numbers.CariNilaiMax(81, 64);
            numbers.CariNilaiMax(74, 87, 24);
        }
    }
}