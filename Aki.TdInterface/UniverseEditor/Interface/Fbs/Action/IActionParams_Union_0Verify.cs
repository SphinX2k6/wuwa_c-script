using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066ED RID: 26349
	public static class IActionParams_Union_0Verify
	{
		// Token: 0x0602C855 RID: 182357 RVA: 0x00616D20 File Offset: 0x00614F20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActionParamsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInvokeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFinishConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IGetRewardByInteractVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IWaitUntilLevelSequenceReachMarkVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IClearEntityVisibleTagVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ISetEntityPosVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IResetEntityPosVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IServerSetPlayerPosVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IFixTeleControllerPosVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IFixTeleControllerResetPosVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IFixFoundationRelationVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ITraceCurrentQuestVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IFixShowTargetRangeVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IFixGetItemVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ILogVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IShowMessageVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IPromptVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = ISendNpcMailVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IAdjustTodTimeVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = ISetAreaTimeStateVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = ISetTimeScaleVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IJumpTalkVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ISetHeadIconVisibleVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IPlayMontageVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IAvgPlayRoleActionVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IAvgMoveRoleVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IAvgFocusRoleVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IAvgShakeUiVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IDestroyDynamicEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IActorLookAtVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = IActorTurnToVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IShowTalkVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IFinishTalkVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IShowCenterTextVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IFinishStateVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IChangeStateVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IChangeBehaviorStateVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = ISetBehaviorIsPausedVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IChangeRandomStateVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IChangeActorStateVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IChangeOtherStateVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = ISetCameraModeVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IModifySceneUiSubtitleVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = ISetPlotModeVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IPlaySequenceDataVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IPlayCustomSequenceVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IPlayMovieVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IPlayEffectVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IPlayEffect2Verify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IPlayCommonEffectVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IPlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = ISwitchEffectStateVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IPlayDissolveEffectVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IPlayMpcEffectVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = IRemoveEffectVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = IWaitVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = IMoveToPosAVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = ISetMoveSpeedVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = ISetPosAVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = IFaceToPosVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = ISpawnChildVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = ISimpleMoveVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = ISetNumberVarVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = ISyncVarToActorStateVerify.Verify(verifier, tablePos);
				break;
			case 67:
				result = IDoCalculateVerify.Verify(verifier, tablePos);
				break;
			case 68:
				result = ICallByConditionVerify.Verify(verifier, tablePos);
				break;
			case 69:
				result = ICallFunctionVerify.Verify(verifier, tablePos);
				break;
			case 70:
				result = IAddFlowInteractOptionVerify.Verify(verifier, tablePos);
				break;
			case 71:
				result = IRemoveFlowInteractOptionVerify.Verify(verifier, tablePos);
				break;
			case 72:
				result = IChangeInteractOptionTextVerify.Verify(verifier, tablePos);
				break;
			case 73:
				result = ISpawnEntityVerify.Verify(verifier, tablePos);
				break;
			case 74:
				result = IDestroyAllChildVerify.Verify(verifier, tablePos);
				break;
			case 75:
				result = IDestroyEntityVerify.Verify(verifier, tablePos);
				break;
			case 76:
				result = IPlayFlowVerify.Verify(verifier, tablePos);
				break;
			case 77:
				result = IBubbleDataVerify.Verify(verifier, tablePos);
				break;
			case 78:
				result = IPlayerLookAtVerify.Verify(verifier, tablePos);
				break;
			case 79:
				result = IEntityLookAtVerify.Verify(verifier, tablePos);
				break;
			case 80:
				result = ICharacterLookAtVerify.Verify(verifier, tablePos);
				break;
			case 81:
				result = IPlayerLookTowardsVerify.Verify(verifier, tablePos);
				break;
			case 82:
				result = IEntityTurnToVerify.Verify(verifier, tablePos);
				break;
			case 83:
				result = ICameraLookAtVerify.Verify(verifier, tablePos);
				break;
			case 84:
				result = IStopCameraLookAtVerify.Verify(verifier, tablePos);
				break;
			case 85:
				result = ISetVarVerify.Verify(verifier, tablePos);
				break;
			case 86:
				result = ISetActorVarVerify.Verify(verifier, tablePos);
				break;
			case 87:
				result = ICalculateVarVerify.Verify(verifier, tablePos);
				break;
			case 88:
				result = IRandomVarVerify.Verify(verifier, tablePos);
				break;
			case 89:
				result = IGuideTriggerVerify.Verify(verifier, tablePos);
				break;
			case 90:
				result = ICompleteGuideVerify.Verify(verifier, tablePos);
				break;
			case 91:
				result = IGetItemVerify.Verify(verifier, tablePos);
				break;
			case 92:
				result = IDestroyQuestItemVerify.Verify(verifier, tablePos);
				break;
			case 93:
				result = IAwakeEntityVerify.Verify(verifier, tablePos);
				break;
			case 94:
				result = ISetEntityVisibleVerify.Verify(verifier, tablePos);
				break;
			case 95:
				result = ISetEntityClientVisibleVerify.Verify(verifier, tablePos);
				break;
			case 96:
				result = ISetEntityClientVisibleSaveVerify.Verify(verifier, tablePos);
				break;
			case 97:
				result = ILockEntityVerify.Verify(verifier, tablePos);
				break;
			case 98:
				result = IUnlockEntityVerify.Verify(verifier, tablePos);
				break;
			case 99:
				result = ICompleteChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 100:
				result = IAcceptCurrentQuestVerify.Verify(verifier, tablePos);
				break;
			case 101:
				result = IFinishDoInteractVerify.Verify(verifier, tablePos);
				break;
			case 102:
				result = IModifyEntityDecorationVerify.Verify(verifier, tablePos);
				break;
			case 103:
				result = IAddBuffToEntityVerify.Verify(verifier, tablePos);
				break;
			case 104:
				result = IAddBuffToPlayerVerify.Verify(verifier, tablePos);
				break;
			case 105:
				result = IAddBuffToFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 106:
				result = IOpenSystemBoardVerify.Verify(verifier, tablePos);
				break;
			case 107:
				result = IOpenSystemFunctionVerify.Verify(verifier, tablePos);
				break;
			case 108:
				result = IChangeEntityStateVerify.Verify(verifier, tablePos);
				break;
			case 109:
				result = IChangeEntityStateDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 110:
				result = IChangeEntityStateBatchDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 111:
				result = IChangeEntityStateLoopVerify.Verify(verifier, tablePos);
				break;
			case 112:
				result = IChangeNpcPerformStateVerify.Verify(verifier, tablePos);
				break;
			case 113:
				result = ISetForceLockVerify.Verify(verifier, tablePos);
				break;
			case 114:
				result = ISetAreaStateVerify.Verify(verifier, tablePos);
				break;
			case 115:
				result = ISetWuYinQuStateVerify.Verify(verifier, tablePos);
				break;
			case 116:
				result = IRemoveBuffFromEntityVerify.Verify(verifier, tablePos);
				break;
			case 117:
				result = IRemoveBuffFromPlayerVerify.Verify(verifier, tablePos);
				break;
			case 118:
				result = ICollectVerify.Verify(verifier, tablePos);
				break;
			case 119:
				result = IDestroyVerify.Verify(verifier, tablePos);
				break;
			case 120:
				result = IDestroySelfVerify.Verify(verifier, tablePos);
				break;
			case 121:
				result = ISetPlayerMoveControlVerify.Verify(verifier, tablePos);
				break;
			case 122:
				result = IUnlockTeleportTriggerVerify.Verify(verifier, tablePos);
				break;
			case 123:
				result = IChangeTeamPositionVerify.Verify(verifier, tablePos);
				break;
			case 124:
				result = IClientChangeTeamPositionVerify.Verify(verifier, tablePos);
				break;
			case 125:
				result = IClaimLevelPlayRewardVerify.Verify(verifier, tablePos);
				break;
			case 126:
				result = IClaimDynamicEntityRewardVerify.Verify(verifier, tablePos);
				break;
			case 127:
				result = IClearFishingCabinInSaleItemsVerify.Verify(verifier, tablePos);
				break;
			case 128:
				result = IAcceptFishingEntrustVerify.Verify(verifier, tablePos);
				break;
			case 129:
				result = IDestroyFishingBoatVerify.Verify(verifier, tablePos);
				break;
			case 130:
				result = ITeleportDungeonVerify.Verify(verifier, tablePos);
				break;
			case 131:
				result = IStopUiScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 132:
				result = IClaimDungeonRewardVerify.Verify(verifier, tablePos);
				break;
			case 133:
				result = ISettlementDungeonVerify.Verify(verifier, tablePos);
				break;
			case 134:
				result = IExitDungeonVerify.Verify(verifier, tablePos);
				break;
			case 135:
				result = IUnlockDungeonEntryVerify.Verify(verifier, tablePos);
				break;
			case 136:
				result = IFinishDungeonVerify.Verify(verifier, tablePos);
				break;
			case 137:
				result = ISetReviveRegionVerify.Verify(verifier, tablePos);
				break;
			case 138:
				result = IPromptQuestChapterUIVerify.Verify(verifier, tablePos);
				break;
			case 139:
				result = IFireBulletVerify.Verify(verifier, tablePos);
				break;
			case 140:
				result = IFireBulletEffectVerify.Verify(verifier, tablePos);
				break;
			case 141:
				result = ISetAssistCharacterPosVerify.Verify(verifier, tablePos);
				break;
			case 142:
				result = ISetPlayerPosVerify.Verify(verifier, tablePos);
				break;
			case 143:
				result = IClientSetPlayerPosVerify.Verify(verifier, tablePos);
				break;
			case 144:
				result = IClientPreEnableSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 145:
				result = IRogueGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 146:
				result = IRogueSelectRoomVerify.Verify(verifier, tablePos);
				break;
			case 147:
				result = IRogueActivatePortalVerify.Verify(verifier, tablePos);
				break;
			case 148:
				result = IRogueReceiveRewardVerify.Verify(verifier, tablePos);
				break;
			case 149:
				result = IChangeSelfEntityStateVerify.Verify(verifier, tablePos);
				break;
			case 150:
				result = IInterludeActionsVerify.Verify(verifier, tablePos);
				break;
			case 151:
				result = IAddBuffToTriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 152:
				result = IRemoveBuffToTriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 153:
				result = IDetectTriggerVerify.Verify(verifier, tablePos);
				break;
			case 154:
				result = IItemFoundationMatchVerify.Verify(verifier, tablePos);
				break;
			case 155:
				result = ISetBattleStateVerify.Verify(verifier, tablePos);
				break;
			case 156:
				result = IExecBattleActionVerify.Verify(verifier, tablePos);
				break;
			case 157:
				result = IExecClientMonsterNpcInteractVerify.Verify(verifier, tablePos);
				break;
			case 158:
				result = IExecClientBattleActionVerify.Verify(verifier, tablePos);
				break;
			case 159:
				result = IWaitBattleConditionVerify.Verify(verifier, tablePos);
				break;
			case 160:
				result = IEnableHostilityVerify.Verify(verifier, tablePos);
				break;
			case 161:
				result = IUnlockSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 162:
				result = IClientUnlockAchievementSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 163:
				result = IAddPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 164:
				result = IPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 165:
				result = IClearPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 166:
				result = IMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 167:
				result = INewMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 168:
				result = IStopNewMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 169:
				result = ICharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 170:
				result = IPlayerMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 171:
				result = INpcMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 172:
				result = IToggleScanSplineEffectVerify.Verify(verifier, tablePos);
				break;
			case 173:
				result = IOpenTraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 174:
				result = ICloseTraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 175:
				result = ITraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 176:
				result = IEnableAIVerify.Verify(verifier, tablePos);
				break;
			case 177:
				result = IRunActionsVerify.Verify(verifier, tablePos);
				break;
			case 178:
				result = ICommonTipVerify.Verify(verifier, tablePos);
				break;
			case 179:
				result = ICommonTip2Verify.Verify(verifier, tablePos);
				break;
			case 180:
				result = IEndCommonTipVerify.Verify(verifier, tablePos);
				break;
			case 181:
				result = IEnableNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 182:
				result = ISendAiEventVerify.Verify(verifier, tablePos);
				break;
			case 183:
				result = IEnableLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 184:
				result = IServerForceEnableLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 185:
				result = ITeleportDungeonPosVerify.Verify(verifier, tablePos);
				break;
			case 186:
				result = IFadeInScreenVerify.Verify(verifier, tablePos);
				break;
			case 187:
				result = IFadeOutScreenVerify.Verify(verifier, tablePos);
				break;
			case 188:
				result = IStartFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 189:
				result = IEndFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 190:
				result = ICloseFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 191:
				result = IChangeFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 192:
				result = IBeginFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 193:
				result = ISetFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 194:
				result = IHideTargetRangeVerify.Verify(verifier, tablePos);
				break;
			case 195:
				result = IShowTargetRangeVerify.Verify(verifier, tablePos);
				break;
			case 196:
				result = IHideSpecificEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 197:
				result = IShowSpecificEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 198:
				result = IHideGroupVerify.Verify(verifier, tablePos);
				break;
			case 199:
				result = IShowHidedGroupVerify.Verify(verifier, tablePos);
				break;
			case 200:
				result = ISetSubScreenModeVerify.Verify(verifier, tablePos);
				break;
			case 201:
				result = IToggleDragActorPlayVerify.Verify(verifier, tablePos);
				break;
			case 202:
				result = IDarkTideSetMapMarkStateVerify.Verify(verifier, tablePos);
				break;
			case 203:
				result = IManualOccupationsVerify.Verify(verifier, tablePos);
				break;
			case 204:
				result = IForceOccupationsVerify.Verify(verifier, tablePos);
				break;
			case 205:
				result = IChangeFightTeamVerify.Verify(verifier, tablePos);
				break;
			case 206:
				result = IActiveRangeVerify.Verify(verifier, tablePos);
				break;
			case 207:
				result = IAddTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 208:
				result = IUpdateTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 209:
				result = IRestoreTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 210:
				result = IRemoveTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 211:
				result = IAddGuestCharacterVerify.Verify(verifier, tablePos);
				break;
			case 212:
				result = IRemoveGuestCharacterVerify.Verify(verifier, tablePos);
				break;
			case 213:
				result = IDestroyQuestVerify.Verify(verifier, tablePos);
				break;
			case 214:
				result = ISetCameraAnimVerify.Verify(verifier, tablePos);
				break;
			case 215:
				result = IChangeTimerVerify.Verify(verifier, tablePos);
				break;
			case 216:
				result = IToggleTimerPauseStateVerify.Verify(verifier, tablePos);
				break;
			case 217:
				result = IRotatorEntityVerify.Verify(verifier, tablePos);
				break;
			case 218:
				result = IUnLimitPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 219:
				result = ILimitPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 220:
				result = IEnableSystemVerify.Verify(verifier, tablePos);
				break;
			case 221:
				result = ILeisureInteractVerify.Verify(verifier, tablePos);
				break;
			case 222:
				result = INpcLeisureInteractVerify.Verify(verifier, tablePos);
				break;
			case 223:
				result = IPostAkEventVerify.Verify(verifier, tablePos);
				break;
			case 224:
				result = IMoveSceneItemVerify.Verify(verifier, tablePos);
				break;
			case 225:
				result = IStopSceneItemMoveVerify.Verify(verifier, tablePos);
				break;
			case 226:
				result = IChangeLiftTargetVerify.Verify(verifier, tablePos);
				break;
			case 227:
				result = IHideByRangeInFlowVerify.Verify(verifier, tablePos);
				break;
			case 228:
				result = IShowAllHidedGroupInFlowVerify.Verify(verifier, tablePos);
				break;
			case 229:
				result = IOpenSimpleGameplayVerify.Verify(verifier, tablePos);
				break;
			case 230:
				result = IToggleRideFlyingCarUiGameplayVerify.Verify(verifier, tablePos);
				break;
			case 231:
				result = IChangePhantomVerify.Verify(verifier, tablePos);
				break;
			case 232:
				result = IRestorePhantomVerify.Verify(verifier, tablePos);
				break;
			case 233:
				result = ITakePlotPhotoVerify.Verify(verifier, tablePos);
				break;
			case 234:
				result = IChangeActorTalkerVerify.Verify(verifier, tablePos);
				break;
			case 235:
				result = ISwitchSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 236:
				result = ISwitchSubLevelsDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 237:
				result = IPreloadSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 238:
				result = ISwitchPermissionVerify.Verify(verifier, tablePos);
				break;
			case 239:
				result = ISwitchDataLayersVerify.Verify(verifier, tablePos);
				break;
			case 240:
				result = IActivateResetPointVerify.Verify(verifier, tablePos);
				break;
			case 241:
				result = ITeleportToLatestResetPointVerify.Verify(verifier, tablePos);
				break;
			case 242:
				result = ISetWeatherVerify.Verify(verifier, tablePos);
				break;
			case 243:
				result = ISetTimeLockStateVerify.Verify(verifier, tablePos);
				break;
			case 244:
				result = ISetWeatherLockStateVerify.Verify(verifier, tablePos);
				break;
			case 245:
				result = IClientSetSeasonStateVerify.Verify(verifier, tablePos);
				break;
			case 246:
				result = IAxisLockScreenConfigVerify.Verify(verifier, tablePos);
				break;
			case 247:
				result = IAdjustPlayerCameraVerify.Verify(verifier, tablePos);
				break;
			case 248:
				result = IRestorePlayerCameraAdjustmentVerify.Verify(verifier, tablePos);
				break;
			case 249:
				result = IAdjustPlayerCameraGravityVerify.Verify(verifier, tablePos);
				break;
			case 250:
				result = IEnterMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 251:
				result = IExitMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 252:
				result = IResetPlayerCameraFocusVerify.Verify(verifier, tablePos);
				break;
			case 253:
				result = IUsePhantomSkillVerify.Verify(verifier, tablePos);
				break;
			case 254:
				result = IChangePhantomFormationVerify.Verify(verifier, tablePos);
				break;
			case 255:
				result = IRestorePhantomFormationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
