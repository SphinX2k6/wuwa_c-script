using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBA RID: 12218
	public class TetrisUtils : Singleton
	{
		// Token: 0x0601D01C RID: 118812 RVA: 0x008DB740 File Offset: 0x008D9940
		[NullableContext(1)]
		public BlockInstance CreateInstance(ShapeConfig config)
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			int length = config.Matrix.GetLength(0);
			if (length > 0)
			{
				int length2 = config.Matrix.GetLength(1);
				for (int i = 0; i < length; i++)
				{
					for (int j = 0; j < length2; j++)
					{
						if (config.Matrix[i, j] == 1)
						{
							list.Add(new ValueTuple<int, int>(i, j));
						}
					}
				}
			}
			return new BlockInstance
			{
				Config = config,
				Offsets = list.ToArray(),
				ColorId = 0,
				GemType = EGemType.None,
				GemFill = EGemFillType.None,
				GemOffSet = 0,
				Rotation = ETetrisRotation.Origin
			};
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x008DB7E8 File Offset: 0x008D99E8
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public static ValueTuple<int, int>? GetDropTargetOffset([Nullable(1)] BlockInstance block, FVector2D boundRectCentrePosition, float gridWidth, float gridHeight)
		{
			int boundRectWidth = block.BoundRectWidth;
			int boundRectHeight = block.BoundRectHeight;
			FVector2D pos;
			switch (block.Rotation)
			{
			case ETetrisRotation.Origin:
			case ETetrisRotation.Clockwise180:
				pos = new FVector2D(boundRectCentrePosition.X - (float)(boundRectWidth - 1) * gridWidth / 2f, boundRectCentrePosition.Y + (float)(boundRectHeight - 1) * gridHeight / 2f);
				break;
			case ETetrisRotation.Clockwise90:
			case ETetrisRotation.Clockwise270:
				pos = new FVector2D(boundRectCentrePosition.X - (float)(boundRectHeight - 1) * gridWidth / 2f, boundRectCentrePosition.Y + (float)(boundRectWidth - 1) * gridHeight / 2f);
				break;
			default:
				throw new ArgumentOutOfRangeException("block", block, null);
			}
			return TetrisUtils.CalcBoardRawColumnByPosition(pos, gridWidth, gridHeight);
		}

		// Token: 0x0601D01E RID: 118814 RVA: 0x008DB894 File Offset: 0x008D9A94
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public static ValueTuple<int, int> GetRotatedOffset([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] ValueTuple<int, int> blockOffsets, int boundRectWidth, int boundRectHeight, ETetrisRotation rotation)
		{
			ValueTuple<int, int> result;
			switch (rotation)
			{
			case ETetrisRotation.Origin:
				result = blockOffsets;
				break;
			case ETetrisRotation.Clockwise90:
				result = new ValueTuple<int, int>(blockOffsets.Item2, boundRectHeight - 1 - blockOffsets.Item1);
				break;
			case ETetrisRotation.Clockwise180:
				result = new ValueTuple<int, int>(boundRectHeight - 1 - blockOffsets.Item1, boundRectWidth - 1 - blockOffsets.Item2);
				break;
			case ETetrisRotation.Clockwise270:
				result = new ValueTuple<int, int>(boundRectWidth - 1 - blockOffsets.Item2, blockOffsets.Item1);
				break;
			default:
				throw new ArgumentOutOfRangeException("rotation", rotation, null);
			}
			return result;
		}

		// Token: 0x0601D01F RID: 118815 RVA: 0x008DB91C File Offset: 0x008D9B1C
		public static FVector2D GetRotatedAnchorOffset([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] ValueTuple<int, int> blockOffsets, int boundRectWidth, int boundRectHeight, float gridWidth, float gridHeight, ETetrisRotation rotation)
		{
			ValueTuple<float, float> valueTuple;
			switch (rotation)
			{
			case ETetrisRotation.Origin:
			case ETetrisRotation.Clockwise180:
				valueTuple = new ValueTuple<float, float>(-((float)(boundRectWidth - 1) * gridWidth / 2f), (float)(boundRectHeight - 1) * gridHeight / 2f);
				break;
			case ETetrisRotation.Clockwise90:
			case ETetrisRotation.Clockwise270:
				valueTuple = new ValueTuple<float, float>(-((float)(boundRectHeight - 1) * gridWidth / 2f), (float)(boundRectWidth - 1) * gridHeight / 2f);
				break;
			default:
				throw new ArgumentOutOfRangeException("rotation", rotation, null);
			}
			ValueTuple<float, float> valueTuple2 = valueTuple;
			float item = valueTuple2.Item1;
			float item2 = valueTuple2.Item2;
			ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(blockOffsets, boundRectWidth, boundRectHeight, rotation);
			return new FVector2D(item + (float)rotatedOffset.Item2 * gridWidth, item2 - (float)rotatedOffset.Item1 * gridHeight);
		}

		// Token: 0x0601D020 RID: 118816 RVA: 0x008DB9D0 File Offset: 0x008D9BD0
		public static float GetRotateHotkeyAnchorOffsetX(int boundRectWidth, int boundRectHeight, float gridWidth, ETetrisRotation rotation)
		{
			float result;
			switch (rotation)
			{
			case ETetrisRotation.Origin:
			case ETetrisRotation.Clockwise180:
				result = (float)boundRectWidth / 2f * gridWidth;
				break;
			case ETetrisRotation.Clockwise90:
			case ETetrisRotation.Clockwise270:
				result = (float)boundRectHeight / 2f * gridWidth;
				break;
			default:
				throw new ArgumentOutOfRangeException("rotation", rotation, null);
			}
			return result;
		}

		// Token: 0x0601D021 RID: 118817 RVA: 0x008DBA24 File Offset: 0x008D9C24
		public static FVector2D GetRotateCentreOffset(int boundRectWidth, int boundRectHeight, float gridWidth, float gridHeight, ETetrisRotation rotation)
		{
			FVector2D result;
			if (Info.Instance.IsInTouch())
			{
				FVector2D fvector2D;
				switch (rotation)
				{
				case ETetrisRotation.Origin:
				case ETetrisRotation.Clockwise180:
					fvector2D = new FVector2D(-((float)(boundRectWidth - 1) * gridWidth / 2f + gridWidth), (float)(boundRectHeight - 1) * gridHeight / 2f);
					break;
				case ETetrisRotation.Clockwise90:
				case ETetrisRotation.Clockwise270:
					fvector2D = new FVector2D(-((float)(boundRectHeight - 1) * gridWidth / 2f + gridWidth), (float)(boundRectWidth - 1) * gridHeight / 2f);
					break;
				default:
					throw new ArgumentOutOfRangeException("rotation", rotation, null);
				}
				result = fvector2D;
			}
			else
			{
				result = FVector2D.ZeroVector;
			}
			return result;
		}

		// Token: 0x0601D022 RID: 118818 RVA: 0x008DBABC File Offset: 0x008D9CBC
		public static FVector2D GetRotateCentreVector(FVector2D dragPosition, int boundRectWidth, int boundRectHeight, float gridWidth, float gridHeight, ETetrisRotation rotation)
		{
			FVector2D rotateCentreOffset = TetrisUtils.GetRotateCentreOffset(boundRectWidth, boundRectHeight, gridWidth, gridHeight, rotation);
			return dragPosition + rotateCentreOffset;
		}

		// Token: 0x0601D023 RID: 118819 RVA: 0x008DBAE0 File Offset: 0x008D9CE0
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public static ValueTuple<int, int>? CalcBoardRawColumnByPosition(FVector2D pos, float gridWidth, float gridHeight)
		{
			int num = (int)MathF.Floor(4f + pos.X / gridWidth);
			int num2 = (int)MathF.Floor(4f - pos.Y / gridHeight);
			if (num < 0 || num >= 8 || num2 < 0 || num2 >= 8)
			{
				return null;
			}
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(num2, num));
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x008DBB40 File Offset: 0x008D9D40
		public static EGameMode CheckLevelMode(Tetris levelConfig)
		{
			if (levelConfig.Mode == 3)
			{
				return EGameMode.Infinite;
			}
			for (int i = 0; i < levelConfig.TargetResultsLength; i++)
			{
				IntIntMap value = levelConfig.TargetResults(i).Value;
				for (int j = 0; j < value.MapIntIntLength; j++)
				{
					DicIntInt value2 = value.MapIntInt(j).Value;
					if (value2.Key == 0 && value2.Value > 0)
					{
						return EGameMode.Score;
					}
				}
			}
			return EGameMode.GemCollection;
		}

		// Token: 0x0601D025 RID: 118821 RVA: 0x008DBBB7 File Offset: 0x008D9DB7
		public static bool IsEggLevel(Tetris levelConfig)
		{
			return levelConfig.Mode == 2;
		}

		// Token: 0x0601D026 RID: 118822 RVA: 0x008DBBC4 File Offset: 0x008D9DC4
		public static bool IsActivityEggLevel(Tetris levelConfig)
		{
			if (levelConfig.ActivityId != 0)
			{
				int mode = levelConfig.Mode;
				if (mode - 2 <= 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D027 RID: 118823 RVA: 0x008DBBEF File Offset: 0x008D9DEF
		public static bool IsHardLevel(Tetris levelConfig)
		{
			return levelConfig.Mode == 1;
		}

		// Token: 0x0601D028 RID: 118824 RVA: 0x008DBBFB File Offset: 0x008D9DFB
		public static bool IsActivityLevel(Tetris levelConfig)
		{
			return levelConfig.ActivityId != 0;
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x008DBC07 File Offset: 0x008D9E07
		public static int GenPosKey(int row, int column)
		{
			return row * 8 + column;
		}

		// Token: 0x0601D02A RID: 118826 RVA: 0x008DBC0E File Offset: 0x008D9E0E
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public static ValueTuple<int, int> ParsePosKey(int key)
		{
			return new ValueTuple<int, int>(key / 8, key % 8);
		}

		// Token: 0x0601D02B RID: 118827 RVA: 0x008DBC1C File Offset: 0x008D9E1C
		public static FVector2D RotatePosition(FVector2D position, float t)
		{
			if (t < 0f || t > 1f)
			{
				throw new ArgumentOutOfRangeException("t", t, "t必须在[0, 1]之间。");
			}
			if (t != 1f)
			{
				ValueTuple<float, float> valueTuple = FMath.SinCos(1.5707964f * t);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				return new FVector2D(position.X * item2 + position.Y * item, -position.X * item + position.Y * item2);
			}
			return new FVector2D(position.Y, -position.X);
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0601D02C RID: 118828 RVA: 0x008DBCAD File Offset: 0x008D9EAD
		[Nullable(1)]
		public static TetrisUtils Instance
		{
			[NullableContext(1)]
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

		// Token: 0x0601D02D RID: 118829 RVA: 0x008DBCD0 File Offset: 0x008D9ED0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D02E RID: 118830 RVA: 0x008DBCD2 File Offset: 0x008D9ED2
		public static void ResetStaticDefaultValue()
		{
			TetrisUtils instance = TetrisUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TetrisUtils._instance = null;
		}

		// Token: 0x0601D02F RID: 118831 RVA: 0x008DBCEB File Offset: 0x008D9EEB
		static TetrisUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TetrisUtils.CreateStaticDefaultValue), new Action(TetrisUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0400F47A RID: 62586
		[Nullable(2)]
		private static TetrisUtils _instance;
	}
}
