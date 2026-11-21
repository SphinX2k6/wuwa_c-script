using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005477 RID: 21623
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceDetector
	{
		// Token: 0x06035B12 RID: 219922 RVA: 0x00F014C2 File Offset: 0x00EFF6C2
		public void DetectInto(Board board, int rowStart, int rowEnd, HashSet<int> cols, List<ItemSequence> result)
		{
			this.HRuns.Clear();
			this.VRuns.Clear();
			this.UsedV.Clear();
			this.ScanHorizontal(board, rowStart, rowEnd);
			this.ScanVertical(board, cols);
			this.MergeAndClassify(board, result);
		}

		// Token: 0x06035B13 RID: 219923 RVA: 0x00F01500 File Offset: 0x00EFF700
		public void DetectAll(Board board, List<ItemSequence> result)
		{
			this.HRuns.Clear();
			this.VRuns.Clear();
			this.UsedV.Clear();
			this.ScanHorizontal(board, 0, 6);
			for (int i = 0; i < 8; i++)
			{
				this.ScanVerticalColumn(board, i);
			}
			this.MergeAndClassify(board, result);
		}

		// Token: 0x06035B14 RID: 219924 RVA: 0x00F01554 File Offset: 0x00EFF754
		private void ScanHorizontal(Board board, int rowStart, int rowEnd)
		{
			rowStart = ((rowStart < 0) ? 0 : rowStart);
			rowEnd = ((rowEnd >= 7) ? 6 : rowEnd);
			for (int i = rowStart; i <= rowEnd; i++)
			{
				int j = 0;
				while (j < 8)
				{
					EPieceType type;
					if (!this.TryMatchType(board, i, j, out type))
					{
						j++;
					}
					else
					{
						int num = j + 1;
						while (num < 8 && this.SameMatch(board, i, num, type))
						{
							num++;
						}
						int num2 = num - j;
						if (num2 >= 3)
						{
							this.HRuns.Add(new ValueTuple<int, int, int>(i, j, num2));
						}
						j = num;
					}
				}
			}
		}

		// Token: 0x06035B15 RID: 219925 RVA: 0x00F015D8 File Offset: 0x00EFF7D8
		private void ScanVertical(Board board, HashSet<int> cols)
		{
			foreach (int num in cols)
			{
				if (num >= 0 && num < 8)
				{
					this.ScanVerticalColumn(board, num);
				}
			}
		}

		// Token: 0x06035B16 RID: 219926 RVA: 0x00F01630 File Offset: 0x00EFF830
		private void ScanVerticalColumn(Board board, int c)
		{
			int i = 0;
			while (i < 7)
			{
				EPieceType type;
				if (!this.TryMatchType(board, i, c, out type))
				{
					i++;
				}
				else
				{
					int num = i + 1;
					while (num < 7 && this.SameMatch(board, num, c, type))
					{
						num++;
					}
					int num2 = num - i;
					if (num2 >= 3)
					{
						this.VRuns.Add(new ValueTuple<int, int, int>(i, c, num2));
					}
					i = num;
				}
			}
		}

		// Token: 0x06035B17 RID: 219927 RVA: 0x00F01690 File Offset: 0x00EFF890
		private bool TryMatchType(Board board, int r, int c, out EPieceType type)
		{
			Piece piece = board.GetPiece(r, c);
			if (piece == null || !piece.IsMatchable)
			{
				type = (EPieceType)0;
				return false;
			}
			type = piece.Type;
			return true;
		}

		// Token: 0x06035B18 RID: 219928 RVA: 0x00F016C4 File Offset: 0x00EFF8C4
		private bool SameMatch(Board board, int r, int c, EPieceType type)
		{
			Piece piece = board.GetPiece(r, c);
			return piece != null && piece.IsMatchable && piece.Type == type;
		}

		// Token: 0x06035B19 RID: 219929 RVA: 0x00F016F4 File Offset: 0x00EFF8F4
		private void MergeAndClassify(Board board, List<ItemSequence> result)
		{
			this.UsedH.Clear();
			this.UsedV.Clear();
			foreach (EMatchShape ematchShape in MatchThreeGameplayDefine.MatchShapePriority)
			{
				if (ematchShape - EMatchShape.Line3 > 2)
				{
					if (ematchShape - EMatchShape.L <= 1)
					{
						this.ExtractCrosses(board, result, ematchShape);
					}
				}
				else
				{
					this.ExtractLines(board, result, ematchShape);
				}
			}
		}

		// Token: 0x06035B1A RID: 219930 RVA: 0x00F01750 File Offset: 0x00EFF950
		private void ExtractLines(Board board, List<ItemSequence> result, EMatchShape shape)
		{
			for (int i = 0; i < this.HRuns.Count; i++)
			{
				if (!this.UsedH.Contains(i))
				{
					ValueTuple<int, int, int> valueTuple = this.HRuns[i];
					if (this.ClassifyLineShape(valueTuple.Item3) == shape)
					{
						this.UsedH.Add(i);
						result.Add(this.BuildLineSequence(board, valueTuple.Item1, valueTuple.Item2, valueTuple.Item3, true));
					}
				}
			}
			for (int j = 0; j < this.VRuns.Count; j++)
			{
				if (!this.UsedV.Contains(j))
				{
					ValueTuple<int, int, int> valueTuple2 = this.VRuns[j];
					if (this.ClassifyLineShape(valueTuple2.Item3) == shape)
					{
						this.UsedV.Add(j);
						result.Add(this.BuildLineSequence(board, valueTuple2.Item1, valueTuple2.Item2, valueTuple2.Item3, false));
					}
				}
			}
		}

		// Token: 0x06035B1B RID: 219931 RVA: 0x00F01838 File Offset: 0x00EFFA38
		private void ExtractCrosses(Board board, List<ItemSequence> result, EMatchShape shape)
		{
			for (int i = 0; i < this.HRuns.Count; i++)
			{
				if (!this.UsedH.Contains(i))
				{
					ValueTuple<int, int, int> valueTuple = this.HRuns[i];
					for (int j = 0; j < this.VRuns.Count; j++)
					{
						if (!this.UsedV.Contains(j))
						{
							ValueTuple<int, int, int> valueTuple2 = this.VRuns[j];
							bool flag = valueTuple2.Item2 >= valueTuple.Item2 && valueTuple2.Item2 < valueTuple.Item2 + valueTuple.Item3;
							bool flag2 = valueTuple.Item1 >= valueTuple2.Item1 && valueTuple.Item1 < valueTuple2.Item1 + valueTuple2.Item3;
							if (flag && flag2 && this.ClassifyLT(valueTuple, valueTuple2) == shape)
							{
								this.UsedH.Add(i);
								this.UsedV.Add(j);
								result.Add(this.BuildLTSequence(board, valueTuple, valueTuple2));
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06035B1C RID: 219932 RVA: 0x00F01944 File Offset: 0x00EFFB44
		private ItemSequence BuildLineSequence(Board board, int row, int col, int len, bool isHorizontal)
		{
			ItemSequence result = new ItemSequence
			{
				Type = board.GetPiece(row, col).Type
			};
			if (isHorizontal)
			{
				result.HStartRow = row;
				result.HStartCol = col;
				result.HLen = len;
				result.CenterRow = row;
				result.CenterCol = col + (len - 1) / 2;
			}
			else
			{
				result.VStartRow = row;
				result.VStartCol = col;
				result.VLen = len;
				result.CenterRow = row + (len - 1) / 2;
				result.CenterCol = col;
			}
			result.Shape = this.ClassifyLineShape(len);
			return result;
		}

		// Token: 0x06035B1D RID: 219933 RVA: 0x00F019E8 File Offset: 0x00EFFBE8
		[NullableContext(0)]
		private ItemSequence BuildLTSequence([Nullable(1)] Board board, [TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})] ValueTuple<int, int, int> h, [TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})] ValueTuple<int, int, int> v)
		{
			return new ItemSequence
			{
				Type = board.GetPiece(h.Item1, h.Item2).Type,
				HStartRow = h.Item1,
				HStartCol = h.Item2,
				HLen = h.Item3,
				VStartRow = v.Item1,
				VStartCol = v.Item2,
				VLen = v.Item3,
				CenterRow = h.Item1,
				CenterCol = v.Item2,
				Shape = this.ClassifyLT(h, v)
			};
		}

		// Token: 0x06035B1E RID: 219934 RVA: 0x00F01A94 File Offset: 0x00EFFC94
		[NullableContext(0)]
		private EMatchShape ClassifyLT([TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})] ValueTuple<int, int, int> h, [TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})] ValueTuple<int, int, int> v)
		{
			bool flag = v.Item2 == h.Item2 || v.Item2 == h.Item2 + h.Item3 - 1;
			bool flag2 = h.Item1 == v.Item1 || h.Item1 == v.Item1 + v.Item3 - 1;
			if (!flag || !flag2)
			{
				return EMatchShape.T;
			}
			return EMatchShape.L;
		}

		// Token: 0x06035B1F RID: 219935 RVA: 0x00F01AF9 File Offset: 0x00EFFCF9
		private EMatchShape ClassifyLineShape(int len)
		{
			if (len >= 5)
			{
				return EMatchShape.Line5;
			}
			if (len == 4)
			{
				return EMatchShape.Line4;
			}
			return EMatchShape.Line3;
		}

		// Token: 0x06035B20 RID: 219936 RVA: 0x00F01B08 File Offset: 0x00EFFD08
		public bool HasAnyValidMove(Board board)
		{
			return this.ScanValidMoves(board, null);
		}

		// Token: 0x06035B21 RID: 219937 RVA: 0x00F01B12 File Offset: 0x00EFFD12
		public void CollectValidMoves(Board board, List<ValidMove> buffer)
		{
			buffer.Clear();
			this.ScanValidMoves(board, buffer);
		}

		// Token: 0x06035B22 RID: 219938 RVA: 0x00F01B24 File Offset: 0x00EFFD24
		private bool ScanValidMoves(Board board, [Nullable(2)] List<ValidMove> buffer)
		{
			bool result = false;
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = board.GetPiece(i, j);
					if (piece != null && piece.Has(EPieceCaps.Swappable))
					{
						if (j + 1 < 8 && this.TrySwapMakesMatch(board, piece, i, j, i, j + 1))
						{
							if (buffer == null)
							{
								return true;
							}
							buffer.Add(new ValidMove(new GridPosition(i, j), new GridPosition(i, j + 1)));
							result = true;
						}
						if (i + 1 < 7 && this.TrySwapMakesMatch(board, piece, i, j, i + 1, j))
						{
							if (buffer == null)
							{
								return true;
							}
							buffer.Add(new ValidMove(new GridPosition(i, j), new GridPosition(i + 1, j)));
							result = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06035B23 RID: 219939 RVA: 0x00F01BE0 File Offset: 0x00EFFDE0
		private bool TrySwapMakesMatch(Board board, Piece pa, int r1, int c1, int r2, int c2)
		{
			Piece piece = board.GetPiece(r2, c2);
			if (piece == null || !piece.Has(EPieceCaps.Swappable))
			{
				return false;
			}
			if (pa.Has(EPieceCaps.SwapEffect) || piece.Has(EPieceCaps.SwapEffect))
			{
				Piece piece2 = pa.Has(EPieceCaps.SwapEffect) ? pa : piece;
				Piece other = pa.Has(EPieceCaps.SwapEffect) ? piece : pa;
				foreach (IPieceComponent pieceComponent in piece2.Components)
				{
					ISwapEffectBehavior swapEffectBehavior = pieceComponent as ISwapEffectBehavior;
					if (swapEffectBehavior != null && swapEffectBehavior.CanSwapWith(other))
					{
						return true;
					}
				}
			}
			if (pa.IsMatchable && piece.IsMatchable && pa.Type == piece.Type)
			{
				return false;
			}
			GridPosition a = new GridPosition(r1, c1);
			GridPosition b = new GridPosition(r2, c2);
			board.SwapPiece(a, b);
			bool result = this.HasMatchAt(board, r1, c1) || this.HasMatchAt(board, r2, c2);
			board.SwapPiece(a, b);
			return result;
		}

		// Token: 0x06035B24 RID: 219940 RVA: 0x00F01D00 File Offset: 0x00EFFF00
		public bool HasMatchAt(Board board, int r, int c, EPieceType type)
		{
			return this.WouldFormLineAt(board, r, c, type, true) || this.WouldFormLineAt(board, r, c, type, false);
		}

		// Token: 0x06035B25 RID: 219941 RVA: 0x00F01D20 File Offset: 0x00EFFF20
		private bool HasMatchAt(Board board, int r, int c)
		{
			EPieceType type;
			return this.TryMatchType(board, r, c, out type) && this.HasMatchAt(board, r, c, type);
		}

		// Token: 0x06035B26 RID: 219942 RVA: 0x00F01D48 File Offset: 0x00EFFF48
		public bool WouldFormLineAt(Board board, int row, int col, EPieceType type, bool horizontal)
		{
			int num = 1;
			if (horizontal)
			{
				int num2 = col - 1;
				while (num2 >= 0 && this.SameMatch(board, row, num2, type))
				{
					num++;
					num2--;
				}
				for (int i = col + 1; i < 8; i++)
				{
					if (!this.SameMatch(board, row, i, type))
					{
						break;
					}
					num++;
				}
			}
			else
			{
				int num3 = row - 1;
				while (num3 >= 0 && this.SameMatch(board, num3, col, type))
				{
					num++;
					num3--;
				}
				int num4 = row + 1;
				while (num4 < 7 && this.SameMatch(board, num4, col, type))
				{
					num++;
					num4++;
				}
			}
			return num >= 3;
		}

		// Token: 0x0401C66A RID: 116330
		private const int MinMatch = 3;

		// Token: 0x0401C66B RID: 116331
		[TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int, int>> HRuns = new List<ValueTuple<int, int, int>>();

		// Token: 0x0401C66C RID: 116332
		[TupleElementNames(new string[]
		{
			"Row",
			"Col",
			"Len"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int, int>> VRuns = new List<ValueTuple<int, int, int>>();

		// Token: 0x0401C66D RID: 116333
		private readonly HashSet<int> UsedH = new HashSet<int>();

		// Token: 0x0401C66E RID: 116334
		private readonly HashSet<int> UsedV = new HashSet<int>();
	}
}
