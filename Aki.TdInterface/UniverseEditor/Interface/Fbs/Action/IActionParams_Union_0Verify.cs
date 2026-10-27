using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608B RID: 24715
	public static class IActionParams_Union_0Verify
	{
		// Token: 0x0602A192 RID: 172434 RVA: 0x005CD1AC File Offset: 0x005CB3AC
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
				result = ISetPlotModeVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IPlaySequenceDataVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IPlayCustomSequenceVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IPlayMovieVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IPlayEffectVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IPlayEffect2Verify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IPlayCommonEffectVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IPlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = ISwitchEffectStateVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IPlayDissolveEffectVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IPlayMpcEffectVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IRemoveEffectVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = IWaitVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = IMoveToPosAVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = ISetMoveSpeedVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = ISetPosAVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = IFaceToPosVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = ISpawnChildVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = ISimpleMoveVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = ISetNumberVarVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = ISyncVarToActorStateVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = IDoCalculateVerify.Verify(verifier, tablePos);
				break;
			case 67:
				result = ICallByConditionVerify.Verify(verifier, tablePos);
				break;
			case 68:
				result = ICallFunctionVerify.Verify(verifier, tablePos);
				break;
			case 69:
				result = IAddFlowInteractOptionVerify.Verify(verifier, tablePos);
				break;
			case 70:
				result = IRemoveFlowInteractOptionVerify.Verify(verifier, tablePos);
				break;
			case 71:
				result = IChangeInteractOptionTextVerify.Verify(verifier, tablePos);
				break;
			case 72:
				result = ISpawnEntityVerify.Verify(verifier, tablePos);
				break;
			case 73:
				result = IDestroyAllChildVerify.Verify(verifier, tablePos);
				break;
			case 74:
				result = IDestroyEntityVerify.Verify(verifier, tablePos);
				break;
			case 75:
				result = IPlayFlowVerify.Verify(verifier, tablePos);
				break;
			case 76:
				result = IBubbleDataVerify.Verify(verifier, tablePos);
				break;
			case 77:
				result = IPlayerLookAtVerify.Verify(verifier, tablePos);
				break;
			case 78:
				result = IEntityLookAtVerify.Verify(verifier, tablePos);
				break;
			case 79:
				result = ICharacterLookAtVerify.Verify(verifier, tablePos);
				break;
			case 80:
				result = IPlayerLookTowardsVerify.Verify(verifier, tablePos);
				break;
			case 81:
				result = IEntityTurnToVerify.Verify(verifier, tablePos);
				break;
			case 82:
				result = ICameraLookAtVerify.Verify(verifier, tablePos);
				break;
			case 83:
				result = IStopCameraLookAtVerify.Verify(verifier, tablePos);
				break;
			case 84:
				result = ISetVarVerify.Verify(verifier, tablePos);
				break;
			case 85:
				result = ISetActorVarVerify.Verify(verifier, tablePos);
				break;
			case 86:
				result = ICalculateVarVerify.Verify(verifier, tablePos);
				break;
			case 87:
				result = IRandomVarVerify.Verify(verifier, tablePos);
				break;
			case 88:
				result = IGuideTriggerVerify.Verify(verifier, tablePos);
				break;
			case 89:
				result = ICompleteGuideVerify.Verify(verifier, tablePos);
				break;
			case 90:
				result = IGetItemVerify.Verify(verifier, tablePos);
				break;
			case 91:
				result = IDestroyQuestItemVerify.Verify(verifier, tablePos);
				break;
			case 92:
				result = IAwakeEntityVerify.Verify(verifier, tablePos);
				break;
			case 93:
				result = ISetEntityVisibleVerify.Verify(verifier, tablePos);
				break;
			case 94:
				result = ISetEntityClientVisibleVerify.Verify(verifier, tablePos);
				break;
			case 95:
				result = ISetEntityClientVisibleSaveVerify.Verify(verifier, tablePos);
				break;
			case 96:
				result = ILockEntityVerify.Verify(verifier, tablePos);
				break;
			case 97:
				result = IUnlockEntityVerify.Verify(verifier, tablePos);
				break;
			case 98:
				result = ICompleteChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 99:
				result = IAcceptCurrentQuestVerify.Verify(verifier, tablePos);
				break;
			case 100:
				result = IFinishDoInteractVerify.Verify(verifier, tablePos);
				break;
			case 101:
				result = IAddBuffToEntityVerify.Verify(verifier, tablePos);
				break;
			case 102:
				result = IAddBuffToPlayerVerify.Verify(verifier, tablePos);
				break;
			case 103:
				result = IAddBuffToFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 104:
				result = IOpenSystemBoardVerify.Verify(verifier, tablePos);
				break;
			case 105:
				result = IOpenSystemFunctionVerify.Verify(verifier, tablePos);
				break;
			case 106:
				result = IChangeEntityStateVerify.Verify(verifier, tablePos);
				break;
			case 107:
				result = IChangeEntityStateDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 108:
				result = IChangeEntityStateBatchDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 109:
				result = IChangeEntityStateLoopVerify.Verify(verifier, tablePos);
				break;
			case 110:
				result = IChangeNpcPerformStateVerify.Verify(verifier, tablePos);
				break;
			case 111:
				result = ISetForceLockVerify.Verify(verifier, tablePos);
				break;
			case 112:
				result = ISetAreaStateVerify.Verify(verifier, tablePos);
				break;
			case 113:
				result = ISetWuYinQuStateVerify.Verify(verifier, tablePos);
				break;
			case 114:
				result = IRemoveBuffFromEntityVerify.Verify(verifier, tablePos);
				break;
			case 115:
				result = IRemoveBuffFromPlayerVerify.Verify(verifier, tablePos);
				break;
			case 116:
				result = ICollectVerify.Verify(verifier, tablePos);
				break;
			case 117:
				result = IDestroyVerify.Verify(verifier, tablePos);
				break;
			case 118:
				result = IDestroySelfVerify.Verify(verifier, tablePos);
				break;
			case 119:
				result = ISetPlayerMoveControlVerify.Verify(verifier, tablePos);
				break;
			case 120:
				result = IUnlockTeleportTriggerVerify.Verify(verifier, tablePos);
				break;
			case 121:
				result = IChangeTeamPositionVerify.Verify(verifier, tablePos);
				break;
			case 122:
				result = IClientChangeTeamPositionVerify.Verify(verifier, tablePos);
				break;
			case 123:
				result = IClaimLevelPlayRewardVerify.Verify(verifier, tablePos);
				break;
			case 124:
				result = IClaimDynamicEntityRewardVerify.Verify(verifier, tablePos);
				break;
			case 125:
				result = IClearFishingCabinInSaleItemsVerify.Verify(verifier, tablePos);
				break;
			case 126:
				result = IAcceptFishingEntrustVerify.Verify(verifier, tablePos);
				break;
			case 127:
				result = IDestroyFishingBoatVerify.Verify(verifier, tablePos);
				break;
			case 128:
				result = ITeleportDungeonVerify.Verify(verifier, tablePos);
				break;
			case 129:
				result = IStopUiScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 130:
				result = IClaimDungeonRewardVerify.Verify(verifier, tablePos);
				break;
			case 131:
				result = ISettlementDungeonVerify.Verify(verifier, tablePos);
				break;
			case 132:
				result = IExitDungeonVerify.Verify(verifier, tablePos);
				break;
			case 133:
				result = IUnlockDungeonEntryVerify.Verify(verifier, tablePos);
				break;
			case 134:
				result = IFinishDungeonVerify.Verify(verifier, tablePos);
				break;
			case 135:
				result = ISetReviveRegionVerify.Verify(verifier, tablePos);
				break;
			case 136:
				result = IPromptQuestChapterUIVerify.Verify(verifier, tablePos);
				break;
			case 137:
				result = IFireBulletVerify.Verify(verifier, tablePos);
				break;
			case 138:
				result = IFireBulletEffectVerify.Verify(verifier, tablePos);
				break;
			case 139:
				result = ISetPlayerPosVerify.Verify(verifier, tablePos);
				break;
			case 140:
				result = IClientSetPlayerPosVerify.Verify(verifier, tablePos);
				break;
			case 141:
				result = IClientPreEnableSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 142:
				result = IRogueGotoNextFloorVerify.Verify(verifier, tablePos);
				break;
			case 143:
				result = IRogueSelectRoomVerify.Verify(verifier, tablePos);
				break;
			case 144:
				result = IRogueActivatePortalVerify.Verify(verifier, tablePos);
				break;
			case 145:
				result = IRogueReceiveRewardVerify.Verify(verifier, tablePos);
				break;
			case 146:
				result = IChangeSelfEntityStateVerify.Verify(verifier, tablePos);
				break;
			case 147:
				result = IInterludeActionsVerify.Verify(verifier, tablePos);
				break;
			case 148:
				result = IAddBuffToTriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 149:
				result = IRemoveBuffToTriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 150:
				result = IDetectTriggerVerify.Verify(verifier, tablePos);
				break;
			case 151:
				result = IItemFoundationMatchVerify.Verify(verifier, tablePos);
				break;
			case 152:
				result = ISetBattleStateVerify.Verify(verifier, tablePos);
				break;
			case 153:
				result = IExecBattleActionVerify.Verify(verifier, tablePos);
				break;
			case 154:
				result = IExecClientMonsterNpcInteractVerify.Verify(verifier, tablePos);
				break;
			case 155:
				result = IExecClientBattleActionVerify.Verify(verifier, tablePos);
				break;
			case 156:
				result = IWaitBattleConditionVerify.Verify(verifier, tablePos);
				break;
			case 157:
				result = IEnableHostilityVerify.Verify(verifier, tablePos);
				break;
			case 158:
				result = IUnlockSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 159:
				result = IClientUnlockAchievementSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 160:
				result = IAddPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 161:
				result = IPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 162:
				result = IClearPlayBubbleVerify.Verify(verifier, tablePos);
				break;
			case 163:
				result = IMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 164:
				result = INewMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 165:
				result = IStopNewMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 166:
				result = ICharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 167:
				result = IPlayerMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 168:
				result = INpcMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 169:
				result = IToggleScanSplineEffectVerify.Verify(verifier, tablePos);
				break;
			case 170:
				result = IOpenTraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 171:
				result = ICloseTraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 172:
				result = ITraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 173:
				result = IEnableAIVerify.Verify(verifier, tablePos);
				break;
			case 174:
				result = IRunActionsVerify.Verify(verifier, tablePos);
				break;
			case 175:
				result = ICommonTipVerify.Verify(verifier, tablePos);
				break;
			case 176:
				result = ICommonTip2Verify.Verify(verifier, tablePos);
				break;
			case 177:
				result = IEndCommonTipVerify.Verify(verifier, tablePos);
				break;
			case 178:
				result = IEnableNearbyTrackingVerify.Verify(verifier, tablePos);
				break;
			case 179:
				result = ISendAiEventVerify.Verify(verifier, tablePos);
				break;
			case 180:
				result = IEnableLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 181:
				result = IServerForceEnableLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 182:
				result = ITeleportDungeonPosVerify.Verify(verifier, tablePos);
				break;
			case 183:
				result = IFadeInScreenVerify.Verify(verifier, tablePos);
				break;
			case 184:
				result = IFadeOutScreenVerify.Verify(verifier, tablePos);
				break;
			case 185:
				result = IStartFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 186:
				result = IEndFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 187:
				result = ICloseFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 188:
				result = IChangeFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 189:
				result = IBeginFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 190:
				result = ISetFlowTemplateVerify.Verify(verifier, tablePos);
				break;
			case 191:
				result = IHideTargetRangeVerify.Verify(verifier, tablePos);
				break;
			case 192:
				result = IShowTargetRangeVerify.Verify(verifier, tablePos);
				break;
			case 193:
				result = IHideSpecificEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 194:
				result = IShowSpecificEntitiesVerify.Verify(verifier, tablePos);
				break;
			case 195:
				result = IHideGroupVerify.Verify(verifier, tablePos);
				break;
			case 196:
				result = IShowHidedGroupVerify.Verify(verifier, tablePos);
				break;
			case 197:
				result = ISetSubScreenModeVerify.Verify(verifier, tablePos);
				break;
			case 198:
				result = IToggleDragActorPlayVerify.Verify(verifier, tablePos);
				break;
			case 199:
				result = IManualOccupationsVerify.Verify(verifier, tablePos);
				break;
			case 200:
				result = IForceOccupationsVerify.Verify(verifier, tablePos);
				break;
			case 201:
				result = IChangeFightTeamVerify.Verify(verifier, tablePos);
				break;
			case 202:
				result = IActiveRangeVerify.Verify(verifier, tablePos);
				break;
			case 203:
				result = IAddTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 204:
				result = IUpdateTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 205:
				result = IRestoreTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 206:
				result = IRemoveTrialCharacterVerify.Verify(verifier, tablePos);
				break;
			case 207:
				result = IAddGuestCharacterVerify.Verify(verifier, tablePos);
				break;
			case 208:
				result = IRemoveGuestCharacterVerify.Verify(verifier, tablePos);
				break;
			case 209:
				result = IDestroyQuestVerify.Verify(verifier, tablePos);
				break;
			case 210:
				result = ISetCameraAnimVerify.Verify(verifier, tablePos);
				break;
			case 211:
				result = IChangeTimerVerify.Verify(verifier, tablePos);
				break;
			case 212:
				result = IToggleTimerPauseStateVerify.Verify(verifier, tablePos);
				break;
			case 213:
				result = IRotatorEntityVerify.Verify(verifier, tablePos);
				break;
			case 214:
				result = IUnLimitPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 215:
				result = ILimitPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 216:
				result = IEnableSystemVerify.Verify(verifier, tablePos);
				break;
			case 217:
				result = ILeisureInteractVerify.Verify(verifier, tablePos);
				break;
			case 218:
				result = INpcLeisureInteractVerify.Verify(verifier, tablePos);
				break;
			case 219:
				result = IPostAkEventVerify.Verify(verifier, tablePos);
				break;
			case 220:
				result = IMoveSceneItemVerify.Verify(verifier, tablePos);
				break;
			case 221:
				result = IStopSceneItemMoveVerify.Verify(verifier, tablePos);
				break;
			case 222:
				result = IChangeLiftTargetVerify.Verify(verifier, tablePos);
				break;
			case 223:
				result = IHideByRangeInFlowVerify.Verify(verifier, tablePos);
				break;
			case 224:
				result = IShowAllHidedGroupInFlowVerify.Verify(verifier, tablePos);
				break;
			case 225:
				result = IOpenSimpleGameplayVerify.Verify(verifier, tablePos);
				break;
			case 226:
				result = ICloseSimpleGameplayVerify.Verify(verifier, tablePos);
				break;
			case 227:
				result = IChangePhantomVerify.Verify(verifier, tablePos);
				break;
			case 228:
				result = IRestorePhantomVerify.Verify(verifier, tablePos);
				break;
			case 229:
				result = ITakePlotPhotoVerify.Verify(verifier, tablePos);
				break;
			case 230:
				result = IChangeActorTalkerVerify.Verify(verifier, tablePos);
				break;
			case 231:
				result = ISwitchSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 232:
				result = ISwitchSubLevelsDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 233:
				result = IPreloadSubLevelsVerify.Verify(verifier, tablePos);
				break;
			case 234:
				result = ISwitchPermissionVerify.Verify(verifier, tablePos);
				break;
			case 235:
				result = ISwitchDataLayersVerify.Verify(verifier, tablePos);
				break;
			case 236:
				result = IActivateResetPointVerify.Verify(verifier, tablePos);
				break;
			case 237:
				result = ITeleportToLatestResetPointVerify.Verify(verifier, tablePos);
				break;
			case 238:
				result = ISetWeatherVerify.Verify(verifier, tablePos);
				break;
			case 239:
				result = ISetTimeLockStateVerify.Verify(verifier, tablePos);
				break;
			case 240:
				result = ISetWeatherLockStateVerify.Verify(verifier, tablePos);
				break;
			case 241:
				result = IClientSetSeasonStateVerify.Verify(verifier, tablePos);
				break;
			case 242:
				result = IAxisLockScreenConfigVerify.Verify(verifier, tablePos);
				break;
			case 243:
				result = IAdjustPlayerCameraVerify.Verify(verifier, tablePos);
				break;
			case 244:
				result = IRestorePlayerCameraAdjustmentVerify.Verify(verifier, tablePos);
				break;
			case 245:
				result = IAdjustPlayerCameraGravityVerify.Verify(verifier, tablePos);
				break;
			case 246:
				result = IEnterMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 247:
				result = IExitMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 248:
				result = IResetPlayerCameraFocusVerify.Verify(verifier, tablePos);
				break;
			case 249:
				result = IUsePhantomSkillVerify.Verify(verifier, tablePos);
				break;
			case 250:
				result = IChangePhantomFormationVerify.Verify(verifier, tablePos);
				break;
			case 251:
				result = IRestorePhantomFormationVerify.Verify(verifier, tablePos);
				break;
			case 252:
				result = IEnterOrbitalCameraVerify.Verify(verifier, tablePos);
				break;
			case 253:
				result = IExitOrbitalCameraVerify.Verify(verifier, tablePos);
				break;
			case 254:
				result = IEnableSplineMoveModelVerify.Verify(verifier, tablePos);
				break;
			case 255:
				result = IEnableActorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
