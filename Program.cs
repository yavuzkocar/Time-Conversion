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


namespace Time_Conversion
{
    class Result
{

    //benim çözümüm bazı sorunlar var yazılan saat 06 ile başlayıp öğleden önce olduğu zaman hata veriyor..

    public static string timeConversion(string s)
    {
        string[] dizi = new string[s.Length];
       for (int i = 0; i < s.Length; i++)
        { 
         dizi[i]=s[i].ToString();
        }
        int b=Convert.ToInt32(dizi[0]);
        int a= b*10;
        int c= Convert.ToInt32(dizi[1]);
        int d= a+c;

        
        
        if (dizi[8]=="P")
        {
            d+=12;
        }
        if (dizi[8]=="A")
        {
            d+=0;
        }
        string[] dizi2= new string[s.Length-2];
        string f = Convert.ToString(d);
        dizi2[0]=f[0].ToString();
        dizi2[1]=f[1].ToString();
        for (int i = 2; i < s.Length-2; i++)
        {
            dizi2[i]=s[i].ToString();
        }
        string son="";
        foreach (var item in dizi2)
        {
            son+=item;
        }
       
 return(son);
    //***************************
    
        
            
        
  

    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        Console.WriteLine(result);

       
    }
}
}
