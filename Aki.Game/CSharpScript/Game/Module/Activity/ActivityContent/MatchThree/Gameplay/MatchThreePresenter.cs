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
	// Token: 0x020064C6 RID: 25798
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePresenter : IMatchThreePresentation
	{
		// Token: 0x06040BA8 RID: 265128 RVA: 0x00FAB868 File Offset: 0x00FA9A68
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

		// Token: 0x06040BA9 RID: 265129 RVA: 0x00FABA32 File Offset: 0x00FA9C32
		public void BindView(MatchThreeGameplayView view)
		{
			this.View = view;
		}

		// Token: 0x170094D1 RID: 38097
		// (get) Token: 0x06040BAA RID: 265130 RVA: 0x00FABA3B File Offset: 0x00FA9C3B
		public Board Board
		{
			get
			{
				return this.Game.Board;
			}
		}

		// Token: 0x170094D2 RID: 38098
		// (get) Token: 0x06040BAB RID: 265131 RVA: 0x00FABA48 File Offset: 0x00FA9C48
		public IReadOnlyList<LevelGoal> Goals
		{
			get
			{
				return this.Game.Goals;
			}
		}

		// Token: 0x170094D3 RID: 38099
		// (get) Token: 0x06040BAC RID: 265132 RVA: 0x00FABA55 File Offset: 0x00FA9C55
		public int RemainingTurns
		{
			get
			{
				return this.Game.RemainingTurns;
			}
		}

		// Token: 0x170094D4 RID: 38100
		// (get) Token: 0x06040BAD RID: 265133 RVA: 0x00FABA62 File Offset: 0x00FA9C62
		public int MaxTurns
		{
			get
			{
				return this.Game.MaxTurns;
			}
		}

		// Token: 0x170094D5 RID: 38101
		// (get) Token: 0x06040BAE RID: 265134 RVA: 0x00FABA6F File Offset: 0x00FA9C6F
		public int LastTurnCostDelta
		{
			get
			{
				return this.Game.LastTurnCostDelta;
			}
		}

		// Token: 0x170094D6 RID: 38102
		// (get) Token: 0x06040BAF RID: 265135 RVA: 0x00FABA7C File Offset: 0x00FA9C7C
		public int Score
		{
			get
			{
				return this.Game.Score;
			}
		}

		// Token: 0x170094D7 RID: 38103
		// (get) Token: 0x06040BB0 RID: 265136 RVA: 0x00FABA89 File Offset: 0x00FA9C89
		public IReadOnlyList<ValidMove> LastValidMoves
		{
			get
			{
				return this.Game.LastValidMoves;
			}
		}

		// Token: 0x170094D8 RID: 38104
		// (get) Token: 0x06040BB1 RID: 265137 RVA: 0x00FABA96 File Offset: 0x00FA9C96
		public bool LastSwapAccepted
		{
			get
			{
				return this.Game.LastSwapAccepted;
			}
		}

		// Token: 0x170094D9 RID: 38105
		// (get) Token: 0x06040BB2 RID: 265138 RVA: 0x00FABAA4 File Offset: 0x00FA9CA4
		public bool IsGameOver
		{
			get
			{
				EMatchThreeGameState state = this.Game.State;
				return state - EMatchThreeGameState.Win <= 1;
			}
		}

		// Token: 0x06040BB3 RID: 265139 RVA: 0x00FABACC File Offset: 0x00FA9CCC
		public bool CanFocusBoard()
		{
			return !this.InitialPresentationFlowRunning && !this.InitialMechanicTipsPlaying && !this.Game.InputLocked && this.Game.State == EMatchThreeGameState.WaitingInput && this.ResolveFinished == null && !this.Restarting && !this.IsGameOver && this.View != null;
		}

		// Token: 0x170094DA RID: 38106
		// (get) Token: 0x06040BB4 RID: 265140 RVA: 0x00FABB26 File Offset: 0x00FA9D26
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

		// Token: 0x170094DB RID: 38107
		// (get) Token: 0x06040BB5 RID: 265141 RVA: 0x00FABB39 File Offset: 0x00FA9D39
		public int FullEnergy
		{
			get
			{
				return this.Game.FullEnergy;
			}
		}

		// Token: 0x06040BB6 RID: 265142 RVA: 0x00FABB46 File Offset: 0x00FA9D46
		public IReadOnlyList<SkillPointDisplayData> CollectSkillPoints()
		{
			return this.SkillPoints;
		}

		// Token: 0x06040BB7 RID: 265143 RVA: 0x00FABB4E File Offset: 0x00FA9D4E
		private void SyncEnergyDisplay()
		{
			this.PoolWatermark = this.Game.Energy;
			this.EnergyDisplay = this.PoolWatermark;
			this.Game.CollectSkillPoints(this.SkillPoints, this.Energy);
		}

		// Token: 0x06040BB8 RID: 265144 RVA: 0x00FABB84 File Offset: 0x00FA9D84
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

		// Token: 0x06040BB9 RID: 265145 RVA: 0x00FABBE4 File Offset: 0x00FA9DE4
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

		// Token: 0x06040BBA RID: 265146 RVA: 0x00FABC58 File Offset: 0x00FA9E58
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

		// Token: 0x06040BBB RID: 265147 RVA: 0x00FABCC0 File Offset: 0x00FA9EC0
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

		// Token: 0x06040BBC RID: 265148 RVA: 0x00FABD0C File Offset: 0x00FA9F0C
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

		// Token: 0x06040BBD RID: 265149 RVA: 0x00FABD58 File Offset: 0x00FA9F58
		private UniTask AbortRunningResolveAsync()
		{
			MatchThreePresenter.<AbortRunningResolveAsync>d__37 <AbortRunningResolveAsync>d__;
			<AbortRunningResolveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AbortRunningResolveAsync>d__.<>4__this = this;
			<AbortRunningResolveAsync>d__.<>1__state = -1;
			<AbortRunningResolveAsync>d__.<>t__builder.Start<MatchThreePresenter.<AbortRunningResolveAsync>d__37>(ref <AbortRunningResolveAsync>d__);
			return <AbortRunningResolveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040BBE RID: 265150 RVA: 0x00FABD9C File Offset: 0x00FA9F9C
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

		// Token: 0x06040BBF RID: 265151 RVA: 0x00FABDF8 File Offset: 0x00FA9FF8
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

		// Token: 0x06040BC0 RID: 265152 RVA: 0x00FABF04 File Offset: 0x00FAA104
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

		// Token: 0x06040BC1 RID: 265153 RVA: 0x00FABF3C File Offset: 0x00FAA13C
		public UniTask TryPlayInitialGuideThenMechanicTipsAsync()
		{
			MatchThreePresenter.<TryPlayInitialGuideThenMechanicTipsAsync>d__55 <TryPlayInitialGuideThenMechanicTipsAsync>d__;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>4__this = this;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>1__state = -1;
			<TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder.Start<MatchThreePresenter.<TryPlayInitialGuideThenMechanicTipsAsync>d__55>(ref <TryPlayInitialGuideThenMechanicTipsAsync>d__);
			return <TryPlayInitialGuideThenMechanicTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040BC2 RID: 265154 RVA: 0x00FABF80 File Offset: 0x00FAA180
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

		// Token: 0x06040BC3 RID: 265155 RVA: 0x00FABFD4 File Offset: 0x00FAA1D4
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

		// Token: 0x06040BC4 RID: 265156 RVA: 0x00FAC018 File Offset: 0x00FAA218
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

		// Token: 0x06040BC5 RID: 265157 RVA: 0x00FAC064 File Offset: 0x00FAA264
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

		// Token: 0x06040BC6 RID: 265158 RVA: 0x00FAC0B4 File Offset: 0x00FAA2B4
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

		// Token: 0x06040BC7 RID: 265159 RVA: 0x00FAC104 File Offset: 0x00FAA304
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

		// Token: 0x06040BC8 RID: 265160 RVA: 0x00FAC1BF File Offset: 0x00FAA3BF
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

		// Token: 0x06040BC9 RID: 265161 RVA: 0x00FAC1F8 File Offset: 0x00FAA3F8
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

		// Token: 0x06040BCA RID: 265162 RVA: 0x00FAC244 File Offset: 0x00FAA444
		public UniTask PlayInitialMechanicTipsAsync()
		{
			MatchThreePresenter.<PlayInitialMechanicTipsAsync>d__64 <PlayInitialMechanicTipsAsync>d__;
			<PlayInitialMechanicTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayInitialMechanicTipsAsync>d__.<>4__this = this;
			<PlayInitialMechanicTipsAsync>d__.<>1__state = -1;
			<PlayInitialMechanicTipsAsync>d__.<>t__builder.Start<MatchThreePresenter.<PlayInitialMechanicTipsAsync>d__64>(ref <PlayInitialMechanicTipsAsync>d__);
			return <PlayInitialMechanicTipsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040BCB RID: 265163 RVA: 0x00FAC288 File Offset: 0x00FAA488
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

		// Token: 0x06040BCC RID: 265164 RVA: 0x00FAC2F0 File Offset: 0x00FAA4F0
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

		// Token: 0x06040BCD RID: 265165 RVA: 0x00FAC344 File Offset: 0x00FAA544
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

		// Token: 0x06040BCE RID: 265166 RVA: 0x00FAC37C File Offset: 0x00FAA57C
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

		// Token: 0x06040BCF RID: 265167 RVA: 0x00FAC3B0 File Offset: 0x00FAA5B0
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

		// Token: 0x06040BD0 RID: 265168 RVA: 0x00FAC3FC File Offset: 0x00FAA5FC
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

		// Token: 0x06040BD1 RID: 265169 RVA: 0x00FAC447 File Offset: 0x00FAA647
		private static int CellIdx(GridPosition pos)
		{
			return pos.Row * 8 + pos.Col;
		}

		// Token: 0x06040BD2 RID: 265170 RVA: 0x00FAC458 File Offset: 0x00FAA658
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

		// Token: 0x06040BD3 RID: 265171 RVA: 0x00FAC530 File Offset: 0x00FAA730
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

		// Token: 0x06040BD4 RID: 265172 RVA: 0x00FAC5B0 File Offset: 0x00FAA7B0
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

		// Token: 0x06040BD5 RID: 265173 RVA: 0x00FAC5E8 File Offset: 0x00FAA7E8
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

		// Token: 0x06040BD6 RID: 265174 RVA: 0x00FAC69C File Offset: 0x00FAA89C
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

		// Token: 0x06040BD7 RID: 265175 RVA: 0x00FAC700 File Offset: 0x00FAA900
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

		// Token: 0x06040BD8 RID: 265176 RVA: 0x00FAC76D File Offset: 0x00FAA96D
		private void PlayTileAddAudio()
		{
			if (this.TileAddAudioPlayed)
			{
				return;
			}
			this.TileAddAudioPlayed = true;
			AudioSystem.Instance.PostEvent("play_ui_match3game_game_tile_add");
		}

		// Token: 0x06040BD9 RID: 265177 RVA: 0x00FAC790 File Offset: 0x00FAA990
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

		// Token: 0x06040BDA RID: 265178 RVA: 0x00FAC8B0 File Offset: 0x00FAAAB0
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

		// Token: 0x06040BDB RID: 265179 RVA: 0x00FAC9AC File Offset: 0x00FAABAC
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

		// Token: 0x06040BDC RID: 265180 RVA: 0x00FACA2C File Offset: 0x00FAAC2C
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

		// Token: 0x06040BDD RID: 265181 RVA: 0x00FACA94 File Offset: 0x00FAAC94
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

		// Token: 0x06040BDE RID: 265182 RVA: 0x00FACB00 File Offset: 0x00FAAD00
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

		// Token: 0x06040BDF RID: 265183 RVA: 0x00FACC00 File Offset: 0x00FAAE00
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

		// Token: 0x06040BE0 RID: 265184 RVA: 0x00FACC69 File Offset: 0x00FAAE69
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

		// Token: 0x06040BE1 RID: 265185 RVA: 0x00FACC9C File Offset: 0x00FAAE9C
		private void OpenLandGate(GridPosition pos)
		{
			UniTaskCompletionSource uniTaskCompletionSource = this.LandGates[MatchThreePresenter.CellIdx(pos)];
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}

		// Token: 0x06040BE2 RID: 265186 RVA: 0x00FACCB8 File Offset: 0x00FAAEB8
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

		// Token: 0x06040BE3 RID: 265187 RVA: 0x00FACD24 File Offset: 0x00FAAF24
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

		// Token: 0x06040BE4 RID: 265188 RVA: 0x00FACDF8 File Offset: 0x00FAAFF8
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

		// Token: 0x06040BE5 RID: 265189 RVA: 0x00FACE59 File Offset: 0x00FAB059
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

		// Token: 0x06040BE6 RID: 265190 RVA: 0x00FACE8C File Offset: 0x00FAB08C
		private void OpenDetonationGate(GridPosition source)
		{
			UniTaskCompletionSource uniTaskCompletionSource = this.DetonationGates[MatchThreePresenter.CellIdx(source)];
			if (uniTaskCompletionSource == null)
			{
				return;
			}
			uniTaskCompletionSource.TrySetResult();
		}

		// Token: 0x06040BE7 RID: 265191 RVA: 0x00FACEA8 File Offset: 0x00FAB0A8
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

		// Token: 0x06040BE8 RID: 265192 RVA: 0x00FACEE8 File Offset: 0x00FAB0E8
		private UniTask WaitUltimateFullUpAsync(PieceClearEvent ev)
		{
			if (this.UltimateFullUpGate == null || ev.Reason == EPieceClearReason.UltimateAllManual || ev.Reason == EPieceClearReason.UltimateAllPassive)
			{
				return UniTask.CompletedTask;
			}
			return this.WaitUltimateFullUpAsync();
		}

		// Token: 0x06040BE9 RID: 265193 RVA: 0x00FACF10 File Offset: 0x00FAB110
		private UniTask WaitUltimateFullUpAsync()
		{
			UniTaskCompletionSource ultimateFullUpGate = this.UltimateFullUpGate;
			if (ultimateFullUpGate == null)
			{
				return UniTask.CompletedTask;
			}
			return ultimateFullUpGate.Task;
		}

		// Token: 0x06040BEA RID: 265194 RVA: 0x00FACF27 File Offset: 0x00FAB127
		private void OpenUltimateFullUpGate()
		{
			UniTaskCompletionSource ultimateFullUpGate = this.UltimateFullUpGate;
			if (ultimateFullUpGate == null)
			{
				return;
			}
			ultimateFullUpGate.TrySetResult();
		}

		// Token: 0x06040BEB RID: 265195 RVA: 0x00FACF3C File Offset: 0x00FAB13C
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

		// Token: 0x06040BEC RID: 265196 RVA: 0x00FACF98 File Offset: 0x00FAB198
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

		// Token: 0x06040BED RID: 265197 RVA: 0x00FACFFC File Offset: 0x00FAB1FC
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

		// Token: 0x06040BEE RID: 265198 RVA: 0x00FAD050 File Offset: 0x00FAB250
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

		// Token: 0x06040BEF RID: 265199 RVA: 0x00FAD0DC File Offset: 0x00FAB2DC
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

		// Token: 0x06040BF0 RID: 265200 RVA: 0x00FAD138 File Offset: 0x00FAB338
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

		// Token: 0x06040BF1 RID: 265201 RVA: 0x00FAD17C File Offset: 0x00FAB37C
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

		// Token: 0x06040BF2 RID: 265202 RVA: 0x00FAD1C8 File Offset: 0x00FAB3C8
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

		// Token: 0x06040BF3 RID: 265203 RVA: 0x00FAD214 File Offset: 0x00FAB414
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

		// Token: 0x06040BF4 RID: 265204 RVA: 0x00FAD260 File Offset: 0x00FAB460
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

		// Token: 0x06040BF5 RID: 265205 RVA: 0x00FAD2B8 File Offset: 0x00FAB4B8
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

		// Token: 0x06040BF6 RID: 265206 RVA: 0x00FAD304 File Offset: 0x00FAB504
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

		// Token: 0x06040BF7 RID: 265207 RVA: 0x00FAD350 File Offset: 0x00FAB550
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

		// Token: 0x06040BF8 RID: 265208 RVA: 0x00FAD39B File Offset: 0x00FAB59B
		private static int GetPieceRecolorDelayMs(PieceRecolorEvent recolor, int index)
		{
			if (recolor.Presentation == ESkillRecolorPresentation.AllureUltimate)
			{
				return index * 20;
			}
			return index * 40;
		}

		// Token: 0x06040BF9 RID: 265209 RVA: 0x00FAD3B0 File Offset: 0x00FAB5B0
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

		// Token: 0x06040BFA RID: 265210 RVA: 0x00FAD3FC File Offset: 0x00FAB5FC
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

		// Token: 0x06040BFB RID: 265211 RVA: 0x00FAD450 File Offset: 0x00FAB650
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

		// Token: 0x06040BFC RID: 265212 RVA: 0x00FAD49C File Offset: 0x00FAB69C
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

		// Token: 0x06040BFD RID: 265213 RVA: 0x00FAD4E7 File Offset: 0x00FAB6E7
		private void OnGameWin()
		{
			if (!this.TryBeginSettlement())
			{
				return;
			}
			this.OpenSuccessSettlement(1, 1);
		}

		// Token: 0x06040BFE RID: 265214 RVA: 0x00FAD4FC File Offset: 0x00FAB6FC
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

		// Token: 0x06040BFF RID: 265215 RVA: 0x00FAD55E File Offset: 0x00FAB75E
		private bool TryBeginSettlement()
		{
			if (this.SettlementStarted)
			{
				return false;
			}
			this.SettlementStarted = true;
			return true;
		}

		// Token: 0x06040C00 RID: 265216 RVA: 0x00FAD574 File Offset: 0x00FAB774
		private void OpenSuccessSettlement(int result, int reason)
		{
			MatchThreeSuccessPopParams param = this.PackSuccessParams();
			this.ReportSettleLog(result, reason);
			MatchThreeController.Instance.SubmitResult(this.PackResults());
			UiManager.Instance.OpenView(EUiViewName.MatchThreeSuccessPopView, param, null);
		}

		// Token: 0x06040C01 RID: 265217 RVA: 0x00FAD5B1 File Offset: 0x00FAB7B1
		private void OnGameLose()
		{
			if (this.TryBeginSettlement())
			{
				this.ReportSettleLog(0, 1);
			}
			UiManager.Instance.OpenView(EUiViewName.MatchThreeFailPopView, new Action(this.OnFailPopClosed), null);
		}

		// Token: 0x06040C02 RID: 265218 RVA: 0x00FAD5E0 File Offset: 0x00FAB7E0
		private void OnFailPopClosed()
		{
			this.FailsSinceLowerDifficulty++;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchThreeRestartConfirm);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.GiveUpAfterLose);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.OnRestartConfirmed);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06040C03 RID: 265219 RVA: 0x00FAD642 File Offset: 0x00FAB842
		private void GiveUpAfterLose()
		{
			MatchThreeController.Instance.SubmitResult(this.PackResults());
			MatchThreePresenter.EndGame();
		}

		// Token: 0x06040C04 RID: 265220 RVA: 0x00FAD65C File Offset: 0x00FAB85C
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

		// Token: 0x06040C05 RID: 265221 RVA: 0x00FAD6D3 File Offset: 0x00FAB8D3
		private void OnLowerDifficultyConfirmed()
		{
			this.FailsSinceLowerDifficulty = 0;
			this.RestartAsync(true).Forget<bool>();
		}

		// Token: 0x06040C06 RID: 265222 RVA: 0x00FAD6E8 File Offset: 0x00FAB8E8
		private static void EndGame()
		{
			MatchThreeController.Instance.End(true);
		}

		// Token: 0x06040C07 RID: 265223 RVA: 0x00FAD6F5 File Offset: 0x00FAB8F5
		private static void EndGameAfterWin()
		{
			MatchThreeGameplayContext context = MatchThreeController.Instance.Context;
			if (MatchThreePresenter.IsHardLevel((context != null) ? context.LevelId : 0))
			{
				UiManager.Instance.CloseView(EUiViewName.MatchThreeLevelDetailView, null);
			}
			MatchThreeController.Instance.End(true);
		}

		// Token: 0x06040C08 RID: 265224 RVA: 0x00FAD730 File Offset: 0x00FAB930
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

		// Token: 0x06040C09 RID: 265225 RVA: 0x00FAD7B8 File Offset: 0x00FAB9B8
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

		// Token: 0x06040C0A RID: 265226 RVA: 0x00FAD838 File Offset: 0x00FABA38
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

		// Token: 0x06040C0B RID: 265227 RVA: 0x00FAD9C0 File Offset: 0x00FABBC0
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

		// Token: 0x06040C0C RID: 265228 RVA: 0x00FADA44 File Offset: 0x00FABC44
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

		// Token: 0x06040C0D RID: 265229 RVA: 0x00FADB68 File Offset: 0x00FABD68
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

		// Token: 0x06040C0E RID: 265230 RVA: 0x00FADBD8 File Offset: 0x00FABDD8
		private int ResolveCostTimeSeconds()
		{
			long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.LevelStartTime;
			if (num > 0L)
			{
				return (int)Math.Round((double)num / 1000.0);
			}
			return 0;
		}

		// Token: 0x06040C0F RID: 265231 RVA: 0x00FADC14 File Offset: 0x00FABE14
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

		// Token: 0x06040C10 RID: 265232 RVA: 0x00FADC88 File Offset: 0x00FABE88
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

		// Token: 0x06040C11 RID: 265233 RVA: 0x00FADD54 File Offset: 0x00FABF54
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

		// Token: 0x04021BB1 RID: 138161
		private readonly MatchThreeGame Game;

		// Token: 0x04021BB2 RID: 138162
		[Nullable(2)]
		private MatchThreeGameplayView View;

		// Token: 0x04021BB3 RID: 138163
		private readonly List<SkillPointDisplayData> SkillPoints = new List<SkillPointDisplayData>();

		// Token: 0x04021BB4 RID: 138164
		private int EnergyDisplay;

		// Token: 0x04021BB5 RID: 138165
		private int PoolWatermark;

		// Token: 0x04021BB6 RID: 138166
		private bool Restarting;

		// Token: 0x04021BB7 RID: 138167
		[Nullable(2)]
		private UniTaskCompletionSource ResolveFinished;

		// Token: 0x04021BB8 RID: 138168
		private int TurnScore;

		// Token: 0x04021BB9 RID: 138169
		private readonly List<MechanicTipEvent> PendingMechanicTips = new List<MechanicTipEvent>();

		// Token: 0x04021BBA RID: 138170
		private bool InitialMechanicTipsPlayed;

		// Token: 0x04021BBB RID: 138171
		private bool InitialMechanicTipsPlaying;

		// Token: 0x04021BBC RID: 138172
		private bool InitialPresentationFlowRunning;

		// Token: 0x04021BBD RID: 138173
		private bool InitialGuideViewEventsBound;

		// Token: 0x04021BBE RID: 138174
		private int InitialGuideGroupId;

		// Token: 0x04021BBF RID: 138175
		private int InitialTutorialViewId;

		// Token: 0x04021BC0 RID: 138176
		[Nullable(2)]
		private UniTaskCompletionSource InitialTutorialCloseSource;

		// Token: 0x04021BC1 RID: 138177
		[Nullable(2)]
		private UniTaskCompletionSource InitialPresentationAbortSource;

		// Token: 0x04021BC2 RID: 138178
		private bool InitialPresentationAborted;

		// Token: 0x04021BC3 RID: 138179
		private int TurnGainPresentedDuringResolve;

		// Token: 0x04021BC4 RID: 138180
		private readonly List<UniTask> TransformTasks = new List<UniTask>();

		// Token: 0x04021BC5 RID: 138181
		private readonly List<UniTask> AttachTasks = new List<UniTask>();

		// Token: 0x04021BC6 RID: 138182
		private readonly List<UniTask> RecolorTasks = new List<UniTask>();

		// Token: 0x04021BC7 RID: 138183
		private readonly List<UniTask> SkillTrailTasks = new List<UniTask>();

		// Token: 0x04021BC8 RID: 138184
		private readonly List<UniTask> MechanicTrailTasks = new List<UniTask>();

		// Token: 0x04021BC9 RID: 138185
		private readonly List<UniTask>[] ColClearTasks = new List<UniTask>[8];

		// Token: 0x04021BCA RID: 138186
		private readonly List<UniTask> ColumnTasks = new List<UniTask>();

		// Token: 0x04021BCB RID: 138187
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] ColumnGates = new UniTaskCompletionSource[8];

		// Token: 0x04021BCC RID: 138188
		private readonly int[] ColumnClearPending = new int[8];

		// Token: 0x04021BCD RID: 138189
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<MatchThreePieceView> HitTargets = new List<MatchThreePieceView>();

		// Token: 0x04021BCE RID: 138190
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

		// Token: 0x04021BCF RID: 138191
		private readonly List<UniTask> MoveTasks = new List<UniTask>();

		// Token: 0x04021BD0 RID: 138192
		private bool TileAddAudioPlayed;

		// Token: 0x04021BD1 RID: 138193
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<MatchThreePieceView> MovePieces = new List<MatchThreePieceView>();

		// Token: 0x04021BD2 RID: 138194
		private readonly int[] CellClearIdx = new int[56];

		// Token: 0x04021BD3 RID: 138195
		private readonly int[] CellFirstHitIdx = new int[56];

		// Token: 0x04021BD4 RID: 138196
		private readonly List<int> HitNext = new List<int>();

		// Token: 0x04021BD5 RID: 138197
		private readonly int[] CellLastIdx = new int[56];

		// Token: 0x04021BD6 RID: 138198
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UniTaskCompletionSource<int>> ClearStrikeGates = new List<UniTaskCompletionSource<int>>();

		// Token: 0x04021BD7 RID: 138199
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<UniTaskCompletionSource<int>> HitStrikeGates = new List<UniTaskCompletionSource<int>>();

		// Token: 0x04021BD8 RID: 138200
		private readonly int[] CellFirstStrikeIdx = new int[56];

		// Token: 0x04021BD9 RID: 138201
		private readonly List<int> StrikeNext = new List<int>();

		// Token: 0x04021BDA RID: 138202
		private readonly List<MatchThreePresenter.DirectedStrikeTarget> StrikeTargets = new List<MatchThreePresenter.DirectedStrikeTarget>();

		// Token: 0x04021BDB RID: 138203
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] LandGates = new UniTaskCompletionSource[56];

		// Token: 0x04021BDC RID: 138204
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly UniTaskCompletionSource[] DetonationGates = new UniTaskCompletionSource[56];

		// Token: 0x04021BDD RID: 138205
		[Nullable(2)]
		private UniTaskCompletionSource UltimateFullUpGate;

		// Token: 0x04021BDE RID: 138206
		private const int LowerDifficultyFailCount = 2;

		// Token: 0x04021BDF RID: 138207
		private bool SettlementStarted;

		// Token: 0x04021BE0 RID: 138208
		private int FailsSinceLowerDifficulty;

		// Token: 0x04021BE1 RID: 138209
		private long LevelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

		// Token: 0x0200C6B6 RID: 50870
		[NullableContext(0)]
		private readonly struct DirectedStrikeTarget
		{
			// Token: 0x06050DD3 RID: 331219 RVA: 0x015D3872 File Offset: 0x015D1A72
			public DirectedStrikeTarget(bool isHit, int eventIndex)
			{
				this.IsHit = isHit;
				this.EventIndex = eventIndex;
			}

			// Token: 0x0403BFE7 RID: 245735
			public readonly bool IsHit;

			// Token: 0x0403BFE8 RID: 245736
			public readonly int EventIndex;
		}

		// Token: 0x0200C6B7 RID: 50871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403BFE9 RID: 245737
			[Nullable(0)]
			public static Action <0>__EndGameAfterWin;
		}
	}
}
