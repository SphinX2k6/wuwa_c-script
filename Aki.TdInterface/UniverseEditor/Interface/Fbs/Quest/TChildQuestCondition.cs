using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200471C RID: 18204
	public enum TChildQuestCondition : byte
	{
		// Token: 0x0400C990 RID: 51600
		NONE,
		// Token: 0x0400C991 RID: 51601
		IAtomicProcess,
		// Token: 0x0400C992 RID: 51602
		IAwakeAndLoadEntityCondition,
		// Token: 0x0400C993 RID: 51603
		ICheckActivityStateCondition,
		// Token: 0x0400C994 RID: 51604
		ICheckClientConditionGroupQuestCondition,
		// Token: 0x0400C995 RID: 51605
		ICheckConditionGroupQuestCondition,
		// Token: 0x0400C996 RID: 51606
		ICheckEntityStateQuestCondition,
		// Token: 0x0400C997 RID: 51607
		ICheckLevelPlayQuestCondition,
		// Token: 0x0400C998 RID: 51608
		ICheckPlayerInputCondition,
		// Token: 0x0400C999 RID: 51609
		ICheckSpringFestivalGameplayCompleted,
		// Token: 0x0400C99A RID: 51610
		ICheckTargetBattleAttributeCondition,
		// Token: 0x0400C99B RID: 51611
		ICheckTrapDefenseEventCondition,
		// Token: 0x0400C99C RID: 51612
		ICheckUiGameQuestCondition,
		// Token: 0x0400C99D RID: 51613
		ICompareActorVar,
		// Token: 0x0400C99E RID: 51614
		ICompareVarConditionInChildQuest,
		// Token: 0x0400C99F RID: 51615
		ICrossSceneSyncKillMonster,
		// Token: 0x0400C9A0 RID: 51616
		IDetectCombatState2Condition,
		// Token: 0x0400C9A1 RID: 51617
		IDetectCombatStateCondition,
		// Token: 0x0400C9A2 RID: 51618
		IDoInteractQuestCondition,
		// Token: 0x0400C9A3 RID: 51619
		IEnterDungeonCondition,
		// Token: 0x0400C9A4 RID: 51620
		IFinishArcadeGameplay,
		// Token: 0x0400C9A5 RID: 51621
		IFinishBvbChallenge,
		// Token: 0x0400C9A6 RID: 51622
		IFinishDungeonQuestCondition,
		// Token: 0x0400C9A7 RID: 51623
		IFinishFlipperCondition,
		// Token: 0x0400C9A8 RID: 51624
		IFinishJellyfishReturnCondition,
		// Token: 0x0400C9A9 RID: 51625
		IFinishKuroSimpleCombatKillMonster,
		// Token: 0x0400C9AA RID: 51626
		IFinishKurotatoCondition,
		// Token: 0x0400C9AB RID: 51627
		IFinishRhythmSpaceshipCondition,
		// Token: 0x0400C9AC RID: 51628
		IFinishRoleTowerCondition,
		// Token: 0x0400C9AD RID: 51629
		IFinishRollBlock,
		// Token: 0x0400C9AE RID: 51630
		IFinishSurvivorsRougeCondition,
		// Token: 0x0400C9AF RID: 51631
		IFinishTetris,
		// Token: 0x0400C9B0 RID: 51632
		IFinishTrapDefenseCondition,
		// Token: 0x0400C9B1 RID: 51633
		IGetItemQuestCondition,
		// Token: 0x0400C9B2 RID: 51634
		IGetSkillQuestCondition,
		// Token: 0x0400C9B3 RID: 51635
		IGuideCondition,
		// Token: 0x0400C9B4 RID: 51636
		IHandInItemsCondition,
		// Token: 0x0400C9B5 RID: 51637
		IInformationViewCheckCondition,
		// Token: 0x0400C9B6 RID: 51638
		IKillChildQuestCondition,
		// Token: 0x0400C9B7 RID: 51639
		ILeaveDungeonCondition,
		// Token: 0x0400C9B8 RID: 51640
		IListenToEvent,
		// Token: 0x0400C9B9 RID: 51641
		IMonsterCreatorQuestCondition,
		// Token: 0x0400C9BA RID: 51642
		INewHandInItemsCondition,
		// Token: 0x0400C9BB RID: 51643
		IParallaxAlignQuestCondition,
		// Token: 0x0400C9BC RID: 51644
		IParkourQuestCondition,
		// Token: 0x0400C9BD RID: 51645
		IPlaybackShowTimelineQuestCondition,
		// Token: 0x0400C9BE RID: 51646
		IPlayFlowQuestCondition,
		// Token: 0x0400C9BF RID: 51647
		IProgramSpecialProcess,
		// Token: 0x0400C9C0 RID: 51648
		IReachAreaQuestCondition,
		// Token: 0x0400C9C1 RID: 51649
		IReadMailCondition,
		// Token: 0x0400C9C2 RID: 51650
		IReadPhoneMessageQuestCondition,
		// Token: 0x0400C9C3 RID: 51651
		IReceiveTelecomChildQuestCondition,
		// Token: 0x0400C9C4 RID: 51652
		IScheduleTimeCondition,
		// Token: 0x0400C9C5 RID: 51653
		IShowUiCondition,
		// Token: 0x0400C9C6 RID: 51654
		ITakePhoto2Condition,
		// Token: 0x0400C9C7 RID: 51655
		ITakePhotoCondition,
		// Token: 0x0400C9C8 RID: 51656
		ITimerQuestCondition,
		// Token: 0x0400C9C9 RID: 51657
		ITimeScaledPhotograph,
		// Token: 0x0400C9CA RID: 51658
		IUseItemCondition,
		// Token: 0x0400C9CB RID: 51659
		IUseSkillQuestCondition,
		// Token: 0x0400C9CC RID: 51660
		IUseWeatherSwitchCondition,
		// Token: 0x0400C9CD RID: 51661
		IVisionSystemQuestCondition,
		// Token: 0x0400C9CE RID: 51662
		IWaitBattleCondition,
		// Token: 0x0400C9CF RID: 51663
		IWaitTimeCondition,
		// Token: 0x0400C9D0 RID: 51664
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0400C9D1 RID: 51665
		IWalkingPatternCondition
	}
}
