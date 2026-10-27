using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000083 RID: 131
	public sealed class ActivityData : IMessage<ActivityData>, IMessage, IEquatable<ActivityData>, IDeepCloneable<ActivityData>, IBufferMessage
	{
		// Token: 0x0600190D RID: 6413 RVA: 0x00041BDC File Offset: 0x0003FDDC
		[NullableContext(1)]
		public static ActivityData Create()
		{
			return new ActivityData();
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00041BE3 File Offset: 0x0003FDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityData> Parser
		{
			get
			{
				return ActivityData._parser;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00041BEA File Offset: 0x0003FDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x00041BED File Offset: 0x0003FDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityData.Descriptor;
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData()
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00041C14 File Offset: 0x0003FE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData(ActivityData other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.beginShowTime_ = other.beginShowTime_;
			this.endShowTime_ = other.endShowTime_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this.isUnlock_ = other.isUnlock_;
			this.completePreQuests_ = other.completePreQuests_.Clone();
			this.isFirstOpen_ = other.isFirstOpen_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this.activityOpenType_ = other.activityOpenType_;
			this.canPreOpen_ = other.canPreOpen_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this.limitRewardBeginTime_ = other.limitRewardBeginTime_;
			this.limitRewardEndTime_ = other.limitRewardEndTime_;
			switch (other.DataCase)
			{
			case ActivityData.DataOneofCase.ParkourActivity:
				this.ParkourActivity = other.ParkourActivity.Clone();
				break;
			case ActivityData.DataOneofCase.SignActivity:
				this.SignActivity = other.SignActivity.Clone();
				break;
			case ActivityData.DataOneofCase.NewBieCourseActivity:
				this.NewBieCourseActivity = other.NewBieCourseActivity.Clone();
				break;
			case ActivityData.DataOneofCase.DoubleInstActivityReward:
				this.DoubleInstActivityReward = other.DoubleInstActivityReward.Clone();
				break;
			case ActivityData.DataOneofCase.HarvestActivity:
				this.HarvestActivity = other.HarvestActivity.Clone();
				break;
			case ActivityData.DataOneofCase.RoleTrialInfoActivity:
				this.RoleTrialInfoActivity = other.RoleTrialInfoActivity.Clone();
				break;
			case ActivityData.DataOneofCase.PhantomCollectActivity:
				this.PhantomCollectActivity = other.PhantomCollectActivity.Clone();
				break;
			case ActivityData.DataOneofCase.GatherActivityInfo:
				this.GatherActivityInfo = other.GatherActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.DailyAdventureActivityData:
				this.DailyAdventureActivityData = other.DailyAdventureActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.RoguelikeActivityData:
				this.RoguelikeActivityData = other.RoguelikeActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.LongShanActivityData:
				this.LongShanActivityData = other.LongShanActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.TurntableActivityData:
				this.TurntableActivityData = other.TurntableActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.BossRushActivityData:
				this.BossRushActivityData = other.BossRushActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.TrackMoonActivityTaskData:
				this.TrackMoonActivityTaskData = other.TrackMoonActivityTaskData.Clone();
				break;
			case ActivityData.DataOneofCase.TimePointRewardActivityData:
				this.TimePointRewardActivityData = other.TimePointRewardActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.TowerDefenceActivityData:
				this.TowerDefenceActivityData = other.TowerDefenceActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.CircumFluenceTaskData:
				this.CircumFluenceTaskData = other.CircumFluenceTaskData.Clone();
				break;
			case ActivityData.DataOneofCase.TraceMoonPhaseData:
				this.TraceMoonPhaseData = other.TraceMoonPhaseData.Clone();
				break;
			case ActivityData.DataOneofCase.CorniceMeetingData:
				this.CorniceMeetingData = other.CorniceMeetingData.Clone();
				break;
			case ActivityData.DataOneofCase.RiskHarvestActivityInfo:
				this.RiskHarvestActivityInfo = other.RiskHarvestActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.BlackCoastThemeActivityData:
				this.BlackCoastThemeActivityData = other.BlackCoastThemeActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.RogueWhiteCatData:
				this.RogueWhiteCatData = other.RogueWhiteCatData.Clone();
				break;
			case ActivityData.DataOneofCase.ScratchCardActivityInfo:
				this.ScratchCardActivityInfo = other.ScratchCardActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.PreheatSignActivityInfo:
				this.PreheatSignActivityInfo = other.PreheatSignActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.MowTowerActivityInfo:
				this.MowTowerActivityInfo = other.MowTowerActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.FarmGoldInfo:
				this.FarmGoldInfo = other.FarmGoldInfo.Clone();
				break;
			case ActivityData.DataOneofCase.SpringSignInfo:
				this.SpringSignInfo = other.SpringSignInfo.Clone();
				break;
			case ActivityData.DataOneofCase.MapTravelActivityInfo:
				this.MapTravelActivityInfo = other.MapTravelActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RoleSkinTrialInfoActivity:
				this.RoleSkinTrialInfoActivity = other.RoleSkinTrialInfoActivity.Clone();
				break;
			case ActivityData.DataOneofCase.FishingActivityInfo:
				this.FishingActivityInfo = other.FishingActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RogueWeeklyData:
				this.RogueWeeklyData = other.RogueWeeklyData.Clone();
				break;
			case ActivityData.DataOneofCase.TeamParkourLevelActivityInfo:
				this.TeamParkourLevelActivityInfo = other.TeamParkourLevelActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.BabelActivityInfo:
				this.BabelActivityInfo = other.BabelActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RacingBetsData:
				this.RacingBetsData = other.RacingBetsData.Clone();
				break;
			case ActivityData.DataOneofCase.ExploreActivityInfo:
				this.ExploreActivityInfo = other.ExploreActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RogueResActivityData:
				this.RogueResActivityData = other.RogueResActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.AvignonActivityInfo:
				this.AvignonActivityInfo = other.AvignonActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.AbyssInfo:
				this.AbyssInfo = other.AbyssInfo.Clone();
				break;
			case ActivityData.DataOneofCase.H5CircumFluenceData:
				this.H5CircumFluenceData = other.H5CircumFluenceData.Clone();
				break;
			case ActivityData.DataOneofCase.DangoMonopolyActivityData:
				this.DangoMonopolyActivityData = other.DangoMonopolyActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.CiacconaActivityPbData:
				this.CiacconaActivityPbData = other.CiacconaActivityPbData.Clone();
				break;
			case ActivityData.DataOneofCase.ActivityLinkageData:
				this.ActivityLinkageData = other.ActivityLinkageData.Clone();
				break;
			case ActivityData.DataOneofCase.RegressData:
				this.RegressData = other.RegressData.Clone();
				break;
			case ActivityData.DataOneofCase.ConsumptiveActivityInfo:
				this.ConsumptiveActivityInfo = other.ConsumptiveActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.PhantomBattleActivityInfo:
				this.PhantomBattleActivityInfo = other.PhantomBattleActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.NewbieCarnivalData:
				this.NewbieCarnivalData = other.NewbieCarnivalData.Clone();
				break;
			case ActivityData.DataOneofCase.MoraleActivityData:
				this.MoraleActivityData = other.MoraleActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.FloroRanchActivityData:
				this.FloroRanchActivityData = other.FloroRanchActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.LifePointChallenge:
				this.LifePointChallenge = other.LifePointChallenge.Clone();
				break;
			case ActivityData.DataOneofCase.TrapDefenseActivityInfo:
				this.TrapDefenseActivityInfo = other.TrapDefenseActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.FunPlayActivityInfo:
				this.FunPlayActivityInfo = other.FunPlayActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.JinzhouFlyData:
				this.JinzhouFlyData = other.JinzhouFlyData.Clone();
				break;
			case ActivityData.DataOneofCase.LineCrossActivityData:
				this.LineCrossActivityData = other.LineCrossActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.MoonPhaseActivityData:
				this.MoonPhaseActivityData = other.MoonPhaseActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.HonamiStoryActivityInfo:
				this.HonamiStoryActivityInfo = other.HonamiStoryActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.PhotoFightActivityData:
				this.PhotoFightActivityData = other.PhotoFightActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.SurvivorsActivityData:
				this.SurvivorsActivityData = other.SurvivorsActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.WuWuKujiActivityInfo:
				this.WuWuKujiActivityInfo = other.WuWuKujiActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.AdvertisingPageInfo:
				this.AdvertisingPageInfo = other.AdvertisingPageInfo.Clone();
				break;
			case ActivityData.DataOneofCase.ArtemisActivityInfo:
				this.ArtemisActivityInfo = other.ArtemisActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RoleCoopActivityData:
				this.RoleCoopActivityData = other.RoleCoopActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.MotorCycleIpActivityData:
				this.MotorCycleIpActivityData = other.MotorCycleIpActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo:
				this.PhantomBattleRecordActivityInfo = other.PhantomBattleRecordActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.InfrThemeActivityPb:
				this.InfrThemeActivityPb = other.InfrThemeActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.RoadBookActivityInfo:
				this.RoadBookActivityInfo = other.RoadBookActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.PhantomBattleGuideActivity:
				this.PhantomBattleGuideActivity = other.PhantomBattleGuideActivity.Clone();
				break;
			case ActivityData.DataOneofCase.NewTowerClimbingActivityData:
				this.NewTowerClimbingActivityData = other.NewTowerClimbingActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.NewPlayerSupportActivityData:
				this.NewPlayerSupportActivityData = other.NewPlayerSupportActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.MotorParkourActivityInfo:
				this.MotorParkourActivityInfo = other.MotorParkourActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.SpringFestivalActivityInfo:
				this.SpringFestivalActivityInfo = other.SpringFestivalActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.TotalTopUpActivityInfo:
				this.TotalTopUpActivityInfo = other.TotalTopUpActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.MotorFightActivityPb:
				this.MotorFightActivityPb = other.MotorFightActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.H5ViewActivityData:
				this.H5ViewActivityData = other.H5ViewActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.SkinRewardActivityData:
				this.SkinRewardActivityData = other.SkinRewardActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.EncircleActivityPb:
				this.EncircleActivityPb = other.EncircleActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.MotorDevelopActivityData:
				this.MotorDevelopActivityData = other.MotorDevelopActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.FlagChallengeActivityInfo:
				this.FlagChallengeActivityInfo = other.FlagChallengeActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.FeiXuePreheatActivityInfo:
				this.FeiXuePreheatActivityInfo = other.FeiXuePreheatActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.RhythmActivityPb:
				this.RhythmActivityPb = other.RhythmActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.DropCatchActivityInfo:
				this.DropCatchActivityInfo = other.DropCatchActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.TetrisActivityInfo:
				this.TetrisActivityInfo = other.TetrisActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.PinballActivityData:
				this.PinballActivityData = other.PinballActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.BossPilingActivityInfo:
				this.BossPilingActivityInfo = other.BossPilingActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.ThemeCelebration:
				this.ThemeCelebration = other.ThemeCelebration.Clone();
				break;
			case ActivityData.DataOneofCase.WuWuWeekActivity:
				this.WuWuWeekActivity = other.WuWuWeekActivity.Clone();
				break;
			case ActivityData.DataOneofCase.MotorDecalActivityData:
				this.MotorDecalActivityData = other.MotorDecalActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.LinkageCheckInActivityData:
				this.LinkageCheckInActivityData = other.LinkageCheckInActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.RoleGiftActivityData:
				this.RoleGiftActivityData = other.RoleGiftActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.KurotatoActivityData:
				this.KurotatoActivityData = other.KurotatoActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.GolemCrackActivityInfo:
				this.GolemCrackActivityInfo = other.GolemCrackActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.EdgeRunnerActivityInfo:
				this.EdgeRunnerActivityInfo = other.EdgeRunnerActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.OnlineMotorActivityData:
				this.OnlineMotorActivityData = other.OnlineMotorActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.RealmBetweenActivityInfo:
				this.RealmBetweenActivityInfo = other.RealmBetweenActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.ThroughTrainSummaryActivityData:
				this.ThroughTrainSummaryActivityData = other.ThroughTrainSummaryActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.NewbieMainActivityPb:
				this.NewbieMainActivityPb = other.NewbieMainActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.NewbieCourseV2ActivityPb:
				this.NewbieCourseV2ActivityPb = other.NewbieCourseV2ActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.NewbieAdventureV2Pb:
				this.NewbieAdventureV2Pb = other.NewbieAdventureV2Pb.Clone();
				break;
			case ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb:
				this.NewPlayerSupportActivityV2Pb = other.NewPlayerSupportActivityV2Pb.Clone();
				break;
			case ActivityData.DataOneofCase.ThroughTrainActivityData:
				this.ThroughTrainActivityData = other.ThroughTrainActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.RoverRogueActivityData:
				this.RoverRogueActivityData = other.RoverRogueActivityData.Clone();
				break;
			case ActivityData.DataOneofCase.DangoBrawlActivityInfo:
				this.DangoBrawlActivityInfo = other.DangoBrawlActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.QingXiaoActivityInfo:
				this.QingXiaoActivityInfo = other.QingXiaoActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.MatchThreeActivityInfo:
				this.MatchThreeActivityInfo = other.MatchThreeActivityInfo.Clone();
				break;
			case ActivityData.DataOneofCase.GiantActivityInfo:
				this.GiantActivityInfo = other.GiantActivityInfo.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000427B0 File Offset: 0x000409B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData Clone()
		{
			return new ActivityData(this);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000427B8 File Offset: 0x000409B8
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x000427C0 File Offset: 0x000409C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x000427C9 File Offset: 0x000409C9
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x000427D1 File Offset: 0x000409D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x000427DA File Offset: 0x000409DA
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x000427E2 File Offset: 0x000409E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginShowTime
		{
			get
			{
				return this.beginShowTime_;
			}
			set
			{
				this.beginShowTime_ = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000427EB File Offset: 0x000409EB
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x000427F3 File Offset: 0x000409F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndShowTime
		{
			get
			{
				return this.endShowTime_;
			}
			set
			{
				this.endShowTime_ = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x000427FC File Offset: 0x000409FC
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00042804 File Offset: 0x00040A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0004280D File Offset: 0x00040A0D
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00042815 File Offset: 0x00040A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndOpenTime
		{
			get
			{
				return this.endOpenTime_;
			}
			set
			{
				this.endOpenTime_ = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0004281E File Offset: 0x00040A1E
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00042826 File Offset: 0x00040A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0004282F File Offset: 0x00040A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletePreQuests
		{
			get
			{
				return this.completePreQuests_;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00042837 File Offset: 0x00040A37
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0004283F File Offset: 0x00040A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirstOpen
		{
			get
			{
				return this.isFirstOpen_;
			}
			set
			{
				this.isFirstOpen_ = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x00042848 File Offset: 0x00040A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00042850 File Offset: 0x00040A50
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x00042858 File Offset: 0x00040A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityOpenType ActivityOpenType
		{
			get
			{
				return this.activityOpenType_;
			}
			set
			{
				this.activityOpenType_ = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x00042861 File Offset: 0x00040A61
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x00042869 File Offset: 0x00040A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanPreOpen
		{
			get
			{
				return this.canPreOpen_;
			}
			set
			{
				this.canPreOpen_ = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00042872 File Offset: 0x00040A72
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0004287A File Offset: 0x00040A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00042883 File Offset: 0x00040A83
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0004288B File Offset: 0x00040A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00042894 File Offset: 0x00040A94
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0004289C File Offset: 0x00040A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitRewardBeginTime
		{
			get
			{
				return this.limitRewardBeginTime_;
			}
			set
			{
				this.limitRewardBeginTime_ = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000428A5 File Offset: 0x00040AA5
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x000428AD File Offset: 0x00040AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitRewardEndTime
		{
			get
			{
				return this.limitRewardEndTime_;
			}
			set
			{
				this.limitRewardEndTime_ = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000428B6 File Offset: 0x00040AB6
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x000428CF File Offset: 0x00040ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivity ParkourActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ParkourActivity)
				{
					return null;
				}
				return (ParkourActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ParkourActivity);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000428E6 File Offset: 0x00040AE6
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x000428FF File Offset: 0x00040AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivity SignActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SignActivity)
				{
					return null;
				}
				return (SignActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SignActivity);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00042916 File Offset: 0x00040B16
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0004292F File Offset: 0x00040B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity NewBieCourseActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewBieCourseActivity)
				{
					return null;
				}
				return (NewBieCourseActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewBieCourseActivity);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00042946 File Offset: 0x00040B46
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0004295F File Offset: 0x00040B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward DoubleInstActivityReward
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.DoubleInstActivityReward)
				{
					return null;
				}
				return (DoubleInstActivityReward)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.DoubleInstActivityReward);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00042976 File Offset: 0x00040B76
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0004298F File Offset: 0x00040B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity HarvestActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.HarvestActivity)
				{
					return null;
				}
				return (HarvestActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.HarvestActivity);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000429A6 File Offset: 0x00040BA6
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x000429BF File Offset: 0x00040BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialInfoActivity RoleTrialInfoActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoleTrialInfoActivity)
				{
					return null;
				}
				return (RoleTrialInfoActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoleTrialInfoActivity);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000429D6 File Offset: 0x00040BD6
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x000429EF File Offset: 0x00040BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity PhantomCollectActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PhantomCollectActivity)
				{
					return null;
				}
				return (PhantomCollectActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PhantomCollectActivity);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00042A06 File Offset: 0x00040C06
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x00042A1F File Offset: 0x00040C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo GatherActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.GatherActivityInfo)
				{
					return null;
				}
				return (GatherActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.GatherActivityInfo);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00042A36 File Offset: 0x00040C36
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00042A4F File Offset: 0x00040C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData DailyAdventureActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.DailyAdventureActivityData)
				{
					return null;
				}
				return (DailyAdventureActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.DailyAdventureActivityData);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00042A66 File Offset: 0x00040C66
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x00042A7F File Offset: 0x00040C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData RoguelikeActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoguelikeActivityData)
				{
					return null;
				}
				return (RoguelikeActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoguelikeActivityData);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00042A96 File Offset: 0x00040C96
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x00042AAF File Offset: 0x00040CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity LongShanActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.LongShanActivityData)
				{
					return null;
				}
				return (LongShanActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.LongShanActivityData);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00042AC6 File Offset: 0x00040CC6
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00042ADF File Offset: 0x00040CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData TurntableActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TurntableActivityData)
				{
					return null;
				}
				return (TurntableActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TurntableActivityData);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00042AF6 File Offset: 0x00040CF6
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00042B0F File Offset: 0x00040D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData BossRushActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.BossRushActivityData)
				{
					return null;
				}
				return (BossRushActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.BossRushActivityData);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00042B26 File Offset: 0x00040D26
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x00042B3F File Offset: 0x00040D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData TrackMoonActivityTaskData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TrackMoonActivityTaskData)
				{
					return null;
				}
				return (ActivityTaskData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TrackMoonActivityTaskData);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00042B56 File Offset: 0x00040D56
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00042B6F File Offset: 0x00040D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData TimePointRewardActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TimePointRewardActivityData)
				{
					return null;
				}
				return (TimePointRewardActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TimePointRewardActivityData);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00042B86 File Offset: 0x00040D86
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x00042B9F File Offset: 0x00040D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo TowerDefenceActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TowerDefenceActivityData)
				{
					return null;
				}
				return (TowerDefenceActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TowerDefenceActivityData);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00042BB6 File Offset: 0x00040DB6
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x00042BCF File Offset: 0x00040DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData CircumFluenceTaskData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.CircumFluenceTaskData)
				{
					return null;
				}
				return (CircumFluenceData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.CircumFluenceTaskData);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00042BE6 File Offset: 0x00040DE6
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00042BFF File Offset: 0x00040DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData TraceMoonPhaseData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TraceMoonPhaseData)
				{
					return null;
				}
				return (TraceMoonPhaseData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TraceMoonPhaseData);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00042C16 File Offset: 0x00040E16
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00042C2F File Offset: 0x00040E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingData CorniceMeetingData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.CorniceMeetingData)
				{
					return null;
				}
				return (CorniceMeetingData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.CorniceMeetingData);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00042C46 File Offset: 0x00040E46
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00042C5F File Offset: 0x00040E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo RiskHarvestActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RiskHarvestActivityInfo)
				{
					return null;
				}
				return (RiskHarvestActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RiskHarvestActivityInfo);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00042C76 File Offset: 0x00040E76
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00042C8F File Offset: 0x00040E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActivity BlackCoastThemeActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.BlackCoastThemeActivityData)
				{
					return null;
				}
				return (BlackCoastThemeActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.BlackCoastThemeActivityData);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00042CA6 File Offset: 0x00040EA6
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00042CBF File Offset: 0x00040EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData RogueWhiteCatData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RogueWhiteCatData)
				{
					return null;
				}
				return (RogueWhiteCatData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RogueWhiteCatData);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00042CD6 File Offset: 0x00040ED6
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00042CEF File Offset: 0x00040EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo ScratchCardActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ScratchCardActivityInfo)
				{
					return null;
				}
				return (ScratchCardActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ScratchCardActivityInfo);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00042D06 File Offset: 0x00040F06
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00042D1F File Offset: 0x00040F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignActivityInfo PreheatSignActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PreheatSignActivityInfo)
				{
					return null;
				}
				return (PreheatSignActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PreheatSignActivityInfo);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00042D36 File Offset: 0x00040F36
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00042D4F File Offset: 0x00040F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo MowTowerActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MowTowerActivityInfo)
				{
					return null;
				}
				return (MowTowerActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MowTowerActivityInfo);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00042D66 File Offset: 0x00040F66
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00042D7F File Offset: 0x00040F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo FarmGoldInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FarmGoldInfo)
				{
					return null;
				}
				return (FarmGoldInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FarmGoldInfo);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00042D96 File Offset: 0x00040F96
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00042DAF File Offset: 0x00040FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignInfo SpringSignInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SpringSignInfo)
				{
					return null;
				}
				return (SpringSignInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SpringSignInfo);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00042DC6 File Offset: 0x00040FC6
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00042DDF File Offset: 0x00040FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo MapTravelActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MapTravelActivityInfo)
				{
					return null;
				}
				return (MapTravelActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MapTravelActivityInfo);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00042DF6 File Offset: 0x00040FF6
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00042E0F File Offset: 0x0004100F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialInfoActivity RoleSkinTrialInfoActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
				{
					return null;
				}
				return (RoleSkinTrialInfoActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoleSkinTrialInfoActivity);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00042E26 File Offset: 0x00041026
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x00042E3F File Offset: 0x0004103F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo FishingActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FishingActivityInfo)
				{
					return null;
				}
				return (FishingActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FishingActivityInfo);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00042E56 File Offset: 0x00041056
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x00042E6F File Offset: 0x0004106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData RogueWeeklyData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RogueWeeklyData)
				{
					return null;
				}
				return (RogueWeeklyData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RogueWeeklyData);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00042E86 File Offset: 0x00041086
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x00042E9F File Offset: 0x0004109F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelActivityInfo TeamParkourLevelActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
				{
					return null;
				}
				return (TeamParkourLevelActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TeamParkourLevelActivityInfo);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x00042EB6 File Offset: 0x000410B6
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x00042ECF File Offset: 0x000410CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInfo BabelActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.BabelActivityInfo)
				{
					return null;
				}
				return (BabelActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.BabelActivityInfo);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00042EE6 File Offset: 0x000410E6
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x00042EFF File Offset: 0x000410FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData RacingBetsData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RacingBetsData)
				{
					return null;
				}
				return (RacingBetsActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RacingBetsData);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00042F16 File Offset: 0x00041116
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x00042F2F File Offset: 0x0004112F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityInfo ExploreActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ExploreActivityInfo)
				{
					return null;
				}
				return (ExploreActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ExploreActivityInfo);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00042F46 File Offset: 0x00041146
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x00042F5F File Offset: 0x0004115F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData RogueResActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RogueResActivityData)
				{
					return null;
				}
				return (RogueResActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RogueResActivityData);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00042F76 File Offset: 0x00041176
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x00042F8F File Offset: 0x0004118F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo AvignonActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.AvignonActivityInfo)
				{
					return null;
				}
				return (AvignonActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.AvignonActivityInfo);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00042FA6 File Offset: 0x000411A6
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x00042FBF File Offset: 0x000411BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInfo AbyssInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.AbyssInfo)
				{
					return null;
				}
				return (AbyssInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.AbyssInfo);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00042FD6 File Offset: 0x000411D6
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x00042FEF File Offset: 0x000411EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData H5CircumFluenceData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.H5CircumFluenceData)
				{
					return null;
				}
				return (H5CircumFluenceActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.H5CircumFluenceData);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00043006 File Offset: 0x00041206
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0004301F File Offset: 0x0004121F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData DangoMonopolyActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.DangoMonopolyActivityData)
				{
					return null;
				}
				return (DangoMonopolyActivityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.DangoMonopolyActivityData);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00043036 File Offset: 0x00041236
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0004304F File Offset: 0x0004124F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData CiacconaActivityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.CiacconaActivityPbData)
				{
					return null;
				}
				return (CiacconaActivityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.CiacconaActivityPbData);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00043066 File Offset: 0x00041266
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x0004307F File Offset: 0x0004127F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageData ActivityLinkageData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ActivityLinkageData)
				{
					return null;
				}
				return (ActivityLinkageData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ActivityLinkageData);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00043096 File Offset: 0x00041296
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x000430AF File Offset: 0x000412AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData RegressData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RegressData)
				{
					return null;
				}
				return (RegressData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RegressData);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x000430C6 File Offset: 0x000412C6
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x000430DF File Offset: 0x000412DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo ConsumptiveActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ConsumptiveActivityInfo)
				{
					return null;
				}
				return (ConsumptiveActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ConsumptiveActivityInfo);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000430F6 File Offset: 0x000412F6
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0004310F File Offset: 0x0004130F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo PhantomBattleActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PhantomBattleActivityInfo)
				{
					return null;
				}
				return (PhantomBattleActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PhantomBattleActivityInfo);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00043126 File Offset: 0x00041326
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0004313F File Offset: 0x0004133F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalData NewbieCarnivalData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewbieCarnivalData)
				{
					return null;
				}
				return (NewbieCarnivalData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewbieCarnivalData);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00043156 File Offset: 0x00041356
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x0004316F File Offset: 0x0004136F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData MoraleActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MoraleActivityData)
				{
					return null;
				}
				return (MoraleActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MoraleActivityData);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00043186 File Offset: 0x00041386
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x0004319F File Offset: 0x0004139F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData FloroRanchActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FloroRanchActivityData)
				{
					return null;
				}
				return (FloroRanchActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FloroRanchActivityData);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x000431B6 File Offset: 0x000413B6
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x000431CF File Offset: 0x000413CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeActivityData LifePointChallenge
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.LifePointChallenge)
				{
					return null;
				}
				return (LifePointChallengeActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.LifePointChallenge);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x000431E6 File Offset: 0x000413E6
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x000431FF File Offset: 0x000413FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo TrapDefenseActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TrapDefenseActivityInfo)
				{
					return null;
				}
				return (TrapDefenseActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TrapDefenseActivityInfo);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00043216 File Offset: 0x00041416
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0004322F File Offset: 0x0004142F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayActivityInfo FunPlayActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FunPlayActivityInfo)
				{
					return null;
				}
				return (FunPlayActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FunPlayActivityInfo);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x00043246 File Offset: 0x00041446
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0004325F File Offset: 0x0004145F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData JinzhouFlyData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.JinzhouFlyData)
				{
					return null;
				}
				return (JinzhouFlyData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.JinzhouFlyData);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00043276 File Offset: 0x00041476
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0004328F File Offset: 0x0004148F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData LineCrossActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.LineCrossActivityData)
				{
					return null;
				}
				return (LineCrossActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.LineCrossActivityData);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x000432A6 File Offset: 0x000414A6
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x000432BF File Offset: 0x000414BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData MoonPhaseActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MoonPhaseActivityData)
				{
					return null;
				}
				return (MoonPhaseActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MoonPhaseActivityData);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x000432D6 File Offset: 0x000414D6
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x000432EF File Offset: 0x000414EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo HonamiStoryActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.HonamiStoryActivityInfo)
				{
					return null;
				}
				return (HonamiStoryActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.HonamiStoryActivityInfo);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00043306 File Offset: 0x00041506
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0004331F File Offset: 0x0004151F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb PhotoFightActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PhotoFightActivityData)
				{
					return null;
				}
				return (PhotoFightActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PhotoFightActivityData);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00043336 File Offset: 0x00041536
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0004334F File Offset: 0x0004154F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData SurvivorsActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SurvivorsActivityData)
				{
					return null;
				}
				return (SurvivorsActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SurvivorsActivityData);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00043366 File Offset: 0x00041566
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0004337F File Offset: 0x0004157F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb WuWuKujiActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.WuWuKujiActivityInfo)
				{
					return null;
				}
				return (WuWuKujiActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.WuWuKujiActivityInfo);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00043396 File Offset: 0x00041596
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x000433AF File Offset: 0x000415AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdvertisingPageData AdvertisingPageInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.AdvertisingPageInfo)
				{
					return null;
				}
				return (AdvertisingPageData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.AdvertisingPageInfo);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x000433C6 File Offset: 0x000415C6
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x000433DF File Offset: 0x000415DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo ArtemisActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ArtemisActivityInfo)
				{
					return null;
				}
				return (ArtemisActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ArtemisActivityInfo);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x000433F6 File Offset: 0x000415F6
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0004340F File Offset: 0x0004160F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleCoopActivityData RoleCoopActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoleCoopActivityData)
				{
					return null;
				}
				return (RoleCoopActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoleCoopActivityData);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00043426 File Offset: 0x00041626
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0004343F File Offset: 0x0004163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleIpActivityData MotorCycleIpActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MotorCycleIpActivityData)
				{
					return null;
				}
				return (MotorCycleIpActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MotorCycleIpActivityData);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00043456 File Offset: 0x00041656
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0004346F File Offset: 0x0004166F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleActivityInfo PhantomBattleRecordActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo)
				{
					return null;
				}
				return (PhantomBattleActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00043486 File Offset: 0x00041686
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0004349F File Offset: 0x0004169F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityPb InfrThemeActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.InfrThemeActivityPb)
				{
					return null;
				}
				return (InfrThemeActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.InfrThemeActivityPb);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000434B6 File Offset: 0x000416B6
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x000434CF File Offset: 0x000416CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo RoadBookActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoadBookActivityInfo)
				{
					return null;
				}
				return (RoadBookActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoadBookActivityInfo);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x000434E6 File Offset: 0x000416E6
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x000434FF File Offset: 0x000416FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideActivity PhantomBattleGuideActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PhantomBattleGuideActivity)
				{
					return null;
				}
				return (PhantomBattleGuideActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PhantomBattleGuideActivity);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00043516 File Offset: 0x00041716
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0004352F File Offset: 0x0004172F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData NewTowerClimbingActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewTowerClimbingActivityData)
				{
					return null;
				}
				return (NewTowerClimbingActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewTowerClimbingActivityData);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00043546 File Offset: 0x00041746
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0004355F File Offset: 0x0004175F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityData NewPlayerSupportActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewPlayerSupportActivityData)
				{
					return null;
				}
				return (NewPlayerSupportActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewPlayerSupportActivityData);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00043576 File Offset: 0x00041776
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0004358F File Offset: 0x0004178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo MotorParkourActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MotorParkourActivityInfo)
				{
					return null;
				}
				return (MotorParkourActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MotorParkourActivityInfo);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000435A6 File Offset: 0x000417A6
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x000435BF File Offset: 0x000417BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo SpringFestivalActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SpringFestivalActivityInfo)
				{
					return null;
				}
				return (SpringFestivalActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SpringFestivalActivityInfo);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x000435D6 File Offset: 0x000417D6
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x000435EF File Offset: 0x000417EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo TotalTopUpActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TotalTopUpActivityInfo)
				{
					return null;
				}
				return (TotalTopUpActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TotalTopUpActivityInfo);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00043606 File Offset: 0x00041806
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0004361F File Offset: 0x0004181F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightActivityPb MotorFightActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MotorFightActivityPb)
				{
					return null;
				}
				return (MotorFightActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MotorFightActivityPb);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00043636 File Offset: 0x00041836
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0004364F File Offset: 0x0004184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData H5ViewActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.H5ViewActivityData)
				{
					return null;
				}
				return (H5ViewActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.H5ViewActivityData);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00043666 File Offset: 0x00041866
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0004367F File Offset: 0x0004187F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData SkinRewardActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SkinRewardActivityData)
				{
					return null;
				}
				return (SkinRewardActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SkinRewardActivityData);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00043696 File Offset: 0x00041896
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x000436AF File Offset: 0x000418AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleActivityPb EncircleActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.EncircleActivityPb)
				{
					return null;
				}
				return (EncircleActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.EncircleActivityPb);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000436C6 File Offset: 0x000418C6
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x000436DF File Offset: 0x000418DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData MotorDevelopActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MotorDevelopActivityData)
				{
					return null;
				}
				return (MotorDevelopActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MotorDevelopActivityData);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000436F6 File Offset: 0x000418F6
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0004370F File Offset: 0x0004190F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeActivityInfo FlagChallengeActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FlagChallengeActivityInfo)
				{
					return null;
				}
				return (FlagChallengeActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FlagChallengeActivityInfo);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00043726 File Offset: 0x00041926
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0004373F File Offset: 0x0004193F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatActivityInfo FeiXuePreheatActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.FeiXuePreheatActivityInfo)
				{
					return null;
				}
				return (FeiXuePreheatActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.FeiXuePreheatActivityInfo);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00043756 File Offset: 0x00041956
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0004376F File Offset: 0x0004196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb RhythmActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RhythmActivityPb)
				{
					return null;
				}
				return (RhythmActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RhythmActivityPb);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00043786 File Offset: 0x00041986
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0004379F File Offset: 0x0004199F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo DropCatchActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.DropCatchActivityInfo)
				{
					return null;
				}
				return (DropCatchActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.DropCatchActivityInfo);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000437B6 File Offset: 0x000419B6
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x000437CF File Offset: 0x000419CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo TetrisActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.TetrisActivityInfo)
				{
					return null;
				}
				return (TetrisActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.TetrisActivityInfo);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x000437E6 File Offset: 0x000419E6
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x000437FF File Offset: 0x000419FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballActivityData PinballActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.PinballActivityData)
				{
					return null;
				}
				return (PinballActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.PinballActivityData);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00043816 File Offset: 0x00041A16
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0004382F File Offset: 0x00041A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo BossPilingActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.BossPilingActivityInfo)
				{
					return null;
				}
				return (BossPilingActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.BossPilingActivityInfo);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00043846 File Offset: 0x00041A46
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0004385F File Offset: 0x00041A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration ThemeCelebration
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ThemeCelebration)
				{
					return null;
				}
				return (ThemeCelebration)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ThemeCelebration);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00043876 File Offset: 0x00041A76
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0004388F File Offset: 0x00041A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuWeekActivity WuWuWeekActivity
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.WuWuWeekActivity)
				{
					return null;
				}
				return (WuWuWeekActivity)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.WuWuWeekActivity);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x000438A6 File Offset: 0x00041AA6
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x000438BF File Offset: 0x00041ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalActivityData MotorDecalActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MotorDecalActivityData)
				{
					return null;
				}
				return (MotorDecalActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MotorDecalActivityData);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x000438D6 File Offset: 0x00041AD6
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x000438EF File Offset: 0x00041AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData LinkageCheckInActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.LinkageCheckInActivityData)
				{
					return null;
				}
				return (LinkageCheckInActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.LinkageCheckInActivityData);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00043906 File Offset: 0x00041B06
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0004391F File Offset: 0x00041B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData RoleGiftActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoleGiftActivityData)
				{
					return null;
				}
				return (RoleGiftActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoleGiftActivityData);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00043936 File Offset: 0x00041B36
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0004394F File Offset: 0x00041B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoActivityData KurotatoActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.KurotatoActivityData)
				{
					return null;
				}
				return (KurotatoActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.KurotatoActivityData);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00043966 File Offset: 0x00041B66
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0004397F File Offset: 0x00041B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo GolemCrackActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.GolemCrackActivityInfo)
				{
					return null;
				}
				return (GolemCrackActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.GolemCrackActivityInfo);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00043996 File Offset: 0x00041B96
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x000439AF File Offset: 0x00041BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo EdgeRunnerActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.EdgeRunnerActivityInfo)
				{
					return null;
				}
				return (EdgeRunnerActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.EdgeRunnerActivityInfo);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000439C6 File Offset: 0x00041BC6
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x000439DF File Offset: 0x00041BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData OnlineMotorActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.OnlineMotorActivityData)
				{
					return null;
				}
				return (OnlineMotorActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.OnlineMotorActivityData);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x000439F6 File Offset: 0x00041BF6
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00043A0F File Offset: 0x00041C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo RealmBetweenActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RealmBetweenActivityInfo)
				{
					return null;
				}
				return (RealmBetweenActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RealmBetweenActivityInfo);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00043A26 File Offset: 0x00041C26
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00043A3F File Offset: 0x00041C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainSummaryActivityData ThroughTrainSummaryActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ThroughTrainSummaryActivityData)
				{
					return null;
				}
				return (ThroughTrainSummaryActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ThroughTrainSummaryActivityData);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00043A56 File Offset: 0x00041C56
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x00043A6F File Offset: 0x00041C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainActivityPb NewbieMainActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewbieMainActivityPb)
				{
					return null;
				}
				return (NewbieMainActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewbieMainActivityPb);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00043A86 File Offset: 0x00041C86
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00043A9F File Offset: 0x00041C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb NewbieCourseV2ActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewbieCourseV2ActivityPb)
				{
					return null;
				}
				return (NewbieCourseV2ActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewbieCourseV2ActivityPb);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00043AB6 File Offset: 0x00041CB6
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00043ACF File Offset: 0x00041CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureV2Pb NewbieAdventureV2Pb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewbieAdventureV2Pb)
				{
					return null;
				}
				return (NewbieAdventureV2Pb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewbieAdventureV2Pb);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00043AE6 File Offset: 0x00041CE6
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00043AFF File Offset: 0x00041CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb NewPlayerSupportActivityV2Pb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb)
				{
					return null;
				}
				return (NewPlayerSupportActivityV2Pb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00043B16 File Offset: 0x00041D16
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x00043B2F File Offset: 0x00041D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainActivityData ThroughTrainActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.ThroughTrainActivityData)
				{
					return null;
				}
				return (ThroughTrainActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.ThroughTrainActivityData);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00043B46 File Offset: 0x00041D46
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x00043B5F File Offset: 0x00041D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueActivityData RoverRogueActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoverRogueActivityData)
				{
					return null;
				}
				return (RoverRogueActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoverRogueActivityData);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00043B76 File Offset: 0x00041D76
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x00043B8F File Offset: 0x00041D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo DangoBrawlActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.DangoBrawlActivityInfo)
				{
					return null;
				}
				return (DangoBrawlActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.DangoBrawlActivityInfo);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00043BA6 File Offset: 0x00041DA6
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x00043BBF File Offset: 0x00041DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoActivityInfo QingXiaoActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.QingXiaoActivityInfo)
				{
					return null;
				}
				return (QingXiaoActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.QingXiaoActivityInfo);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00043BD6 File Offset: 0x00041DD6
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x00043BEF File Offset: 0x00041DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo MatchThreeActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.MatchThreeActivityInfo)
				{
					return null;
				}
				return (MatchThreeActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.MatchThreeActivityInfo);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00043C06 File Offset: 0x00041E06
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00043C1F File Offset: 0x00041E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo GiantActivityInfo
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.GiantActivityInfo)
				{
					return null;
				}
				return (GiantActivityInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.GiantActivityInfo);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00043C36 File Offset: 0x00041E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00043C3E File Offset: 0x00041E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ActivityData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00043C4E File Offset: 0x00041E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityData);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00043C5C File Offset: 0x00041E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && this.BeginShowTime == other.BeginShowTime && this.EndShowTime == other.EndShowTime && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && this.IsUnlock == other.IsUnlock && this.completePreQuests_.Equals(other.completePreQuests_) && this.IsFirstOpen == other.IsFirstOpen && this.finishConditions_.Equals(other.finishConditions_) && this.ActivityOpenType == other.ActivityOpenType && this.CanPreOpen == other.CanPreOpen && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && this.LimitRewardBeginTime == other.LimitRewardBeginTime && this.LimitRewardEndTime == other.LimitRewardEndTime && object.Equals(this.ParkourActivity, other.ParkourActivity) && object.Equals(this.SignActivity, other.SignActivity) && object.Equals(this.NewBieCourseActivity, other.NewBieCourseActivity) && object.Equals(this.DoubleInstActivityReward, other.DoubleInstActivityReward) && object.Equals(this.HarvestActivity, other.HarvestActivity) && object.Equals(this.RoleTrialInfoActivity, other.RoleTrialInfoActivity) && object.Equals(this.PhantomCollectActivity, other.PhantomCollectActivity) && object.Equals(this.GatherActivityInfo, other.GatherActivityInfo) && object.Equals(this.DailyAdventureActivityData, other.DailyAdventureActivityData) && object.Equals(this.RoguelikeActivityData, other.RoguelikeActivityData) && object.Equals(this.LongShanActivityData, other.LongShanActivityData) && object.Equals(this.TurntableActivityData, other.TurntableActivityData) && object.Equals(this.BossRushActivityData, other.BossRushActivityData) && object.Equals(this.TrackMoonActivityTaskData, other.TrackMoonActivityTaskData) && object.Equals(this.TimePointRewardActivityData, other.TimePointRewardActivityData) && object.Equals(this.TowerDefenceActivityData, other.TowerDefenceActivityData) && object.Equals(this.CircumFluenceTaskData, other.CircumFluenceTaskData) && object.Equals(this.TraceMoonPhaseData, other.TraceMoonPhaseData) && object.Equals(this.CorniceMeetingData, other.CorniceMeetingData) && object.Equals(this.RiskHarvestActivityInfo, other.RiskHarvestActivityInfo) && object.Equals(this.BlackCoastThemeActivityData, other.BlackCoastThemeActivityData) && object.Equals(this.RogueWhiteCatData, other.RogueWhiteCatData) && object.Equals(this.ScratchCardActivityInfo, other.ScratchCardActivityInfo) && object.Equals(this.PreheatSignActivityInfo, other.PreheatSignActivityInfo) && object.Equals(this.MowTowerActivityInfo, other.MowTowerActivityInfo) && object.Equals(this.FarmGoldInfo, other.FarmGoldInfo) && object.Equals(this.SpringSignInfo, other.SpringSignInfo) && object.Equals(this.MapTravelActivityInfo, other.MapTravelActivityInfo) && object.Equals(this.RoleSkinTrialInfoActivity, other.RoleSkinTrialInfoActivity) && object.Equals(this.FishingActivityInfo, other.FishingActivityInfo) && object.Equals(this.RogueWeeklyData, other.RogueWeeklyData) && object.Equals(this.TeamParkourLevelActivityInfo, other.TeamParkourLevelActivityInfo) && object.Equals(this.BabelActivityInfo, other.BabelActivityInfo) && object.Equals(this.RacingBetsData, other.RacingBetsData) && object.Equals(this.ExploreActivityInfo, other.ExploreActivityInfo) && object.Equals(this.RogueResActivityData, other.RogueResActivityData) && object.Equals(this.AvignonActivityInfo, other.AvignonActivityInfo) && object.Equals(this.AbyssInfo, other.AbyssInfo) && object.Equals(this.H5CircumFluenceData, other.H5CircumFluenceData) && object.Equals(this.DangoMonopolyActivityData, other.DangoMonopolyActivityData) && object.Equals(this.CiacconaActivityPbData, other.CiacconaActivityPbData) && object.Equals(this.ActivityLinkageData, other.ActivityLinkageData) && object.Equals(this.RegressData, other.RegressData) && object.Equals(this.ConsumptiveActivityInfo, other.ConsumptiveActivityInfo) && object.Equals(this.PhantomBattleActivityInfo, other.PhantomBattleActivityInfo) && object.Equals(this.NewbieCarnivalData, other.NewbieCarnivalData) && object.Equals(this.MoraleActivityData, other.MoraleActivityData) && object.Equals(this.FloroRanchActivityData, other.FloroRanchActivityData) && object.Equals(this.LifePointChallenge, other.LifePointChallenge) && object.Equals(this.TrapDefenseActivityInfo, other.TrapDefenseActivityInfo) && object.Equals(this.FunPlayActivityInfo, other.FunPlayActivityInfo) && object.Equals(this.JinzhouFlyData, other.JinzhouFlyData) && object.Equals(this.LineCrossActivityData, other.LineCrossActivityData) && object.Equals(this.MoonPhaseActivityData, other.MoonPhaseActivityData) && object.Equals(this.HonamiStoryActivityInfo, other.HonamiStoryActivityInfo) && object.Equals(this.PhotoFightActivityData, other.PhotoFightActivityData) && object.Equals(this.SurvivorsActivityData, other.SurvivorsActivityData) && object.Equals(this.WuWuKujiActivityInfo, other.WuWuKujiActivityInfo) && object.Equals(this.AdvertisingPageInfo, other.AdvertisingPageInfo) && object.Equals(this.ArtemisActivityInfo, other.ArtemisActivityInfo) && object.Equals(this.RoleCoopActivityData, other.RoleCoopActivityData) && object.Equals(this.MotorCycleIpActivityData, other.MotorCycleIpActivityData) && object.Equals(this.PhantomBattleRecordActivityInfo, other.PhantomBattleRecordActivityInfo) && object.Equals(this.InfrThemeActivityPb, other.InfrThemeActivityPb) && object.Equals(this.RoadBookActivityInfo, other.RoadBookActivityInfo) && object.Equals(this.PhantomBattleGuideActivity, other.PhantomBattleGuideActivity) && object.Equals(this.NewTowerClimbingActivityData, other.NewTowerClimbingActivityData) && object.Equals(this.NewPlayerSupportActivityData, other.NewPlayerSupportActivityData) && object.Equals(this.MotorParkourActivityInfo, other.MotorParkourActivityInfo) && object.Equals(this.SpringFestivalActivityInfo, other.SpringFestivalActivityInfo) && object.Equals(this.TotalTopUpActivityInfo, other.TotalTopUpActivityInfo) && object.Equals(this.MotorFightActivityPb, other.MotorFightActivityPb) && object.Equals(this.H5ViewActivityData, other.H5ViewActivityData) && object.Equals(this.SkinRewardActivityData, other.SkinRewardActivityData) && object.Equals(this.EncircleActivityPb, other.EncircleActivityPb) && object.Equals(this.MotorDevelopActivityData, other.MotorDevelopActivityData) && object.Equals(this.FlagChallengeActivityInfo, other.FlagChallengeActivityInfo) && object.Equals(this.FeiXuePreheatActivityInfo, other.FeiXuePreheatActivityInfo) && object.Equals(this.RhythmActivityPb, other.RhythmActivityPb) && object.Equals(this.DropCatchActivityInfo, other.DropCatchActivityInfo) && object.Equals(this.TetrisActivityInfo, other.TetrisActivityInfo) && object.Equals(this.PinballActivityData, other.PinballActivityData) && object.Equals(this.BossPilingActivityInfo, other.BossPilingActivityInfo) && object.Equals(this.ThemeCelebration, other.ThemeCelebration) && object.Equals(this.WuWuWeekActivity, other.WuWuWeekActivity) && object.Equals(this.MotorDecalActivityData, other.MotorDecalActivityData) && object.Equals(this.LinkageCheckInActivityData, other.LinkageCheckInActivityData) && object.Equals(this.RoleGiftActivityData, other.RoleGiftActivityData) && object.Equals(this.KurotatoActivityData, other.KurotatoActivityData) && object.Equals(this.GolemCrackActivityInfo, other.GolemCrackActivityInfo) && object.Equals(this.EdgeRunnerActivityInfo, other.EdgeRunnerActivityInfo) && object.Equals(this.OnlineMotorActivityData, other.OnlineMotorActivityData) && object.Equals(this.RealmBetweenActivityInfo, other.RealmBetweenActivityInfo) && object.Equals(this.ThroughTrainSummaryActivityData, other.ThroughTrainSummaryActivityData) && object.Equals(this.NewbieMainActivityPb, other.NewbieMainActivityPb) && object.Equals(this.NewbieCourseV2ActivityPb, other.NewbieCourseV2ActivityPb) && object.Equals(this.NewbieAdventureV2Pb, other.NewbieAdventureV2Pb) && object.Equals(this.NewPlayerSupportActivityV2Pb, other.NewPlayerSupportActivityV2Pb) && object.Equals(this.ThroughTrainActivityData, other.ThroughTrainActivityData) && object.Equals(this.RoverRogueActivityData, other.RoverRogueActivityData) && object.Equals(this.DangoBrawlActivityInfo, other.DangoBrawlActivityInfo) && object.Equals(this.QingXiaoActivityInfo, other.QingXiaoActivityInfo) && object.Equals(this.MatchThreeActivityInfo, other.MatchThreeActivityInfo) && object.Equals(this.GiantActivityInfo, other.GiantActivityInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00044628 File Offset: 0x00042828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != ActivityType.Parkour)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.BeginShowTime != 0L)
			{
				num ^= this.BeginShowTime.GetHashCode();
			}
			if (this.EndShowTime != 0L)
			{
				num ^= this.EndShowTime.GetHashCode();
			}
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this.EndOpenTime != 0L)
			{
				num ^= this.EndOpenTime.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			num ^= this.completePreQuests_.GetHashCode();
			if (this.IsFirstOpen)
			{
				num ^= this.IsFirstOpen.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this.ActivityOpenType != ActivityOpenType.TimeLimited)
			{
				num ^= this.ActivityOpenType.GetHashCode();
			}
			if (this.CanPreOpen)
			{
				num ^= this.CanPreOpen.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this.LimitRewardBeginTime != 0L)
			{
				num ^= this.LimitRewardBeginTime.GetHashCode();
			}
			if (this.LimitRewardEndTime != 0L)
			{
				num ^= this.LimitRewardEndTime.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ParkourActivity)
			{
				num ^= this.ParkourActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SignActivity)
			{
				num ^= this.SignActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewBieCourseActivity)
			{
				num ^= this.NewBieCourseActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DoubleInstActivityReward)
			{
				num ^= this.DoubleInstActivityReward.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HarvestActivity)
			{
				num ^= this.HarvestActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTrialInfoActivity)
			{
				num ^= this.RoleTrialInfoActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomCollectActivity)
			{
				num ^= this.PhantomCollectActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GatherActivityInfo)
			{
				num ^= this.GatherActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DailyAdventureActivityData)
			{
				num ^= this.DailyAdventureActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoguelikeActivityData)
			{
				num ^= this.RoguelikeActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LongShanActivityData)
			{
				num ^= this.LongShanActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TurntableActivityData)
			{
				num ^= this.TurntableActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossRushActivityData)
			{
				num ^= this.BossRushActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrackMoonActivityTaskData)
			{
				num ^= this.TrackMoonActivityTaskData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TimePointRewardActivityData)
			{
				num ^= this.TimePointRewardActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TowerDefenceActivityData)
			{
				num ^= this.TowerDefenceActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CircumFluenceTaskData)
			{
				num ^= this.CircumFluenceTaskData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TraceMoonPhaseData)
			{
				num ^= this.TraceMoonPhaseData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CorniceMeetingData)
			{
				num ^= this.CorniceMeetingData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RiskHarvestActivityInfo)
			{
				num ^= this.RiskHarvestActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BlackCoastThemeActivityData)
			{
				num ^= this.BlackCoastThemeActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWhiteCatData)
			{
				num ^= this.RogueWhiteCatData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ScratchCardActivityInfo)
			{
				num ^= this.ScratchCardActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PreheatSignActivityInfo)
			{
				num ^= this.PreheatSignActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MowTowerActivityInfo)
			{
				num ^= this.MowTowerActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FarmGoldInfo)
			{
				num ^= this.FarmGoldInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringSignInfo)
			{
				num ^= this.SpringSignInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MapTravelActivityInfo)
			{
				num ^= this.MapTravelActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
			{
				num ^= this.RoleSkinTrialInfoActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FishingActivityInfo)
			{
				num ^= this.FishingActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWeeklyData)
			{
				num ^= this.RogueWeeklyData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
			{
				num ^= this.TeamParkourLevelActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BabelActivityInfo)
			{
				num ^= this.BabelActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RacingBetsData)
			{
				num ^= this.RacingBetsData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ExploreActivityInfo)
			{
				num ^= this.ExploreActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueResActivityData)
			{
				num ^= this.RogueResActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AvignonActivityInfo)
			{
				num ^= this.AvignonActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AbyssInfo)
			{
				num ^= this.AbyssInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5CircumFluenceData)
			{
				num ^= this.H5CircumFluenceData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoMonopolyActivityData)
			{
				num ^= this.DangoMonopolyActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CiacconaActivityPbData)
			{
				num ^= this.CiacconaActivityPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ActivityLinkageData)
			{
				num ^= this.ActivityLinkageData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RegressData)
			{
				num ^= this.RegressData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ConsumptiveActivityInfo)
			{
				num ^= this.ConsumptiveActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleActivityInfo)
			{
				num ^= this.PhantomBattleActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCarnivalData)
			{
				num ^= this.NewbieCarnivalData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoraleActivityData)
			{
				num ^= this.MoraleActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FloroRanchActivityData)
			{
				num ^= this.FloroRanchActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LifePointChallenge)
			{
				num ^= this.LifePointChallenge.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrapDefenseActivityInfo)
			{
				num ^= this.TrapDefenseActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FunPlayActivityInfo)
			{
				num ^= this.FunPlayActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.JinzhouFlyData)
			{
				num ^= this.JinzhouFlyData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LineCrossActivityData)
			{
				num ^= this.LineCrossActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoonPhaseActivityData)
			{
				num ^= this.MoonPhaseActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HonamiStoryActivityInfo)
			{
				num ^= this.HonamiStoryActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhotoFightActivityData)
			{
				num ^= this.PhotoFightActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SurvivorsActivityData)
			{
				num ^= this.SurvivorsActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuKujiActivityInfo)
			{
				num ^= this.WuWuKujiActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AdvertisingPageInfo)
			{
				num ^= this.AdvertisingPageInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ArtemisActivityInfo)
			{
				num ^= this.ArtemisActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleCoopActivityData)
			{
				num ^= this.RoleCoopActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorCycleIpActivityData)
			{
				num ^= this.MotorCycleIpActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo)
			{
				num ^= this.PhantomBattleRecordActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.InfrThemeActivityPb)
			{
				num ^= this.InfrThemeActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoadBookActivityInfo)
			{
				num ^= this.RoadBookActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleGuideActivity)
			{
				num ^= this.PhantomBattleGuideActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewTowerClimbingActivityData)
			{
				num ^= this.NewTowerClimbingActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityData)
			{
				num ^= this.NewPlayerSupportActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorParkourActivityInfo)
			{
				num ^= this.MotorParkourActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringFestivalActivityInfo)
			{
				num ^= this.SpringFestivalActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TotalTopUpActivityInfo)
			{
				num ^= this.TotalTopUpActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorFightActivityPb)
			{
				num ^= this.MotorFightActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5ViewActivityData)
			{
				num ^= this.H5ViewActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SkinRewardActivityData)
			{
				num ^= this.SkinRewardActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EncircleActivityPb)
			{
				num ^= this.EncircleActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDevelopActivityData)
			{
				num ^= this.MotorDevelopActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FlagChallengeActivityInfo)
			{
				num ^= this.FlagChallengeActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FeiXuePreheatActivityInfo)
			{
				num ^= this.FeiXuePreheatActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RhythmActivityPb)
			{
				num ^= this.RhythmActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DropCatchActivityInfo)
			{
				num ^= this.DropCatchActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TetrisActivityInfo)
			{
				num ^= this.TetrisActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PinballActivityData)
			{
				num ^= this.PinballActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossPilingActivityInfo)
			{
				num ^= this.BossPilingActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThemeCelebration)
			{
				num ^= this.ThemeCelebration.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuWeekActivity)
			{
				num ^= this.WuWuWeekActivity.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDecalActivityData)
			{
				num ^= this.MotorDecalActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LinkageCheckInActivityData)
			{
				num ^= this.LinkageCheckInActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleGiftActivityData)
			{
				num ^= this.RoleGiftActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.KurotatoActivityData)
			{
				num ^= this.KurotatoActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GolemCrackActivityInfo)
			{
				num ^= this.GolemCrackActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EdgeRunnerActivityInfo)
			{
				num ^= this.EdgeRunnerActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.OnlineMotorActivityData)
			{
				num ^= this.OnlineMotorActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RealmBetweenActivityInfo)
			{
				num ^= this.RealmBetweenActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainSummaryActivityData)
			{
				num ^= this.ThroughTrainSummaryActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieMainActivityPb)
			{
				num ^= this.NewbieMainActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCourseV2ActivityPb)
			{
				num ^= this.NewbieCourseV2ActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieAdventureV2Pb)
			{
				num ^= this.NewbieAdventureV2Pb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb)
			{
				num ^= this.NewPlayerSupportActivityV2Pb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainActivityData)
			{
				num ^= this.ThroughTrainActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoverRogueActivityData)
			{
				num ^= this.RoverRogueActivityData.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoBrawlActivityInfo)
			{
				num ^= this.DangoBrawlActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.QingXiaoActivityInfo)
			{
				num ^= this.QingXiaoActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MatchThreeActivityInfo)
			{
				num ^= this.MatchThreeActivityInfo.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GiantActivityInfo)
			{
				num ^= this.GiantActivityInfo.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000451A1 File Offset: 0x000433A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000451AE File Offset: 0x000433AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000451B8 File Offset: 0x000433B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.BeginShowTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BeginShowTime);
			}
			if (this.EndShowTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EndShowTime);
			}
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EndOpenTime);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlock);
			}
			this.completePreQuests_.WriteTo(ref output, ActivityData._repeated_completePreQuests_codec);
			if (this.IsFirstOpen)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsFirstOpen);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ParkourActivity)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ParkourActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SignActivity)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SignActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewBieCourseActivity)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.NewBieCourseActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DoubleInstActivityReward)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.DoubleInstActivityReward);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HarvestActivity)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.HarvestActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTrialInfoActivity)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RoleTrialInfoActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomCollectActivity)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.PhantomCollectActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GatherActivityInfo)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.GatherActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DailyAdventureActivityData)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.DailyAdventureActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoguelikeActivityData)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.RoguelikeActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LongShanActivityData)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.LongShanActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TurntableActivityData)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.TurntableActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossRushActivityData)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.BossRushActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrackMoonActivityTaskData)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.TrackMoonActivityTaskData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TimePointRewardActivityData)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.TimePointRewardActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TowerDefenceActivityData)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.TowerDefenceActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CircumFluenceTaskData)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.CircumFluenceTaskData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TraceMoonPhaseData)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.TraceMoonPhaseData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CorniceMeetingData)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.CorniceMeetingData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RiskHarvestActivityInfo)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.RiskHarvestActivityInfo);
			}
			this.finishConditions_.WriteTo(ref output, ActivityData._repeated_finishConditions_codec);
			if (this.dataCase_ == ActivityData.DataOneofCase.BlackCoastThemeActivityData)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.BlackCoastThemeActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWhiteCatData)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.RogueWhiteCatData);
			}
			if (this.ActivityOpenType != ActivityOpenType.TimeLimited)
			{
				output.WriteRawTag(136, 2);
				output.WriteEnum((int)this.ActivityOpenType);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ScratchCardActivityInfo)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.ScratchCardActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PreheatSignActivityInfo)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.PreheatSignActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MowTowerActivityInfo)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.MowTowerActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FarmGoldInfo)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.FarmGoldInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringSignInfo)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.SpringSignInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MapTravelActivityInfo)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.MapTravelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.RoleSkinTrialInfoActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FishingActivityInfo)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.FishingActivityInfo);
			}
			if (this.CanPreOpen)
			{
				output.WriteRawTag(208, 2);
				output.WriteBool(this.CanPreOpen);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWeeklyData)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.RogueWeeklyData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.TeamParkourLevelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BabelActivityInfo)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.BabelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RacingBetsData)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.RacingBetsData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ExploreActivityInfo)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.ExploreActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueResActivityData)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.RogueResActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AvignonActivityInfo)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.AvignonActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AbyssInfo)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.AbyssInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5CircumFluenceData)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.H5CircumFluenceData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoMonopolyActivityData)
			{
				output.WriteRawTag(162, 3);
				output.WriteMessage(this.DangoMonopolyActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CiacconaActivityPbData)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.CiacconaActivityPbData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ActivityLinkageData)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.ActivityLinkageData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RegressData)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.RegressData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ConsumptiveActivityInfo)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.ConsumptiveActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleActivityInfo)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.PhantomBattleActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCarnivalData)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.NewbieCarnivalData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoraleActivityData)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.MoraleActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FloroRanchActivityData)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.FloroRanchActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LifePointChallenge)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.LifePointChallenge);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrapDefenseActivityInfo)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.TrapDefenseActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FunPlayActivityInfo)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.FunPlayActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.JinzhouFlyData)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.JinzhouFlyData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LineCrossActivityData)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.LineCrossActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoonPhaseActivityData)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.MoonPhaseActivityData);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(152, 4);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(160, 4);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this.LimitRewardBeginTime != 0L)
			{
				output.WriteRawTag(168, 4);
				output.WriteInt64(this.LimitRewardBeginTime);
			}
			if (this.LimitRewardEndTime != 0L)
			{
				output.WriteRawTag(176, 4);
				output.WriteInt64(this.LimitRewardEndTime);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HonamiStoryActivityInfo)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.HonamiStoryActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhotoFightActivityData)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.PhotoFightActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SurvivorsActivityData)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.SurvivorsActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuKujiActivityInfo)
			{
				output.WriteRawTag(210, 4);
				output.WriteMessage(this.WuWuKujiActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AdvertisingPageInfo)
			{
				output.WriteRawTag(218, 4);
				output.WriteMessage(this.AdvertisingPageInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ArtemisActivityInfo)
			{
				output.WriteRawTag(226, 4);
				output.WriteMessage(this.ArtemisActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleCoopActivityData)
			{
				output.WriteRawTag(234, 4);
				output.WriteMessage(this.RoleCoopActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorCycleIpActivityData)
			{
				output.WriteRawTag(242, 4);
				output.WriteMessage(this.MotorCycleIpActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo)
			{
				output.WriteRawTag(250, 4);
				output.WriteMessage(this.PhantomBattleRecordActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.InfrThemeActivityPb)
			{
				output.WriteRawTag(130, 5);
				output.WriteMessage(this.InfrThemeActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoadBookActivityInfo)
			{
				output.WriteRawTag(138, 5);
				output.WriteMessage(this.RoadBookActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleGuideActivity)
			{
				output.WriteRawTag(146, 5);
				output.WriteMessage(this.PhantomBattleGuideActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewTowerClimbingActivityData)
			{
				output.WriteRawTag(154, 5);
				output.WriteMessage(this.NewTowerClimbingActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityData)
			{
				output.WriteRawTag(162, 5);
				output.WriteMessage(this.NewPlayerSupportActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorParkourActivityInfo)
			{
				output.WriteRawTag(170, 5);
				output.WriteMessage(this.MotorParkourActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringFestivalActivityInfo)
			{
				output.WriteRawTag(178, 5);
				output.WriteMessage(this.SpringFestivalActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TotalTopUpActivityInfo)
			{
				output.WriteRawTag(186, 5);
				output.WriteMessage(this.TotalTopUpActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorFightActivityPb)
			{
				output.WriteRawTag(194, 5);
				output.WriteMessage(this.MotorFightActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5ViewActivityData)
			{
				output.WriteRawTag(202, 5);
				output.WriteMessage(this.H5ViewActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SkinRewardActivityData)
			{
				output.WriteRawTag(210, 5);
				output.WriteMessage(this.SkinRewardActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EncircleActivityPb)
			{
				output.WriteRawTag(218, 5);
				output.WriteMessage(this.EncircleActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDevelopActivityData)
			{
				output.WriteRawTag(226, 5);
				output.WriteMessage(this.MotorDevelopActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FlagChallengeActivityInfo)
			{
				output.WriteRawTag(234, 5);
				output.WriteMessage(this.FlagChallengeActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FeiXuePreheatActivityInfo)
			{
				output.WriteRawTag(242, 5);
				output.WriteMessage(this.FeiXuePreheatActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RhythmActivityPb)
			{
				output.WriteRawTag(250, 5);
				output.WriteMessage(this.RhythmActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DropCatchActivityInfo)
			{
				output.WriteRawTag(130, 6);
				output.WriteMessage(this.DropCatchActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TetrisActivityInfo)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.TetrisActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PinballActivityData)
			{
				output.WriteRawTag(146, 6);
				output.WriteMessage(this.PinballActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossPilingActivityInfo)
			{
				output.WriteRawTag(154, 6);
				output.WriteMessage(this.BossPilingActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThemeCelebration)
			{
				output.WriteRawTag(162, 6);
				output.WriteMessage(this.ThemeCelebration);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuWeekActivity)
			{
				output.WriteRawTag(170, 6);
				output.WriteMessage(this.WuWuWeekActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDecalActivityData)
			{
				output.WriteRawTag(178, 6);
				output.WriteMessage(this.MotorDecalActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LinkageCheckInActivityData)
			{
				output.WriteRawTag(186, 6);
				output.WriteMessage(this.LinkageCheckInActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleGiftActivityData)
			{
				output.WriteRawTag(194, 6);
				output.WriteMessage(this.RoleGiftActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.KurotatoActivityData)
			{
				output.WriteRawTag(202, 6);
				output.WriteMessage(this.KurotatoActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GolemCrackActivityInfo)
			{
				output.WriteRawTag(210, 6);
				output.WriteMessage(this.GolemCrackActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EdgeRunnerActivityInfo)
			{
				output.WriteRawTag(218, 6);
				output.WriteMessage(this.EdgeRunnerActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.OnlineMotorActivityData)
			{
				output.WriteRawTag(226, 6);
				output.WriteMessage(this.OnlineMotorActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RealmBetweenActivityInfo)
			{
				output.WriteRawTag(234, 6);
				output.WriteMessage(this.RealmBetweenActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainSummaryActivityData)
			{
				output.WriteRawTag(242, 6);
				output.WriteMessage(this.ThroughTrainSummaryActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieMainActivityPb)
			{
				output.WriteRawTag(250, 6);
				output.WriteMessage(this.NewbieMainActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCourseV2ActivityPb)
			{
				output.WriteRawTag(130, 7);
				output.WriteMessage(this.NewbieCourseV2ActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieAdventureV2Pb)
			{
				output.WriteRawTag(138, 7);
				output.WriteMessage(this.NewbieAdventureV2Pb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb)
			{
				output.WriteRawTag(146, 7);
				output.WriteMessage(this.NewPlayerSupportActivityV2Pb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainActivityData)
			{
				output.WriteRawTag(154, 7);
				output.WriteMessage(this.ThroughTrainActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoverRogueActivityData)
			{
				output.WriteRawTag(162, 7);
				output.WriteMessage(this.RoverRogueActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoBrawlActivityInfo)
			{
				output.WriteRawTag(170, 7);
				output.WriteMessage(this.DangoBrawlActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.QingXiaoActivityInfo)
			{
				output.WriteRawTag(178, 7);
				output.WriteMessage(this.QingXiaoActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MatchThreeActivityInfo)
			{
				output.WriteRawTag(194, 7);
				output.WriteMessage(this.MatchThreeActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GiantActivityInfo)
			{
				output.WriteRawTag(202, 7);
				output.WriteMessage(this.GiantActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00046154 File Offset: 0x00044354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.BeginShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginShowTime);
			}
			if (this.EndShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndShowTime);
			}
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndOpenTime);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			num += this.completePreQuests_.CalculateSize(ActivityData._repeated_completePreQuests_codec);
			if (this.IsFirstOpen)
			{
				num += 2;
			}
			num += this.finishConditions_.CalculateSize(ActivityData._repeated_finishConditions_codec);
			if (this.ActivityOpenType != ActivityOpenType.TimeLimited)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.ActivityOpenType);
			}
			if (this.CanPreOpen)
			{
				num += 3;
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this.LimitRewardBeginTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitRewardBeginTime);
			}
			if (this.LimitRewardEndTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitRewardEndTime);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ParkourActivity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParkourActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SignActivity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SignActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewBieCourseActivity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewBieCourseActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DoubleInstActivityReward)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DoubleInstActivityReward);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HarvestActivity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HarvestActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTrialInfoActivity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleTrialInfoActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomCollectActivity)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhantomCollectActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GatherActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GatherActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DailyAdventureActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DailyAdventureActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoguelikeActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoguelikeActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LongShanActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LongShanActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TurntableActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TurntableActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossRushActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BossRushActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrackMoonActivityTaskData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TrackMoonActivityTaskData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TimePointRewardActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TimePointRewardActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TowerDefenceActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TowerDefenceActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CircumFluenceTaskData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CircumFluenceTaskData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TraceMoonPhaseData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TraceMoonPhaseData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CorniceMeetingData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CorniceMeetingData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RiskHarvestActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RiskHarvestActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BlackCoastThemeActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BlackCoastThemeActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWhiteCatData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueWhiteCatData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ScratchCardActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ScratchCardActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PreheatSignActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PreheatSignActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MowTowerActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MowTowerActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FarmGoldInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FarmGoldInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringSignInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SpringSignInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MapTravelActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MapTravelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleSkinTrialInfoActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FishingActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FishingActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueWeeklyData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TeamParkourLevelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BabelActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BabelActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RacingBetsData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RacingBetsData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ExploreActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExploreActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RogueResActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AvignonActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AvignonActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AbyssInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AbyssInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5CircumFluenceData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.H5CircumFluenceData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoMonopolyActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DangoMonopolyActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.CiacconaActivityPbData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CiacconaActivityPbData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ActivityLinkageData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivityLinkageData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RegressData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RegressData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ConsumptiveActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ConsumptiveActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCarnivalData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewbieCarnivalData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoraleActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MoraleActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FloroRanchActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FloroRanchActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LifePointChallenge)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LifePointChallenge);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TrapDefenseActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FunPlayActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FunPlayActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.JinzhouFlyData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.JinzhouFlyData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LineCrossActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LineCrossActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MoonPhaseActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MoonPhaseActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.HonamiStoryActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhotoFightActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhotoFightActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SurvivorsActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SurvivorsActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuKujiActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.WuWuKujiActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.AdvertisingPageInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AdvertisingPageInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ArtemisActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ArtemisActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleCoopActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleCoopActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorCycleIpActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorCycleIpActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleRecordActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.InfrThemeActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InfrThemeActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoadBookActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoadBookActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleGuideActivity)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleGuideActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewTowerClimbingActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewTowerClimbingActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewPlayerSupportActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorParkourActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorParkourActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SpringFestivalActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SpringFestivalActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TotalTopUpActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TotalTopUpActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorFightActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorFightActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.H5ViewActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.H5ViewActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.SkinRewardActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SkinRewardActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EncircleActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EncircleActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDevelopActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorDevelopActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FlagChallengeActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.FeiXuePreheatActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FeiXuePreheatActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RhythmActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RhythmActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DropCatchActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DropCatchActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.TetrisActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TetrisActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.PinballActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PinballActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.BossPilingActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BossPilingActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThemeCelebration)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ThemeCelebration);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.WuWuWeekActivity)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.WuWuWeekActivity);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MotorDecalActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorDecalActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.LinkageCheckInActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LinkageCheckInActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleGiftActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleGiftActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.KurotatoActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KurotatoActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GolemCrackActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GolemCrackActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.EdgeRunnerActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EdgeRunnerActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.OnlineMotorActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OnlineMotorActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RealmBetweenActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RealmBetweenActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainSummaryActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ThroughTrainSummaryActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieMainActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewbieMainActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCourseV2ActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewbieCourseV2ActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewbieAdventureV2Pb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewbieAdventureV2Pb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NewPlayerSupportActivityV2Pb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ThroughTrainActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoverRogueActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoverRogueActivityData);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.DangoBrawlActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DangoBrawlActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.QingXiaoActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.QingXiaoActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.MatchThreeActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MatchThreeActivityInfo);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.GiantActivityInfo)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GiantActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00046D5C File Offset: 0x00044F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != ActivityType.Parkour)
			{
				this.Type = other.Type;
			}
			if (other.BeginShowTime != 0L)
			{
				this.BeginShowTime = other.BeginShowTime;
			}
			if (other.EndShowTime != 0L)
			{
				this.EndShowTime = other.EndShowTime;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			if (other.EndOpenTime != 0L)
			{
				this.EndOpenTime = other.EndOpenTime;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this.completePreQuests_.Add(other.completePreQuests_);
			if (other.IsFirstOpen)
			{
				this.IsFirstOpen = other.IsFirstOpen;
			}
			this.finishConditions_.Add(other.finishConditions_);
			if (other.ActivityOpenType != ActivityOpenType.TimeLimited)
			{
				this.ActivityOpenType = other.ActivityOpenType;
			}
			if (other.CanPreOpen)
			{
				this.CanPreOpen = other.CanPreOpen;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			if (other.LimitRewardBeginTime != 0L)
			{
				this.LimitRewardBeginTime = other.LimitRewardBeginTime;
			}
			if (other.LimitRewardEndTime != 0L)
			{
				this.LimitRewardEndTime = other.LimitRewardEndTime;
			}
			switch (other.DataCase)
			{
			case ActivityData.DataOneofCase.ParkourActivity:
				if (this.ParkourActivity == null)
				{
					this.ParkourActivity = new ParkourActivity();
				}
				this.ParkourActivity.MergeFrom(other.ParkourActivity);
				break;
			case ActivityData.DataOneofCase.SignActivity:
				if (this.SignActivity == null)
				{
					this.SignActivity = new SignActivity();
				}
				this.SignActivity.MergeFrom(other.SignActivity);
				break;
			case ActivityData.DataOneofCase.NewBieCourseActivity:
				if (this.NewBieCourseActivity == null)
				{
					this.NewBieCourseActivity = new NewBieCourseActivity();
				}
				this.NewBieCourseActivity.MergeFrom(other.NewBieCourseActivity);
				break;
			case ActivityData.DataOneofCase.DoubleInstActivityReward:
				if (this.DoubleInstActivityReward == null)
				{
					this.DoubleInstActivityReward = new DoubleInstActivityReward();
				}
				this.DoubleInstActivityReward.MergeFrom(other.DoubleInstActivityReward);
				break;
			case ActivityData.DataOneofCase.HarvestActivity:
				if (this.HarvestActivity == null)
				{
					this.HarvestActivity = new HarvestActivity();
				}
				this.HarvestActivity.MergeFrom(other.HarvestActivity);
				break;
			case ActivityData.DataOneofCase.RoleTrialInfoActivity:
				if (this.RoleTrialInfoActivity == null)
				{
					this.RoleTrialInfoActivity = new RoleTrialInfoActivity();
				}
				this.RoleTrialInfoActivity.MergeFrom(other.RoleTrialInfoActivity);
				break;
			case ActivityData.DataOneofCase.PhantomCollectActivity:
				if (this.PhantomCollectActivity == null)
				{
					this.PhantomCollectActivity = new PhantomCollectActivity();
				}
				this.PhantomCollectActivity.MergeFrom(other.PhantomCollectActivity);
				break;
			case ActivityData.DataOneofCase.GatherActivityInfo:
				if (this.GatherActivityInfo == null)
				{
					this.GatherActivityInfo = new GatherActivityInfo();
				}
				this.GatherActivityInfo.MergeFrom(other.GatherActivityInfo);
				break;
			case ActivityData.DataOneofCase.DailyAdventureActivityData:
				if (this.DailyAdventureActivityData == null)
				{
					this.DailyAdventureActivityData = new DailyAdventureActivityData();
				}
				this.DailyAdventureActivityData.MergeFrom(other.DailyAdventureActivityData);
				break;
			case ActivityData.DataOneofCase.RoguelikeActivityData:
				if (this.RoguelikeActivityData == null)
				{
					this.RoguelikeActivityData = new RoguelikeActivityData();
				}
				this.RoguelikeActivityData.MergeFrom(other.RoguelikeActivityData);
				break;
			case ActivityData.DataOneofCase.LongShanActivityData:
				if (this.LongShanActivityData == null)
				{
					this.LongShanActivityData = new LongShanActivity();
				}
				this.LongShanActivityData.MergeFrom(other.LongShanActivityData);
				break;
			case ActivityData.DataOneofCase.TurntableActivityData:
				if (this.TurntableActivityData == null)
				{
					this.TurntableActivityData = new TurntableActivityData();
				}
				this.TurntableActivityData.MergeFrom(other.TurntableActivityData);
				break;
			case ActivityData.DataOneofCase.BossRushActivityData:
				if (this.BossRushActivityData == null)
				{
					this.BossRushActivityData = new BossRushActivityData();
				}
				this.BossRushActivityData.MergeFrom(other.BossRushActivityData);
				break;
			case ActivityData.DataOneofCase.TrackMoonActivityTaskData:
				if (this.TrackMoonActivityTaskData == null)
				{
					this.TrackMoonActivityTaskData = new ActivityTaskData();
				}
				this.TrackMoonActivityTaskData.MergeFrom(other.TrackMoonActivityTaskData);
				break;
			case ActivityData.DataOneofCase.TimePointRewardActivityData:
				if (this.TimePointRewardActivityData == null)
				{
					this.TimePointRewardActivityData = new TimePointRewardActivityData();
				}
				this.TimePointRewardActivityData.MergeFrom(other.TimePointRewardActivityData);
				break;
			case ActivityData.DataOneofCase.TowerDefenceActivityData:
				if (this.TowerDefenceActivityData == null)
				{
					this.TowerDefenceActivityData = new TowerDefenceActivityInfo();
				}
				this.TowerDefenceActivityData.MergeFrom(other.TowerDefenceActivityData);
				break;
			case ActivityData.DataOneofCase.CircumFluenceTaskData:
				if (this.CircumFluenceTaskData == null)
				{
					this.CircumFluenceTaskData = new CircumFluenceData();
				}
				this.CircumFluenceTaskData.MergeFrom(other.CircumFluenceTaskData);
				break;
			case ActivityData.DataOneofCase.TraceMoonPhaseData:
				if (this.TraceMoonPhaseData == null)
				{
					this.TraceMoonPhaseData = new TraceMoonPhaseData();
				}
				this.TraceMoonPhaseData.MergeFrom(other.TraceMoonPhaseData);
				break;
			case ActivityData.DataOneofCase.CorniceMeetingData:
				if (this.CorniceMeetingData == null)
				{
					this.CorniceMeetingData = new CorniceMeetingData();
				}
				this.CorniceMeetingData.MergeFrom(other.CorniceMeetingData);
				break;
			case ActivityData.DataOneofCase.RiskHarvestActivityInfo:
				if (this.RiskHarvestActivityInfo == null)
				{
					this.RiskHarvestActivityInfo = new RiskHarvestActivityInfo();
				}
				this.RiskHarvestActivityInfo.MergeFrom(other.RiskHarvestActivityInfo);
				break;
			case ActivityData.DataOneofCase.BlackCoastThemeActivityData:
				if (this.BlackCoastThemeActivityData == null)
				{
					this.BlackCoastThemeActivityData = new BlackCoastThemeActivity();
				}
				this.BlackCoastThemeActivityData.MergeFrom(other.BlackCoastThemeActivityData);
				break;
			case ActivityData.DataOneofCase.RogueWhiteCatData:
				if (this.RogueWhiteCatData == null)
				{
					this.RogueWhiteCatData = new RogueWhiteCatData();
				}
				this.RogueWhiteCatData.MergeFrom(other.RogueWhiteCatData);
				break;
			case ActivityData.DataOneofCase.ScratchCardActivityInfo:
				if (this.ScratchCardActivityInfo == null)
				{
					this.ScratchCardActivityInfo = new ScratchCardActivityInfo();
				}
				this.ScratchCardActivityInfo.MergeFrom(other.ScratchCardActivityInfo);
				break;
			case ActivityData.DataOneofCase.PreheatSignActivityInfo:
				if (this.PreheatSignActivityInfo == null)
				{
					this.PreheatSignActivityInfo = new PreheatSignActivityInfo();
				}
				this.PreheatSignActivityInfo.MergeFrom(other.PreheatSignActivityInfo);
				break;
			case ActivityData.DataOneofCase.MowTowerActivityInfo:
				if (this.MowTowerActivityInfo == null)
				{
					this.MowTowerActivityInfo = new MowTowerActivityInfo();
				}
				this.MowTowerActivityInfo.MergeFrom(other.MowTowerActivityInfo);
				break;
			case ActivityData.DataOneofCase.FarmGoldInfo:
				if (this.FarmGoldInfo == null)
				{
					this.FarmGoldInfo = new FarmGoldInfo();
				}
				this.FarmGoldInfo.MergeFrom(other.FarmGoldInfo);
				break;
			case ActivityData.DataOneofCase.SpringSignInfo:
				if (this.SpringSignInfo == null)
				{
					this.SpringSignInfo = new SpringSignInfo();
				}
				this.SpringSignInfo.MergeFrom(other.SpringSignInfo);
				break;
			case ActivityData.DataOneofCase.MapTravelActivityInfo:
				if (this.MapTravelActivityInfo == null)
				{
					this.MapTravelActivityInfo = new MapTravelActivityInfo();
				}
				this.MapTravelActivityInfo.MergeFrom(other.MapTravelActivityInfo);
				break;
			case ActivityData.DataOneofCase.RoleSkinTrialInfoActivity:
				if (this.RoleSkinTrialInfoActivity == null)
				{
					this.RoleSkinTrialInfoActivity = new RoleSkinTrialInfoActivity();
				}
				this.RoleSkinTrialInfoActivity.MergeFrom(other.RoleSkinTrialInfoActivity);
				break;
			case ActivityData.DataOneofCase.FishingActivityInfo:
				if (this.FishingActivityInfo == null)
				{
					this.FishingActivityInfo = new FishingActivityInfo();
				}
				this.FishingActivityInfo.MergeFrom(other.FishingActivityInfo);
				break;
			case ActivityData.DataOneofCase.RogueWeeklyData:
				if (this.RogueWeeklyData == null)
				{
					this.RogueWeeklyData = new RogueWeeklyData();
				}
				this.RogueWeeklyData.MergeFrom(other.RogueWeeklyData);
				break;
			case ActivityData.DataOneofCase.TeamParkourLevelActivityInfo:
				if (this.TeamParkourLevelActivityInfo == null)
				{
					this.TeamParkourLevelActivityInfo = new TeamParkourLevelActivityInfo();
				}
				this.TeamParkourLevelActivityInfo.MergeFrom(other.TeamParkourLevelActivityInfo);
				break;
			case ActivityData.DataOneofCase.BabelActivityInfo:
				if (this.BabelActivityInfo == null)
				{
					this.BabelActivityInfo = new BabelActivityInfo();
				}
				this.BabelActivityInfo.MergeFrom(other.BabelActivityInfo);
				break;
			case ActivityData.DataOneofCase.RacingBetsData:
				if (this.RacingBetsData == null)
				{
					this.RacingBetsData = new RacingBetsActivityData();
				}
				this.RacingBetsData.MergeFrom(other.RacingBetsData);
				break;
			case ActivityData.DataOneofCase.ExploreActivityInfo:
				if (this.ExploreActivityInfo == null)
				{
					this.ExploreActivityInfo = new ExploreActivityInfo();
				}
				this.ExploreActivityInfo.MergeFrom(other.ExploreActivityInfo);
				break;
			case ActivityData.DataOneofCase.RogueResActivityData:
				if (this.RogueResActivityData == null)
				{
					this.RogueResActivityData = new RogueResActivityData();
				}
				this.RogueResActivityData.MergeFrom(other.RogueResActivityData);
				break;
			case ActivityData.DataOneofCase.AvignonActivityInfo:
				if (this.AvignonActivityInfo == null)
				{
					this.AvignonActivityInfo = new AvignonActivityInfo();
				}
				this.AvignonActivityInfo.MergeFrom(other.AvignonActivityInfo);
				break;
			case ActivityData.DataOneofCase.AbyssInfo:
				if (this.AbyssInfo == null)
				{
					this.AbyssInfo = new AbyssInfo();
				}
				this.AbyssInfo.MergeFrom(other.AbyssInfo);
				break;
			case ActivityData.DataOneofCase.H5CircumFluenceData:
				if (this.H5CircumFluenceData == null)
				{
					this.H5CircumFluenceData = new H5CircumFluenceActivityData();
				}
				this.H5CircumFluenceData.MergeFrom(other.H5CircumFluenceData);
				break;
			case ActivityData.DataOneofCase.DangoMonopolyActivityData:
				if (this.DangoMonopolyActivityData == null)
				{
					this.DangoMonopolyActivityData = new DangoMonopolyActivityPbData();
				}
				this.DangoMonopolyActivityData.MergeFrom(other.DangoMonopolyActivityData);
				break;
			case ActivityData.DataOneofCase.CiacconaActivityPbData:
				if (this.CiacconaActivityPbData == null)
				{
					this.CiacconaActivityPbData = new CiacconaActivityPbData();
				}
				this.CiacconaActivityPbData.MergeFrom(other.CiacconaActivityPbData);
				break;
			case ActivityData.DataOneofCase.ActivityLinkageData:
				if (this.ActivityLinkageData == null)
				{
					this.ActivityLinkageData = new ActivityLinkageData();
				}
				this.ActivityLinkageData.MergeFrom(other.ActivityLinkageData);
				break;
			case ActivityData.DataOneofCase.RegressData:
				if (this.RegressData == null)
				{
					this.RegressData = new RegressData();
				}
				this.RegressData.MergeFrom(other.RegressData);
				break;
			case ActivityData.DataOneofCase.ConsumptiveActivityInfo:
				if (this.ConsumptiveActivityInfo == null)
				{
					this.ConsumptiveActivityInfo = new ConsumptiveActivityInfo();
				}
				this.ConsumptiveActivityInfo.MergeFrom(other.ConsumptiveActivityInfo);
				break;
			case ActivityData.DataOneofCase.PhantomBattleActivityInfo:
				if (this.PhantomBattleActivityInfo == null)
				{
					this.PhantomBattleActivityInfo = new PhantomBattleActivityInfo();
				}
				this.PhantomBattleActivityInfo.MergeFrom(other.PhantomBattleActivityInfo);
				break;
			case ActivityData.DataOneofCase.NewbieCarnivalData:
				if (this.NewbieCarnivalData == null)
				{
					this.NewbieCarnivalData = new NewbieCarnivalData();
				}
				this.NewbieCarnivalData.MergeFrom(other.NewbieCarnivalData);
				break;
			case ActivityData.DataOneofCase.MoraleActivityData:
				if (this.MoraleActivityData == null)
				{
					this.MoraleActivityData = new MoraleActivityData();
				}
				this.MoraleActivityData.MergeFrom(other.MoraleActivityData);
				break;
			case ActivityData.DataOneofCase.FloroRanchActivityData:
				if (this.FloroRanchActivityData == null)
				{
					this.FloroRanchActivityData = new FloroRanchActivityData();
				}
				this.FloroRanchActivityData.MergeFrom(other.FloroRanchActivityData);
				break;
			case ActivityData.DataOneofCase.LifePointChallenge:
				if (this.LifePointChallenge == null)
				{
					this.LifePointChallenge = new LifePointChallengeActivityData();
				}
				this.LifePointChallenge.MergeFrom(other.LifePointChallenge);
				break;
			case ActivityData.DataOneofCase.TrapDefenseActivityInfo:
				if (this.TrapDefenseActivityInfo == null)
				{
					this.TrapDefenseActivityInfo = new TrapDefenseActivityInfo();
				}
				this.TrapDefenseActivityInfo.MergeFrom(other.TrapDefenseActivityInfo);
				break;
			case ActivityData.DataOneofCase.FunPlayActivityInfo:
				if (this.FunPlayActivityInfo == null)
				{
					this.FunPlayActivityInfo = new FunPlayActivityInfo();
				}
				this.FunPlayActivityInfo.MergeFrom(other.FunPlayActivityInfo);
				break;
			case ActivityData.DataOneofCase.JinzhouFlyData:
				if (this.JinzhouFlyData == null)
				{
					this.JinzhouFlyData = new JinzhouFlyData();
				}
				this.JinzhouFlyData.MergeFrom(other.JinzhouFlyData);
				break;
			case ActivityData.DataOneofCase.LineCrossActivityData:
				if (this.LineCrossActivityData == null)
				{
					this.LineCrossActivityData = new LineCrossActivityData();
				}
				this.LineCrossActivityData.MergeFrom(other.LineCrossActivityData);
				break;
			case ActivityData.DataOneofCase.MoonPhaseActivityData:
				if (this.MoonPhaseActivityData == null)
				{
					this.MoonPhaseActivityData = new MoonPhaseActivityData();
				}
				this.MoonPhaseActivityData.MergeFrom(other.MoonPhaseActivityData);
				break;
			case ActivityData.DataOneofCase.HonamiStoryActivityInfo:
				if (this.HonamiStoryActivityInfo == null)
				{
					this.HonamiStoryActivityInfo = new HonamiStoryActivityInfo();
				}
				this.HonamiStoryActivityInfo.MergeFrom(other.HonamiStoryActivityInfo);
				break;
			case ActivityData.DataOneofCase.PhotoFightActivityData:
				if (this.PhotoFightActivityData == null)
				{
					this.PhotoFightActivityData = new PhotoFightActivityPb();
				}
				this.PhotoFightActivityData.MergeFrom(other.PhotoFightActivityData);
				break;
			case ActivityData.DataOneofCase.SurvivorsActivityData:
				if (this.SurvivorsActivityData == null)
				{
					this.SurvivorsActivityData = new SurvivorsActivityData();
				}
				this.SurvivorsActivityData.MergeFrom(other.SurvivorsActivityData);
				break;
			case ActivityData.DataOneofCase.WuWuKujiActivityInfo:
				if (this.WuWuKujiActivityInfo == null)
				{
					this.WuWuKujiActivityInfo = new WuWuKujiActivityPb();
				}
				this.WuWuKujiActivityInfo.MergeFrom(other.WuWuKujiActivityInfo);
				break;
			case ActivityData.DataOneofCase.AdvertisingPageInfo:
				if (this.AdvertisingPageInfo == null)
				{
					this.AdvertisingPageInfo = new AdvertisingPageData();
				}
				this.AdvertisingPageInfo.MergeFrom(other.AdvertisingPageInfo);
				break;
			case ActivityData.DataOneofCase.ArtemisActivityInfo:
				if (this.ArtemisActivityInfo == null)
				{
					this.ArtemisActivityInfo = new ArtemisActivityInfo();
				}
				this.ArtemisActivityInfo.MergeFrom(other.ArtemisActivityInfo);
				break;
			case ActivityData.DataOneofCase.RoleCoopActivityData:
				if (this.RoleCoopActivityData == null)
				{
					this.RoleCoopActivityData = new RoleCoopActivityData();
				}
				this.RoleCoopActivityData.MergeFrom(other.RoleCoopActivityData);
				break;
			case ActivityData.DataOneofCase.MotorCycleIpActivityData:
				if (this.MotorCycleIpActivityData == null)
				{
					this.MotorCycleIpActivityData = new MotorCycleIpActivityData();
				}
				this.MotorCycleIpActivityData.MergeFrom(other.MotorCycleIpActivityData);
				break;
			case ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo:
				if (this.PhantomBattleRecordActivityInfo == null)
				{
					this.PhantomBattleRecordActivityInfo = new PhantomBattleActivityInfo();
				}
				this.PhantomBattleRecordActivityInfo.MergeFrom(other.PhantomBattleRecordActivityInfo);
				break;
			case ActivityData.DataOneofCase.InfrThemeActivityPb:
				if (this.InfrThemeActivityPb == null)
				{
					this.InfrThemeActivityPb = new InfrThemeActivityPb();
				}
				this.InfrThemeActivityPb.MergeFrom(other.InfrThemeActivityPb);
				break;
			case ActivityData.DataOneofCase.RoadBookActivityInfo:
				if (this.RoadBookActivityInfo == null)
				{
					this.RoadBookActivityInfo = new RoadBookActivityInfo();
				}
				this.RoadBookActivityInfo.MergeFrom(other.RoadBookActivityInfo);
				break;
			case ActivityData.DataOneofCase.PhantomBattleGuideActivity:
				if (this.PhantomBattleGuideActivity == null)
				{
					this.PhantomBattleGuideActivity = new PhantomBattleGuideActivity();
				}
				this.PhantomBattleGuideActivity.MergeFrom(other.PhantomBattleGuideActivity);
				break;
			case ActivityData.DataOneofCase.NewTowerClimbingActivityData:
				if (this.NewTowerClimbingActivityData == null)
				{
					this.NewTowerClimbingActivityData = new NewTowerClimbingActivityData();
				}
				this.NewTowerClimbingActivityData.MergeFrom(other.NewTowerClimbingActivityData);
				break;
			case ActivityData.DataOneofCase.NewPlayerSupportActivityData:
				if (this.NewPlayerSupportActivityData == null)
				{
					this.NewPlayerSupportActivityData = new NewPlayerSupportActivityData();
				}
				this.NewPlayerSupportActivityData.MergeFrom(other.NewPlayerSupportActivityData);
				break;
			case ActivityData.DataOneofCase.MotorParkourActivityInfo:
				if (this.MotorParkourActivityInfo == null)
				{
					this.MotorParkourActivityInfo = new MotorParkourActivityInfo();
				}
				this.MotorParkourActivityInfo.MergeFrom(other.MotorParkourActivityInfo);
				break;
			case ActivityData.DataOneofCase.SpringFestivalActivityInfo:
				if (this.SpringFestivalActivityInfo == null)
				{
					this.SpringFestivalActivityInfo = new SpringFestivalActivityInfo();
				}
				this.SpringFestivalActivityInfo.MergeFrom(other.SpringFestivalActivityInfo);
				break;
			case ActivityData.DataOneofCase.TotalTopUpActivityInfo:
				if (this.TotalTopUpActivityInfo == null)
				{
					this.TotalTopUpActivityInfo = new TotalTopUpActivityInfo();
				}
				this.TotalTopUpActivityInfo.MergeFrom(other.TotalTopUpActivityInfo);
				break;
			case ActivityData.DataOneofCase.MotorFightActivityPb:
				if (this.MotorFightActivityPb == null)
				{
					this.MotorFightActivityPb = new MotorFightActivityPb();
				}
				this.MotorFightActivityPb.MergeFrom(other.MotorFightActivityPb);
				break;
			case ActivityData.DataOneofCase.H5ViewActivityData:
				if (this.H5ViewActivityData == null)
				{
					this.H5ViewActivityData = new H5ViewActivityData();
				}
				this.H5ViewActivityData.MergeFrom(other.H5ViewActivityData);
				break;
			case ActivityData.DataOneofCase.SkinRewardActivityData:
				if (this.SkinRewardActivityData == null)
				{
					this.SkinRewardActivityData = new SkinRewardActivityData();
				}
				this.SkinRewardActivityData.MergeFrom(other.SkinRewardActivityData);
				break;
			case ActivityData.DataOneofCase.EncircleActivityPb:
				if (this.EncircleActivityPb == null)
				{
					this.EncircleActivityPb = new EncircleActivityPb();
				}
				this.EncircleActivityPb.MergeFrom(other.EncircleActivityPb);
				break;
			case ActivityData.DataOneofCase.MotorDevelopActivityData:
				if (this.MotorDevelopActivityData == null)
				{
					this.MotorDevelopActivityData = new MotorDevelopActivityData();
				}
				this.MotorDevelopActivityData.MergeFrom(other.MotorDevelopActivityData);
				break;
			case ActivityData.DataOneofCase.FlagChallengeActivityInfo:
				if (this.FlagChallengeActivityInfo == null)
				{
					this.FlagChallengeActivityInfo = new FlagChallengeActivityInfo();
				}
				this.FlagChallengeActivityInfo.MergeFrom(other.FlagChallengeActivityInfo);
				break;
			case ActivityData.DataOneofCase.FeiXuePreheatActivityInfo:
				if (this.FeiXuePreheatActivityInfo == null)
				{
					this.FeiXuePreheatActivityInfo = new FeiXuePreheatActivityInfo();
				}
				this.FeiXuePreheatActivityInfo.MergeFrom(other.FeiXuePreheatActivityInfo);
				break;
			case ActivityData.DataOneofCase.RhythmActivityPb:
				if (this.RhythmActivityPb == null)
				{
					this.RhythmActivityPb = new RhythmActivityPb();
				}
				this.RhythmActivityPb.MergeFrom(other.RhythmActivityPb);
				break;
			case ActivityData.DataOneofCase.DropCatchActivityInfo:
				if (this.DropCatchActivityInfo == null)
				{
					this.DropCatchActivityInfo = new DropCatchActivityInfo();
				}
				this.DropCatchActivityInfo.MergeFrom(other.DropCatchActivityInfo);
				break;
			case ActivityData.DataOneofCase.TetrisActivityInfo:
				if (this.TetrisActivityInfo == null)
				{
					this.TetrisActivityInfo = new TetrisActivityInfo();
				}
				this.TetrisActivityInfo.MergeFrom(other.TetrisActivityInfo);
				break;
			case ActivityData.DataOneofCase.PinballActivityData:
				if (this.PinballActivityData == null)
				{
					this.PinballActivityData = new PinballActivityData();
				}
				this.PinballActivityData.MergeFrom(other.PinballActivityData);
				break;
			case ActivityData.DataOneofCase.BossPilingActivityInfo:
				if (this.BossPilingActivityInfo == null)
				{
					this.BossPilingActivityInfo = new BossPilingActivityInfo();
				}
				this.BossPilingActivityInfo.MergeFrom(other.BossPilingActivityInfo);
				break;
			case ActivityData.DataOneofCase.ThemeCelebration:
				if (this.ThemeCelebration == null)
				{
					this.ThemeCelebration = new ThemeCelebration();
				}
				this.ThemeCelebration.MergeFrom(other.ThemeCelebration);
				break;
			case ActivityData.DataOneofCase.WuWuWeekActivity:
				if (this.WuWuWeekActivity == null)
				{
					this.WuWuWeekActivity = new WuWuWeekActivity();
				}
				this.WuWuWeekActivity.MergeFrom(other.WuWuWeekActivity);
				break;
			case ActivityData.DataOneofCase.MotorDecalActivityData:
				if (this.MotorDecalActivityData == null)
				{
					this.MotorDecalActivityData = new MotorDecalActivityData();
				}
				this.MotorDecalActivityData.MergeFrom(other.MotorDecalActivityData);
				break;
			case ActivityData.DataOneofCase.LinkageCheckInActivityData:
				if (this.LinkageCheckInActivityData == null)
				{
					this.LinkageCheckInActivityData = new LinkageCheckInActivityData();
				}
				this.LinkageCheckInActivityData.MergeFrom(other.LinkageCheckInActivityData);
				break;
			case ActivityData.DataOneofCase.RoleGiftActivityData:
				if (this.RoleGiftActivityData == null)
				{
					this.RoleGiftActivityData = new RoleGiftActivityData();
				}
				this.RoleGiftActivityData.MergeFrom(other.RoleGiftActivityData);
				break;
			case ActivityData.DataOneofCase.KurotatoActivityData:
				if (this.KurotatoActivityData == null)
				{
					this.KurotatoActivityData = new KurotatoActivityData();
				}
				this.KurotatoActivityData.MergeFrom(other.KurotatoActivityData);
				break;
			case ActivityData.DataOneofCase.GolemCrackActivityInfo:
				if (this.GolemCrackActivityInfo == null)
				{
					this.GolemCrackActivityInfo = new GolemCrackActivityInfo();
				}
				this.GolemCrackActivityInfo.MergeFrom(other.GolemCrackActivityInfo);
				break;
			case ActivityData.DataOneofCase.EdgeRunnerActivityInfo:
				if (this.EdgeRunnerActivityInfo == null)
				{
					this.EdgeRunnerActivityInfo = new EdgeRunnerActivityInfo();
				}
				this.EdgeRunnerActivityInfo.MergeFrom(other.EdgeRunnerActivityInfo);
				break;
			case ActivityData.DataOneofCase.OnlineMotorActivityData:
				if (this.OnlineMotorActivityData == null)
				{
					this.OnlineMotorActivityData = new OnlineMotorActivityData();
				}
				this.OnlineMotorActivityData.MergeFrom(other.OnlineMotorActivityData);
				break;
			case ActivityData.DataOneofCase.RealmBetweenActivityInfo:
				if (this.RealmBetweenActivityInfo == null)
				{
					this.RealmBetweenActivityInfo = new RealmBetweenActivityInfo();
				}
				this.RealmBetweenActivityInfo.MergeFrom(other.RealmBetweenActivityInfo);
				break;
			case ActivityData.DataOneofCase.ThroughTrainSummaryActivityData:
				if (this.ThroughTrainSummaryActivityData == null)
				{
					this.ThroughTrainSummaryActivityData = new ThroughTrainSummaryActivityData();
				}
				this.ThroughTrainSummaryActivityData.MergeFrom(other.ThroughTrainSummaryActivityData);
				break;
			case ActivityData.DataOneofCase.NewbieMainActivityPb:
				if (this.NewbieMainActivityPb == null)
				{
					this.NewbieMainActivityPb = new NewbieMainActivityPb();
				}
				this.NewbieMainActivityPb.MergeFrom(other.NewbieMainActivityPb);
				break;
			case ActivityData.DataOneofCase.NewbieCourseV2ActivityPb:
				if (this.NewbieCourseV2ActivityPb == null)
				{
					this.NewbieCourseV2ActivityPb = new NewbieCourseV2ActivityPb();
				}
				this.NewbieCourseV2ActivityPb.MergeFrom(other.NewbieCourseV2ActivityPb);
				break;
			case ActivityData.DataOneofCase.NewbieAdventureV2Pb:
				if (this.NewbieAdventureV2Pb == null)
				{
					this.NewbieAdventureV2Pb = new NewbieAdventureV2Pb();
				}
				this.NewbieAdventureV2Pb.MergeFrom(other.NewbieAdventureV2Pb);
				break;
			case ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb:
				if (this.NewPlayerSupportActivityV2Pb == null)
				{
					this.NewPlayerSupportActivityV2Pb = new NewPlayerSupportActivityV2Pb();
				}
				this.NewPlayerSupportActivityV2Pb.MergeFrom(other.NewPlayerSupportActivityV2Pb);
				break;
			case ActivityData.DataOneofCase.ThroughTrainActivityData:
				if (this.ThroughTrainActivityData == null)
				{
					this.ThroughTrainActivityData = new ThroughTrainActivityData();
				}
				this.ThroughTrainActivityData.MergeFrom(other.ThroughTrainActivityData);
				break;
			case ActivityData.DataOneofCase.RoverRogueActivityData:
				if (this.RoverRogueActivityData == null)
				{
					this.RoverRogueActivityData = new RoverRogueActivityData();
				}
				this.RoverRogueActivityData.MergeFrom(other.RoverRogueActivityData);
				break;
			case ActivityData.DataOneofCase.DangoBrawlActivityInfo:
				if (this.DangoBrawlActivityInfo == null)
				{
					this.DangoBrawlActivityInfo = new DangoBrawlActivityInfo();
				}
				this.DangoBrawlActivityInfo.MergeFrom(other.DangoBrawlActivityInfo);
				break;
			case ActivityData.DataOneofCase.QingXiaoActivityInfo:
				if (this.QingXiaoActivityInfo == null)
				{
					this.QingXiaoActivityInfo = new QingXiaoActivityInfo();
				}
				this.QingXiaoActivityInfo.MergeFrom(other.QingXiaoActivityInfo);
				break;
			case ActivityData.DataOneofCase.MatchThreeActivityInfo:
				if (this.MatchThreeActivityInfo == null)
				{
					this.MatchThreeActivityInfo = new MatchThreeActivityInfo();
				}
				this.MatchThreeActivityInfo.MergeFrom(other.MatchThreeActivityInfo);
				break;
			case ActivityData.DataOneofCase.GiantActivityInfo:
				if (this.GiantActivityInfo == null)
				{
					this.GiantActivityInfo = new GiantActivityInfo();
				}
				this.GiantActivityInfo.MergeFrom(other.GiantActivityInfo);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0004812D File Offset: 0x0004632D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00048138 File Offset: 0x00046338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 474U)
				{
					if (num <= 234U)
					{
						if (num <= 114U)
						{
							if (num <= 56U)
							{
								if (num <= 24U)
								{
									if (num == 8U)
									{
										this.Id = input.ReadInt32();
										continue;
									}
									if (num == 16U)
									{
										this.Type = (ActivityType)input.ReadEnum();
										continue;
									}
									if (num == 24U)
									{
										this.BeginShowTime = input.ReadInt64();
										continue;
									}
								}
								else if (num <= 40U)
								{
									if (num == 32U)
									{
										this.EndShowTime = input.ReadInt64();
										continue;
									}
									if (num == 40U)
									{
										this.BeginOpenTime = input.ReadInt64();
										continue;
									}
								}
								else
								{
									if (num == 48U)
									{
										this.EndOpenTime = input.ReadInt64();
										continue;
									}
									if (num == 56U)
									{
										this.IsUnlock = input.ReadBool();
										continue;
									}
								}
							}
							else if (num <= 82U)
							{
								if (num <= 66U)
								{
									if (num == 64U || num == 66U)
									{
										this.completePreQuests_.AddEntriesFrom(ref input, ActivityData._repeated_completePreQuests_codec);
										continue;
									}
								}
								else
								{
									if (num == 72U)
									{
										this.IsFirstOpen = input.ReadBool();
										continue;
									}
									if (num == 82U)
									{
										ParkourActivity parkourActivity = new ParkourActivity();
										if (this.dataCase_ == ActivityData.DataOneofCase.ParkourActivity)
										{
											parkourActivity.MergeFrom(this.ParkourActivity);
										}
										input.ReadMessage(parkourActivity);
										this.ParkourActivity = parkourActivity;
										continue;
									}
								}
							}
							else if (num <= 98U)
							{
								if (num == 90U)
								{
									SignActivity signActivity = new SignActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.SignActivity)
									{
										signActivity.MergeFrom(this.SignActivity);
									}
									input.ReadMessage(signActivity);
									this.SignActivity = signActivity;
									continue;
								}
								if (num == 98U)
								{
									NewBieCourseActivity newBieCourseActivity = new NewBieCourseActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.NewBieCourseActivity)
									{
										newBieCourseActivity.MergeFrom(this.NewBieCourseActivity);
									}
									input.ReadMessage(newBieCourseActivity);
									this.NewBieCourseActivity = newBieCourseActivity;
									continue;
								}
							}
							else
							{
								if (num == 106U)
								{
									DoubleInstActivityReward doubleInstActivityReward = new DoubleInstActivityReward();
									if (this.dataCase_ == ActivityData.DataOneofCase.DoubleInstActivityReward)
									{
										doubleInstActivityReward.MergeFrom(this.DoubleInstActivityReward);
									}
									input.ReadMessage(doubleInstActivityReward);
									this.DoubleInstActivityReward = doubleInstActivityReward;
									continue;
								}
								if (num == 114U)
								{
									HarvestActivity harvestActivity = new HarvestActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.HarvestActivity)
									{
										harvestActivity.MergeFrom(this.HarvestActivity);
									}
									input.ReadMessage(harvestActivity);
									this.HarvestActivity = harvestActivity;
									continue;
								}
							}
						}
						else if (num <= 170U)
						{
							if (num <= 138U)
							{
								if (num == 122U)
								{
									RoleTrialInfoActivity roleTrialInfoActivity = new RoleTrialInfoActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.RoleTrialInfoActivity)
									{
										roleTrialInfoActivity.MergeFrom(this.RoleTrialInfoActivity);
									}
									input.ReadMessage(roleTrialInfoActivity);
									this.RoleTrialInfoActivity = roleTrialInfoActivity;
									continue;
								}
								if (num == 130U)
								{
									PhantomCollectActivity phantomCollectActivity = new PhantomCollectActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.PhantomCollectActivity)
									{
										phantomCollectActivity.MergeFrom(this.PhantomCollectActivity);
									}
									input.ReadMessage(phantomCollectActivity);
									this.PhantomCollectActivity = phantomCollectActivity;
									continue;
								}
								if (num == 138U)
								{
									GatherActivityInfo gatherActivityInfo = new GatherActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.GatherActivityInfo)
									{
										gatherActivityInfo.MergeFrom(this.GatherActivityInfo);
									}
									input.ReadMessage(gatherActivityInfo);
									this.GatherActivityInfo = gatherActivityInfo;
									continue;
								}
							}
							else if (num <= 154U)
							{
								if (num == 146U)
								{
									DailyAdventureActivityData dailyAdventureActivityData = new DailyAdventureActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.DailyAdventureActivityData)
									{
										dailyAdventureActivityData.MergeFrom(this.DailyAdventureActivityData);
									}
									input.ReadMessage(dailyAdventureActivityData);
									this.DailyAdventureActivityData = dailyAdventureActivityData;
									continue;
								}
								if (num == 154U)
								{
									RoguelikeActivityData roguelikeActivityData = new RoguelikeActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.RoguelikeActivityData)
									{
										roguelikeActivityData.MergeFrom(this.RoguelikeActivityData);
									}
									input.ReadMessage(roguelikeActivityData);
									this.RoguelikeActivityData = roguelikeActivityData;
									continue;
								}
							}
							else
							{
								if (num == 162U)
								{
									LongShanActivity longShanActivity = new LongShanActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.LongShanActivityData)
									{
										longShanActivity.MergeFrom(this.LongShanActivityData);
									}
									input.ReadMessage(longShanActivity);
									this.LongShanActivityData = longShanActivity;
									continue;
								}
								if (num == 170U)
								{
									TurntableActivityData turntableActivityData = new TurntableActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.TurntableActivityData)
									{
										turntableActivityData.MergeFrom(this.TurntableActivityData);
									}
									input.ReadMessage(turntableActivityData);
									this.TurntableActivityData = turntableActivityData;
									continue;
								}
							}
						}
						else if (num <= 202U)
						{
							if (num <= 186U)
							{
								if (num == 178U)
								{
									BossRushActivityData bossRushActivityData = new BossRushActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.BossRushActivityData)
									{
										bossRushActivityData.MergeFrom(this.BossRushActivityData);
									}
									input.ReadMessage(bossRushActivityData);
									this.BossRushActivityData = bossRushActivityData;
									continue;
								}
								if (num == 186U)
								{
									ActivityTaskData activityTaskData = new ActivityTaskData();
									if (this.dataCase_ == ActivityData.DataOneofCase.TrackMoonActivityTaskData)
									{
										activityTaskData.MergeFrom(this.TrackMoonActivityTaskData);
									}
									input.ReadMessage(activityTaskData);
									this.TrackMoonActivityTaskData = activityTaskData;
									continue;
								}
							}
							else
							{
								if (num == 194U)
								{
									TimePointRewardActivityData timePointRewardActivityData = new TimePointRewardActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.TimePointRewardActivityData)
									{
										timePointRewardActivityData.MergeFrom(this.TimePointRewardActivityData);
									}
									input.ReadMessage(timePointRewardActivityData);
									this.TimePointRewardActivityData = timePointRewardActivityData;
									continue;
								}
								if (num == 202U)
								{
									TowerDefenceActivityInfo towerDefenceActivityInfo = new TowerDefenceActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.TowerDefenceActivityData)
									{
										towerDefenceActivityInfo.MergeFrom(this.TowerDefenceActivityData);
									}
									input.ReadMessage(towerDefenceActivityInfo);
									this.TowerDefenceActivityData = towerDefenceActivityInfo;
									continue;
								}
							}
						}
						else if (num <= 218U)
						{
							if (num == 210U)
							{
								CircumFluenceData circumFluenceData = new CircumFluenceData();
								if (this.dataCase_ == ActivityData.DataOneofCase.CircumFluenceTaskData)
								{
									circumFluenceData.MergeFrom(this.CircumFluenceTaskData);
								}
								input.ReadMessage(circumFluenceData);
								this.CircumFluenceTaskData = circumFluenceData;
								continue;
							}
							if (num == 218U)
							{
								TraceMoonPhaseData traceMoonPhaseData = new TraceMoonPhaseData();
								if (this.dataCase_ == ActivityData.DataOneofCase.TraceMoonPhaseData)
								{
									traceMoonPhaseData.MergeFrom(this.TraceMoonPhaseData);
								}
								input.ReadMessage(traceMoonPhaseData);
								this.TraceMoonPhaseData = traceMoonPhaseData;
								continue;
							}
						}
						else
						{
							if (num == 226U)
							{
								CorniceMeetingData corniceMeetingData = new CorniceMeetingData();
								if (this.dataCase_ == ActivityData.DataOneofCase.CorniceMeetingData)
								{
									corniceMeetingData.MergeFrom(this.CorniceMeetingData);
								}
								input.ReadMessage(corniceMeetingData);
								this.CorniceMeetingData = corniceMeetingData;
								continue;
							}
							if (num == 234U)
							{
								RiskHarvestActivityInfo riskHarvestActivityInfo = new RiskHarvestActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.RiskHarvestActivityInfo)
								{
									riskHarvestActivityInfo.MergeFrom(this.RiskHarvestActivityInfo);
								}
								input.ReadMessage(riskHarvestActivityInfo);
								this.RiskHarvestActivityInfo = riskHarvestActivityInfo;
								continue;
							}
						}
					}
					else if (num <= 346U)
					{
						if (num <= 282U)
						{
							if (num <= 250U)
							{
								if (num == 240U || num == 242U)
								{
									this.finishConditions_.AddEntriesFrom(ref input, ActivityData._repeated_finishConditions_codec);
									continue;
								}
								if (num == 250U)
								{
									BlackCoastThemeActivity blackCoastThemeActivity = new BlackCoastThemeActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.BlackCoastThemeActivityData)
									{
										blackCoastThemeActivity.MergeFrom(this.BlackCoastThemeActivityData);
									}
									input.ReadMessage(blackCoastThemeActivity);
									this.BlackCoastThemeActivityData = blackCoastThemeActivity;
									continue;
								}
							}
							else if (num <= 264U)
							{
								if (num == 258U)
								{
									RogueWhiteCatData rogueWhiteCatData = new RogueWhiteCatData();
									if (this.dataCase_ == ActivityData.DataOneofCase.RogueWhiteCatData)
									{
										rogueWhiteCatData.MergeFrom(this.RogueWhiteCatData);
									}
									input.ReadMessage(rogueWhiteCatData);
									this.RogueWhiteCatData = rogueWhiteCatData;
									continue;
								}
								if (num == 264U)
								{
									this.ActivityOpenType = (ActivityOpenType)input.ReadEnum();
									continue;
								}
							}
							else
							{
								if (num == 274U)
								{
									ScratchCardActivityInfo scratchCardActivityInfo = new ScratchCardActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.ScratchCardActivityInfo)
									{
										scratchCardActivityInfo.MergeFrom(this.ScratchCardActivityInfo);
									}
									input.ReadMessage(scratchCardActivityInfo);
									this.ScratchCardActivityInfo = scratchCardActivityInfo;
									continue;
								}
								if (num == 282U)
								{
									PreheatSignActivityInfo preheatSignActivityInfo = new PreheatSignActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.PreheatSignActivityInfo)
									{
										preheatSignActivityInfo.MergeFrom(this.PreheatSignActivityInfo);
									}
									input.ReadMessage(preheatSignActivityInfo);
									this.PreheatSignActivityInfo = preheatSignActivityInfo;
									continue;
								}
							}
						}
						else if (num <= 314U)
						{
							if (num <= 298U)
							{
								if (num == 290U)
								{
									MowTowerActivityInfo mowTowerActivityInfo = new MowTowerActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.MowTowerActivityInfo)
									{
										mowTowerActivityInfo.MergeFrom(this.MowTowerActivityInfo);
									}
									input.ReadMessage(mowTowerActivityInfo);
									this.MowTowerActivityInfo = mowTowerActivityInfo;
									continue;
								}
								if (num == 298U)
								{
									FarmGoldInfo farmGoldInfo = new FarmGoldInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.FarmGoldInfo)
									{
										farmGoldInfo.MergeFrom(this.FarmGoldInfo);
									}
									input.ReadMessage(farmGoldInfo);
									this.FarmGoldInfo = farmGoldInfo;
									continue;
								}
							}
							else
							{
								if (num == 306U)
								{
									SpringSignInfo springSignInfo = new SpringSignInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.SpringSignInfo)
									{
										springSignInfo.MergeFrom(this.SpringSignInfo);
									}
									input.ReadMessage(springSignInfo);
									this.SpringSignInfo = springSignInfo;
									continue;
								}
								if (num == 314U)
								{
									MapTravelActivityInfo mapTravelActivityInfo = new MapTravelActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.MapTravelActivityInfo)
									{
										mapTravelActivityInfo.MergeFrom(this.MapTravelActivityInfo);
									}
									input.ReadMessage(mapTravelActivityInfo);
									this.MapTravelActivityInfo = mapTravelActivityInfo;
									continue;
								}
							}
						}
						else if (num <= 330U)
						{
							if (num == 322U)
							{
								RoleSkinTrialInfoActivity roleSkinTrialInfoActivity = new RoleSkinTrialInfoActivity();
								if (this.dataCase_ == ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
								{
									roleSkinTrialInfoActivity.MergeFrom(this.RoleSkinTrialInfoActivity);
								}
								input.ReadMessage(roleSkinTrialInfoActivity);
								this.RoleSkinTrialInfoActivity = roleSkinTrialInfoActivity;
								continue;
							}
							if (num == 330U)
							{
								FishingActivityInfo fishingActivityInfo = new FishingActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.FishingActivityInfo)
								{
									fishingActivityInfo.MergeFrom(this.FishingActivityInfo);
								}
								input.ReadMessage(fishingActivityInfo);
								this.FishingActivityInfo = fishingActivityInfo;
								continue;
							}
						}
						else
						{
							if (num == 336U)
							{
								this.CanPreOpen = input.ReadBool();
								continue;
							}
							if (num == 346U)
							{
								RogueWeeklyData rogueWeeklyData = new RogueWeeklyData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RogueWeeklyData)
								{
									rogueWeeklyData.MergeFrom(this.RogueWeeklyData);
								}
								input.ReadMessage(rogueWeeklyData);
								this.RogueWeeklyData = rogueWeeklyData;
								continue;
							}
						}
					}
					else if (num <= 410U)
					{
						if (num <= 378U)
						{
							if (num <= 362U)
							{
								if (num == 354U)
								{
									TeamParkourLevelActivityInfo teamParkourLevelActivityInfo = new TeamParkourLevelActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
									{
										teamParkourLevelActivityInfo.MergeFrom(this.TeamParkourLevelActivityInfo);
									}
									input.ReadMessage(teamParkourLevelActivityInfo);
									this.TeamParkourLevelActivityInfo = teamParkourLevelActivityInfo;
									continue;
								}
								if (num == 362U)
								{
									BabelActivityInfo babelActivityInfo = new BabelActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.BabelActivityInfo)
									{
										babelActivityInfo.MergeFrom(this.BabelActivityInfo);
									}
									input.ReadMessage(babelActivityInfo);
									this.BabelActivityInfo = babelActivityInfo;
									continue;
								}
							}
							else
							{
								if (num == 370U)
								{
									RacingBetsActivityData racingBetsActivityData = new RacingBetsActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.RacingBetsData)
									{
										racingBetsActivityData.MergeFrom(this.RacingBetsData);
									}
									input.ReadMessage(racingBetsActivityData);
									this.RacingBetsData = racingBetsActivityData;
									continue;
								}
								if (num == 378U)
								{
									ExploreActivityInfo exploreActivityInfo = new ExploreActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.ExploreActivityInfo)
									{
										exploreActivityInfo.MergeFrom(this.ExploreActivityInfo);
									}
									input.ReadMessage(exploreActivityInfo);
									this.ExploreActivityInfo = exploreActivityInfo;
									continue;
								}
							}
						}
						else if (num <= 394U)
						{
							if (num == 386U)
							{
								RogueResActivityData rogueResActivityData = new RogueResActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RogueResActivityData)
								{
									rogueResActivityData.MergeFrom(this.RogueResActivityData);
								}
								input.ReadMessage(rogueResActivityData);
								this.RogueResActivityData = rogueResActivityData;
								continue;
							}
							if (num == 394U)
							{
								AvignonActivityInfo avignonActivityInfo = new AvignonActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.AvignonActivityInfo)
								{
									avignonActivityInfo.MergeFrom(this.AvignonActivityInfo);
								}
								input.ReadMessage(avignonActivityInfo);
								this.AvignonActivityInfo = avignonActivityInfo;
								continue;
							}
						}
						else
						{
							if (num == 402U)
							{
								AbyssInfo abyssInfo = new AbyssInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.AbyssInfo)
								{
									abyssInfo.MergeFrom(this.AbyssInfo);
								}
								input.ReadMessage(abyssInfo);
								this.AbyssInfo = abyssInfo;
								continue;
							}
							if (num == 410U)
							{
								H5CircumFluenceActivityData h5CircumFluenceActivityData = new H5CircumFluenceActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.H5CircumFluenceData)
								{
									h5CircumFluenceActivityData.MergeFrom(this.H5CircumFluenceData);
								}
								input.ReadMessage(h5CircumFluenceActivityData);
								this.H5CircumFluenceData = h5CircumFluenceActivityData;
								continue;
							}
						}
					}
					else if (num <= 442U)
					{
						if (num <= 426U)
						{
							if (num == 418U)
							{
								DangoMonopolyActivityPbData dangoMonopolyActivityPbData = new DangoMonopolyActivityPbData();
								if (this.dataCase_ == ActivityData.DataOneofCase.DangoMonopolyActivityData)
								{
									dangoMonopolyActivityPbData.MergeFrom(this.DangoMonopolyActivityData);
								}
								input.ReadMessage(dangoMonopolyActivityPbData);
								this.DangoMonopolyActivityData = dangoMonopolyActivityPbData;
								continue;
							}
							if (num == 426U)
							{
								CiacconaActivityPbData ciacconaActivityPbData = new CiacconaActivityPbData();
								if (this.dataCase_ == ActivityData.DataOneofCase.CiacconaActivityPbData)
								{
									ciacconaActivityPbData.MergeFrom(this.CiacconaActivityPbData);
								}
								input.ReadMessage(ciacconaActivityPbData);
								this.CiacconaActivityPbData = ciacconaActivityPbData;
								continue;
							}
						}
						else
						{
							if (num == 434U)
							{
								ActivityLinkageData activityLinkageData = new ActivityLinkageData();
								if (this.dataCase_ == ActivityData.DataOneofCase.ActivityLinkageData)
								{
									activityLinkageData.MergeFrom(this.ActivityLinkageData);
								}
								input.ReadMessage(activityLinkageData);
								this.ActivityLinkageData = activityLinkageData;
								continue;
							}
							if (num == 442U)
							{
								RegressData regressData = new RegressData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RegressData)
								{
									regressData.MergeFrom(this.RegressData);
								}
								input.ReadMessage(regressData);
								this.RegressData = regressData;
								continue;
							}
						}
					}
					else if (num <= 458U)
					{
						if (num == 450U)
						{
							ConsumptiveActivityInfo consumptiveActivityInfo = new ConsumptiveActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.ConsumptiveActivityInfo)
							{
								consumptiveActivityInfo.MergeFrom(this.ConsumptiveActivityInfo);
							}
							input.ReadMessage(consumptiveActivityInfo);
							this.ConsumptiveActivityInfo = consumptiveActivityInfo;
							continue;
						}
						if (num == 458U)
						{
							PhantomBattleActivityInfo phantomBattleActivityInfo = new PhantomBattleActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleActivityInfo)
							{
								phantomBattleActivityInfo.MergeFrom(this.PhantomBattleActivityInfo);
							}
							input.ReadMessage(phantomBattleActivityInfo);
							this.PhantomBattleActivityInfo = phantomBattleActivityInfo;
							continue;
						}
					}
					else
					{
						if (num == 466U)
						{
							NewbieCarnivalData newbieCarnivalData = new NewbieCarnivalData();
							if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCarnivalData)
							{
								newbieCarnivalData.MergeFrom(this.NewbieCarnivalData);
							}
							input.ReadMessage(newbieCarnivalData);
							this.NewbieCarnivalData = newbieCarnivalData;
							continue;
						}
						if (num == 474U)
						{
							MoraleActivityData moraleActivityData = new MoraleActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.MoraleActivityData)
							{
								moraleActivityData.MergeFrom(this.MoraleActivityData);
							}
							input.ReadMessage(moraleActivityData);
							this.MoraleActivityData = moraleActivityData;
							continue;
						}
					}
				}
				else if (num <= 714U)
				{
					if (num <= 594U)
					{
						if (num <= 530U)
						{
							if (num <= 498U)
							{
								if (num == 482U)
								{
									FloroRanchActivityData floroRanchActivityData = new FloroRanchActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.FloroRanchActivityData)
									{
										floroRanchActivityData.MergeFrom(this.FloroRanchActivityData);
									}
									input.ReadMessage(floroRanchActivityData);
									this.FloroRanchActivityData = floroRanchActivityData;
									continue;
								}
								if (num == 490U)
								{
									LifePointChallengeActivityData lifePointChallengeActivityData = new LifePointChallengeActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.LifePointChallenge)
									{
										lifePointChallengeActivityData.MergeFrom(this.LifePointChallenge);
									}
									input.ReadMessage(lifePointChallengeActivityData);
									this.LifePointChallenge = lifePointChallengeActivityData;
									continue;
								}
								if (num == 498U)
								{
									TrapDefenseActivityInfo trapDefenseActivityInfo = new TrapDefenseActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.TrapDefenseActivityInfo)
									{
										trapDefenseActivityInfo.MergeFrom(this.TrapDefenseActivityInfo);
									}
									input.ReadMessage(trapDefenseActivityInfo);
									this.TrapDefenseActivityInfo = trapDefenseActivityInfo;
									continue;
								}
							}
							else if (num <= 514U)
							{
								if (num == 506U)
								{
									FunPlayActivityInfo funPlayActivityInfo = new FunPlayActivityInfo();
									if (this.dataCase_ == ActivityData.DataOneofCase.FunPlayActivityInfo)
									{
										funPlayActivityInfo.MergeFrom(this.FunPlayActivityInfo);
									}
									input.ReadMessage(funPlayActivityInfo);
									this.FunPlayActivityInfo = funPlayActivityInfo;
									continue;
								}
								if (num == 514U)
								{
									JinzhouFlyData jinzhouFlyData = new JinzhouFlyData();
									if (this.dataCase_ == ActivityData.DataOneofCase.JinzhouFlyData)
									{
										jinzhouFlyData.MergeFrom(this.JinzhouFlyData);
									}
									input.ReadMessage(jinzhouFlyData);
									this.JinzhouFlyData = jinzhouFlyData;
									continue;
								}
							}
							else
							{
								if (num == 522U)
								{
									LineCrossActivityData lineCrossActivityData = new LineCrossActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.LineCrossActivityData)
									{
										lineCrossActivityData.MergeFrom(this.LineCrossActivityData);
									}
									input.ReadMessage(lineCrossActivityData);
									this.LineCrossActivityData = lineCrossActivityData;
									continue;
								}
								if (num == 530U)
								{
									MoonPhaseActivityData moonPhaseActivityData = new MoonPhaseActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.MoonPhaseActivityData)
									{
										moonPhaseActivityData.MergeFrom(this.MoonPhaseActivityData);
									}
									input.ReadMessage(moonPhaseActivityData);
									this.MoonPhaseActivityData = moonPhaseActivityData;
									continue;
								}
							}
						}
						else if (num <= 560U)
						{
							if (num <= 544U)
							{
								if (num == 536U)
								{
									this.LimitBeginTime = input.ReadInt64();
									continue;
								}
								if (num == 544U)
								{
									this.LimitEndTime = input.ReadInt64();
									continue;
								}
							}
							else
							{
								if (num == 552U)
								{
									this.LimitRewardBeginTime = input.ReadInt64();
									continue;
								}
								if (num == 560U)
								{
									this.LimitRewardEndTime = input.ReadInt64();
									continue;
								}
							}
						}
						else if (num <= 578U)
						{
							if (num == 570U)
							{
								HonamiStoryActivityInfo honamiStoryActivityInfo = new HonamiStoryActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.HonamiStoryActivityInfo)
								{
									honamiStoryActivityInfo.MergeFrom(this.HonamiStoryActivityInfo);
								}
								input.ReadMessage(honamiStoryActivityInfo);
								this.HonamiStoryActivityInfo = honamiStoryActivityInfo;
								continue;
							}
							if (num == 578U)
							{
								PhotoFightActivityPb photoFightActivityPb = new PhotoFightActivityPb();
								if (this.dataCase_ == ActivityData.DataOneofCase.PhotoFightActivityData)
								{
									photoFightActivityPb.MergeFrom(this.PhotoFightActivityData);
								}
								input.ReadMessage(photoFightActivityPb);
								this.PhotoFightActivityData = photoFightActivityPb;
								continue;
							}
						}
						else
						{
							if (num == 586U)
							{
								SurvivorsActivityData survivorsActivityData = new SurvivorsActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.SurvivorsActivityData)
								{
									survivorsActivityData.MergeFrom(this.SurvivorsActivityData);
								}
								input.ReadMessage(survivorsActivityData);
								this.SurvivorsActivityData = survivorsActivityData;
								continue;
							}
							if (num == 594U)
							{
								WuWuKujiActivityPb wuWuKujiActivityPb = new WuWuKujiActivityPb();
								if (this.dataCase_ == ActivityData.DataOneofCase.WuWuKujiActivityInfo)
								{
									wuWuKujiActivityPb.MergeFrom(this.WuWuKujiActivityInfo);
								}
								input.ReadMessage(wuWuKujiActivityPb);
								this.WuWuKujiActivityInfo = wuWuKujiActivityPb;
								continue;
							}
						}
					}
					else if (num <= 650U)
					{
						if (num <= 618U)
						{
							if (num == 602U)
							{
								AdvertisingPageData advertisingPageData = new AdvertisingPageData();
								if (this.dataCase_ == ActivityData.DataOneofCase.AdvertisingPageInfo)
								{
									advertisingPageData.MergeFrom(this.AdvertisingPageInfo);
								}
								input.ReadMessage(advertisingPageData);
								this.AdvertisingPageInfo = advertisingPageData;
								continue;
							}
							if (num == 610U)
							{
								ArtemisActivityInfo artemisActivityInfo = new ArtemisActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.ArtemisActivityInfo)
								{
									artemisActivityInfo.MergeFrom(this.ArtemisActivityInfo);
								}
								input.ReadMessage(artemisActivityInfo);
								this.ArtemisActivityInfo = artemisActivityInfo;
								continue;
							}
							if (num == 618U)
							{
								RoleCoopActivityData roleCoopActivityData = new RoleCoopActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RoleCoopActivityData)
								{
									roleCoopActivityData.MergeFrom(this.RoleCoopActivityData);
								}
								input.ReadMessage(roleCoopActivityData);
								this.RoleCoopActivityData = roleCoopActivityData;
								continue;
							}
						}
						else if (num <= 634U)
						{
							if (num == 626U)
							{
								MotorCycleIpActivityData motorCycleIpActivityData = new MotorCycleIpActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.MotorCycleIpActivityData)
								{
									motorCycleIpActivityData.MergeFrom(this.MotorCycleIpActivityData);
								}
								input.ReadMessage(motorCycleIpActivityData);
								this.MotorCycleIpActivityData = motorCycleIpActivityData;
								continue;
							}
							if (num == 634U)
							{
								PhantomBattleActivityInfo phantomBattleActivityInfo2 = new PhantomBattleActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleRecordActivityInfo)
								{
									phantomBattleActivityInfo2.MergeFrom(this.PhantomBattleRecordActivityInfo);
								}
								input.ReadMessage(phantomBattleActivityInfo2);
								this.PhantomBattleRecordActivityInfo = phantomBattleActivityInfo2;
								continue;
							}
						}
						else
						{
							if (num == 642U)
							{
								InfrThemeActivityPb infrThemeActivityPb = new InfrThemeActivityPb();
								if (this.dataCase_ == ActivityData.DataOneofCase.InfrThemeActivityPb)
								{
									infrThemeActivityPb.MergeFrom(this.InfrThemeActivityPb);
								}
								input.ReadMessage(infrThemeActivityPb);
								this.InfrThemeActivityPb = infrThemeActivityPb;
								continue;
							}
							if (num == 650U)
							{
								RoadBookActivityInfo roadBookActivityInfo = new RoadBookActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.RoadBookActivityInfo)
								{
									roadBookActivityInfo.MergeFrom(this.RoadBookActivityInfo);
								}
								input.ReadMessage(roadBookActivityInfo);
								this.RoadBookActivityInfo = roadBookActivityInfo;
								continue;
							}
						}
					}
					else if (num <= 682U)
					{
						if (num <= 666U)
						{
							if (num == 658U)
							{
								PhantomBattleGuideActivity phantomBattleGuideActivity = new PhantomBattleGuideActivity();
								if (this.dataCase_ == ActivityData.DataOneofCase.PhantomBattleGuideActivity)
								{
									phantomBattleGuideActivity.MergeFrom(this.PhantomBattleGuideActivity);
								}
								input.ReadMessage(phantomBattleGuideActivity);
								this.PhantomBattleGuideActivity = phantomBattleGuideActivity;
								continue;
							}
							if (num == 666U)
							{
								NewTowerClimbingActivityData newTowerClimbingActivityData = new NewTowerClimbingActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.NewTowerClimbingActivityData)
								{
									newTowerClimbingActivityData.MergeFrom(this.NewTowerClimbingActivityData);
								}
								input.ReadMessage(newTowerClimbingActivityData);
								this.NewTowerClimbingActivityData = newTowerClimbingActivityData;
								continue;
							}
						}
						else
						{
							if (num == 674U)
							{
								NewPlayerSupportActivityData newPlayerSupportActivityData = new NewPlayerSupportActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityData)
								{
									newPlayerSupportActivityData.MergeFrom(this.NewPlayerSupportActivityData);
								}
								input.ReadMessage(newPlayerSupportActivityData);
								this.NewPlayerSupportActivityData = newPlayerSupportActivityData;
								continue;
							}
							if (num == 682U)
							{
								MotorParkourActivityInfo motorParkourActivityInfo = new MotorParkourActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.MotorParkourActivityInfo)
								{
									motorParkourActivityInfo.MergeFrom(this.MotorParkourActivityInfo);
								}
								input.ReadMessage(motorParkourActivityInfo);
								this.MotorParkourActivityInfo = motorParkourActivityInfo;
								continue;
							}
						}
					}
					else if (num <= 698U)
					{
						if (num == 690U)
						{
							SpringFestivalActivityInfo springFestivalActivityInfo = new SpringFestivalActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.SpringFestivalActivityInfo)
							{
								springFestivalActivityInfo.MergeFrom(this.SpringFestivalActivityInfo);
							}
							input.ReadMessage(springFestivalActivityInfo);
							this.SpringFestivalActivityInfo = springFestivalActivityInfo;
							continue;
						}
						if (num == 698U)
						{
							TotalTopUpActivityInfo totalTopUpActivityInfo = new TotalTopUpActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.TotalTopUpActivityInfo)
							{
								totalTopUpActivityInfo.MergeFrom(this.TotalTopUpActivityInfo);
							}
							input.ReadMessage(totalTopUpActivityInfo);
							this.TotalTopUpActivityInfo = totalTopUpActivityInfo;
							continue;
						}
					}
					else
					{
						if (num == 706U)
						{
							MotorFightActivityPb motorFightActivityPb = new MotorFightActivityPb();
							if (this.dataCase_ == ActivityData.DataOneofCase.MotorFightActivityPb)
							{
								motorFightActivityPb.MergeFrom(this.MotorFightActivityPb);
							}
							input.ReadMessage(motorFightActivityPb);
							this.MotorFightActivityPb = motorFightActivityPb;
							continue;
						}
						if (num == 714U)
						{
							H5ViewActivityData h5ViewActivityData = new H5ViewActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.H5ViewActivityData)
							{
								h5ViewActivityData.MergeFrom(this.H5ViewActivityData);
							}
							input.ReadMessage(h5ViewActivityData);
							this.H5ViewActivityData = h5ViewActivityData;
							continue;
						}
					}
				}
				else if (num <= 834U)
				{
					if (num <= 770U)
					{
						if (num <= 738U)
						{
							if (num == 722U)
							{
								SkinRewardActivityData skinRewardActivityData = new SkinRewardActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.SkinRewardActivityData)
								{
									skinRewardActivityData.MergeFrom(this.SkinRewardActivityData);
								}
								input.ReadMessage(skinRewardActivityData);
								this.SkinRewardActivityData = skinRewardActivityData;
								continue;
							}
							if (num == 730U)
							{
								EncircleActivityPb encircleActivityPb = new EncircleActivityPb();
								if (this.dataCase_ == ActivityData.DataOneofCase.EncircleActivityPb)
								{
									encircleActivityPb.MergeFrom(this.EncircleActivityPb);
								}
								input.ReadMessage(encircleActivityPb);
								this.EncircleActivityPb = encircleActivityPb;
								continue;
							}
							if (num == 738U)
							{
								MotorDevelopActivityData motorDevelopActivityData = new MotorDevelopActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.MotorDevelopActivityData)
								{
									motorDevelopActivityData.MergeFrom(this.MotorDevelopActivityData);
								}
								input.ReadMessage(motorDevelopActivityData);
								this.MotorDevelopActivityData = motorDevelopActivityData;
								continue;
							}
						}
						else if (num <= 754U)
						{
							if (num == 746U)
							{
								FlagChallengeActivityInfo flagChallengeActivityInfo = new FlagChallengeActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.FlagChallengeActivityInfo)
								{
									flagChallengeActivityInfo.MergeFrom(this.FlagChallengeActivityInfo);
								}
								input.ReadMessage(flagChallengeActivityInfo);
								this.FlagChallengeActivityInfo = flagChallengeActivityInfo;
								continue;
							}
							if (num == 754U)
							{
								FeiXuePreheatActivityInfo feiXuePreheatActivityInfo = new FeiXuePreheatActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.FeiXuePreheatActivityInfo)
								{
									feiXuePreheatActivityInfo.MergeFrom(this.FeiXuePreheatActivityInfo);
								}
								input.ReadMessage(feiXuePreheatActivityInfo);
								this.FeiXuePreheatActivityInfo = feiXuePreheatActivityInfo;
								continue;
							}
						}
						else
						{
							if (num == 762U)
							{
								RhythmActivityPb rhythmActivityPb = new RhythmActivityPb();
								if (this.dataCase_ == ActivityData.DataOneofCase.RhythmActivityPb)
								{
									rhythmActivityPb.MergeFrom(this.RhythmActivityPb);
								}
								input.ReadMessage(rhythmActivityPb);
								this.RhythmActivityPb = rhythmActivityPb;
								continue;
							}
							if (num == 770U)
							{
								DropCatchActivityInfo dropCatchActivityInfo = new DropCatchActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.DropCatchActivityInfo)
								{
									dropCatchActivityInfo.MergeFrom(this.DropCatchActivityInfo);
								}
								input.ReadMessage(dropCatchActivityInfo);
								this.DropCatchActivityInfo = dropCatchActivityInfo;
								continue;
							}
						}
					}
					else if (num <= 802U)
					{
						if (num <= 786U)
						{
							if (num == 778U)
							{
								TetrisActivityInfo tetrisActivityInfo = new TetrisActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.TetrisActivityInfo)
								{
									tetrisActivityInfo.MergeFrom(this.TetrisActivityInfo);
								}
								input.ReadMessage(tetrisActivityInfo);
								this.TetrisActivityInfo = tetrisActivityInfo;
								continue;
							}
							if (num == 786U)
							{
								PinballActivityData pinballActivityData = new PinballActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.PinballActivityData)
								{
									pinballActivityData.MergeFrom(this.PinballActivityData);
								}
								input.ReadMessage(pinballActivityData);
								this.PinballActivityData = pinballActivityData;
								continue;
							}
						}
						else
						{
							if (num == 794U)
							{
								BossPilingActivityInfo bossPilingActivityInfo = new BossPilingActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.BossPilingActivityInfo)
								{
									bossPilingActivityInfo.MergeFrom(this.BossPilingActivityInfo);
								}
								input.ReadMessage(bossPilingActivityInfo);
								this.BossPilingActivityInfo = bossPilingActivityInfo;
								continue;
							}
							if (num == 802U)
							{
								ThemeCelebration themeCelebration = new ThemeCelebration();
								if (this.dataCase_ == ActivityData.DataOneofCase.ThemeCelebration)
								{
									themeCelebration.MergeFrom(this.ThemeCelebration);
								}
								input.ReadMessage(themeCelebration);
								this.ThemeCelebration = themeCelebration;
								continue;
							}
						}
					}
					else if (num <= 818U)
					{
						if (num == 810U)
						{
							WuWuWeekActivity wuWuWeekActivity = new WuWuWeekActivity();
							if (this.dataCase_ == ActivityData.DataOneofCase.WuWuWeekActivity)
							{
								wuWuWeekActivity.MergeFrom(this.WuWuWeekActivity);
							}
							input.ReadMessage(wuWuWeekActivity);
							this.WuWuWeekActivity = wuWuWeekActivity;
							continue;
						}
						if (num == 818U)
						{
							MotorDecalActivityData motorDecalActivityData = new MotorDecalActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.MotorDecalActivityData)
							{
								motorDecalActivityData.MergeFrom(this.MotorDecalActivityData);
							}
							input.ReadMessage(motorDecalActivityData);
							this.MotorDecalActivityData = motorDecalActivityData;
							continue;
						}
					}
					else
					{
						if (num == 826U)
						{
							LinkageCheckInActivityData linkageCheckInActivityData = new LinkageCheckInActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.LinkageCheckInActivityData)
							{
								linkageCheckInActivityData.MergeFrom(this.LinkageCheckInActivityData);
							}
							input.ReadMessage(linkageCheckInActivityData);
							this.LinkageCheckInActivityData = linkageCheckInActivityData;
							continue;
						}
						if (num == 834U)
						{
							RoleGiftActivityData roleGiftActivityData = new RoleGiftActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.RoleGiftActivityData)
							{
								roleGiftActivityData.MergeFrom(this.RoleGiftActivityData);
							}
							input.ReadMessage(roleGiftActivityData);
							this.RoleGiftActivityData = roleGiftActivityData;
							continue;
						}
					}
				}
				else if (num <= 898U)
				{
					if (num <= 866U)
					{
						if (num <= 850U)
						{
							if (num == 842U)
							{
								KurotatoActivityData kurotatoActivityData = new KurotatoActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.KurotatoActivityData)
								{
									kurotatoActivityData.MergeFrom(this.KurotatoActivityData);
								}
								input.ReadMessage(kurotatoActivityData);
								this.KurotatoActivityData = kurotatoActivityData;
								continue;
							}
							if (num == 850U)
							{
								GolemCrackActivityInfo golemCrackActivityInfo = new GolemCrackActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.GolemCrackActivityInfo)
								{
									golemCrackActivityInfo.MergeFrom(this.GolemCrackActivityInfo);
								}
								input.ReadMessage(golemCrackActivityInfo);
								this.GolemCrackActivityInfo = golemCrackActivityInfo;
								continue;
							}
						}
						else
						{
							if (num == 858U)
							{
								EdgeRunnerActivityInfo edgeRunnerActivityInfo = new EdgeRunnerActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.EdgeRunnerActivityInfo)
								{
									edgeRunnerActivityInfo.MergeFrom(this.EdgeRunnerActivityInfo);
								}
								input.ReadMessage(edgeRunnerActivityInfo);
								this.EdgeRunnerActivityInfo = edgeRunnerActivityInfo;
								continue;
							}
							if (num == 866U)
							{
								OnlineMotorActivityData onlineMotorActivityData = new OnlineMotorActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.OnlineMotorActivityData)
								{
									onlineMotorActivityData.MergeFrom(this.OnlineMotorActivityData);
								}
								input.ReadMessage(onlineMotorActivityData);
								this.OnlineMotorActivityData = onlineMotorActivityData;
								continue;
							}
						}
					}
					else if (num <= 882U)
					{
						if (num == 874U)
						{
							RealmBetweenActivityInfo realmBetweenActivityInfo = new RealmBetweenActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.RealmBetweenActivityInfo)
							{
								realmBetweenActivityInfo.MergeFrom(this.RealmBetweenActivityInfo);
							}
							input.ReadMessage(realmBetweenActivityInfo);
							this.RealmBetweenActivityInfo = realmBetweenActivityInfo;
							continue;
						}
						if (num == 882U)
						{
							ThroughTrainSummaryActivityData throughTrainSummaryActivityData = new ThroughTrainSummaryActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainSummaryActivityData)
							{
								throughTrainSummaryActivityData.MergeFrom(this.ThroughTrainSummaryActivityData);
							}
							input.ReadMessage(throughTrainSummaryActivityData);
							this.ThroughTrainSummaryActivityData = throughTrainSummaryActivityData;
							continue;
						}
					}
					else
					{
						if (num == 890U)
						{
							NewbieMainActivityPb newbieMainActivityPb = new NewbieMainActivityPb();
							if (this.dataCase_ == ActivityData.DataOneofCase.NewbieMainActivityPb)
							{
								newbieMainActivityPb.MergeFrom(this.NewbieMainActivityPb);
							}
							input.ReadMessage(newbieMainActivityPb);
							this.NewbieMainActivityPb = newbieMainActivityPb;
							continue;
						}
						if (num == 898U)
						{
							NewbieCourseV2ActivityPb newbieCourseV2ActivityPb = new NewbieCourseV2ActivityPb();
							if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCourseV2ActivityPb)
							{
								newbieCourseV2ActivityPb.MergeFrom(this.NewbieCourseV2ActivityPb);
							}
							input.ReadMessage(newbieCourseV2ActivityPb);
							this.NewbieCourseV2ActivityPb = newbieCourseV2ActivityPb;
							continue;
						}
					}
				}
				else if (num <= 930U)
				{
					if (num <= 914U)
					{
						if (num == 906U)
						{
							NewbieAdventureV2Pb newbieAdventureV2Pb = new NewbieAdventureV2Pb();
							if (this.dataCase_ == ActivityData.DataOneofCase.NewbieAdventureV2Pb)
							{
								newbieAdventureV2Pb.MergeFrom(this.NewbieAdventureV2Pb);
							}
							input.ReadMessage(newbieAdventureV2Pb);
							this.NewbieAdventureV2Pb = newbieAdventureV2Pb;
							continue;
						}
						if (num == 914U)
						{
							NewPlayerSupportActivityV2Pb newPlayerSupportActivityV2Pb = new NewPlayerSupportActivityV2Pb();
							if (this.dataCase_ == ActivityData.DataOneofCase.NewPlayerSupportActivityV2Pb)
							{
								newPlayerSupportActivityV2Pb.MergeFrom(this.NewPlayerSupportActivityV2Pb);
							}
							input.ReadMessage(newPlayerSupportActivityV2Pb);
							this.NewPlayerSupportActivityV2Pb = newPlayerSupportActivityV2Pb;
							continue;
						}
					}
					else
					{
						if (num == 922U)
						{
							ThroughTrainActivityData throughTrainActivityData = new ThroughTrainActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.ThroughTrainActivityData)
							{
								throughTrainActivityData.MergeFrom(this.ThroughTrainActivityData);
							}
							input.ReadMessage(throughTrainActivityData);
							this.ThroughTrainActivityData = throughTrainActivityData;
							continue;
						}
						if (num == 930U)
						{
							RoverRogueActivityData roverRogueActivityData = new RoverRogueActivityData();
							if (this.dataCase_ == ActivityData.DataOneofCase.RoverRogueActivityData)
							{
								roverRogueActivityData.MergeFrom(this.RoverRogueActivityData);
							}
							input.ReadMessage(roverRogueActivityData);
							this.RoverRogueActivityData = roverRogueActivityData;
							continue;
						}
					}
				}
				else if (num <= 946U)
				{
					if (num == 938U)
					{
						DangoBrawlActivityInfo dangoBrawlActivityInfo = new DangoBrawlActivityInfo();
						if (this.dataCase_ == ActivityData.DataOneofCase.DangoBrawlActivityInfo)
						{
							dangoBrawlActivityInfo.MergeFrom(this.DangoBrawlActivityInfo);
						}
						input.ReadMessage(dangoBrawlActivityInfo);
						this.DangoBrawlActivityInfo = dangoBrawlActivityInfo;
						continue;
					}
					if (num == 946U)
					{
						QingXiaoActivityInfo qingXiaoActivityInfo = new QingXiaoActivityInfo();
						if (this.dataCase_ == ActivityData.DataOneofCase.QingXiaoActivityInfo)
						{
							qingXiaoActivityInfo.MergeFrom(this.QingXiaoActivityInfo);
						}
						input.ReadMessage(qingXiaoActivityInfo);
						this.QingXiaoActivityInfo = qingXiaoActivityInfo;
						continue;
					}
				}
				else
				{
					if (num == 962U)
					{
						MatchThreeActivityInfo matchThreeActivityInfo = new MatchThreeActivityInfo();
						if (this.dataCase_ == ActivityData.DataOneofCase.MatchThreeActivityInfo)
						{
							matchThreeActivityInfo.MergeFrom(this.MatchThreeActivityInfo);
						}
						input.ReadMessage(matchThreeActivityInfo);
						this.MatchThreeActivityInfo = matchThreeActivityInfo;
						continue;
					}
					if (num == 970U)
					{
						GiantActivityInfo giantActivityInfo = new GiantActivityInfo();
						if (this.dataCase_ == ActivityData.DataOneofCase.GiantActivityInfo)
						{
							giantActivityInfo.MergeFrom(this.GiantActivityInfo);
						}
						input.ReadMessage(giantActivityInfo);
						this.GiantActivityInfo = giantActivityInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021AB RID: 8619
		private static readonly MessageParser<ActivityData> _parser = new MessageParser<ActivityData>(() => new ActivityData());

		// Token: 0x040021AC RID: 8620
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021AD RID: 8621
		public const int IdFieldNumber = 1;

		// Token: 0x040021AE RID: 8622
		private int id_;

		// Token: 0x040021AF RID: 8623
		public const int TypeFieldNumber = 2;

		// Token: 0x040021B0 RID: 8624
		private ActivityType type_;

		// Token: 0x040021B1 RID: 8625
		public const int BeginShowTimeFieldNumber = 3;

		// Token: 0x040021B2 RID: 8626
		private long beginShowTime_;

		// Token: 0x040021B3 RID: 8627
		public const int EndShowTimeFieldNumber = 4;

		// Token: 0x040021B4 RID: 8628
		private long endShowTime_;

		// Token: 0x040021B5 RID: 8629
		public const int BeginOpenTimeFieldNumber = 5;

		// Token: 0x040021B6 RID: 8630
		private long beginOpenTime_;

		// Token: 0x040021B7 RID: 8631
		public const int EndOpenTimeFieldNumber = 6;

		// Token: 0x040021B8 RID: 8632
		private long endOpenTime_;

		// Token: 0x040021B9 RID: 8633
		public const int IsUnlockFieldNumber = 7;

		// Token: 0x040021BA RID: 8634
		private bool isUnlock_;

		// Token: 0x040021BB RID: 8635
		public const int CompletePreQuestsFieldNumber = 8;

		// Token: 0x040021BC RID: 8636
		private static readonly FieldCodec<int> _repeated_completePreQuests_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040021BD RID: 8637
		private readonly RepeatedField<int> completePreQuests_ = new RepeatedField<int>();

		// Token: 0x040021BE RID: 8638
		public const int IsFirstOpenFieldNumber = 9;

		// Token: 0x040021BF RID: 8639
		private bool isFirstOpen_;

		// Token: 0x040021C0 RID: 8640
		public const int FinishConditionsFieldNumber = 30;

		// Token: 0x040021C1 RID: 8641
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(242U);

		// Token: 0x040021C2 RID: 8642
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x040021C3 RID: 8643
		public const int ActivityOpenTypeFieldNumber = 33;

		// Token: 0x040021C4 RID: 8644
		private ActivityOpenType activityOpenType_;

		// Token: 0x040021C5 RID: 8645
		public const int CanPreOpenFieldNumber = 42;

		// Token: 0x040021C6 RID: 8646
		private bool canPreOpen_;

		// Token: 0x040021C7 RID: 8647
		public const int LimitBeginTimeFieldNumber = 67;

		// Token: 0x040021C8 RID: 8648
		private long limitBeginTime_;

		// Token: 0x040021C9 RID: 8649
		public const int LimitEndTimeFieldNumber = 68;

		// Token: 0x040021CA RID: 8650
		private long limitEndTime_;

		// Token: 0x040021CB RID: 8651
		public const int LimitRewardBeginTimeFieldNumber = 69;

		// Token: 0x040021CC RID: 8652
		private long limitRewardBeginTime_;

		// Token: 0x040021CD RID: 8653
		public const int LimitRewardEndTimeFieldNumber = 70;

		// Token: 0x040021CE RID: 8654
		private long limitRewardEndTime_;

		// Token: 0x040021CF RID: 8655
		public const int ParkourActivityFieldNumber = 10;

		// Token: 0x040021D0 RID: 8656
		public const int SignActivityFieldNumber = 11;

		// Token: 0x040021D1 RID: 8657
		public const int NewBieCourseActivityFieldNumber = 12;

		// Token: 0x040021D2 RID: 8658
		public const int DoubleInstActivityRewardFieldNumber = 13;

		// Token: 0x040021D3 RID: 8659
		public const int HarvestActivityFieldNumber = 14;

		// Token: 0x040021D4 RID: 8660
		public const int RoleTrialInfoActivityFieldNumber = 15;

		// Token: 0x040021D5 RID: 8661
		public const int PhantomCollectActivityFieldNumber = 16;

		// Token: 0x040021D6 RID: 8662
		public const int GatherActivityInfoFieldNumber = 17;

		// Token: 0x040021D7 RID: 8663
		public const int DailyAdventureActivityDataFieldNumber = 18;

		// Token: 0x040021D8 RID: 8664
		public const int RoguelikeActivityDataFieldNumber = 19;

		// Token: 0x040021D9 RID: 8665
		public const int LongShanActivityDataFieldNumber = 20;

		// Token: 0x040021DA RID: 8666
		public const int TurntableActivityDataFieldNumber = 21;

		// Token: 0x040021DB RID: 8667
		public const int BossRushActivityDataFieldNumber = 22;

		// Token: 0x040021DC RID: 8668
		public const int TrackMoonActivityTaskDataFieldNumber = 23;

		// Token: 0x040021DD RID: 8669
		public const int TimePointRewardActivityDataFieldNumber = 24;

		// Token: 0x040021DE RID: 8670
		public const int TowerDefenceActivityDataFieldNumber = 25;

		// Token: 0x040021DF RID: 8671
		public const int CircumFluenceTaskDataFieldNumber = 26;

		// Token: 0x040021E0 RID: 8672
		public const int TraceMoonPhaseDataFieldNumber = 27;

		// Token: 0x040021E1 RID: 8673
		public const int CorniceMeetingDataFieldNumber = 28;

		// Token: 0x040021E2 RID: 8674
		public const int RiskHarvestActivityInfoFieldNumber = 29;

		// Token: 0x040021E3 RID: 8675
		public const int BlackCoastThemeActivityDataFieldNumber = 31;

		// Token: 0x040021E4 RID: 8676
		public const int RogueWhiteCatDataFieldNumber = 32;

		// Token: 0x040021E5 RID: 8677
		public const int ScratchCardActivityInfoFieldNumber = 34;

		// Token: 0x040021E6 RID: 8678
		public const int PreheatSignActivityInfoFieldNumber = 35;

		// Token: 0x040021E7 RID: 8679
		public const int MowTowerActivityInfoFieldNumber = 36;

		// Token: 0x040021E8 RID: 8680
		public const int FarmGoldInfoFieldNumber = 37;

		// Token: 0x040021E9 RID: 8681
		public const int SpringSignInfoFieldNumber = 38;

		// Token: 0x040021EA RID: 8682
		public const int MapTravelActivityInfoFieldNumber = 39;

		// Token: 0x040021EB RID: 8683
		public const int RoleSkinTrialInfoActivityFieldNumber = 40;

		// Token: 0x040021EC RID: 8684
		public const int FishingActivityInfoFieldNumber = 41;

		// Token: 0x040021ED RID: 8685
		public const int RogueWeeklyDataFieldNumber = 43;

		// Token: 0x040021EE RID: 8686
		public const int TeamParkourLevelActivityInfoFieldNumber = 44;

		// Token: 0x040021EF RID: 8687
		public const int BabelActivityInfoFieldNumber = 45;

		// Token: 0x040021F0 RID: 8688
		public const int RacingBetsDataFieldNumber = 46;

		// Token: 0x040021F1 RID: 8689
		public const int ExploreActivityInfoFieldNumber = 47;

		// Token: 0x040021F2 RID: 8690
		public const int RogueResActivityDataFieldNumber = 48;

		// Token: 0x040021F3 RID: 8691
		public const int AvignonActivityInfoFieldNumber = 49;

		// Token: 0x040021F4 RID: 8692
		public const int AbyssInfoFieldNumber = 50;

		// Token: 0x040021F5 RID: 8693
		public const int H5CircumFluenceDataFieldNumber = 51;

		// Token: 0x040021F6 RID: 8694
		public const int DangoMonopolyActivityDataFieldNumber = 52;

		// Token: 0x040021F7 RID: 8695
		public const int CiacconaActivityPbDataFieldNumber = 53;

		// Token: 0x040021F8 RID: 8696
		public const int ActivityLinkageDataFieldNumber = 54;

		// Token: 0x040021F9 RID: 8697
		public const int RegressDataFieldNumber = 55;

		// Token: 0x040021FA RID: 8698
		public const int ConsumptiveActivityInfoFieldNumber = 56;

		// Token: 0x040021FB RID: 8699
		public const int PhantomBattleActivityInfoFieldNumber = 57;

		// Token: 0x040021FC RID: 8700
		public const int NewbieCarnivalDataFieldNumber = 58;

		// Token: 0x040021FD RID: 8701
		public const int MoraleActivityDataFieldNumber = 59;

		// Token: 0x040021FE RID: 8702
		public const int FloroRanchActivityDataFieldNumber = 60;

		// Token: 0x040021FF RID: 8703
		public const int LifePointChallengeFieldNumber = 61;

		// Token: 0x04002200 RID: 8704
		public const int TrapDefenseActivityInfoFieldNumber = 62;

		// Token: 0x04002201 RID: 8705
		public const int FunPlayActivityInfoFieldNumber = 63;

		// Token: 0x04002202 RID: 8706
		public const int JinzhouFlyDataFieldNumber = 64;

		// Token: 0x04002203 RID: 8707
		public const int LineCrossActivityDataFieldNumber = 65;

		// Token: 0x04002204 RID: 8708
		public const int MoonPhaseActivityDataFieldNumber = 66;

		// Token: 0x04002205 RID: 8709
		public const int HonamiStoryActivityInfoFieldNumber = 71;

		// Token: 0x04002206 RID: 8710
		public const int PhotoFightActivityDataFieldNumber = 72;

		// Token: 0x04002207 RID: 8711
		public const int SurvivorsActivityDataFieldNumber = 73;

		// Token: 0x04002208 RID: 8712
		public const int WuWuKujiActivityInfoFieldNumber = 74;

		// Token: 0x04002209 RID: 8713
		public const int AdvertisingPageInfoFieldNumber = 75;

		// Token: 0x0400220A RID: 8714
		public const int ArtemisActivityInfoFieldNumber = 76;

		// Token: 0x0400220B RID: 8715
		public const int RoleCoopActivityDataFieldNumber = 77;

		// Token: 0x0400220C RID: 8716
		public const int MotorCycleIpActivityDataFieldNumber = 78;

		// Token: 0x0400220D RID: 8717
		public const int PhantomBattleRecordActivityInfoFieldNumber = 79;

		// Token: 0x0400220E RID: 8718
		public const int InfrThemeActivityPbFieldNumber = 80;

		// Token: 0x0400220F RID: 8719
		public const int RoadBookActivityInfoFieldNumber = 81;

		// Token: 0x04002210 RID: 8720
		public const int PhantomBattleGuideActivityFieldNumber = 82;

		// Token: 0x04002211 RID: 8721
		public const int NewTowerClimbingActivityDataFieldNumber = 83;

		// Token: 0x04002212 RID: 8722
		public const int NewPlayerSupportActivityDataFieldNumber = 84;

		// Token: 0x04002213 RID: 8723
		public const int MotorParkourActivityInfoFieldNumber = 85;

		// Token: 0x04002214 RID: 8724
		public const int SpringFestivalActivityInfoFieldNumber = 86;

		// Token: 0x04002215 RID: 8725
		public const int TotalTopUpActivityInfoFieldNumber = 87;

		// Token: 0x04002216 RID: 8726
		public const int MotorFightActivityPbFieldNumber = 88;

		// Token: 0x04002217 RID: 8727
		public const int H5ViewActivityDataFieldNumber = 89;

		// Token: 0x04002218 RID: 8728
		public const int SkinRewardActivityDataFieldNumber = 90;

		// Token: 0x04002219 RID: 8729
		public const int EncircleActivityPbFieldNumber = 91;

		// Token: 0x0400221A RID: 8730
		public const int MotorDevelopActivityDataFieldNumber = 92;

		// Token: 0x0400221B RID: 8731
		public const int FlagChallengeActivityInfoFieldNumber = 93;

		// Token: 0x0400221C RID: 8732
		public const int FeiXuePreheatActivityInfoFieldNumber = 94;

		// Token: 0x0400221D RID: 8733
		public const int RhythmActivityPbFieldNumber = 95;

		// Token: 0x0400221E RID: 8734
		public const int DropCatchActivityInfoFieldNumber = 96;

		// Token: 0x0400221F RID: 8735
		public const int TetrisActivityInfoFieldNumber = 97;

		// Token: 0x04002220 RID: 8736
		public const int PinballActivityDataFieldNumber = 98;

		// Token: 0x04002221 RID: 8737
		public const int BossPilingActivityInfoFieldNumber = 99;

		// Token: 0x04002222 RID: 8738
		public const int ThemeCelebrationFieldNumber = 100;

		// Token: 0x04002223 RID: 8739
		public const int WuWuWeekActivityFieldNumber = 101;

		// Token: 0x04002224 RID: 8740
		public const int MotorDecalActivityDataFieldNumber = 102;

		// Token: 0x04002225 RID: 8741
		public const int LinkageCheckInActivityDataFieldNumber = 103;

		// Token: 0x04002226 RID: 8742
		public const int RoleGiftActivityDataFieldNumber = 104;

		// Token: 0x04002227 RID: 8743
		public const int KurotatoActivityDataFieldNumber = 105;

		// Token: 0x04002228 RID: 8744
		public const int GolemCrackActivityInfoFieldNumber = 106;

		// Token: 0x04002229 RID: 8745
		public const int EdgeRunnerActivityInfoFieldNumber = 107;

		// Token: 0x0400222A RID: 8746
		public const int OnlineMotorActivityDataFieldNumber = 108;

		// Token: 0x0400222B RID: 8747
		public const int RealmBetweenActivityInfoFieldNumber = 109;

		// Token: 0x0400222C RID: 8748
		public const int ThroughTrainSummaryActivityDataFieldNumber = 110;

		// Token: 0x0400222D RID: 8749
		public const int NewbieMainActivityPbFieldNumber = 111;

		// Token: 0x0400222E RID: 8750
		public const int NewbieCourseV2ActivityPbFieldNumber = 112;

		// Token: 0x0400222F RID: 8751
		public const int NewbieAdventureV2PbFieldNumber = 113;

		// Token: 0x04002230 RID: 8752
		public const int NewPlayerSupportActivityV2PbFieldNumber = 114;

		// Token: 0x04002231 RID: 8753
		public const int ThroughTrainActivityDataFieldNumber = 115;

		// Token: 0x04002232 RID: 8754
		public const int RoverRogueActivityDataFieldNumber = 116;

		// Token: 0x04002233 RID: 8755
		public const int DangoBrawlActivityInfoFieldNumber = 117;

		// Token: 0x04002234 RID: 8756
		public const int QingXiaoActivityInfoFieldNumber = 118;

		// Token: 0x04002235 RID: 8757
		public const int MatchThreeActivityInfoFieldNumber = 120;

		// Token: 0x04002236 RID: 8758
		public const int GiantActivityInfoFieldNumber = 121;

		// Token: 0x04002237 RID: 8759
		private object data_;

		// Token: 0x04002238 RID: 8760
		private ActivityData.DataOneofCase dataCase_;

		// Token: 0x020016D5 RID: 5845
		public enum DataOneofCase
		{
			// Token: 0x0400C4A8 RID: 50344
			None,
			// Token: 0x0400C4A9 RID: 50345
			ParkourActivity = 10,
			// Token: 0x0400C4AA RID: 50346
			SignActivity,
			// Token: 0x0400C4AB RID: 50347
			NewBieCourseActivity,
			// Token: 0x0400C4AC RID: 50348
			DoubleInstActivityReward,
			// Token: 0x0400C4AD RID: 50349
			HarvestActivity,
			// Token: 0x0400C4AE RID: 50350
			RoleTrialInfoActivity,
			// Token: 0x0400C4AF RID: 50351
			PhantomCollectActivity,
			// Token: 0x0400C4B0 RID: 50352
			GatherActivityInfo,
			// Token: 0x0400C4B1 RID: 50353
			DailyAdventureActivityData,
			// Token: 0x0400C4B2 RID: 50354
			RoguelikeActivityData,
			// Token: 0x0400C4B3 RID: 50355
			LongShanActivityData,
			// Token: 0x0400C4B4 RID: 50356
			TurntableActivityData,
			// Token: 0x0400C4B5 RID: 50357
			BossRushActivityData,
			// Token: 0x0400C4B6 RID: 50358
			TrackMoonActivityTaskData,
			// Token: 0x0400C4B7 RID: 50359
			TimePointRewardActivityData,
			// Token: 0x0400C4B8 RID: 50360
			TowerDefenceActivityData,
			// Token: 0x0400C4B9 RID: 50361
			CircumFluenceTaskData,
			// Token: 0x0400C4BA RID: 50362
			TraceMoonPhaseData,
			// Token: 0x0400C4BB RID: 50363
			CorniceMeetingData,
			// Token: 0x0400C4BC RID: 50364
			RiskHarvestActivityInfo,
			// Token: 0x0400C4BD RID: 50365
			BlackCoastThemeActivityData = 31,
			// Token: 0x0400C4BE RID: 50366
			RogueWhiteCatData,
			// Token: 0x0400C4BF RID: 50367
			ScratchCardActivityInfo = 34,
			// Token: 0x0400C4C0 RID: 50368
			PreheatSignActivityInfo,
			// Token: 0x0400C4C1 RID: 50369
			MowTowerActivityInfo,
			// Token: 0x0400C4C2 RID: 50370
			FarmGoldInfo,
			// Token: 0x0400C4C3 RID: 50371
			SpringSignInfo,
			// Token: 0x0400C4C4 RID: 50372
			MapTravelActivityInfo,
			// Token: 0x0400C4C5 RID: 50373
			RoleSkinTrialInfoActivity,
			// Token: 0x0400C4C6 RID: 50374
			FishingActivityInfo,
			// Token: 0x0400C4C7 RID: 50375
			RogueWeeklyData = 43,
			// Token: 0x0400C4C8 RID: 50376
			TeamParkourLevelActivityInfo,
			// Token: 0x0400C4C9 RID: 50377
			BabelActivityInfo,
			// Token: 0x0400C4CA RID: 50378
			RacingBetsData,
			// Token: 0x0400C4CB RID: 50379
			ExploreActivityInfo,
			// Token: 0x0400C4CC RID: 50380
			RogueResActivityData,
			// Token: 0x0400C4CD RID: 50381
			AvignonActivityInfo,
			// Token: 0x0400C4CE RID: 50382
			AbyssInfo,
			// Token: 0x0400C4CF RID: 50383
			H5CircumFluenceData,
			// Token: 0x0400C4D0 RID: 50384
			DangoMonopolyActivityData,
			// Token: 0x0400C4D1 RID: 50385
			CiacconaActivityPbData,
			// Token: 0x0400C4D2 RID: 50386
			ActivityLinkageData,
			// Token: 0x0400C4D3 RID: 50387
			RegressData,
			// Token: 0x0400C4D4 RID: 50388
			ConsumptiveActivityInfo,
			// Token: 0x0400C4D5 RID: 50389
			PhantomBattleActivityInfo,
			// Token: 0x0400C4D6 RID: 50390
			NewbieCarnivalData,
			// Token: 0x0400C4D7 RID: 50391
			MoraleActivityData,
			// Token: 0x0400C4D8 RID: 50392
			FloroRanchActivityData,
			// Token: 0x0400C4D9 RID: 50393
			LifePointChallenge,
			// Token: 0x0400C4DA RID: 50394
			TrapDefenseActivityInfo,
			// Token: 0x0400C4DB RID: 50395
			FunPlayActivityInfo,
			// Token: 0x0400C4DC RID: 50396
			JinzhouFlyData,
			// Token: 0x0400C4DD RID: 50397
			LineCrossActivityData,
			// Token: 0x0400C4DE RID: 50398
			MoonPhaseActivityData,
			// Token: 0x0400C4DF RID: 50399
			HonamiStoryActivityInfo = 71,
			// Token: 0x0400C4E0 RID: 50400
			PhotoFightActivityData,
			// Token: 0x0400C4E1 RID: 50401
			SurvivorsActivityData,
			// Token: 0x0400C4E2 RID: 50402
			WuWuKujiActivityInfo,
			// Token: 0x0400C4E3 RID: 50403
			AdvertisingPageInfo,
			// Token: 0x0400C4E4 RID: 50404
			ArtemisActivityInfo,
			// Token: 0x0400C4E5 RID: 50405
			RoleCoopActivityData,
			// Token: 0x0400C4E6 RID: 50406
			MotorCycleIpActivityData,
			// Token: 0x0400C4E7 RID: 50407
			PhantomBattleRecordActivityInfo,
			// Token: 0x0400C4E8 RID: 50408
			InfrThemeActivityPb,
			// Token: 0x0400C4E9 RID: 50409
			RoadBookActivityInfo,
			// Token: 0x0400C4EA RID: 50410
			PhantomBattleGuideActivity,
			// Token: 0x0400C4EB RID: 50411
			NewTowerClimbingActivityData,
			// Token: 0x0400C4EC RID: 50412
			NewPlayerSupportActivityData,
			// Token: 0x0400C4ED RID: 50413
			MotorParkourActivityInfo,
			// Token: 0x0400C4EE RID: 50414
			SpringFestivalActivityInfo,
			// Token: 0x0400C4EF RID: 50415
			TotalTopUpActivityInfo,
			// Token: 0x0400C4F0 RID: 50416
			MotorFightActivityPb,
			// Token: 0x0400C4F1 RID: 50417
			H5ViewActivityData,
			// Token: 0x0400C4F2 RID: 50418
			SkinRewardActivityData,
			// Token: 0x0400C4F3 RID: 50419
			EncircleActivityPb,
			// Token: 0x0400C4F4 RID: 50420
			MotorDevelopActivityData,
			// Token: 0x0400C4F5 RID: 50421
			FlagChallengeActivityInfo,
			// Token: 0x0400C4F6 RID: 50422
			FeiXuePreheatActivityInfo,
			// Token: 0x0400C4F7 RID: 50423
			RhythmActivityPb,
			// Token: 0x0400C4F8 RID: 50424
			DropCatchActivityInfo,
			// Token: 0x0400C4F9 RID: 50425
			TetrisActivityInfo,
			// Token: 0x0400C4FA RID: 50426
			PinballActivityData,
			// Token: 0x0400C4FB RID: 50427
			BossPilingActivityInfo,
			// Token: 0x0400C4FC RID: 50428
			ThemeCelebration,
			// Token: 0x0400C4FD RID: 50429
			WuWuWeekActivity,
			// Token: 0x0400C4FE RID: 50430
			MotorDecalActivityData,
			// Token: 0x0400C4FF RID: 50431
			LinkageCheckInActivityData,
			// Token: 0x0400C500 RID: 50432
			RoleGiftActivityData,
			// Token: 0x0400C501 RID: 50433
			KurotatoActivityData,
			// Token: 0x0400C502 RID: 50434
			GolemCrackActivityInfo,
			// Token: 0x0400C503 RID: 50435
			EdgeRunnerActivityInfo,
			// Token: 0x0400C504 RID: 50436
			OnlineMotorActivityData,
			// Token: 0x0400C505 RID: 50437
			RealmBetweenActivityInfo,
			// Token: 0x0400C506 RID: 50438
			ThroughTrainSummaryActivityData,
			// Token: 0x0400C507 RID: 50439
			NewbieMainActivityPb,
			// Token: 0x0400C508 RID: 50440
			NewbieCourseV2ActivityPb,
			// Token: 0x0400C509 RID: 50441
			NewbieAdventureV2Pb,
			// Token: 0x0400C50A RID: 50442
			NewPlayerSupportActivityV2Pb,
			// Token: 0x0400C50B RID: 50443
			ThroughTrainActivityData,
			// Token: 0x0400C50C RID: 50444
			RoverRogueActivityData,
			// Token: 0x0400C50D RID: 50445
			DangoBrawlActivityInfo,
			// Token: 0x0400C50E RID: 50446
			QingXiaoActivityInfo,
			// Token: 0x0400C50F RID: 50447
			MatchThreeActivityInfo = 120,
			// Token: 0x0400C510 RID: 50448
			GiantActivityInfo
		}
	}
}
