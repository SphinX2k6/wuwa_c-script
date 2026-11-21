using System;
using CSharpScript.Core.Common;

// Token: 0x0200289E RID: 10398
[EnumExtensions]
public enum ERedDotName
{
	// Token: 0x0400E771 RID: 59249
	[EnumStringMember("Test")]
	Test,
	// Token: 0x0400E772 RID: 59250
	[EnumStringMember("BattleViewMenu")]
	BattleViewMenu,
	// Token: 0x0400E773 RID: 59251
	[EnumStringMember("BattleViewResonanceButton")]
	BattleViewResonanceButton,
	// Token: 0x0400E774 RID: 59252
	[EnumStringMember("BattleViewShopButton")]
	BattleViewShopButton,
	// Token: 0x0400E775 RID: 59253
	[EnumStringMember("BattleViewGachaButton")]
	BattleViewGachaButton,
	// Token: 0x0400E776 RID: 59254
	[EnumStringMember("MailFilterAll")]
	MailFilterAll,
	// Token: 0x0400E777 RID: 59255
	[EnumStringMember("FilterImportant")]
	FilterImportant,
	// Token: 0x0400E778 RID: 59256
	[EnumStringMember("FilterUnScanned")]
	FilterUnScanned,
	// Token: 0x0400E779 RID: 59257
	[EnumStringMember("RoleSystemRoleList")]
	RoleSystemRoleList,
	// Token: 0x0400E77A RID: 59258
	[EnumStringMember("RoleAttributeTab")]
	RoleAttributeTab,
	// Token: 0x0400E77B RID: 59259
	[EnumStringMember("RoleAttributeTabLevelUp")]
	RoleAttributeTabLevelUp,
	// Token: 0x0400E77C RID: 59260
	[EnumStringMember("RoleAttributeTabBreakUp")]
	RoleAttributeTabBreakUp,
	// Token: 0x0400E77D RID: 59261
	[EnumStringMember("RoleSkin")]
	RoleSkin,
	// Token: 0x0400E77E RID: 59262
	[EnumStringMember("RoleChange")]
	RoleChange,
	// Token: 0x0400E77F RID: 59263
	[EnumStringMember("FlySkinTab")]
	FlySkinTab,
	// Token: 0x0400E780 RID: 59264
	[EnumStringMember("FlySkinChildTab")]
	FlySkinChildTab,
	// Token: 0x0400E781 RID: 59265
	[EnumStringMember("HuluSkinTab")]
	HuluSkinTab,
	// Token: 0x0400E782 RID: 59266
	[EnumStringMember("RoleOrnamentTab")]
	RoleOrnamentTab,
	// Token: 0x0400E783 RID: 59267
	[EnumStringMember("RoleWeaponTabBreakUp")]
	RoleWeaponTabBreakUp,
	// Token: 0x0400E784 RID: 59268
	[EnumStringMember("RoleFavorTab")]
	RoleFavorTab,
	// Token: 0x0400E785 RID: 59269
	[EnumStringMember("RoleSkillTabPhantomSkill")]
	RoleSkillTabPhantomSkill,
	// Token: 0x0400E786 RID: 59270
	[EnumStringMember("RoleChipTab")]
	RoleChipTab,
	// Token: 0x0400E787 RID: 59271
	[EnumStringMember("RoleChipTabHole")]
	RoleChipTabHole,
	// Token: 0x0400E788 RID: 59272
	[EnumStringMember("RoleResonanceTab")]
	RoleResonanceTab,
	// Token: 0x0400E789 RID: 59273
	[EnumStringMember("RoleResonanceTabHole")]
	RoleResonanceTabHole,
	// Token: 0x0400E78A RID: 59274
	[EnumStringMember("RedDotResonanceBtn")]
	RedDotResonanceBtn,
	// Token: 0x0400E78B RID: 59275
	[EnumStringMember("RoleSelectionList")]
	RoleSelectionList,
	// Token: 0x0400E78C RID: 59276
	[EnumStringMember("FunctionRole")]
	FunctionRole,
	// Token: 0x0400E78D RID: 59277
	[EnumStringMember("FunctionPhantom")]
	FunctionPhantom,
	// Token: 0x0400E78E RID: 59278
	[EnumStringMember("FunctionFriend")]
	FunctionFriend,
	// Token: 0x0400E78F RID: 59279
	[EnumStringMember("FunctionGacha")]
	FunctionGacha,
	// Token: 0x0400E790 RID: 59280
	[EnumStringMember("FunctionTutorial")]
	FunctionTutorial,
	// Token: 0x0400E791 RID: 59281
	[EnumStringMember("FunctionAdventure")]
	FunctionAdventure,
	// Token: 0x0400E792 RID: 59282
	[EnumStringMember("FunctionCalabash")]
	FunctionCalabash,
	// Token: 0x0400E793 RID: 59283
	[EnumStringMember("FunctionInventory")]
	FunctionInventory,
	// Token: 0x0400E794 RID: 59284
	[EnumStringMember("FunctionMail")]
	FunctionMail,
	// Token: 0x0400E795 RID: 59285
	[EnumStringMember("FunctionNotice")]
	FunctionNotice,
	// Token: 0x0400E796 RID: 59286
	[EnumStringMember("FunctionPayShop")]
	FunctionPayShop,
	// Token: 0x0400E797 RID: 59287
	[EnumStringMember("FunctionPhantomExploreSet")]
	FunctionPhantomExploreSet,
	// Token: 0x0400E798 RID: 59288
	[EnumStringMember("FunctionMailBind")]
	FunctionMailBind,
	// Token: 0x0400E799 RID: 59289
	[EnumStringMember("FunctionKuroStreet")]
	FunctionKuroStreet,
	// Token: 0x0400E79A RID: 59290
	[EnumStringMember("FunctionMap")]
	FunctionMap,
	// Token: 0x0400E79B RID: 59291
	[EnumStringMember("FunctionPhotograph")]
	FunctionPhotograph,
	// Token: 0x0400E79C RID: 59292
	[EnumStringMember("PreDownload")]
	PreDownload,
	// Token: 0x0400E79D RID: 59293
	[EnumStringMember("PreDownloadComplete")]
	PreDownloadComplete,
	// Token: 0x0400E79E RID: 59294
	[EnumStringMember("FunctionSetting")]
	FunctionSetting,
	// Token: 0x0400E79F RID: 59295
	[EnumStringMember("FunctionPhoneMsg")]
	FunctionPhoneMsg,
	// Token: 0x0400E7A0 RID: 59296
	[EnumStringMember("FunctionWeatherCentral")]
	FunctionWeatherCentral,
	// Token: 0x0400E7A1 RID: 59297
	[EnumStringMember("FunctionMotorDevelop")]
	FunctionMotorDevelop,
	// Token: 0x0400E7A2 RID: 59298
	[EnumStringMember("PhoneMsgChatItemRedDot")]
	PhoneMsgChatItemRedDot,
	// Token: 0x0400E7A3 RID: 59299
	[EnumStringMember("PhoneMsgChatPartnerRedDot")]
	PhoneMsgChatPartnerRedDot,
	// Token: 0x0400E7A4 RID: 59300
	[EnumStringMember("PhoneMsgChatPartnerRedDotGiftIcon")]
	PhoneMsgChatPartnerRedDotGiftIcon,
	// Token: 0x0400E7A5 RID: 59301
	[EnumStringMember("MapAreaExplore")]
	MapAreaExplore,
	// Token: 0x0400E7A6 RID: 59302
	[EnumStringMember("MapAreaBoxReward")]
	MapAreaBoxReward,
	// Token: 0x0400E7A7 RID: 59303
	[EnumStringMember("MapAreaShowTabCountry")]
	MapAreaShowTabCountry,
	// Token: 0x0400E7A8 RID: 59304
	[EnumStringMember("MapAreaShowTabState")]
	MapAreaShowTabState,
	// Token: 0x0400E7A9 RID: 59305
	[EnumStringMember("MapAreaShowTabArea")]
	MapAreaShowTabArea,
	// Token: 0x0400E7AA RID: 59306
	[EnumStringMember("ShipTower")]
	ShipTower,
	// Token: 0x0400E7AB RID: 59307
	[EnumStringMember("ShipTowerReward")]
	ShipTowerReward,
	// Token: 0x0400E7AC RID: 59308
	[EnumStringMember("CalabashTab")]
	CalabashTab,
	// Token: 0x0400E7AD RID: 59309
	[EnumStringMember("VisionRecovery")]
	VisionRecovery,
	// Token: 0x0400E7AE RID: 59310
	[EnumStringMember("VisionRefine")]
	VisionRefine,
	// Token: 0x0400E7AF RID: 59311
	[EnumStringMember("FriendNewApplication")]
	FriendNewApplication,
	// Token: 0x0400E7B0 RID: 59312
	[EnumStringMember("ChatRoom")]
	ChatRoom,
	// Token: 0x0400E7B1 RID: 59313
	[EnumStringMember("ChatView")]
	ChatView,
	// Token: 0x0400E7B2 RID: 59314
	[EnumStringMember("TutorialItemNew")]
	TutorialItemNew,
	// Token: 0x0400E7B3 RID: 59315
	[EnumStringMember("TutorialTypeNew")]
	TutorialTypeNew,
	// Token: 0x0400E7B4 RID: 59316
	[EnumStringMember("AdventureManual")]
	AdventureManual,
	// Token: 0x0400E7B5 RID: 59317
	[EnumStringMember("AdventureBattleButton")]
	AdventureBattleButton,
	// Token: 0x0400E7B6 RID: 59318
	[EnumStringMember("AdventureFirstAward")]
	AdventureFirstAward,
	// Token: 0x0400E7B7 RID: 59319
	[EnumStringMember("AdventureFirstAwardCategory")]
	AdventureFirstAwardCategory,
	// Token: 0x0400E7B8 RID: 59320
	[EnumStringMember("AdventureFirstAwardResult")]
	AdventureFirstAwardResult,
	// Token: 0x0400E7B9 RID: 59321
	[EnumStringMember("AdventureDailyActivityTab")]
	AdventureDailyActivityTab,
	// Token: 0x0400E7BA RID: 59322
	[EnumStringMember("AdventureDailyActivityTabDaily")]
	AdventureDailyActivityTabDaily,
	// Token: 0x0400E7BB RID: 59323
	[EnumStringMember("AdventureDailyActivityTabWeekly")]
	AdventureDailyActivityTabWeekly,
	// Token: 0x0400E7BC RID: 59324
	[EnumStringMember("AdventureNewSoundAreaTab")]
	AdventureNewSoundAreaTab,
	// Token: 0x0400E7BD RID: 59325
	[EnumStringMember("AdventureNewSoundAreaGeneral")]
	AdventureNewSoundAreaGeneral,
	// Token: 0x0400E7BE RID: 59326
	[EnumStringMember("AdventureChallengeTab")]
	AdventureChallengeTab,
	// Token: 0x0400E7BF RID: 59327
	[EnumStringMember("AdventurePeriodicityTab")]
	AdventurePeriodicityTab,
	// Token: 0x0400E7C0 RID: 59328
	[EnumStringMember("InfluenceReputation")]
	InfluenceReputation,
	// Token: 0x0400E7C1 RID: 59329
	[EnumStringMember("InfluenceReward")]
	InfluenceReward,
	// Token: 0x0400E7C2 RID: 59330
	[EnumStringMember("CookerLevel")]
	CookerLevel,
	// Token: 0x0400E7C3 RID: 59331
	[EnumStringMember("CookerLevelMain")]
	CookerLevelMain,
	// Token: 0x0400E7C4 RID: 59332
	[EnumStringMember("BattlePass")]
	BattlePass,
	// Token: 0x0400E7C5 RID: 59333
	[EnumStringMember("BattlePassTask")]
	BattlePassTask,
	// Token: 0x0400E7C6 RID: 59334
	[EnumStringMember("BattlePassReward")]
	BattlePassReward,
	// Token: 0x0400E7C7 RID: 59335
	[EnumStringMember("BattlePassAlwaysTaskTab")]
	BattlePassAlwaysTaskTab,
	// Token: 0x0400E7C8 RID: 59336
	[EnumStringMember("BattlePassWeekTaskTab")]
	BattlePassWeekTaskTab,
	// Token: 0x0400E7C9 RID: 59337
	[EnumStringMember("BattlePassDayTaskTab")]
	BattlePassDayTaskTab,
	// Token: 0x0400E7CA RID: 59338
	[EnumStringMember("RoleHandBook")]
	RoleHandBook,
	// Token: 0x0400E7CB RID: 59339
	[EnumStringMember("RoleHandBookActiveButton")]
	RoleHandBookActiveButton,
	// Token: 0x0400E7CC RID: 59340
	[EnumStringMember("ComposeReagentProduction")]
	ComposeReagentProduction,
	// Token: 0x0400E7CD RID: 59341
	[EnumStringMember("ItemHandBook")]
	ItemHandBook,
	// Token: 0x0400E7CE RID: 59342
	[EnumStringMember("PhantomHandBook")]
	PhantomHandBook,
	// Token: 0x0400E7CF RID: 59343
	[EnumStringMember("Achievement")]
	Achievement,
	// Token: 0x0400E7D0 RID: 59344
	[EnumStringMember("AchievementCategory")]
	AchievementCategory,
	// Token: 0x0400E7D1 RID: 59345
	[EnumStringMember("ActivityEntrance")]
	ActivityEntrance,
	// Token: 0x0400E7D2 RID: 59346
	[EnumStringMember("CommonActivityPage")]
	CommonActivityPage,
	// Token: 0x0400E7D3 RID: 59347
	[EnumStringMember("ActivityRun")]
	ActivityRun,
	// Token: 0x0400E7D4 RID: 59348
	[EnumStringMember("BattleViewQuestButton")]
	BattleViewQuestButton,
	// Token: 0x0400E7D5 RID: 59349
	[EnumStringMember("QuestViewItem")]
	QuestViewItem,
	// Token: 0x0400E7D6 RID: 59350
	[EnumStringMember("QuestTab")]
	QuestTab,
	// Token: 0x0400E7D7 RID: 59351
	[EnumStringMember("FunctionViewQuestBtn")]
	FunctionViewQuestBtn,
	// Token: 0x0400E7D8 RID: 59352
	[EnumStringMember("InventoryVirtual")]
	InventoryVirtual,
	// Token: 0x0400E7D9 RID: 59353
	[EnumStringMember("InventoryCommon")]
	InventoryCommon,
	// Token: 0x0400E7DA RID: 59354
	[EnumStringMember("InventoryWeapon")]
	InventoryWeapon,
	// Token: 0x0400E7DB RID: 59355
	[EnumStringMember("InventoryPhantom")]
	InventoryPhantom,
	// Token: 0x0400E7DC RID: 59356
	[EnumStringMember("InventoryCollection")]
	InventoryCollection,
	// Token: 0x0400E7DD RID: 59357
	[EnumStringMember("InventoryMaterial")]
	InventoryMaterial,
	// Token: 0x0400E7DE RID: 59358
	[EnumStringMember("InventoryMission")]
	InventoryMission,
	// Token: 0x0400E7DF RID: 59359
	[EnumStringMember("InventorySpecial")]
	InventorySpecial,
	// Token: 0x0400E7E0 RID: 59360
	[EnumStringMember("InventoryCard")]
	InventoryCard,
	// Token: 0x0400E7E1 RID: 59361
	[EnumStringMember("TowerReward")]
	TowerReward,
	// Token: 0x0400E7E2 RID: 59362
	[EnumStringMember("TowerRewardByDifficulties")]
	TowerRewardByDifficulties,
	// Token: 0x0400E7E3 RID: 59363
	[EnumStringMember("IdentifyTab")]
	VisionIdentifyTab,
	// Token: 0x0400E7E4 RID: 59364
	[EnumStringMember("VisionOneKeyEquip")]
	VisionOneKeyEquip,
	// Token: 0x0400E7E5 RID: 59365
	[EnumStringMember("VisionTabRedDot")]
	VisionTabRedDot,
	// Token: 0x0400E7E6 RID: 59366
	[EnumStringMember("VisionGridRedDot")]
	VisionGridRedDot,
	// Token: 0x0400E7E7 RID: 59367
	[EnumStringMember("PayShopInstance")]
	PayShopInstance,
	// Token: 0x0400E7E8 RID: 59368
	[EnumStringMember("PayShopTab")]
	PayShopTab,
	// Token: 0x0400E7E9 RID: 59369
	[EnumStringMember("CustomerService")]
	CustomerService,
	// Token: 0x0400E7EA RID: 59370
	[EnumStringMember("Introduction")]
	Introduction,
	// Token: 0x0400E7EB RID: 59371
	[EnumStringMember("RogueSkillUnlock")]
	RogueSkillUnlock,
	// Token: 0x0400E7EC RID: 59372
	[EnumStringMember("RoguelikeAchievement")]
	RoguelikeAchievement,
	// Token: 0x0400E7ED RID: 59373
	[EnumStringMember("RoguelikeShop")]
	RoguelikeShop,
	// Token: 0x0400E7EE RID: 59374
	[EnumStringMember("RoguelikeAchievementGroup")]
	RoguelikeAchievementGroup,
	// Token: 0x0400E7EF RID: 59375
	[EnumStringMember("RogueResIllustratedTokenTab")]
	RogueResIllustratedTokenTab,
	// Token: 0x0400E7F0 RID: 59376
	[EnumStringMember("RogueResIllustratedNormalTab")]
	RogueResIllustratedNormalTab,
	// Token: 0x0400E7F1 RID: 59377
	[EnumStringMember("RogueResIllustratedMapTab")]
	RogueResIllustratedMapTab,
	// Token: 0x0400E7F2 RID: 59378
	[EnumStringMember("RogueResIllustrated")]
	RogueResIllustrated,
	// Token: 0x0400E7F3 RID: 59379
	[EnumStringMember("RogueResTask")]
	RogueResTask,
	// Token: 0x0400E7F4 RID: 59380
	[EnumStringMember("RogueResShop")]
	RogueResShop,
	// Token: 0x0400E7F5 RID: 59381
	[EnumStringMember("RogueResInst")]
	RogueResInst,
	// Token: 0x0400E7F6 RID: 59382
	[EnumStringMember("RogueResSkillTree")]
	RogueResSkillTree,
	// Token: 0x0400E7F7 RID: 59383
	[EnumStringMember("RogueResEnding")]
	RogueResEnding,
	// Token: 0x0400E7F8 RID: 59384
	[EnumStringMember("BossRushReward")]
	BossRushReward,
	// Token: 0x0400E7F9 RID: 59385
	[EnumStringMember("MowingTowerReward")]
	MowingTowerReward,
	// Token: 0x0400E7FA RID: 59386
	[EnumStringMember("TowerDefenseReward")]
	TowerDefenseReward,
	// Token: 0x0400E7FB RID: 59387
	[EnumStringMember("TowerDefenseInstance")]
	TowerDefenseInstance,
	// Token: 0x0400E7FC RID: 59388
	[EnumStringMember("RedDotMowingRiskReward")]
	RedDotMowingRiskReward,
	// Token: 0x0400E7FD RID: 59389
	[EnumStringMember("RedDotMowingRiskBuffAll")]
	RedDotMowingRiskBuffAll,
	// Token: 0x0400E7FE RID: 59390
	[EnumStringMember("FragmentMemoryReward")]
	FragmentMemoryReward,
	// Token: 0x0400E7FF RID: 59391
	[EnumStringMember("FragmentMemoryEntrance")]
	FragmentMemoryEntrance,
	// Token: 0x0400E800 RID: 59392
	[EnumStringMember("FragmentMemoryTopic")]
	FragmentMemoryTopic,
	// Token: 0x0400E801 RID: 59393
	[EnumStringMember("FragmentMemoryTopicCollectRedDot")]
	FragmentMemoryTopicCollectRedDot,
	// Token: 0x0400E802 RID: 59394
	[EnumStringMember("BattlePassPayButton")]
	BattlePassPayButton,
	// Token: 0x0400E803 RID: 59395
	[EnumStringMember("PersonalInfo")]
	PersonalizedInfo,
	// Token: 0x0400E804 RID: 59396
	[EnumStringMember("PersonalCard")]
	PersonalCard,
	// Token: 0x0400E805 RID: 59397
	[EnumStringMember("PersonalTitle")]
	PersonalTitle,
	// Token: 0x0400E806 RID: 59398
	[EnumStringMember("PersonalBirthday")]
	PersonalBirthday,
	// Token: 0x0400E807 RID: 59399
	[EnumStringMember("PersonalImageBook")]
	PersonalImageBook,
	// Token: 0x0400E808 RID: 59400
	[EnumStringMember("ActivityRecallSignEntry")]
	ActivityRecallSignEntry,
	// Token: 0x0400E809 RID: 59401
	[EnumStringMember("ActivityRecallTask")]
	ActivityRecallTaskEntry,
	// Token: 0x0400E80A RID: 59402
	[EnumStringMember("ActivityRegressQuestionnaire")]
	ActivityRegressQuestionnaire,
	// Token: 0x0400E80B RID: 59403
	[EnumStringMember("ActivityRegressShopDiscount")]
	ActivityRegressShopDiscount,
	// Token: 0x0400E80C RID: 59404
	[EnumStringMember("ActivityRegressDoubleDrop")]
	ActivityRegressDoubleDrop,
	// Token: 0x0400E80D RID: 59405
	[EnumStringMember("ActivityRegressCultivate")]
	ActivityRegressCultivate,
	// Token: 0x0400E80E RID: 59406
	[EnumStringMember("ActivityRegressConstantTask")]
	ActivityRegressConstantTask,
	// Token: 0x0400E80F RID: 59407
	[EnumStringMember("ActivityRegressTrialRole")]
	ActivityRegressTrialRole,
	// Token: 0x0400E810 RID: 59408
	[EnumStringMember("ActivityRegressBp")]
	ActivityRegressBp,
	// Token: 0x0400E811 RID: 59409
	[EnumStringMember("ActivityRegressBpTask")]
	ActivityRegressBpTask,
	// Token: 0x0400E812 RID: 59410
	[EnumStringMember("ActivityRegressBpReward")]
	ActivityRegressBpReward,
	// Token: 0x0400E813 RID: 59411
	[EnumStringMember("ActivityRegressDisposableReward")]
	ActivityRegressDisposableReward,
	// Token: 0x0400E814 RID: 59412
	[EnumStringMember("ActivityRegressRecommend")]
	ActivityRegressRecommend,
	// Token: 0x0400E815 RID: 59413
	[EnumStringMember("ActivityRegressAdventure")]
	ActivityRegressAdventure,
	// Token: 0x0400E816 RID: 59414
	[EnumStringMember("ActivityRegressRewardBtn")]
	ActivityRegressRewardBtn,
	// Token: 0x0400E817 RID: 59415
	[EnumStringMember("VisionLevelUpSetting")]
	VisionLevelUpSetting,
	// Token: 0x0400E818 RID: 59416
	[EnumStringMember("MoonChasingAllQuest")]
	MoonChasingAllQuest,
	// Token: 0x0400E819 RID: 59417
	[EnumStringMember("MoonChasingMainlineTab")]
	MoonChasingMainlineTab,
	// Token: 0x0400E81A RID: 59418
	[EnumStringMember("MoonChasingBranchTab")]
	MoonChasingBranchTab,
	// Token: 0x0400E81B RID: 59419
	[EnumStringMember("MoonChasingHandbook")]
	MoonChasingHandbook,
	// Token: 0x0400E81C RID: 59420
	[EnumStringMember("MoonChasingReward")]
	MoonChasingReward,
	// Token: 0x0400E81D RID: 59421
	[EnumStringMember("MoonChasingShop")]
	MoonChasingShop,
	// Token: 0x0400E81E RID: 59422
	[EnumStringMember("MoonChasingRewardAndShop")]
	MoonChasingRewardAndShop,
	// Token: 0x0400E81F RID: 59423
	[EnumStringMember("MoonChasingBuilding")]
	MoonChasingBuilding,
	// Token: 0x0400E820 RID: 59424
	[EnumStringMember("MoonChasingRole")]
	MoonChasingRole,
	// Token: 0x0400E821 RID: 59425
	[EnumStringMember("MoonChasingDelegation")]
	MoonChasingDelegation,
	// Token: 0x0400E822 RID: 59426
	[EnumStringMember("ActivityCorniceMeeting")]
	ActivityCorniceMeeting,
	// Token: 0x0400E823 RID: 59427
	[EnumStringMember("Spring25AllLetter")]
	Spring25AllLetter,
	// Token: 0x0400E824 RID: 59428
	[EnumStringMember("Spring25Reward")]
	Spring25Reward,
	// Token: 0x0400E825 RID: 59429
	[EnumStringMember("Spring25Invite")]
	Spring25Invite,
	// Token: 0x0400E826 RID: 59430
	[EnumStringMember("Spring25Enter")]
	Spring25Enter,
	// Token: 0x0400E827 RID: 59431
	[EnumStringMember("FarmGoldReward")]
	FarmGoldReward,
	// Token: 0x0400E828 RID: 59432
	[EnumStringMember("FishingTech")]
	FishingTech,
	// Token: 0x0400E829 RID: 59433
	[EnumStringMember("FishingRoleTechNode")]
	FishingRoleTechNode,
	// Token: 0x0400E82A RID: 59434
	[EnumStringMember("FishingRoleToggleTech")]
	FishingRoleToggleTech,
	// Token: 0x0400E82B RID: 59435
	[EnumStringMember("FishingNormalTechNode")]
	FishingNormalTechNode,
	// Token: 0x0400E82C RID: 59436
	[EnumStringMember("FishingNormalTech")]
	FishingNormalTech,
	// Token: 0x0400E82D RID: 59437
	[EnumStringMember("FishingRoleTech")]
	FishingRoleTech,
	// Token: 0x0400E82E RID: 59438
	[EnumStringMember("InviteNewbie")]
	InviteNewbie,
	// Token: 0x0400E82F RID: 59439
	[EnumStringMember("BabelTowerQuestRedDot")]
	BabelTowerQuestRedDot,
	// Token: 0x0400E830 RID: 59440
	[EnumStringMember("BabelTowerNewLevelDifficulty")]
	BabelTowerNewLevelDifficulty,
	// Token: 0x0400E831 RID: 59441
	[EnumStringMember("BabelTowerNewLevel")]
	BabelTowerNewLevel,
	// Token: 0x0400E832 RID: 59442
	[EnumStringMember("CiacconaProgressReward")]
	CiacconaProgressReward,
	// Token: 0x0400E833 RID: 59443
	[EnumStringMember("CiacconaEndingReward")]
	CiacconaEndingReward,
	// Token: 0x0400E834 RID: 59444
	[EnumStringMember("CiacconaSubEndingReward")]
	CiacconaSubEndingReward,
	// Token: 0x0400E835 RID: 59445
	[EnumStringMember("DangoMonopoly")]
	DangoMonopoly,
	// Token: 0x0400E836 RID: 59446
	[EnumStringMember("DangoMonopolyTask")]
	DangoMonopolyTask,
	// Token: 0x0400E837 RID: 59447
	[EnumStringMember("DangoMonopolyDiceNum")]
	DangoMonopolyDiceNum,
	// Token: 0x0400E838 RID: 59448
	[EnumStringMember("DangoMonopolyRound")]
	DangoMonopolyRound,
	// Token: 0x0400E839 RID: 59449
	[EnumStringMember("Morale")]
	Morale,
	// Token: 0x0400E83A RID: 59450
	[EnumStringMember("MoraleScoreBox")]
	MoraleScoreBox,
	// Token: 0x0400E83B RID: 59451
	[EnumStringMember("MoraleFlagBox")]
	MoraleFlagBox,
	// Token: 0x0400E83C RID: 59452
	[EnumStringMember("MoraleBuff")]
	MoraleBuff,
	// Token: 0x0400E83D RID: 59453
	[EnumStringMember("MoraleAreaBuff")]
	MoraleAreaBuff,
	// Token: 0x0400E83E RID: 59454
	[EnumStringMember("TrapDefense")]
	TrapDefense,
	// Token: 0x0400E83F RID: 59455
	[EnumStringMember("TrapDefenseFixedReward")]
	TrapDefenseFixedReward,
	// Token: 0x0400E840 RID: 59456
	[EnumStringMember("TrapDefenseLimitReward")]
	TrapDefenseLimitReward,
	// Token: 0x0400E841 RID: 59457
	[EnumStringMember("TrapDefenseMainLevel")]
	TrapDefenseMainLevel,
	// Token: 0x0400E842 RID: 59458
	[EnumStringMember("TrapDefenseLevelModeLevelReachOpenTime")]
	TrapDefenseLevelModeLevelReachOpenTime,
	// Token: 0x0400E843 RID: 59459
	[EnumStringMember("TrapDefenseRougeLevel")]
	TrapDefenseRougeLevel,
	// Token: 0x0400E844 RID: 59460
	[EnumStringMember("TrapDefenseTalentTree")]
	TrapDefenseTalentTree,
	// Token: 0x0400E845 RID: 59461
	[EnumStringMember("TrapDefenseDevelopBranchAll")]
	TrapDefenseDevelopBranchAll,
	// Token: 0x0400E846 RID: 59462
	[EnumStringMember("TrapDefenseDevelopBranchAuxiliary")]
	TrapDefenseDevelopBranchAuxiliary,
	// Token: 0x0400E847 RID: 59463
	[EnumStringMember("TrapDefenseDevelopBranchBuilding")]
	TrapDefenseDevelopBranchBuilding,
	// Token: 0x0400E848 RID: 59464
	[EnumStringMember("TrapDefenseRougeModeLevelReachOpenTime")]
	TrapDefenseRougeModeLevelReachOpenTime,
	// Token: 0x0400E849 RID: 59465
	[EnumStringMember("TrapDefenseRougeModeOpen")]
	TrapDefenseRougeModeOpen,
	// Token: 0x0400E84A RID: 59466
	[EnumStringMember("TrapDefenseBdSum")]
	TrapDefenseBdSum,
	// Token: 0x0400E84B RID: 59467
	[EnumStringMember("TrapDefenseBdBuffNewUnlock")]
	TrapDefenseBdBuffNewUnlock,
	// Token: 0x0400E84C RID: 59468
	[EnumStringMember("RedDotVersionCheck")]
	RedDotVersionCheck,
	// Token: 0x0400E84D RID: 59469
	[EnumStringMember("RedDotDangoCommonReward")]
	RedDotDangoCommonReward,
	// Token: 0x0400E84E RID: 59470
	[EnumStringMember("RedDotDangoLimitReward")]
	RedDotDangoLimitReward,
	// Token: 0x0400E84F RID: 59471
	[EnumStringMember("RedDotDangoPayShop")]
	RedDotDangoPayShop,
	// Token: 0x0400E850 RID: 59472
	[EnumStringMember("RedDotDangoDevelop")]
	RedDotDangoDevelop,
	// Token: 0x0400E851 RID: 59473
	[EnumStringMember("RedDotDangoRole")]
	RedDotDangoRole,
	// Token: 0x0400E852 RID: 59474
	[EnumStringMember("RedDotDangoFormation")]
	RedDotDangoFormation,
	// Token: 0x0400E853 RID: 59475
	[EnumStringMember("RedDotDangoFormationRole")]
	RedDotDangoFormationRole,
	// Token: 0x0400E854 RID: 59476
	[EnumStringMember("RedDotRacingBetsActivityReward")]
	RedDotRacingBetsActivityReward,
	// Token: 0x0400E855 RID: 59477
	[EnumStringMember("RedDotRacingBetsActivityInternalReward")]
	RedDotRacingBetsActivityInternalReward,
	// Token: 0x0400E856 RID: 59478
	[EnumStringMember("RedDotPhantomArenaLimitReward")]
	RedDotPhantomArenaLimitReward,
	// Token: 0x0400E857 RID: 59479
	[EnumStringMember("RedDotPhantomArenaTaskReward")]
	RedDotPhantomArenaTaskReward,
	// Token: 0x0400E858 RID: 59480
	[EnumStringMember("RedDotPhantomArenaShopUpdate")]
	RedDotPhantomArenaShopUpdate,
	// Token: 0x0400E859 RID: 59481
	[EnumStringMember("RedDotPhantomArenaCardReward")]
	RedDotPhantomArenaCardReward,
	// Token: 0x0400E85A RID: 59482
	[EnumStringMember("RedDotPhantomArenaBadgeReward")]
	RedDotPhantomArenaBadgeReward,
	// Token: 0x0400E85B RID: 59483
	[EnumStringMember("RedDotPhantomArenaLevelReward")]
	RedDotPhantomArenaLevelReward,
	// Token: 0x0400E85C RID: 59484
	[EnumStringMember("RedDotPhantomArenaCollect")]
	RedDotPhantomArenaCollect,
	// Token: 0x0400E85D RID: 59485
	[EnumStringMember("RedDotPhantomArenaRole")]
	RedDotPhantomArenaRole,
	// Token: 0x0400E85E RID: 59486
	[EnumStringMember("RedDotPhantomArenaGym")]
	RedDotPhantomArenaGym,
	// Token: 0x0400E85F RID: 59487
	[EnumStringMember("RedDotPhantomArenaActivity")]
	RedDotPhantomArenaActivity,
	// Token: 0x0400E860 RID: 59488
	[EnumStringMember("RedDotPhantomArenaMapUnlock")]
	RedDotPhantomArenaMapUnlock,
	// Token: 0x0400E861 RID: 59489
	[EnumStringMember("RedDotPhantomArenaMapUnlockDropDownItem")]
	RedDotPhantomArenaMapUnlockDropDownItem,
	// Token: 0x0400E862 RID: 59490
	[EnumStringMember("CumulativeShopTaskTabRedDot")]
	CumulativeShopTaskTabRedDot,
	// Token: 0x0400E863 RID: 59491
	[EnumStringMember("BeginnerCarnivalTaskTabRedDot")]
	BeginnerCarnivalTaskTabRedDot,
	// Token: 0x0400E864 RID: 59492
	[EnumStringMember("LifePointDrawChallengeRedDot")]
	LifePointDrawChallengeRedDot,
	// Token: 0x0400E865 RID: 59493
	[EnumStringMember("LifePointDrawGroupRedDot")]
	LifePointDrawGroupRedDot,
	// Token: 0x0400E866 RID: 59494
	[EnumStringMember("ActivityFunPlay")]
	ActivityFunPlay,
	// Token: 0x0400E867 RID: 59495
	[EnumStringMember("InfrShop")]
	InfrShop,
	// Token: 0x0400E868 RID: 59496
	[EnumStringMember("InfrLimitedTask")]
	InfrLimitedTask,
	// Token: 0x0400E869 RID: 59497
	[EnumStringMember("InfrArchive")]
	InfrArchive,
	// Token: 0x0400E86A RID: 59498
	[EnumStringMember("Infrastructure")]
	Infrastructure,
	// Token: 0x0400E86B RID: 59499
	[EnumStringMember("VillageInfrTask")]
	VillageInfrTask,
	// Token: 0x0400E86C RID: 59500
	[EnumStringMember("VillageInfrTree")]
	VillageInfrTree,
	// Token: 0x0400E86D RID: 59501
	[EnumStringMember("VillageInfr")]
	VillageInfr,
	// Token: 0x0400E86E RID: 59502
	[EnumStringMember("RedDotNewPlayerSupportTrialRoleEntrance")]
	RedDotNewPlayerSupportTrialRoleEntrance,
	// Token: 0x0400E86F RID: 59503
	[EnumStringMember("RedDotNewPlayerSupportAdventure")]
	RedDotNewPlayerSupportAdventure,
	// Token: 0x0400E870 RID: 59504
	[EnumStringMember("RedDotTrialRoleGroup")]
	RedDotTrialRoleGroup,
	// Token: 0x0400E871 RID: 59505
	[EnumStringMember("LineCrossChallengeRedDot")]
	LineCrossChallengeRedDot,
	// Token: 0x0400E872 RID: 59506
	[EnumStringMember("LineCrossGroupRedDot")]
	LineCrossGroupRedDot,
	// Token: 0x0400E873 RID: 59507
	[EnumStringMember("RedDotWeaponResonanceTab")]
	RedDotWeaponResonanceTab,
	// Token: 0x0400E874 RID: 59508
	[EnumStringMember("RedDotPhantomInteractUnlock")]
	RedDotPhantomInteractUnlock,
	// Token: 0x0400E875 RID: 59509
	[EnumStringMember("RedDotPhantomInteractEditEntry")]
	RedDotPhantomInteractEditEntry,
	// Token: 0x0400E876 RID: 59510
	[EnumStringMember("RedDotPhantomInteractRouletteGrid")]
	RedDotPhantomInteractRouletteGrid,
	// Token: 0x0400E877 RID: 59511
	[EnumStringMember("MotorcycleLevelTab")]
	MotorcycleLevelTab,
	// Token: 0x0400E878 RID: 59512
	[EnumStringMember("MotorcycleTechTreeTab")]
	MotorcycleTechTreeTab,
	// Token: 0x0400E879 RID: 59513
	[EnumStringMember("MotorcycleTreeTypeTechTab")]
	MotorcycleTreeTypeTechTab,
	// Token: 0x0400E87A RID: 59514
	[EnumStringMember("MotorcycleTreeTypeTechTabNew")]
	MotorcycleTreeTypeTechTabNew,
	// Token: 0x0400E87B RID: 59515
	[EnumStringMember("MotorcycleTreeTypeTaskTab")]
	MotorcycleTreeTypeTaskTab,
	// Token: 0x0400E87C RID: 59516
	[EnumStringMember("MotorcycleTaskTab")]
	MotorcycleTaskTab,
	// Token: 0x0400E87D RID: 59517
	[EnumStringMember("MotorcycleDiyTab")]
	MotorcycleDiyTab,
	// Token: 0x0400E87E RID: 59518
	[EnumStringMember("MotorcycleSceneButtonRedDot")]
	MotorcycleSceneButtonRedDot,
	// Token: 0x0400E87F RID: 59519
	[EnumStringMember("MotorcycleDiyFrameTab")]
	MotorcycleDiyFrameTab,
	// Token: 0x0400E880 RID: 59520
	[EnumStringMember("MotorcycleDiyStickerTab")]
	MotorcycleDiyStickerTab,
	// Token: 0x0400E881 RID: 59521
	[EnumStringMember("MotorcycleDiyStickerPartTab")]
	MotorcycleDiyStickerPartTab,
	// Token: 0x0400E882 RID: 59522
	[EnumStringMember("MotorcycleDiyDecorationTab")]
	MotorcycleDiyDecorationTab,
	// Token: 0x0400E883 RID: 59523
	[EnumStringMember("MotorcycleDiyDecorationPartTab")]
	MotorcycleDiyDecorationPartTab,
	// Token: 0x0400E884 RID: 59524
	[EnumStringMember("MotorcycleDiyFramePreTab")]
	MotorcycleDiyFramePreTab,
	// Token: 0x0400E885 RID: 59525
	[EnumStringMember("MotorcycleDiyStickerPreTab")]
	MotorcycleDiyStickerPreTab,
	// Token: 0x0400E886 RID: 59526
	[EnumStringMember("MotorcycleDiyStickerPrePartTab")]
	MotorcycleDiyStickerPrePartTab,
	// Token: 0x0400E887 RID: 59527
	[EnumStringMember("MotorcycleDiyDecorationPreTab")]
	MotorcycleDiyDecorationPreTab,
	// Token: 0x0400E888 RID: 59528
	[EnumStringMember("MotorcycleDiyDecorationPrePartTab")]
	MotorcycleDiyDecorationPrePartTab,
	// Token: 0x0400E889 RID: 59529
	[EnumStringMember("ActivityDirectTrainProEntry")]
	ActivityDirectTrainProEntry,
	// Token: 0x0400E88A RID: 59530
	[EnumStringMember("FeedbackReward")]
	FeedbackReward,
	// Token: 0x0400E88B RID: 59531
	[EnumStringMember("RedDotCyberPunkTask")]
	RedDotCyberPunkTask,
	// Token: 0x0400E88C RID: 59532
	[EnumStringMember("RedDotCyberPunkTaskTab")]
	RedDotCyberPunkTaskTab,
	// Token: 0x0400E88D RID: 59533
	[EnumStringMember("RedDotCyberPunkTrialRole")]
	RedDotCyberPunkTrialRole,
	// Token: 0x0400E88E RID: 59534
	[EnumStringMember("RedDotCyberPunkBoss")]
	RedDotCyberPunkBoss,
	// Token: 0x0400E88F RID: 59535
	[EnumStringMember("RedDotCyberPunkReward")]
	RedDotCyberPunkReward,
	// Token: 0x0400E890 RID: 59536
	[EnumStringMember("SpringManorGameEntrance")]
	SpringManorGameEntrance,
	// Token: 0x0400E891 RID: 59537
	[EnumStringMember("DrinksUnlockLevel")]
	DrinksUnlockLevel,
	// Token: 0x0400E892 RID: 59538
	[EnumStringMember("GuessJokerUnlockLevel")]
	GuessJokerUnlockLevel,
	// Token: 0x0400E893 RID: 59539
	[EnumStringMember("SpringManorAlbumReward")]
	SpringManorAlbumReward,
	// Token: 0x0400E894 RID: 59540
	[EnumStringMember("SpringManorBrochureReward")]
	SpringManorBrochureReward,
	// Token: 0x0400E895 RID: 59541
	[EnumStringMember("FurnitureEntranceRedDot")]
	FurnitureEntranceRedDot,
	// Token: 0x0400E896 RID: 59542
	[EnumStringMember("RhythmShipTimeLimitTask")]
	RhythmShipTimeLimitTask,
	// Token: 0x0400E897 RID: 59543
	[EnumStringMember("RhythmShipTask")]
	RhythmShipTask,
	// Token: 0x0400E898 RID: 59544
	[EnumStringMember("RhythmShipTaskTab")]
	RhythmShipTaskTab,
	// Token: 0x0400E899 RID: 59545
	[EnumStringMember("BossPilingReward")]
	BossPilingReward,
	// Token: 0x0400E89A RID: 59546
	[EnumStringMember("RedDotFlagChallengeActivityReward")]
	RedDotFlagChallengeActivityReward,
	// Token: 0x0400E89B RID: 59547
	[EnumStringMember("RedDotFlagChallengeActivityLevelNewlyUnlocked")]
	RedDotFlagChallengeActivityLevelNewlyUnlocked,
	// Token: 0x0400E89C RID: 59548
	[EnumStringMember("RedDotFlagChallengeActivityBuffNewlyUnlocked")]
	RedDotFlagChallengeActivityBuffNewlyUnlocked,
	// Token: 0x0400E89D RID: 59549
	[EnumStringMember("RedDotFlagChallengeActivityBuffItemNewlyUnlocked")]
	RedDotFlagChallengeActivityBuffItemNewlyUnlocked,
	// Token: 0x0400E89E RID: 59550
	[EnumStringMember("RedDotFlagChallengeBattleBuffNewlyUnlocked")]
	RedDotFlagChallengeBattleBuffNewlyUnlocked,
	// Token: 0x0400E89F RID: 59551
	[EnumStringMember("RedDotPinballRole")]
	RedDotPinballRole,
	// Token: 0x0400E8A0 RID: 59552
	[EnumStringMember("RedDotPinballRoleFunction")]
	RedDotPinballRoleFunction,
	// Token: 0x0400E8A1 RID: 59553
	[EnumStringMember("RedDotKurotatoRole")]
	RedDotKurotatoRole,
	// Token: 0x0400E8A2 RID: 59554
	[EnumStringMember("RedDotKurotatoWeaponAndProp")]
	RedDotKurotatoWeaponAndProp,
	// Token: 0x0400E8A3 RID: 59555
	[EnumStringMember("RedDotKurotatoWeapon")]
	RedDotKurotatoWeapon,
	// Token: 0x0400E8A4 RID: 59556
	[EnumStringMember("RedDotKurotatoProp")]
	RedDotKurotatoProp,
	// Token: 0x0400E8A5 RID: 59557
	[EnumStringMember("RedDotKurotatoNormalRewardBtn")]
	RedDotKurotatoNormalRewardBtn,
	// Token: 0x0400E8A6 RID: 59558
	[EnumStringMember("RedDotKurotatoLimitRewardBtn")]
	RedDotKurotatoLimitRewardBtn,
	// Token: 0x0400E8A7 RID: 59559
	[EnumStringMember("RedDotKurotatoLimitRewardTabItem")]
	RedDotKurotatoLimitRewardTabItem,
	// Token: 0x0400E8A8 RID: 59560
	[EnumStringMember("SheriffMap")]
	SheriffMap,
	// Token: 0x0400E8A9 RID: 59561
	[EnumStringMember("RedDotRoverlikeQuestRewardBtn")]
	RedDotRoverlikeQuestRewardBtn,
	// Token: 0x0400E8AA RID: 59562
	[EnumStringMember("RedDotRoverlikeShopRewardBtn")]
	RedDotRoverlikeShopRewardBtn,
	// Token: 0x0400E8AB RID: 59563
	[EnumStringMember("GiantMindsetEntry")]
	GiantMindsetEntry,
	// Token: 0x0400E8AC RID: 59564
	[EnumStringMember("GiantDeliverable")]
	GiantDeliverable,
	// Token: 0x0400E8AD RID: 59565
	[EnumStringMember("GiantAccessNew")]
	GiantAccessNew,
	// Token: 0x0400E8AE RID: 59566
	[EnumStringMember("GiantInteract")]
	GiantInteract,
	// Token: 0x0400E8AF RID: 59567
	[EnumStringMember("GiantCommission")]
	GiantCommission,
	// Token: 0x0400E8B0 RID: 59568
	[EnumStringMember("RedDotSolarSchoolQuest")]
	RedDotSolarSchoolQuest,
	// Token: 0x0400E8B1 RID: 59569
	[EnumStringMember("RedDotSolarSchoolQuestItem")]
	RedDotSolarSchoolQuestItem
}
