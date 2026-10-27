using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDF RID: 19423
	public static class ICondition2_UnionVerify
	{
		// Token: 0x0601EBD6 RID: 125910 RVA: 0x0044BC28 File Offset: 0x00449E28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICondition2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICompareVarConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestStateEqualConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICompareExploreLevelConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICompareCalabashLevelConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICompareLiftConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICompareEntityStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICompareNpcPerformStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICheckTreasureBeenClaimedConditionVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICompareEntityGroupStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICompareEntitySelfStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICompareLevelPlayRewardStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IHourToHourConditionVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IRangeSphereVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ICheckItemsVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IHasBuffVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ICheckSystemFunctionVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = ICheckAiStateVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = ICompareDungeonIdVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = ICompareTimePeriodVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = ICompareWeatherVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = ICheckLevelPlayStateVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = ICheckLevelPlayCompleteNumberVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = ICheckLevelPlayChildQuestFinishedVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ICheckCurrentRoleVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = ICheckPlayerGenderVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = ICheckInCombatVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ICheckHasFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = ICheckFollowShooterActiveVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ICheckChildQuestFinishedVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ICheckSyncLevelPlayCompleteNumberVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ICheckCrossSceneSyncKillMonsterFinishedVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ICheckNodeStatusVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = ICheckChildQuestStatusVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = ICheckEntitiesExistVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = ICheckPlayerPositionVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = ICheckEntityPositionVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = ICheckDungeonFinishVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = ICheckEntityIsVisibilityVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IComparePlayerMotionStateVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IComparePlayerMotionState2Verify.Verify(verifier, tablePos);
				break;
			case 42:
				result = ICheckDataLayerConditionVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = ICheckHookLockPointConditionVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = ICheckPlayerSkillReadyConditionVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = ICheckPlayerUseSkillConditionVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = ICheckPlayerStateRestrictionConditionVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = ICheckLordGymFinishConditionVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = ICheckCalabashDevelopRewardConditionVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = ICompareFishingPrestigeLevelConditionVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = ICheckCertainFishingItemCountVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = ICompleteCertainFishingEntrustVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = ICompareFishingBoatStateVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = ICheckJigsawInfoConditionVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = ICheckGameplayTagConditionVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = ICheckFormationRoleInfoConditionVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = ICheckTargetAttributeConditionVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = ICheckRogueAbilitySelectConditionVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = ICheckDirectionConditionVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = ICheckSceneItemDirectionConditionVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = ICheckPlayerFaceToConditionVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = ICheckPlayerCanJoinActivityConditionVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = ICheckSystemStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = ICheckInRangeConditionVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = ICheckInRangeProperlyConditionVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = ICheckEntityLockedConditionVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = ICompareTeammateDieConditionVerify.Verify(verifier, tablePos);
				break;
			case 67:
				result = IListenEntitySelfEventConditionVerify.Verify(verifier, tablePos);
				break;
			case 68:
				result = ICheckEntityDistanceConditionVerify.Verify(verifier, tablePos);
				break;
			case 69:
				result = ICheckEntityHasSceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 70:
				result = IListenEntityThroughPortalVerify.Verify(verifier, tablePos);
				break;
			case 71:
				result = ICheckTeleControlStateVerify.Verify(verifier, tablePos);
				break;
			case 72:
				result = ICustomJsonConditionVerify.Verify(verifier, tablePos);
				break;
			case 73:
				result = ICheckChessWinnerVerify.Verify(verifier, tablePos);
				break;
			case 74:
				result = ICheckVehicleConditionVerify.Verify(verifier, tablePos);
				break;
			case 75:
				result = ICompareAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 76:
				result = ICheckEntityGravityDirectionVerify.Verify(verifier, tablePos);
				break;
			case 77:
				result = ICheckCollectAnimalPartsVerify.Verify(verifier, tablePos);
				break;
			case 78:
				result = ICheckFinishLoadingVerify.Verify(verifier, tablePos);
				break;
			case 79:
				result = ICheckFishingPointHasFishVerify.Verify(verifier, tablePos);
				break;
			case 80:
				result = ICheckFishingCageFillingRatioVerify.Verify(verifier, tablePos);
				break;
			case 81:
				result = ICompareFishingTechLevelVerify.Verify(verifier, tablePos);
				break;
			case 82:
				result = ICheckGuestCharacterVerify.Verify(verifier, tablePos);
				break;
			case 83:
				result = ICheckSubLevelStateVerify.Verify(verifier, tablePos);
				break;
			case 84:
				result = IComparePlayerNumInDungeonVerify.Verify(verifier, tablePos);
				break;
			case 85:
				result = ICheckAlertAreaEnabledVerify.Verify(verifier, tablePos);
				break;
			case 86:
				result = ICheckClientEventVerify.Verify(verifier, tablePos);
				break;
			case 87:
				result = ICheckIsGramophonePlayingMusicVerify.Verify(verifier, tablePos);
				break;
			case 88:
				result = ICheckEntityRewardVerify.Verify(verifier, tablePos);
				break;
			case 89:
				result = ICheckDungeonHasSaveConfigVerify.Verify(verifier, tablePos);
				break;
			case 90:
				result = ICheckSystemEventBvbVerify.Verify(verifier, tablePos);
				break;
			case 91:
				result = ICheckDangoCultivationProgressVerify.Verify(verifier, tablePos);
				break;
			case 92:
				result = ICheckPlayerMoraleLevelRangeVerify.Verify(verifier, tablePos);
				break;
			case 93:
				result = ICheckIsGlobalTimeScaleEnabledVerify.Verify(verifier, tablePos);
				break;
			case 94:
				result = ISaveConfigEnterMethodVerify.Verify(verifier, tablePos);
				break;
			case 95:
				result = ICheckIsEntityTimeScaleEnabledVerify.Verify(verifier, tablePos);
				break;
			case 96:
				result = ICheckIsCharacterHoldingHandsVerify.Verify(verifier, tablePos);
				break;
			case 97:
				result = ICheckIsTrackingCurrentQuestVerify.Verify(verifier, tablePos);
				break;
			case 98:
				result = ICheckIsTrackingQuestVerify.Verify(verifier, tablePos);
				break;
			case 99:
				result = ICheckMusicEventVerify.Verify(verifier, tablePos);
				break;
			case 100:
				result = ICompareGameDifficultyVerify.Verify(verifier, tablePos);
				break;
			case 101:
				result = ICheckPhotographCameraParamVerify.Verify(verifier, tablePos);
				break;
			case 102:
				result = ICheckEntityHasBuffVerify.Verify(verifier, tablePos);
				break;
			case 103:
				result = ICheckEntityBuffStackVerify.Verify(verifier, tablePos);
				break;
			case 104:
				result = ICheckAvailableSunSpiritCountVerify.Verify(verifier, tablePos);
				break;
			case 105:
				result = ICheckPlayerEnterClientTriggerDirVerify.Verify(verifier, tablePos);
				break;
			case 106:
				result = ICheckPlayerRelativeDistanceVerify.Verify(verifier, tablePos);
				break;
			case 107:
				result = ICheckPlayerRelativeAngleVerify.Verify(verifier, tablePos);
				break;
			case 108:
				result = ICheckHonamiStoryGetItemVerify.Verify(verifier, tablePos);
				break;
			case 109:
				result = ICheckHonamiStoryEquipItemVerify.Verify(verifier, tablePos);
				break;
			case 110:
				result = ICheckHonamiStoryActivateTalentVerify.Verify(verifier, tablePos);
				break;
			case 111:
				result = ICheckHonamiStoryUnlockSlotVerify.Verify(verifier, tablePos);
				break;
			case 112:
				result = ICheckHonamiStoryLifeSupportLevelVerify.Verify(verifier, tablePos);
				break;
			case 113:
				result = ICheckHonamiStoryTowerCompleteVerify.Verify(verifier, tablePos);
				break;
			case 114:
				result = ICheckHonamiStoryPlayerCorruptedLevelVerify.Verify(verifier, tablePos);
				break;
			case 115:
				result = ICheckHonamiStoryUnlockMascotVerify.Verify(verifier, tablePos);
				break;
			case 116:
				result = ICheckHonamiStoryChestOpenTimeVerify.Verify(verifier, tablePos);
				break;
			case 117:
				result = ICheckHonamiStorySuccessfulEvacuationVerify.Verify(verifier, tablePos);
				break;
			case 118:
				result = ICheckBvbChallengeStateVerify.Verify(verifier, tablePos);
				break;
			case 119:
				result = ICheckBvbActivityRankVerify.Verify(verifier, tablePos);
				break;
			case 120:
				result = ICheckCollectedSunSpiritCountVerify.Verify(verifier, tablePos);
				break;
			case 121:
				result = ICheckTargetSunSpiritCollectedVerify.Verify(verifier, tablePos);
				break;
			case 122:
				result = ICheckPlayerIsInDeadEyeProcessVerify.Verify(verifier, tablePos);
				break;
			case 123:
				result = ICheckEntitySelfDirectionVerify.Verify(verifier, tablePos);
				break;
			case 124:
				result = ICheckDollGrabItemComboAchievedInOnceDeliveryVerify.Verify(verifier, tablePos);
				break;
			case 125:
				result = ICheckDollGrabShowcaseItemComboAchievedVerify.Verify(verifier, tablePos);
				break;
			case 126:
				result = ICheckRoverRogueAbilitySelectConditionVerify.Verify(verifier, tablePos);
				break;
			case 127:
				result = ICheckDollGrabMachineFinishedVerify.Verify(verifier, tablePos);
				break;
			case 128:
				result = ICheckTrafficBlockedVerify.Verify(verifier, tablePos);
				break;
			case 129:
				result = ICheckDrinksPreferenceLevelVerify.Verify(verifier, tablePos);
				break;
			case 130:
				result = ICheckPlayerIsInMotorcycleCruiseVerify.Verify(verifier, tablePos);
				break;
			case 131:
				result = ICheckTetrisEndlessScoreVerify.Verify(verifier, tablePos);
				break;
			case 132:
				result = ICheckAtlasUnlockedVerify.Verify(verifier, tablePos);
				break;
			case 133:
				result = ICheckSheriffUnlockEndingVerify.Verify(verifier, tablePos);
				break;
			case 134:
				result = ICheckIsInDragActorPlayVerify.Verify(verifier, tablePos);
				break;
			case 135:
				result = ICheckIsInDollGrabGamePlayVerify.Verify(verifier, tablePos);
				break;
			case 136:
				result = ICheckEntityPrefabPerformanceTypeVerify.Verify(verifier, tablePos);
				break;
			case 137:
				result = ICheckIsSupportedWalkingVerify.Verify(verifier, tablePos);
				break;
			case 138:
				result = ICheckGiantStableValueVerify.Verify(verifier, tablePos);
				break;
			case 139:
				result = ICheckGiantTotalProgressCanActivateNodeVerify.Verify(verifier, tablePos);
				break;
			case 140:
				result = ICheckGiantTotalProgressInteractActivatedNodeVerify.Verify(verifier, tablePos);
				break;
			case 141:
				result = ICheckGiantRegionCultivationTriggeredUpgradeLevelVerify.Verify(verifier, tablePos);
				break;
			case 142:
				result = ICheckElementalBoxStateVerify.Verify(verifier, tablePos);
				break;
			case 143:
				result = ICheckIsTargetHoldElementalBoxVerify.Verify(verifier, tablePos);
				break;
			case 144:
				result = ICheckElementalEffectActiveVerify.Verify(verifier, tablePos);
				break;
			case 145:
				result = ICheckElementalWaterBoxStagnationSeqVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
