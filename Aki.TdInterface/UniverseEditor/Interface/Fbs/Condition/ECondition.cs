using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004DE7 RID: 19943
	public enum ECondition : byte
	{
		// Token: 0x0400DAB8 RID: 55992
		CompareVar,
		// Token: 0x0400DAB9 RID: 55993
		CompareQuestState,
		// Token: 0x0400DABA RID: 55994
		CompareExploreLevel,
		// Token: 0x0400DABB RID: 55995
		CompareCalabashLevel,
		// Token: 0x0400DABC RID: 55996
		CompareEntityState,
		// Token: 0x0400DABD RID: 55997
		CompareNpcPerformState,
		// Token: 0x0400DABE RID: 55998
		CheckTreasureBeenClaimed,
		// Token: 0x0400DABF RID: 55999
		CompareEntityGroupState,
		// Token: 0x0400DAC0 RID: 56000
		CompareLevelPlayRewardState,
		// Token: 0x0400DAC1 RID: 56001
		CompareEntitySelfState,
		// Token: 0x0400DAC2 RID: 56002
		HourToHour,
		// Token: 0x0400DAC3 RID: 56003
		RangeSphere,
		// Token: 0x0400DAC4 RID: 56004
		CheckItems,
		// Token: 0x0400DAC5 RID: 56005
		HasBuff,
		// Token: 0x0400DAC6 RID: 56006
		CheckEntityHasBuff,
		// Token: 0x0400DAC7 RID: 56007
		CheckEntityBuffStack,
		// Token: 0x0400DAC8 RID: 56008
		ListenEntitySelfEvent,
		// Token: 0x0400DAC9 RID: 56009
		CheckSystemFunction,
		// Token: 0x0400DACA RID: 56010
		CompareLift,
		// Token: 0x0400DACB RID: 56011
		CompareDungeonId,
		// Token: 0x0400DACC RID: 56012
		CheckAiState,
		// Token: 0x0400DACD RID: 56013
		CompareTimePeriod,
		// Token: 0x0400DACE RID: 56014
		CompareWeather,
		// Token: 0x0400DACF RID: 56015
		CheckLevelPlayState,
		// Token: 0x0400DAD0 RID: 56016
		CheckLevelPlayCompleteNumber,
		// Token: 0x0400DAD1 RID: 56017
		CheckLevelPlayChildQuestFinished,
		// Token: 0x0400DAD2 RID: 56018
		CheckCurrentRole,
		// Token: 0x0400DAD3 RID: 56019
		CheckPlayerGender,
		// Token: 0x0400DAD4 RID: 56020
		CheckInCombat,
		// Token: 0x0400DAD5 RID: 56021
		CheckHasFollowShooter,
		// Token: 0x0400DAD6 RID: 56022
		CheckFollowShooterActive,
		// Token: 0x0400DAD7 RID: 56023
		CheckChildQuestFinished,
		// Token: 0x0400DAD8 RID: 56024
		ComparePlayerMotionState,
		// Token: 0x0400DAD9 RID: 56025
		ComparePlayerMotionState2,
		// Token: 0x0400DADA RID: 56026
		CheckDataLayer,
		// Token: 0x0400DADB RID: 56027
		CheckHookLockPoint,
		// Token: 0x0400DADC RID: 56028
		CheckPlayerSkillReady,
		// Token: 0x0400DADD RID: 56029
		CheckPlayerUseSkill,
		// Token: 0x0400DADE RID: 56030
		CheckPlayerStateRestriction,
		// Token: 0x0400DADF RID: 56031
		CheckJigsawInfo,
		// Token: 0x0400DAE0 RID: 56032
		CheckLordGymFinish,
		// Token: 0x0400DAE1 RID: 56033
		CheckCalabashDevelopReward,
		// Token: 0x0400DAE2 RID: 56034
		CheckGameplayTag,
		// Token: 0x0400DAE3 RID: 56035
		CheckFormationRoleInfo,
		// Token: 0x0400DAE4 RID: 56036
		CheckTargetAttribute,
		// Token: 0x0400DAE5 RID: 56037
		CheckRogueAbilitySelect,
		// Token: 0x0400DAE6 RID: 56038
		CompareTeammateDie,
		// Token: 0x0400DAE7 RID: 56039
		CheckNodeStatus,
		// Token: 0x0400DAE8 RID: 56040
		CheckChildQuestStatus,
		// Token: 0x0400DAE9 RID: 56041
		CheckEntitesExist,
		// Token: 0x0400DAEA RID: 56042
		CheckPlayerPosition,
		// Token: 0x0400DAEB RID: 56043
		CheckEntityPosition,
		// Token: 0x0400DAEC RID: 56044
		CheckDirection,
		// Token: 0x0400DAED RID: 56045
		CheckSceneItemDirection,
		// Token: 0x0400DAEE RID: 56046
		CheckPlayerFaceTo,
		// Token: 0x0400DAEF RID: 56047
		CheckPlayerCanJoinActivity,
		// Token: 0x0400DAF0 RID: 56048
		CheckSystemState,
		// Token: 0x0400DAF1 RID: 56049
		CheckInRange,
		// Token: 0x0400DAF2 RID: 56050
		CheckInRangeProperly,
		// Token: 0x0400DAF3 RID: 56051
		CheckEntityLocked,
		// Token: 0x0400DAF4 RID: 56052
		CheckEntityDistance,
		// Token: 0x0400DAF5 RID: 56053
		CheckDungeonFinish,
		// Token: 0x0400DAF6 RID: 56054
		CheckEntityIsVisibility,
		// Token: 0x0400DAF7 RID: 56055
		CheckEntityHasSceneItemAttributeTag,
		// Token: 0x0400DAF8 RID: 56056
		ListenEntityThroughPortal,
		// Token: 0x0400DAF9 RID: 56057
		CheckTeleControlState,
		// Token: 0x0400DAFA RID: 56058
		CustomJson,
		// Token: 0x0400DAFB RID: 56059
		CheckChessWinner,
		// Token: 0x0400DAFC RID: 56060
		CheckVehicleCondition,
		// Token: 0x0400DAFD RID: 56061
		CompareAlertValue,
		// Token: 0x0400DAFE RID: 56062
		CheckEntityGravityDirection,
		// Token: 0x0400DAFF RID: 56063
		CheckCollectAnimalParts,
		// Token: 0x0400DB00 RID: 56064
		CompleteCertainFishingEntrust,
		// Token: 0x0400DB01 RID: 56065
		CheckCertainFishingItemCount,
		// Token: 0x0400DB02 RID: 56066
		CompareFishingPrestigeLevel,
		// Token: 0x0400DB03 RID: 56067
		CompareFishingBoatState,
		// Token: 0x0400DB04 RID: 56068
		CheckFinishLoading,
		// Token: 0x0400DB05 RID: 56069
		CheckPreloadComplete,
		// Token: 0x0400DB06 RID: 56070
		CheckFishingPointHasFish,
		// Token: 0x0400DB07 RID: 56071
		CheckFishingCageFillingRatio,
		// Token: 0x0400DB08 RID: 56072
		CompareFishingTechLevel,
		// Token: 0x0400DB09 RID: 56073
		CheckGuestCharacter,
		// Token: 0x0400DB0A RID: 56074
		CheckSubLevelState,
		// Token: 0x0400DB0B RID: 56075
		ComparePlayerNumInDungeon,
		// Token: 0x0400DB0C RID: 56076
		CheckAlertAreaEnabled,
		// Token: 0x0400DB0D RID: 56077
		CheckClientEvent,
		// Token: 0x0400DB0E RID: 56078
		CheckIsGramophonePlayingMusic,
		// Token: 0x0400DB0F RID: 56079
		CheckEntityReward,
		// Token: 0x0400DB10 RID: 56080
		CheckDungeonHasSaveConfig,
		// Token: 0x0400DB11 RID: 56081
		CheckBVBEvent,
		// Token: 0x0400DB12 RID: 56082
		CheckDangoCultivationProgress,
		// Token: 0x0400DB13 RID: 56083
		CheckPlayerMoraleLevelRange,
		// Token: 0x0400DB14 RID: 56084
		CheckIsGlobalTimeScaleEnabled,
		// Token: 0x0400DB15 RID: 56085
		SaveConfigEnterMethod,
		// Token: 0x0400DB16 RID: 56086
		CheckIsEntityTimeScaleEnabled,
		// Token: 0x0400DB17 RID: 56087
		CheckIsCharacterHoldingHands,
		// Token: 0x0400DB18 RID: 56088
		CheckIsTrackingCurrentQuest,
		// Token: 0x0400DB19 RID: 56089
		CheckIsTrackingQuest,
		// Token: 0x0400DB1A RID: 56090
		CheckMusicBeatsEvent,
		// Token: 0x0400DB1B RID: 56091
		CompareGameDifficulty,
		// Token: 0x0400DB1C RID: 56092
		CheckPhotographCameraParam,
		// Token: 0x0400DB1D RID: 56093
		CheckAvailableSunSpiritCount,
		// Token: 0x0400DB1E RID: 56094
		CheckHonamiStoryGetItem,
		// Token: 0x0400DB1F RID: 56095
		CheckHonamiStoryEquipItem,
		// Token: 0x0400DB20 RID: 56096
		CheckHonamiStoryActivateTalent,
		// Token: 0x0400DB21 RID: 56097
		CheckHonamiStoryUnlockSlot,
		// Token: 0x0400DB22 RID: 56098
		CheckHonamiStoryLifeSupportLevel,
		// Token: 0x0400DB23 RID: 56099
		CheckHonamiStoryTowerComplete,
		// Token: 0x0400DB24 RID: 56100
		CheckHonamiStoryPlayerCorruptedLevel,
		// Token: 0x0400DB25 RID: 56101
		CheckHonamiStoryUnlockMascot,
		// Token: 0x0400DB26 RID: 56102
		CheckHonamiStoryChestOpenTime,
		// Token: 0x0400DB27 RID: 56103
		CheckHonamiStorySuccessfulEvacuation,
		// Token: 0x0400DB28 RID: 56104
		CheckPlayerEnterClientTriggerDir,
		// Token: 0x0400DB29 RID: 56105
		CheckPlayerRelativeAngle,
		// Token: 0x0400DB2A RID: 56106
		CheckBvbChallengeState,
		// Token: 0x0400DB2B RID: 56107
		CheckBvbActivityRank,
		// Token: 0x0400DB2C RID: 56108
		CheckCollectedSunSpiritCount,
		// Token: 0x0400DB2D RID: 56109
		CheckTargetSunSpiritCollected,
		// Token: 0x0400DB2E RID: 56110
		CheckPlayerIsInDeadEyeProcess,
		// Token: 0x0400DB2F RID: 56111
		CheckTrafficBlocked,
		// Token: 0x0400DB30 RID: 56112
		CheckPlayerRelativeDistance,
		// Token: 0x0400DB31 RID: 56113
		CheckDrinksPreferenceLevel,
		// Token: 0x0400DB32 RID: 56114
		CheckPlayerIsInMotorcycleCruise,
		// Token: 0x0400DB33 RID: 56115
		CheckPlayerIsControlledByAi,
		// Token: 0x0400DB34 RID: 56116
		CheckEntitySelfDirection,
		// Token: 0x0400DB35 RID: 56117
		CheckDollGrabItemComboAchievedInOnceDelivery,
		// Token: 0x0400DB36 RID: 56118
		CheckDollGrabShowcaseItemComboAchieved,
		// Token: 0x0400DB37 RID: 56119
		CheckDollGrabMachineFinished,
		// Token: 0x0400DB38 RID: 56120
		CheckTetrisEndlessScore,
		// Token: 0x0400DB39 RID: 56121
		CheckDartLevelComplete,
		// Token: 0x0400DB3A RID: 56122
		CheckAtlasUnlocked,
		// Token: 0x0400DB3B RID: 56123
		CheckSheriffUnlockEnding,
		// Token: 0x0400DB3C RID: 56124
		CheckSyncLevelPlayCompleteNumber,
		// Token: 0x0400DB3D RID: 56125
		CheckCrossSceneSyncKillMonsterFinished,
		// Token: 0x0400DB3E RID: 56126
		CheckIsInDragActorPlay,
		// Token: 0x0400DB3F RID: 56127
		CheckIsInDollGrabGamePlay,
		// Token: 0x0400DB40 RID: 56128
		CheckIsInDartGameplay,
		// Token: 0x0400DB41 RID: 56129
		CheckIsInRideFlyingCarGameplay,
		// Token: 0x0400DB42 RID: 56130
		CheckEntityPrefabPerformanceType,
		// Token: 0x0400DB43 RID: 56131
		CheckRoverRogueAbilitySelect,
		// Token: 0x0400DB44 RID: 56132
		CheckIsSupportedWalking,
		// Token: 0x0400DB45 RID: 56133
		CheckIsTargetHoldElementalBox,
		// Token: 0x0400DB46 RID: 56134
		CheckElementalBoxState,
		// Token: 0x0400DB47 RID: 56135
		CheckElementalEffectActive,
		// Token: 0x0400DB48 RID: 56136
		CheckGiantStableValue,
		// Token: 0x0400DB49 RID: 56137
		CheckGiantTotalProgressCanActivateNode,
		// Token: 0x0400DB4A RID: 56138
		CheckGiantTotalProgressInteractActivatedNode,
		// Token: 0x0400DB4B RID: 56139
		CheckGiantRegionCultivationTriggeredUpgradeLevel,
		// Token: 0x0400DB4C RID: 56140
		CheckElementalWaterBoxStagnationSeq,
		// Token: 0x0400DB4D RID: 56141
		CheckMechState,
		// Token: 0x0400DB4E RID: 56142
		CheckExploreSkillState,
		// Token: 0x0400DB4F RID: 56143
		CompareSeasonWeather,
		// Token: 0x0400DB50 RID: 56144
		CheckSeasonWeatherSpecialUnlocked,
		// Token: 0x0400DB51 RID: 56145
		CheckCollectiblesDetectionAllowed,
		// Token: 0x0400DB52 RID: 56146
		CheckDiceGameChallengeState,
		// Token: 0x0400DB53 RID: 56147
		CompareDiceGameRankLevel
	}
}
