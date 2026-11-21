using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.AIGearStrategy;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x020060BE RID: 24766
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeGame
	{
		// Token: 0x0603B630 RID: 243248 RVA: 0x010CEE7C File Offset: 0x010CD07C
		public TicTacToeGame()
		{
			this.CurrentCamp = this.CampLoop[0];
		}

		// Token: 0x0603B631 RID: 243249 RVA: 0x010CEEF0 File Offset: 0x010CD0F0
		public void Init(bool isAiOffensive, Action<int, int> onPieceMove)
		{
			this.Board.Init(this.WinLineCount, new Action<ETicTacToeBoardContent>(this.OnGameOverCallback), new Action(this.OnEndRoundCallback));
			this.Controller.Init(this.Board, this.PlayerCamp);
			this.AiController.InitAi(this.Board, this.AiCamp, this.PlayerCamp);
			this.Controller.RegisterEvent(onPieceMove);
			this.AiController.RegisterEvent(onPieceMove);
			this.SetOffensive(isAiOffensive);
		}

		// Token: 0x0603B632 RID: 243250 RVA: 0x010CEF79 File Offset: 0x010CD179
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

		// Token: 0x0603B633 RID: 243251 RVA: 0x010CEFA8 File Offset: 0x010CD1A8
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

		// Token: 0x0603B634 RID: 243252 RVA: 0x010CF00D File Offset: 0x010CD20D
		public bool OnIndexSelect(int index)
		{
			if (!this.Controller.IsSelecting)
			{
				return this.Controller.SelectPiece(index);
			}
			return this.Controller.ResetSelectPiece(index) || this.Controller.MovePiece(index);
		}

		// Token: 0x0603B635 RID: 243253 RVA: 0x010CF045 File Offset: 0x010CD245
		public bool OnIndexMove(int oldIndex, int newIndex)
		{
			this.Controller.SelectPiece(oldIndex);
			return this.Controller.IsSelecting && this.Controller.MovePiece(newIndex);
		}

		// Token: 0x0603B636 RID: 243254 RVA: 0x010CF070 File Offset: 0x010CD270
		public void NextRound()
		{
			this.CurrentRound++;
			int num = this.CampLoop.Length;
			this.CurrentCamp = this.CampLoop[this.CurrentRound % num];
			this.StartRound();
		}

		// Token: 0x0603B637 RID: 243255 RVA: 0x010CF0B0 File Offset: 0x010CD2B0
		public void SetCurrentRound(int round)
		{
			this.CurrentRound = round;
			int num = this.CampLoop.Length;
			this.CurrentCamp = this.CampLoop[this.CurrentRound % num];
			this.WinCampInternal = ETicTacToeBoardContent.None;
			this.StartRound();
		}

		// Token: 0x17007066 RID: 28774
		// (get) Token: 0x0603B638 RID: 243256 RVA: 0x010CF0EF File Offset: 0x010CD2EF
		public bool IsPlayerRound
		{
			get
			{
				return this.CurrentCamp == this.PlayerCamp;
			}
		}

		// Token: 0x17007067 RID: 28775
		// (get) Token: 0x0603B639 RID: 243257 RVA: 0x010CF0FF File Offset: 0x010CD2FF
		public bool PlayerWin
		{
			get
			{
				return this.WinCampInternal == this.PlayerCamp;
			}
		}

		// Token: 0x17007068 RID: 28776
		// (get) Token: 0x0603B63A RID: 243258 RVA: 0x010CF10F File Offset: 0x010CD30F
		public bool AiWin
		{
			get
			{
				return this.WinCampInternal == this.AiCamp;
			}
		}

		// Token: 0x17007069 RID: 28777
		// (get) Token: 0x0603B63B RID: 243259 RVA: 0x010CF11F File Offset: 0x010CD31F
		public bool IsFinish
		{
			get
			{
				return this.WinCampInternal > ETicTacToeBoardContent.None;
			}
		}

		// Token: 0x0603B63C RID: 243260 RVA: 0x010CF12A File Offset: 0x010CD32A
		public void StartGame()
		{
			this.CurrentRound = 0;
			this.CurrentCamp = this.CampLoop[0];
			this.WinCampInternal = ETicTacToeBoardContent.None;
			this.StartRound();
		}

		// Token: 0x0603B63D RID: 243261 RVA: 0x010CF14E File Offset: 0x010CD34E
		public void ResetGame()
		{
			this.Controller.OnResetGame();
			this.AiController.OnResetGame();
			this.Board.ResetGame();
			this.StartGame();
		}

		// Token: 0x0603B63E RID: 243262 RVA: 0x010CF177 File Offset: 0x010CD377
		protected void OnGameOver(ETicTacToeBoardContent winCamp)
		{
			this.WinCampInternal = winCamp;
		}

		// Token: 0x0603B63F RID: 243263 RVA: 0x010CF180 File Offset: 0x010CD380
		protected void OnGameOverCallback(ETicTacToeBoardContent winCamp)
		{
			this.OnGameOver(winCamp);
		}

		// Token: 0x0603B640 RID: 243264 RVA: 0x010CF189 File Offset: 0x010CD389
		protected void OnEndRound()
		{
			if (this.AutoNextRound)
			{
				this.NextRound();
			}
		}

		// Token: 0x0603B641 RID: 243265 RVA: 0x010CF199 File Offset: 0x010CD399
		protected void OnEndRoundCallback()
		{
			this.OnEndRound();
		}

		// Token: 0x0603B642 RID: 243266 RVA: 0x010CF1A1 File Offset: 0x010CD3A1
		public void RefreshAiInfo(BP_AIGearStrategy_C aiInfo)
		{
			this.AiController.RefreshAiInfo(aiInfo);
		}

		// Token: 0x0603B643 RID: 243267 RVA: 0x010CF1B0 File Offset: 0x010CD3B0
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

		// Token: 0x0603B644 RID: 243268 RVA: 0x010CF290 File Offset: 0x010CD490
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

		// Token: 0x0603B645 RID: 243269 RVA: 0x010CF2E2 File Offset: 0x010CD4E2
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

		// Token: 0x0603B646 RID: 243270 RVA: 0x010CF31F File Offset: 0x010CD51F
		public IReadOnlyList<int> GetNoneNeighbors(int selectIndex)
		{
			return this.Board.GetNoneNeighbors(selectIndex);
		}

		// Token: 0x0603B647 RID: 243271 RVA: 0x010CF32D File Offset: 0x010CD52D
		public bool CheckCanMove(int index)
		{
			return this.Board.CheckBoardValue(index, ETicTacToeBoardContent.None);
		}

		// Token: 0x0603B648 RID: 243272 RVA: 0x010CF33C File Offset: 0x010CD53C
		public bool CheckIsPlayerPiece(int index)
		{
			return this.Board.CheckBoardValue(index, this.PlayerCamp);
		}

		// Token: 0x0603B649 RID: 243273 RVA: 0x010CF350 File Offset: 0x010CD550
		public bool CheckIsCenter(int index)
		{
			return this.Board.CenterIndex == index;
		}

		// Token: 0x0603B64A RID: 243274 RVA: 0x010CF360 File Offset: 0x010CD560
		public bool CheckGameOver(int index)
		{
			return this.Board.CheckGameOver(index);
		}

		// Token: 0x0401F4C9 RID: 128201
		protected readonly TicTacToeController Controller = new TicTacToeController();

		// Token: 0x0401F4CA RID: 128202
		protected readonly TicTacToeAiController AiController = new TicTacToeAiController();

		// Token: 0x0401F4CB RID: 128203
		protected readonly TicTacToeBoard Board = new TicTacToeBoard();

		// Token: 0x0401F4CC RID: 128204
		protected readonly int WinLineCount = 3;

		// Token: 0x0401F4CD RID: 128205
		protected ETicTacToeBoardContent[] CampLoop = new ETicTacToeBoardContent[]
		{
			ETicTacToeBoardContent.White,
			ETicTacToeBoardContent.Black
		};

		// Token: 0x0401F4CE RID: 128206
		protected readonly ETicTacToeBoardContent PlayerCamp = ETicTacToeBoardContent.White;

		// Token: 0x0401F4CF RID: 128207
		protected readonly ETicTacToeBoardContent AiCamp = ETicTacToeBoardContent.Black;

		// Token: 0x0401F4D0 RID: 128208
		protected ETicTacToeBoardContent CurrentCamp;

		// Token: 0x0401F4D1 RID: 128209
		protected bool AutoNextRound;

		// Token: 0x0401F4D2 RID: 128210
		private int CurrentRound;

		// Token: 0x0401F4D3 RID: 128211
		private bool IsAiEnable = true;

		// Token: 0x0401F4D4 RID: 128212
		private ETicTacToeBoardContent WinCampInternal;
	}
}
