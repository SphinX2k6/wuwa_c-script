using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C0 RID: 17088
	public enum TChildQuestCondition : byte
	{
		// Token: 0x0400BF83 RID: 49027
		NONE,
		// Token: 0x0400BF84 RID: 49028
		IAtomicProcess,
		// Token: 0x0400BF85 RID: 49029
		IAwakeAndLoadEntityCondition,
		// Token: 0x0400BF86 RID: 49030
		ICheckActivityStateCondition,
		// Token: 0x0400BF87 RID: 49031
		ICheckClientConditionGroupQuestCondition,
		// Token: 0x0400BF88 RID: 49032
		ICheckConditionGroupQuestCondition,
		// Token: 0x0400BF89 RID: 49033
		ICheckEntityStateQuestCondition,
		// Token: 0x0400BF8A RID: 49034
		ICheckLevelPlayQuestCondition,
		// Token: 0x0400BF8B RID: 49035
		ICheckPlayerInputCondition,
		// Token: 0x0400BF8C RID: 49036
		ICheckSpringFestivalGameplayCompleted,
		// Token: 0x0400BF8D RID: 49037
		ICheckTargetBattleAttributeCondition,
		// Token: 0x0400BF8E RID: 49038
		ICheckTrapDefenseEventCondition,
		// Token: 0x0400BF8F RID: 49039
		ICheckUiGameQuestCondition,
		// Token: 0x0400BF90 RID: 49040
		ICompareActorVar,
		// Token: 0x0400BF91 RID: 49041
		ICompareVarConditionInChildQuest,
		// Token: 0x0400BF92 RID: 49042
		ICrossSceneSyncKillMonster,
		// Token: 0x0400BF93 RID: 49043
		IDetectCombatState2Condition,
		// Token: 0x0400BF94 RID: 49044
		IDetectCombatStateCondition,
		// Token: 0x0400BF95 RID: 49045
		IDoInteractQuestCondition,
		// Token: 0x0400BF96 RID: 49046
		IEnterDungeonCondition,
		// Token: 0x0400BF97 RID: 49047
		IFinishArcadeGameplay,
		// Token: 0x0400BF98 RID: 49048
		IFinishBvbChallenge,
		// Token: 0x0400BF99 RID: 49049
		IFinishDungeonQuestCondition,
		// Token: 0x0400BF9A RID: 49050
		IFinishFlipperCondition,
		// Token: 0x0400BF9B RID: 49051
		IFinishJellyfishReturnCondition,
		// Token: 0x0400BF9C RID: 49052
		IFinishKuroSimpleCombatKillMonster,
		// Token: 0x0400BF9D RID: 49053
		IFinishKurotatoCondition,
		// Token: 0x0400BF9E RID: 49054
		IFinishRhythmSpaceshipCondition,
		// Token: 0x0400BF9F RID: 49055
		IFinishRoleTowerCondition,
		// Token: 0x0400BFA0 RID: 49056
		IFinishRollBlock,
		// Token: 0x0400BFA1 RID: 49057
		IFinishSurvivorsRougeCondition,
		// Token: 0x0400BFA2 RID: 49058
		IFinishTetris,
		// Token: 0x0400BFA3 RID: 49059
		IFinishTrapDefenseCondition,
		// Token: 0x0400BFA4 RID: 49060
		IGetItemQuestCondition,
		// Token: 0x0400BFA5 RID: 49061
		IGetSkillQuestCondition,
		// Token: 0x0400BFA6 RID: 49062
		IGuideCondition,
		// Token: 0x0400BFA7 RID: 49063
		IHandInItemsCondition,
		// Token: 0x0400BFA8 RID: 49064
		IInformationViewCheckCondition,
		// Token: 0x0400BFA9 RID: 49065
		IKillChildQuestCondition,
		// Token: 0x0400BFAA RID: 49066
		ILeaveDungeonCondition,
		// Token: 0x0400BFAB RID: 49067
		IListenToEvent,
		// Token: 0x0400BFAC RID: 49068
		IMonsterCreatorQuestCondition,
		// Token: 0x0400BFAD RID: 49069
		INewHandInItemsCondition,
		// Token: 0x0400BFAE RID: 49070
		IParallaxAlignQuestCondition,
		// Token: 0x0400BFAF RID: 49071
		IParkourQuestCondition,
		// Token: 0x0400BFB0 RID: 49072
		IPlaybackShowTimelineQuestCondition,
		// Token: 0x0400BFB1 RID: 49073
		IPlayFlowQuestCondition,
		// Token: 0x0400BFB2 RID: 49074
		IProgramSpecialProcess,
		// Token: 0x0400BFB3 RID: 49075
		IReachAreaQuestCondition,
		// Token: 0x0400BFB4 RID: 49076
		IReadMailCondition,
		// Token: 0x0400BFB5 RID: 49077
		IReadPhoneMessageQuestCondition,
		// Token: 0x0400BFB6 RID: 49078
		IReceiveTelecomChildQuestCondition,
		// Token: 0x0400BFB7 RID: 49079
		IScheduleTimeCondition,
		// Token: 0x0400BFB8 RID: 49080
		IShowUiCondition,
		// Token: 0x0400BFB9 RID: 49081
		ITakePhoto2Condition,
		// Token: 0x0400BFBA RID: 49082
		ITakePhotoCondition,
		// Token: 0x0400BFBB RID: 49083
		ITimerQuestCondition,
		// Token: 0x0400BFBC RID: 49084
		ITimeScaledPhotograph,
		// Token: 0x0400BFBD RID: 49085
		IUseItemCondition,
		// Token: 0x0400BFBE RID: 49086
		IUseSkillQuestCondition,
		// Token: 0x0400BFBF RID: 49087
		IUseWeatherSwitchCondition,
		// Token: 0x0400BFC0 RID: 49088
		IVisionSystemQuestCondition,
		// Token: 0x0400BFC1 RID: 49089
		IWaitBattleCondition,
		// Token: 0x0400BFC2 RID: 49090
		IWaitTimeCondition,
		// Token: 0x0400BFC3 RID: 49091
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0400BFC4 RID: 49092
		IWalkingPatternCondition
	}
}
