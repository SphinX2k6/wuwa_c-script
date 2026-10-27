using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD3 RID: 16339
	public static class IQuestCondition_UnionVerify
	{
		// Token: 0x06017796 RID: 96150 RVA: 0x003623EC File Offset: 0x003605EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInformationViewCheckConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUseItemConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGetItemQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICheckEntityStateQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICheckLevelPlayQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICheckUiGameQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IReadPhoneMessageQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IUseSkillQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IGetSkillQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IPlayFlowQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IDoInteractQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IReachAreaQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IKillChildQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IDetectCombatStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IDetectCombatState2ConditionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IHandInItemsConditionVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = INewHandInItemsConditionVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IFinishDungeonQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IWaitTimeConditionVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IScheduleTimeConditionVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IReadMailConditionVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IGuideConditionVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IEnterDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ILeaveDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = ICheckTargetBattleAttributeConditionVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IWaitBattleConditionVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ICompareVarConditionInChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = ICompareActorVarVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IReceiveTelecomChildQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IShowUiConditionVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ITakePhotoConditionVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ITakePhoto2ConditionVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IVisionSystemQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IParallaxAlignQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = ICheckConditionGroupQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = ICheckClientConditionGroupQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = ICheckActivityStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = ICheckPlayerInputConditionVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IAwakeAndLoadEntityConditionVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IWalkingPatternConditionVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IFinishBvbChallengeVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IProgramSpecialProcessVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IPlaybackShowTimelineQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IWaitUntilLevelSequenceReachMarkVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IFinishTrapDefenseConditionVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = ICheckTrapDefenseEventConditionVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IFinishSurvivorsRougeConditionVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IFinishKurotatoConditionVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IFinishRoleTowerConditionVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IFinishRhythmSpaceshipConditionVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IFinishFlipperConditionVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = ITimeScaledPhotographVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IFinishRollBlockVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IAtomicProcessVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IUseWeatherSwitchConditionVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = ICheckSpringFestivalGameplayCompletedVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = IListenToEventVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = IParkourQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = ITimerQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = IMonsterCreatorQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = IFinishTetrisVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = IFinishArcadeGameplayVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = IFinishKuroSimpleCombatKillMonsterVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = ICrossSceneSyncKillMonsterVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = IFinishJellyfishReturnConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
