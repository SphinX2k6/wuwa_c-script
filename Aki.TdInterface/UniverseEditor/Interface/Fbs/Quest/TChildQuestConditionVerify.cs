using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C2 RID: 17090
	public static class TChildQuestConditionVerify
	{
		// Token: 0x0601959E RID: 103838 RVA: 0x003A3160 File Offset: 0x003A1360
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAtomicProcessVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAwakeAndLoadEntityConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckActivityStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICheckClientConditionGroupQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICheckConditionGroupQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICheckEntityStateQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICheckLevelPlayQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICheckPlayerInputConditionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICheckSpringFestivalGameplayCompletedVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICheckTargetBattleAttributeConditionVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICheckTrapDefenseEventConditionVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ICheckUiGameQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ICompareActorVarVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ICompareVarConditionInChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ICrossSceneSyncKillMonsterVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IDetectCombatState2ConditionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IDetectCombatStateConditionVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IDoInteractQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IEnterDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IFinishArcadeGameplayVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IFinishBvbChallengeVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IFinishDungeonQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IFinishFlipperConditionVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IFinishJellyfishReturnConditionVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IFinishKuroSimpleCombatKillMonsterVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IFinishKurotatoConditionVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IFinishRhythmSpaceshipConditionVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IFinishRoleTowerConditionVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IFinishRollBlockVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IFinishSurvivorsRougeConditionVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IFinishTetrisVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IFinishTrapDefenseConditionVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = IGetItemQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IGetSkillQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IGuideConditionVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IHandInItemsConditionVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IInformationViewCheckConditionVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IKillChildQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = ILeaveDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IListenToEventVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IMonsterCreatorQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = INewHandInItemsConditionVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IParallaxAlignQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IParkourQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IPlaybackShowTimelineQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IPlayFlowQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IProgramSpecialProcessVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IReachAreaQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IReadMailConditionVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IReadPhoneMessageQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IReceiveTelecomChildQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IScheduleTimeConditionVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IShowUiConditionVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = ITakePhoto2ConditionVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = ITakePhotoConditionVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = ITimerQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = ITimeScaledPhotographVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = IUseItemConditionVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = IUseSkillQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = IUseWeatherSwitchConditionVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = IVisionSystemQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = IWaitBattleConditionVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = IWaitTimeConditionVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = IWaitUntilLevelSequenceReachMarkVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = IWalkingPatternConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
