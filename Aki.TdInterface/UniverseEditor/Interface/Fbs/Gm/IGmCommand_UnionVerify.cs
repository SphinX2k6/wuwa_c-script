using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465F RID: 18015
	public static class IGmCommand_UnionVerify
	{
		// Token: 0x0601B53A RID: 111930 RVA: 0x003E2B34 File Offset: 0x003E0D34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGmCommandVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISkipToLevelPlayNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFinishCurrentLevelPlayNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITeleportToCurLevelPlayTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IGmSetLevelPlaySwitchForceVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IGmSetLevelPlayUpdateForceVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITeleportToLevelPlayCenterVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ISkipToQuestNodeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IFinishCurrentTrackQuestNodeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITeleportToCurQuestTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IAcceptQuestVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IUnlockQuestVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IPlayFlowForGmVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ISkipToInstanceDungeonNodeVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IFinishCurTrackDungeonNodeVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ITeleportToCurDungeonTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IResetCurrentDungeonVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IExitDungeonInGmVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IGmRoguelikeStartInGmVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IGmGotoRogueRoomInGmVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IUnlockEntityForGmVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = ITeleportToEntityVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IGmTeleportToEntityVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IOpenDungeonEntranceVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IShowTipsViewVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IShieldGuideVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IOpenFuncVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ISetTimeVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IUnlockAllExploreSkillVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IActivateTeleportVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ISetUnopenedAreaPullbackVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ITeleportToPosVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ITeleportToPosInWorldVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IUnfreezeInstanceLimitVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IUpdateSceneRolesVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IAddAllRoleVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IAddNewRoleVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = ISetAllRoleToGraduateVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IAddAllItemVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IAddItemVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IAddAllPhantomVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IGetAllGraduatedPhantomVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IGetAllGraduatedWeaponVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = ISetEquippedWeaponToGraduateVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IEquipGraduatedWeaponToTeamVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IExecuteActionListVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IOpenBackLoginViewVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = ISavePlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IBrokenRockHotFixVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = ISetVarVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IGoToNodeVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = ICustomTextGmVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IStartCombatOperationCaptureVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IStopCombatOperationCaptureVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IRecordCombatOperationCaptureCheckpointVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IStartCombatOperationReplayVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = IStopCombatOperationReplayVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
