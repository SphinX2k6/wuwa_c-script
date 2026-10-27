using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI;
using CSharpScript.Game.Module.Activity.ActivityContent.Anniversary;
using CSharpScript.Game.Module.Activity.ActivityContent.CommonH5;
using CSharpScript.Game.Module.Activity.ActivityContent.Coop;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Activity.ActivityContent.FeiXue;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge;
using CSharpScript.Game.Module.Activity.ActivityContent.FunPlay;
using CSharpScript.Game.Module.Activity.ActivityContent.LineCross;
using CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn;
using CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop;
using CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorFight;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.Activity.ActivityContent.PreWarm;
using CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Module.Activity.ActivityContent.RoadBook;
using CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Activity.ActivityContent.Tetris;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.Giant.Activity;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.VillageInfr;

// Token: 0x0200167D RID: 5757
public class ActivityManager : IStaticVariableResetter
{
	// Token: 0x0600A29E RID: 41630 RVA: 0x0023DD05 File Offset: 0x0023BF05
	static ActivityManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityManager.CreateStaticDefaultValue), new Action(ActivityManager.ResetStaticDefaultValue));
	}

	// Token: 0x0600A29F RID: 41631 RVA: 0x0023DD24 File Offset: 0x0023BF24
	public static void CreateStaticDefaultValue()
	{
		ActivityManager.ActivityControllerInstance = new Dictionary<ActivityType, IActivityControllerBase>();
	}

	// Token: 0x0600A2A0 RID: 41632 RVA: 0x0023DD30 File Offset: 0x0023BF30
	public static void ResetStaticDefaultValue()
	{
		ActivityManager.ActivityControllerInstance = null;
	}

	// Token: 0x0600A2A1 RID: 41633 RVA: 0x0023DD38 File Offset: 0x0023BF38
	public static void Init()
	{
		ActivityManager.InitActivityController();
		foreach (object obj in Enum.GetValues(typeof(ActivityType)))
		{
			ActivityType activityType = (ActivityType)obj;
			IActivityControllerBase activityControllerBase;
			if (!ActivityManager.ActivityControllerInstance.TryGetValue(activityType, out activityControllerBase))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "没有注册活动类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", activityType);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600A2A2 RID: 41634 RVA: 0x0023DDD8 File Offset: 0x0023BFD8
	private static void InitActivityController()
	{
		ActivityManager.ActivityControllerInstance[ActivityType.Parkour] = ActivityRunController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.GatherActivity] = ActivityCollectionController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Sign] = ActivitySevenDaySignController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewBieCourse] = ActivityNoviceJourneyController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewbieCourseV2] = ActivityNewbieCourseV2Controller.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PureUiactivity] = ActivityUniversalController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TowerGuide] = ActivityTowerGuideController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.WorldNewJourney] = ActivityBeginnerBookController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RougeActivity] = ActivityRogueController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RoleTrialActivity] = ActivityRoleTrialController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Harvest] = ActivityMowingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.DoubleInstanceRewardActivity] = ActivityDoubleRewardController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhantomCollect] = ActivityPhantomCollectController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.DailyAdventureActivity] = ActivityDailyAdventureController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.LongShanMainActivity] = ActivityLongShanController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.BossRushActivity] = BossRushController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TurnTableActivity] = ActivityTurntableController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TimePointRewardActivity] = ActivityTimePointRewardController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhotoMemoryActivity] = FragmentMemoryActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TowerDefenceActivity] = TowerDefenseController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TrackMoonActivity] = ActivityMoonChasingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TowerGuideNew] = ActivityLoopTowerController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.SlashAndTowerLevelPlay] = ActivityShipTowerController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.DangoMonopoly] = ActivityDangoMonopolyController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MoraleActivity] = ActivityMoraleController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Explore] = ActivityMapExploreController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RegressActivity] = ActivityRegressController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TrackMoonPhase] = ActivityRoleGiveController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.CorniceMeeting] = ActivityCorniceMeetingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RiskHarvest] = ActivityMowingRiskController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.BlackCoastTheme] = ActivityBlackCoastController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RogueWhiteCat] = DreamLinkController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ArtemisActivity] = ArtemisActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.DropCatchActivity] = DropCatchActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ScratchCard] = ActivityScratchTicketController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PreheatSign] = ActivityVersionPreheatController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MowTower] = MowingTowerController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ThroughTrain] = ActivityDirectTrainController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ThroughTrainSummary] = DirectTrainActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MapTravelActivity] = ActivityMapTravelController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FarmGold] = FarmGoldController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.SprintSign] = ActivitySpring25Controller.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewLordGym] = ActivityLordGymController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RoleSkinTrialActivity] = RoleSkinTrialController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RogueWeekly] = WeeklyRogueController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FishingActivity] = ActivityFishingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TeamParkOurActivity] = ActivitySolarSpeedController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.BabelTower] = BabelTowerController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.BetHorses] = RacingBetsController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FloroRanchActivity] = FloroRanchController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RogueRes] = ActivityPermanentRogueController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewbieCarnival] = BeginnerCarnivalController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.SkinRewardActivity] = ActivityRoleSkinRewardController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.AnniversaryTheme] = AnniversaryActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Abyss] = DangoAbyssActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Avignon] = AvignonController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.CiacconaActivity] = CiacconaActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.H5CircumFluence] = ActivityInviteNewbieController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ActivityLinkage] = ActivityLinkageController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.LinkageCheckIn] = LinkageRewardActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.ConsumptiveActivity] = CumulativeShopController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhantomBattle] = PhantomArenaController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.HonamiStory] = HonamiStoryController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.LifePointChallenge] = LifePointDrawActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TrapDefense] = ActivityTrapDefenseController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FunPlay] = ActivityFunPlayController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.JinzhouFlyActivity] = ActivitySoarController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.LineCross] = LineCrossActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Survivors] = SurvivorsActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MoonPhase] = MoonSignInController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhotoFight] = FightPhotoController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Encircle] = ActivityEncircleController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.WuWuKuji] = ActivityPrizeDrawingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.InfrTheme] = InfrastructureController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.InfrThemeV2] = VillageInfrController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PreHeatTaskActivity] = ActivityPreWarmController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.CoopActivity] = CoopActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.AdvanceNoticeActivity] = AdvanceNoticeController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorcycleIpLink] = ActivityMotorLinkageController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhantomBattleRecord] = PhantomArenaController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RoadBookActivity] = ActivityRoadBookController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RealmBetween] = ActivityRealmBetweenController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PhantomBattleRecordGuide] = PhantomArenaGuideController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TetrisActivity] = ActivityTetrisController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MatchThreeActivity] = ActivityMatchThreeController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewTowerClimbing] = WheelTowerController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorParkourActivity] = MotorParkourController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.H5View] = CommonH5Controller.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.SpringFestivalActivity] = SpringManorController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewPlayerSupportActivity] = ActivityNewPlayerSupportController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PurePreviewActivity] = ActivityMotorGiftController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewPlayerSupportActivityV2] = ActivityNewPlayerSupportActivityV2Controller.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorFight] = MotorFightController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.TotalTopUp] = TotalTopUpController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RoleGiftActivity] = RoleGiftController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.WuWuWeekSign] = WuWuLogisticsActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorDecalActivity] = MotorDecalLinkController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FlagChallenge] = ActivityFlagChallengeController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorDevelop] = ActivityMotorDevelopController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.FeiXue] = ActivityFeiXuePreheatController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Rhythm] = RhythmShipController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.BossPiling] = BossPilingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.GolemCrackActivity] = GolemHackingController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.EdgeRunnerActivity] = CyberPunkController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.MotorParkour] = MultiMotorController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.PinballActivity] = PinballController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.Kurotato] = KurotatoActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.SheriffActivity] = SheriffController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewbieMain] = NewbieMainController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewbieAdventureV2] = ActivityNewcomerJourneyController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.QingXiaoPlayThePiano] = GuQinActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.RoverRogue] = RoverlikeActivityController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.DangoBrawl] = ActivityDangoBrawlController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.NewRoleGuideActivity] = ActivityPoiController.Instance;
		ActivityManager.ActivityControllerInstance[ActivityType.GiantSystemActivity] = GiantActivityController.Instance;
	}

	// Token: 0x0600A2A3 RID: 41635 RVA: 0x0023E584 File Offset: 0x0023C784
	[NullableContext(1)]
	public static IActivityControllerBase GetActivityController(ActivityType type)
	{
		IActivityControllerBase result;
		if (ActivityManager.ActivityControllerInstance.TryGetValue(type, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600A2A4 RID: 41636 RVA: 0x0023E5A3 File Offset: 0x0023C7A3
	[NullableContext(2)]
	public static IActivityControllerBase GetActivityController(int type)
	{
		return ActivityManager.ActivityControllerInstance.GetValueOrDefault((ActivityType)type);
	}

	// Token: 0x0600A2A5 RID: 41637 RVA: 0x0023E5B0 File Offset: 0x0023C7B0
	public static void Clear()
	{
		ActivityManager.ActivityControllerInstance.Clear();
	}

	// Token: 0x04004A05 RID: 18949
	[Nullable(1)]
	private static Dictionary<ActivityType, IActivityControllerBase> ActivityControllerInstance;
}
