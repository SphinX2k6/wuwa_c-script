using System;
using CSharpScript.Core.Common;

// Token: 0x0200332C RID: 13100
[EnumExtensions]
public enum ERedDotName
{
	// Token: 0x0400E2C1 RID: 58049
	[EnumStringMember("Test")]
	Test,
	// Token: 0x0400E2C2 RID: 58050
	[EnumStringMember("BattleViewMenu")]
	BattleViewMenu,
	// Token: 0x0400E2C3 RID: 58051
	[EnumStringMember("BattleViewResonanceButton")]
	BattleViewResonanceButton,
	// Token: 0x0400E2C4 RID: 58052
	[EnumStringMember("BattleViewShopButton")]
	BattleViewShopButton,
	// Token: 0x0400E2C5 RID: 58053
	[EnumStringMember("BattleViewGachaButton")]
	BattleViewGachaButton,
	// Token: 0x0400E2C6 RID: 58054
	[EnumStringMember("MailFilterAll")]
	MailFilterAll,
	// Token: 0x0400E2C7 RID: 58055
	[EnumStringMember("FilterImportant")]
	FilterImportant,
	// Token: 0x0400E2C8 RID: 58056
	[EnumStringMember("FilterUnScanned")]
	FilterUnScanned,
	// Token: 0x0400E2C9 RID: 58057
	[EnumStringMember("RoleSystemRoleList")]
	RoleSystemRoleList,
	// Token: 0x0400E2CA RID: 58058
	[EnumStringMember("RoleAttributeTab")]
	RoleAttributeTab,
	// Token: 0x0400E2CB RID: 58059
	[EnumStringMember("RoleAttributeTabLevelUp")]
	RoleAttributeTabLevelUp,
	// Token: 0x0400E2CC RID: 58060
	[EnumStringMember("RoleAttributeTabBreakUp")]
	RoleAttributeTabBreakUp,
	// Token: 0x0400E2CD RID: 58061
	[EnumStringMember("RoleSkin")]
	RoleSkin,
	// Token: 0x0400E2CE RID: 58062
	[EnumStringMember("RoleChange")]
	RoleChange,
	// Token: 0x0400E2CF RID: 58063
	[EnumStringMember("FlySkinTab")]
	FlySkinTab,
	// Token: 0x0400E2D0 RID: 58064
	[EnumStringMember("FlySkinChildTab")]
	FlySkinChildTab,
	// Token: 0x0400E2D1 RID: 58065
	[EnumStringMember("HuluSkinTab")]
	HuluSkinTab,
	// Token: 0x0400E2D2 RID: 58066
	[EnumStringMember("RoleOrnamentTab")]
	RoleOrnamentTab,
	// Token: 0x0400E2D3 RID: 58067
	[EnumStringMember("RoleWeaponTabBreakUp")]
	RoleWeaponTabBreakUp,
	// Token: 0x0400E2D4 RID: 58068
	[EnumStringMember("RoleFavorTab")]
	RoleFavorTab,
	// Token: 0x0400E2D5 RID: 58069
	[EnumStringMember("RoleSkillTabPhantomSkill")]
	RoleSkillTabPhantomSkill,
	// Token: 0x0400E2D6 RID: 58070
	[EnumStringMember("RoleChipTab")]
	RoleChipTab,
	// Token: 0x0400E2D7 RID: 58071
	[EnumStringMember("RoleChipTabHole")]
	RoleChipTabHole,
	// Token: 0x0400E2D8 RID: 58072
	[EnumStringMember("RoleResonanceTab")]
	RoleResonanceTab,
	// Token: 0x0400E2D9 RID: 58073
	[EnumStringMember("RoleResonanceTabHole")]
	RoleResonanceTabHole,
	// Token: 0x0400E2DA RID: 58074
	[EnumStringMember("RedDotResonanceBtn")]
	RedDotResonanceBtn,
	// Token: 0x0400E2DB RID: 58075
	[EnumStringMember("RoleSelectionList")]
	RoleSelectionList,
	// Token: 0x0400E2DC RID: 58076
	[EnumStringMember("FunctionRole")]
	FunctionRole,
	// Token: 0x0400E2DD RID: 58077
	[EnumStringMember("FunctionPhantom")]
	FunctionPhantom,
	// Token: 0x0400E2DE RID: 58078
	[EnumStringMember("FunctionFriend")]
	FunctionFriend,
	// Token: 0x0400E2DF RID: 58079
	[EnumStringMember("FunctionGacha")]
	FunctionGacha,
	// Token: 0x0400E2E0 RID: 58080
	[EnumStringMember("FunctionTutorial")]
	FunctionTutorial,
	// Token: 0x0400E2E1 RID: 58081
	[EnumStringMember("FunctionAdventure")]
	FunctionAdventure,
	// Token: 0x0400E2E2 RID: 58082
	[EnumStringMember("FunctionCalabash")]
	FunctionCalabash,
	// Token: 0x0400E2E3 RID: 58083
	[EnumStringMember("FunctionInventory")]
	FunctionInventory,
	// Token: 0x0400E2E4 RID: 58084
	[EnumStringMember("FunctionMail")]
	FunctionMail,
	// Token: 0x0400E2E5 RID: 58085
	[EnumStringMember("FunctionNotice")]
	FunctionNotice,
	// Token: 0x0400E2E6 RID: 58086
	[EnumStringMember("FunctionPayShop")]
	FunctionPayShop,
	// Token: 0x0400E2E7 RID: 58087
	[EnumStringMember("FunctionPhantomExploreSet")]
	FunctionPhantomExploreSet,
	// Token: 0x0400E2E8 RID: 58088
	[EnumStringMember("FunctionMailBind")]
	FunctionMailBind,
	// Token: 0x0400E2E9 RID: 58089
	[EnumStringMember("FunctionKuroStreet")]
	FunctionKuroStreet,
	// Token: 0x0400E2EA RID: 58090
	[EnumStringMember("FunctionMap")]
	FunctionMap,
	// Token: 0x0400E2EB RID: 58091
	[EnumStringMember("FunctionPhotograph")]
	FunctionPhotograph,
	// Token: 0x0400E2EC RID: 58092
	[EnumStringMember("PreDownload")]
	PreDownload,
	// Token: 0x0400E2ED RID: 58093
	[EnumStringMember("PreDownloadComplete")]
	PreDownloadComplete,
	// Token: 0x0400E2EE RID: 58094
	[EnumStringMember("FunctionSetting")]
	FunctionSetting,
	// Token: 0x0400E2EF RID: 58095
	[EnumStringMember("FunctionPhoneMsg")]
	FunctionPhoneMsg,
	// Token: 0x0400E2F0 RID: 58096
	[EnumStringMember("FunctionWeatherCentral")]
	FunctionWeatherCentral,
	// Token: 0x0400E2F1 RID: 58097
	[EnumStringMember("FunctionMotorDevelop")]
	FunctionMotorDevelop,
	// Token: 0x0400E2F2 RID: 58098
	[EnumStringMember("PhoneMsgChatItemRedDot")]
	PhoneMsgChatItemRedDot,
	// Token: 0x0400E2F3 RID: 58099
	[EnumStringMember("PhoneMsgChatPartnerRedDot")]
	PhoneMsgChatPartnerRedDot,
	// Token: 0x0400E2F4 RID: 58100
	[EnumStringMember("PhoneMsgChatPartnerRedDotGiftIcon")]
	PhoneMsgChatPartnerRedDotGiftIcon,
	// Token: 0x0400E2F5 RID: 58101
	[EnumStringMember("MapAreaExplore")]
	MapAreaExplore,
	// Token: 0x0400E2F6 RID: 58102
	[EnumStringMember("MapAreaBoxReward")]
	MapAreaBoxReward,
	// Token: 0x0400E2F7 RID: 58103
	[EnumStringMember("MapAreaShowTabCountry")]
	MapAreaShowTabCountry,
	// Token: 0x0400E2F8 RID: 58104
	[EnumStringMember("MapAreaShowTabState")]
	MapAreaShowTabState,
	// Token: 0x0400E2F9 RID: 58105
	[EnumStringMember("MapAreaShowTabArea")]
	MapAreaShowTabArea,
	// Token: 0x0400E2FA RID: 58106
	[EnumStringMember("ShipTower")]
	ShipTower,
	// Token: 0x0400E2FB RID: 58107
	[EnumStringMember("ShipTowerReward")]
	ShipTowerReward,
	// Token: 0x0400E2FC RID: 58108
	[EnumStringMember("CalabashTab")]
	CalabashTab,
	// Token: 0x0400E2FD RID: 58109
	[EnumStringMember("VisionRecovery")]
	VisionRecovery,
	// Token: 0x0400E2FE RID: 58110
	[EnumStringMember("VisionRefine")]
	VisionRefine,
	// Token: 0x0400E2FF RID: 58111
	[EnumStringMember("FriendNewApplication")]
	FriendNewApplication,
	// Token: 0x0400E300 RID: 58112
	[EnumStringMember("ChatRoom")]
	ChatRoom,
	// Token: 0x0400E301 RID: 58113
	[EnumStringMember("ChatView")]
	ChatView,
	// Token: 0x0400E302 RID: 58114
	[EnumStringMember("TutorialItemNew")]
	TutorialItemNew,
	// Token: 0x0400E303 RID: 58115
	[EnumStringMember("TutorialTypeNew")]
	TutorialTypeNew,
	// Token: 0x0400E304 RID: 58116
	[EnumStringMember("AdventureManual")]
	AdventureManual,
	// Token: 0x0400E305 RID: 58117
	[EnumStringMember("AdventureBattleButton")]
	AdventureBattleButton,
	// Token: 0x0400E306 RID: 58118
	[EnumStringMember("AdventureFirstAward")]
	AdventureFirstAward,
	// Token: 0x0400E307 RID: 58119
	[EnumStringMember("AdventureFirstAwardCategory")]
	AdventureFirstAwardCategory,
	// Token: 0x0400E308 RID: 58120
	[EnumStringMember("AdventureFirstAwardResult")]
	AdventureFirstAwardResult,
	// Token: 0x0400E309 RID: 58121
	[EnumStringMember("AdventureDailyActivityTab")]
	AdventureDailyActivityTab,
	// Token: 0x0400E30A RID: 58122
	[EnumStringMember("AdventureDailyActivityTabDaily")]
	AdventureDailyActivityTabDaily,
	// Token: 0x0400E30B RID: 58123
	[EnumStringMember("AdventureDailyActivityTabWeekly")]
	AdventureDailyActivityTabWeekly,
	// Token: 0x0400E30C RID: 58124
	[EnumStringMember("AdventureNewSoundAreaTab")]
	AdventureNewSoundAreaTab,
	// Token: 0x0400E30D RID: 58125
	[EnumStringMember("AdventureNewSoundAreaGeneral")]
	AdventureNewSoundAreaGeneral,
	// Token: 0x0400E30E RID: 58126
	[EnumStringMember("AdventureChallengeTab")]
	AdventureChallengeTab,
	// Token: 0x0400E30F RID: 58127
	[EnumStringMember("AdventurePeriodicityTab")]
	AdventurePeriodicityTab,
	// Token: 0x0400E310 RID: 58128
	[EnumStringMember("InfluenceReputation")]
	InfluenceReputation,
	// Token: 0x0400E311 RID: 58129
	[EnumStringMember("InfluenceReward")]
	InfluenceReward,
	// Token: 0x0400E312 RID: 58130
	[EnumStringMember("CookerLevel")]
	CookerLevel,
	// Token: 0x0400E313 RID: 58131
	[EnumStringMember("CookerLevelMain")]
	CookerLevelMain,
	// Token: 0x0400E314 RID: 58132
	[EnumStringMember("BattlePass")]
	BattlePass,
	// Token: 0x0400E315 RID: 58133
	[EnumStringMember("BattlePassTask")]
	BattlePassTask,
	// Token: 0x0400E316 RID: 58134
	[EnumStringMember("BattlePassReward")]
	BattlePassReward,
	// Token: 0x0400E317 RID: 58135
	[EnumStringMember("BattlePassAlwaysTaskTab")]
	BattlePassAlwaysTaskTab,
	// Token: 0x0400E318 RID: 58136
	[EnumStringMember("BattlePassWeekTaskTab")]
	BattlePassWeekTaskTab,
	// Token: 0x0400E319 RID: 58137
	[EnumStringMember("BattlePassDayTaskTab")]
	BattlePassDayTaskTab,
	// Token: 0x0400E31A RID: 58138
	[EnumStringMember("RoleHandBook")]
	RoleHandBook,
	// Token: 0x0400E31B RID: 58139
	[EnumStringMember("RoleHandBookActiveButton")]
	RoleHandBookActiveButton,
	// Token: 0x0400E31C RID: 58140
	[EnumStringMember("ComposeReagentProduction")]
	ComposeReagentProduction,
	// Token: 0x0400E31D RID: 58141
	[EnumStringMember("ItemHandBook")]
	ItemHandBook,
	// Token: 0x0400E31E RID: 58142
	[EnumStringMember("PhantomHandBook")]
	PhantomHandBook,
	// Token: 0x0400E31F RID: 58143
	[EnumStringMember("Achievement")]
	Achievement,
	// Token: 0x0400E320 RID: 58144
	[EnumStringMember("AchievementCategory")]
	AchievementCategory,
	// Token: 0x0400E321 RID: 58145
	[EnumStringMember("ActivityEntrance")]
	ActivityEntrance,
	// Token: 0x0400E322 RID: 58146
	[EnumStringMember("CommonActivityPage")]
	CommonActivityPage,
	// Token: 0x0400E323 RID: 58147
	[EnumStringMember("ActivityRun")]
	ActivityRun,
	// Token: 0x0400E324 RID: 58148
	[EnumStringMember("BattleViewQuestButton")]
	BattleViewQuestButton,
	// Token: 0x0400E325 RID: 58149
	[EnumStringMember("QuestViewItem")]
	QuestViewItem,
	// Token: 0x0400E326 RID: 58150
	[EnumStringMember("QuestTab")]
	QuestTab,
	// Token: 0x0400E327 RID: 58151
	[EnumStringMember("FunctionViewQuestBtn")]
	FunctionViewQuestBtn,
	// Token: 0x0400E328 RID: 58152
	[EnumStringMember("InventoryVirtual")]
	InventoryVirtual,
	// Token: 0x0400E329 RID: 58153
	[EnumStringMember("InventoryCommon")]
	InventoryCommon,
	// Token: 0x0400E32A RID: 58154
	[EnumStringMember("InventoryWeapon")]
	InventoryWeapon,
	// Token: 0x0400E32B RID: 58155
	[EnumStringMember("InventoryPhantom")]
	InventoryPhantom,
	// Token: 0x0400E32C RID: 58156
	[EnumStringMember("InventoryCollection")]
	InventoryCollection,
	// Token: 0x0400E32D RID: 58157
	[EnumStringMember("InventoryMaterial")]
	InventoryMaterial,
	// Token: 0x0400E32E RID: 58158
	[EnumStringMember("InventoryMission")]
	InventoryMission,
	// Token: 0x0400E32F RID: 58159
	[EnumStringMember("InventorySpecial")]
	InventorySpecial,
	// Token: 0x0400E330 RID: 58160
	[EnumStringMember("InventoryCard")]
	InventoryCard,
	// Token: 0x0400E331 RID: 58161
	[EnumStringMember("TowerReward")]
	TowerReward,
	// Token: 0x0400E332 RID: 58162
	[EnumStringMember("TowerRewardByDifficulties")]
	TowerRewardByDifficulties,
	// Token: 0x0400E333 RID: 58163
	[EnumStringMember("IdentifyTab")]
	VisionIdentifyTab,
	// Token: 0x0400E334 RID: 58164
	[EnumStringMember("VisionOneKeyEquip")]
	VisionOneKeyEquip,
	// Token: 0x0400E335 RID: 58165
	[EnumStringMember("VisionTabRedDot")]
	VisionTabRedDot,
	// Token: 0x0400E336 RID: 58166
	[EnumStringMember("VisionGridRedDot")]
	VisionGridRedDot,
	// Token: 0x0400E337 RID: 58167
	[EnumStringMember("PayShopInstance")]
	PayShopInstance,
	// Token: 0x0400E338 RID: 58168
	[EnumStringMember("PayShopTab")]
	PayShopTab,
	// Token: 0x0400E339 RID: 58169
	[EnumStringMember("CustomerService")]
	CustomerService,
	// Token: 0x0400E33A RID: 58170
	[EnumStringMember("Introduction")]
	Introduction,
	// Token: 0x0400E33B RID: 58171
	[EnumStringMember("RogueSkillUnlock")]
	RogueSkillUnlock,
	// Token: 0x0400E33C RID: 58172
	[EnumStringMember("RoguelikeAchievement")]
	RoguelikeAchievement,
	// Token: 0x0400E33D RID: 58173
	[EnumStringMember("RoguelikeShop")]
	RoguelikeShop,
	// Token: 0x0400E33E RID: 58174
	[EnumStringMember("RoguelikeAchievementGroup")]
	RoguelikeAchievementGroup,
	// Token: 0x0400E33F RID: 58175
	[EnumStringMember("RogueResIllustratedTokenTab")]
	RogueResIllustratedTokenTab,
	// Token: 0x0400E340 RID: 58176
	[EnumStringMember("RogueResIllustratedNormalTab")]
	RogueResIllustratedNormalTab,
	// Token: 0x0400E341 RID: 58177
	[EnumStringMember("RogueResIllustratedMapTab")]
	RogueResIllustratedMapTab,
	// Token: 0x0400E342 RID: 58178
	[EnumStringMember("RogueResIllustrated")]
	RogueResIllustrated,
	// Token: 0x0400E343 RID: 58179
	[EnumStringMember("RogueResTask")]
	RogueResTask,
	// Token: 0x0400E344 RID: 58180
	[EnumStringMember("RogueResShop")]
	RogueResShop,
	// Token: 0x0400E345 RID: 58181
	[EnumStringMember("RogueResInst")]
	RogueResInst,
	// Token: 0x0400E346 RID: 58182
	[EnumStringMember("RogueResSkillTree")]
	RogueResSkillTree,
	// Token: 0x0400E347 RID: 58183
	[EnumStringMember("RogueResEnding")]
	RogueResEnding,
	// Token: 0x0400E348 RID: 58184
	[EnumStringMember("BossRushReward")]
	BossRushReward,
	// Token: 0x0400E349 RID: 58185
	[EnumStringMember("MowingTowerReward")]
	MowingTowerReward,
	// Token: 0x0400E34A RID: 58186
	[EnumStringMember("TowerDefenseReward")]
	TowerDefenseReward,
	// Token: 0x0400E34B RID: 58187
	[EnumStringMember("TowerDefenseInstance")]
	TowerDefenseInstance,
	// Token: 0x0400E34C RID: 58188
	[EnumStringMember("RedDotMowingRiskReward")]
	RedDotMowingRiskReward,
	// Token: 0x0400E34D RID: 58189
	[EnumStringMember("RedDotMowingRiskBuffAll")]
	RedDotMowingRiskBuffAll,
	// Token: 0x0400E34E RID: 58190
	[EnumStringMember("FragmentMemoryReward")]
	FragmentMemoryReward,
	// Token: 0x0400E34F RID: 58191
	[EnumStringMember("FragmentMemoryEntrance")]
	FragmentMemoryEntrance,
	// Token: 0x0400E350 RID: 58192
	[EnumStringMember("FragmentMemoryTopic")]
	FragmentMemoryTopic,
	// Token: 0x0400E351 RID: 58193
	[EnumStringMember("FragmentMemoryTopicCollectRedDot")]
	FragmentMemoryTopicCollectRedDot,
	// Token: 0x0400E352 RID: 58194
	[EnumStringMember("BattlePassPayButton")]
	BattlePassPayButton,
	// Token: 0x0400E353 RID: 58195
	[EnumStringMember("PersonalInfo")]
	PersonalizedInfo,
	// Token: 0x0400E354 RID: 58196
	[EnumStringMember("PersonalCard")]
	PersonalCard,
	// Token: 0x0400E355 RID: 58197
	[EnumStringMember("PersonalTitle")]
	PersonalTitle,
	// Token: 0x0400E356 RID: 58198
	[EnumStringMember("PersonalBirthday")]
	PersonalBirthday,
	// Token: 0x0400E357 RID: 58199
	[EnumStringMember("PersonalImageBook")]
	PersonalImageBook,
	// Token: 0x0400E358 RID: 58200
	[EnumStringMember("ActivityRecallSignEntry")]
	ActivityRecallSignEntry,
	// Token: 0x0400E359 RID: 58201
	[EnumStringMember("ActivityRecallTask")]
	ActivityRecallTaskEntry,
	// Token: 0x0400E35A RID: 58202
	[EnumStringMember("ActivityRegressQuestionnaire")]
	ActivityRegressQuestionnaire,
	// Token: 0x0400E35B RID: 58203
	[EnumStringMember("ActivityRegressShopDiscount")]
	ActivityRegressShopDiscount,
	// Token: 0x0400E35C RID: 58204
	[EnumStringMember("ActivityRegressDoubleDrop")]
	ActivityRegressDoubleDrop,
	// Token: 0x0400E35D RID: 58205
	[EnumStringMember("ActivityRegressCultivate")]
	ActivityRegressCultivate,
	// Token: 0x0400E35E RID: 58206
	[EnumStringMember("ActivityRegressConstantTask")]
	ActivityRegressConstantTask,
	// Token: 0x0400E35F RID: 58207
	[EnumStringMember("ActivityRegressTrialRole")]
	ActivityRegressTrialRole,
	// Token: 0x0400E360 RID: 58208
	[EnumStringMember("ActivityRegressBp")]
	ActivityRegressBp,
	// Token: 0x0400E361 RID: 58209
	[EnumStringMember("ActivityRegressBpTask")]
	ActivityRegressBpTask,
	// Token: 0x0400E362 RID: 58210
	[EnumStringMember("ActivityRegressBpReward")]
	ActivityRegressBpReward,
	// Token: 0x0400E363 RID: 58211
	[EnumStringMember("ActivityRegressDisposableReward")]
	ActivityRegressDisposableReward,
	// Token: 0x0400E364 RID: 58212
	[EnumStringMember("ActivityRegressRecommend")]
	ActivityRegressRecommend,
	// Token: 0x0400E365 RID: 58213
	[EnumStringMember("ActivityRegressAdventure")]
	ActivityRegressAdventure,
	// Token: 0x0400E366 RID: 58214
	[EnumStringMember("ActivityRegressRewardBtn")]
	ActivityRegressRewardBtn,
	// Token: 0x0400E367 RID: 58215
	[EnumStringMember("VisionLevelUpSetting")]
	VisionLevelUpSetting,
	// Token: 0x0400E368 RID: 58216
	[EnumStringMember("MoonChasingAllQuest")]
	MoonChasingAllQuest,
	// Token: 0x0400E369 RID: 58217
	[EnumStringMember("MoonChasingMainlineTab")]
	MoonChasingMainlineTab,
	// Token: 0x0400E36A RID: 58218
	[EnumStringMember("MoonChasingBranchTab")]
	MoonChasingBranchTab,
	// Token: 0x0400E36B RID: 58219
	[EnumStringMember("MoonChasingHandbook")]
	MoonChasingHandbook,
	// Token: 0x0400E36C RID: 58220
	[EnumStringMember("MoonChasingReward")]
	MoonChasingReward,
	// Token: 0x0400E36D RID: 58221
	[EnumStringMember("MoonChasingShop")]
	MoonChasingShop,
	// Token: 0x0400E36E RID: 58222
	[EnumStringMember("MoonChasingRewardAndShop")]
	MoonChasingRewardAndShop,
	// Token: 0x0400E36F RID: 58223
	[EnumStringMember("MoonChasingBuilding")]
	MoonChasingBuilding,
	// Token: 0x0400E370 RID: 58224
	[EnumStringMember("MoonChasingRole")]
	MoonChasingRole,
	// Token: 0x0400E371 RID: 58225
	[EnumStringMember("MoonChasingDelegation")]
	MoonChasingDelegation,
	// Token: 0x0400E372 RID: 58226
	[EnumStringMember("ActivityCorniceMeeting")]
	ActivityCorniceMeeting,
	// Token: 0x0400E373 RID: 58227
	[EnumStringMember("Spring25AllLetter")]
	Spring25AllLetter,
	// Token: 0x0400E374 RID: 58228
	[EnumStringMember("Spring25Reward")]
	Spring25Reward,
	// Token: 0x0400E375 RID: 58229
	[EnumStringMember("Spring25Invite")]
	Spring25Invite,
	// Token: 0x0400E376 RID: 58230
	[EnumStringMember("Spring25Enter")]
	Spring25Enter,
	// Token: 0x0400E377 RID: 58231
	[EnumStringMember("FarmGoldReward")]
	FarmGoldReward,
	// Token: 0x0400E378 RID: 58232
	[EnumStringMember("FishingTech")]
	FishingTech,
	// Token: 0x0400E379 RID: 58233
	[EnumStringMember("FishingRoleTechNode")]
	FishingRoleTechNode,
	// Token: 0x0400E37A RID: 58234
	[EnumStringMember("FishingRoleToggleTech")]
	FishingRoleToggleTech,
	// Token: 0x0400E37B RID: 58235
	[EnumStringMember("FishingNormalTechNode")]
	FishingNormalTechNode,
	// Token: 0x0400E37C RID: 58236
	[EnumStringMember("FishingNormalTech")]
	FishingNormalTech,
	// Token: 0x0400E37D RID: 58237
	[EnumStringMember("FishingRoleTech")]
	FishingRoleTech,
	// Token: 0x0400E37E RID: 58238
	[EnumStringMember("InviteNewbie")]
	InviteNewbie,
	// Token: 0x0400E37F RID: 58239
	[EnumStringMember("BabelTowerQuestRedDot")]
	BabelTowerQuestRedDot,
	// Token: 0x0400E380 RID: 58240
	[EnumStringMember("BabelTowerNewLevelDifficulty")]
	BabelTowerNewLevelDifficulty,
	// Token: 0x0400E381 RID: 58241
	[EnumStringMember("BabelTowerNewLevel")]
	BabelTowerNewLevel,
	// Token: 0x0400E382 RID: 58242
	[EnumStringMember("CiacconaProgressReward")]
	CiacconaProgressReward,
	// Token: 0x0400E383 RID: 58243
	[EnumStringMember("CiacconaEndingReward")]
	CiacconaEndingReward,
	// Token: 0x0400E384 RID: 58244
	[EnumStringMember("CiacconaSubEndingReward")]
	CiacconaSubEndingReward,
	// Token: 0x0400E385 RID: 58245
	[EnumStringMember("DangoMonopoly")]
	DangoMonopoly,
	// Token: 0x0400E386 RID: 58246
	[EnumStringMember("DangoMonopolyTask")]
	DangoMonopolyTask,
	// Token: 0x0400E387 RID: 58247
	[EnumStringMember("DangoMonopolyDiceNum")]
	DangoMonopolyDiceNum,
	// Token: 0x0400E388 RID: 58248
	[EnumStringMember("DangoMonopolyRound")]
	DangoMonopolyRound,
	// Token: 0x0400E389 RID: 58249
	[EnumStringMember("Morale")]
	Morale,
	// Token: 0x0400E38A RID: 58250
	[EnumStringMember("MoraleScoreBox")]
	MoraleScoreBox,
	// Token: 0x0400E38B RID: 58251
	[EnumStringMember("MoraleFlagBox")]
	MoraleFlagBox,
	// Token: 0x0400E38C RID: 58252
	[EnumStringMember("MoraleBuff")]
	MoraleBuff,
	// Token: 0x0400E38D RID: 58253
	[EnumStringMember("MoraleAreaBuff")]
	MoraleAreaBuff,
	// Token: 0x0400E38E RID: 58254
	[EnumStringMember("TrapDefense")]
	TrapDefense,
	// Token: 0x0400E38F RID: 58255
	[EnumStringMember("TrapDefenseFixedReward")]
	TrapDefenseFixedReward,
	// Token: 0x0400E390 RID: 58256
	[EnumStringMember("TrapDefenseLimitReward")]
	TrapDefenseLimitReward,
	// Token: 0x0400E391 RID: 58257
	[EnumStringMember("TrapDefenseMainLevel")]
	TrapDefenseMainLevel,
	// Token: 0x0400E392 RID: 58258
	[EnumStringMember("TrapDefenseLevelModeLevelReachOpenTime")]
	TrapDefenseLevelModeLevelReachOpenTime,
	// Token: 0x0400E393 RID: 58259
	[EnumStringMember("TrapDefenseRougeLevel")]
	TrapDefenseRougeLevel,
	// Token: 0x0400E394 RID: 58260
	[EnumStringMember("TrapDefenseTalentTree")]
	TrapDefenseTalentTree,
	// Token: 0x0400E395 RID: 58261
	[EnumStringMember("TrapDefenseDevelopBranchAll")]
	TrapDefenseDevelopBranchAll,
	// Token: 0x0400E396 RID: 58262
	[EnumStringMember("TrapDefenseDevelopBranchAuxiliary")]
	TrapDefenseDevelopBranchAuxiliary,
	// Token: 0x0400E397 RID: 58263
	[EnumStringMember("TrapDefenseDevelopBranchBuilding")]
	TrapDefenseDevelopBranchBuilding,
	// Token: 0x0400E398 RID: 58264
	[EnumStringMember("TrapDefenseRougeModeLevelReachOpenTime")]
	TrapDefenseRougeModeLevelReachOpenTime,
	// Token: 0x0400E399 RID: 58265
	[EnumStringMember("TrapDefenseRougeModeOpen")]
	TrapDefenseRougeModeOpen,
	// Token: 0x0400E39A RID: 58266
	[EnumStringMember("TrapDefenseBdSum")]
	TrapDefenseBdSum,
	// Token: 0x0400E39B RID: 58267
	[EnumStringMember("TrapDefenseBdBuffNewUnlock")]
	TrapDefenseBdBuffNewUnlock,
	// Token: 0x0400E39C RID: 58268
	[EnumStringMember("RedDotVersionCheck")]
	RedDotVersionCheck,
	// Token: 0x0400E39D RID: 58269
	[EnumStringMember("RedDotDangoCommonReward")]
	RedDotDangoCommonReward,
	// Token: 0x0400E39E RID: 58270
	[EnumStringMember("RedDotDangoLimitReward")]
	RedDotDangoLimitReward,
	// Token: 0x0400E39F RID: 58271
	[EnumStringMember("RedDotDangoPayShop")]
	RedDotDangoPayShop,
	// Token: 0x0400E3A0 RID: 58272
	[EnumStringMember("RedDotDangoDevelop")]
	RedDotDangoDevelop,
	// Token: 0x0400E3A1 RID: 58273
	[EnumStringMember("RedDotDangoRole")]
	RedDotDangoRole,
	// Token: 0x0400E3A2 RID: 58274
	[EnumStringMember("RedDotDangoFormation")]
	RedDotDangoFormation,
	// Token: 0x0400E3A3 RID: 58275
	[EnumStringMember("RedDotDangoFormationRole")]
	RedDotDangoFormationRole,
	// Token: 0x0400E3A4 RID: 58276
	[EnumStringMember("RedDotRacingBetsActivityReward")]
	RedDotRacingBetsActivityReward,
	// Token: 0x0400E3A5 RID: 58277
	[EnumStringMember("RedDotRacingBetsActivityInternalReward")]
	RedDotRacingBetsActivityInternalReward,
	// Token: 0x0400E3A6 RID: 58278
	[EnumStringMember("RedDotPhantomArenaLimitReward")]
	RedDotPhantomArenaLimitReward,
	// Token: 0x0400E3A7 RID: 58279
	[EnumStringMember("RedDotPhantomArenaTaskReward")]
	RedDotPhantomArenaTaskReward,
	// Token: 0x0400E3A8 RID: 58280
	[EnumStringMember("RedDotPhantomArenaShopUpdate")]
	RedDotPhantomArenaShopUpdate,
	// Token: 0x0400E3A9 RID: 58281
	[EnumStringMember("RedDotPhantomArenaCardReward")]
	RedDotPhantomArenaCardReward,
	// Token: 0x0400E3AA RID: 58282
	[EnumStringMember("RedDotPhantomArenaBadgeReward")]
	RedDotPhantomArenaBadgeReward,
	// Token: 0x0400E3AB RID: 58283
	[EnumStringMember("RedDotPhantomArenaLevelReward")]
	RedDotPhantomArenaLevelReward,
	// Token: 0x0400E3AC RID: 58284
	[EnumStringMember("RedDotPhantomArenaCollect")]
	RedDotPhantomArenaCollect,
	// Token: 0x0400E3AD RID: 58285
	[EnumStringMember("RedDotPhantomArenaRole")]
	RedDotPhantomArenaRole,
	// Token: 0x0400E3AE RID: 58286
	[EnumStringMember("RedDotPhantomArenaGym")]
	RedDotPhantomArenaGym,
	// Token: 0x0400E3AF RID: 58287
	[EnumStringMember("RedDotPhantomArenaActivity")]
	RedDotPhantomArenaActivity,
	// Token: 0x0400E3B0 RID: 58288
	[EnumStringMember("RedDotPhantomArenaMapUnlock")]
	RedDotPhantomArenaMapUnlock,
	// Token: 0x0400E3B1 RID: 58289
	[EnumStringMember("RedDotPhantomArenaMapUnlockDropDownItem")]
	RedDotPhantomArenaMapUnlockDropDownItem,
	// Token: 0x0400E3B2 RID: 58290
	[EnumStringMember("CumulativeShopTaskTabRedDot")]
	CumulativeShopTaskTabRedDot,
	// Token: 0x0400E3B3 RID: 58291
	[EnumStringMember("BeginnerCarnivalTaskTabRedDot")]
	BeginnerCarnivalTaskTabRedDot,
	// Token: 0x0400E3B4 RID: 58292
	[EnumStringMember("LifePointDrawChallengeRedDot")]
	LifePointDrawChallengeRedDot,
	// Token: 0x0400E3B5 RID: 58293
	[EnumStringMember("LifePointDrawGroupRedDot")]
	LifePointDrawGroupRedDot,
	// Token: 0x0400E3B6 RID: 58294
	[EnumStringMember("ActivityFunPlay")]
	ActivityFunPlay,
	// Token: 0x0400E3B7 RID: 58295
	[EnumStringMember("InfrShop")]
	InfrShop,
	// Token: 0x0400E3B8 RID: 58296
	[EnumStringMember("InfrLimitedTask")]
	InfrLimitedTask,
	// Token: 0x0400E3B9 RID: 58297
	[EnumStringMember("InfrArchive")]
	InfrArchive,
	// Token: 0x0400E3BA RID: 58298
	[EnumStringMember("Infrastructure")]
	Infrastructure,
	// Token: 0x0400E3BB RID: 58299
	[EnumStringMember("VillageInfrTask")]
	VillageInfrTask,
	// Token: 0x0400E3BC RID: 58300
	[EnumStringMember("VillageInfrTree")]
	VillageInfrTree,
	// Token: 0x0400E3BD RID: 58301
	[EnumStringMember("VillageInfr")]
	VillageInfr,
	// Token: 0x0400E3BE RID: 58302
	[EnumStringMember("RedDotNewPlayerSupportTrialRoleEntrance")]
	RedDotNewPlayerSupportTrialRoleEntrance,
	// Token: 0x0400E3BF RID: 58303
	[EnumStringMember("RedDotNewPlayerSupportAdventure")]
	RedDotNewPlayerSupportAdventure,
	// Token: 0x0400E3C0 RID: 58304
	[EnumStringMember("RedDotTrialRoleGroup")]
	RedDotTrialRoleGroup,
	// Token: 0x0400E3C1 RID: 58305
	[EnumStringMember("LineCrossChallengeRedDot")]
	LineCrossChallengeRedDot,
	// Token: 0x0400E3C2 RID: 58306
	[EnumStringMember("LineCrossGroupRedDot")]
	LineCrossGroupRedDot,
	// Token: 0x0400E3C3 RID: 58307
	[EnumStringMember("RedDotWeaponResonanceTab")]
	RedDotWeaponResonanceTab,
	// Token: 0x0400E3C4 RID: 58308
	[EnumStringMember("RedDotPhantomInteractUnlock")]
	RedDotPhantomInteractUnlock,
	// Token: 0x0400E3C5 RID: 58309
	[EnumStringMember("RedDotPhantomInteractEditEntry")]
	RedDotPhantomInteractEditEntry,
	// Token: 0x0400E3C6 RID: 58310
	[EnumStringMember("RedDotPhantomInteractRouletteGrid")]
	RedDotPhantomInteractRouletteGrid,
	// Token: 0x0400E3C7 RID: 58311
	[EnumStringMember("MotorcycleLevelTab")]
	MotorcycleLevelTab,
	// Token: 0x0400E3C8 RID: 58312
	[EnumStringMember("MotorcycleTechTreeTab")]
	MotorcycleTechTreeTab,
	// Token: 0x0400E3C9 RID: 58313
	[EnumStringMember("MotorcycleTreeTypeTechTab")]
	MotorcycleTreeTypeTechTab,
	// Token: 0x0400E3CA RID: 58314
	[EnumStringMember("MotorcycleTreeTypeTechTabNew")]
	MotorcycleTreeTypeTechTabNew,
	// Token: 0x0400E3CB RID: 58315
	[EnumStringMember("MotorcycleTreeTypeTaskTab")]
	MotorcycleTreeTypeTaskTab,
	// Token: 0x0400E3CC RID: 58316
	[EnumStringMember("MotorcycleTaskTab")]
	MotorcycleTaskTab,
	// Token: 0x0400E3CD RID: 58317
	[EnumStringMember("MotorcycleDiyTab")]
	MotorcycleDiyTab,
	// Token: 0x0400E3CE RID: 58318
	[EnumStringMember("MotorcycleSceneButtonRedDot")]
	MotorcycleSceneButtonRedDot,
	// Token: 0x0400E3CF RID: 58319
	[EnumStringMember("MotorcycleDiyFrameTab")]
	MotorcycleDiyFrameTab,
	// Token: 0x0400E3D0 RID: 58320
	[EnumStringMember("MotorcycleDiyStickerTab")]
	MotorcycleDiyStickerTab,
	// Token: 0x0400E3D1 RID: 58321
	[EnumStringMember("MotorcycleDiyStickerPartTab")]
	MotorcycleDiyStickerPartTab,
	// Token: 0x0400E3D2 RID: 58322
	[EnumStringMember("MotorcycleDiyDecorationTab")]
	MotorcycleDiyDecorationTab,
	// Token: 0x0400E3D3 RID: 58323
	[EnumStringMember("MotorcycleDiyDecorationPartTab")]
	MotorcycleDiyDecorationPartTab,
	// Token: 0x0400E3D4 RID: 58324
	[EnumStringMember("MotorcycleDiyFramePreTab")]
	MotorcycleDiyFramePreTab,
	// Token: 0x0400E3D5 RID: 58325
	[EnumStringMember("MotorcycleDiyStickerPreTab")]
	MotorcycleDiyStickerPreTab,
	// Token: 0x0400E3D6 RID: 58326
	[EnumStringMember("MotorcycleDiyStickerPrePartTab")]
	MotorcycleDiyStickerPrePartTab,
	// Token: 0x0400E3D7 RID: 58327
	[EnumStringMember("MotorcycleDiyDecorationPreTab")]
	MotorcycleDiyDecorationPreTab,
	// Token: 0x0400E3D8 RID: 58328
	[EnumStringMember("MotorcycleDiyDecorationPrePartTab")]
	MotorcycleDiyDecorationPrePartTab,
	// Token: 0x0400E3D9 RID: 58329
	[EnumStringMember("ActivityDirectTrainProEntry")]
	ActivityDirectTrainProEntry,
	// Token: 0x0400E3DA RID: 58330
	[EnumStringMember("FeedbackReward")]
	FeedbackReward,
	// Token: 0x0400E3DB RID: 58331
	[EnumStringMember("RedDotCyberPunkTask")]
	RedDotCyberPunkTask,
	// Token: 0x0400E3DC RID: 58332
	[EnumStringMember("RedDotCyberPunkTaskTab")]
	RedDotCyberPunkTaskTab,
	// Token: 0x0400E3DD RID: 58333
	[EnumStringMember("RedDotCyberPunkTrialRole")]
	RedDotCyberPunkTrialRole,
	// Token: 0x0400E3DE RID: 58334
	[EnumStringMember("RedDotCyberPunkBoss")]
	RedDotCyberPunkBoss,
	// Token: 0x0400E3DF RID: 58335
	[EnumStringMember("RedDotCyberPunkReward")]
	RedDotCyberPunkReward,
	// Token: 0x0400E3E0 RID: 58336
	[EnumStringMember("SpringManorGameEntrance")]
	SpringManorGameEntrance,
	// Token: 0x0400E3E1 RID: 58337
	[EnumStringMember("DrinksUnlockLevel")]
	DrinksUnlockLevel,
	// Token: 0x0400E3E2 RID: 58338
	[EnumStringMember("GuessJokerUnlockLevel")]
	GuessJokerUnlockLevel,
	// Token: 0x0400E3E3 RID: 58339
	[EnumStringMember("SpringManorAlbumReward")]
	SpringManorAlbumReward,
	// Token: 0x0400E3E4 RID: 58340
	[EnumStringMember("SpringManorBrochureReward")]
	SpringManorBrochureReward,
	// Token: 0x0400E3E5 RID: 58341
	[EnumStringMember("FurnitureEntranceRedDot")]
	FurnitureEntranceRedDot,
	// Token: 0x0400E3E6 RID: 58342
	[EnumStringMember("RhythmShipTimeLimitTask")]
	RhythmShipTimeLimitTask,
	// Token: 0x0400E3E7 RID: 58343
	[EnumStringMember("RhythmShipTask")]
	RhythmShipTask,
	// Token: 0x0400E3E8 RID: 58344
	[EnumStringMember("RhythmShipTaskTab")]
	RhythmShipTaskTab,
	// Token: 0x0400E3E9 RID: 58345
	[EnumStringMember("BossPilingReward")]
	BossPilingReward,
	// Token: 0x0400E3EA RID: 58346
	[EnumStringMember("RedDotFlagChallengeActivityReward")]
	RedDotFlagChallengeActivityReward,
	// Token: 0x0400E3EB RID: 58347
	[EnumStringMember("RedDotFlagChallengeActivityLevelNewlyUnlocked")]
	RedDotFlagChallengeActivityLevelNewlyUnlocked,
	// Token: 0x0400E3EC RID: 58348
	[EnumStringMember("RedDotFlagChallengeActivityBuffNewlyUnlocked")]
	RedDotFlagChallengeActivityBuffNewlyUnlocked,
	// Token: 0x0400E3ED RID: 58349
	[EnumStringMember("RedDotFlagChallengeActivityBuffItemNewlyUnlocked")]
	RedDotFlagChallengeActivityBuffItemNewlyUnlocked,
	// Token: 0x0400E3EE RID: 58350
	[EnumStringMember("RedDotFlagChallengeBattleBuffNewlyUnlocked")]
	RedDotFlagChallengeBattleBuffNewlyUnlocked,
	// Token: 0x0400E3EF RID: 58351
	[EnumStringMember("RedDotPinballRole")]
	RedDotPinballRole,
	// Token: 0x0400E3F0 RID: 58352
	[EnumStringMember("RedDotPinballRoleFunction")]
	RedDotPinballRoleFunction,
	// Token: 0x0400E3F1 RID: 58353
	[EnumStringMember("RedDotKurotatoRole")]
	RedDotKurotatoRole,
	// Token: 0x0400E3F2 RID: 58354
	[EnumStringMember("RedDotKurotatoWeaponAndProp")]
	RedDotKurotatoWeaponAndProp,
	// Token: 0x0400E3F3 RID: 58355
	[EnumStringMember("RedDotKurotatoWeapon")]
	RedDotKurotatoWeapon,
	// Token: 0x0400E3F4 RID: 58356
	[EnumStringMember("RedDotKurotatoProp")]
	RedDotKurotatoProp,
	// Token: 0x0400E3F5 RID: 58357
	[EnumStringMember("RedDotKurotatoNormalRewardBtn")]
	RedDotKurotatoNormalRewardBtn,
	// Token: 0x0400E3F6 RID: 58358
	[EnumStringMember("RedDotKurotatoLimitRewardBtn")]
	RedDotKurotatoLimitRewardBtn,
	// Token: 0x0400E3F7 RID: 58359
	[EnumStringMember("RedDotKurotatoLimitRewardTabItem")]
	RedDotKurotatoLimitRewardTabItem,
	// Token: 0x0400E3F8 RID: 58360
	[EnumStringMember("SheriffMap")]
	SheriffMap,
	// Token: 0x0400E3F9 RID: 58361
	[EnumStringMember("RedDotRoverlikeQuestRewardBtn")]
	RedDotRoverlikeQuestRewardBtn,
	// Token: 0x0400E3FA RID: 58362
	[EnumStringMember("RedDotRoverlikeShopRewardBtn")]
	RedDotRoverlikeShopRewardBtn,
	// Token: 0x0400E3FB RID: 58363
	[EnumStringMember("GiantMindsetEntry")]
	GiantMindsetEntry,
	// Token: 0x0400E3FC RID: 58364
	[EnumStringMember("GiantDeliverable")]
	GiantDeliverable,
	// Token: 0x0400E3FD RID: 58365
	[EnumStringMember("GiantAccessNew")]
	GiantAccessNew,
	// Token: 0x0400E3FE RID: 58366
	[EnumStringMember("GiantInteract")]
	GiantInteract,
	// Token: 0x0400E3FF RID: 58367
	[EnumStringMember("GiantCommission")]
	GiantCommission
}
