using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Core.Utils
{
	// Token: 0x0200012B RID: 299
	public class RomanNumeralUtils : IStaticVariableResetter
	{
		// Token: 0x06000B0A RID: 2826 RVA: 0x00034E13 File Offset: 0x00033013
		static RomanNumeralUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RomanNumeralUtils.CreateStaticDefaultValue), new Action(RomanNumeralUtils.ResetStaticDefaultValue));
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00034E34 File Offset: 0x00033034
		public static void CreateStaticDefaultValue()
		{
			RomanNumeralUtils.MaxRomanNumeral = 3999;
			RomanNumeralUtils.StaticBuilder = new StringBuilder();
			RomanNumeralUtils.RomanNumerals = new ValueTuple<int, string>[]
			{
				new ValueTuple<int, string>(1000, "M"),
				new ValueTuple<int, string>(900, "CM"),
				new ValueTuple<int, string>(500, "D"),
				new ValueTuple<int, string>(400, "CD"),
				new ValueTuple<int, string>(100, "C"),
				new ValueTuple<int, string>(90, "XC"),
				new ValueTuple<int, string>(50, "L"),
				new ValueTuple<int, string>(40, "XL"),
				new ValueTuple<int, string>(10, "X"),
				new ValueTuple<int, string>(9, "IX"),
				new ValueTuple<int, string>(5, "V"),
				new ValueTuple<int, string>(4, "IV"),
				new ValueTuple<int, string>(1, "I")
			};
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00034F65 File Offset: 0x00033165
		public static void ResetStaticDefaultValue()
		{
			RomanNumeralUtils.MaxRomanNumeral = 0;
			RomanNumeralUtils.RomanNumerals = null;
			RomanNumeralUtils.StaticBuilder = null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00034F7C File Offset: 0x0003317C
		[NullableContext(1)]
		public static string ConvertToRoman(int number)
		{
			if (!RomanNumeralUtils.IsValidInput(number))
			{
				return string.Empty;
			}
			StringBuilder staticBuilder = RomanNumeralUtils.StaticBuilder;
			staticBuilder.Clear();
			int num = number;
			foreach (ValueTuple<int, string> valueTuple in RomanNumeralUtils.RomanNumerals)
			{
				int num2 = num / valueTuple.Item1;
				if (num2 > 0)
				{
					for (int j = 0; j < num2; j++)
					{
						staticBuilder.Append(valueTuple.Item2);
					}
					num -= valueTuple.Item1 * num2;
				}
			}
			return staticBuilder.ToString();
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00035005 File Offset: 0x00033205
		private static bool IsValidInput(int number)
		{
			return number > 0 && number <= RomanNumeralUtils.MaxRomanNumeral;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00035018 File Offset: 0x00033218
		public static bool IsValidRange(int number)
		{
			return RomanNumeralUtils.IsValidInput(number);
		}

		// Token: 0x040006B4 RID: 1716
		[Nullable(2)]
		private static StringBuilder StaticBuilder;

		// Token: 0x040006B5 RID: 1717
		[TupleElementNames(new string[]
		{
			"Value",
			"Symbol"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private static ValueTuple<int, string>[] RomanNumerals;

		// Token: 0x040006B6 RID: 1718
		private static int MaxRomanNumeral;
	}
}
