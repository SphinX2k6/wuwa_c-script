using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.GroupInfo;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005444 RID: 21572
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePresenter : IMatchThreePresentation
	{
		// Token: 0x0603586C RID: 219244 RVA: 0x00EF28B0 File Offset: 0x00EF0AB0
		public MatchThreePresenter(MatchThreeGame game)
		{
			this.Game = game;
			this.Game.BindPresenter(this);
			this.Game.OnWin = new Action(this.OnGameWin);
			this.Game.OnLose = new Action(this.OnGameLose);
			this.Game.OnSegmentPlay = new Action<int>(this.OnSegmentPlay);
			for (int i = 0; i < 8; i++)
			{
				this.ColClearTasks[i] = new List<UniTask>();
			}
			this.SyncEnergyDisplay();
		}

		// Token: 0x0603586D RID: 219245 RVA: 0x00EF2A7A File Offset: 0x00EF0C7A
		public void BindView(MatchThreeGameplayView view)
		{
			this.View = view;
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x0603586E RID: 219246 RVA: 0x00EF2A83 File Offset: 0x00EF0C83
		public Board Board
		{
			get
			{
				return this.Game.Board;
			}
		}

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x0603586F RID: 219247 RVA: 0x00EF2A90 File Offset: 0x00EF0C90
		public IReadOnlyList<LevelGoal> Goals
		{
			get
			{
				return this.Game.Goals;
			}
		}

		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x06035870 RID: 219248 RVA: 0x00EF2A9D File Offset: 0x00EF0C9D
		public int RemainingTurns
		{
			get
			{
				return this.Game.RemainingTurns;
			}
		}

		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x06035871 RID: 219249 RVA: 0x00EF2AAA File Offset: 0x00EF0CAA
		public int MaxTurns
		{
			get
			{
				return this.Game.MaxTurns;
			}
		}

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x06035872 RID: 219250 RVA: 0x00EF2AB7 File Offset: 0x00EF0CB7
		public int LastTurnCostDelta
		{
			get
			{
				return this.Game.LastTurnCostDelta;
			}
		}

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x06035873 RID: 219251 RVA: 0x00EF2AC4 File Offset: 0x00EF0CC4
		public int Score
		{
			get
			{
				return this.Game.Score;
			}
		}

		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x06035874 RID: 219252 RVA: 0x00EF2AD1 File Offset: 0x00EF0CD1
		public IReadOnlyList<ValidMove> LastValidMoves
		{
			get
			{
				return this.Game.LastValidMoves;
			}
		}

		// Token: 0x1700683A RID: 26682
		// (get) Token: 0x06035875 RID: 219253 RVA: 0x00EF2ADE File Offset: 0x00EF0CDE
		public bool LastSwapAccepted
		{
			get
			{
				return this.Game.LastSwapAccepted;
			}
		}

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x06035876 RID: 219254 RVA: 0x00EF2AEC File Offset: 0x00EF0CEC
		public bool IsGameOver
		{
			get
			{
				EMatchThreeGameState state = this.Game.State;
				return state - EMatchThreeGameState.Win <= 1;
			}
		}

		// Token: 0x06035877 RID: 219255 RVA: 0x00EF2B14 File Offset: 0x00EF0D14
		public bool CanFocusBoard()
		{
			return !this.InitialPresentationFlowRunning && !this.InitialMechanicTipsPlaying && !this.Game.InputLocked && this.Game.State == EMatchThreeGameState.WaitingInput && this.ResolveFinished == null && !this.Restarting && !this.IsGameOver && this.View != null;
		}

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x06035878 RID: 219256 RVA: 0x00EF2B6E File Offset: 0x00EF0D6E
		public int Energy
		{
			get
			{
				if (this.EnergyDisplay <= 0)
				{
					return 0;
				}
				return this.EnergyDisplay;
			}
		}

		// Token: 0x1700683D RID: 26685
		// (get) Token: 0x06035879 RID: 219257 RVA: 0x00EF2B81 File Offset: 0x00EF0D81
		public int FullEnergy
		{
			get
			{
				return this.Game.FullEnergy;
			}
		}

		// Token: 0x0603587A RID: 219258 RVA: 0x00EF2B8E File Offset: 0x00EF0D8E
		public IReadOnlyList<SkillPointDisplayData> CollectSkillPoints()
		{
			return this.SkillPoints;
		}

		// Token: 0x0603587B RID: 219259 RVA: 0x00EF2B96 File Offset: 0x00EF0D96
		private void SyncEnergyDisplay()
		{
			this.PoolWatermark = this.Game.Energy;
			this.EnergyDisplay = this.PoolWatermark;
			this.Game.CollectSkillPoints(this.SkillPoints, this.Energy);
		}

		// Token: 0x0603587C RID: 219260 RVA: 0x00EF2BCC File Offset: 0x00EF0DCC
		private void OnSegmentPlay(int trailCharge)
		{
			int energy = this.Game.Energy;
			this.EnergyDisplay += energy - this.PoolWatermark - trailCharge;
			this.PoolWatermark = energy;
			this.Game.CollectSkillPoints(this.SkillPoints, this.Energy);
			MatchThreeGameplayView view = this.View;
			if (view == null)
			{
				return;
			}
			view.RefreshGoalProgress();
		}

		// Token: 0x0603587D RID: 219261 RVA: 0x00EF2C2C File Offset: 0x00EF0E2C
		public void AddLandedTrailEnergy(int energy)
		{
			this.EnergyDisplay += energy;
			int energy2 = this.Energy;
			for (int i = 0; i < this.SkillPoints.Count; i++)
			{
				SkillPointDisplayData skillPointDisplayData = this.SkillPoints[i];
				this.SkillPoints[i] = new SkillPointDisplayData(skillPointDisplayData.EnergyNode, skillPointDisplayData.Icon, energy2 >= skillPointDisplayData.EnergyNode, skillPointDisplayData.Released);
			}
		}

		// Token: 0x0603587E RID: 219262 RVA: 0x00EF2CA0 File Offset: 0x00EF0EA0
		public bool RequestSwap(GridPosition a, GridPosition b)
		{
			if (this.InitialPresentationFlowRunning || this.InitialMechanicTipsPlaying || this.Game.InputLocked || this.ResolveFinished != null || this.Restarting || this.IsGameOver || this.View == null)
			{
				return false;
			}
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.ResolveFinished = uniTaskCompletionSource;
			this.SwapThenRefreshAsync(a, b, uniTaskCompletionSource).Forget();
			return true;
		}

		// Token: 0x0603587F RID: 219263 RVA: 0x00EF2D08 File Offset: 0x00EF0F08
		[NullableContext(0)]
		public UniTask<bool> RestartAsync(bool lowerDifficulty = false)
		{
			MatchThreePresenter.<RestartAsync>d__35 <RestartAsync>d__;
			<RestartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RestartAsync>d__.<>4__this = this;
			<RestartAsync>d__.lowerDifficulty = lowerDifficulty;
			<RestartAsync>d__.<>1__state = -1;
			<RestartAsync>d__.<>t__builder.Start<MatchThreePresenter.<RestartAsync>d__35>(ref <RestartAsync>d__);
			return <RestartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035880 RID: 219264 RVA: 0x00EF2D54 File Offset: 0x00EF0F54
		public UniTask RewindAsync(int turns = 1)
		{
			MatchThreePresenter.<RewindAsync>d__36 <RewindAsync>d__;
			<RewindAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RewindAsync>d__.<>4__this = this;
			<RewindAsync>d__.turns = turns;
			<RewindAsync>d__.<>1__state = -1;
			<RewindAsync>d__.<>t__builder.Start<MatchThreePresenter.<RewindAsync>d__36>(ref <RewindAsync>d__);
			return <RewindAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035881 RID: 219265 RVA: 0x00EF2DA0 File Offset: 0x00EF0FA0
		private UniTask AbortRunningResolveAsync()
		{
			MatchThreePresenter.<AbortRunningResolveAsync>d__37 <AbortRunningResolveAsync>d__;
			<AbortRunningResolveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AbortRunningResolveAsync>d__.<>4__this = this;
			<AbortRunningResolveAsync>d__.<>1__state = -1;
			<AbortRunningResolveAsync>d__.<>t__builder.Start<MatchThreePresenter.<AbortRunningResolveAsync>d__37>(ref <AbortRunningResolveAsync>d__);
			return <AbortRunningResolveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035882 RID: 219266 RVA: 0x00EF2DE4 File Offset: 0x00EF0FE4
		private UniTask SwapThenRefreshAsync(GridPosition a, GridPosition b, UniTaskCompletionSource finished)
		{
			MatchThreePresenter.<SwapThenRefreshAsync>d__40 <SwapThenRefreshAsync>d__;
			<SwapThenRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwapThenRefreshAsync>d__.<>4__this = this;
			<SwapThenRefreshAsync>d__.a = a;
			<SwapThenRefreshAsync>d__.b = b;
			<SwapThenRefreshAsync>d__.finished = finished;
			<SwapThenRefreshAsync>d__.<>1__state = -1;
			<SwapThenRefreshAsync>d__.<>t__builder.Start<MatchThreePresenter.<SwapThenRefreshAsync>d__40>(ref <SwapThenRefreshAsync>d__);
			return <SwapThenRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035883 RID: 219267 RVA: 0x00EF2E40 File Offset: 0x00EF1040
		public IReadOnlyList<MechanicDisplayData> CollectMechanicDisplays()
		{
			List<MechanicDisplayData> list = new List<MechanicDisplayData>();
			List<int> mountRounds = new List<int>();
			foreach (LevelMechanic levelMechanic in this.Game.Mechanics)
			{
				GenerateSpecialPieceMechanic generateSpecialPieceMechanic = levelMechanic as GenerateSpecialPieceMechanic;
				if (generateSpecialPieceMechanic != null)
				{
					if (this.Game.Round >= generateSpecialPieceMechanic.MountRound)
					{
						MechanicDisplayData display = new MechanicDisplayData(generateSpecialPieceMechanic.EnvId, generateSpecialPieceMechanic.TargetType, generateSpecialPieceMechanic.RoundsUntilFire(this.Game.Round), generateSpecialPieceMechanic.GenerateCount, true);
						MatchThreePresenter.InsertMechanicDisplayByMountRound(list, mountRounds, display, generateSpecialPieceMechanic.MountRound);
					}
				}
				else
				{
					RecycleSpecialPieceMechanic recycleSpecialPieceMechanic = levelMechanic as RecycleSpecialPieceMechanic;
					if (recycleSpecialPieceMechanic != null && this.Game.Round >= recycleSpecialPieceMechanic.MountRound)
					{
						MechanicDisplayData display2 = new MechanicDisplayData(recycleSpecialPieceMechanic.EnvId, recycleSpecialPieceMechanic.TargetType, 0, 0, false);
						MatchThreePresenter.InsertMechanicDisplayByMountRound(list, mountRounds, display2, recycleSpecialPieceMechanic.MountRound);
					}
				}
			}
			return list;
		}

		// Token: 0x06035884 RID: 219268 RVA: 0x00EF2F4C File Offset: 0x00EF114C
		private static void InsertMechanicDisplayByMountRound(List<MechanicDisplayData> displays, List<int> mountRounds, MechanicDisplayData display, int mountRound)
		{
			int num = 0;
			while (num < mountRounds.Count && mountRounds[num] <= mountRound)
			{
				num++;
			}
			displays.Insert(num, display);
			mountRounds.Insert(num, mountRound);
		}

		// Token: 0x06035885 RID: 219269 RVA: 0x00EF2F84 File Offset: 0x00EF1184
		public UniTask TryPlayInitialGuideThenMechanicTipsAsync()
		{
			MatchThreePresenter.<TryPlayInitialGuideThenMechanicTipsAsync>d__55 <TryPlayInitialGuideThenMechanicTipsAsync>d__;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>4__this = this;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>1__state = -1;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder.Start<MatchThreePresenter.<TryPlayInitialGuideThenMechanicTipsAsync>d__55>(ref <TryPlayInitialGuideThenMechanicTipsAsync>d__);
			return <TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035886 RID: 219270 RVA: 0x00EF2FC8 File Offset: 0x00EF11C8
		[NullableContext(0)]
		private UniTask<bool> TryPlayInitialGuideAsync(int levelId, int guideGroupId, [Nullable(1)] UniTaskCompletionSource abortSource)
		{
			MatchThreePresenter.<TryPlayInitialGuideAsync>d__56 <TryPlayInitialGuideAsync>d__;
			<TryPlayInitialGuideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryPlayInitialGuideAsync>d__.<>4__this = this;
			<TryPlayInitialGuideAsync>d__.guideGroupId = guideGroupId;
			<TryPlayInitialGuideAsync>d__.abortSource = abortSource;
			<TryPlayInitialGuideAsync>d__.<>1__state = -1;
			<TryPlayInitialGuideAsync>d__.<>t__builder.Start<MatchThreePresenter.<TryPlayInitialGuideAsync>d__56>(ref <TryPlayInitialGuideAsync>d__);
			return <TryPlayInitialGuideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035887 RID: 219271 RVA: 0x00EF301C File Offset: 0x00EF121C
		private static bool ContainsTutorialStep(GuideGroupInfo groupInfo)
		{
			for (int i = 0; i < groupInfo.StepInfoList.Count; i++)
			{
				if (groupInfo.StepInfoList[i].Config.ContentType == 3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035888 RID: 219272 RVA: 0x00EF3060 File Offset: 0x00EF1260
		[NullableContext(0)]
		private static UniTask<bool> WaitInitialPresentationOrAbortAsync(UniTask presentationTask, [Nullable(1)] UniTaskCompletionSource abortSource)
		{
			MatchThreePresenter.<WaitInitialPresentationOrAbortAsync>d__58 <WaitInitialPresentationOrAbortAsync>d__;
			<WaitInitialPresentationOrAbortAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitInitialPresentationOrAbortAsync>d__.presentationTask = presentationTask;
			<WaitInitialPresentationOrAbortAsync>d__.abortSource = abortSource;
			<WaitInitialPresentationOrAbortAsync>d__.<>1__state = -1;
			<WaitInitialPresentationOrAbortAsync>d__.<>t__builder.Start<MatchThreePresenter.<WaitInitialPresentationOrAbortAsync>d__58>(ref <WaitInitialPresentationOrAbortAsync>d__);
			return <WaitInitialPresentationOrAbortAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035889 RID: 219273 RVA: 0x00EF30AC File Offset: 0x00EF12AC
		private void BindInitialGuideViewEvents()
		{
			if (this.InitialGuideViewEventsBound)
			{
				return;
			}
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnInitialTutorialViewOpened));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnInitialTutorialViewClosed));
			this.InitialGuideViewEventsBound = true;
		}

		// Token: 0x0603588A RID: 219274 RVA: 0x00EF30FC File Offset: 0x00EF12FC
		private void UnbindInitialGuideViewEvents()
		{
			if (!this.InitialGuideViewEventsBound)
			{
				return;
			}
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnInitialTutorialViewOpened));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnInitialTutorialViewClosed));
			this.InitialGuideViewEventsBound = false;
		}

		// Token: 0x0603588B RID: 219275 RVA: 0x00EF314C File Offset: 0x00EF134C
		private void OnInitialTutorialViewOpened(EUiViewName viewName, int viewId)
		{
			if (this.InitialGuideGroupId == 0 || (viewName != EUiViewName.GuideTutorialView && viewName != EUiViewName.GuideTutorialPopView))
			{
				return;
			}
			GuideTutorialView guideTutorialView = UiManager.Instance.GetView(viewId) as GuideTutorialView;
			TutorialListInfo tutorialListInfo;
			if ((tutorialListInfo = ((guideTutorialView != null) ? guideTutorialView.TutorialInfo : null)) == null)
			{
				tutorialListInfo = (((guideTutorialView != null) ? guideTutorialView.OpenParam : null) as TutorialListInfo);
			}
			TutorialListInfo tutorialListInfo2 = tutorialListInfo;
			int? num;
			if (tutorialListInfo2 == null)
			{
				num = null;
			}
			else
			{
				GuideStepInfo ownerStep = tutorialListInfo2.OwnerStep;
				if (ownerStep == null)
				{
					num = null;
				}
				else
				{
					GuideGroupInfo ownerGroup = ownerStep.OwnerGroup;
					num = ((ownerGroup != null) ? new int?(ownerGroup.Id) : null);
				}
			}
			int? num2 = num;
			if (num2.GetValueOrDefault() != this.InitialGuideGroupId)
			{
				return;
			}
			this.InitialTutorialViewId = viewId;
		}

		// Token: 0x0603588C RID: 219276 RVA: 0x00EF3207 File Offset: 0x00EF1407
		private void OnInitialTutorialViewClosed(EUiViewName viewName, int viewId)
		{
			if ((viewName != EUiViewName.GuideTutorialView && viewName != EUiViewName.GuideTutorialPopView) || viewId != this.InitialTutorialViewId)
			{
				return;
			}
			UniTaskCompletionSource initialTutorialCloseSource = this.InitialTutorialCloseSource;
			if (initialTutorialCloseSource == null)
			{
				return;
			}
			initialTutorialCloseSource.TrySetResult();
		}

		// Token: 0x0603588D RID: 219277 RVA: 0x00EF3240 File Offset: 0x00EF1440
		private void AbortInitialPresentationFlow()
		{
			this.InitialPresentationAborted = true;
			UniTaskCompletionSource initialPresentationAbortSource = this.InitialPresentationAbortSource;
			if (initialPresentationAbortSource != null)
			{
				initialPresentationAbortSource.TrySetResult();
			}
			UniTaskCompletionSource initialTutorialCloseSource = this.InitialTutorialCloseSource;
			if (initialTutorialCloseSource != null)
			{
				initialTutorialCloseSource.TrySetResult();
			}
			this.UnbindInitialGuideViewEvents();
			this.InitialGuideGroupId = 0;
			this.InitialTutorialViewId = 0;
		}

		// Token: 0x0603588E RID: 219278 RVA: 0x00EF328C File Offset: 0x00EF148C
		public UniTask PlayInitialMechanicTipsAsync()
		{
			MatchThreePresenter.<PlayInitialMechanicTipsAsync>d__64 <PlayInitialMechanicTipsAsync>d__;
			<PlayInitialMechanicTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayInitialMechanicTipsAsync>d__.<>4__this = this;
			<PlayInitialMechanicTipsAsync>d__.<>1__state = -1;
			<PlayInitialMechanicTipsAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayInitialMechanicTipsAsync>d__64>(ref <PlayInitialMechanicTipsAsync>d__);
			return <PlayInitialMechanicTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603588F RID: 219279 RVA: 0x00EF32D0 File Offset: 0x00EF14D0
		private void PrepareInitialMechanicTips()
		{
			for (int i = 0; i < this.Game.Mechanics.Count; i++)
			{
				MechanicTipEvent? mechanicTipEvent = this.Game.Mechanics[i].CreateMountTip(this.Game.Round);
				if (mechanicTipEvent != null)
				{
					this.PendingMechanicTips.Add(mechanicTipEvent.Value);
				}
			}
		}

		// Token: 0x06035890 RID: 219280 RVA: 0x00EF3338 File Offset: 0x00EF1538
		public UniTask PlaySwapAsync(GridPosition a, GridPosition b)
		{
			MatchThreePresenter.<PlaySwapAsync>d__66 <PlaySwapAsync>d__;
			<PlaySwapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwapAsync>d__.<>4__this = this;
			<PlaySwapAsync>d__.a = a;
			<PlaySwapAsync>d__.b = b;
			<PlaySwapAsync>d__.<>1__state = -1;
			<PlaySwapAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlaySwapAsync>d__66>(ref <PlaySwapAsync>d__);
			return <PlaySwapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035891 RID: 219281 RVA: 0x00EF338C File Offset: 0x00EF158C
		public UniTask PlaySwapFailAsync(GridPosition a, GridPosition b)
		{
			MatchThreeGameplayView view = this.View;
			if (view == null)
			{
				return UniTask.CompletedTask;
			}
			AudioSystem.Instance.PostEvent("play_ui_match3game_game_move_fail");
			return view.PlaySwapFailAsync(a, b);
		}

		// Token: 0x06035892 RID: 219282 RVA: 0x00EF33C4 File Offset: 0x00EF15C4
		public UniTask PlayReshuffleAsync()
		{
			MatchThreeGameplayView view = this.View;
			if (view == null)
			{
				return UniTask.CompletedTask;
			}
			AudioSystem.Instance.PostEvent("play_ui_match3game_game_refresh");
			return view.PlayReshuffleAsync();
		}

		// Token: 0x06035893 RID: 219283 RVA: 0x00EF33F8 File Offset: 0x00EF15F8
		public UniTask PlayBoardAsync(BoardSegment board)
		{
			MatchThreePresenter.<PlayBoardAsync>d__95 <PlayBoardAsync>d__;
			<PlayBoardAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBoardAsync>d__.<>4__this = this;
			<PlayBoardAsync>d__.board = board;
			<PlayBoardAsync>d__.<>1__state = -1;
			<PlayBoardAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayBoardAsync>d__95>(ref <PlayBoardAsync>d__);
			return <PlayBoardAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035894 RID: 219284 RVA: 0x00EF3444 File Offset: 0x00EF1644
		private UniTask PlayColumnAsync(BoardSegment board, int col)
		{
			MatchThreePresenter.<PlayColumnAsync>d__96 <PlayColumnAsync>d__;
			<PlayColumnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayColumnAsync>d__.<>4__this = this;
			<PlayColumnAsync>d__.col = col;
			<PlayColumnAsync>d__.<>1__state = -1;
			<PlayColumnAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayColumnAsync>d__96>(ref <PlayColumnAsync>d__);
			return <PlayColumnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035895 RID: 219285 RVA: 0x00EF348F File Offset: 0x00EF168F
		private static int CellIdx(GridPosition pos)
		{
			return pos.Row * 8 + pos.Col;
		}

		// Token: 0x06035896 RID: 219286 RVA: 0x00EF34A0 File Offset: 0x00EF16A0
		private void BuildCellIndex(BoardSegment board)
		{
			Array.Fill<int>(this.CellClearIdx, -1);
			Array.Fill<int>(this.CellFirstHitIdx, -1);
			Array.Fill<int>(this.CellLastIdx, -1);
			this.HitNext.Clear();
			for (int i = 0; i < board.Clears.Count; i++)
			{
				this.CellClearIdx[MatchThreePresenter.CellIdx(board.Clears[i].Pos)] = i;
			}
			for (int j = 0; j < board.Hits.Count; j++)
			{
				int num = MatchThreePresenter.CellIdx(board.Hits[j].Pos);
				this.HitNext.Add(-1);
				int num2 = this.CellLastIdx[num];
				if (num2 < 0)
				{
					this.CellFirstHitIdx[num] = j;
				}
				else
				{
					this.HitNext[num2] = j;
				}
				this.CellLastIdx[num] = j;
			}
		}

		// Token: 0x06035897 RID: 219287 RVA: 0x00EF3578 File Offset: 0x00EF1778
		private void BuildColumnGates(IReadOnlyList<PieceClearEvent> clears)
		{
			Array.Clear(this.ColumnClearPending, 0, this.ColumnClearPending.Length);
			for (int i = 0; i < clears.Count; i++)
			{
				this.ColumnClearPending[clears[i].Pos.Col]++;
			}
			for (int j = 0; j < 8; j++)
			{
				UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
				this.ColumnGates[j] = uniTaskCompletionSource;
				if (this.ColumnClearPending[j] == 0)
				{
					uniTaskCompletionSource.TrySetResult();
				}
			}
		}

		// Token: 0x06035898 RID: 219288 RVA: 0x00EF35F8 File Offset: 0x00EF17F8
		private void OnColumnCellVacated(int col)
		{
			int[] columnClearPending = this.ColumnClearPending;
			int num = columnClearPending[col] - 1;
			columnClearPending[col] = num;
			if (num <= 0)
			{
				UniTaskCompletionSource uniTaskCompletionSource = this.ColumnGates[col];
				if (uniTaskCompletionSource == null)
				{
					return;
				}
				uniTaskCompletionSource.TrySetResult();
			}
		}

		// Token: 0x06035899 RID: 219289 RVA: 0x00EF3630 File Offset: 0x00EF1830
		private unsafe void ReportUnlitColumnGates()
		{
			for (int i = 0; i < 8; i++)
			{
				if (this.ColumnClearPending[i] > 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MatchThree;
					ELogAuthor author = ELogAuthor.CB;
					string message = "[PlayBoardAsync] 列任务已收工但该列未报满腾空数，下落将卡死（已强行放行）";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Col", i);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("未报数", this.ColumnClearPending[i]);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.ColumnClearPending[i] = 0;
					UniTaskCompletionSource uniTaskCompletionSource = this.ColumnGates[i];
					if (uniTaskCompletionSource != null)
					{
						uniTaskCompletionSource.TrySetResult();
					}
				}
			}
		}

		// Token: 0x0603589A RID: 219290 RVA: 0x00EF36E4 File Offset: 0x00EF18E4
		private void BuildMoveTrips(List<PieceMoveEvent> moves)
		{
			this.MoveTrips.Clear();
			int num = 0;
			for (int i = 1; i <= moves.Count; i++)
			{
				if (i >= moves.Count || moves[i].Piece != moves[num].Piece)
				{
					this.MoveTrips.Add(new ValueTuple<int, int>(num, i - num));
					num = i;
				}
			}
		}

		// Token: 0x0603589B RID: 219291 RVA: 0x00EF3748 File Offset: 0x00EF1948
		private UniTask PlayTripAsync(MatchThreeGameplayView view, List<PieceMoveEvent> moves, int start, int count, [Nullable(2)] MatchThreePieceView piece)
		{
			MatchThreePresenter.<PlayTripAsync>d__103 <PlayTripAsync>d__;
			<PlayTripAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTripAsync>d__.<>4__this = this;
			<PlayTripAsync>d__.view = view;
			<PlayTripAsync>d__.moves = moves;
			<PlayTripAsync>d__.start = start;
			<PlayTripAsync>d__.count = count;
			<PlayTripAsync>d__.piece = piece;
			<PlayTripAsync>d__.<>1__state = -1;
			<PlayTripAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayTripAsync>d__103>(ref <PlayTripAsync>d__);
			return <PlayTripAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603589C RID: 219292 RVA: 0x00EF37B5 File Offset: 0x00EF19B5
		private void PlayTileAddAudio()
		{
			if (this.TileAddAudioPlayed)
			{
				return;
			}
			this.TileAddAudioPlayed = true;
			AudioSystem.Instance.PostEvent("play_ui_match3game_game_tile_add");
		}

		// Token: 0x0603589D RID: 219293 RVA: 0x00EF37D8 File Offset: 0x00EF19D8
		private void BuildStrikeGates(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits)
		{
			this.ClearStrikeGates.Clear();
			this.HitStrikeGates.Clear();
			Array.Fill<int>(this.CellFirstStrikeIdx, -1);
			Array.Fill<int>(this.CellLastIdx, -1);
			this.StrikeNext.Clear();
			this.StrikeTargets.Clear();
			for (int i = 0; i < clears.Count; i++)
			{
				GridPosition? trailFrom = clears[i].TrailFrom;
				if (trailFrom == null)
				{
					this.ClearStrikeGates.Add(null);
				}
				else
				{
					UniTaskCompletionSource<int> item = this.CreateStrikeGate(clears, hits, trailFrom.Value);
					this.ClearStrikeGates.Add(item);
					this.AddStrikeTarget(trailFrom.Value, new MatchThreePresenter.DirectedStrikeTarget(false, i));
				}
			}
			for (int j = 0; j < hits.Count; j++)
			{
				GridPosition? trailFrom2 = hits[j].TrailFrom;
				if (trailFrom2 == null)
				{
					this.HitStrikeGates.Add(null);
				}
				else
				{
					UniTaskCompletionSource<int> item2 = this.CreateStrikeGate(clears, hits, trailFrom2.Value);
					this.HitStrikeGates.Add(item2);
					this.AddStrikeTarget(trailFrom2.Value, new MatchThreePresenter.DirectedStrikeTarget(true, j));
				}
			}
		}

		// Token: 0x0603589E RID: 219294 RVA: 0x00EF38F8 File Offset: 0x00EF1AF8
		private unsafe UniTaskCompletionSource<int> CreateStrikeGate(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits, GridPosition origin)
		{
			UniTaskCompletionSource<int> uniTaskCompletionSource = new UniTaskCompletionSource<int>();
			if (!this.HasSourceEventAt(clears, hits, origin))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[CreateStrikeGate] 拖尾源格本段无可放行事件，立即放行目标表现";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "Origin";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(origin.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(origin.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ClearCount", clears.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HitCount", hits.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				uniTaskCompletionSource.TrySetResult(0);
			}
			return uniTaskCompletionSource;
		}

		// Token: 0x0603589F RID: 219295 RVA: 0x00EF39F4 File Offset: 0x00EF1BF4
		private bool HasSourceEventAt(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits, GridPosition pos)
		{
			int num = MatchThreePresenter.CellIdx(pos);
			int num2 = this.CellClearIdx[num];
			if (num2 >= 0 && num2 < clears.Count)
			{
				PieceClearEvent pieceClearEvent = clears[num2];
				if (pieceClearEvent.TrailFrom == null || pieceClearEvent.OpensDirectedTrails)
				{
					return true;
				}
			}
			int num3 = this.CellFirstHitIdx[num];
			while (num3 >= 0 && num3 < hits.Count)
			{
				if (hits[num3].OpensDirectedTrails)
				{
					return true;
				}
				num3 = this.HitNext[num3];
			}
			return false;
		}

		// Token: 0x060358A0 RID: 219296 RVA: 0x00EF3A74 File Offset: 0x00EF1C74
		private void AddStrikeTarget(GridPosition origin, MatchThreePresenter.DirectedStrikeTarget target)
		{
			int count = this.StrikeTargets.Count;
			this.StrikeTargets.Add(target);
			this.StrikeNext.Add(-1);
			int num = MatchThreePresenter.CellIdx(origin);
			int num2 = this.CellLastIdx[num];
			if (num2 < 0)
			{
				this.CellFirstStrikeIdx[num] = count;
			}
			else
			{
				this.StrikeNext[num2] = count;
			}
			this.CellLastIdx[num] = count;
		}

		// Token: 0x060358A1 RID: 219297 RVA: 0x00EF3ADC File Offset: 0x00EF1CDC
		private void BuildLandGates(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits)
		{
			Array.Clear(this.LandGates, 0, this.LandGates.Length);
			for (int i = 0; i < clears.Count; i++)
			{
				this.EnsureLandGate(clears, hits, clears[i].WaitLandAt);
			}
			for (int j = 0; j < hits.Count; j++)
			{
				this.EnsureLandGate(clears, hits, hits[j].WaitLandAt);
			}
		}

		// Token: 0x060358A2 RID: 219298 RVA: 0x00EF3B48 File Offset: 0x00EF1D48
		private void EnsureLandGate(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits, GridPosition? anchor)
		{
			if (anchor == null)
			{
				return;
			}
			int num = MatchThreePresenter.CellIdx(anchor.Value);
			if (this.LandGates[num] != null)
			{
				return;
			}
			int num2 = this.CellClearIdx[num];
			bool flag = num2 >= 0 && clears[num2].TrailFrom != null;
			bool flag2 = this.HasHitTrailAt(hits, anchor.Value);
			if (!flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[BuildLandGates] 落地锚点本段无带拖尾的消除，等灯格将立刻起播";
				string item = "Anchor";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(anchor.Value.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(anchor.Value.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.LandGates[num] = new UniTaskCompletionSource();
		}

		// Token: 0x060358A3 RID: 219299 RVA: 0x00EF3C48 File Offset: 0x00EF1E48
		private bool HasHitTrailAt(IReadOnlyList<PieceHitEvent> hits, GridPosition pos)
		{
			for (int i = 0; i < hits.Count; i++)
			{
				if (hits[i].Pos.Row == pos.Row && hits[i].Pos.Col == pos.Col && hits[i].TrailFrom != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060358A4 RID: 219300 RVA: 0x00EF3CB1 File Offset: 0x00EF1EB1
		private UniTask WaitLandAsync(GridPosition? anchor)
		{
			if (anchor == null)
			{
				return UniTask.CompletedTask;
			}
			UniTaskCompletionSource uniTaskCompletionSource = this.LandGates[MatchThreePresenter.CellIdx(anchor.Value)];
			if (uniTaskCompletionSource == null)
			{
				return UniTask.CompletedTask;
			}
			return uniTaskCompletionSource.Task;
		}

		// Token: 0x060358A5 RID: 219301 RVA: 0x00EF3CE4 File Offset: 0x00EF1EE4
		private void OpenLandGate(GridPosition pos)
		{
			UniTaskCompletionSource uniTaskCompletionSource = this.LandGates[MatchThreePresenter.CellIdx(pos)];
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}

		// Token: 0x060358A6 RID: 219302 RVA: 0x00EF3D00 File Offset: 0x00EF1F00
		private void BuildDetonationGates(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits)
		{
			Array.Clear(this.DetonationGates, 0, this.DetonationGates.Length);
			for (int i = 0; i < clears.Count; i++)
			{
				this.EnsureDetonationGate(clears, hits, clears[i].WaitDetonationAt);
			}
			for (int j = 0; j < hits.Count; j++)
			{
				this.EnsureDetonationGate(clears, hits, hits[j].WaitDetonationAt);
			}
		}

		// Token: 0x060358A7 RID: 219303 RVA: 0x00EF3D6C File Offset: 0x00EF1F6C
		private void EnsureDetonationGate(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits, GridPosition? source)
		{
			if (source == null)
			{
				return;
			}
			int num = MatchThreePresenter.CellIdx(source.Value);
			if (this.DetonationGates[num] != null)
			{
				return;
			}
			if (!this.HasDetonationSourceAt(clears, hits, source.Value))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[BuildDetonationGates] 引爆源本段无消除或受击事件，波及格将立刻起播";
				string item = "Source";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(source.Value.Row);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(source.Value.Col);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DetonationGates[num] = new UniTaskCompletionSource();
		}

		// Token: 0x060358A8 RID: 219304 RVA: 0x00EF3E40 File Offset: 0x00EF2040
		private bool HasDetonationSourceAt(IReadOnlyList<PieceClearEvent> clears, IReadOnlyList<PieceHitEvent> hits, GridPosition source)
		{
			int num = this.CellClearIdx[MatchThreePresenter.CellIdx(source)];
			if (num >= 0 && clears[num].OpensDetonation)
			{
				return true;
			}
			for (int i = this.CellFirstHitIdx[MatchThreePresenter.CellIdx(source)]; i >= 0; i = this.HitNext[i])
			{
				if (hits[i].OpensDetonation)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060358A9 RID: 219305 RVA: 0x00EF3EA1 File Offset: 0x00EF20A1
		private UniTask WaitDetonationAsync(GridPosition? source)
		{
			if (source == null)
			{
				return UniTask.CompletedTask;
			}
			UniTaskCompletionSource uniTaskCompletionSource = this.DetonationGates[MatchThreePresenter.CellIdx(source.Value)];
			if (uniTaskCompletionSource == null)
			{
				return UniTask.CompletedTask;
			}
			return uniTaskCompletionSource.Task;
		}

		// Token: 0x060358AA RID: 219306 RVA: 0x00EF3ED4 File Offset: 0x00EF20D4
		private void OpenDetonationGate(GridPosition source)
		{
			UniTaskCompletionSource uniTaskCompletionSource = this.DetonationGates[MatchThreePresenter.CellIdx(source)];
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}

		// Token: 0x060358AB RID: 219307 RVA: 0x00EF3EF0 File Offset: 0x00EF20F0
		private void BuildUltimateFullUpGate(IReadOnlyList<PieceClearEvent> clears)
		{
			this.UltimateFullUpGate = null;
			for (int i = 0; i < clears.Count; i++)
			{
				if (clears[i].Reason == EPieceClearReason.UltimateAllManual)
				{
					this.UltimateFullUpGate = new UniTaskCompletionSource();
					return;
				}
			}
		}

		// Token: 0x060358AC RID: 219308 RVA: 0x00EF3F30 File Offset: 0x00EF2130
		private UniTask WaitUltimateFullUpAsync(PieceClearEvent ev)
		{
			if (this.UltimateFullUpGate == null || ev.Reason == EPieceClearReason.UltimateAllManual || ev.Reason == EPieceClearReason.UltimateAllPassive)
			{
				return UniTask.CompletedTask;
			}
			return this.WaitUltimateFullUpAsync();
		}

		// Token: 0x060358AD RID: 219309 RVA: 0x00EF3F58 File Offset: 0x00EF2158
		private UniTask WaitUltimateFullUpAsync()
		{
			UniTaskCompletionSource ultimateFullUpGate = this.UltimateFullUpGate;
			if (ultimateFullUpGate == null)
			{
				return UniTask.CompletedTask;
			}
			return ultimateFullUpGate.Task;
		}

		// Token: 0x060358AE RID: 219310 RVA: 0x00EF3F6F File Offset: 0x00EF216F
		private void OpenUltimateFullUpGate()
		{
			UniTaskCompletionSource ultimateFullUpGate = this.UltimateFullUpGate;
			if (ultimateFullUpGate == null)
			{
				return;
			}
			ultimateFullUpGate.TrySetResult();
		}

		// Token: 0x060358AF RID: 219311 RVA: 0x00EF3F84 File Offset: 0x00EF2184
		private UniTask PlayCellAsync(MatchThreeGameplayView view, BoardSegment board, int clearIdx)
		{
			MatchThreePresenter.<PlayCellAsync>d__123 <PlayCellAsync>d__;
			<PlayCellAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCellAsync>d__.<>4__this = this;
			<PlayCellAsync>d__.view = view;
			<PlayCellAsync>d__.board = board;
			<PlayCellAsync>d__.clearIdx = clearIdx;
			<PlayCellAsync>d__.<>1__state = -1;
			<PlayCellAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayCellAsync>d__123>(ref <PlayCellAsync>d__);
			return <PlayCellAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B0 RID: 219312 RVA: 0x00EF3FE0 File Offset: 0x00EF21E0
		private UniTask PlayCellHitsAsync(MatchThreeGameplayView view, List<PieceHitEvent> hits, int firstIdx, bool waitUltimateFullUp)
		{
			MatchThreePresenter.<PlayCellHitsAsync>d__124 <PlayCellHitsAsync>d__;
			<PlayCellHitsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCellHitsAsync>d__.<>4__this = this;
			<PlayCellHitsAsync>d__.view = view;
			<PlayCellHitsAsync>d__.hits = hits;
			<PlayCellHitsAsync>d__.firstIdx = firstIdx;
			<PlayCellHitsAsync>d__.waitUltimateFullUp = waitUltimateFullUp;
			<PlayCellHitsAsync>d__.<>1__state = -1;
			<PlayCellHitsAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayCellHitsAsync>d__124>(ref <PlayCellHitsAsync>d__);
			return <PlayCellHitsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B1 RID: 219313 RVA: 0x00EF4044 File Offset: 0x00EF2244
		private UniTask PlayClearAndOpenStrikesAsync(MatchThreeGameplayView view, PieceClearEvent ev)
		{
			MatchThreePresenter.<PlayClearAndOpenStrikesAsync>d__125 <PlayClearAndOpenStrikesAsync>d__;
			<PlayClearAndOpenStrikesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayClearAndOpenStrikesAsync>d__.<>4__this = this;
			<PlayClearAndOpenStrikesAsync>d__.view = view;
			<PlayClearAndOpenStrikesAsync>d__.ev = ev;
			<PlayClearAndOpenStrikesAsync>d__.<>1__state = -1;
			<PlayClearAndOpenStrikesAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayClearAndOpenStrikesAsync>d__125>(ref <PlayClearAndOpenStrikesAsync>d__);
			return <PlayClearAndOpenStrikesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B2 RID: 219314 RVA: 0x00EF4098 File Offset: 0x00EF2298
		private bool OpenStrikes(GridPosition origin)
		{
			int num = 0;
			for (int i = this.CellFirstStrikeIdx[MatchThreePresenter.CellIdx(origin)]; i >= 0; i = this.StrikeNext[i])
			{
				MatchThreePresenter.DirectedStrikeTarget directedStrikeTarget = this.StrikeTargets[i];
				if (directedStrikeTarget.IsHit)
				{
					UniTaskCompletionSource<int> uniTaskCompletionSource = this.HitStrikeGates[directedStrikeTarget.EventIndex];
					if (uniTaskCompletionSource != null)
					{
						uniTaskCompletionSource.TrySetResult(num);
					}
				}
				else
				{
					UniTaskCompletionSource<int> uniTaskCompletionSource2 = this.ClearStrikeGates[directedStrikeTarget.EventIndex];
					if (uniTaskCompletionSource2 != null)
					{
						uniTaskCompletionSource2.TrySetResult(num);
					}
				}
				num++;
			}
			return num > 0;
		}

		// Token: 0x060358B3 RID: 219315 RVA: 0x00EF4124 File Offset: 0x00EF2324
		private UniTask PlayStrikeClearAsync(MatchThreeGameplayView view, PieceClearEvent ev, UniTaskCompletionSource<int> gate)
		{
			MatchThreePresenter.<PlayStrikeClearAsync>d__127 <PlayStrikeClearAsync>d__;
			<PlayStrikeClearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStrikeClearAsync>d__.<>4__this = this;
			<PlayStrikeClearAsync>d__.view = view;
			<PlayStrikeClearAsync>d__.ev = ev;
			<PlayStrikeClearAsync>d__.gate = gate;
			<PlayStrikeClearAsync>d__.<>1__state = -1;
			<PlayStrikeClearAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayStrikeClearAsync>d__127>(ref <PlayStrikeClearAsync>d__);
			return <PlayStrikeClearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B4 RID: 219316 RVA: 0x00EF4180 File Offset: 0x00EF2380
		public UniTask PlayMechanicTipAsync(IReadOnlyList<MechanicTipEvent> tips)
		{
			if (this.View == null)
			{
				return UniTask.CompletedTask;
			}
			for (int i = 0; i < tips.Count; i++)
			{
				this.PendingMechanicTips.Add(tips[i]);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x060358B5 RID: 219317 RVA: 0x00EF41C4 File Offset: 0x00EF23C4
		private UniTask PlayPendingMechanicTipsAsync(MatchThreeGameplayView view)
		{
			MatchThreePresenter.<PlayPendingMechanicTipsAsync>d__130 <PlayPendingMechanicTipsAsync>d__;
			<PlayPendingMechanicTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPendingMechanicTipsAsync>d__.<>4__this = this;
			<PlayPendingMechanicTipsAsync>d__.view = view;
			<PlayPendingMechanicTipsAsync>d__.<>1__state = -1;
			<PlayPendingMechanicTipsAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayPendingMechanicTipsAsync>d__130>(ref <PlayPendingMechanicTipsAsync>d__);
			return <PlayPendingMechanicTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B6 RID: 219318 RVA: 0x00EF4210 File Offset: 0x00EF2410
		public UniTask PlaySkillTipAsync(IReadOnlyList<SkillTipEvent> tips)
		{
			MatchThreePresenter.<PlaySkillTipAsync>d__131 <PlaySkillTipAsync>d__;
			<PlaySkillTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySkillTipAsync>d__.<>4__this = this;
			<PlaySkillTipAsync>d__.tips = tips;
			<PlaySkillTipAsync>d__.<>1__state = -1;
			<PlaySkillTipAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlaySkillTipAsync>d__131>(ref <PlaySkillTipAsync>d__);
			return <PlaySkillTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B7 RID: 219319 RVA: 0x00EF425C File Offset: 0x00EF245C
		private UniTask ShowThenHideSkillTipAsync(SkillTipEvent tip)
		{
			MatchThreePresenter.<ShowThenHideSkillTipAsync>d__132 <ShowThenHideSkillTipAsync>d__;
			<ShowThenHideSkillTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowThenHideSkillTipAsync>d__.<>4__this = this;
			<ShowThenHideSkillTipAsync>d__.tip = tip;
			<ShowThenHideSkillTipAsync>d__.<>1__state = -1;
			<ShowThenHideSkillTipAsync>d__.<>t__builder.Start<MatchThreePresenter.<ShowThenHideSkillTipAsync>d__132>(ref <ShowThenHideSkillTipAsync>d__);
			return <ShowThenHideSkillTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358B8 RID: 219320 RVA: 0x00EF42A8 File Offset: 0x00EF24A8
		public UniTask PlayScorePopAsync(IReadOnlyList<ScorePopEvent> pops)
		{
			if (this.View == null)
			{
				return UniTask.CompletedTask;
			}
			for (int i = 0; i < pops.Count; i++)
			{
				this.TurnScore += pops[i].SegmentScore;
			}
			return this.View.ShowScorePopAsync(this.TurnScore);
		}

		// Token: 0x060358B9 RID: 219321 RVA: 0x00EF4300 File Offset: 0x00EF2500
		public UniTask PlayPieceTransformAsync(IReadOnlyList<PieceTransformEvent> transforms)
		{
			MatchThreePresenter.<PlayPieceTransformAsync>d__134 <PlayPieceTransformAsync>d__;
			<PlayPieceTransformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPieceTransformAsync>d__.<>4__this = this;
			<PlayPieceTransformAsync>d__.transforms = transforms;
			<PlayPieceTransformAsync>d__.<>1__state = -1;
			<PlayPieceTransformAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayPieceTransformAsync>d__134>(ref <PlayPieceTransformAsync>d__);
			return <PlayPieceTransformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358BA RID: 219322 RVA: 0x00EF434C File Offset: 0x00EF254C
		public UniTask PlayPieceAttachAsync(IReadOnlyList<PieceAttachEvent> attaches)
		{
			MatchThreePresenter.<PlayPieceAttachAsync>d__135 <PlayPieceAttachAsync>d__;
			<PlayPieceAttachAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPieceAttachAsync>d__.<>4__this = this;
			<PlayPieceAttachAsync>d__.attaches = attaches;
			<PlayPieceAttachAsync>d__.<>1__state = -1;
			<PlayPieceAttachAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayPieceAttachAsync>d__135>(ref <PlayPieceAttachAsync>d__);
			return <PlayPieceAttachAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358BB RID: 219323 RVA: 0x00EF4398 File Offset: 0x00EF2598
		public UniTask PlayPieceRecolorAsync(IReadOnlyList<PieceRecolorEvent> recolors)
		{
			MatchThreePresenter.<PlayPieceRecolorAsync>d__136 <PlayPieceRecolorAsync>d__;
			<PlayPieceRecolorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPieceRecolorAsync>d__.<>4__this = this;
			<PlayPieceRecolorAsync>d__.recolors = recolors;
			<PlayPieceRecolorAsync>d__.<>1__state = -1;
			<PlayPieceRecolorAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayPieceRecolorAsync>d__136>(ref <PlayPieceRecolorAsync>d__);
			return <PlayPieceRecolorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358BC RID: 219324 RVA: 0x00EF43E3 File Offset: 0x00EF25E3
		private static int GetPieceRecolorDelayMs(PieceRecolorEvent recolor, int index)
		{
			if (recolor.Presentation == ESkillRecolorPresentation.AllureUltimate)
			{
				return index * 20;
			}
			return index * 40;
		}

		// Token: 0x060358BD RID: 219325 RVA: 0x00EF43F8 File Offset: 0x00EF25F8
		public UniTask PlaySkillTrailAsync(IReadOnlyList<SkillTrailEvent> trails)
		{
			MatchThreePresenter.<PlaySkillTrailAsync>d__138 <PlaySkillTrailAsync>d__;
			<PlaySkillTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySkillTrailAsync>d__.<>4__this = this;
			<PlaySkillTrailAsync>d__.trails = trails;
			<PlaySkillTrailAsync>d__.<>1__state = -1;
			<PlaySkillTrailAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlaySkillTrailAsync>d__138>(ref <PlaySkillTrailAsync>d__);
			return <PlaySkillTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358BE RID: 219326 RVA: 0x00EF4444 File Offset: 0x00EF2644
		private UniTask PlaySkillTrailAndAttachAsync(MatchThreeGameplayView view, SkillTrailEvent trail, int arriveDelayMs)
		{
			MatchThreePresenter.<PlaySkillTrailAndAttachAsync>d__139 <PlaySkillTrailAndAttachAsync>d__;
			<PlaySkillTrailAndAttachAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySkillTrailAndAttachAsync>d__.view = view;
			<PlaySkillTrailAndAttachAsync>d__.trail = trail;
			<PlaySkillTrailAndAttachAsync>d__.arriveDelayMs = arriveDelayMs;
			<PlaySkillTrailAndAttachAsync>d__.<>1__state = -1;
			<PlaySkillTrailAndAttachAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlaySkillTrailAndAttachAsync>d__139>(ref <PlaySkillTrailAndAttachAsync>d__);
			return <PlaySkillTrailAndAttachAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358BF RID: 219327 RVA: 0x00EF4498 File Offset: 0x00EF2698
		public UniTask PlayMechanicTrailAsync(IReadOnlyList<MechanicTrailEvent> trails)
		{
			MatchThreePresenter.<PlayMechanicTrailAsync>d__140 <PlayMechanicTrailAsync>d__;
			<PlayMechanicTrailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMechanicTrailAsync>d__.<>4__this = this;
			<PlayMechanicTrailAsync>d__.trails = trails;
			<PlayMechanicTrailAsync>d__.<>1__state = -1;
			<PlayMechanicTrailAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayMechanicTrailAsync>d__140>(ref <PlayMechanicTrailAsync>d__);
			return <PlayMechanicTrailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358C0 RID: 219328 RVA: 0x00EF44E4 File Offset: 0x00EF26E4
		public UniTask PlayRecycleTrailSettleAsync(IReadOnlyList<RecycleTrailSettleEvent> settles)
		{
			MatchThreePresenter.<PlayRecycleTrailSettleAsync>d__141 <PlayRecycleTrailSettleAsync>d__;
			<PlayRecycleTrailSettleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRecycleTrailSettleAsync>d__.<>4__this = this;
			<PlayRecycleTrailSettleAsync>d__.settles = settles;
			<PlayRecycleTrailSettleAsync>d__.<>1__state = -1;
			<PlayRecycleTrailSettleAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayRecycleTrailSettleAsync>d__141>(ref <PlayRecycleTrailSettleAsync>d__);
			return <PlayRecycleTrailSettleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358C1 RID: 219329 RVA: 0x00EF452F File Offset: 0x00EF272F
		private void OnGameWin()
		{
			if (!this.TryBeginSettlement())
			{
				return;
			}
			this.OpenSuccessSettlement(1, 1);
		}

		// Token: 0x060358C2 RID: 219330 RVA: 0x00EF4544 File Offset: 0x00EF2744
		public void HandleExitConfirmed()
		{
			if (!this.TryBeginSettlement())
			{
				return;
			}
			if (!this.IsEndlessLevel())
			{
				this.ReportSettleLog(0, 2);
				MatchThreePresenter.EndGame();
				return;
			}
			Dictionary<EGoalCondType, int> results = this.PackResults();
			if (this.Game.Score <= 0)
			{
				this.ReportSettleLog(0, 2);
				MatchThreeController.Instance.SubmitResult(results);
				MatchThreePresenter.EndGame();
				return;
			}
			this.OpenSuccessSettlement(1, 2);
		}

		// Token: 0x060358C3 RID: 219331 RVA: 0x00EF45A6 File Offset: 0x00EF27A6
		private bool TryBeginSettlement()
		{
			if (this.SettlementStarted)
			{
				return false;
			}
			this.SettlementStarted = true;
			return true;
		}

		// Token: 0x060358C4 RID: 219332 RVA: 0x00EF45BC File Offset: 0x00EF27BC
		private void OpenSuccessSettlement(int result, int reason)
		{
			MatchThreeSuccessPopParams param = this.PackSuccessParams();
			this.ReportSettleLog(result, reason);
			MatchThreeController.Instance.SubmitResult(this.PackResults());
			UiManager.Instance.OpenView(EUiViewName.MatchThreeSuccessPopView, param, null);
		}

		// Token: 0x060358C5 RID: 219333 RVA: 0x00EF45F9 File Offset: 0x00EF27F9
		private void OnGameLose()
		{
			if (this.TryBeginSettlement())
			{
				this.ReportSettleLog(0, 1);
			}
			UiManager.Instance.OpenView(EUiViewName.MatchThreeFailPopView, new Action(this.OnFailPopClosed), null);
		}

		// Token: 0x060358C6 RID: 219334 RVA: 0x00EF4628 File Offset: 0x00EF2828
		private void OnFailPopClosed()
		{
			this.FailsSinceLowerDifficulty++;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchThreeRestartConfirm);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.GiveUpAfterLose);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.OnRestartConfirmed);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060358C7 RID: 219335 RVA: 0x00EF468A File Offset: 0x00EF288A
		private void GiveUpAfterLose()
		{
			MatchThreeController.Instance.SubmitResult(this.PackResults());
			MatchThreePresenter.EndGame();
		}

		// Token: 0x060358C8 RID: 219336 RVA: 0x00EF46A4 File Offset: 0x00EF28A4
		private void OnRestartConfirmed()
		{
			if (this.FailsSinceLowerDifficulty < 2 || !this.Game.CanLowerGoalDifficulty)
			{
				this.RestartAsync(false).Forget<bool>();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchThreeLowerDifficultyConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				this.RestartAsync(false).Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[2] = new Action(this.OnLowerDifficultyConfirmed);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060358C9 RID: 219337 RVA: 0x00EF471B File Offset: 0x00EF291B
		private void OnLowerDifficultyConfirmed()
		{
			this.FailsSinceLowerDifficulty = 0;
			this.RestartAsync(true).Forget<bool>();
		}

		// Token: 0x060358CA RID: 219338 RVA: 0x00EF4730 File Offset: 0x00EF2930
		private static void EndGame()
		{
			MatchThreeController.Instance.End(true);
		}

		// Token: 0x060358CB RID: 219339 RVA: 0x00EF473D File Offset: 0x00EF293D
		private static void EndGameAfterWin()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (MatchThreePresenter.IsHardLevel((context != null) ? context.LevelId : 0))
			{
				UiManager.Instance.CloseView(EUiViewName.MatchThreeLevelDetailView, null);
			}
			MatchThreeController.Instance.End(true);
		}

		// Token: 0x060358CC RID: 219340 RVA: 0x00EF4778 File Offset: 0x00EF2978
		private static bool IsHardLevel(int levelId)
		{
			if (levelId <= 0)
			{
				return false;
			}
			MatchThreeLevel? levelConfig = ActivityMatchThreeConfig.Instance.GetLevelConfig(levelId);
			if (levelConfig != null && levelConfig.GetValueOrDefault().Difficulty > 0)
			{
				return true;
			}
			using (IEnumerator<MatchThreeChapterSelectData> enumerator = ActivityMatchThreeController.Instance.GetAllLevelSelectData().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HardLevelId == levelId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060358CD RID: 219341 RVA: 0x00EF4800 File Offset: 0x00EF2A00
		private bool IsEndlessLevel()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			int levelId = (context != null) ? context.LevelId : 0;
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			MatchThreeLevel? matchThreeLevel = (matchThreeData != null) ? matchThreeData.GetLevelConfig(levelId) : null;
			if (matchThreeLevel == null)
			{
				matchThreeLevel = ActivityMatchThreeConfig.Instance.GetLevelConfig(levelId);
			}
			if (matchThreeLevel != null)
			{
				return matchThreeLevel.Value.EndLess;
			}
			return this.Goals.Count == 0;
		}

		// Token: 0x060358CE RID: 219342 RVA: 0x00EF4880 File Offset: 0x00EF2A80
		private MatchThreeSuccessPopParams PackSuccessParams()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			int num = (context != null) ? context.LevelId : 0;
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			MatchThreeLevelInfo matchThreeLevelInfo = (matchThreeData != null) ? matchThreeData.GetLevelInfo(num) : null;
			MatchThreeLevel? matchThreeLevel = (matchThreeData != null) ? matchThreeData.GetLevelConfig(num) : null;
			MatchThreeLevel? matchThreeLevel2 = (matchThreeLevel != null) ? matchThreeLevel : ActivityMatchThreeConfig.Instance.GetLevelConfig(num);
			bool flag = this.IsEndlessLevel();
			bool flag2 = matchThreeLevelInfo == null || !matchThreeLevelInfo.FirstPass;
			int num2 = (matchThreeLevelInfo != null && matchThreeLevelInfo.HasScore) ? matchThreeLevelInfo.Score : 0;
			List<TItem> list = new List<TItem>();
			if (flag2 && matchThreeLevel2 != null && matchThreeLevel2.Value.RewardDrop > 0 && (!flag || this.Game.Score > 0))
			{
				list.AddRange(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(matchThreeLevel2.Value.RewardDrop));
			}
			MatchThreeSuccessPopParams matchThreeSuccessPopParams = new MatchThreeSuccessPopParams();
			matchThreeSuccessPopParams.IsEndless = flag;
			matchThreeSuccessPopParams.Score = this.Game.Score;
			matchThreeSuccessPopParams.IsNewRecord = (flag && this.Game.Score > num2);
			matchThreeSuccessPopParams.Rewards = list;
			Action onExit;
			if ((onExit = MatchThreePresenter.<>O.<0>__EndGameAfterWin) == null)
			{
				onExit = (MatchThreePresenter.<>O.<0>__EndGameAfterWin = new Action(MatchThreePresenter.EndGameAfterWin));
			}
			matchThreeSuccessPopParams.OnExit = onExit;
			MatchThreeSuccessPopParams matchThreeSuccessPopParams2 = matchThreeSuccessPopParams;
			if (flag)
			{
				matchThreeSuccessPopParams2.OnPrepareRetry = new Func<UniTask<bool>>(MatchThreeController.Instance.PrepareRetryAfterWinAsync);
				matchThreeSuccessPopParams2.OnRetryAfterClose = new Action(MatchThreeController.Instance.RetryAfterWinAfterClose);
			}
			return matchThreeSuccessPopParams2;
		}

		// Token: 0x060358CF RID: 219343 RVA: 0x00EF4A08 File Offset: 0x00EF2C08
		private Dictionary<EGoalCondType, int> PackResults()
		{
			Dictionary<EGoalCondType, int> dictionary = new Dictionary<EGoalCondType, int>();
			dictionary[EGoalCondType.Score] = this.Game.Score;
			Dictionary<EGoalCondType, int> dictionary2 = dictionary;
			foreach (LevelGoal levelGoal in this.Goals)
			{
				ClearTypeCountGoal clearTypeCountGoal = levelGoal as ClearTypeCountGoal;
				if (clearTypeCountGoal != null)
				{
					dictionary2[clearTypeCountGoal.CondType] = this.Game.ClearedCountOf(clearTypeCountGoal.TargetType);
				}
			}
			return dictionary2;
		}

		// Token: 0x060358D0 RID: 219344 RVA: 0x00EF4A8C File Offset: 0x00EF2C8C
		private void ReportSettleLog(int result, int reason)
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (context == null)
			{
				return;
			}
			ActivityMatchThreeData matchThreeData = ActivityMatchThreeController.Instance.GetMatchThreeData();
			bool flag = matchThreeData != null && matchThreeData.CheckChallengeComplete(context.LevelId);
			MatchThreeLevelSettleLogData matchThreeLevelSettleLogData = new MatchThreeLevelSettleLogData
			{
				i_activity_id = ActivityMatchThreeController.Instance.ActivityId,
				i_activity_type = 116,
				i_level_id = context.LevelId,
				i_inst_diff = ActivityMatchThreeConfig.Instance.GetReportDifficulty(context.LevelId),
				s_trace_id = context.TraceId,
				i_role_id = context.RoleId,
				i_result = result,
				i_reason = reason,
				i_score = this.Game.Score,
				i_score_limit = this.ResolveScoreLimit(),
				i_round = this.Game.RemainingTurns,
				i_count = this.Game.Round,
				i_first_pass = ((result == 1 && !flag) ? 1 : 0),
				i_cost_time = this.ResolveCostTimeSeconds(),
				s_tag = this.PackAchievedGoalTag()
			};
			matchThreeLevelSettleLogData.o_target_detail.Add(this.PackTargetDetail());
			LogReportController.Instance.LogReport(matchThreeLevelSettleLogData);
		}

		// Token: 0x060358D1 RID: 219345 RVA: 0x00EF4BB0 File Offset: 0x00EF2DB0
		private int ResolveScoreLimit()
		{
			int num = 0;
			foreach (LevelGoal levelGoal in this.Goals)
			{
				if (levelGoal.CondType == EGoalCondType.Score)
				{
					return levelGoal.Target;
				}
				if (num == 0 && levelGoal is ClearTypeCountGoal)
				{
					num = levelGoal.Target;
				}
			}
			return num;
		}

		// Token: 0x060358D2 RID: 219346 RVA: 0x00EF4C20 File Offset: 0x00EF2E20
		private int ResolveCostTimeSeconds()
		{
			long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.LevelStartTime;
			if (num > 0L)
			{
				return (int)Math.Round((double)num / 1000.0);
			}
			return 0;
		}

		// Token: 0x060358D3 RID: 219347 RVA: 0x00EF4C5C File Offset: 0x00EF2E5C
		private string PackAchievedGoalTag()
		{
			List<string> list = new List<string>();
			foreach (LevelGoal levelGoal in this.Goals)
			{
				if (levelGoal.IsAchieved)
				{
					list.Add(((int)levelGoal.CondType).ToString());
				}
			}
			return string.Join(",", list);
		}

		// Token: 0x060358D4 RID: 219348 RVA: 0x00EF4CD0 File Offset: 0x00EF2ED0
		private MatchThreeTargetDetailData PackTargetDetail()
		{
			MatchThreeStatsKeeper stats = this.Game.Stats;
			MatchThreeTargetDetailData matchThreeTargetDetailData = new MatchThreeTargetDetailData();
			matchThreeTargetDetailData.i_big_skill = stats.BigSkillCount;
			matchThreeTargetDetailData.i_small_skill = stats.SmallSkillCount;
			matchThreeTargetDetailData.i_gen_bomb = stats.GeneratedBombCount;
			matchThreeTargetDetailData.i_gen_cross = stats.GeneratedCrossCount;
			matchThreeTargetDetailData.i_gen_ulti = stats.GeneratedUltimateCount;
			matchThreeTargetDetailData.i_del_bomb = stats.ClearedBombCount;
			matchThreeTargetDetailData.i_del_cross = stats.ClearedCrossCount;
			matchThreeTargetDetailData.i_del_ulti = stats.ClearedUltimateCount;
			matchThreeTargetDetailData.i_max_score = stats.MaxSegmentScore;
			matchThreeTargetDetailData.i_gen_round = stats.HourglassTurnGain;
			matchThreeTargetDetailData.i_del_glass = this.Game.ClearedCountOf(EPieceType.Hourglass);
			matchThreeTargetDetailData.i_del_bott = this.Game.ClearedCountOf(EPieceType.Charger);
			matchThreeTargetDetailData.o_round_count.AddRange(stats.RoundCountByGrade);
			return matchThreeTargetDetailData;
		}

		// Token: 0x060358D5 RID: 219349 RVA: 0x00EF4D9C File Offset: 0x00EF2F9C
		public void Dispose()
		{
			this.AbortInitialPresentationFlow();
			this.Game.AbortResolve();
			this.PendingMechanicTips.Clear();
			this.Game.OnWin = null;
			this.Game.OnLose = null;
			this.Game.OnSegmentPlay = null;
			this.Game.Dispose();
			this.View = null;
		}

		// Token: 0x0401C4E2 RID: 115938
		private readonly MatchThreeGame Game;

		// Token: 0x0401C4E3 RID: 115939
		[Nullable(2)]
		private MatchThreeGameplayView View;

		// Token: 0x0401C4E4 RID: 115940
		private readonly List<SkillPointDisplayData> SkillPoints = new List<SkillPointDisplayData>();

		// Token: 0x0401C4E5 RID: 115941
		private int EnergyDisplay;

		// Token: 0x0401C4E6 RID: 115942
		private int PoolWatermark;

		// Token: 0x0401C4E7 RID: 115943
		private bool Restarting;

		// Token: 0x0401C4E8 RID: 115944
		[Nullable(2)]
		private UniTaskCompletionSource ResolveFinished;

		// Token: 0x0401C4E9 RID: 115945
		private int TurnScore;

		// Token: 0x0401C4EA RID: 115946
		private readonly List<MechanicTipEvent> PendingMechanicTips = new List<MechanicTipEvent>();

		// Token: 0x0401C4EB RID: 115947
		private bool InitialMechanicTipsPlayed;

		// Token: 0x0401C4EC RID: 115948
		private bool InitialMechanicTipsPlaying;

		// Token: 0x0401C4ED RID: 115949
		private bool InitialPresentationFlowRunning;

		// Token: 0x0401C4EE RID: 115950
		private bool InitialGuideViewEventsBound;

		// Token: 0x0401C4EF RID: 115951
		private int InitialGuideGroupId;

		// Token: 0x0401C4F0 RID: 115952
		private int InitialTutorialViewId;

		// Token: 0x0401C4F1 RID: 115953
		[Nullable(2)]
		private UniTaskCompletionSource InitialTutorialCloseSource;

		// Token: 0x0401C4F2 RID: 115954
		[Nullable(2)]
		private UniTaskCompletionSource InitialPresentationAbortSource;

		// Token: 0x0401C4F3 RID: 115955
		private bool InitialPresentationAborted;

		// Token: 0x0401C4F4 RID: 115956
		private int TurnGainPresentedDuringResolve;

		// Token: 0x0401C4F5 RID: 115957
		private readonly List<UniTask> TransformTasks = new List<UniTask>();

		// Token: 0x0401C4F6 RID: 115958
		private readonly List<UniTask> AttachTasks = new List<UniTask>();

		// Token: 0x0401C4F7 RID: 115959
		private readonly List<UniTask> RecolorTasks = new List<UniTask>();

		// Token: 0x0401C4F8 RID: 115960
		private readonly List<UniTask> SkillTrailTasks = new List<UniTask>();

		// Token: 0x0401C4F9 RID: 115961
		private readonly List<UniTask> MechanicTrailTasks = new List<UniTask>();

		// Token: 0x0401C4FA RID: 115962
		private readonly List<UniTask>[] ColClearTasks = new List<UniTask>[8];

		// Token: 0x0401C4FB RID: 115963
		private readonly List<UniTask> ColumnTasks = new List<UniTask>();

		// Token: 0x0401C4FC RID: 115964
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] ColumnGates = new UniTaskCompletionSource[8];

		// Token: 0x0401C4FD RID: 115965
		private readonly int[] ColumnClearPending = new int[8];

		// Token: 0x0401C4FE RID: 115966
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<MatchThreePieceView> HitTargets = new List<MatchThreePieceView>();

		// Token: 0x0401C4FF RID: 115967
		[TupleElementNames(new string[]
		{
			"Start",
			"Count"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> MoveTrips = new List<ValueTuple<int, int>>();

		// Token: 0x0401C500 RID: 115968
		private readonly List<UniTask> MoveTasks = new List<UniTask>();

		// Token: 0x0401C501 RID: 115969
		private bool TileAddAudioPlayed;

		// Token: 0x0401C502 RID: 115970
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<MatchThreePieceView> MovePieces = new List<MatchThreePieceView>();

		// Token: 0x0401C503 RID: 115971
		private readonly int[] CellClearIdx = new int[56];

		// Token: 0x0401C504 RID: 115972
		private readonly int[] CellFirstHitIdx = new int[56];

		// Token: 0x0401C505 RID: 115973
		private readonly List<int> HitNext = new List<int>();

		// Token: 0x0401C506 RID: 115974
		private readonly int[] CellLastIdx = new int[56];

		// Token: 0x0401C507 RID: 115975
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UniTaskCompletionSource<int>> ClearStrikeGates = new List<UniTaskCompletionSource<int>>();

		// Token: 0x0401C508 RID: 115976
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UniTaskCompletionSource<int>> HitStrikeGates = new List<UniTaskCompletionSource<int>>();

		// Token: 0x0401C509 RID: 115977
		private readonly int[] CellFirstStrikeIdx = new int[56];

		// Token: 0x0401C50A RID: 115978
		private readonly List<int> StrikeNext = new List<int>();

		// Token: 0x0401C50B RID: 115979
		private readonly List<MatchThreePresenter.DirectedStrikeTarget> StrikeTargets = new List<MatchThreePresenter.DirectedStrikeTarget>();

		// Token: 0x0401C50C RID: 115980
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] LandGates = new UniTaskCompletionSource[56];

		// Token: 0x0401C50D RID: 115981
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] DetonationGates = new UniTaskCompletionSource[56];

		// Token: 0x0401C50E RID: 115982
		[Nullable(2)]
		private UniTaskCompletionSource UltimateFullUpGate;

		// Token: 0x0401C50F RID: 115983
		private const int LowerDifficultyFailCount = 2;

		// Token: 0x0401C510 RID: 115984
		private bool SettlementStarted;

		// Token: 0x0401C511 RID: 115985
		private int FailsSinceLowerDifficulty;

		// Token: 0x0401C512 RID: 115986
		private long LevelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

		// Token: 0x0200B09C RID: 45212
		[NullableContext(0)]
		private readonly struct DirectedStrikeTarget
		{
			// Token: 0x060472B3 RID: 291507 RVA: 0x0158B5E2 File Offset: 0x015897E2
			public DirectedStrikeTarget(bool isHit, int eventIndex)
			{
				this.IsHit = isHit;
				this.EventIndex = eventIndex;
			}

			// Token: 0x04036942 RID: 223554
			public readonly bool IsHit;

			// Token: 0x04036943 RID: 223555
			public readonly int EventIndex;
		}

		// Token: 0x0200B09D RID: 45213
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04036944 RID: 223556
			[Nullable(0)]
			public static Action <0>__EndGameAfterWin;
		}
	}
}
