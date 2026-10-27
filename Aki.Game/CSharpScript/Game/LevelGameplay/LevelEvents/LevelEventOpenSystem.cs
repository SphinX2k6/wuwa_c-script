using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B48 RID: 27464
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventOpenSystem : LevelEventBase
	{
		// Token: 0x0604418F RID: 278927 RVA: 0x010C0BF0 File Offset: 0x010BEDF0
		public LevelEventOpenSystem(int id) : base(id)
		{
			this.OpenSystemMap[ESystemType.Shop] = new OpenSystemShopView(this);
			this.OpenSystemMap[ESystemType.InformationView] = new OpenSystemInformationView(this);
			this.OpenSystemMap[ESystemType.InstanceEntrance] = new OpenSystemInstanceEntrance(this);
			this.OpenSystemMap[ESystemType.MingSuTi] = new OpenSystemMingSuTi(this);
			this.OpenSystemMap[ESystemType.Cook] = new OpenSystemCook(this);
			this.OpenSystemMap[ESystemType.FixCook] = new OpenSystemFixCook(this);
			this.OpenSystemMap[ESystemType.Synthetic] = new OpenSystemSynthetic(this);
			this.OpenSystemMap[ESystemType.Forging] = new OpenSystemForging(this);
			this.OpenSystemMap[ESystemType.Expostulation] = new OpenSystemExpostulation(this);
			this.OpenSystemMap[ESystemType.RoleDescription] = new OpenSystemRoleDescription(this);
			this.OpenSystemMap[ESystemType.TrialRoleDescription] = new OpenSystemTrialRoleDescription(this);
			this.OpenSystemMap[ESystemType.RogueAbilitySelect] = new OpenSystemRogueAbilitySelect(this);
			this.OpenSystemMap[ESystemType.TurntableControl] = new OpenSystemTurntableControl(this);
			this.OpenSystemMap[ESystemType.GameSysOpen] = new OpenSystemGameSysOpen(this);
			this.OpenSystemMap[ESystemType.InstanceFailure] = new OpenSystemInstanceFailure(this);
			this.OpenSystemMap[ESystemType.FeedingPets] = new OpenSystemFeed(this);
			this.OpenSystemMap[ESystemType.SoundAreaPlayInfo] = new OpenSystemSoundAreaPlayInfo(this);
			this.OpenSystemMap[ESystemType.RogueShop] = new OpenSystemRogueShop(this);
			this.OpenSystemMap[ESystemType.PermanentRogueAbilitySelect] = new OpenSystemRogueBattleAbilitySelect(this);
			this.OpenSystemMap[ESystemType.PermanentRogueShop] = new OpenSystemRogueBattleShop(this);
			this.OpenSystemMap[ESystemType.ContributionLevel] = new OpenSystemContributionLevel(this);
			this.OpenSystemMap[ESystemType.RegionQuest] = new OpenSystemRegionQuest(this);
			this.OpenSystemMap[ESystemType.LordChallenge] = new OpenSystemLordGym(this);
			this.OpenSystemMap[ESystemType.LordGymEntrance] = new OpenSystemLordGymLordEntranceSelectView(this);
			this.OpenSystemMap[ESystemType.ExploreLevelView] = new OpenSystemExploreLevel(this);
			this.OpenSystemMap[ESystemType.RogueActivityIntroduce] = new OpenSystemRoguelikeActivity(this);
			this.OpenSystemMap[ESystemType.RogueRandomEvent] = new OpenSystemRogueEventSelect(this);
			this.OpenSystemMap[ESystemType.ConfirmBox] = new OpenSystemConfirmBox(this);
			this.OpenSystemMap[ESystemType.ConfirmBox2] = new OpenSystemConfirmBox(this);
			this.OpenSystemMap[ESystemType.ActivityIntroduce] = new OpenSystemActivity(this);
			this.OpenSystemMap[ESystemType.ActivitySubInterface] = new OpenSystemActivitySubView(this);
			this.OpenSystemMap[ESystemType.Photograph] = new OpenSystemPhotographView(this);
			this.OpenSystemMap[ESystemType.RogueSettlement] = new OpenSystemRogueSettlement(this);
			this.OpenSystemMap[ESystemType.RogueTowerTrial] = new OpenSystemRogueTowerTrial(this);
			this.OpenSystemMap[ESystemType.DigitalScreen] = new OpenSystemDigitalScreen(this);
			this.OpenSystemMap[ESystemType.ChasingMoonMain] = new OpenSystemChasingMoonMain(this);
			this.OpenSystemMap[ESystemType.DreamLink] = new OpenSystemDreamLinkLevel(this);
			this.OpenSystemMap[ESystemType.Gramophone] = new OpenSystemPhonograph(this);
			this.OpenSystemMap[ESystemType.ScratchTicket] = new OpenSystemScratchTicketMain(this);
			this.OpenSystemMap[ESystemType.MowBuffDistribute] = new OpenSystemMowBuffDistribute(this);
			this.OpenSystemMap[ESystemType.PreheatingCheckIn] = new OpenSystemVersionPreheat(this);
			this.OpenSystemMap[ESystemType.MowingTowerActivity] = new OpenSystemMowingTower(this);
			this.OpenSystemMap[ESystemType.RaidReportSettlement] = new OpenSystemPunishReportSettlement(this);
			this.OpenSystemMap[ESystemType.PhotoMemoryTopic] = new OpenSystemFragmentMemory(this);
			this.OpenSystemMap[ESystemType.HideLordOpen] = new OpenSystemHiddenBossWindow(this);
			this.OpenSystemMap[ESystemType.FishingDock] = new OpenSystemFishingDock(this);
			this.OpenSystemMap[ESystemType.FishingCage] = new OpenSystemFishingCage(this);
			this.OpenSystemMap[ESystemType.SlashAndTower] = new OpenSystemShipTower(this);
			this.OpenSystemMap[ESystemType.RogueTokenSelect] = new OpenSystemWeeklyRogueToken(this);
			this.OpenSystemMap[ESystemType.PermanentRogueTokenSelect] = new OpenSystemRogueBattleAbilitySelect(this);
			this.OpenSystemMap[ESystemType.BossRushPlayInfo] = new OpenSystemBossRushBuff(this);
			this.OpenSystemMap[ESystemType.CiacconaAvgSystemBoard] = new OpenSystemCiacconaChapterEntry(this);
			this.OpenSystemMap[ESystemType.CiacconaAvgChapterBoard] = new OpenSystemCiacconaChapterView(this);
			this.OpenSystemMap[ESystemType.DangoAbyssActivity] = new OpenSystemDangoAbyssView(this);
			this.OpenSystemMap[ESystemType.PhantomBattleChallenge] = new OpenSystemPhantomArenaChallengeView(this);
			this.OpenSystemMap[ESystemType.CoBathing] = new OpenSystemShower(this);
			this.OpenSystemMap[ESystemType.PlotReview] = new OpenSystemQuestReviewMainView(this);
			this.OpenSystemMap[ESystemType.PlotReviewJumpTips] = new OpenSystemQuestReviewTipsView(this);
			this.OpenSystemMap[ESystemType.MoraleSystem] = new OpenSystemMoraleAreaSum(this);
			this.OpenSystemMap[ESystemType.LifePointChallenge] = new OpenSystemLifePointDraw(this);
			this.OpenSystemMap[ESystemType.GreatSwordChallenge] = new OpenSystemGreatSwordSelectView(this);
			this.OpenSystemMap[ESystemType.TrapDefenseMapChange] = new OpenSystemTrapDefenseMapChange(this);
			this.OpenSystemMap[ESystemType.FindBug] = new OpenSystemActivityFunPlay(this);
			this.OpenSystemMap[ESystemType.HonamiStoryResourceStation] = new OpenSystemHonamiShopView(this);
			this.OpenSystemMap[ESystemType.HonamiStoryFightPreparation] = new OpenSystemHonamiMainView(this);
			this.OpenSystemMap[ESystemType.HonamiStoryWareHouse] = new OpenSystemHonamiInventoryView(this);
			this.OpenSystemMap[ESystemType.HonamiStoryMascot] = new OpenSystemHonamiMascotView(this);
			this.OpenSystemMap[ESystemType.HonamiStoryTalentTree] = new OpenSystemHonamiTalentTreeView(this);
			this.OpenSystemMap[ESystemType.HonamiStoryChooseLevel] = new OpenSystemHonamiChooseLevelView(this);
			this.OpenSystemMap[ESystemType.Enrollment] = new OpenSystemAdmissionStudentCard(this);
			this.OpenSystemMap[ESystemType.TransitionPopup] = new OpenSystemTransitionPopupView(this);
			this.OpenSystemMap[ESystemType.InfrActivityFinishInfrastructure] = new OpenSystemInfrBuildSuccessView(this);
			this.OpenSystemMap[ESystemType.VillageInfrMainView] = new OpenVillageInfrMainView(this);
			this.OpenSystemMap[ESystemType.VillageInfrDelivery] = new OpenSystemVillageInfrDelivery(this);
			this.OpenSystemMap[ESystemType.VillageInfrFinishConstruction] = new OpenSystemVillageInfrBuildSuccessView(this);
			this.OpenSystemMap[ESystemType.Map] = new OpenSystemWorldMap(this);
			this.OpenSystemMap[ESystemType.AreaTerminalGamePlay] = new OpenSystemRegionalTerminal(this);
			this.OpenSystemMap[ESystemType.Motorcycle] = new OpenSystemMotorcycleDevelop(this);
			this.OpenSystemMap[ESystemType.MotorcycleDiy] = new OpenSystemMotorcycleDiy(this);
			this.OpenSystemMap[ESystemType.GuessCardGamePlayView] = new OpenSystemGuessJokerGamePlayView(this);
			this.OpenSystemMap[ESystemType.GuessJokerSelectRoleView] = new OpenSystemGuessJokerSelectRoleView(this);
			this.OpenSystemMap[ESystemType.DrinksMixDrinksView] = new OpenSystemDrinksGamePlayView(this);
			this.OpenSystemMap[ESystemType.DrinksSelectRoleView] = new OpenSystemDrinksSelectRoleView(this);
			this.OpenSystemMap[ESystemType.FurnitureDiyShop] = new OpenSystemFurnitureShopView(this);
			this.OpenSystemMap[ESystemType.ChangeWeaponExhibitView] = new OpenSystemChangeWeaponExhibitView(this);
			this.OpenSystemMap[ESystemType.ChangePhantomExhibitView] = new OpenSystemChangePhantomExhibitView(this);
			this.OpenSystemMap[ESystemType.TakePhoto] = new OpenSystemTakePhotoView(this);
			this.OpenSystemMap[ESystemType.SpringFestivalBrochure] = new OpenSystemSpringFestivalBrochureView(this);
			this.OpenSystemMap[ESystemType.SpringFestivalPictureAlbum] = new OpenSystemSpringFestivalPictureAlbumView(this);
			this.OpenSystemMap[ESystemType.PictureCaption] = new OpenSystemVideoPromptView(this);
			this.OpenSystemMap[ESystemType.TetrisBoardGameEndlessLevel] = new OpenSystemTetrisBoardGameEndlessLevel(this);
			this.OpenSystemMap[ESystemType.RhythmSpaceshipInMainStory] = new OpenSystemShowerRhythmSpaceshipInMainStory(this);
			this.OpenSystemMap[ESystemType.DropCatchInMainStory] = new OpenSystemDropCatchInMainStory(this);
			this.OpenSystemMap[ESystemType.InteractiveComic] = new OpenSystemInteractiveComic(this);
			this.OpenSystemMap[ESystemType.CyberpunkCollaborationVehicleShare] = new OpenSystemCyberpunkCollaborationVehicleShare(this);
			this.OpenSystemMap[ESystemType.CyberpunkCollaborationVehicleShareInProgress] = new OpenSystemCyberpunkCollaborationVehicleShareInProgress(this);
			this.OpenSystemMap[ESystemType.QuestBranch] = new OpenSystemQuestMultiLineView(this);
			this.OpenSystemMap[ESystemType.QuestBranchTips] = new OpenSystemQuestMultiLineTipsView(this);
			this.OpenSystemMap[ESystemType.SheriffCriminalIdentityConfirmed] = new OpenSystemSheriffCriminalIdentityConfirmed(this);
			this.OpenSystemMap[ESystemType.SheriffAnomaly] = new OpenSystemSheriffAnomaly(this);
			this.OpenSystemMap[ESystemType.SheriffMainStoryError] = new OpenSystemSheriffMainStoryError(this);
			this.OpenSystemMap[ESystemType.DollGrabDelivery] = new OpenSystemDollShowcaseDelivery(this);
			this.OpenSystemMap[ESystemType.MechascoutMindSpaceDungeon] = new OpenSystemMachineryFactoryTouch(this);
			this.OpenSystemMap[ESystemType.WriteLetter] = new OpenSystemWriteLetter(this);
			this.OpenSystemMap[ESystemType.FoxFailureTips] = new OpenSystemFoxFailureTips(this);
			this.OpenSystemMap[ESystemType.DangoBrawlVictorySettlement] = new OpenSystemDangoBrawlSettleVictory(this);
			this.OpenSystemMap[ESystemType.DangoBrawlFailureSettlement] = new OpenSystemDangoBrawlSettleFailure(this);
		}

		// Token: 0x06044190 RID: 278928 RVA: 0x010C13F8 File Offset: 0x010BF5F8
		protected override void OnReset()
		{
			if (EventSystem.Instance.Has(EEventName.CloseView, new Action<EUiViewName, int>(this.FinishExecuteSync)))
			{
				EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.FinishExecuteSync));
			}
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
			this.LoadingPromise = null;
		}

		// Token: 0x06044191 RID: 278929 RVA: 0x010C1478 File Offset: 0x010BF678
		private UniTask ExecuteOpenView(OpenSystemBoard @params, GeneralContext context)
		{
			LevelEventOpenSystem.<ExecuteOpenView>d__5 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.@params = @params;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<LevelEventOpenSystem.<ExecuteOpenView>d__5>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044192 RID: 278930 RVA: 0x010C14CB File Offset: 0x010BF6CB
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044193 RID: 278931 RVA: 0x010C14D8 File Offset: 0x010BF6D8
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			OpenSystemBoard openSystemBoard = inParams as OpenSystemBoard;
			if (openSystemBoard == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.WLJ, "[LevelEventOpenSystem]参数类型出错", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ExecuteOpenView(openSystemBoard, context);
		}

		// Token: 0x06044194 RID: 278932 RVA: 0x010C1518 File Offset: 0x010BF718
		private void CreateLoadingPromise()
		{
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "[LevelEventOpenSystem]创建LoadingPromise", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LoadingPromise = new CustomPromise<object>();
			if (!EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
		}

		// Token: 0x06044195 RID: 278933 RVA: 0x010C1588 File Offset: 0x010BF788
		private void OnWorldDoneAndCloseLoading()
		{
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "[LevelEventOpenSystem]设置LoadingPromise结果", default(ReadOnlySpan<ValueTuple<string, object>>));
			CustomPromise<object> loadingPromise = this.LoadingPromise;
			if (loadingPromise == null)
			{
				return;
			}
			loadingPromise.SetResult(null);
		}

		// Token: 0x06044196 RID: 278934 RVA: 0x010C15C4 File Offset: 0x010BF7C4
		private void ActivateNpcPerformance(OpenSystemBoard @params, OpenSystemBase openSystem, GeneralContext context)
		{
			EUiViewName? viewName = openSystem.GetViewName(@params, context);
			if (viewName == null)
			{
				return;
			}
			if (@params.SystemType == ESystemType.Photograph)
			{
				TsInteractionUtils.RegisterOpenViewName(viewName.Value);
				return;
			}
			CommonNpcPerformComponent commonNpcPerformComponent = null;
			EntityContext entityContext = context as EntityContext;
			int? num = (entityContext != null) ? entityContext.EntityId : null;
			int? num2;
			if (num == null)
			{
				DynamicInteractContext dynamicInteractContext = context as DynamicInteractContext;
				num2 = ((dynamicInteractContext != null) ? dynamicInteractContext.EntityId : null);
			}
			else
			{
				num2 = num;
			}
			int? num3 = num2;
			if (num3 != null)
			{
				Entity entity = EntitySystem.Instance.Get(num3.Value);
				commonNpcPerformComponent = ((entity != null) ? entity.GetComponent<CommonNpcPerformComponent>() : null);
			}
			if (commonNpcPerformComponent == null)
			{
				return;
			}
			TsInteractionUtils.RegisterOpenViewName(viewName.Value);
			commonNpcPerformComponent.SetUiOpenPerformance(viewName.Value, @params.BoardId);
		}

		// Token: 0x06044197 RID: 278935 RVA: 0x010C168C File Offset: 0x010BF88C
		private void FinishExecuteSync(EUiViewName viewName, int viewId)
		{
			if (viewName != this.ViewName)
			{
				return;
			}
			base.FinishExecute(true, false, true);
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.FinishExecuteSync));
		}

		// Token: 0x06044198 RID: 278936 RVA: 0x010C16E0 File Offset: 0x010BF8E0
		private void FinishPromptViewSync(EUiViewName viewName)
		{
			base.FinishExecute(true, false, true);
			EventSystem.Instance.Remove<EUiViewName>(EEventName.ClosePlotCaptionImageView, new Action<EUiViewName>(this.FinishPromptViewSync));
		}

		// Token: 0x06044199 RID: 278937 RVA: 0x010C1708 File Offset: 0x010BF908
		private void TryCloseLevelLoading(EUiViewName viewName, int viewId)
		{
			if (viewName != this.ViewName)
			{
				return;
			}
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "OpenSystem", null, null);
		}

		// Token: 0x0402391E RID: 145694
		private EUiViewName? ViewName;

		// Token: 0x0402391F RID: 145695
		private readonly Dictionary<ESystemType, OpenSystemBase> OpenSystemMap = new Dictionary<ESystemType, OpenSystemBase>();

		// Token: 0x04023920 RID: 145696
		[Nullable(2)]
		private CustomPromise<object> LoadingPromise;
	}
}
