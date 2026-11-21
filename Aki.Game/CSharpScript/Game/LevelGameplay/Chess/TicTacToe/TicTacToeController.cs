using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x020060BD RID: 24765
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeController
	{
		// Token: 0x0603B624 RID: 243236 RVA: 0x010CED4E File Offset: 0x010CCF4E
		public void Init(TicTacToeBoard board, ETicTacToeBoardContent camp)
		{
			this.ChessBoard = board;
			this.SelfCamp = camp;
		}

		// Token: 0x0603B625 RID: 243237 RVA: 0x010CED5E File Offset: 0x010CCF5E
		public virtual void OnStartRound()
		{
		}

		// Token: 0x0603B626 RID: 243238 RVA: 0x010CED60 File Offset: 0x010CCF60
		public virtual void OnStartGame()
		{
			this.SelectIndex = -1;
		}

		// Token: 0x17007064 RID: 28772
		// (get) Token: 0x0603B627 RID: 243239 RVA: 0x010CED69 File Offset: 0x010CCF69
		public bool IsSelecting
		{
			get
			{
				return this.SelectIndex > -1;
			}
		}

		// Token: 0x17007065 RID: 28773
		// (get) Token: 0x0603B628 RID: 243240 RVA: 0x010CED74 File Offset: 0x010CCF74
		public int SelectPieceIndex
		{
			get
			{
				return this.SelectIndex;
			}
		}

		// Token: 0x0603B629 RID: 243241 RVA: 0x010CED7C File Offset: 0x010CCF7C
		public bool SelectPiece(int index)
		{
			if (this.SelectIndex == index)
			{
				return true;
			}
			if (!this.ChessBoard.CheckPieceSelect(index, this.SelfCamp))
			{
				this.SelectIndex = -1;
				return false;
			}
			this.SelectIndex = index;
			return true;
		}

		// Token: 0x0603B62A RID: 243242 RVA: 0x010CEDAE File Offset: 0x010CCFAE
		public bool ResetSelectPiece(int index)
		{
			if (this.SelectIndex == index)
			{
				this.SelectIndex = -1;
				return true;
			}
			return false;
		}

		// Token: 0x0603B62B RID: 243243 RVA: 0x010CEDC3 File Offset: 0x010CCFC3
		public IReadOnlyList<int> GetSelectNeighbor()
		{
			return this.ChessBoard.GetNoneNeighbors(this.SelectIndex);
		}

		// Token: 0x0603B62C RID: 243244 RVA: 0x010CEDD6 File Offset: 0x010CCFD6
		public void RegisterEvent(Action<int, int> onPieceMove)
		{
			this.OnPieceMove = onPieceMove;
		}

		// Token: 0x0603B62D RID: 243245 RVA: 0x010CEDE0 File Offset: 0x010CCFE0
		public virtual bool MovePiece(int newIndex)
		{
			if (this.ChessBoard == null || !this.ChessBoard.CheckPieceMove(this.SelectIndex, newIndex, this.SelfCamp))
			{
				this.SelectIndex = -1;
				return false;
			}
			if (!this.ChessBoard.OnPieceMove(this.SelectIndex, newIndex))
			{
				this.SelectIndex = -1;
				return false;
			}
			if (this.OnPieceMove != null)
			{
				this.OnPieceMove(this.SelectIndex, newIndex);
			}
			this.SelectIndex = -1;
			return true;
		}

		// Token: 0x0603B62E RID: 243246 RVA: 0x010CEE57 File Offset: 0x010CD057
		public void OnResetGame()
		{
			this.OnStartGame();
		}

		// Token: 0x0401F4C4 RID: 128196
		protected ETicTacToeBoardContent SelfCamp = ETicTacToeBoardContent.White;

		// Token: 0x0401F4C5 RID: 128197
		protected int SelectIndex = -1;

		// Token: 0x0401F4C6 RID: 128198
		protected readonly int WinLineCount = 3;

		// Token: 0x0401F4C7 RID: 128199
		[Nullable(2)]
		protected TicTacToeBoard ChessBoard;

		// Token: 0x0401F4C8 RID: 128200
		[Nullable(2)]
		protected Action<int, int> OnPieceMove;
	}
}
