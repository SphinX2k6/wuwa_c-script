using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F1 RID: 25841
	[NullableContext(1)]
	[Nullable(0)]
	public class BoardFillStrategy
	{
		// Token: 0x06040DB2 RID: 265650 RVA: 0x00FB5F68 File Offset: 0x00FB4168
		public BoardFillStrategy(SequenceDetector detector, [Nullable(2)] int[] fillRuleIds, GameRandom rng)
		{
			this.Detector = detector;
			this.RuleIds = fillRuleIds;
			this.Rng = rng;
			this.ActivePool = this.DefaultPool;
		}

		// Token: 0x06040DB3 RID: 265651 RVA: 0x00FB6038 File Offset: 0x00FB4238
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

		// Token: 0x06040DB4 RID: 265652 RVA: 0x00FB622C File Offset: 0x00FB442C
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

		// Token: 0x06040DB5 RID: 265653 RVA: 0x00FB626A File Offset: 0x00FB446A
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

		// Token: 0x06040DB6 RID: 265654 RVA: 0x00FB6293 File Offset: 0x00FB4493
		public void Reset()
		{
			this.NoCascadeStreak = 0;
			this.ActivePool = this.DefaultPool;
		}

		// Token: 0x06040DB7 RID: 265655 RVA: 0x00FB62A8 File Offset: 0x00FB44A8
		private bool RollEliminate(in BoardFillStrategy.FillRule rule)
		{
			float num = rule.EliminateProb + rule.RandomProb;
			return num > 0f && this.Rng.NextDouble() * (double)num < (double)rule.EliminateProb;
		}

		// Token: 0x06040DB8 RID: 265656 RVA: 0x00FB62E4 File Offset: 0x00FB44E4
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

		// Token: 0x06040DB9 RID: 265657 RVA: 0x00FB6390 File Offset: 0x00FB4590
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

		// Token: 0x06040DBA RID: 265658 RVA: 0x00FB643C File Offset: 0x00FB463C
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

		// Token: 0x06040DBB RID: 265659 RVA: 0x00FB6480 File Offset: 0x00FB4680
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

		// Token: 0x06040DBC RID: 265660 RVA: 0x00FB64C4 File Offset: 0x00FB46C4
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

		// Token: 0x06040DBD RID: 265661 RVA: 0x00FB6500 File Offset: 0x00FB4700
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

		// Token: 0x06040DBE RID: 265662 RVA: 0x00FB6554 File Offset: 0x00FB4754
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

		// Token: 0x06040DBF RID: 265663 RVA: 0x00FB65A0 File Offset: 0x00FB47A0
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

		// Token: 0x06040DC0 RID: 265664 RVA: 0x00FB6600 File Offset: 0x00FB4800
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

		// Token: 0x06040DC1 RID: 265665 RVA: 0x00FB665C File Offset: 0x00FB485C
		private void MarkFillSlots()
		{
			for (int i = 0; i < this.IsFillSlot.Length; i++)
			{
				this.IsFillSlot[i] = (this.Occ[i] != 0 && this.Occupant[i] == null);
			}
		}

		// Token: 0x06040DC2 RID: 265666 RVA: 0x00FB669C File Offset: 0x00FB489C
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

		// Token: 0x06040DC3 RID: 265667 RVA: 0x00FB6708 File Offset: 0x00FB4908
		private void CopyWay(int from, int to)
		{
			int num = this.WayCount[from];
			Array.Copy(this.WayRow, from * 6, this.WayRow, to * 6, num);
			Array.Copy(this.WayCol, from * 6, this.WayCol, to * 6, num);
			this.WayCount[to] = num;
			this.WayCount[from] = 0;
		}

		// Token: 0x06040DC4 RID: 265668 RVA: 0x00FB6760 File Offset: 0x00FB4960
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

		// Token: 0x06040DC5 RID: 265669 RVA: 0x00FB679C File Offset: 0x00FB499C
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

		// Token: 0x06040DC6 RID: 265670 RVA: 0x00FB6864 File Offset: 0x00FB4A64
		private void EmitWay(int idx, Piece piece, List<PieceMoveEvent> moves)
		{
			int num = idx * 6;
			for (int i = 1; i < this.WayCount[idx]; i++)
			{
				moves.Add(new PieceMoveEvent(this.WayCol[num + i - 1], this.WayCol[num + i], this.WayRow[num + i - 1], this.WayRow[num + i], piece));
			}
		}

		// Token: 0x06040DC7 RID: 265671 RVA: 0x00FB68C0 File Offset: 0x00FB4AC0
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

		// Token: 0x06040DC8 RID: 265672 RVA: 0x00FB6918 File Offset: 0x00FB4B18
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

		// Token: 0x06040DC9 RID: 265673 RVA: 0x00FB69B4 File Offset: 0x00FB4BB4
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

		// Token: 0x06040DCA RID: 265674 RVA: 0x00FB6A1E File Offset: 0x00FB4C1E
		private EPieceType NextSpawnType()
		{
			return this.ActivePool[this.Rng.Next(this.ActivePool.Length)];
		}

		// Token: 0x04021CA8 RID: 138408
		private const int Rows = 7;

		// Token: 0x04021CA9 RID: 138409
		private const int Cols = 8;

		// Token: 0x04021CAA RID: 138410
		private const byte OccEmpty = 0;

		// Token: 0x04021CAB RID: 138411
		private const byte OccBlock = 1;

		// Token: 0x04021CAC RID: 138412
		private const byte OccFixed = 2;

		// Token: 0x04021CAD RID: 138413
		private const byte OccMove = 3;

		// Token: 0x04021CAE RID: 138414
		private const int MaxWay = 6;

		// Token: 0x04021CAF RID: 138415
		private const int ScanSealed = -1;

		// Token: 0x04021CB0 RID: 138416
		private const int ScanOpenTop = -2;

		// Token: 0x04021CB1 RID: 138417
		private readonly SequenceDetector Detector;

		// Token: 0x04021CB2 RID: 138418
		private readonly GameRandom Rng;

		// Token: 0x04021CB3 RID: 138419
		private readonly bool[] IsFillSlot = new bool[56];

		// Token: 0x04021CB4 RID: 138420
		private readonly bool[] Decided = new bool[56];

		// Token: 0x04021CB5 RID: 138421
		private readonly EPieceType[] SlotColor = new EPieceType[56];

		// Token: 0x04021CB6 RID: 138422
		private readonly byte[] Occ = new byte[56];

		// Token: 0x04021CB7 RID: 138423
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Piece[] Occupant = new Piece[56];

		// Token: 0x04021CB8 RID: 138424
		private readonly int[] WayCount = new int[56];

		// Token: 0x04021CB9 RID: 138425
		private readonly int[] WayRow = new int[336];

		// Token: 0x04021CBA RID: 138426
		private readonly int[] WayCol = new int[336];

		// Token: 0x04021CBB RID: 138427
		private readonly int[] SpawnCount = new int[8];

		// Token: 0x04021CBC RID: 138428
		private readonly EPieceType[] DefaultPool = new EPieceType[]
		{
			EPieceType.Red,
			EPieceType.Yellow,
			EPieceType.Blue,
			EPieceType.Green,
			EPieceType.Purple
		};

		// Token: 0x04021CBD RID: 138429
		[Nullable(2)]
		private readonly int[] RuleIds;

		// Token: 0x04021CBE RID: 138430
		private bool ConfigLoaded;

		// Token: 0x04021CBF RID: 138431
		private BoardFillStrategy.FillRule[] Rules = Array.Empty<BoardFillStrategy.FillRule>();

		// Token: 0x04021CC0 RID: 138432
		private EPieceType[] ActivePool;

		// Token: 0x04021CC1 RID: 138433
		private int NoCascadeStreak;

		// Token: 0x0200C729 RID: 50985
		[Nullable(0)]
		private readonly struct FillRule
		{
			// Token: 0x06050EA4 RID: 331428 RVA: 0x015DEBD2 File Offset: 0x015DCDD2
			public FillRule(int count, float eliminateProb, float randomProb, EPieceType[] pool)
			{
				this.Count = count;
				this.EliminateProb = eliminateProb;
				this.RandomProb = randomProb;
				this.Pool = pool;
			}

			// Token: 0x0403C2B3 RID: 246451
			public readonly int Count;

			// Token: 0x0403C2B4 RID: 246452
			public readonly float EliminateProb;

			// Token: 0x0403C2B5 RID: 246453
			public readonly float RandomProb;

			// Token: 0x0403C2B6 RID: 246454
			public readonly EPieceType[] Pool;
		}
	}
}
