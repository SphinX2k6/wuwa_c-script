using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x02006F3C RID: 28476
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeController
	{
		// Token: 0x06045476 RID: 283766 RVA: 0x01124DA2 File Offset: 0x01122FA2
		public void Init(TicTacToeBoard board, ETicTacToeBoardContent camp)
		{
			this.ChessBoard = board;
			this.SelfCamp = camp;
		}

		// Token: 0x06045477 RID: 283767 RVA: 0x01124DB2 File Offset: 0x01122FB2
		public virtual void OnStartRound()
		{
		}

		// Token: 0x06045478 RID: 283768 RVA: 0x01124DB4 File Offset: 0x01122FB4
		public virtual void OnStartGame()
		{
			this.SelectIndex = -1;
		}

		// Token: 0x17009B25 RID: 39717
		// (get) Token: 0x06045479 RID: 283769 RVA: 0x01124DBD File Offset: 0x01122FBD
		public bool IsSelecting
		{
			get
			{
				return this.SelectIndex > -1;
			}
		}

		// Token: 0x17009B26 RID: 39718
		// (get) Token: 0x0604547A RID: 283770 RVA: 0x01124DC8 File Offset: 0x01122FC8
		public int SelectPieceIndex
		{
			get
			{
				return this.SelectIndex;
			}
		}

		// Token: 0x0604547B RID: 283771 RVA: 0x01124DD0 File Offset: 0x01122FD0
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

		// Token: 0x0604547C RID: 283772 RVA: 0x01124E02 File Offset: 0x01123002
		public bool ResetSelectPiece(int index)
		{
			if (this.SelectIndex == index)
			{
				this.SelectIndex = -1;
				return true;
			}
			return false;
		}

		// Token: 0x0604547D RID: 283773 RVA: 0x01124E17 File Offset: 0x01123017
		public IReadOnlyList<int> GetSelectNeighbor()
		{
			return this.ChessBoard.GetNoneNeighbors(this.SelectIndex);
		}

		// Token: 0x0604547E RID: 283774 RVA: 0x01124E2A File Offset: 0x0112302A
		public void RegisterEvent(Action<int, int> onPieceMove)
		{
			this.OnPieceMove = onPieceMove;
		}

		// Token: 0x0604547F RID: 283775 RVA: 0x01124E34 File Offset: 0x01123034
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

		// Token: 0x06045480 RID: 283776 RVA: 0x01124EAB File Offset: 0x011230AB
		public void OnResetGame()
		{
			this.OnStartGame();
		}

		// Token: 0x0402420F RID: 147983
		protected ETicTacToeBoardContent SelfCamp = ETicTacToeBoardContent.White;

		// Token: 0x04024210 RID: 147984
		protected int SelectIndex = -1;

		// Token: 0x04024211 RID: 147985
		protected readonly int WinLineCount = 3;

		// Token: 0x04024212 RID: 147986
		[Nullable(2)]
		protected TicTacToeBoard ChessBoard;

		// Token: 0x04024213 RID: 147987
		[Nullable(2)]
		protected Action<int, int> OnPieceMove;
	}
}
