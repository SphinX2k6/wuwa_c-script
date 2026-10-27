using System;

namespace CSharpScript.Game.Common
{
	// Token: 0x0200728A RID: 29322
	public enum ELocalStoragePlayerKey
	{
		// Token: 0x04025D56 RID: 154966
		FirstOpenShop,
		// Token: 0x04025D57 RID: 154967
		CookerLevelKey,
		// Token: 0x04025D58 RID: 154968
		EditBattleTeam,
		// Token: 0x04025D59 RID: 154969
		GachaPoolOpenRecord,
		// Token: 0x04025D5A RID: 154970
		InventoryCommonItem,
		// Token: 0x04025D5B RID: 154971
		InventoryAttributeItem,
		// Token: 0x04025D5C RID: 154972
		InventoryCommonItemRedDot,
		// Token: 0x04025D5D RID: 154973
		InventoryAttributeItemRedDot,
		// Token: 0x04025D5E RID: 154974
		RouletteAssemblyItemRedDot,
		// Token: 0x04025D5F RID: 154975
		GetItemConfigListSaveKey,
		// Token: 0x04025D60 RID: 154976
		ComposeLevelKey,
		// Token: 0x04025D61 RID: 154977
		ForgingLevelKey,
		// Token: 0x04025D62 RID: 154978
		Chat,
		// Token: 0x04025D63 RID: 154979
		BattlePassPayButton,
		// Token: 0x04025D64 RID: 154980
		MonthCardNextShowRedDotTime,
		// Token: 0x04025D65 RID: 154981
		IsErrorChatReplace,
		// Token: 0x04025D66 RID: 154982
		LocalFriendApplication,
		// Token: 0x04025D67 RID: 154983
		MarqueeScrollingMap,
		// Token: 0x04025D68 RID: 154984
		LoginTime,
		// Token: 0x04025D69 RID: 154985
		LastTimeUploadStamp,
		// Token: 0x04025D6A RID: 154986
		Activity,
		// Token: 0x04025D6B RID: 154987
		IsTriggerMobileGuide,
		// Token: 0x04025D6C RID: 154988
		IsTriggerDesktopGuide,
		// Token: 0x04025D6D RID: 154989
		AutoInteractionGuideAppearCount,
		// Token: 0x04025D6E RID: 154990
		IsSimpleDetail,
		// Token: 0x04025D6F RID: 154991
		VisionSpecialSkillShowMap,
		// Token: 0x04025D70 RID: 154992
		ItemGridDropDown,
		// Token: 0x04025D71 RID: 154993
		HasShowNewMailTipsMap,
		// Token: 0x04025D72 RID: 154994
		RoguelikeDescModel,
		// Token: 0x04025D73 RID: 154995
		RoleDataItem,
		// Token: 0x04025D74 RID: 154996
		PersonalDataItem,
		// Token: 0x04025D75 RID: 154997
		CalabashCollect,
		// Token: 0x04025D76 RID: 154998
		CalabashCollectIsSimpleDetail,
		// Token: 0x04025D77 RID: 154999
		RoguelikeShopRecord,
		// Token: 0x04025D78 RID: 155000
		RoguelikeShopNextTimeStamp,
		// Token: 0x04025D79 RID: 155001
		VisionSkin,
		// Token: 0x04025D7A RID: 155002
		SilentTips,
		// Token: 0x04025D7B RID: 155003
		GachaRoleRecord,
		// Token: 0x04025D7C RID: 155004
		GachaWeaponRecord,
		// Token: 0x04025D7D RID: 155005
		RouletteAction01OpenConfig,
		// Token: 0x04025D7E RID: 155006
		RouletteAction02OpenConfig,
		// Token: 0x04025D7F RID: 155007
		MoonChasingShopItemUnlock,
		// Token: 0x04025D80 RID: 155008
		MoonChasingShopItemChecked,
		// Token: 0x04025D81 RID: 155009
		MoonChasingRoleUnlock,
		// Token: 0x04025D82 RID: 155010
		MoonChasingQuestUnlock,
		// Token: 0x04025D83 RID: 155011
		MoonChasingMemoryChecked,
		// Token: 0x04025D84 RID: 155012
		LoopTowerIsClickSeason,
		// Token: 0x04025D85 RID: 155013
		LoopTowerIsClickShop,
		// Token: 0x04025D86 RID: 155014
		TowerOverLockArea,
		// Token: 0x04025D87 RID: 155015
		ActivityRecallWatchFirstShow,
		// Token: 0x04025D88 RID: 155016
		ActivityRecallSplashFirstShowTime,
		// Token: 0x04025D89 RID: 155017
		ActivityRecallWatchFirstShowTime,
		// Token: 0x04025D8A RID: 155018
		ActivityRegressSignLastDailyFirstShowTimeStamp,
		// Token: 0x04025D8B RID: 155019
		ActivityRegressShopRedDotCheckedInPeriod,
		// Token: 0x04025D8C RID: 155020
		ActivityRegressQuestionnaireRedDotCheckedInPeriod,
		// Token: 0x04025D8D RID: 155021
		ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod,
		// Token: 0x04025D8E RID: 155022
		ActivityRegressDoubleDropReminderLastShowTime,
		// Token: 0x04025D8F RID: 155023
		ActivityRegressDoubleDropFirstRedDotCheckedInPeriod,
		// Token: 0x04025D90 RID: 155024
		ActivityRegressBpPayButtonRedDotCheckedInPeriod,
		// Token: 0x04025D91 RID: 155025
		ActivityRegressTrialRoleRedDotCheckedInPeriod,
		// Token: 0x04025D92 RID: 155026
		ActivityRegressDoubleDropRedDotCheckedInPeriod,
		// Token: 0x04025D93 RID: 155027
		ActivityRegressRecommendRedDotCheckedInPeriod,
		// Token: 0x04025D94 RID: 155028
		ActivityRegressAdventureRedDotCheckedInPeriod,
		// Token: 0x04025D95 RID: 155029
		TowerDefenseEntered,
		// Token: 0x04025D96 RID: 155030
		VersionPreheatToQuestClicked,
		// Token: 0x04025D97 RID: 155031
		VersionPreheatBonusClicked,
		// Token: 0x04025D98 RID: 155032
		VersionPreheatToQuestPlayed,
		// Token: 0x04025D99 RID: 155033
		VersionPreheatBonusPlayed,
		// Token: 0x04025D9A RID: 155034
		Spring25FirstTimeTaskAllDone,
		// Token: 0x04025D9B RID: 155035
		Spring25FirstDoneTaskIndex,
		// Token: 0x04025D9C RID: 155036
		Spring25FirstLetterClick,
		// Token: 0x04025D9D RID: 155037
		Spring25FirstEnter,
		// Token: 0x04025D9E RID: 155038
		MoonChasingDelegation,
		// Token: 0x04025D9F RID: 155039
		ShowPersonalTip,
		// Token: 0x04025DA0 RID: 155040
		HasCleanInvalidCustomMark,
		// Token: 0x04025DA1 RID: 155041
		SortConfig,
		// Token: 0x04025DA2 RID: 155042
		FilterConfig,
		// Token: 0x04025DA3 RID: 155043
		FragmentMemoryOpened,
		// Token: 0x04025DA4 RID: 155044
		VisionRecoveryBatchTip,
		// Token: 0x04025DA5 RID: 155045
		VisionRecoveryBatchAimTip,
		// Token: 0x04025DA6 RID: 155046
		VisionRefineTip,
		// Token: 0x04025DA7 RID: 155047
		AuToTrackQuestTime,
		// Token: 0x04025DA8 RID: 155048
		GoodsRemindMap,
		// Token: 0x04025DA9 RID: 155049
		WeaponSkinRedDot,
		// Token: 0x04025DAA RID: 155050
		FlySkinRedDot,
		// Token: 0x04025DAB RID: 155051
		CalabashSkinRedDot,
		// Token: 0x04025DAC RID: 155052
		MowingRiskIsInstanceNew,
		// Token: 0x04025DAD RID: 155053
		TowerDefenseNewLevel,
		// Token: 0x04025DAE RID: 155054
		MailBindNextShowRedDotTime,
		// Token: 0x04025DAF RID: 155055
		ShowSkillResume,
		// Token: 0x04025DB0 RID: 155056
		ShowSkillShowTag,
		// Token: 0x04025DB1 RID: 155057
		GamepadUsageRecord,
		// Token: 0x04025DB2 RID: 155058
		RedDotAdventureNewSoundAreaTabLastUpdateTime,
		// Token: 0x04025DB3 RID: 155059
		VisionLevelUpMaterialPutInMode,
		// Token: 0x04025DB4 RID: 155060
		VisionLevelUpMaterialUseType,
		// Token: 0x04025DB5 RID: 155061
		VisionLevelUpSettingRedDot,
		// Token: 0x04025DB6 RID: 155062
		VisionLevelUpIdentifyRedDot,
		// Token: 0x04025DB7 RID: 155063
		DirectTrainGotoRedDotHaveDisplayed,
		// Token: 0x04025DB8 RID: 155064
		DirectTrainGotoRedDotHaveDisplayedByActId,
		// Token: 0x04025DB9 RID: 155065
		DirectTrainMakeRoleChange,
		// Token: 0x04025DBA RID: 155066
		DetectionRedDotRecord,
		// Token: 0x04025DBB RID: 155067
		SuitWeaponFirstWearRecord,
		// Token: 0x04025DBC RID: 155068
		RoleSkinRedDot,
		// Token: 0x04025DBD RID: 155069
		NewLordGymEntranceIdRecord,
		// Token: 0x04025DBE RID: 155070
		SailingIsFix,
		// Token: 0x04025DBF RID: 155071
		VisionTopTipsState,
		// Token: 0x04025DC0 RID: 155072
		FirstOpenVisionGroup,
		// Token: 0x04025DC1 RID: 155073
		ShipTowerSeason,
		// Token: 0x04025DC2 RID: 155074
		AdventrueShipTowerSeason,
		// Token: 0x04025DC3 RID: 155075
		AdventrueWeeklyRogue,
		// Token: 0x04025DC4 RID: 155076
		AdventrueTower,
		// Token: 0x04025DC5 RID: 155077
		DockyardListItemRead,
		// Token: 0x04025DC6 RID: 155078
		FilterRedPoint,
		// Token: 0x04025DC7 RID: 155079
		SolarSpeedInstanceClicked,
		// Token: 0x04025DC8 RID: 155080
		PayShopTabItemChecked,
		// Token: 0x04025DC9 RID: 155081
		FishingHandBookItemRecord,
		// Token: 0x04025DCA RID: 155082
		FishingShipSkinRecord,
		// Token: 0x04025DCB RID: 155083
		ShipTowerGetBuffSet,
		// Token: 0x04025DCC RID: 155084
		ShipTowerExchangeInstId,
		// Token: 0x04025DCD RID: 155085
		ExploreActivityFirstUnlock,
		// Token: 0x04025DCE RID: 155086
		PlayerTitleRecord,
		// Token: 0x04025DCF RID: 155087
		PlayerTitleUnlockRedDot,
		// Token: 0x04025DD0 RID: 155088
		VersionRedDotMap,
		// Token: 0x04025DD1 RID: 155089
		BabelTowerNewLevel,
		// Token: 0x04025DD2 RID: 155090
		BabelTowerNewLevelHasClick,
		// Token: 0x04025DD3 RID: 155091
		InviteNewbieEntered,
		// Token: 0x04025DD4 RID: 155092
		AbyssDangoFormationSelect,
		// Token: 0x04025DD5 RID: 155093
		RogueResDungeonNewest,
		// Token: 0x04025DD6 RID: 155094
		RogueResSkillTreeOpen,
		// Token: 0x04025DD7 RID: 155095
		RogueResEndingOpen,
		// Token: 0x04025DD8 RID: 155096
		RogueResShopRefresh,
		// Token: 0x04025DD9 RID: 155097
		RogueResShopNewGoods,
		// Token: 0x04025DDA RID: 155098
		RogueResTaskOpen,
		// Token: 0x04025DDB RID: 155099
		RogueResTrialOpen,
		// Token: 0x04025DDC RID: 155100
		RogueResNewRoleFlag,
		// Token: 0x04025DDD RID: 155101
		RogueResMapScale,
		// Token: 0x04025DDE RID: 155102
		DangoMonopolyActivityId,
		// Token: 0x04025DDF RID: 155103
		DangoMonopolySpeed,
		// Token: 0x04025DE0 RID: 155104
		DangoMonopolyLastEnterBoard,
		// Token: 0x04025DE1 RID: 155105
		DangoMonopolyNewTask,
		// Token: 0x04025DE2 RID: 155106
		RacingBetsMatchViewRecord,
		// Token: 0x04025DE3 RID: 155107
		RacingBetsRankViewRecord,
		// Token: 0x04025DE4 RID: 155108
		RacingBetsReplayGameRecord,
		// Token: 0x04025DE5 RID: 155109
		RacingBetsWatchGameRecord,
		// Token: 0x04025DE6 RID: 155110
		RacingBetsSettlementMainViewRecord,
		// Token: 0x04025DE7 RID: 155111
		RacingBetsBettingMainViewRecord,
		// Token: 0x04025DE8 RID: 155112
		RacingBetsBulletScreenAlphaRecord,
		// Token: 0x04025DE9 RID: 155113
		RacingBetsBulletScreenShowTypeRecord,
		// Token: 0x04025DEA RID: 155114
		SdkReportStateMap,
		// Token: 0x04025DEB RID: 155115
		PayShopRechargeRedDot,
		// Token: 0x04025DEC RID: 155116
		ShowNoteIdMap,
		// Token: 0x04025DED RID: 155117
		AbyssSelectRole,
		// Token: 0x04025DEE RID: 155118
		AbyssDangoLevelCheck,
		// Token: 0x04025DEF RID: 155119
		AbyssDangoRoleNew,
		// Token: 0x04025DF0 RID: 155120
		AbyssDangoEnterNew,
		// Token: 0x04025DF1 RID: 155121
		AbyssDangoFormationNew,
		// Token: 0x04025DF2 RID: 155122
		RogueResDungeonSelected,
		// Token: 0x04025DF3 RID: 155123
		IsDirectTrainProOpened,
		// Token: 0x04025DF4 RID: 155124
		PhantomArenaEntranceShopRefresh,
		// Token: 0x04025DF5 RID: 155125
		PhantomArenaEntranceGymCheck,
		// Token: 0x04025DF6 RID: 155126
		PhantomArenaRepeatLastIndex,
		// Token: 0x04025DF7 RID: 155127
		PhantomArenaEntranceGymRedDotCheck,
		// Token: 0x04025DF8 RID: 155128
		QuestReviewNodeRedDot,
		// Token: 0x04025DF9 RID: 155129
		QuestReviewNodeUnlockAnim,
		// Token: 0x04025DFA RID: 155130
		QuestReviewLineUnlockAnim,
		// Token: 0x04025DFB RID: 155131
		QuestReviewLineDestroyAnim,
		// Token: 0x04025DFC RID: 155132
		QuestReviewTabUnlockAnim,
		// Token: 0x04025DFD RID: 155133
		QuestReviewMainViewEntryAnim,
		// Token: 0x04025DFE RID: 155134
		QuestReviewHasFused,
		// Token: 0x04025DFF RID: 155135
		QuestReviewNewLineHasFused,
		// Token: 0x04025E00 RID: 155136
		BeginnerCarnivalShop,
		// Token: 0x04025E01 RID: 155137
		BeginnerCarnivalGacha,
		// Token: 0x04025E02 RID: 155138
		BeginnerCarnivalChoseRoleView,
		// Token: 0x04025E03 RID: 155139
		FloroRanchSpeed,
		// Token: 0x04025E04 RID: 155140
		MoraleAreaUnlockFlagSet,
		// Token: 0x04025E05 RID: 155141
		MoraleTipsAreaBuff,
		// Token: 0x04025E06 RID: 155142
		MoraleActiveAreaBuff,
		// Token: 0x04025E07 RID: 155143
		RoleTutorialNew,
		// Token: 0x04025E08 RID: 155144
		AdventrueItemNew,
		// Token: 0x04025E09 RID: 155145
		VisionSuitFilter,
		// Token: 0x04025E0A RID: 155146
		FloroRanchSkillId,
		// Token: 0x04025E0B RID: 155147
		FloroRanchSkillIdWeekly,
		// Token: 0x04025E0C RID: 155148
		CustomizedThumbnailShow,
		// Token: 0x04025E0D RID: 155149
		VisionLevelUpIdentify,
		// Token: 0x04025E0E RID: 155150
		FloroRanchSelectedRaceIds,
		// Token: 0x04025E0F RID: 155151
		FloroRanchSkillRedDot,
		// Token: 0x04025E10 RID: 155152
		FloroRanchCardRedDot,
		// Token: 0x04025E11 RID: 155153
		FloroRanchCardInGameRedDot,
		// Token: 0x04025E12 RID: 155154
		FloroRanchToyRedDot,
		// Token: 0x04025E13 RID: 155155
		FloroRanchRaceRedDot,
		// Token: 0x04025E14 RID: 155156
		WeeklyRogueExtraEnterTips,
		// Token: 0x04025E15 RID: 155157
		LoopTowerSeason,
		// Token: 0x04025E16 RID: 155158
		IntroductionVersion,
		// Token: 0x04025E17 RID: 155159
		TrapDefenseBuildingClicked,
		// Token: 0x04025E18 RID: 155160
		TrapDefenseAuxiliaryClicked,
		// Token: 0x04025E19 RID: 155161
		TrapDefenseBdBuffUnlock,
		// Token: 0x04025E1A RID: 155162
		TrapDefenseLevelReachOpenTime,
		// Token: 0x04025E1B RID: 155163
		TrapDefenseRougeModeOpen,
		// Token: 0x04025E1C RID: 155164
		TrapDefenseRougeModeOpenSub,
		// Token: 0x04025E1D RID: 155165
		SurvivorsHandbookClicked,
		// Token: 0x04025E1E RID: 155166
		FightPhotoLevelRedDot,
		// Token: 0x04025E1F RID: 155167
		QuestTreeNodeNewTag,
		// Token: 0x04025E20 RID: 155168
		SubDownLoadAgreeUseCellData,
		// Token: 0x04025E21 RID: 155169
		SubDownLoadLastDownLoadList,
		// Token: 0x04025E22 RID: 155170
		HonamiStoryMascotUnlockSet,
		// Token: 0x04025E23 RID: 155171
		HonamiStoryWeaponUnlockSet,
		// Token: 0x04025E24 RID: 155172
		HonamiStoryMainButtonUnlockSet,
		// Token: 0x04025E25 RID: 155173
		HonamiStorySelectLvAreaUnLockTips,
		// Token: 0x04025E26 RID: 155174
		HonamiStorySelectLvUnLockTips,
		// Token: 0x04025E27 RID: 155175
		HonamiStorySelectLvTowerUnLockTips,
		// Token: 0x04025E28 RID: 155176
		HonamiStorySelectLvTowerUnLockTogRedDot,
		// Token: 0x04025E29 RID: 155177
		HonamiStorySelectLvTowerUnLockBtnGoRedDot,
		// Token: 0x04025E2A RID: 155178
		HonamiStorySkillDescMode,
		// Token: 0x04025E2B RID: 155179
		FirstOpenCommonWeaponSelect,
		// Token: 0x04025E2C RID: 155180
		SubDownLoadClearOnLogin,
		// Token: 0x04025E2D RID: 155181
		MotorcycleMusicRedDot,
		// Token: 0x04025E2E RID: 155182
		MotorcycleCurPlayAlbumId,
		// Token: 0x04025E2F RID: 155183
		MotorcycleCurPlayMusicId,
		// Token: 0x04025E30 RID: 155184
		MotorcyclePlayMode,
		// Token: 0x04025E31 RID: 155185
		FirstUnlockArtemisDayMap,
		// Token: 0x04025E32 RID: 155186
		FirstPlayArtemisPlaneAnimMap,
		// Token: 0x04025E33 RID: 155187
		RemindCanUpgradedLaHaiLuo,
		// Token: 0x04025E34 RID: 155188
		RemindCanUpgradedRiLing,
		// Token: 0x04025E35 RID: 155189
		InfrRecordObservatoryLevel,
		// Token: 0x04025E36 RID: 155190
		InfrRoadMarkUnlockRecord,
		// Token: 0x04025E37 RID: 155191
		InfrObservatoryLevelUpSeq,
		// Token: 0x04025E38 RID: 155192
		MapNPCMarkShowSeq,
		// Token: 0x04025E39 RID: 155193
		RegionalTerminalBarFoldState,
		// Token: 0x04025E3A RID: 155194
		PhantomArenaChallengeUnlockRedDotCheck,
		// Token: 0x04025E3B RID: 155195
		PhantomArenaMapUnlockRedDotCheck,
		// Token: 0x04025E3C RID: 155196
		MotorParkourLevelClicked,
		// Token: 0x04025E3D RID: 155197
		CyberPunkBossEntranceFirstClicked,
		// Token: 0x04025E3E RID: 155198
		WeatherCentralClicked,
		// Token: 0x04025E3F RID: 155199
		PhantomInteractNewUnlock,
		// Token: 0x04025E40 RID: 155200
		NewPlayerSupportTrialRoleEntranceRedDot,
		// Token: 0x04025E41 RID: 155201
		TrialRoleGroupUnlock,
		// Token: 0x04025E42 RID: 155202
		ActivityNewPlayerSupportFirstShow,
		// Token: 0x04025E43 RID: 155203
		MotorDevelopIsFirstDailyExpLimit,
		// Token: 0x04025E44 RID: 155204
		MotorDevelopNewUnlockTree,
		// Token: 0x04025E45 RID: 155205
		MotorDiyNewUnlockId,
		// Token: 0x04025E46 RID: 155206
		MotorFightLevelClicked,
		// Token: 0x04025E47 RID: 155207
		MotorFightItemClicked,
		// Token: 0x04025E48 RID: 155208
		MotorFightRoleClicked,
		// Token: 0x04025E49 RID: 155209
		DrinksUnlockLevelClicked,
		// Token: 0x04025E4A RID: 155210
		GuessJokerUnlockLevelClicked,
		// Token: 0x04025E4B RID: 155211
		GuessJokerFirstFinishAnim,
		// Token: 0x04025E4C RID: 155212
		FlagChallengeFormationRoleIds,
		// Token: 0x04025E4D RID: 155213
		FeedbackRewardHaveShowRewardId,
		// Token: 0x04025E4E RID: 155214
		SpringManorBrochureUnlockSequencePlayed,
		// Token: 0x04025E4F RID: 155215
		CoopLevelFirstRedDotClicked,
		// Token: 0x04025E50 RID: 155216
		CoopPhotoRedDotClicked,
		// Token: 0x04025E51 RID: 155217
		PhantomDiscardPlanRecycleSet,
		// Token: 0x04025E52 RID: 155218
		RhythmShipLocalCalibrationValue,
		// Token: 0x04025E53 RID: 155219
		RhythmShipHavePlayAniLevelId,
		// Token: 0x04025E54 RID: 155220
		BossPilingQuestClicked,
		// Token: 0x04025E55 RID: 155221
		BossPilingLevelNew,
		// Token: 0x04025E56 RID: 155222
		RoguelikeInstanceSelectGroupIndex,
		// Token: 0x04025E57 RID: 155223
		RoguelikeInstanceSelectEntryId,
		// Token: 0x04025E58 RID: 155224
		RoguelikeFormationIdList,
		// Token: 0x04025E59 RID: 155225
		RoguelikeSelectPhantomId,
		// Token: 0x04025E5A RID: 155226
		RoleVoiceMap,
		// Token: 0x04025E5B RID: 155227
		RoleTrialRemindMap,
		// Token: 0x04025E5C RID: 155228
		GolemHackingBonusLevelGroupPlayed,
		// Token: 0x04025E5D RID: 155229
		GolemHackingActivityLevelTime,
		// Token: 0x04025E5E RID: 155230
		ShouldSaveCaptureCollectFlag,
		// Token: 0x04025E5F RID: 155231
		FirstOpenDailyActivityDailyTab,
		// Token: 0x04025E60 RID: 155232
		FirstOpenDailyActivityWeeklyTab,
		// Token: 0x04025E61 RID: 155233
		IgnoreWheelTowerSeasonReviewMedalCheck,
		// Token: 0x04025E62 RID: 155234
		RoguelikeShopItemChecked,
		// Token: 0x04025E63 RID: 155235
		SheriffHideCompletedMarkItem,
		// Token: 0x04025E64 RID: 155236
		SubPackageRecommendConfirmShown,
		// Token: 0x04025E65 RID: 155237
		RoleLangCustomRecord,
		// Token: 0x04025E66 RID: 155238
		RoverRogueLastPassRoleType,
		// Token: 0x04025E67 RID: 155239
		UseFormation3DView,
		// Token: 0x04025E68 RID: 155240
		RoverRogueSeenUnlockedInsIds,
		// Token: 0x04025E69 RID: 155241
		RoverRogueSeenUnlockedBlessIds,
		// Token: 0x04025E6A RID: 155242
		RoverRogueSeenUnlockedLootIds,
		// Token: 0x04025E6B RID: 155243
		GiantAccessReadIds,
		// Token: 0x04025E6C RID: 155244
		GiantCommissionRedDotClicked,
		// Token: 0x04025E6D RID: 155245
		SubDownLoadRecallProtectedIds,
		// Token: 0x04025E6E RID: 155246
		GiantInteractReadNodeIds
	}
}
