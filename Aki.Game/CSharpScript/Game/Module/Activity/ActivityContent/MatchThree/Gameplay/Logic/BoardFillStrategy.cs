using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200546F RID: 21615
	[NullableContext(1)]
	[Nullable(0)]
	public class BoardFillStrategy
	{
		// Token: 0x06035A76 RID: 219766 RVA: 0x00EFCF98 File Offset: 0x00EFB198
		public BoardFillStrategy(SequenceDetector detector, [Nullable(2)] int[] fillRuleIds, GameRandom rng)
		{
			this.Detector = detector;
			this.RuleIds = fillRuleIds;
			this.Rng = rng;
			this.ActivePool = this.DefaultPool;
		}

		// Token: 0x06035A77 RID: 219767 RVA: 0x00EFD068 File Offset: 0x00EFB268
		private unsafe void EnsureConfigLoaded()
		{
			if (this.ConfigLoaded)
			{
				return;
			}
			this.ConfigLoaded = true;
			if (this.RuleIds == null || this.RuleIds.Length == 0)
			{
				return;
			}
			List<BoardFillStrategy.FillRule> list = new List<BoardFillStrategy.FillRule>(this.RuleIds.Length);
			foreach (int num in this.RuleIds)
			{
				MatchThreeFillRules? fillRulesConfig = MatchThreeConfig.Instance.GetFillRulesConfig(num);
				if (fillRulesConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.CB;
					string message = "填充规则配置缺失: MatchThreeFillRules";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (fillRulesConfig.Value.Count <= 0)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.MatchThree;
					ELogAuthor author2 = ELogAuthor.CB;
					string message2 = "填充规则 Count 非法（须 >0），跳过该档";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Count", fillRulesConfig.Value.Count);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					EPieceType[] array = this.DefaultPool;
					int[] poolArray = fillRulesConfig.Value.GetPoolArray();
					if (poolArray != null && poolArray.Length > 0)
					{
						array = new EPieceType[poolArray.Length];
						for (int j = 0; j < poolArray.Length; j++)
						{
							array[j] = (EPieceType)poolArray[j];
						}
					}
					list.Add(new BoardFillStrategy.FillRule(fillRulesConfig.Value.Count, fillRulesConfig.Value.EliminateProbability, fillRulesConfig.Value.RandomProbability, array));
				}
			}
			list.Sort((BoardFillStrategy.FillRule x, BoardFillStrategy.FillRule y) => x.Count.CompareTo(y.Count));
			this.Rules = list.ToArray();
		}

		// Token: 0x06035A78 RID: 219768 RVA: 0x00EFD25C File Offset: 0x00EFB45C
		private int SelectRuleIndex()
		{
			for (int i = this.Rules.Length - 1; i >= 0; i--)
			{
				if (this.NoCascadeStreak >= this.Rules[i].Count)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06035A79 RID: 219769 RVA: 0x00EFD29A File Offset: 0x00EFB49A
		public void NotifyTurnResolved(bool hadCascade)
		{
			if (hadCascade)
			{
				this.NoCascadeStreak = 0;
			}
			else
			{
				this.NoCascadeStreak++;
			}
			this.EnsureConfigLoaded();
			this.SelectRuleIndex();
		}

		// Token: 0x06035A7A RID: 219770 RVA: 0x00EFD2C3 File Offset: 0x00EFB4C3
		public void Reset()
		{
			this.NoCascadeStreak = 0;
			this.ActivePool = this.DefaultPool;
		}

		// Token: 0x06035A7B RID: 219771 RVA: 0x00EFD2D8 File Offset: 0x00EFB4D8
		private bool RollEliminate(in BoardFillStrategy.FillRule rule)
		{
			float num = rule.EliminateProb + rule.RandomProb;
			return num > 0f && this.Rng.NextDouble() * (double)num < (double)rule.EliminateProb;
		}

		// Token: 0x06035A7C RID: 219772 RVA: 0x00EFD314 File Offset: 0x00EFB514
		public int RefillDirtyColumns(Board board, HashSet<int> dirtyCols, List<PieceMoveEvent> moves, List<int> landedCols)
		{
			this.EnsureConfigLoaded();
			Array.Clear(this.Decided, 0, this.Decided.Length);
			Array.Clear(this.SpawnCount, 0, this.SpawnCount.Length);
			this.LoadShadow(board);
			this.SettleShadow();
			this.MarkFillSlots();
			this.WriteBackExisting(board);
			int num = this.SelectRuleIndex();
			this.ActivePool = ((num >= 0) ? this.Rules[num].Pool : this.DefaultPool);
			if (num >= 0 && this.RollEliminate(this.Rules[num]))
			{
				this.TryPitySeed(board);
			}
			return this.CommitShadow(board, dirtyCols, moves, landedCols);
		}

		// Token: 0x06035A7D RID: 219773 RVA: 0x00EFD3C0 File Offset: 0x00EFB5C0
		private void LoadShadow(Board board)
		{
			Array.Clear(this.Occ, 0, this.Occ.Length);
			Array.Clear(this.Occupant, 0, this.Occupant.Length);
			Array.Clear(this.WayCount, 0, this.WayCount.Length);
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = board.GetPiece(i, j);
					if (piece != null)
					{
						int num = i * 8 + j;
						this.Occ[num] = (piece.Has(EPieceCaps.Block) ? 1 : (piece.Has(EPieceCaps.Fallable) ? 3 : 2));
						this.Occupant[num] = piece;
						this.PushWay(num, i, j);
					}
				}
			}
		}

		// Token: 0x06035A7E RID: 219774 RVA: 0x00EFD46C File Offset: 0x00EFB66C
		private void SettleShadow()
		{
			bool flag;
			do
			{
				flag = false;
				for (int i = 6; i >= 0; i--)
				{
					for (int j = 0; j < 8; j++)
					{
						if (this.Occ[i * 8 + j] == 0 && this.PullInto(i, j))
						{
							flag = true;
						}
					}
				}
			}
			while (flag);
		}

		// Token: 0x06035A7F RID: 219775 RVA: 0x00EFD4B0 File Offset: 0x00EFB6B0
		private bool PullInto(int r, int c)
		{
			int num2;
			int num = this.ScanUp(r, c, out num2);
			if (num >= 0)
			{
				this.MoveInShadow(num, c, r, c);
				return true;
			}
			if (num == -2)
			{
				this.SpawnInto(r, c);
				return true;
			}
			return this.TryDiagonalInto(num2 + 1, r, c);
		}

		// Token: 0x06035A80 RID: 219776 RVA: 0x00EFD4F4 File Offset: 0x00EFB6F4
		private int ScanUp(int r, int c, out int blockRow)
		{
			blockRow = -1;
			for (int i = r - 1; i >= 0; i--)
			{
				byte b = this.Occ[i * 8 + c];
				if (b == 1)
				{
					blockRow = i;
					return -1;
				}
				if (b == 3)
				{
					return i;
				}
			}
			return -2;
		}

		// Token: 0x06035A81 RID: 219777 RVA: 0x00EFD530 File Offset: 0x00EFB730
		private bool TryDiagonalInto(int startRow, int endRow, int c)
		{
			if (startRow <= 0 || endRow >= 7 || startRow > endRow)
			{
				return false;
			}
			for (int i = startRow; i <= endRow; i++)
			{
				if (this.Occ[i * 8 + c] != 0)
				{
					return false;
				}
				if (this.TryDiagonalFrom(i, c, c - 1) || this.TryDiagonalFrom(i, c, c + 1))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035A82 RID: 219778 RVA: 0x00EFD584 File Offset: 0x00EFB784
		private bool TryDiagonalFrom(int r, int c, int srcCol)
		{
			if (srcCol < 0 || srcCol >= 8)
			{
				return false;
			}
			int num = (r - 1) * 8 + srcCol;
			if (this.Occ[num] != 3)
			{
				return false;
			}
			if (this.Occ[r * 8 + srcCol] == 0)
			{
				return false;
			}
			this.MoveInShadow(r - 1, srcCol, r, c);
			return true;
		}

		// Token: 0x06035A83 RID: 219779 RVA: 0x00EFD5D0 File Offset: 0x00EFB7D0
		private void MoveInShadow(int fromRow, int fromCol, int toRow, int toCol)
		{
			int num = fromRow * 8 + fromCol;
			int num2 = toRow * 8 + toCol;
			this.Occ[num2] = this.Occ[num];
			this.Occupant[num2] = this.Occupant[num];
			this.Occ[num] = 0;
			this.Occupant[num] = null;
			this.CopyWay(num, num2);
			this.PushWay(num2, toRow, toCol);
		}

		// Token: 0x06035A84 RID: 219780 RVA: 0x00EFD630 File Offset: 0x00EFB830
		private void SpawnInto(int r, int c)
		{
			int num = r * 8 + c;
			this.Occ[num] = 3;
			this.Occupant[num] = null;
			this.WayCount[num] = 0;
			this.PushWay(num, -1 - this.SpawnCount[c], c);
			this.SpawnCount[c]++;
			this.PushWay(num, r, c);
		}

		// Token: 0x06035A85 RID: 219781 RVA: 0x00EFD68C File Offset: 0x00EFB88C
		private void MarkFillSlots()
		{
			for (int i = 0; i < this.IsFillSlot.Length; i++)
			{
				this.IsFillSlot[i] = (this.Occ[i] != 0 && this.Occupant[i] == null);
			}
		}

		// Token: 0x06035A86 RID: 219782 RVA: 0x00EFD6CC File Offset: 0x00EFB8CC
		private void PushWay(int idx, int row, int col)
		{
			int num = idx * 6;
			int num2 = this.WayCount[idx];
			if (num2 >= 2 && this.WayCol[num + num2 - 1] == col && this.WayCol[num + num2 - 2] == col)
			{
				num2--;
			}
			else if (num2 >= 6)
			{
				num2 = 5;
			}
			this.WayRow[num + num2] = row;
			this.WayCol[num + num2] = col;
			this.WayCount[idx] = num2 + 1;
		}

		// Token: 0x06035A87 RID: 219783 RVA: 0x00EFD738 File Offset: 0x00EFB938
		private void CopyWay(int from, int to)
		{
			int num = this.WayCount[from];
			Array.Copy(this.WayRow, from * 6, this.WayRow, to * 6, num);
			Array.Copy(this.WayCol, from * 6, this.WayCol, to * 6, num);
			this.WayCount[to] = num;
			this.WayCount[from] = 0;
		}

		// Token: 0x06035A88 RID: 219784 RVA: 0x00EFD790 File Offset: 0x00EFB990
		private void WriteBackExisting(Board board)
		{
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					board.SetPiece(i, j, this.Occupant[i * 8 + j]);
				}
			}
		}

		// Token: 0x06035A89 RID: 219785 RVA: 0x00EFD7CC File Offset: 0x00EFB9CC
		private int CommitShadow(Board board, HashSet<int> dirtyCols, List<PieceMoveEvent> moves, List<int> landedCols)
		{
			int num = 0;
			int num2 = 6;
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int num3 = i * 8 + j;
					if (this.Occ[num3] != 0)
					{
						Piece piece = this.Occupant[num3];
						if (piece == null)
						{
							EPieceType type = this.Decided[num3] ? this.SlotColor[num3] : this.NextSpawnType();
							piece = board.RentPiece(type, null);
							board.SetPiece(i, j, piece);
						}
						if (this.WayCount[num3] > 1)
						{
							this.EmitWay(num3, piece, moves);
							dirtyCols.Add(j);
							if (i > num)
							{
								num = i;
							}
							if (i == num2 && !landedCols.Contains(j))
							{
								landedCols.Add(j);
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06035A8A RID: 219786 RVA: 0x00EFD894 File Offset: 0x00EFBA94
		private void EmitWay(int idx, Piece piece, List<PieceMoveEvent> moves)
		{
			int num = idx * 6;
			for (int i = 1; i < this.WayCount[idx]; i++)
			{
				moves.Add(new PieceMoveEvent(this.WayCol[num + i - 1], this.WayCol[num + i], this.WayRow[num + i - 1], this.WayRow[num + i], piece));
			}
		}

		// Token: 0x06035A8B RID: 219787 RVA: 0x00EFD8F0 File Offset: 0x00EFBAF0
		private void TryPitySeed(Board board)
		{
			bool flag = this.Rng.Next(2) == 0;
			bool outerReverse = this.Rng.Next(2) == 0;
			bool innerReverse = this.Rng.Next(2) == 0;
			if (this.SeedScan(board, flag, outerReverse, innerReverse))
			{
				return;
			}
			this.SeedScan(board, !flag, outerReverse, innerReverse);
		}

		// Token: 0x06035A8C RID: 219788 RVA: 0x00EFD948 File Offset: 0x00EFBB48
		private bool SeedScan(Board board, bool horizontalMatch, bool outerReverse, bool innerReverse)
		{
			if (horizontalMatch)
			{
				for (int i = 0; i < 7; i++)
				{
					int r = outerReverse ? (6 - i) : i;
					for (int j = 0; j < 8; j++)
					{
						int c = innerReverse ? (7 - j) : j;
						if (this.TrySeedCell(board, r, c, true))
						{
							return true;
						}
					}
				}
			}
			else
			{
				for (int k = 0; k < 8; k++)
				{
					int c2 = outerReverse ? (7 - k) : k;
					for (int l = 0; l < 7; l++)
					{
						int r2 = innerReverse ? (6 - l) : l;
						if (this.TrySeedCell(board, r2, c2, false))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06035A8D RID: 219789 RVA: 0x00EFD9E4 File Offset: 0x00EFBBE4
		private bool TrySeedCell(Board board, int r, int c, bool horizontal)
		{
			int num = r * 8 + c;
			if (!this.IsFillSlot[num] || this.Decided[num])
			{
				return false;
			}
			foreach (EPieceType epieceType in this.ActivePool)
			{
				if (this.Detector.WouldFormLineAt(board, r, c, epieceType, horizontal))
				{
					this.SlotColor[num] = epieceType;
					this.Decided[num] = true;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035A8E RID: 219790 RVA: 0x00EFDA4E File Offset: 0x00EFBC4E
		private EPieceType NextSpawnType()
		{
			return this.ActivePool[this.Rng.Next(this.ActivePool.Length)];
		}

		// Token: 0x0401C5D9 RID: 116185
		private const int Rows = 7;

		// Token: 0x0401C5DA RID: 116186
		private const int Cols = 8;

		// Token: 0x0401C5DB RID: 116187
		private const byte OccEmpty = 0;

		// Token: 0x0401C5DC RID: 116188
		private const byte OccBlock = 1;

		// Token: 0x0401C5DD RID: 116189
		private const byte OccFixed = 2;

		// Token: 0x0401C5DE RID: 116190
		private const byte OccMove = 3;

		// Token: 0x0401C5DF RID: 116191
		private const int MaxWay = 6;

		// Token: 0x0401C5E0 RID: 116192
		private const int ScanSealed = -1;

		// Token: 0x0401C5E1 RID: 116193
		private const int ScanOpenTop = -2;

		// Token: 0x0401C5E2 RID: 116194
		private readonly SequenceDetector Detector;

		// Token: 0x0401C5E3 RID: 116195
		private readonly GameRandom Rng;

		// Token: 0x0401C5E4 RID: 116196
		private readonly bool[] IsFillSlot = new bool[56];

		// Token: 0x0401C5E5 RID: 116197
		private readonly bool[] Decided = new bool[56];

		// Token: 0x0401C5E6 RID: 116198
		private readonly EPieceType[] SlotColor = new EPieceType[56];

		// Token: 0x0401C5E7 RID: 116199
		private readonly byte[] Occ = new byte[56];

		// Token: 0x0401C5E8 RID: 116200
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Piece[] Occupant = new Piece[56];

		// Token: 0x0401C5E9 RID: 116201
		private readonly int[] WayCount = new int[56];

		// Token: 0x0401C5EA RID: 116202
		private readonly int[] WayRow = new int[336];

		// Token: 0x0401C5EB RID: 116203
		private readonly int[] WayCol = new int[336];

		// Token: 0x0401C5EC RID: 116204
		private readonly int[] SpawnCount = new int[8];

		// Token: 0x0401C5ED RID: 116205
		private readonly EPieceType[] DefaultPool = new EPieceType[]
		{
			EPieceType.Red,
			EPieceType.Yellow,
			EPieceType.Blue,
			EPieceType.Green,
			EPieceType.Purple
		};

		// Token: 0x0401C5EE RID: 116206
		[Nullable(2)]
		private readonly int[] RuleIds;

		// Token: 0x0401C5EF RID: 116207
		private bool ConfigLoaded;

		// Token: 0x0401C5F0 RID: 116208
		private BoardFillStrategy.FillRule[] Rules = Array.Empty<BoardFillStrategy.FillRule>();

		// Token: 0x0401C5F1 RID: 116209
		private EPieceType[] ActivePool;

		// Token: 0x0401C5F2 RID: 116210
		private int NoCascadeStreak;

		// Token: 0x0200B10F RID: 45327
		[Nullable(0)]
		private readonly struct FillRule
		{
			// Token: 0x06047384 RID: 291716 RVA: 0x0159692E File Offset: 0x01594B2E
			public FillRule(int count, float eliminateProb, float randomProb, EPieceType[] pool)
			{
				this.Count = count;
				this.EliminateProb = eliminateProb;
				this.RandomProb = randomProb;
				this.Pool = pool;
			}

			// Token: 0x04036C0E RID: 224270
			public readonly int Count;

			// Token: 0x04036C0F RID: 224271
			public readonly float EliminateProb;

			// Token: 0x04036C10 RID: 224272
			public readonly float RandomProb;

			// Token: 0x04036C11 RID: 224273
			public readonly EPieceType[] Pool;
		}
	}
}
