using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF3 RID: 24563
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisUtils : Singleton
	{
		// Token: 0x0603E3C8 RID: 254920 RVA: 0x00F05F70 File Offset: 0x00F04170
		public BlockInstance CreateInstance(IShapeConfig config)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			int num = config.Matrix.Length;
			if (num > 0)
			{
				int num2 = config.Matrix[0].Length;
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						if (config.Matrix[i][j] == 1)
						{
							list.Add(new ValueTuple<int, int>(i, j));
						}
					}
				}
			}
			return new BlockInstance
			{
				ConfigId = config.Id,
				Offsets = list,
				ColorId = 0,
				GemType = EGemType.None,
				GemFill = EGemFillType.None,
				GemOffSet = 0
			};
		}

		// Token: 0x0603E3C9 RID: 254921 RVA: 0x00F06008 File Offset: 0x00F04208
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public ValueTuple<int, int> FindAnchorOffset([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int>> offsets)
		{
			if (offsets.Count == 0)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int num = 0;
			int num2 = 0;
			foreach (ValueTuple<int, int> valueTuple in offsets)
			{
				num += valueTuple.Item1;
				num2 += valueTuple.Item2;
			}
			float num3 = (float)num / (float)offsets.Count;
			float num4 = (float)num2 / (float)offsets.Count;
			float num5 = float.MaxValue;
			ValueTuple<int, int> result = offsets[0];
			foreach (ValueTuple<int, int> valueTuple2 in offsets)
			{
				float num6 = (float)(Math.Pow((double)((float)valueTuple2.Item1 - num3), 2.0) + Math.Pow((double)((float)valueTuple2.Item2 - num4), 2.0));
				if (num6 < num5)
				{
					num5 = num6;
					result = valueTuple2;
				}
			}
			return result;
		}

		// Token: 0x0603E3CA RID: 254922 RVA: 0x00F06120 File Offset: 0x00F04320
		public List<int> GetRandomIndices(int length, int count)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < length; i++)
			{
				list.Add(i);
			}
			Random random = new Random();
			for (int j = length - 1; j > 0; j--)
			{
				int index = random.Next(j + 1);
				int value = list[j];
				list[j] = list[index];
				list[index] = value;
			}
			return list.GetRange(0, count);
		}

		// Token: 0x0603E3CB RID: 254923 RVA: 0x00F06190 File Offset: 0x00F04390
		public static EGameMode CheckLevelMode(Tetris levelConfig)
		{
			if (levelConfig.Mode == 3)
			{
				return EGameMode.Infinite;
			}
			for (int i = 0; i < levelConfig.TargetResultLength; i++)
			{
				DicIntInt? dicIntInt = levelConfig.TargetResult(i);
				if (dicIntInt != null && dicIntInt.Value.Key == 0 && dicIntInt.Value.Value > 0)
				{
					return EGameMode.Score;
				}
			}
			return EGameMode.GemCollection;
		}

		// Token: 0x0603E3CC RID: 254924 RVA: 0x00F061F3 File Offset: 0x00F043F3
		public static bool IsEggLevel(Tetris levelConfig)
		{
			return levelConfig.Mode == 2;
		}

		// Token: 0x0603E3CD RID: 254925 RVA: 0x00F061FF File Offset: 0x00F043FF
		public static bool IsHardLevel(Tetris levelConfig)
		{
			return levelConfig.Mode == 1;
		}

		// Token: 0x0603E3CE RID: 254926 RVA: 0x00F0620B File Offset: 0x00F0440B
		public static bool IsActivityLevel(Tetris levelConfig)
		{
			return levelConfig.Mode == 1 || levelConfig.Mode == 0 || levelConfig.Mode == 2;
		}

		// Token: 0x0603E3CF RID: 254927 RVA: 0x00F0622C File Offset: 0x00F0442C
		public static int GenPosKey(int row, int column)
		{
			return row * 100 + column;
		}

		// Token: 0x0603E3D0 RID: 254928 RVA: 0x00F06234 File Offset: 0x00F04434
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public static ValueTuple<int, int> ParsePosKey(int key)
		{
			return new ValueTuple<int, int>(key / 100, key % 100);
		}

		// Token: 0x17009067 RID: 36967
		// (get) Token: 0x0603E3D1 RID: 254929 RVA: 0x00F06243 File Offset: 0x00F04443
		public static TetrisUtils Instance
		{
			get
			{
				if (TetrisUtils._instance == null)
				{
					TetrisUtils._instance = new TetrisUtils();
					TetrisUtils._instance.OnInit();
				}
				return TetrisUtils._instance;
			}
		}

		// Token: 0x0603E3D2 RID: 254930 RVA: 0x00F06266 File Offset: 0x00F04466
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E3D3 RID: 254931 RVA: 0x00F06268 File Offset: 0x00F04468
		public static void ResetStaticDefaultValue()
		{
			TetrisUtils instance = TetrisUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TetrisUtils._instance = null;
		}

		// Token: 0x0603E3D4 RID: 254932 RVA: 0x00F06281 File Offset: 0x00F04481
		static TetrisUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TetrisUtils.CreateStaticDefaultValue), new Action(TetrisUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04020814 RID: 133140
		[Nullable(2)]
		private static TetrisUtils _instance;
	}
}
