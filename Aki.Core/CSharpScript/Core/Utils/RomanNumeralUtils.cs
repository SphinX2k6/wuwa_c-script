using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Core.Utils
{
	// Token: 0x0200012A RID: 298
	public class RomanNumeralUtils : IStaticVariableResetter
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0003439F File Offset: 0x0003259F
		static RomanNumeralUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RomanNumeralUtils.CreateStaticDefaultValue), new Action(RomanNumeralUtils.ResetStaticDefaultValue));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000343C0 File Offset: 0x000325C0
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

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000344F1 File Offset: 0x000326F1
		public static void ResetStaticDefaultValue()
		{
			RomanNumeralUtils.MaxRomanNumeral = 0;
			RomanNumeralUtils.RomanNumerals = null;
			RomanNumeralUtils.StaticBuilder = null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00034508 File Offset: 0x00032708
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

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00034591 File Offset: 0x00032791
		private static bool IsValidInput(int number)
		{
			return number > 0 && number <= RomanNumeralUtils.MaxRomanNumeral;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000345A4 File Offset: 0x000327A4
		public static bool IsValidRange(int number)
		{
			return RomanNumeralUtils.IsValidInput(number);
		}

		// Token: 0x040006A6 RID: 1702
		[Nullable(2)]
		private static StringBuilder StaticBuilder;

		// Token: 0x040006A7 RID: 1703
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

		// Token: 0x040006A8 RID: 1704
		private static int MaxRomanNumeral;
	}
}
