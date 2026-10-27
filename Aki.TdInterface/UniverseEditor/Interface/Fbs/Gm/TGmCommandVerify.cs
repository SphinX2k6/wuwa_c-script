using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046DA RID: 18138
	public static class TGmCommandVerify
	{
		// Token: 0x0601B9B0 RID: 113072 RVA: 0x003EA054 File Offset: 0x003E8254
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAcceptQuestVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActivateTeleportVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAddAllItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAddAllPhantomVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAddAllRoleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IAddItemVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IAddNewRoleVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBrokenRockHotFixVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICustomTextGmVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IEquipGraduatedWeaponToTeamVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IExecuteActionListVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IExitDungeonInGmVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IFinishCurrentLevelPlayNodeVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IFinishCurrentTrackQuestNodeVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IFinishCurTrackDungeonNodeVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IGetAllGraduatedPhantomVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IGetAllGraduatedWeaponVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IGmGotoRogueRoomInGmVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IGmRoguelikeStartInGmVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IGmSetLevelPlaySwitchForceVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IGmSetLevelPlayUpdateForceVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IGmTeleportToEntityVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IGoToNodeVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IOpenBackLoginViewVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IOpenDungeonEntranceVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IOpenFuncVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IPlayFlowForGmVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IRecordCombatOperationCaptureCheckpointVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IResetCurrentDungeonVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ISavePlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ISetAllRoleToGraduateVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ISetEquippedWeaponToGraduateVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ISetTimeVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = ISetUnopenedAreaPullbackVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = ISetVarVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IShieldGuideVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IShowTipsViewVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = ISkipToInstanceDungeonNodeVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = ISkipToLevelPlayNodeVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = ISkipToQuestNodeVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IStartCombatOperationCaptureVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IStartCombatOperationReplayVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IStopCombatOperationCaptureVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IStopCombatOperationReplayVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = ITeleportToCurDungeonTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = ITeleportToCurLevelPlayTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = ITeleportToCurQuestTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = ITeleportToEntityVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = ITeleportToLevelPlayCenterVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = ITeleportToPosVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = ITeleportToPosInWorldVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IUnfreezeInstanceLimitVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IUnlockAllExploreSkillVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IUnlockEntityForGmVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IUnlockQuestVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IUpdateSceneRolesVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
