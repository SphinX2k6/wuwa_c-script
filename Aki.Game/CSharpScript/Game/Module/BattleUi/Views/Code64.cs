using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CFC RID: 23804
	[NullableContext(1)]
	[Nullable(0)]
	public class Code64 : CodeNBase
	{
		// Token: 0x0603C4B4 RID: 246964 RVA: 0x00E6FE20 File Offset: 0x00E6E020
		public override Dictionary<string, int[]> GetCodeTable()
		{
			return Code64.CodeTable;
		}

		// Token: 0x0603C4B5 RID: 246965 RVA: 0x00E6FE27 File Offset: 0x00E6E027
		public override int SingleCodeLength()
		{
			return 8;
		}

		// Token: 0x0603C4B6 RID: 246966 RVA: 0x00E6FE2A File Offset: 0x00E6E02A
		public override int SupportCharCount()
		{
			return 62;
		}

		// Token: 0x0603C4B8 RID: 246968 RVA: 0x00E6FE38 File Offset: 0x00E6E038
		// Note: this type is marked as 'beforefieldinit'.
		static Code64()
		{
			Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
			Dictionary<string, int[]> dictionary2 = dictionary;
			string key = "+";
			int[] array = new int[7];
			array[0] = 1;
			dictionary2.Add(key, array);
			dictionary.Add("-", new int[]
			{
				1,
				0,
				0,
				0,
				0,
				0,
				1
			});
			Dictionary<string, int[]> dictionary3 = dictionary;
			string key2 = "0";
			int[] array2 = new int[7];
			array2[0] = 1;
			array2[5] = 1;
			dictionary3.Add(key2, array2);
			dictionary.Add("1", new int[]
			{
				1,
				0,
				0,
				0,
				0,
				1,
				1
			});
			Dictionary<string, int[]> dictionary4 = dictionary;
			string key3 = "2";
			int[] array3 = new int[7];
			array3[0] = 1;
			array3[4] = 1;
			dictionary4.Add(key3, array3);
			dictionary.Add("3", new int[]
			{
				1,
				0,
				0,
				0,
				1,
				0,
				1
			});
			dictionary.Add("4", new int[]
			{
				1,
				0,
				0,
				0,
				1,
				1,
				0
			});
			dictionary.Add("5", new int[]
			{
				1,
				0,
				0,
				0,
				1,
				1,
				1
			});
			Dictionary<string, int[]> dictionary5 = dictionary;
			string key4 = "6";
			int[] array4 = new int[7];
			array4[0] = 1;
			array4[3] = 1;
			dictionary5.Add(key4, array4);
			dictionary.Add("7", new int[]
			{
				1,
				0,
				0,
				1,
				0,
				0,
				1
			});
			dictionary.Add("8", new int[]
			{
				1,
				0,
				0,
				1,
				0,
				1,
				0
			});
			dictionary.Add("9", new int[]
			{
				1,
				0,
				0,
				1,
				0,
				1,
				1
			});
			dictionary.Add("a", new int[]
			{
				1,
				0,
				0,
				1,
				1,
				0,
				0
			});
			dictionary.Add("b", new int[]
			{
				1,
				0,
				0,
				1,
				1,
				0,
				1
			});
			dictionary.Add("c", new int[]
			{
				1,
				0,
				0,
				1,
				1,
				1,
				0
			});
			dictionary.Add("d", new int[]
			{
				1,
				0,
				0,
				1,
				1,
				1,
				1
			});
			Dictionary<string, int[]> dictionary6 = dictionary;
			string key5 = "e";
			int[] array5 = new int[7];
			array5[0] = 1;
			array5[2] = 1;
			dictionary6.Add(key5, array5);
			dictionary.Add("f", new int[]
			{
				1,
				0,
				1,
				0,
				0,
				0,
				1
			});
			dictionary.Add("g", new int[]
			{
				1,
				0,
				1,
				0,
				0,
				1,
				0
			});
			dictionary.Add("h", new int[]
			{
				1,
				0,
				1,
				0,
				0,
				1,
				1
			});
			dictionary.Add("i", new int[]
			{
				1,
				0,
				1,
				0,
				1,
				0,
				0
			});
			dictionary.Add("j", new int[]
			{
				1,
				0,
				1,
				0,
				1,
				0,
				1
			});
			dictionary.Add("k", new int[]
			{
				1,
				0,
				1,
				0,
				1,
				1,
				0
			});
			dictionary.Add("l", new int[]
			{
				1,
				0,
				1,
				0,
				1,
				1,
				1
			});
			dictionary.Add("m", new int[]
			{
				1,
				0,
				1,
				1,
				0,
				0,
				0
			});
			dictionary.Add("n", new int[]
			{
				1,
				0,
				1,
				1,
				0,
				0,
				1
			});
			dictionary.Add("o", new int[]
			{
				1,
				0,
				1,
				1,
				0,
				1,
				0
			});
			dictionary.Add("p", new int[]
			{
				1,
				0,
				1,
				1,
				0,
				1,
				1
			});
			dictionary.Add("q", new int[]
			{
				1,
				0,
				1,
				1,
				1,
				0,
				0
			});
			dictionary.Add("r", new int[]
			{
				1,
				0,
				1,
				1,
				1,
				0,
				1
			});
			dictionary.Add("s", new int[]
			{
				1,
				0,
				1,
				1,
				1,
				1,
				0
			});
			dictionary.Add("t", new int[]
			{
				1,
				0,
				1,
				1,
				1,
				1,
				1
			});
			Dictionary<string, int[]> dictionary7 = dictionary;
			string key6 = "u";
			int[] array6 = new int[7];
			array6[0] = 1;
			array6[1] = 1;
			dictionary7.Add(key6, array6);
			dictionary.Add("v", new int[]
			{
				1,
				1,
				0,
				0,
				0,
				0,
				1
			});
			dictionary.Add("w", new int[]
			{
				1,
				1,
				0,
				0,
				0,
				1,
				0
			});
			dictionary.Add("x", new int[]
			{
				1,
				1,
				0,
				0,
				0,
				1,
				1
			});
			dictionary.Add("y", new int[]
			{
				1,
				1,
				0,
				0,
				1,
				0,
				0
			});
			dictionary.Add("z", new int[]
			{
				1,
				1,
				0,
				0,
				1,
				0,
				1
			});
			dictionary.Add("A", new int[]
			{
				1,
				1,
				0,
				0,
				1,
				1,
				0
			});
			dictionary.Add("B", new int[]
			{
				1,
				1,
				0,
				0,
				1,
				1,
				1
			});
			dictionary.Add("C", new int[]
			{
				1,
				1,
				0,
				1,
				0,
				0,
				0
			});
			dictionary.Add("D", new int[]
			{
				1,
				1,
				0,
				1,
				0,
				0,
				1
			});
			dictionary.Add("E", new int[]
			{
				1,
				1,
				0,
				1,
				0,
				1,
				0
			});
			dictionary.Add("F", new int[]
			{
				1,
				1,
				0,
				1,
				0,
				1,
				1
			});
			dictionary.Add("G", new int[]
			{
				1,
				1,
				0,
				1,
				1,
				0,
				0
			});
			dictionary.Add("H", new int[]
			{
				1,
				1,
				0,
				1,
				1,
				0,
				1
			});
			dictionary.Add("I", new int[]
			{
				1,
				1,
				0,
				1,
				1,
				1,
				0
			});
			dictionary.Add("J", new int[]
			{
				1,
				1,
				0,
				1,
				1,
				1,
				1
			});
			dictionary.Add("K", new int[]
			{
				1,
				1,
				1,
				0,
				0,
				0,
				0
			});
			dictionary.Add("L", new int[]
			{
				1,
				1,
				1,
				0,
				0,
				0,
				1
			});
			dictionary.Add("M", new int[]
			{
				1,
				1,
				1,
				0,
				0,
				1,
				0
			});
			dictionary.Add("N", new int[]
			{
				1,
				1,
				1,
				0,
				0,
				1,
				1
			});
			dictionary.Add("O", new int[]
			{
				1,
				1,
				1,
				0,
				1,
				0,
				0
			});
			dictionary.Add("P", new int[]
			{
				1,
				1,
				1,
				0,
				1,
				0,
				1
			});
			dictionary.Add("Q", new int[]
			{
				1,
				1,
				1,
				0,
				1,
				1,
				0
			});
			dictionary.Add("R", new int[]
			{
				1,
				1,
				1,
				0,
				1,
				1,
				1
			});
			dictionary.Add("S", new int[]
			{
				1,
				1,
				1,
				1,
				0,
				0,
				0
			});
			dictionary.Add("T", new int[]
			{
				1,
				1,
				1,
				1,
				0,
				0,
				1
			});
			dictionary.Add("U", new int[]
			{
				1,
				1,
				1,
				1,
				0,
				1,
				0
			});
			dictionary.Add("V", new int[]
			{
				1,
				1,
				1,
				1,
				0,
				1,
				1
			});
			dictionary.Add("W", new int[]
			{
				1,
				1,
				1,
				1,
				1,
				0,
				0
			});
			dictionary.Add("X", new int[]
			{
				1,
				1,
				1,
				1,
				1,
				0,
				1
			});
			dictionary.Add("Y", new int[]
			{
				1,
				1,
				1,
				1,
				1,
				1,
				0
			});
			dictionary.Add("Z", new int[]
			{
				1,
				1,
				1,
				1,
				1,
				1,
				1
			});
			Code64.CodeTable = dictionary;
		}

		// Token: 0x0401F697 RID: 128663
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int[]> CodeTable;
	}
}
