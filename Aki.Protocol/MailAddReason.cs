using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001669 RID: 5737
	public enum MailAddReason
	{
		// Token: 0x0400C3A5 RID: 50085
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400C3A6 RID: 50086
		[OriginalName("BagFull")]
		BagFull,
		// Token: 0x0400C3A7 RID: 50087
		[OriginalName("Public")]
		Public,
		// Token: 0x0400C3A8 RID: 50088
		[OriginalName("OfflineEventAdd")]
		OfflineEventAdd,
		// Token: 0x0400C3A9 RID: 50089
		[OriginalName("QuestNpcAction")]
		QuestNpcAction,
		// Token: 0x0400C3AA RID: 50090
		[OriginalName("DailyQuestReward")]
		DailyQuestReward,
		// Token: 0x0400C3AB RID: 50091
		[OriginalName("ReportPlayer")]
		ReportPlayer,
		// Token: 0x0400C3AC RID: 50092
		[OriginalName("MonthCardRemind")]
		MonthCardRemind,
		// Token: 0x0400C3AD RID: 50093
		[OriginalName("BattlePassSettle")]
		BattlePassSettle,
		// Token: 0x0400C3AE RID: 50094
		[OriginalName("PayRebate")]
		PayRebate,
		// Token: 0x0400C3AF RID: 50095
		[OriginalName("RemoveTemporaryTeleportBySceneDataLayerChange")]
		RemoveTemporaryTeleportBySceneDataLayerChange,
		// Token: 0x0400C3B0 RID: 50096
		[OriginalName("CdKey")]
		CdKey,
		// Token: 0x0400C3B1 RID: 50097
		[OriginalName("PayRefund")]
		PayRefund,
		// Token: 0x0400C3B2 RID: 50098
		[OriginalName("Replenishment")]
		Replenishment,
		// Token: 0x0400C3B3 RID: 50099
		[OriginalName("GatherActivitySettle")]
		GatherActivitySettle,
		// Token: 0x0400C3B4 RID: 50100
		[OriginalName("HarvestActivitySettle")]
		HarvestActivitySettle,
		// Token: 0x0400C3B5 RID: 50101
		[OriginalName("RoleTrialActivitySettle")]
		RoleTrialActivitySettle,
		// Token: 0x0400C3B6 RID: 50102
		[OriginalName("KuroBbsFirstBind")]
		KuroBbsFirstBind,
		// Token: 0x0400C3B7 RID: 50103
		[OriginalName("ParkourActivitySettle")]
		ParkourActivitySettle,
		// Token: 0x0400C3B8 RID: 50104
		[OriginalName("DailyAdventureActivitySettle")]
		DailyAdventureActivitySettle,
		// Token: 0x0400C3B9 RID: 50105
		[OriginalName("LongShanActivitySettle")]
		LongShanActivitySettle,
		// Token: 0x0400C3BA RID: 50106
		[OriginalName("SignActivitySettle")]
		SignActivitySettle,
		// Token: 0x0400C3BB RID: 50107
		[OriginalName("BossRushActivitySettle")]
		BossRushActivitySettle,
		// Token: 0x0400C3BC RID: 50108
		[OriginalName("PromotionActivity")]
		PromotionActivity,
		// Token: 0x0400C3BD RID: 50109
		[OriginalName("RogueActivitySettle")]
		RogueActivitySettle,
		// Token: 0x0400C3BE RID: 50110
		[OriginalName("TowerDefenceActivitySettle")]
		TowerDefenceActivitySettle,
		// Token: 0x0400C3BF RID: 50111
		[OriginalName("ExploreToolUnlock")]
		ExploreToolUnlock,
		// Token: 0x0400C3C0 RID: 50112
		[OriginalName("CalabashFixLevelExp")]
		CalabashFixLevelExp,
		// Token: 0x0400C3C1 RID: 50113
		[OriginalName("ActivityNotice")]
		ActivityNotice,
		// Token: 0x0400C3C2 RID: 50114
		[OriginalName("TrackMoonPhaseSettle")]
		TrackMoonPhaseSettle,
		// Token: 0x0400C3C3 RID: 50115
		[OriginalName("TrackMoonSettle")]
		TrackMoonSettle,
		// Token: 0x0400C3C4 RID: 50116
		[OriginalName("CircumFluenceSettle")]
		CircumFluenceSettle,
		// Token: 0x0400C3C5 RID: 50117
		[OriginalName("CorniceMeetingActivitySettle")]
		CorniceMeetingActivitySettle,
		// Token: 0x0400C3C6 RID: 50118
		[OriginalName("RiskHarvestSettle")]
		RiskHarvestSettle,
		// Token: 0x0400C3C7 RID: 50119
		[OriginalName("BlackCoastThemeSettle")]
		BlackCoastThemeSettle,
		// Token: 0x0400C3C8 RID: 50120
		[OriginalName("PreheatSignSettle")]
		PreheatSignSettle,
		// Token: 0x0400C3C9 RID: 50121
		[OriginalName("MowTower")]
		MowTower,
		// Token: 0x0400C3CA RID: 50122
		[OriginalName("RogueWhiteCatLimitRewardReissue")]
		RogueWhiteCatLimitRewardReissue,
		// Token: 0x0400C3CB RID: 50123
		[OriginalName("SpecialItemUnlock")]
		SpecialItemUnlock,
		// Token: 0x0400C3CC RID: 50124
		[OriginalName("SpringSignSettle")]
		SpringSignSettle,
		// Token: 0x0400C3CD RID: 50125
		[OriginalName("RoleSkinTrialActivitySettle")]
		RoleSkinTrialActivitySettle,
		// Token: 0x0400C3CE RID: 50126
		[OriginalName("FishingActivityLimitSettleReward")]
		FishingActivityLimitSettleReward,
		// Token: 0x0400C3CF RID: 50127
		[OriginalName("TeamParkOurSettleReward")]
		TeamParkOurSettleReward,
		// Token: 0x0400C3D0 RID: 50128
		[OriginalName("RogueWeeklyCycleAward")]
		RogueWeeklyCycleAward,
		// Token: 0x0400C3D1 RID: 50129
		[OriginalName("BabelTowerDailyTaskResetReward")]
		BabelTowerDailyTaskResetReward,
		// Token: 0x0400C3D2 RID: 50130
		[OriginalName("BabelTowerCloseReward")]
		BabelTowerCloseReward,
		// Token: 0x0400C3D3 RID: 50131
		[OriginalName("ExploreActivitySettle")]
		ExploreActivitySettle,
		// Token: 0x0400C3D4 RID: 50132
		[OriginalName("AvignonMailSettle")]
		AvignonMailSettle,
		// Token: 0x0400C3D5 RID: 50133
		[OriginalName("CircumFluenceCloseNotice")]
		CircumFluenceCloseNotice,
		// Token: 0x0400C3D6 RID: 50134
		[OriginalName("RogueResTaskAwardRecoup")]
		RogueResTaskAwardRecoup,
		// Token: 0x0400C3D7 RID: 50135
		[OriginalName("CiacconaActivitySettle")]
		CiacconaActivitySettle,
		// Token: 0x0400C3D8 RID: 50136
		[OriginalName("DangoMonopolyGridReward")]
		DangoMonopolyGridReward,
		// Token: 0x0400C3D9 RID: 50137
		[OriginalName("DangoMonopolyBoardReward")]
		DangoMonopolyBoardReward,
		// Token: 0x0400C3DA RID: 50138
		[OriginalName("AbyssActivityRewardSettle")]
		AbyssActivityRewardSettle,
		// Token: 0x0400C3DB RID: 50139
		[OriginalName("RacingBetsActivitySettle")]
		RacingBetsActivitySettle,
		// Token: 0x0400C3DC RID: 50140
		[OriginalName("ConsumptiveActivitySettle")]
		ConsumptiveActivitySettle,
		// Token: 0x0400C3DD RID: 50141
		[OriginalName("ConsumptiveShopSettle")]
		ConsumptiveShopSettle,
		// Token: 0x0400C3DE RID: 50142
		[OriginalName("SlashAndTowerSettle")]
		SlashAndTowerSettle,
		// Token: 0x0400C3DF RID: 50143
		[OriginalName("TowerMailSettle")]
		TowerMailSettle,
		// Token: 0x0400C3E0 RID: 50144
		[OriginalName("BirthDaySettle")]
		BirthDaySettle,
		// Token: 0x0400C3E1 RID: 50145
		[OriginalName("RacingBetsActivityEnd")]
		RacingBetsActivityEnd,
		// Token: 0x0400C3E2 RID: 50146
		[OriginalName("NewbieCarnivalReissueAward")]
		NewbieCarnivalReissueAward,
		// Token: 0x0400C3E3 RID: 50147
		[OriginalName("PhantomBattleLimitSettleReward")]
		PhantomBattleLimitSettleReward,
		// Token: 0x0400C3E4 RID: 50148
		[OriginalName("FloroMailSettle")]
		FloroMailSettle,
		// Token: 0x0400C3E5 RID: 50149
		[OriginalName("FixQuestTreasureBox")]
		FixQuestTreasureBox,
		// Token: 0x0400C3E6 RID: 50150
		[OriginalName("TrapDefenseActivitySettle")]
		TrapDefenseActivitySettle,
		// Token: 0x0400C3E7 RID: 50151
		[OriginalName("FunPlayActivityClose")]
		FunPlayActivityClose,
		// Token: 0x0400C3E8 RID: 50152
		[OriginalName("JinZhouFlySend")]
		JinZhouFlySend,
		// Token: 0x0400C3E9 RID: 50153
		[OriginalName("PhotoFightActivityClose")]
		PhotoFightActivityClose,
		// Token: 0x0400C3EA RID: 50154
		[OriginalName("SurvivorsTaskReward")]
		SurvivorsTaskReward,
		// Token: 0x0400C3EB RID: 50155
		[OriginalName("SurvivorsScoreReward")]
		SurvivorsScoreReward,
		// Token: 0x0400C3EC RID: 50156
		[OriginalName("HonamiStoryLimitSettleReward")]
		HonamiStoryLimitSettleReward,
		// Token: 0x0400C3ED RID: 50157
		[OriginalName("RegressActivityDelayOpen")]
		RegressActivityDelayOpen,
		// Token: 0x0400C3EE RID: 50158
		[OriginalName("ArtemisActivityReward")]
		ArtemisActivityReward,
		// Token: 0x0400C3EF RID: 50159
		[OriginalName("MotorcycleIpLink")]
		MotorcycleIpLink,
		// Token: 0x0400C3F0 RID: 50160
		[OriginalName("InfrThemeActivityClose")]
		InfrThemeActivityClose,
		// Token: 0x0400C3F1 RID: 50161
		[OriginalName("NewTowerScoreReward")]
		NewTowerScoreReward,
		// Token: 0x0400C3F2 RID: 50162
		[OriginalName("MotorLimitSettleReward")]
		MotorLimitSettleReward,
		// Token: 0x0400C3F3 RID: 50163
		[OriginalName("NewPlayerSupportActTaskRewardReissue")]
		NewPlayerSupportActTaskRewardReissue,
		// Token: 0x0400C3F4 RID: 50164
		[OriginalName("MotorParkourActivityReward")]
		MotorParkourActivityReward,
		// Token: 0x0400C3F5 RID: 50165
		[OriginalName("TotalTopUpSettleReward")]
		TotalTopUpSettleReward,
		// Token: 0x0400C3F6 RID: 50166
		[OriginalName("MotorFightActivityClose")]
		MotorFightActivityClose,
		// Token: 0x0400C3F7 RID: 50167
		[OriginalName("WeekCardRewardSettle")]
		WeekCardRewardSettle,
		// Token: 0x0400C3F8 RID: 50168
		[OriginalName("FarmGoldActivityRewardReissue")]
		FarmGoldActivityRewardReissue,
		// Token: 0x0400C3F9 RID: 50169
		[OriginalName("SpringFestival31MailSettle")]
		SpringFestival31MailSettle,
		// Token: 0x0400C3FA RID: 50170
		[OriginalName("MotorDevelopActivitySettle")]
		MotorDevelopActivitySettle,
		// Token: 0x0400C3FB RID: 50171
		[OriginalName("PhantomVicePolishNotice")]
		PhantomVicePolishNotice,
		// Token: 0x0400C3FC RID: 50172
		[OriginalName("FlagChallengeTaskRewardSettle")]
		FlagChallengeTaskRewardSettle,
		// Token: 0x0400C3FD RID: 50173
		[OriginalName("TotalTopUpReplenishment")]
		TotalTopUpReplenishment,
		// Token: 0x0400C3FE RID: 50174
		[OriginalName("FeiXuePreheatRewardSettle")]
		FeiXuePreheatRewardSettle,
		// Token: 0x0400C3FF RID: 50175
		[OriginalName("RhythmLimitTaskReissue")]
		RhythmLimitTaskReissue,
		// Token: 0x0400C400 RID: 50176
		[OriginalName("DropCatchActivityReward")]
		DropCatchActivityReward,
		// Token: 0x0400C401 RID: 50177
		[OriginalName("NewTowerSeasonAward")]
		NewTowerSeasonAward,
		// Token: 0x0400C402 RID: 50178
		[OriginalName("NewTowerSeasonScoreAward")]
		NewTowerSeasonScoreAward,
		// Token: 0x0400C403 RID: 50179
		[OriginalName("BossPilingTaskRewardSettle")]
		BossPilingTaskRewardSettle,
		// Token: 0x0400C404 RID: 50180
		[OriginalName("ThemeCelebration")]
		ThemeCelebration,
		// Token: 0x0400C405 RID: 50181
		[OriginalName("ThemeCelebrationWuWu")]
		ThemeCelebrationWuWu,
		// Token: 0x0400C406 RID: 50182
		[OriginalName("TotalTopUpCloseReplenishment")]
		TotalTopUpCloseReplenishment,
		// Token: 0x0400C407 RID: 50183
		[OriginalName("MotorDecalActivity")]
		MotorDecalActivity,
		// Token: 0x0400C408 RID: 50184
		[OriginalName("PinballMailSettle")]
		PinballMailSettle,
		// Token: 0x0400C409 RID: 50185
		[OriginalName("LinkageCheckInSettle")]
		LinkageCheckInSettle,
		// Token: 0x0400C40A RID: 50186
		[OriginalName("RoleGiftSettle")]
		RoleGiftSettle,
		// Token: 0x0400C40B RID: 50187
		[OriginalName("KurotatoLimitRewardReissue")]
		KurotatoLimitRewardReissue,
		// Token: 0x0400C40C RID: 50188
		[OriginalName("KurotatoScoreRewardReissue")]
		KurotatoScoreRewardReissue,
		// Token: 0x0400C40D RID: 50189
		[OriginalName("KurotatoResRewardReissue")]
		KurotatoResRewardReissue,
		// Token: 0x0400C40E RID: 50190
		[OriginalName("GachaAccumulateRewardSettle")]
		GachaAccumulateRewardSettle,
		// Token: 0x0400C40F RID: 50191
		[OriginalName("OnlineMotorSettle")]
		OnlineMotorSettle,
		// Token: 0x0400C410 RID: 50192
		[OriginalName("EdgeRunnerActivityMailSettle")]
		EdgeRunnerActivityMailSettle,
		// Token: 0x0400C411 RID: 50193
		[OriginalName("WeeklyFrameScoreRewardReissue")]
		WeeklyFrameScoreRewardReissue,
		// Token: 0x0400C412 RID: 50194
		[OriginalName("XboxGift")]
		XboxGift,
		// Token: 0x0400C413 RID: 50195
		[OriginalName("DangoBrawlActivityMailSettle")]
		DangoBrawlActivityMailSettle,
		// Token: 0x0400C414 RID: 50196
		[OriginalName("RoverRogueTaskRewardSettle")]
		RoverRogueTaskRewardSettle,
		// Token: 0x0400C415 RID: 50197
		[OriginalName("QingXiaoActivityMailSettle")]
		QingXiaoActivityMailSettle,
		// Token: 0x0400C416 RID: 50198
		[OriginalName("TimePointRewardActivityMailSettle")]
		TimePointRewardActivityMailSettle,
		// Token: 0x0400C417 RID: 50199
		[OriginalName("SolarSchoolLimitTaskReissue")]
		SolarSchoolLimitTaskReissue,
		// Token: 0x0400C418 RID: 50200
		[OriginalName("RoleTowerLimitRewardReissue")]
		RoleTowerLimitRewardReissue = 116,
		// Token: 0x0400C419 RID: 50201
		[OriginalName("RoleTowerScoreRewardReissue")]
		RoleTowerScoreRewardReissue
	}
}
