using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD1 RID: 16337
	public enum IQuestCondition_Union : byte
	{
		// Token: 0x0400BA72 RID: 47730
		NONE,
		// Token: 0x0400BA73 RID: 47731
		IQuestCondition,
		// Token: 0x0400BA74 RID: 47732
		IInformationViewCheckCondition,
		// Token: 0x0400BA75 RID: 47733
		IUseItemCondition,
		// Token: 0x0400BA76 RID: 47734
		IGetItemQuestCondition,
		// Token: 0x0400BA77 RID: 47735
		ICheckEntityStateQuestCondition,
		// Token: 0x0400BA78 RID: 47736
		ICheckLevelPlayQuestCondition,
		// Token: 0x0400BA79 RID: 47737
		ICheckUiGameQuestCondition,
		// Token: 0x0400BA7A RID: 47738
		IReadPhoneMessageQuestCondition,
		// Token: 0x0400BA7B RID: 47739
		IUseSkillQuestCondition,
		// Token: 0x0400BA7C RID: 47740
		IGetSkillQuestCondition,
		// Token: 0x0400BA7D RID: 47741
		IPlayFlowQuestCondition,
		// Token: 0x0400BA7E RID: 47742
		IDoInteractQuestCondition,
		// Token: 0x0400BA7F RID: 47743
		IReachAreaQuestCondition,
		// Token: 0x0400BA80 RID: 47744
		IKillChildQuestCondition,
		// Token: 0x0400BA81 RID: 47745
		IDetectCombatStateCondition,
		// Token: 0x0400BA82 RID: 47746
		IDetectCombatState2Condition,
		// Token: 0x0400BA83 RID: 47747
		IHandInItemsCondition,
		// Token: 0x0400BA84 RID: 47748
		INewHandInItemsCondition,
		// Token: 0x0400BA85 RID: 47749
		IFinishDungeonQuestCondition,
		// Token: 0x0400BA86 RID: 47750
		IWaitTimeCondition,
		// Token: 0x0400BA87 RID: 47751
		IScheduleTimeCondition,
		// Token: 0x0400BA88 RID: 47752
		IReadMailCondition,
		// Token: 0x0400BA89 RID: 47753
		IGuideCondition,
		// Token: 0x0400BA8A RID: 47754
		IEnterDungeonCondition,
		// Token: 0x0400BA8B RID: 47755
		ILeaveDungeonCondition,
		// Token: 0x0400BA8C RID: 47756
		ICheckTargetBattleAttributeCondition,
		// Token: 0x0400BA8D RID: 47757
		IWaitBattleCondition,
		// Token: 0x0400BA8E RID: 47758
		ICompareVarConditionInChildQuest,
		// Token: 0x0400BA8F RID: 47759
		ICompareActorVar,
		// Token: 0x0400BA90 RID: 47760
		IReceiveTelecomChildQuestCondition,
		// Token: 0x0400BA91 RID: 47761
		IShowUiCondition,
		// Token: 0x0400BA92 RID: 47762
		ITakePhotoCondition,
		// Token: 0x0400BA93 RID: 47763
		ITakePhoto2Condition,
		// Token: 0x0400BA94 RID: 47764
		IVisionSystemQuestCondition,
		// Token: 0x0400BA95 RID: 47765
		IParallaxAlignQuestCondition,
		// Token: 0x0400BA96 RID: 47766
		ICheckConditionGroupQuestCondition,
		// Token: 0x0400BA97 RID: 47767
		ICheckClientConditionGroupQuestCondition,
		// Token: 0x0400BA98 RID: 47768
		ICheckActivityStateCondition,
		// Token: 0x0400BA99 RID: 47769
		ICheckPlayerInputCondition,
		// Token: 0x0400BA9A RID: 47770
		IAwakeAndLoadEntityCondition,
		// Token: 0x0400BA9B RID: 47771
		IWalkingPatternCondition,
		// Token: 0x0400BA9C RID: 47772
		IFinishBvbChallenge,
		// Token: 0x0400BA9D RID: 47773
		IProgramSpecialProcess,
		// Token: 0x0400BA9E RID: 47774
		IPlaybackShowTimelineQuestCondition,
		// Token: 0x0400BA9F RID: 47775
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0400BAA0 RID: 47776
		IFinishTrapDefenseCondition,
		// Token: 0x0400BAA1 RID: 47777
		ICheckTrapDefenseEventCondition,
		// Token: 0x0400BAA2 RID: 47778
		IFinishSurvivorsRougeCondition,
		// Token: 0x0400BAA3 RID: 47779
		IFinishKurotatoCondition,
		// Token: 0x0400BAA4 RID: 47780
		IFinishRoleTowerCondition,
		// Token: 0x0400BAA5 RID: 47781
		IFinishRhythmSpaceshipCondition,
		// Token: 0x0400BAA6 RID: 47782
		IFinishFlipperCondition,
		// Token: 0x0400BAA7 RID: 47783
		ITimeScaledPhotograph,
		// Token: 0x0400BAA8 RID: 47784
		IFinishRollBlock,
		// Token: 0x0400BAA9 RID: 47785
		IAtomicProcess,
		// Token: 0x0400BAAA RID: 47786
		IUseWeatherSwitchCondition,
		// Token: 0x0400BAAB RID: 47787
		ICheckSpringFestivalGameplayCompleted,
		// Token: 0x0400BAAC RID: 47788
		IListenToEvent,
		// Token: 0x0400BAAD RID: 47789
		IParkourQuestCondition,
		// Token: 0x0400BAAE RID: 47790
		ITimerQuestCondition,
		// Token: 0x0400BAAF RID: 47791
		IMonsterCreatorQuestCondition,
		// Token: 0x0400BAB0 RID: 47792
		IFinishTetris,
		// Token: 0x0400BAB1 RID: 47793
		IFinishArcadeGameplay,
		// Token: 0x0400BAB2 RID: 47794
		IFinishKuroSimpleCombatKillMonster,
		// Token: 0x0400BAB3 RID: 47795
		ICrossSceneSyncKillMonster,
		// Token: 0x0400BAB4 RID: 47796
		IFinishJellyfishReturnCondition
	}
}
