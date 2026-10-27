using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F6 RID: 5622
	public enum MailAddReason
	{
		// Token: 0x0400BEAE RID: 48814
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400BEAF RID: 48815
		[OriginalName("BagFull")]
		BagFull,
		// Token: 0x0400BEB0 RID: 48816
		[OriginalName("Public")]
		Public,
		// Token: 0x0400BEB1 RID: 48817
		[OriginalName("OfflineEventAdd")]
		OfflineEventAdd,
		// Token: 0x0400BEB2 RID: 48818
		[OriginalName("QuestNpcAction")]
		QuestNpcAction,
		// Token: 0x0400BEB3 RID: 48819
		[OriginalName("DailyQuestReward")]
		DailyQuestReward,
		// Token: 0x0400BEB4 RID: 48820
		[OriginalName("ReportPlayer")]
		ReportPlayer,
		// Token: 0x0400BEB5 RID: 48821
		[OriginalName("MonthCardRemind")]
		MonthCardRemind,
		// Token: 0x0400BEB6 RID: 48822
		[OriginalName("BattlePassSettle")]
		BattlePassSettle,
		// Token: 0x0400BEB7 RID: 48823
		[OriginalName("PayRebate")]
		PayRebate,
		// Token: 0x0400BEB8 RID: 48824
		[OriginalName("RemoveTemporaryTeleportBySceneDataLayerChange")]
		RemoveTemporaryTeleportBySceneDataLayerChange,
		// Token: 0x0400BEB9 RID: 48825
		[OriginalName("CdKey")]
		CdKey,
		// Token: 0x0400BEBA RID: 48826
		[OriginalName("PayRefund")]
		PayRefund,
		// Token: 0x0400BEBB RID: 48827
		[OriginalName("Replenishment")]
		Replenishment,
		// Token: 0x0400BEBC RID: 48828
		[OriginalName("GatherActivitySettle")]
		GatherActivitySettle,
		// Token: 0x0400BEBD RID: 48829
		[OriginalName("HarvestActivitySettle")]
		HarvestActivitySettle,
		// Token: 0x0400BEBE RID: 48830
		[OriginalName("RoleTrialActivitySettle")]
		RoleTrialActivitySettle,
		// Token: 0x0400BEBF RID: 48831
		[OriginalName("KuroBbsFirstBind")]
		KuroBbsFirstBind,
		// Token: 0x0400BEC0 RID: 48832
		[OriginalName("ParkourActivitySettle")]
		ParkourActivitySettle,
		// Token: 0x0400BEC1 RID: 48833
		[OriginalName("DailyAdventureActivitySettle")]
		DailyAdventureActivitySettle,
		// Token: 0x0400BEC2 RID: 48834
		[OriginalName("LongShanActivitySettle")]
		LongShanActivitySettle,
		// Token: 0x0400BEC3 RID: 48835
		[OriginalName("SignActivitySettle")]
		SignActivitySettle,
		// Token: 0x0400BEC4 RID: 48836
		[OriginalName("BossRushActivitySettle")]
		BossRushActivitySettle,
		// Token: 0x0400BEC5 RID: 48837
		[OriginalName("PromotionActivity")]
		PromotionActivity,
		// Token: 0x0400BEC6 RID: 48838
		[OriginalName("RogueActivitySettle")]
		RogueActivitySettle,
		// Token: 0x0400BEC7 RID: 48839
		[OriginalName("TowerDefenceActivitySettle")]
		TowerDefenceActivitySettle,
		// Token: 0x0400BEC8 RID: 48840
		[OriginalName("ExploreToolUnlock")]
		ExploreToolUnlock,
		// Token: 0x0400BEC9 RID: 48841
		[OriginalName("CalabashFixLevelExp")]
		CalabashFixLevelExp,
		// Token: 0x0400BECA RID: 48842
		[OriginalName("ActivityNotice")]
		ActivityNotice,
		// Token: 0x0400BECB RID: 48843
		[OriginalName("TrackMoonPhaseSettle")]
		TrackMoonPhaseSettle,
		// Token: 0x0400BECC RID: 48844
		[OriginalName("TrackMoonSettle")]
		TrackMoonSettle,
		// Token: 0x0400BECD RID: 48845
		[OriginalName("CircumFluenceSettle")]
		CircumFluenceSettle,
		// Token: 0x0400BECE RID: 48846
		[OriginalName("CorniceMeetingActivitySettle")]
		CorniceMeetingActivitySettle,
		// Token: 0x0400BECF RID: 48847
		[OriginalName("RiskHarvestSettle")]
		RiskHarvestSettle,
		// Token: 0x0400BED0 RID: 48848
		[OriginalName("BlackCoastThemeSettle")]
		BlackCoastThemeSettle,
		// Token: 0x0400BED1 RID: 48849
		[OriginalName("PreheatSignSettle")]
		PreheatSignSettle,
		// Token: 0x0400BED2 RID: 48850
		[OriginalName("MowTower")]
		MowTower,
		// Token: 0x0400BED3 RID: 48851
		[OriginalName("RogueWhiteCatLimitRewardReissue")]
		RogueWhiteCatLimitRewardReissue,
		// Token: 0x0400BED4 RID: 48852
		[OriginalName("SpecialItemUnlock")]
		SpecialItemUnlock,
		// Token: 0x0400BED5 RID: 48853
		[OriginalName("SpringSignSettle")]
		SpringSignSettle,
		// Token: 0x0400BED6 RID: 48854
		[OriginalName("RoleSkinTrialActivitySettle")]
		RoleSkinTrialActivitySettle,
		// Token: 0x0400BED7 RID: 48855
		[OriginalName("FishingActivityLimitSettleReward")]
		FishingActivityLimitSettleReward,
		// Token: 0x0400BED8 RID: 48856
		[OriginalName("TeamParkOurSettleReward")]
		TeamParkOurSettleReward,
		// Token: 0x0400BED9 RID: 48857
		[OriginalName("RogueWeeklyCycleAward")]
		RogueWeeklyCycleAward,
		// Token: 0x0400BEDA RID: 48858
		[OriginalName("BabelTowerDailyTaskResetReward")]
		BabelTowerDailyTaskResetReward,
		// Token: 0x0400BEDB RID: 48859
		[OriginalName("BabelTowerCloseReward")]
		BabelTowerCloseReward,
		// Token: 0x0400BEDC RID: 48860
		[OriginalName("ExploreActivitySettle")]
		ExploreActivitySettle,
		// Token: 0x0400BEDD RID: 48861
		[OriginalName("AvignonMailSettle")]
		AvignonMailSettle,
		// Token: 0x0400BEDE RID: 48862
		[OriginalName("CircumFluenceCloseNotice")]
		CircumFluenceCloseNotice,
		// Token: 0x0400BEDF RID: 48863
		[OriginalName("RogueResTaskAwardRecoup")]
		RogueResTaskAwardRecoup,
		// Token: 0x0400BEE0 RID: 48864
		[OriginalName("CiacconaActivitySettle")]
		CiacconaActivitySettle,
		// Token: 0x0400BEE1 RID: 48865
		[OriginalName("DangoMonopolyGridReward")]
		DangoMonopolyGridReward,
		// Token: 0x0400BEE2 RID: 48866
		[OriginalName("DangoMonopolyBoardReward")]
		DangoMonopolyBoardReward,
		// Token: 0x0400BEE3 RID: 48867
		[OriginalName("AbyssActivityRewardSettle")]
		AbyssActivityRewardSettle,
		// Token: 0x0400BEE4 RID: 48868
		[OriginalName("RacingBetsActivitySettle")]
		RacingBetsActivitySettle,
		// Token: 0x0400BEE5 RID: 48869
		[OriginalName("ConsumptiveActivitySettle")]
		ConsumptiveActivitySettle,
		// Token: 0x0400BEE6 RID: 48870
		[OriginalName("ConsumptiveShopSettle")]
		ConsumptiveShopSettle,
		// Token: 0x0400BEE7 RID: 48871
		[OriginalName("SlashAndTowerSettle")]
		SlashAndTowerSettle,
		// Token: 0x0400BEE8 RID: 48872
		[OriginalName("TowerMailSettle")]
		TowerMailSettle,
		// Token: 0x0400BEE9 RID: 48873
		[OriginalName("BirthDaySettle")]
		BirthDaySettle,
		// Token: 0x0400BEEA RID: 48874
		[OriginalName("RacingBetsActivityEnd")]
		RacingBetsActivityEnd,
		// Token: 0x0400BEEB RID: 48875
		[OriginalName("NewbieCarnivalReissueAward")]
		NewbieCarnivalReissueAward,
		// Token: 0x0400BEEC RID: 48876
		[OriginalName("PhantomBattleLimitSettleReward")]
		PhantomBattleLimitSettleReward,
		// Token: 0x0400BEED RID: 48877
		[OriginalName("FloroMailSettle")]
		FloroMailSettle,
		// Token: 0x0400BEEE RID: 48878
		[OriginalName("FixQuestTreasureBox")]
		FixQuestTreasureBox,
		// Token: 0x0400BEEF RID: 48879
		[OriginalName("TrapDefenseActivitySettle")]
		TrapDefenseActivitySettle,
		// Token: 0x0400BEF0 RID: 48880
		[OriginalName("FunPlayActivityClose")]
		FunPlayActivityClose,
		// Token: 0x0400BEF1 RID: 48881
		[OriginalName("JinZhouFlySend")]
		JinZhouFlySend,
		// Token: 0x0400BEF2 RID: 48882
		[OriginalName("PhotoFightActivityClose")]
		PhotoFightActivityClose,
		// Token: 0x0400BEF3 RID: 48883
		[OriginalName("SurvivorsTaskReward")]
		SurvivorsTaskReward,
		// Token: 0x0400BEF4 RID: 48884
		[OriginalName("SurvivorsScoreReward")]
		SurvivorsScoreReward,
		// Token: 0x0400BEF5 RID: 48885
		[OriginalName("HonamiStoryLimitSettleReward")]
		HonamiStoryLimitSettleReward,
		// Token: 0x0400BEF6 RID: 48886
		[OriginalName("RegressActivityDelayOpen")]
		RegressActivityDelayOpen,
		// Token: 0x0400BEF7 RID: 48887
		[OriginalName("ArtemisActivityReward")]
		ArtemisActivityReward,
		// Token: 0x0400BEF8 RID: 48888
		[OriginalName("MotorcycleIpLink")]
		MotorcycleIpLink,
		// Token: 0x0400BEF9 RID: 48889
		[OriginalName("InfrThemeActivityClose")]
		InfrThemeActivityClose,
		// Token: 0x0400BEFA RID: 48890
		[OriginalName("NewTowerScoreReward")]
		NewTowerScoreReward,
		// Token: 0x0400BEFB RID: 48891
		[OriginalName("MotorLimitSettleReward")]
		MotorLimitSettleReward,
		// Token: 0x0400BEFC RID: 48892
		[OriginalName("NewPlayerSupportActTaskRewardReissue")]
		NewPlayerSupportActTaskRewardReissue,
		// Token: 0x0400BEFD RID: 48893
		[OriginalName("MotorParkourActivityReward")]
		MotorParkourActivityReward,
		// Token: 0x0400BEFE RID: 48894
		[OriginalName("TotalTopUpSettleReward")]
		TotalTopUpSettleReward,
		// Token: 0x0400BEFF RID: 48895
		[OriginalName("MotorFightActivityClose")]
		MotorFightActivityClose,
		// Token: 0x0400BF00 RID: 48896
		[OriginalName("WeekCardRewardSettle")]
		WeekCardRewardSettle,
		// Token: 0x0400BF01 RID: 48897
		[OriginalName("FarmGoldActivityRewardReissue")]
		FarmGoldActivityRewardReissue,
		// Token: 0x0400BF02 RID: 48898
		[OriginalName("SpringFestival31MailSettle")]
		SpringFestival31MailSettle,
		// Token: 0x0400BF03 RID: 48899
		[OriginalName("MotorDevelopActivitySettle")]
		MotorDevelopActivitySettle,
		// Token: 0x0400BF04 RID: 48900
		[OriginalName("PhantomVicePolishNotice")]
		PhantomVicePolishNotice,
		// Token: 0x0400BF05 RID: 48901
		[OriginalName("FlagChallengeTaskRewardSettle")]
		FlagChallengeTaskRewardSettle,
		// Token: 0x0400BF06 RID: 48902
		[OriginalName("TotalTopUpReplenishment")]
		TotalTopUpReplenishment,
		// Token: 0x0400BF07 RID: 48903
		[OriginalName("FeiXuePreheatRewardSettle")]
		FeiXuePreheatRewardSettle,
		// Token: 0x0400BF08 RID: 48904
		[OriginalName("RhythmLimitTaskReissue")]
		RhythmLimitTaskReissue,
		// Token: 0x0400BF09 RID: 48905
		[OriginalName("DropCatchActivityReward")]
		DropCatchActivityReward,
		// Token: 0x0400BF0A RID: 48906
		[OriginalName("NewTowerSeasonAward")]
		NewTowerSeasonAward,
		// Token: 0x0400BF0B RID: 48907
		[OriginalName("NewTowerSeasonScoreAward")]
		NewTowerSeasonScoreAward,
		// Token: 0x0400BF0C RID: 48908
		[OriginalName("BossPilingTaskRewardSettle")]
		BossPilingTaskRewardSettle,
		// Token: 0x0400BF0D RID: 48909
		[OriginalName("ThemeCelebration")]
		ThemeCelebration,
		// Token: 0x0400BF0E RID: 48910
		[OriginalName("ThemeCelebrationWuWu")]
		ThemeCelebrationWuWu,
		// Token: 0x0400BF0F RID: 48911
		[OriginalName("TotalTopUpCloseReplenishment")]
		TotalTopUpCloseReplenishment,
		// Token: 0x0400BF10 RID: 48912
		[OriginalName("MotorDecalActivity")]
		MotorDecalActivity,
		// Token: 0x0400BF11 RID: 48913
		[OriginalName("PinballMailSettle")]
		PinballMailSettle,
		// Token: 0x0400BF12 RID: 48914
		[OriginalName("LinkageCheckInSettle")]
		LinkageCheckInSettle,
		// Token: 0x0400BF13 RID: 48915
		[OriginalName("RoleGiftSettle")]
		RoleGiftSettle,
		// Token: 0x0400BF14 RID: 48916
		[OriginalName("KurotatoLimitRewardReissue")]
		KurotatoLimitRewardReissue,
		// Token: 0x0400BF15 RID: 48917
		[OriginalName("KurotatoScoreRewardReissue")]
		KurotatoScoreRewardReissue,
		// Token: 0x0400BF16 RID: 48918
		[OriginalName("KurotatoResRewardReissue")]
		KurotatoResRewardReissue,
		// Token: 0x0400BF17 RID: 48919
		[OriginalName("GachaAccumulateRewardSettle")]
		GachaAccumulateRewardSettle,
		// Token: 0x0400BF18 RID: 48920
		[OriginalName("OnlineMotorSettle")]
		OnlineMotorSettle,
		// Token: 0x0400BF19 RID: 48921
		[OriginalName("EdgeRunnerActivityMailSettle")]
		EdgeRunnerActivityMailSettle,
		// Token: 0x0400BF1A RID: 48922
		[OriginalName("WeeklyFrameScoreRewardReissue")]
		WeeklyFrameScoreRewardReissue,
		// Token: 0x0400BF1B RID: 48923
		[OriginalName("XboxGift")]
		XboxGift,
		// Token: 0x0400BF1C RID: 48924
		[OriginalName("DangoBrawlActivityMailSettle")]
		DangoBrawlActivityMailSettle,
		// Token: 0x0400BF1D RID: 48925
		[OriginalName("RoverRogueTaskRewardSettle")]
		RoverRogueTaskRewardSettle,
		// Token: 0x0400BF1E RID: 48926
		[OriginalName("QingXiaoActivityMailSettle")]
		QingXiaoActivityMailSettle,
		// Token: 0x0400BF1F RID: 48927
		[OriginalName("TimePointRewardActivityMailSettle")]
		TimePointRewardActivityMailSettle
	}
}
