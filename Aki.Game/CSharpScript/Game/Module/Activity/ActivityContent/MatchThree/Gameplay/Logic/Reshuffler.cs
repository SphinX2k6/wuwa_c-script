using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005475 RID: 21621
	[NullableContext(1)]
	[Nullable(0)]
	public class Reshuffler
	{
		// Token: 0x06035B08 RID: 219912 RVA: 0x00F0109C File Offset: 0x00EFF29C
		public Reshuffler(SequenceDetector detector, GameRandom rng)
		{
		}

		// Token: 0x06035B09 RID: 219913 RVA: 0x00F010F4 File Offset: 0x00EFF2F4
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

		// Token: 0x06035B0A RID: 219914 RVA: 0x00F012A0 File Offset: 0x00EFF4A0
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

		// Token: 0x06035B0B RID: 219915 RVA: 0x00F013F6 File Offset: 0x00EFF5F6
		private bool IsSafe(Board board, int r, int c, Piece piece)
		{
			return !piece.IsMatchable || !this.Detector.HasMatchAt(board, r, c, piece.Type);
		}

		// Token: 0x0401C65F RID: 116319
		private const int MAX_ATTEMPTS = 20;

		// Token: 0x0401C660 RID: 116320
		private readonly SequenceDetector Detector = detector;

		// Token: 0x0401C661 RID: 116321
		private readonly GameRandom Rng = rng;

		// Token: 0x0401C662 RID: 116322
		private readonly ReshuffleJob ReshuffleJob = new ReshuffleJob();

		// Token: 0x0401C663 RID: 116323
		private readonly List<IJob> Jobs = new List<IJob>();

		// Token: 0x0401C664 RID: 116324
		public bool LastLayoutFailed;

		// Token: 0x0401C665 RID: 116325
		private readonly List<GridPosition> Slots = new List<GridPosition>();

		// Token: 0x0401C666 RID: 116326
		private readonly List<Piece> Pieces = new List<Piece>();

		// Token: 0x0401C667 RID: 116327
		private readonly List<Piece> Pool = new List<Piece>();
	}
}
