using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004412 RID: 17426
	public enum IQuestCondition_Union : byte
	{
		// Token: 0x0400C458 RID: 50264
		NONE,
		// Token: 0x0400C459 RID: 50265
		IQuestCondition,
		// Token: 0x0400C45A RID: 50266
		IInformationViewCheckCondition,
		// Token: 0x0400C45B RID: 50267
		IUseItemCondition,
		// Token: 0x0400C45C RID: 50268
		IGetItemQuestCondition,
		// Token: 0x0400C45D RID: 50269
		ICheckEntityStateQuestCondition,
		// Token: 0x0400C45E RID: 50270
		ICheckLevelPlayQuestCondition,
		// Token: 0x0400C45F RID: 50271
		ICheckUiGameQuestCondition,
		// Token: 0x0400C460 RID: 50272
		IReadPhoneMessageQuestCondition,
		// Token: 0x0400C461 RID: 50273
		IUseSkillQuestCondition,
		// Token: 0x0400C462 RID: 50274
		IGetSkillQuestCondition,
		// Token: 0x0400C463 RID: 50275
		IPlayFlowQuestCondition,
		// Token: 0x0400C464 RID: 50276
		IDoInteractQuestCondition,
		// Token: 0x0400C465 RID: 50277
		IReachAreaQuestCondition,
		// Token: 0x0400C466 RID: 50278
		IKillChildQuestCondition,
		// Token: 0x0400C467 RID: 50279
		IDetectCombatStateCondition,
		// Token: 0x0400C468 RID: 50280
		IDetectCombatState2Condition,
		// Token: 0x0400C469 RID: 50281
		IHandInItemsCondition,
		// Token: 0x0400C46A RID: 50282
		INewHandInItemsCondition,
		// Token: 0x0400C46B RID: 50283
		IFinishDungeonQuestCondition,
		// Token: 0x0400C46C RID: 50284
		IWaitTimeCondition,
		// Token: 0x0400C46D RID: 50285
		IScheduleTimeCondition,
		// Token: 0x0400C46E RID: 50286
		IReadMailCondition,
		// Token: 0x0400C46F RID: 50287
		IGuideCondition,
		// Token: 0x0400C470 RID: 50288
		IEnterDungeonCondition,
		// Token: 0x0400C471 RID: 50289
		ILeaveDungeonCondition,
		// Token: 0x0400C472 RID: 50290
		ICheckTargetBattleAttributeCondition,
		// Token: 0x0400C473 RID: 50291
		IWaitBattleCondition,
		// Token: 0x0400C474 RID: 50292
		ICompareVarConditionInChildQuest,
		// Token: 0x0400C475 RID: 50293
		ICompareActorVar,
		// Token: 0x0400C476 RID: 50294
		IReceiveTelecomChildQuestCondition,
		// Token: 0x0400C477 RID: 50295
		IShowUiCondition,
		// Token: 0x0400C478 RID: 50296
		ITakePhotoCondition,
		// Token: 0x0400C479 RID: 50297
		ITakePhoto2Condition,
		// Token: 0x0400C47A RID: 50298
		IVisionSystemQuestCondition,
		// Token: 0x0400C47B RID: 50299
		IParallaxAlignQuestCondition,
		// Token: 0x0400C47C RID: 50300
		ICheckConditionGroupQuestCondition,
		// Token: 0x0400C47D RID: 50301
		ICheckClientConditionGroupQuestCondition,
		// Token: 0x0400C47E RID: 50302
		ICheckActivityStateCondition,
		// Token: 0x0400C47F RID: 50303
		ICheckPlayerInputCondition,
		// Token: 0x0400C480 RID: 50304
		IAwakeAndLoadEntityCondition,
		// Token: 0x0400C481 RID: 50305
		IWalkingPatternCondition,
		// Token: 0x0400C482 RID: 50306
		IFinishBvbChallenge,
		// Token: 0x0400C483 RID: 50307
		IProgramSpecialProcess,
		// Token: 0x0400C484 RID: 50308
		IPlaybackShowTimelineQuestCondition,
		// Token: 0x0400C485 RID: 50309
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0400C486 RID: 50310
		IFinishTrapDefenseCondition,
		// Token: 0x0400C487 RID: 50311
		ICheckTrapDefenseEventCondition,
		// Token: 0x0400C488 RID: 50312
		IFinishSurvivorsRougeCondition,
		// Token: 0x0400C489 RID: 50313
		IFinishKurotatoCondition,
		// Token: 0x0400C48A RID: 50314
		IFinishRoleTowerCondition,
		// Token: 0x0400C48B RID: 50315
		IFinishRhythmSpaceshipCondition,
		// Token: 0x0400C48C RID: 50316
		IFinishFlipperCondition,
		// Token: 0x0400C48D RID: 50317
		ITimeScaledPhotograph,
		// Token: 0x0400C48E RID: 50318
		IFinishRollBlock,
		// Token: 0x0400C48F RID: 50319
		IAtomicProcess,
		// Token: 0x0400C490 RID: 50320
		IUseWeatherSwitchCondition,
		// Token: 0x0400C491 RID: 50321
		ICheckSpringFestivalGameplayCompleted,
		// Token: 0x0400C492 RID: 50322
		IListenToEvent,
		// Token: 0x0400C493 RID: 50323
		IParkourQuestCondition,
		// Token: 0x0400C494 RID: 50324
		ITimerQuestCondition,
		// Token: 0x0400C495 RID: 50325
		IMonsterCreatorQuestCondition,
		// Token: 0x0400C496 RID: 50326
		IFinishTetris,
		// Token: 0x0400C497 RID: 50327
		IFinishArcadeGameplay,
		// Token: 0x0400C498 RID: 50328
		IFinishKuroSimpleCombatKillMonster,
		// Token: 0x0400C499 RID: 50329
		ICrossSceneSyncKillMonster,
		// Token: 0x0400C49A RID: 50330
		IFinishJellyfishReturnCondition
	}
}
