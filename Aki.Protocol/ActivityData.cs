using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000084 RID: 132
	public sealed class ActivityData : IMessage<ActivityData>, IMessage, IEquatable<ActivityData>, IDeepCloneable<ActivityData>, IBufferMessage
	{
		// Token: 0x06001950 RID: 6480 RVA: 0x00042590 File Offset: 0x00040790
		[NullableContext(1)]
		public static ActivityData Create()
		{
			return new ActivityData();
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00042597 File Offset: 0x00040797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityData> Parser
		{
			get
			{
				return ActivityData._parser;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0004259E File Offset: 0x0004079E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000425A1 File Offset: 0x000407A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityData.Descriptor;
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000425A8 File Offset: 0x000407A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData()
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000425C8 File Offset: 0x000407C8
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
			case ActivityData.DataOneofCase.SolarSchoolActivityPb:
				this.SolarSchoolActivityPb = other.SolarSchoolActivityPb.Clone();
				break;
			case ActivityData.DataOneofCase.RoleTowerActivityData:
				this.RoleTowerActivityData = other.RoleTowerActivityData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00043198 File Offset: 0x00041398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData Clone()
		{
			return new ActivityData(this);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x000431A0 File Offset: 0x000413A0
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x000431A8 File Offset: 0x000413A8
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x000431B1 File Offset: 0x000413B1
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x000431B9 File Offset: 0x000413B9
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000431C2 File Offset: 0x000413C2
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x000431CA File Offset: 0x000413CA
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000431D3 File Offset: 0x000413D3
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x000431DB File Offset: 0x000413DB
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x000431E4 File Offset: 0x000413E4
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x000431EC File Offset: 0x000413EC
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x000431F5 File Offset: 0x000413F5
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x000431FD File Offset: 0x000413FD
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x00043206 File Offset: 0x00041406
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x0004320E File Offset: 0x0004140E
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x00043217 File Offset: 0x00041417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletePreQuests
		{
			get
			{
				return this.completePreQuests_;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0004321F File Offset: 0x0004141F
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00043227 File Offset: 0x00041427
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

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00043230 File Offset: 0x00041430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00043238 File Offset: 0x00041438
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x00043240 File Offset: 0x00041440
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00043249 File Offset: 0x00041449
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x00043251 File Offset: 0x00041451
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x0004325A File Offset: 0x0004145A
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x00043262 File Offset: 0x00041462
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x0004326B File Offset: 0x0004146B
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x00043273 File Offset: 0x00041473
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0004327C File Offset: 0x0004147C
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x00043284 File Offset: 0x00041484
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0004328D File Offset: 0x0004148D
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00043295 File Offset: 0x00041495
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0004329E File Offset: 0x0004149E
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x000432B7 File Offset: 0x000414B7
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000432CE File Offset: 0x000414CE
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x000432E7 File Offset: 0x000414E7
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000432FE File Offset: 0x000414FE
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x00043317 File Offset: 0x00041517
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0004332E File Offset: 0x0004152E
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00043347 File Offset: 0x00041547
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x0004335E File Offset: 0x0004155E
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x00043377 File Offset: 0x00041577
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0004338E File Offset: 0x0004158E
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x000433A7 File Offset: 0x000415A7
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x000433BE File Offset: 0x000415BE
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x000433D7 File Offset: 0x000415D7
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

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x000433EE File Offset: 0x000415EE
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x00043407 File Offset: 0x00041607
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0004341E File Offset: 0x0004161E
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x00043437 File Offset: 0x00041637
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0004344E File Offset: 0x0004164E
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00043467 File Offset: 0x00041667
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0004347E File Offset: 0x0004167E
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00043497 File Offset: 0x00041697
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x000434AE File Offset: 0x000416AE
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x000434C7 File Offset: 0x000416C7
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x000434DE File Offset: 0x000416DE
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x000434F7 File Offset: 0x000416F7
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0004350E File Offset: 0x0004170E
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00043527 File Offset: 0x00041727
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0004353E File Offset: 0x0004173E
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x00043557 File Offset: 0x00041757
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0004356E File Offset: 0x0004176E
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00043587 File Offset: 0x00041787
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0004359E File Offset: 0x0004179E
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x000435B7 File Offset: 0x000417B7
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x000435CE File Offset: 0x000417CE
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x000435E7 File Offset: 0x000417E7
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x000435FE File Offset: 0x000417FE
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x00043617 File Offset: 0x00041817
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

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0004362E File Offset: 0x0004182E
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x00043647 File Offset: 0x00041847
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

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x0004365E File Offset: 0x0004185E
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00043677 File Offset: 0x00041877
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x0004368E File Offset: 0x0004188E
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x000436A7 File Offset: 0x000418A7
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000436BE File Offset: 0x000418BE
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x000436D7 File Offset: 0x000418D7
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000436EE File Offset: 0x000418EE
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x00043707 File Offset: 0x00041907
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x0004371E File Offset: 0x0004191E
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00043737 File Offset: 0x00041937
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0004374E File Offset: 0x0004194E
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x00043767 File Offset: 0x00041967
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0004377E File Offset: 0x0004197E
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00043797 File Offset: 0x00041997
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

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000437AE File Offset: 0x000419AE
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x000437C7 File Offset: 0x000419C7
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x000437DE File Offset: 0x000419DE
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x000437F7 File Offset: 0x000419F7
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x0004380E File Offset: 0x00041A0E
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x00043827 File Offset: 0x00041A27
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x0004383E File Offset: 0x00041A3E
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x00043857 File Offset: 0x00041A57
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x0004386E File Offset: 0x00041A6E
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00043887 File Offset: 0x00041A87
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0004389E File Offset: 0x00041A9E
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x000438B7 File Offset: 0x00041AB7
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x000438CE File Offset: 0x00041ACE
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x000438E7 File Offset: 0x00041AE7
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x000438FE File Offset: 0x00041AFE
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00043917 File Offset: 0x00041B17
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0004392E File Offset: 0x00041B2E
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00043947 File Offset: 0x00041B47
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0004395E File Offset: 0x00041B5E
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00043977 File Offset: 0x00041B77
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0004398E File Offset: 0x00041B8E
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x000439A7 File Offset: 0x00041BA7
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x000439BE File Offset: 0x00041BBE
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x000439D7 File Offset: 0x00041BD7
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x000439EE File Offset: 0x00041BEE
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x00043A07 File Offset: 0x00041C07
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00043A1E File Offset: 0x00041C1E
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x00043A37 File Offset: 0x00041C37
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00043A4E File Offset: 0x00041C4E
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x00043A67 File Offset: 0x00041C67
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00043A7E File Offset: 0x00041C7E
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x00043A97 File Offset: 0x00041C97
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00043AAE File Offset: 0x00041CAE
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00043AC7 File Offset: 0x00041CC7
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00043ADE File Offset: 0x00041CDE
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00043AF7 File Offset: 0x00041CF7
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00043B0E File Offset: 0x00041D0E
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00043B27 File Offset: 0x00041D27
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00043B3E File Offset: 0x00041D3E
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x00043B57 File Offset: 0x00041D57
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00043B6E File Offset: 0x00041D6E
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x00043B87 File Offset: 0x00041D87
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

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00043B9E File Offset: 0x00041D9E
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x00043BB7 File Offset: 0x00041DB7
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00043BCE File Offset: 0x00041DCE
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x00043BE7 File Offset: 0x00041DE7
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00043BFE File Offset: 0x00041DFE
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00043C17 File Offset: 0x00041E17
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00043C2E File Offset: 0x00041E2E
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00043C47 File Offset: 0x00041E47
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x00043C5E File Offset: 0x00041E5E
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x00043C77 File Offset: 0x00041E77
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00043C8E File Offset: 0x00041E8E
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00043CA7 File Offset: 0x00041EA7
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00043CBE File Offset: 0x00041EBE
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x00043CD7 File Offset: 0x00041ED7
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00043CEE File Offset: 0x00041EEE
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x00043D07 File Offset: 0x00041F07
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00043D1E File Offset: 0x00041F1E
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x00043D37 File Offset: 0x00041F37
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00043D4E File Offset: 0x00041F4E
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x00043D67 File Offset: 0x00041F67
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00043D7E File Offset: 0x00041F7E
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x00043D97 File Offset: 0x00041F97
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00043DAE File Offset: 0x00041FAE
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00043DC7 File Offset: 0x00041FC7
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00043DDE File Offset: 0x00041FDE
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x00043DF7 File Offset: 0x00041FF7
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00043E0E File Offset: 0x0004200E
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x00043E27 File Offset: 0x00042027
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x00043E3E File Offset: 0x0004203E
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x00043E57 File Offset: 0x00042057
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x00043E6E File Offset: 0x0004206E
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x00043E87 File Offset: 0x00042087
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00043E9E File Offset: 0x0004209E
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x00043EB7 File Offset: 0x000420B7
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00043ECE File Offset: 0x000420CE
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x00043EE7 File Offset: 0x000420E7
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00043EFE File Offset: 0x000420FE
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x00043F17 File Offset: 0x00042117
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

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00043F2E File Offset: 0x0004212E
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x00043F47 File Offset: 0x00042147
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00043F5E File Offset: 0x0004215E
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x00043F77 File Offset: 0x00042177
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00043F8E File Offset: 0x0004218E
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00043FA7 File Offset: 0x000421A7
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00043FBE File Offset: 0x000421BE
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00043FD7 File Offset: 0x000421D7
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00043FEE File Offset: 0x000421EE
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x00044007 File Offset: 0x00042207
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0004401E File Offset: 0x0004221E
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x00044037 File Offset: 0x00042237
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0004404E File Offset: 0x0004224E
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x00044067 File Offset: 0x00042267
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0004407E File Offset: 0x0004227E
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x00044097 File Offset: 0x00042297
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x000440AE File Offset: 0x000422AE
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x000440C7 File Offset: 0x000422C7
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x000440DE File Offset: 0x000422DE
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x000440F7 File Offset: 0x000422F7
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0004410E File Offset: 0x0004230E
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00044127 File Offset: 0x00042327
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0004413E File Offset: 0x0004233E
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00044157 File Offset: 0x00042357
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0004416E File Offset: 0x0004236E
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00044187 File Offset: 0x00042387
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0004419E File Offset: 0x0004239E
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x000441B7 File Offset: 0x000423B7
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x000441CE File Offset: 0x000423CE
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x000441E7 File Offset: 0x000423E7
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x000441FE File Offset: 0x000423FE
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00044217 File Offset: 0x00042417
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0004422E File Offset: 0x0004242E
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x00044247 File Offset: 0x00042447
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0004425E File Offset: 0x0004245E
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x00044277 File Offset: 0x00042477
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0004428E File Offset: 0x0004248E
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x000442A7 File Offset: 0x000424A7
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000442BE File Offset: 0x000424BE
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x000442D7 File Offset: 0x000424D7
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x000442EE File Offset: 0x000424EE
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00044307 File Offset: 0x00042507
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0004431E File Offset: 0x0004251E
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x00044337 File Offset: 0x00042537
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0004434E File Offset: 0x0004254E
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x00044367 File Offset: 0x00042567
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0004437E File Offset: 0x0004257E
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x00044397 File Offset: 0x00042597
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000443AE File Offset: 0x000425AE
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x000443C7 File Offset: 0x000425C7
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x000443DE File Offset: 0x000425DE
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x000443F7 File Offset: 0x000425F7
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

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0004440E File Offset: 0x0004260E
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x00044427 File Offset: 0x00042627
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0004443E File Offset: 0x0004263E
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00044457 File Offset: 0x00042657
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0004446E File Offset: 0x0004266E
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00044487 File Offset: 0x00042687
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0004449E File Offset: 0x0004269E
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x000444B7 File Offset: 0x000426B7
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000444CE File Offset: 0x000426CE
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x000444E7 File Offset: 0x000426E7
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x000444FE File Offset: 0x000426FE
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x00044517 File Offset: 0x00042717
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

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0004452E File Offset: 0x0004272E
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00044547 File Offset: 0x00042747
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

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0004455E File Offset: 0x0004275E
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00044577 File Offset: 0x00042777
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0004458E File Offset: 0x0004278E
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x000445A7 File Offset: 0x000427A7
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x000445BE File Offset: 0x000427BE
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x000445D7 File Offset: 0x000427D7
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x000445EE File Offset: 0x000427EE
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00044607 File Offset: 0x00042807
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x0004461E File Offset: 0x0004281E
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00044637 File Offset: 0x00042837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolActivityPb SolarSchoolActivityPb
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.SolarSchoolActivityPb)
				{
					return null;
				}
				return (SolarSchoolActivityPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.SolarSchoolActivityPb);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0004464E File Offset: 0x0004284E
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00044667 File Offset: 0x00042867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerActivityData RoleTowerActivityData
		{
			get
			{
				if (this.dataCase_ != ActivityData.DataOneofCase.RoleTowerActivityData)
				{
					return null;
				}
				return (RoleTowerActivityData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityData.DataOneofCase.None : ActivityData.DataOneofCase.RoleTowerActivityData);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0004467E File Offset: 0x0004287E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00044686 File Offset: 0x00042886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ActivityData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00044696 File Offset: 0x00042896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityData);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000446A4 File Offset: 0x000428A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && this.BeginShowTime == other.BeginShowTime && this.EndShowTime == other.EndShowTime && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && this.IsUnlock == other.IsUnlock && this.completePreQuests_.Equals(other.completePreQuests_) && this.IsFirstOpen == other.IsFirstOpen && this.finishConditions_.Equals(other.finishConditions_) && this.ActivityOpenType == other.ActivityOpenType && this.CanPreOpen == other.CanPreOpen && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && this.LimitRewardBeginTime == other.LimitRewardBeginTime && this.LimitRewardEndTime == other.LimitRewardEndTime && object.Equals(this.ParkourActivity, other.ParkourActivity) && object.Equals(this.SignActivity, other.SignActivity) && object.Equals(this.NewBieCourseActivity, other.NewBieCourseActivity) && object.Equals(this.DoubleInstActivityReward, other.DoubleInstActivityReward) && object.Equals(this.HarvestActivity, other.HarvestActivity) && object.Equals(this.RoleTrialInfoActivity, other.RoleTrialInfoActivity) && object.Equals(this.PhantomCollectActivity, other.PhantomCollectActivity) && object.Equals(this.GatherActivityInfo, other.GatherActivityInfo) && object.Equals(this.DailyAdventureActivityData, other.DailyAdventureActivityData) && object.Equals(this.RoguelikeActivityData, other.RoguelikeActivityData) && object.Equals(this.LongShanActivityData, other.LongShanActivityData) && object.Equals(this.TurntableActivityData, other.TurntableActivityData) && object.Equals(this.BossRushActivityData, other.BossRushActivityData) && object.Equals(this.TrackMoonActivityTaskData, other.TrackMoonActivityTaskData) && object.Equals(this.TimePointRewardActivityData, other.TimePointRewardActivityData) && object.Equals(this.TowerDefenceActivityData, other.TowerDefenceActivityData) && object.Equals(this.CircumFluenceTaskData, other.CircumFluenceTaskData) && object.Equals(this.TraceMoonPhaseData, other.TraceMoonPhaseData) && object.Equals(this.CorniceMeetingData, other.CorniceMeetingData) && object.Equals(this.RiskHarvestActivityInfo, other.RiskHarvestActivityInfo) && object.Equals(this.BlackCoastThemeActivityData, other.BlackCoastThemeActivityData) && object.Equals(this.RogueWhiteCatData, other.RogueWhiteCatData) && object.Equals(this.ScratchCardActivityInfo, other.ScratchCardActivityInfo) && object.Equals(this.PreheatSignActivityInfo, other.PreheatSignActivityInfo) && object.Equals(this.MowTowerActivityInfo, other.MowTowerActivityInfo) && object.Equals(this.FarmGoldInfo, other.FarmGoldInfo) && object.Equals(this.SpringSignInfo, other.SpringSignInfo) && object.Equals(this.MapTravelActivityInfo, other.MapTravelActivityInfo) && object.Equals(this.RoleSkinTrialInfoActivity, other.RoleSkinTrialInfoActivity) && object.Equals(this.FishingActivityInfo, other.FishingActivityInfo) && object.Equals(this.RogueWeeklyData, other.RogueWeeklyData) && object.Equals(this.TeamParkourLevelActivityInfo, other.TeamParkourLevelActivityInfo) && object.Equals(this.BabelActivityInfo, other.BabelActivityInfo) && object.Equals(this.RacingBetsData, other.RacingBetsData) && object.Equals(this.ExploreActivityInfo, other.ExploreActivityInfo) && object.Equals(this.RogueResActivityData, other.RogueResActivityData) && object.Equals(this.AvignonActivityInfo, other.AvignonActivityInfo) && object.Equals(this.AbyssInfo, other.AbyssInfo) && object.Equals(this.H5CircumFluenceData, other.H5CircumFluenceData) && object.Equals(this.DangoMonopolyActivityData, other.DangoMonopolyActivityData) && object.Equals(this.CiacconaActivityPbData, other.CiacconaActivityPbData) && object.Equals(this.ActivityLinkageData, other.ActivityLinkageData) && object.Equals(this.RegressData, other.RegressData) && object.Equals(this.ConsumptiveActivityInfo, other.ConsumptiveActivityInfo) && object.Equals(this.PhantomBattleActivityInfo, other.PhantomBattleActivityInfo) && object.Equals(this.NewbieCarnivalData, other.NewbieCarnivalData) && object.Equals(this.MoraleActivityData, other.MoraleActivityData) && object.Equals(this.FloroRanchActivityData, other.FloroRanchActivityData) && object.Equals(this.LifePointChallenge, other.LifePointChallenge) && object.Equals(this.TrapDefenseActivityInfo, other.TrapDefenseActivityInfo) && object.Equals(this.FunPlayActivityInfo, other.FunPlayActivityInfo) && object.Equals(this.JinzhouFlyData, other.JinzhouFlyData) && object.Equals(this.LineCrossActivityData, other.LineCrossActivityData) && object.Equals(this.MoonPhaseActivityData, other.MoonPhaseActivityData) && object.Equals(this.HonamiStoryActivityInfo, other.HonamiStoryActivityInfo) && object.Equals(this.PhotoFightActivityData, other.PhotoFightActivityData) && object.Equals(this.SurvivorsActivityData, other.SurvivorsActivityData) && object.Equals(this.WuWuKujiActivityInfo, other.WuWuKujiActivityInfo) && object.Equals(this.AdvertisingPageInfo, other.AdvertisingPageInfo) && object.Equals(this.ArtemisActivityInfo, other.ArtemisActivityInfo) && object.Equals(this.RoleCoopActivityData, other.RoleCoopActivityData) && object.Equals(this.MotorCycleIpActivityData, other.MotorCycleIpActivityData) && object.Equals(this.PhantomBattleRecordActivityInfo, other.PhantomBattleRecordActivityInfo) && object.Equals(this.InfrThemeActivityPb, other.InfrThemeActivityPb) && object.Equals(this.RoadBookActivityInfo, other.RoadBookActivityInfo) && object.Equals(this.PhantomBattleGuideActivity, other.PhantomBattleGuideActivity) && object.Equals(this.NewTowerClimbingActivityData, other.NewTowerClimbingActivityData) && object.Equals(this.NewPlayerSupportActivityData, other.NewPlayerSupportActivityData) && object.Equals(this.MotorParkourActivityInfo, other.MotorParkourActivityInfo) && object.Equals(this.SpringFestivalActivityInfo, other.SpringFestivalActivityInfo) && object.Equals(this.TotalTopUpActivityInfo, other.TotalTopUpActivityInfo) && object.Equals(this.MotorFightActivityPb, other.MotorFightActivityPb) && object.Equals(this.H5ViewActivityData, other.H5ViewActivityData) && object.Equals(this.SkinRewardActivityData, other.SkinRewardActivityData) && object.Equals(this.EncircleActivityPb, other.EncircleActivityPb) && object.Equals(this.MotorDevelopActivityData, other.MotorDevelopActivityData) && object.Equals(this.FlagChallengeActivityInfo, other.FlagChallengeActivityInfo) && object.Equals(this.FeiXuePreheatActivityInfo, other.FeiXuePreheatActivityInfo) && object.Equals(this.RhythmActivityPb, other.RhythmActivityPb) && object.Equals(this.DropCatchActivityInfo, other.DropCatchActivityInfo) && object.Equals(this.TetrisActivityInfo, other.TetrisActivityInfo) && object.Equals(this.PinballActivityData, other.PinballActivityData) && object.Equals(this.BossPilingActivityInfo, other.BossPilingActivityInfo) && object.Equals(this.ThemeCelebration, other.ThemeCelebration) && object.Equals(this.WuWuWeekActivity, other.WuWuWeekActivity) && object.Equals(this.MotorDecalActivityData, other.MotorDecalActivityData) && object.Equals(this.LinkageCheckInActivityData, other.LinkageCheckInActivityData) && object.Equals(this.RoleGiftActivityData, other.RoleGiftActivityData) && object.Equals(this.KurotatoActivityData, other.KurotatoActivityData) && object.Equals(this.GolemCrackActivityInfo, other.GolemCrackActivityInfo) && object.Equals(this.EdgeRunnerActivityInfo, other.EdgeRunnerActivityInfo) && object.Equals(this.OnlineMotorActivityData, other.OnlineMotorActivityData) && object.Equals(this.RealmBetweenActivityInfo, other.RealmBetweenActivityInfo) && object.Equals(this.ThroughTrainSummaryActivityData, other.ThroughTrainSummaryActivityData) && object.Equals(this.NewbieMainActivityPb, other.NewbieMainActivityPb) && object.Equals(this.NewbieCourseV2ActivityPb, other.NewbieCourseV2ActivityPb) && object.Equals(this.NewbieAdventureV2Pb, other.NewbieAdventureV2Pb) && object.Equals(this.NewPlayerSupportActivityV2Pb, other.NewPlayerSupportActivityV2Pb) && object.Equals(this.ThroughTrainActivityData, other.ThroughTrainActivityData) && object.Equals(this.RoverRogueActivityData, other.RoverRogueActivityData) && object.Equals(this.DangoBrawlActivityInfo, other.DangoBrawlActivityInfo) && object.Equals(this.QingXiaoActivityInfo, other.QingXiaoActivityInfo) && object.Equals(this.MatchThreeActivityInfo, other.MatchThreeActivityInfo) && object.Equals(this.GiantActivityInfo, other.GiantActivityInfo) && object.Equals(this.SolarSchoolActivityPb, other.SolarSchoolActivityPb) && object.Equals(this.RoleTowerActivityData, other.RoleTowerActivityData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0004509C File Offset: 0x0004329C
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
			if (this.dataCase_ == ActivityData.DataOneofCase.SolarSchoolActivityPb)
			{
				num ^= this.SolarSchoolActivityPb.GetHashCode();
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTowerActivityData)
			{
				num ^= this.RoleTowerActivityData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00045C45 File Offset: 0x00043E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00045C52 File Offset: 0x00043E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00045C5C File Offset: 0x00043E5C
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
			if (this.dataCase_ == ActivityData.DataOneofCase.SolarSchoolActivityPb)
			{
				output.WriteRawTag(210, 7);
				output.WriteMessage(this.SolarSchoolActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTowerActivityData)
			{
				output.WriteRawTag(218, 7);
				output.WriteMessage(this.RoleTowerActivityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00046C3C File Offset: 0x00044E3C
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
			if (this.dataCase_ == ActivityData.DataOneofCase.SolarSchoolActivityPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SolarSchoolActivityPb);
			}
			if (this.dataCase_ == ActivityData.DataOneofCase.RoleTowerActivityData)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleTowerActivityData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00047878 File Offset: 0x00045A78
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
			case ActivityData.DataOneofCase.SolarSchoolActivityPb:
				if (this.SolarSchoolActivityPb == null)
				{
					this.SolarSchoolActivityPb = new SolarSchoolActivityPb();
				}
				this.SolarSchoolActivityPb.MergeFrom(other.SolarSchoolActivityPb);
				break;
			case ActivityData.DataOneofCase.RoleTowerActivityData:
				if (this.RoleTowerActivityData == null)
				{
					this.RoleTowerActivityData = new RoleTowerActivityData();
				}
				this.RoleTowerActivityData.MergeFrom(other.RoleTowerActivityData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00048CA3 File Offset: 0x00046EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00048CAC File Offset: 0x00046EAC
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
				if (num <= 482U)
				{
					if (num <= 240U)
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
									if (num != 24U)
									{
										goto IL_82E;
									}
									this.BeginShowTime = input.ReadInt64();
									continue;
								}
								else if (num <= 40U)
								{
									if (num == 32U)
									{
										this.EndShowTime = input.ReadInt64();
										continue;
									}
									if (num != 40U)
									{
										goto IL_82E;
									}
									this.BeginOpenTime = input.ReadInt64();
									continue;
								}
								else
								{
									if (num == 48U)
									{
										this.EndOpenTime = input.ReadInt64();
										continue;
									}
									if (num != 56U)
									{
										goto IL_82E;
									}
									this.IsUnlock = input.ReadBool();
									continue;
								}
							}
							else if (num <= 82U)
							{
								if (num <= 66U)
								{
									if (num != 64U && num != 66U)
									{
										goto IL_82E;
									}
									this.completePreQuests_.AddEntriesFrom(ref input, ActivityData._repeated_completePreQuests_codec);
									continue;
								}
								else
								{
									if (num == 72U)
									{
										this.IsFirstOpen = input.ReadBool();
										continue;
									}
									if (num != 82U)
									{
										goto IL_82E;
									}
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
								if (num != 98U)
								{
									goto IL_82E;
								}
								NewBieCourseActivity newBieCourseActivity = new NewBieCourseActivity();
								if (this.dataCase_ == ActivityData.DataOneofCase.NewBieCourseActivity)
								{
									newBieCourseActivity.MergeFrom(this.NewBieCourseActivity);
								}
								input.ReadMessage(newBieCourseActivity);
								this.NewBieCourseActivity = newBieCourseActivity;
								continue;
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
								if (num != 114U)
								{
									goto IL_82E;
								}
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
						else if (num <= 178U)
						{
							if (num <= 146U)
							{
								if (num <= 130U)
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
									if (num != 130U)
									{
										goto IL_82E;
									}
									PhantomCollectActivity phantomCollectActivity = new PhantomCollectActivity();
									if (this.dataCase_ == ActivityData.DataOneofCase.PhantomCollectActivity)
									{
										phantomCollectActivity.MergeFrom(this.PhantomCollectActivity);
									}
									input.ReadMessage(phantomCollectActivity);
									this.PhantomCollectActivity = phantomCollectActivity;
									continue;
								}
								else
								{
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
									if (num != 146U)
									{
										goto IL_82E;
									}
									DailyAdventureActivityData dailyAdventureActivityData = new DailyAdventureActivityData();
									if (this.dataCase_ == ActivityData.DataOneofCase.DailyAdventureActivityData)
									{
										dailyAdventureActivityData.MergeFrom(this.DailyAdventureActivityData);
									}
									input.ReadMessage(dailyAdventureActivityData);
									this.DailyAdventureActivityData = dailyAdventureActivityData;
									continue;
								}
							}
							else if (num <= 162U)
							{
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
								if (num != 162U)
								{
									goto IL_82E;
								}
								LongShanActivity longShanActivity = new LongShanActivity();
								if (this.dataCase_ == ActivityData.DataOneofCase.LongShanActivityData)
								{
									longShanActivity.MergeFrom(this.LongShanActivityData);
								}
								input.ReadMessage(longShanActivity);
								this.LongShanActivityData = longShanActivity;
								continue;
							}
							else
							{
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
								if (num != 178U)
								{
									goto IL_82E;
								}
								BossRushActivityData bossRushActivityData = new BossRushActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.BossRushActivityData)
								{
									bossRushActivityData.MergeFrom(this.BossRushActivityData);
								}
								input.ReadMessage(bossRushActivityData);
								this.BossRushActivityData = bossRushActivityData;
								continue;
							}
						}
						else if (num <= 210U)
						{
							if (num <= 194U)
							{
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
								if (num != 194U)
								{
									goto IL_82E;
								}
								TimePointRewardActivityData timePointRewardActivityData = new TimePointRewardActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.TimePointRewardActivityData)
								{
									timePointRewardActivityData.MergeFrom(this.TimePointRewardActivityData);
								}
								input.ReadMessage(timePointRewardActivityData);
								this.TimePointRewardActivityData = timePointRewardActivityData;
								continue;
							}
							else
							{
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
								if (num != 210U)
								{
									goto IL_82E;
								}
								CircumFluenceData circumFluenceData = new CircumFluenceData();
								if (this.dataCase_ == ActivityData.DataOneofCase.CircumFluenceTaskData)
								{
									circumFluenceData.MergeFrom(this.CircumFluenceTaskData);
								}
								input.ReadMessage(circumFluenceData);
								this.CircumFluenceTaskData = circumFluenceData;
								continue;
							}
						}
						else if (num <= 226U)
						{
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
							if (num != 226U)
							{
								goto IL_82E;
							}
							CorniceMeetingData corniceMeetingData = new CorniceMeetingData();
							if (this.dataCase_ == ActivityData.DataOneofCase.CorniceMeetingData)
							{
								corniceMeetingData.MergeFrom(this.CorniceMeetingData);
							}
							input.ReadMessage(corniceMeetingData);
							this.CorniceMeetingData = corniceMeetingData;
							continue;
						}
						else
						{
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
							if (num != 240U)
							{
								goto IL_82E;
							}
						}
					}
					else if (num <= 354U)
					{
						if (num <= 290U)
						{
							if (num <= 258U)
							{
								if (num != 242U)
								{
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
									if (num != 258U)
									{
										goto IL_82E;
									}
									RogueWhiteCatData rogueWhiteCatData = new RogueWhiteCatData();
									if (this.dataCase_ == ActivityData.DataOneofCase.RogueWhiteCatData)
									{
										rogueWhiteCatData.MergeFrom(this.RogueWhiteCatData);
									}
									input.ReadMessage(rogueWhiteCatData);
									this.RogueWhiteCatData = rogueWhiteCatData;
									continue;
								}
							}
							else if (num <= 274U)
							{
								if (num == 264U)
								{
									this.ActivityOpenType = (ActivityOpenType)input.ReadEnum();
									continue;
								}
								if (num != 274U)
								{
									goto IL_82E;
								}
								ScratchCardActivityInfo scratchCardActivityInfo = new ScratchCardActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.ScratchCardActivityInfo)
								{
									scratchCardActivityInfo.MergeFrom(this.ScratchCardActivityInfo);
								}
								input.ReadMessage(scratchCardActivityInfo);
								this.ScratchCardActivityInfo = scratchCardActivityInfo;
								continue;
							}
							else
							{
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
								if (num != 290U)
								{
									goto IL_82E;
								}
								MowTowerActivityInfo mowTowerActivityInfo = new MowTowerActivityInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.MowTowerActivityInfo)
								{
									mowTowerActivityInfo.MergeFrom(this.MowTowerActivityInfo);
								}
								input.ReadMessage(mowTowerActivityInfo);
								this.MowTowerActivityInfo = mowTowerActivityInfo;
								continue;
							}
						}
						else if (num <= 322U)
						{
							if (num <= 306U)
							{
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
								if (num != 306U)
								{
									goto IL_82E;
								}
								SpringSignInfo springSignInfo = new SpringSignInfo();
								if (this.dataCase_ == ActivityData.DataOneofCase.SpringSignInfo)
								{
									springSignInfo.MergeFrom(this.SpringSignInfo);
								}
								input.ReadMessage(springSignInfo);
								this.SpringSignInfo = springSignInfo;
								continue;
							}
							else
							{
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
								if (num != 322U)
								{
									goto IL_82E;
								}
								RoleSkinTrialInfoActivity roleSkinTrialInfoActivity = new RoleSkinTrialInfoActivity();
								if (this.dataCase_ == ActivityData.DataOneofCase.RoleSkinTrialInfoActivity)
								{
									roleSkinTrialInfoActivity.MergeFrom(this.RoleSkinTrialInfoActivity);
								}
								input.ReadMessage(roleSkinTrialInfoActivity);
								this.RoleSkinTrialInfoActivity = roleSkinTrialInfoActivity;
								continue;
							}
						}
						else if (num <= 336U)
						{
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
							if (num != 336U)
							{
								goto IL_82E;
							}
							this.CanPreOpen = input.ReadBool();
							continue;
						}
						else
						{
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
							if (num != 354U)
							{
								goto IL_82E;
							}
							TeamParkourLevelActivityInfo teamParkourLevelActivityInfo = new TeamParkourLevelActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.TeamParkourLevelActivityInfo)
							{
								teamParkourLevelActivityInfo.MergeFrom(this.TeamParkourLevelActivityInfo);
							}
							input.ReadMessage(teamParkourLevelActivityInfo);
							this.TeamParkourLevelActivityInfo = teamParkourLevelActivityInfo;
							continue;
						}
					}
					else if (num <= 418U)
					{
						if (num <= 386U)
						{
							if (num <= 370U)
							{
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
								if (num != 370U)
								{
									goto IL_82E;
								}
								RacingBetsActivityData racingBetsActivityData = new RacingBetsActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RacingBetsData)
								{
									racingBetsActivityData.MergeFrom(this.RacingBetsData);
								}
								input.ReadMessage(racingBetsActivityData);
								this.RacingBetsData = racingBetsActivityData;
								continue;
							}
							else
							{
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
								if (num != 386U)
								{
									goto IL_82E;
								}
								RogueResActivityData rogueResActivityData = new RogueResActivityData();
								if (this.dataCase_ == ActivityData.DataOneofCase.RogueResActivityData)
								{
									rogueResActivityData.MergeFrom(this.RogueResActivityData);
								}
								input.ReadMessage(rogueResActivityData);
								this.RogueResActivityData = rogueResActivityData;
								continue;
							}
						}
						else if (num <= 402U)
						{
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
							if (num != 402U)
							{
								goto IL_82E;
							}
							AbyssInfo abyssInfo = new AbyssInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.AbyssInfo)
							{
								abyssInfo.MergeFrom(this.AbyssInfo);
							}
							input.ReadMessage(abyssInfo);
							this.AbyssInfo = abyssInfo;
							continue;
						}
						else
						{
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
							if (num != 418U)
							{
								goto IL_82E;
							}
							DangoMonopolyActivityPbData dangoMonopolyActivityPbData = new DangoMonopolyActivityPbData();
							if (this.dataCase_ == ActivityData.DataOneofCase.DangoMonopolyActivityData)
							{
								dangoMonopolyActivityPbData.MergeFrom(this.DangoMonopolyActivityData);
							}
							input.ReadMessage(dangoMonopolyActivityPbData);
							this.DangoMonopolyActivityData = dangoMonopolyActivityPbData;
							continue;
						}
					}
					else if (num <= 450U)
					{
						if (num <= 434U)
						{
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
							if (num != 434U)
							{
								goto IL_82E;
							}
							ActivityLinkageData activityLinkageData = new ActivityLinkageData();
							if (this.dataCase_ == ActivityData.DataOneofCase.ActivityLinkageData)
							{
								activityLinkageData.MergeFrom(this.ActivityLinkageData);
							}
							input.ReadMessage(activityLinkageData);
							this.ActivityLinkageData = activityLinkageData;
							continue;
						}
						else
						{
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
							if (num != 450U)
							{
								goto IL_82E;
							}
							ConsumptiveActivityInfo consumptiveActivityInfo = new ConsumptiveActivityInfo();
							if (this.dataCase_ == ActivityData.DataOneofCase.ConsumptiveActivityInfo)
							{
								consumptiveActivityInfo.MergeFrom(this.ConsumptiveActivityInfo);
							}
							input.ReadMessage(consumptiveActivityInfo);
							this.ConsumptiveActivityInfo = consumptiveActivityInfo;
							continue;
						}
					}
					else if (num <= 466U)
					{
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
						if (num != 466U)
						{
							goto IL_82E;
						}
						NewbieCarnivalData newbieCarnivalData = new NewbieCarnivalData();
						if (this.dataCase_ == ActivityData.DataOneofCase.NewbieCarnivalData)
						{
							newbieCarnivalData.MergeFrom(this.NewbieCarnivalData);
						}
						input.ReadMessage(newbieCarnivalData);
						this.NewbieCarnivalData = newbieCarnivalData;
						continue;
					}
					else
					{
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
						if (num != 482U)
						{
							goto IL_82E;
						}
						FloroRanchActivityData floroRanchActivityData = new FloroRanchActivityData();
						if (this.dataCase_ == ActivityData.DataOneofCase.FloroRanchActivityData)
						{
							floroRanchActivityData.MergeFrom(this.FloroRanchActivityData);
						}
						input.ReadMessage(floroRanchActivityData);
						this.FloroRanchActivityData = floroRanchActivityData;
						continue;
					}
					this.finishConditions_.AddEntriesFrom(ref input, ActivityData._repeated_finishConditions_codec);
					continue;
				}
				if (num <= 730U)
				{
					if (num <= 602U)
					{
						if (num <= 536U)
						{
							if (num <= 506U)
							{
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
							}
							else if (num <= 522U)
							{
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
							}
							else
							{
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
								if (num == 536U)
								{
									this.LimitBeginTime = input.ReadInt64();
									continue;
								}
							}
						}
						else if (num <= 570U)
						{
							if (num <= 552U)
							{
								if (num == 544U)
								{
									this.LimitEndTime = input.ReadInt64();
									continue;
								}
								if (num == 552U)
								{
									this.LimitRewardBeginTime = input.ReadInt64();
									continue;
								}
							}
							else
							{
								if (num == 560U)
								{
									this.LimitRewardEndTime = input.ReadInt64();
									continue;
								}
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
							}
						}
						else if (num <= 586U)
						{
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
						}
						else
						{
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
						}
					}
					else if (num <= 666U)
					{
						if (num <= 634U)
						{
							if (num <= 618U)
							{
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
							else
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
						}
						else if (num <= 650U)
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
						else
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
					}
					else if (num <= 698U)
					{
						if (num <= 682U)
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
						else
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
					}
					else if (num <= 714U)
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
					else
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
					}
				}
				else if (num <= 850U)
				{
					if (num <= 786U)
					{
						if (num <= 754U)
						{
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
						else if (num <= 770U)
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
						else
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
					}
					else if (num <= 818U)
					{
						if (num <= 802U)
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
						else
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
					}
					else if (num <= 834U)
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
					else
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
				}
				else if (num <= 914U)
				{
					if (num <= 882U)
					{
						if (num <= 866U)
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
						else
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
					}
					else if (num <= 898U)
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
					else
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
				}
				else if (num <= 946U)
				{
					if (num <= 930U)
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
					else
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
				}
				else if (num <= 970U)
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
				else
				{
					if (num == 978U)
					{
						SolarSchoolActivityPb solarSchoolActivityPb = new SolarSchoolActivityPb();
						if (this.dataCase_ == ActivityData.DataOneofCase.SolarSchoolActivityPb)
						{
							solarSchoolActivityPb.MergeFrom(this.SolarSchoolActivityPb);
						}
						input.ReadMessage(solarSchoolActivityPb);
						this.SolarSchoolActivityPb = solarSchoolActivityPb;
						continue;
					}
					if (num == 986U)
					{
						RoleTowerActivityData roleTowerActivityData = new RoleTowerActivityData();
						if (this.dataCase_ == ActivityData.DataOneofCase.RoleTowerActivityData)
						{
							roleTowerActivityData.MergeFrom(this.RoleTowerActivityData);
						}
						input.ReadMessage(roleTowerActivityData);
						this.RoleTowerActivityData = roleTowerActivityData;
						continue;
					}
				}
				IL_82E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400220A RID: 8714
		private static readonly MessageParser<ActivityData> _parser = new MessageParser<ActivityData>(() => new ActivityData());

		// Token: 0x0400220B RID: 8715
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400220C RID: 8716
		public const int IdFieldNumber = 1;

		// Token: 0x0400220D RID: 8717
		private int id_;

		// Token: 0x0400220E RID: 8718
		public const int TypeFieldNumber = 2;

		// Token: 0x0400220F RID: 8719
		private ActivityType type_;

		// Token: 0x04002210 RID: 8720
		public const int BeginShowTimeFieldNumber = 3;

		// Token: 0x04002211 RID: 8721
		private long beginShowTime_;

		// Token: 0x04002212 RID: 8722
		public const int EndShowTimeFieldNumber = 4;

		// Token: 0x04002213 RID: 8723
		private long endShowTime_;

		// Token: 0x04002214 RID: 8724
		public const int BeginOpenTimeFieldNumber = 5;

		// Token: 0x04002215 RID: 8725
		private long beginOpenTime_;

		// Token: 0x04002216 RID: 8726
		public const int EndOpenTimeFieldNumber = 6;

		// Token: 0x04002217 RID: 8727
		private long endOpenTime_;

		// Token: 0x04002218 RID: 8728
		public const int IsUnlockFieldNumber = 7;

		// Token: 0x04002219 RID: 8729
		private bool isUnlock_;

		// Token: 0x0400221A RID: 8730
		public const int CompletePreQuestsFieldNumber = 8;

		// Token: 0x0400221B RID: 8731
		private static readonly FieldCodec<int> _repeated_completePreQuests_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400221C RID: 8732
		private readonly RepeatedField<int> completePreQuests_ = new RepeatedField<int>();

		// Token: 0x0400221D RID: 8733
		public const int IsFirstOpenFieldNumber = 9;

		// Token: 0x0400221E RID: 8734
		private bool isFirstOpen_;

		// Token: 0x0400221F RID: 8735
		public const int FinishConditionsFieldNumber = 30;

		// Token: 0x04002220 RID: 8736
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(242U);

		// Token: 0x04002221 RID: 8737
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x04002222 RID: 8738
		public const int ActivityOpenTypeFieldNumber = 33;

		// Token: 0x04002223 RID: 8739
		private ActivityOpenType activityOpenType_;

		// Token: 0x04002224 RID: 8740
		public const int CanPreOpenFieldNumber = 42;

		// Token: 0x04002225 RID: 8741
		private bool canPreOpen_;

		// Token: 0x04002226 RID: 8742
		public const int LimitBeginTimeFieldNumber = 67;

		// Token: 0x04002227 RID: 8743
		private long limitBeginTime_;

		// Token: 0x04002228 RID: 8744
		public const int LimitEndTimeFieldNumber = 68;

		// Token: 0x04002229 RID: 8745
		private long limitEndTime_;

		// Token: 0x0400222A RID: 8746
		public const int LimitRewardBeginTimeFieldNumber = 69;

		// Token: 0x0400222B RID: 8747
		private long limitRewardBeginTime_;

		// Token: 0x0400222C RID: 8748
		public const int LimitRewardEndTimeFieldNumber = 70;

		// Token: 0x0400222D RID: 8749
		private long limitRewardEndTime_;

		// Token: 0x0400222E RID: 8750
		public const int ParkourActivityFieldNumber = 10;

		// Token: 0x0400222F RID: 8751
		public const int SignActivityFieldNumber = 11;

		// Token: 0x04002230 RID: 8752
		public const int NewBieCourseActivityFieldNumber = 12;

		// Token: 0x04002231 RID: 8753
		public const int DoubleInstActivityRewardFieldNumber = 13;

		// Token: 0x04002232 RID: 8754
		public const int HarvestActivityFieldNumber = 14;

		// Token: 0x04002233 RID: 8755
		public const int RoleTrialInfoActivityFieldNumber = 15;

		// Token: 0x04002234 RID: 8756
		public const int PhantomCollectActivityFieldNumber = 16;

		// Token: 0x04002235 RID: 8757
		public const int GatherActivityInfoFieldNumber = 17;

		// Token: 0x04002236 RID: 8758
		public const int DailyAdventureActivityDataFieldNumber = 18;

		// Token: 0x04002237 RID: 8759
		public const int RoguelikeActivityDataFieldNumber = 19;

		// Token: 0x04002238 RID: 8760
		public const int LongShanActivityDataFieldNumber = 20;

		// Token: 0x04002239 RID: 8761
		public const int TurntableActivityDataFieldNumber = 21;

		// Token: 0x0400223A RID: 8762
		public const int BossRushActivityDataFieldNumber = 22;

		// Token: 0x0400223B RID: 8763
		public const int TrackMoonActivityTaskDataFieldNumber = 23;

		// Token: 0x0400223C RID: 8764
		public const int TimePointRewardActivityDataFieldNumber = 24;

		// Token: 0x0400223D RID: 8765
		public const int TowerDefenceActivityDataFieldNumber = 25;

		// Token: 0x0400223E RID: 8766
		public const int CircumFluenceTaskDataFieldNumber = 26;

		// Token: 0x0400223F RID: 8767
		public const int TraceMoonPhaseDataFieldNumber = 27;

		// Token: 0x04002240 RID: 8768
		public const int CorniceMeetingDataFieldNumber = 28;

		// Token: 0x04002241 RID: 8769
		public const int RiskHarvestActivityInfoFieldNumber = 29;

		// Token: 0x04002242 RID: 8770
		public const int BlackCoastThemeActivityDataFieldNumber = 31;

		// Token: 0x04002243 RID: 8771
		public const int RogueWhiteCatDataFieldNumber = 32;

		// Token: 0x04002244 RID: 8772
		public const int ScratchCardActivityInfoFieldNumber = 34;

		// Token: 0x04002245 RID: 8773
		public const int PreheatSignActivityInfoFieldNumber = 35;

		// Token: 0x04002246 RID: 8774
		public const int MowTowerActivityInfoFieldNumber = 36;

		// Token: 0x04002247 RID: 8775
		public const int FarmGoldInfoFieldNumber = 37;

		// Token: 0x04002248 RID: 8776
		public const int SpringSignInfoFieldNumber = 38;

		// Token: 0x04002249 RID: 8777
		public const int MapTravelActivityInfoFieldNumber = 39;

		// Token: 0x0400224A RID: 8778
		public const int RoleSkinTrialInfoActivityFieldNumber = 40;

		// Token: 0x0400224B RID: 8779
		public const int FishingActivityInfoFieldNumber = 41;

		// Token: 0x0400224C RID: 8780
		public const int RogueWeeklyDataFieldNumber = 43;

		// Token: 0x0400224D RID: 8781
		public const int TeamParkourLevelActivityInfoFieldNumber = 44;

		// Token: 0x0400224E RID: 8782
		public const int BabelActivityInfoFieldNumber = 45;

		// Token: 0x0400224F RID: 8783
		public const int RacingBetsDataFieldNumber = 46;

		// Token: 0x04002250 RID: 8784
		public const int ExploreActivityInfoFieldNumber = 47;

		// Token: 0x04002251 RID: 8785
		public const int RogueResActivityDataFieldNumber = 48;

		// Token: 0x04002252 RID: 8786
		public const int AvignonActivityInfoFieldNumber = 49;

		// Token: 0x04002253 RID: 8787
		public const int AbyssInfoFieldNumber = 50;

		// Token: 0x04002254 RID: 8788
		public const int H5CircumFluenceDataFieldNumber = 51;

		// Token: 0x04002255 RID: 8789
		public const int DangoMonopolyActivityDataFieldNumber = 52;

		// Token: 0x04002256 RID: 8790
		public const int CiacconaActivityPbDataFieldNumber = 53;

		// Token: 0x04002257 RID: 8791
		public const int ActivityLinkageDataFieldNumber = 54;

		// Token: 0x04002258 RID: 8792
		public const int RegressDataFieldNumber = 55;

		// Token: 0x04002259 RID: 8793
		public const int ConsumptiveActivityInfoFieldNumber = 56;

		// Token: 0x0400225A RID: 8794
		public const int PhantomBattleActivityInfoFieldNumber = 57;

		// Token: 0x0400225B RID: 8795
		public const int NewbieCarnivalDataFieldNumber = 58;

		// Token: 0x0400225C RID: 8796
		public const int MoraleActivityDataFieldNumber = 59;

		// Token: 0x0400225D RID: 8797
		public const int FloroRanchActivityDataFieldNumber = 60;

		// Token: 0x0400225E RID: 8798
		public const int LifePointChallengeFieldNumber = 61;

		// Token: 0x0400225F RID: 8799
		public const int TrapDefenseActivityInfoFieldNumber = 62;

		// Token: 0x04002260 RID: 8800
		public const int FunPlayActivityInfoFieldNumber = 63;

		// Token: 0x04002261 RID: 8801
		public const int JinzhouFlyDataFieldNumber = 64;

		// Token: 0x04002262 RID: 8802
		public const int LineCrossActivityDataFieldNumber = 65;

		// Token: 0x04002263 RID: 8803
		public const int MoonPhaseActivityDataFieldNumber = 66;

		// Token: 0x04002264 RID: 8804
		public const int HonamiStoryActivityInfoFieldNumber = 71;

		// Token: 0x04002265 RID: 8805
		public const int PhotoFightActivityDataFieldNumber = 72;

		// Token: 0x04002266 RID: 8806
		public const int SurvivorsActivityDataFieldNumber = 73;

		// Token: 0x04002267 RID: 8807
		public const int WuWuKujiActivityInfoFieldNumber = 74;

		// Token: 0x04002268 RID: 8808
		public const int AdvertisingPageInfoFieldNumber = 75;

		// Token: 0x04002269 RID: 8809
		public const int ArtemisActivityInfoFieldNumber = 76;

		// Token: 0x0400226A RID: 8810
		public const int RoleCoopActivityDataFieldNumber = 77;

		// Token: 0x0400226B RID: 8811
		public const int MotorCycleIpActivityDataFieldNumber = 78;

		// Token: 0x0400226C RID: 8812
		public const int PhantomBattleRecordActivityInfoFieldNumber = 79;

		// Token: 0x0400226D RID: 8813
		public const int InfrThemeActivityPbFieldNumber = 80;

		// Token: 0x0400226E RID: 8814
		public const int RoadBookActivityInfoFieldNumber = 81;

		// Token: 0x0400226F RID: 8815
		public const int PhantomBattleGuideActivityFieldNumber = 82;

		// Token: 0x04002270 RID: 8816
		public const int NewTowerClimbingActivityDataFieldNumber = 83;

		// Token: 0x04002271 RID: 8817
		public const int NewPlayerSupportActivityDataFieldNumber = 84;

		// Token: 0x04002272 RID: 8818
		public const int MotorParkourActivityInfoFieldNumber = 85;

		// Token: 0x04002273 RID: 8819
		public const int SpringFestivalActivityInfoFieldNumber = 86;

		// Token: 0x04002274 RID: 8820
		public const int TotalTopUpActivityInfoFieldNumber = 87;

		// Token: 0x04002275 RID: 8821
		public const int MotorFightActivityPbFieldNumber = 88;

		// Token: 0x04002276 RID: 8822
		public const int H5ViewActivityDataFieldNumber = 89;

		// Token: 0x04002277 RID: 8823
		public const int SkinRewardActivityDataFieldNumber = 90;

		// Token: 0x04002278 RID: 8824
		public const int EncircleActivityPbFieldNumber = 91;

		// Token: 0x04002279 RID: 8825
		public const int MotorDevelopActivityDataFieldNumber = 92;

		// Token: 0x0400227A RID: 8826
		public const int FlagChallengeActivityInfoFieldNumber = 93;

		// Token: 0x0400227B RID: 8827
		public const int FeiXuePreheatActivityInfoFieldNumber = 94;

		// Token: 0x0400227C RID: 8828
		public const int RhythmActivityPbFieldNumber = 95;

		// Token: 0x0400227D RID: 8829
		public const int DropCatchActivityInfoFieldNumber = 96;

		// Token: 0x0400227E RID: 8830
		public const int TetrisActivityInfoFieldNumber = 97;

		// Token: 0x0400227F RID: 8831
		public const int PinballActivityDataFieldNumber = 98;

		// Token: 0x04002280 RID: 8832
		public const int BossPilingActivityInfoFieldNumber = 99;

		// Token: 0x04002281 RID: 8833
		public const int ThemeCelebrationFieldNumber = 100;

		// Token: 0x04002282 RID: 8834
		public const int WuWuWeekActivityFieldNumber = 101;

		// Token: 0x04002283 RID: 8835
		public const int MotorDecalActivityDataFieldNumber = 102;

		// Token: 0x04002284 RID: 8836
		public const int LinkageCheckInActivityDataFieldNumber = 103;

		// Token: 0x04002285 RID: 8837
		public const int RoleGiftActivityDataFieldNumber = 104;

		// Token: 0x04002286 RID: 8838
		public const int KurotatoActivityDataFieldNumber = 105;

		// Token: 0x04002287 RID: 8839
		public const int GolemCrackActivityInfoFieldNumber = 106;

		// Token: 0x04002288 RID: 8840
		public const int EdgeRunnerActivityInfoFieldNumber = 107;

		// Token: 0x04002289 RID: 8841
		public const int OnlineMotorActivityDataFieldNumber = 108;

		// Token: 0x0400228A RID: 8842
		public const int RealmBetweenActivityInfoFieldNumber = 109;

		// Token: 0x0400228B RID: 8843
		public const int ThroughTrainSummaryActivityDataFieldNumber = 110;

		// Token: 0x0400228C RID: 8844
		public const int NewbieMainActivityPbFieldNumber = 111;

		// Token: 0x0400228D RID: 8845
		public const int NewbieCourseV2ActivityPbFieldNumber = 112;

		// Token: 0x0400228E RID: 8846
		public const int NewbieAdventureV2PbFieldNumber = 113;

		// Token: 0x0400228F RID: 8847
		public const int NewPlayerSupportActivityV2PbFieldNumber = 114;

		// Token: 0x04002290 RID: 8848
		public const int ThroughTrainActivityDataFieldNumber = 115;

		// Token: 0x04002291 RID: 8849
		public const int RoverRogueActivityDataFieldNumber = 116;

		// Token: 0x04002292 RID: 8850
		public const int DangoBrawlActivityInfoFieldNumber = 117;

		// Token: 0x04002293 RID: 8851
		public const int QingXiaoActivityInfoFieldNumber = 118;

		// Token: 0x04002294 RID: 8852
		public const int MatchThreeActivityInfoFieldNumber = 120;

		// Token: 0x04002295 RID: 8853
		public const int GiantActivityInfoFieldNumber = 121;

		// Token: 0x04002296 RID: 8854
		public const int SolarSchoolActivityPbFieldNumber = 122;

		// Token: 0x04002297 RID: 8855
		public const int RoleTowerActivityDataFieldNumber = 123;

		// Token: 0x04002298 RID: 8856
		private object data_;

		// Token: 0x04002299 RID: 8857
		private ActivityData.DataOneofCase dataCase_;

		// Token: 0x02001751 RID: 5969
		public enum DataOneofCase
		{
			// Token: 0x0400C9D7 RID: 51671
			None,
			// Token: 0x0400C9D8 RID: 51672
			ParkourActivity = 10,
			// Token: 0x0400C9D9 RID: 51673
			SignActivity,
			// Token: 0x0400C9DA RID: 51674
			NewBieCourseActivity,
			// Token: 0x0400C9DB RID: 51675
			DoubleInstActivityReward,
			// Token: 0x0400C9DC RID: 51676
			HarvestActivity,
			// Token: 0x0400C9DD RID: 51677
			RoleTrialInfoActivity,
			// Token: 0x0400C9DE RID: 51678
			PhantomCollectActivity,
			// Token: 0x0400C9DF RID: 51679
			GatherActivityInfo,
			// Token: 0x0400C9E0 RID: 51680
			DailyAdventureActivityData,
			// Token: 0x0400C9E1 RID: 51681
			RoguelikeActivityData,
			// Token: 0x0400C9E2 RID: 51682
			LongShanActivityData,
			// Token: 0x0400C9E3 RID: 51683
			TurntableActivityData,
			// Token: 0x0400C9E4 RID: 51684
			BossRushActivityData,
			// Token: 0x0400C9E5 RID: 51685
			TrackMoonActivityTaskData,
			// Token: 0x0400C9E6 RID: 51686
			TimePointRewardActivityData,
			// Token: 0x0400C9E7 RID: 51687
			TowerDefenceActivityData,
			// Token: 0x0400C9E8 RID: 51688
			CircumFluenceTaskData,
			// Token: 0x0400C9E9 RID: 51689
			TraceMoonPhaseData,
			// Token: 0x0400C9EA RID: 51690
			CorniceMeetingData,
			// Token: 0x0400C9EB RID: 51691
			RiskHarvestActivityInfo,
			// Token: 0x0400C9EC RID: 51692
			BlackCoastThemeActivityData = 31,
			// Token: 0x0400C9ED RID: 51693
			RogueWhiteCatData,
			// Token: 0x0400C9EE RID: 51694
			ScratchCardActivityInfo = 34,
			// Token: 0x0400C9EF RID: 51695
			PreheatSignActivityInfo,
			// Token: 0x0400C9F0 RID: 51696
			MowTowerActivityInfo,
			// Token: 0x0400C9F1 RID: 51697
			FarmGoldInfo,
			// Token: 0x0400C9F2 RID: 51698
			SpringSignInfo,
			// Token: 0x0400C9F3 RID: 51699
			MapTravelActivityInfo,
			// Token: 0x0400C9F4 RID: 51700
			RoleSkinTrialInfoActivity,
			// Token: 0x0400C9F5 RID: 51701
			FishingActivityInfo,
			// Token: 0x0400C9F6 RID: 51702
			RogueWeeklyData = 43,
			// Token: 0x0400C9F7 RID: 51703
			TeamParkourLevelActivityInfo,
			// Token: 0x0400C9F8 RID: 51704
			BabelActivityInfo,
			// Token: 0x0400C9F9 RID: 51705
			RacingBetsData,
			// Token: 0x0400C9FA RID: 51706
			ExploreActivityInfo,
			// Token: 0x0400C9FB RID: 51707
			RogueResActivityData,
			// Token: 0x0400C9FC RID: 51708
			AvignonActivityInfo,
			// Token: 0x0400C9FD RID: 51709
			AbyssInfo,
			// Token: 0x0400C9FE RID: 51710
			H5CircumFluenceData,
			// Token: 0x0400C9FF RID: 51711
			DangoMonopolyActivityData,
			// Token: 0x0400CA00 RID: 51712
			CiacconaActivityPbData,
			// Token: 0x0400CA01 RID: 51713
			ActivityLinkageData,
			// Token: 0x0400CA02 RID: 51714
			RegressData,
			// Token: 0x0400CA03 RID: 51715
			ConsumptiveActivityInfo,
			// Token: 0x0400CA04 RID: 51716
			PhantomBattleActivityInfo,
			// Token: 0x0400CA05 RID: 51717
			NewbieCarnivalData,
			// Token: 0x0400CA06 RID: 51718
			MoraleActivityData,
			// Token: 0x0400CA07 RID: 51719
			FloroRanchActivityData,
			// Token: 0x0400CA08 RID: 51720
			LifePointChallenge,
			// Token: 0x0400CA09 RID: 51721
			TrapDefenseActivityInfo,
			// Token: 0x0400CA0A RID: 51722
			FunPlayActivityInfo,
			// Token: 0x0400CA0B RID: 51723
			JinzhouFlyData,
			// Token: 0x0400CA0C RID: 51724
			LineCrossActivityData,
			// Token: 0x0400CA0D RID: 51725
			MoonPhaseActivityData,
			// Token: 0x0400CA0E RID: 51726
			HonamiStoryActivityInfo = 71,
			// Token: 0x0400CA0F RID: 51727
			PhotoFightActivityData,
			// Token: 0x0400CA10 RID: 51728
			SurvivorsActivityData,
			// Token: 0x0400CA11 RID: 51729
			WuWuKujiActivityInfo,
			// Token: 0x0400CA12 RID: 51730
			AdvertisingPageInfo,
			// Token: 0x0400CA13 RID: 51731
			ArtemisActivityInfo,
			// Token: 0x0400CA14 RID: 51732
			RoleCoopActivityData,
			// Token: 0x0400CA15 RID: 51733
			MotorCycleIpActivityData,
			// Token: 0x0400CA16 RID: 51734
			PhantomBattleRecordActivityInfo,
			// Token: 0x0400CA17 RID: 51735
			InfrThemeActivityPb,
			// Token: 0x0400CA18 RID: 51736
			RoadBookActivityInfo,
			// Token: 0x0400CA19 RID: 51737
			PhantomBattleGuideActivity,
			// Token: 0x0400CA1A RID: 51738
			NewTowerClimbingActivityData,
			// Token: 0x0400CA1B RID: 51739
			NewPlayerSupportActivityData,
			// Token: 0x0400CA1C RID: 51740
			MotorParkourActivityInfo,
			// Token: 0x0400CA1D RID: 51741
			SpringFestivalActivityInfo,
			// Token: 0x0400CA1E RID: 51742
			TotalTopUpActivityInfo,
			// Token: 0x0400CA1F RID: 51743
			MotorFightActivityPb,
			// Token: 0x0400CA20 RID: 51744
			H5ViewActivityData,
			// Token: 0x0400CA21 RID: 51745
			SkinRewardActivityData,
			// Token: 0x0400CA22 RID: 51746
			EncircleActivityPb,
			// Token: 0x0400CA23 RID: 51747
			MotorDevelopActivityData,
			// Token: 0x0400CA24 RID: 51748
			FlagChallengeActivityInfo,
			// Token: 0x0400CA25 RID: 51749
			FeiXuePreheatActivityInfo,
			// Token: 0x0400CA26 RID: 51750
			RhythmActivityPb,
			// Token: 0x0400CA27 RID: 51751
			DropCatchActivityInfo,
			// Token: 0x0400CA28 RID: 51752
			TetrisActivityInfo,
			// Token: 0x0400CA29 RID: 51753
			PinballActivityData,
			// Token: 0x0400CA2A RID: 51754
			BossPilingActivityInfo,
			// Token: 0x0400CA2B RID: 51755
			ThemeCelebration,
			// Token: 0x0400CA2C RID: 51756
			WuWuWeekActivity,
			// Token: 0x0400CA2D RID: 51757
			MotorDecalActivityData,
			// Token: 0x0400CA2E RID: 51758
			LinkageCheckInActivityData,
			// Token: 0x0400CA2F RID: 51759
			RoleGiftActivityData,
			// Token: 0x0400CA30 RID: 51760
			KurotatoActivityData,
			// Token: 0x0400CA31 RID: 51761
			GolemCrackActivityInfo,
			// Token: 0x0400CA32 RID: 51762
			EdgeRunnerActivityInfo,
			// Token: 0x0400CA33 RID: 51763
			OnlineMotorActivityData,
			// Token: 0x0400CA34 RID: 51764
			RealmBetweenActivityInfo,
			// Token: 0x0400CA35 RID: 51765
			ThroughTrainSummaryActivityData,
			// Token: 0x0400CA36 RID: 51766
			NewbieMainActivityPb,
			// Token: 0x0400CA37 RID: 51767
			NewbieCourseV2ActivityPb,
			// Token: 0x0400CA38 RID: 51768
			NewbieAdventureV2Pb,
			// Token: 0x0400CA39 RID: 51769
			NewPlayerSupportActivityV2Pb,
			// Token: 0x0400CA3A RID: 51770
			ThroughTrainActivityData,
			// Token: 0x0400CA3B RID: 51771
			RoverRogueActivityData,
			// Token: 0x0400CA3C RID: 51772
			DangoBrawlActivityInfo,
			// Token: 0x0400CA3D RID: 51773
			QingXiaoActivityInfo,
			// Token: 0x0400CA3E RID: 51774
			MatchThreeActivityInfo = 120,
			// Token: 0x0400CA3F RID: 51775
			GiantActivityInfo,
			// Token: 0x0400CA40 RID: 51776
			SolarSchoolActivityPb,
			// Token: 0x0400CA41 RID: 51777
			RoleTowerActivityData
		}
	}
}
