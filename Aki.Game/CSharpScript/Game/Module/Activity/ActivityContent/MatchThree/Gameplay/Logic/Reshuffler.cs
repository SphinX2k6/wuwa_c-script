using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F7 RID: 25847
	[NullableContext(1)]
	[Nullable(0)]
	public class Reshuffler
	{
		// Token: 0x06040E44 RID: 265796 RVA: 0x00FBA06C File Offset: 0x00FB826C
		public Reshuffler(SequenceDetector detector, GameRandom rng)
		{
		}

		// Token: 0x06040E45 RID: 265797 RVA: 0x00FBA0C4 File Offset: 0x00FB82C4
		public unsafe List<IJob> Reshuffle(Board board)
		{
			this.Slots.Clear();
			this.Pieces.Clear();
			this.LastLayoutFailed = true;
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = board.GetPiece(i, j);
					if (piece != null && MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type) && !piece.Has(EPieceCaps.Block))
					{
						this.Slots.Add(new GridPosition(i, j));
						this.Pieces.Add(piece);
					}
				}
			}
			int k;
			for (k = 0; k < 20; k++)
			{
				if (this.TryFillOnce(board) && this.Detector.HasAnyValidMove(board))
				{
					this.LastLayoutFailed = false;
					break;
				}
			}
			this.Jobs.Clear();
			if (!this.LastLayoutFailed)
			{
				this.Jobs.Add(this.ReshuffleJob);
				return this.Jobs;
			}
			for (int l = 0; l < this.Slots.Count; l++)
			{
				board.SetPiece(this.Slots[l].Row, this.Slots[l].Col, this.Pieces[l]);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MatchThree;
			ELogAuthor author = ELogAuthor.CB;
			string message = "[Reshuffle] 重试耗尽未凑出可玩排布，放弃重排并还原盘面";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("棋子数", this.Pieces.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("尝试次数", k);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return this.Jobs;
		}

		// Token: 0x06040E46 RID: 265798 RVA: 0x00FBA270 File Offset: 0x00FB8470
		private bool TryFillOnce(Board board)
		{
			this.Pool.Clear();
			this.Pool.AddRange(this.Pieces);
			for (int i = 0; i < this.Slots.Count; i++)
			{
				board.SetPiece(this.Slots[i].Row, this.Slots[i].Col, null);
			}
			bool flag = true;
			for (int j = 0; j < this.Slots.Count; j++)
			{
				GridPosition gridPosition = this.Slots[j];
				int count = this.Pool.Count;
				int num = this.Rng.Next(count);
				int index = num;
				bool flag2 = false;
				for (int k = 0; k < count; k++)
				{
					int num2 = num + k;
					if (num2 >= count)
					{
						num2 -= count;
					}
					if (this.IsSafe(board, gridPosition.Row, gridPosition.Col, this.Pool[num2]))
					{
						index = num2;
						flag2 = true;
						break;
					}
				}
				flag = (flag && flag2);
				board.SetPiece(gridPosition.Row, gridPosition.Col, this.Pool[index]);
				this.Pool[index] = this.Pool[count - 1];
				this.Pool.RemoveAt(count - 1);
			}
			return flag;
		}

		// Token: 0x06040E47 RID: 265799 RVA: 0x00FBA3C6 File Offset: 0x00FB85C6
		private bool IsSafe(Board board, int r, int c, Piece piece)
		{
			return !piece.IsMatchable || !this.Detector.HasMatchAt(board, r, c, piece.Type);
		}

		// Token: 0x04021D2E RID: 138542
		private const int MAX_ATTEMPTS = 20;

		// Token: 0x04021D2F RID: 138543
		private readonly SequenceDetector Detector = detector;

		// Token: 0x04021D30 RID: 138544
		private readonly GameRandom Rng = rng;

		// Token: 0x04021D31 RID: 138545
		private readonly ReshuffleJob ReshuffleJob = new ReshuffleJob();

		// Token: 0x04021D32 RID: 138546
		private readonly List<IJob> Jobs = new List<IJob>();

		// Token: 0x04021D33 RID: 138547
		public bool LastLayoutFailed;

		// Token: 0x04021D34 RID: 138548
		private readonly List<GridPosition> Slots = new List<GridPosition>();

		// Token: 0x04021D35 RID: 138549
		private readonly List<Piece> Pieces = new List<Piece>();

		// Token: 0x04021D36 RID: 138550
		private readonly List<Piece> Pool = new List<Piece>();
	}
}
