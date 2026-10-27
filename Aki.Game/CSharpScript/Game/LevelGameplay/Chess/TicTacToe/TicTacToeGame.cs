using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.AIGearStrategy;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x02006F3D RID: 28477
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeGame
	{
		// Token: 0x06045482 RID: 283778 RVA: 0x01124ED0 File Offset: 0x011230D0
		public TicTacToeGame()
		{
			this.CurrentCamp = this.CampLoop[0];
		}

		// Token: 0x06045483 RID: 283779 RVA: 0x01124F44 File Offset: 0x01123144
		public void Init(bool isAiOffensive, Action<int, int> onPieceMove)
		{
			this.Board.Init(this.WinLineCount, new Action<ETicTacToeBoardContent>(this.OnGameOverCallback), new Action(this.OnEndRoundCallback));
			this.Controller.Init(this.Board, this.PlayerCamp);
			this.AiController.InitAi(this.Board, this.AiCamp, this.PlayerCamp);
			this.Controller.RegisterEvent(onPieceMove);
			this.AiController.RegisterEvent(onPieceMove);
			this.SetOffensive(isAiOffensive);
		}

		// Token: 0x06045484 RID: 283780 RVA: 0x01124FCD File Offset: 0x011231CD
		public void RefreshAiEnable(bool enable)
		{
			if (this.IsAiEnable != enable)
			{
				if (!this.IsAiEnable && this.CurrentCamp == this.AiCamp)
				{
					this.StartRound();
				}
				this.IsAiEnable = enable;
			}
		}

		// Token: 0x06045485 RID: 283781 RVA: 0x01124FFC File Offset: 0x011231FC
		public void StartRound()
		{
			if (this.CurrentCamp == this.PlayerCamp)
			{
				this.Controller.OnStartRound();
				return;
			}
			if (this.CurrentCamp == this.AiCamp)
			{
				if (this.IsAiEnable)
				{
					this.AiController.OnStartRound();
					return;
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.WLJ, "[TicTacToe]当前回合阵营错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06045486 RID: 283782 RVA: 0x01125061 File Offset: 0x01123261
		public bool OnIndexSelect(int index)
		{
			if (!this.Controller.IsSelecting)
			{
				return this.Controller.SelectPiece(index);
			}
			return this.Controller.ResetSelectPiece(index) || this.Controller.MovePiece(index);
		}

		// Token: 0x06045487 RID: 283783 RVA: 0x01125099 File Offset: 0x01123299
		public bool OnIndexMove(int oldIndex, int newIndex)
		{
			this.Controller.SelectPiece(oldIndex);
			return this.Controller.IsSelecting && this.Controller.MovePiece(newIndex);
		}

		// Token: 0x06045488 RID: 283784 RVA: 0x011250C4 File Offset: 0x011232C4
		public void NextRound()
		{
			this.CurrentRound++;
			int num = this.CampLoop.Length;
			this.CurrentCamp = this.CampLoop[this.CurrentRound % num];
			this.StartRound();
		}

		// Token: 0x06045489 RID: 283785 RVA: 0x01125104 File Offset: 0x01123304
		public void SetCurrentRound(int round)
		{
			this.CurrentRound = round;
			int num = this.CampLoop.Length;
			this.CurrentCamp = this.CampLoop[this.CurrentRound % num];
			this.WinCampInternal = ETicTacToeBoardContent.None;
			this.StartRound();
		}

		// Token: 0x17009B27 RID: 39719
		// (get) Token: 0x0604548A RID: 283786 RVA: 0x01125143 File Offset: 0x01123343
		public bool IsPlayerRound
		{
			get
			{
				return this.CurrentCamp == this.PlayerCamp;
			}
		}

		// Token: 0x17009B28 RID: 39720
		// (get) Token: 0x0604548B RID: 283787 RVA: 0x01125153 File Offset: 0x01123353
		public bool PlayerWin
		{
			get
			{
				return this.WinCampInternal == this.PlayerCamp;
			}
		}

		// Token: 0x17009B29 RID: 39721
		// (get) Token: 0x0604548C RID: 283788 RVA: 0x01125163 File Offset: 0x01123363
		public bool AiWin
		{
			get
			{
				return this.WinCampInternal == this.AiCamp;
			}
		}

		// Token: 0x17009B2A RID: 39722
		// (get) Token: 0x0604548D RID: 283789 RVA: 0x01125173 File Offset: 0x01123373
		public bool IsFinish
		{
			get
			{
				return this.WinCampInternal > ETicTacToeBoardContent.None;
			}
		}

		// Token: 0x0604548E RID: 283790 RVA: 0x0112517E File Offset: 0x0112337E
		public void StartGame()
		{
			this.CurrentRound = 0;
			this.CurrentCamp = this.CampLoop[0];
			this.WinCampInternal = ETicTacToeBoardContent.None;
			this.StartRound();
		}

		// Token: 0x0604548F RID: 283791 RVA: 0x011251A2 File Offset: 0x011233A2
		public void ResetGame()
		{
			this.Controller.OnResetGame();
			this.AiController.OnResetGame();
			this.Board.ResetGame();
			this.StartGame();
		}

		// Token: 0x06045490 RID: 283792 RVA: 0x011251CB File Offset: 0x011233CB
		protected void OnGameOver(ETicTacToeBoardContent winCamp)
		{
			this.WinCampInternal = winCamp;
		}

		// Token: 0x06045491 RID: 283793 RVA: 0x011251D4 File Offset: 0x011233D4
		protected void OnGameOverCallback(ETicTacToeBoardContent winCamp)
		{
			this.OnGameOver(winCamp);
		}

		// Token: 0x06045492 RID: 283794 RVA: 0x011251DD File Offset: 0x011233DD
		protected void OnEndRound()
		{
			if (this.AutoNextRound)
			{
				this.NextRound();
			}
		}

		// Token: 0x06045493 RID: 283795 RVA: 0x011251ED File Offset: 0x011233ED
		protected void OnEndRoundCallback()
		{
			this.OnEndRound();
		}

		// Token: 0x06045494 RID: 283796 RVA: 0x011251F5 File Offset: 0x011233F5
		public void RefreshAiInfo(BP_AIGearStrategy_C aiInfo)
		{
			this.AiController.RefreshAiInfo(aiInfo);
		}

		// Token: 0x06045495 RID: 283797 RVA: 0x01125204 File Offset: 0x01123404
		public void InitBoardInfo(IList<int> aiPieces, IList<int> playerPieces, bool initOriginBoardInfo = false)
		{
			ETicTacToeBoardContent[] array = new ETicTacToeBoardContent[this.Board.BoardLength * this.Board.BoardLength];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ETicTacToeBoardContent.None;
			}
			foreach (int num in aiPieces)
			{
				if (num < array.Length)
				{
					array[num] = this.AiCamp;
				}
			}
			foreach (int num2 in playerPieces)
			{
				if (num2 < array.Length)
				{
					array[num2] = this.PlayerCamp;
				}
			}
			if (initOriginBoardInfo)
			{
				this.Board.InitOriginBoardInfo(array);
				return;
			}
			this.Board.InitBoardInfo(array);
		}

		// Token: 0x06045496 RID: 283798 RVA: 0x011252E4 File Offset: 0x011234E4
		public int[] GetPlayerPieces()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			this.Board.GetBoardInfo(list2);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i] == (int)this.PlayerCamp)
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06045497 RID: 283799 RVA: 0x01125336 File Offset: 0x01123536
		public void SetOffensive(bool isAiOffensive)
		{
			ETicTacToeBoardContent[] campLoop;
			if (!isAiOffensive)
			{
				ETicTacToeBoardContent[] array = new ETicTacToeBoardContent[2];
				array[0] = this.PlayerCamp;
				campLoop = array;
				array[1] = this.AiCamp;
			}
			else
			{
				ETicTacToeBoardContent[] array2 = new ETicTacToeBoardContent[2];
				array2[0] = this.AiCamp;
				campLoop = array2;
				array2[1] = this.PlayerCamp;
			}
			this.CampLoop = campLoop;
		}

		// Token: 0x06045498 RID: 283800 RVA: 0x01125373 File Offset: 0x01123573
		public IReadOnlyList<int> GetNoneNeighbors(int selectIndex)
		{
			return this.Board.GetNoneNeighbors(selectIndex);
		}

		// Token: 0x06045499 RID: 283801 RVA: 0x01125381 File Offset: 0x01123581
		public bool CheckCanMove(int index)
		{
			return this.Board.CheckBoardValue(index, ETicTacToeBoardContent.None);
		}

		// Token: 0x0604549A RID: 283802 RVA: 0x01125390 File Offset: 0x01123590
		public bool CheckIsPlayerPiece(int index)
		{
			return this.Board.CheckBoardValue(index, this.PlayerCamp);
		}

		// Token: 0x0604549B RID: 283803 RVA: 0x011253A4 File Offset: 0x011235A4
		public bool CheckIsCenter(int index)
		{
			return this.Board.CenterIndex == index;
		}

		// Token: 0x0604549C RID: 283804 RVA: 0x011253B4 File Offset: 0x011235B4
		public bool CheckGameOver(int index)
		{
			return this.Board.CheckGameOver(index);
		}

		// Token: 0x04024214 RID: 147988
		protected readonly TicTacToeController Controller = new TicTacToeController();

		// Token: 0x04024215 RID: 147989
		protected readonly TicTacToeAiController AiController = new TicTacToeAiController();

		// Token: 0x04024216 RID: 147990
		protected readonly TicTacToeBoard Board = new TicTacToeBoard();

		// Token: 0x04024217 RID: 147991
		protected readonly int WinLineCount = 3;

		// Token: 0x04024218 RID: 147992
		protected ETicTacToeBoardContent[] CampLoop = new ETicTacToeBoardContent[]
		{
			ETicTacToeBoardContent.White,
			ETicTacToeBoardContent.Black
		};

		// Token: 0x04024219 RID: 147993
		protected readonly ETicTacToeBoardContent PlayerCamp = ETicTacToeBoardContent.White;

		// Token: 0x0402421A RID: 147994
		protected readonly ETicTacToeBoardContent AiCamp = ETicTacToeBoardContent.Black;

		// Token: 0x0402421B RID: 147995
		protected ETicTacToeBoardContent CurrentCamp;

		// Token: 0x0402421C RID: 147996
		protected bool AutoNextRound;

		// Token: 0x0402421D RID: 147997
		private int CurrentRound;

		// Token: 0x0402421E RID: 147998
		private bool IsAiEnable = true;

		// Token: 0x0402421F RID: 147999
		private ETicTacToeBoardContent WinCampInternal;
	}
}
