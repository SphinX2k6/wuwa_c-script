using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608E RID: 24718
	public static class IActionParams_Union_1Verify
	{
		// Token: 0x0602A318 RID: 172824 RVA: 0x005D0A84 File Offset: 0x005CEC84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetSportsStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetExploreStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyActorMaterialVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IModifyActorMaterialParamBySplineProgressVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IModifyActorMediaVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPlayLevelSequenceVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IEnableTakePhotoClipVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IToggleAirWallVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ITriggerCameraShakeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITriggerGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IPlayRegisteredMontageVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICreatePrefabVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IDestroyPrefabVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ISetDataLayerTransitionsVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IEnableAoiNotifyVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IRecoverDurabilityVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ISetPlayerOperationRestrictionVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IClientSetPlayerOperationRestrictionVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IClientEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IClientDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IClientDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IEnableFunctionVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = ITeleportDungeonFunctionVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IMotorRadioUiFunctionVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IInteractiveItemsFunctionVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IEnableClientFunctionVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IHealthBarDisplayClientFunctionVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IChangeEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IChangeTargetEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = IChangeSelfEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IModifySceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IModifySelfSceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IModifyTargetSceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IClientModifyTargetTagVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IToggleMapMarkStateVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IShowMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IHideMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IDisableMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IFocusOnMapMarkActionVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IEnableTemporaryTeleportVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = ISetRegionConfigVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = ISetRegionMpcVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = ISetJigsawItemVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = ISetJigsawFoundationVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IToggleHighlightExploreUiVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IShowHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IHideHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IToggleAndHighlightItemVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IResetEntityVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IResetLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IPlayDynamicSettlementVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = ISetInteractionLockStateVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = ISetAudioStateVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = IPerformerAiSplineMoveVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = IPerformerAiMoveToVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = IAddTrialFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = IRemoveTrialFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = IEnableFollowShooterAbilityVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = IClientFollowShooterLeisureInteractVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = ICustomJsonVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = IExecResurrectionVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = IOpenSystemBoardWithReturnVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = IResumeSystemRewardPopupVerify.Verify(verifier, tablePos);
				break;
			case 67:
				result = IExecRiskHarvestEffectVerify.Verify(verifier, tablePos);
				break;
			case 68:
				result = ISetTeleControlVerify.Verify(verifier, tablePos);
				break;
			case 69:
				result = IMowingTowerGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 70:
				result = ISlashAndTowerGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 71:
				result = IRoleTowerGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 72:
				result = IVehicleEnterVerify.Verify(verifier, tablePos);
				break;
			case 73:
				result = IEnterNpcVehicleVerify.Verify(verifier, tablePos);
				break;
			case 74:
				result = IVehicleExitPlayerVerify.Verify(verifier, tablePos);
				break;
			case 75:
				result = IVehicleExitNpcVerify.Verify(verifier, tablePos);
				break;
			case 76:
				result = ITeleportVehicleVerify.Verify(verifier, tablePos);
				break;
			case 77:
				result = IClientTeleportVehicleVerify.Verify(verifier, tablePos);
				break;
			case 78:
				result = IVehiclePlayPassengerVoiceVerify.Verify(verifier, tablePos);
				break;
			case 79:
				result = IVehicleWaterfallClimbingVerify.Verify(verifier, tablePos);
				break;
			case 80:
				result = ITeleportToAndEnterVehicleVerify.Verify(verifier, tablePos);
				break;
			case 81:
				result = IVehicleMoveWithPathLineVerify.Verify(verifier, tablePos);
				break;
			case 82:
				result = IVehicleSprintVerify.Verify(verifier, tablePos);
				break;
			case 83:
				result = IOpenQteActionVerify.Verify(verifier, tablePos);
				break;
			case 84:
				result = IPlayerInputVerify.Verify(verifier, tablePos);
				break;
			case 85:
				result = IPreloadActionVerify.Verify(verifier, tablePos);
				break;
			case 86:
				result = IRemovePreloadResourceActionVerify.Verify(verifier, tablePos);
				break;
			case 87:
				result = IExecAlertSystemActionVerify.Verify(verifier, tablePos);
				break;
			case 88:
				result = ISetSpineAnimationVerify.Verify(verifier, tablePos);
				break;
			case 89:
				result = IChangeEntityCampVerify.Verify(verifier, tablePos);
				break;
			case 90:
				result = IRecordDungeonEventVerify.Verify(verifier, tablePos);
				break;
			case 91:
				result = IDangoAbyssGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 92:
				result = IDangoAbyssCreateRewardTreasureBoxVerify.Verify(verifier, tablePos);
				break;
			case 93:
				result = IDangoAbyssActivatePortalVerify.Verify(verifier, tablePos);
				break;
			case 94:
				result = IDangoAbyssReceiveRewardVerify.Verify(verifier, tablePos);
				break;
			case 95:
				result = IRoverRogueActivateVerify.Verify(verifier, tablePos);
				break;
			case 96:
				result = IRoverRogueRoomFinishVerify.Verify(verifier, tablePos);
				break;
			case 97:
				result = IRoverRogueCreateRoomRewardVerify.Verify(verifier, tablePos);
				break;
			case 98:
				result = IGuestOperateUiAnimationVerify.Verify(verifier, tablePos);
				break;
			case 99:
				result = ISlideRailStartVerify.Verify(verifier, tablePos);
				break;
			case 100:
				result = ISlideRailEndVerify.Verify(verifier, tablePos);
				break;
			case 101:
				result = ISlidePerformStartVerify.Verify(verifier, tablePos);
				break;
			case 102:
				result = IBvbSendSystemEventVerify.Verify(verifier, tablePos);
				break;
			case 103:
				result = IBvbSendAiEventVerify.Verify(verifier, tablePos);
				break;
			case 104:
				result = IBvbPlayDialogVerify.Verify(verifier, tablePos);
				break;
			case 105:
				result = IBvbPlayerOperationConstraintVerify.Verify(verifier, tablePos);
				break;
			case 106:
				result = IBvbSkipChallengeVerify.Verify(verifier, tablePos);
				break;
			case 107:
				result = IActiveAntiGravitySafePointVerify.Verify(verifier, tablePos);
				break;
			case 108:
				result = ISummonEntityVerify.Verify(verifier, tablePos);
				break;
			case 109:
				result = IDestroySummonedEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 110:
				result = ISetupMoraleSystemVerify.Verify(verifier, tablePos);
				break;
			case 111:
				result = IGiantToggleModelVerify.Verify(verifier, tablePos);
				break;
			case 112:
				result = IGiantTriggerResponseVerify.Verify(verifier, tablePos);
				break;
			case 113:
				result = IActivateGiantTotalProgressNodeVerify.Verify(verifier, tablePos);
				break;
			case 114:
				result = IRunActorCustomEventVerify.Verify(verifier, tablePos);
				break;
			case 115:
				result = ITriggerSpecificScanEffectVerify.Verify(verifier, tablePos);
				break;
			case 116:
				result = ISendClientEventVerify.Verify(verifier, tablePos);
				break;
			case 117:
				result = IScanEnrichmentAreaVerify.Verify(verifier, tablePos);
				break;
			case 118:
				result = IRequestSystemFunctionVerify.Verify(verifier, tablePos);
				break;
			case 119:
				result = IReignsSetPropertyVisibleVerify.Verify(verifier, tablePos);
				break;
			case 120:
				result = IReignsChangeBackgroundVerify.Verify(verifier, tablePos);
				break;
			case 121:
				result = IReignsSetUiEffectVerify.Verify(verifier, tablePos);
				break;
			case 122:
				result = IReignsChangePlayerNameVerify.Verify(verifier, tablePos);
				break;
			case 123:
				result = IReignsCallCardVerify.Verify(verifier, tablePos);
				break;
			case 124:
				result = IReignsTriggerGuideVerify.Verify(verifier, tablePos);
				break;
			case 125:
				result = IReignsAddBuffVerify.Verify(verifier, tablePos);
				break;
			case 126:
				result = IReignsCheckSettleVerify.Verify(verifier, tablePos);
				break;
			case 127:
				result = ISetNpcGroupPerformVerify.Verify(verifier, tablePos);
				break;
			case 128:
				result = IRemoveNpcGroupPerformVerify.Verify(verifier, tablePos);
				break;
			case 129:
				result = IEnableEntityLookAtVerify.Verify(verifier, tablePos);
				break;
			case 130:
				result = IDisableEntityLookAtVerify.Verify(verifier, tablePos);
				break;
			case 131:
				result = IOverrideAiBehaviorTreeVerify.Verify(verifier, tablePos);
				break;
			case 132:
				result = IRestoreAiBehaviorTreeVerify.Verify(verifier, tablePos);
				break;
			case 133:
				result = IFlowDefineNpcGroupPerformVerify.Verify(verifier, tablePos);
				break;
			case 134:
				result = ISeqEventAddTagToSelfVerify.Verify(verifier, tablePos);
				break;
			case 135:
				result = ISeqEventFireBulletVerify.Verify(verifier, tablePos);
				break;
			case 136:
				result = ITrapDefenseChangeMiniMapVerify.Verify(verifier, tablePos);
				break;
			case 137:
				result = ITrapDefensePlayerOperationConstraintVerify.Verify(verifier, tablePos);
				break;
			case 138:
				result = IHonamiStoryInteractPickUpVerify.Verify(verifier, tablePos);
				break;
			case 139:
				result = IHonamiStoryReceiveCorruptedChestRewardVerify.Verify(verifier, tablePos);
				break;
			case 140:
				result = IHonamiStoryActivateSafeEvacuationVerify.Verify(verifier, tablePos);
				break;
			case 141:
				result = IHonamiStorySetFormationVerify.Verify(verifier, tablePos);
				break;
			case 142:
				result = IHonamiStoryGetItemVerify.Verify(verifier, tablePos);
				break;
			case 143:
				result = IInfrActivityUpgradeInfrastructureVerify.Verify(verifier, tablePos);
				break;
			case 144:
				result = IPlayWalkingOverlayMontageVerify.Verify(verifier, tablePos);
				break;
			case 145:
				result = IEnableKey4FuncVerify.Verify(verifier, tablePos);
				break;
			case 146:
				result = IChangeNpcAbpStateVerify.Verify(verifier, tablePos);
				break;
			case 147:
				result = IOverrideAbpAnimSchemeVerify.Verify(verifier, tablePos);
				break;
			case 148:
				result = ICloseWalkingOverlayMontageVerify.Verify(verifier, tablePos);
				break;
			case 149:
				result = ISetMotorSpeedVerify.Verify(verifier, tablePos);
				break;
			case 150:
				result = IVehicleSetSpeedImmediatelyVerify.Verify(verifier, tablePos);
				break;
			case 151:
				result = IStartMotorCruiseVerify.Verify(verifier, tablePos);
				break;
			case 152:
				result = IStopMotorCruiseVerify.Verify(verifier, tablePos);
				break;
			case 153:
				result = IDriveMotorInSpecConfigVerify.Verify(verifier, tablePos);
				break;
			case 154:
				result = IMotorSoarInWindFieldVerify.Verify(verifier, tablePos);
				break;
			case 155:
				result = ISetSkillBtnEffectVerify.Verify(verifier, tablePos);
				break;
			case 156:
				result = ICollectSunSpiritVerify.Verify(verifier, tablePos);
				break;
			case 157:
				result = IPerformSunSpiritGearRoundTripVerify.Verify(verifier, tablePos);
				break;
			case 158:
				result = ITriggerDeadeyeModeVerify.Verify(verifier, tablePos);
				break;
			case 159:
				result = ITriggerSystemRandomPlotVerify.Verify(verifier, tablePos);
				break;
			case 160:
				result = ISetAudioEnableVerify.Verify(verifier, tablePos);
				break;
			case 161:
				result = IPhoneSystemInteractVerify.Verify(verifier, tablePos);
				break;
			case 162:
				result = IRollBlockGetRewardVerify.Verify(verifier, tablePos);
				break;
			case 163:
				result = IEnterMovieModeVerify.Verify(verifier, tablePos);
				break;
			case 164:
				result = IExitMovieModeVerify.Verify(verifier, tablePos);
				break;
			case 165:
				result = IStartRoadNetworkNavigationVerify.Verify(verifier, tablePos);
				break;
			case 166:
				result = ISetWayOccupancyStateVerify.Verify(verifier, tablePos);
				break;
			case 167:
				result = IEnterPatrolStateVerify.Verify(verifier, tablePos);
				break;
			case 168:
				result = IPerformAiHideSelfVerify.Verify(verifier, tablePos);
				break;
			case 169:
				result = ISendSceneActorEventVerify.Verify(verifier, tablePos);
				break;
			case 170:
				result = IExecBpActorFuncVerify.Verify(verifier, tablePos);
				break;
			case 171:
				result = IResetPlayerPosWithPresentationVerify.Verify(verifier, tablePos);
				break;
			case 172:
				result = IDrinksRollRoleRequirementVerify.Verify(verifier, tablePos);
				break;
			case 173:
				result = ISetBlendAnimVerify.Verify(verifier, tablePos);
				break;
			case 174:
				result = IReportTrackingEventVerify.Verify(verifier, tablePos);
				break;
			case 175:
				result = ITetrisThrowBlockVerify.Verify(verifier, tablePos);
				break;
			case 176:
				result = ITetrisGameCompleteVerify.Verify(verifier, tablePos);
				break;
			case 177:
				result = ITetrisTriggerDelayFallVerify.Verify(verifier, tablePos);
				break;
			case 178:
				result = IBossPilingRandomBuffVerify.Verify(verifier, tablePos);
				break;
			case 179:
				result = IBossPilingEnterNextInstVerify.Verify(verifier, tablePos);
				break;
			case 180:
				result = IOpenQuickHackSystemVerify.Verify(verifier, tablePos);
				break;
			case 181:
				result = IDollGrabItemDeliveryVerify.Verify(verifier, tablePos);
				break;
			case 182:
				result = ISheriffUnlockClueVerify.Verify(verifier, tablePos);
				break;
			case 183:
				result = ISheriffUnlockProgressVerify.Verify(verifier, tablePos);
				break;
			case 184:
				result = ISheriffChangeCriminalStateVerify.Verify(verifier, tablePos);
				break;
			case 185:
				result = ISheriffChangeCriminalIdentityVerify.Verify(verifier, tablePos);
				break;
			case 186:
				result = ISheriffUnlockEndingVerify.Verify(verifier, tablePos);
				break;
			case 187:
				result = ISetTargetElementalAbilityVerify.Verify(verifier, tablePos);
				break;
			case 188:
				result = IToggleEntityElementalAbilityVerify.Verify(verifier, tablePos);
				break;
			case 189:
				result = ICaptureElementalBoxVerify.Verify(verifier, tablePos);
				break;
			case 190:
				result = IChangeElementalBoxStateVerify.Verify(verifier, tablePos);
				break;
			case 191:
				result = ISetElementalBoxToTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
