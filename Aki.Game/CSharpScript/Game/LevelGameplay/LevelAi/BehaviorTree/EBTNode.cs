using System;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree
{
	// Token: 0x02005F56 RID: 24406
	public enum EBTNode
	{
		// Token: 0x0401ED42 RID: 126274
		TsTaskLog,
		// Token: 0x0401ED43 RID: 126275
		TsTaskPatrol,
		// Token: 0x0401ED44 RID: 126276
		TsTaskUseSkillDesignated,
		// Token: 0x0401ED45 RID: 126277
		TsTaskBlackBoardSetString,
		// Token: 0x0401ED46 RID: 126278
		TsTaskPatrolWithEvents,
		// Token: 0x0401ED47 RID: 126279
		TsTaskBlackboardSetValues,
		// Token: 0x0401ED48 RID: 126280
		TsTaskPlayMontage,
		// Token: 0x0401ED49 RID: 126281
		TsTaskPlayWalkingOverlayMontage,
		// Token: 0x0401ED4A RID: 126282
		TsTaskPatrolStateReset,
		// Token: 0x0401ED4B RID: 126283
		TsTaskPlayBubble,
		// Token: 0x0401ED4C RID: 126284
		TsTaskAddPlayBubble,
		// Token: 0x0401ED4D RID: 126285
		TsTaskClearPlayBubble,
		// Token: 0x0401ED4E RID: 126286
		TsTaskTurnToPosition,
		// Token: 0x0401ED4F RID: 126287
		TsTaskTurnToEntity,
		// Token: 0x0401ED50 RID: 126288
		TsTaskNpcLeisureInteract,
		// Token: 0x0401ED51 RID: 126289
		TsTaskNpcSitOnChair,
		// Token: 0x0401ED52 RID: 126290
		TsTaskMoveToTarget,
		// Token: 0x0401ED53 RID: 126291
		TsTaskEnterPatrolState,
		// Token: 0x0401ED54 RID: 126292
		TsTaskWait,
		// Token: 0x0401ED55 RID: 126293
		TsTaskChangeNpcAbpState,
		// Token: 0x0401ED56 RID: 126294
		TsTaskEnableEntityLookAt,
		// Token: 0x0401ED57 RID: 126295
		TsTaskDisableEntityLookAt,
		// Token: 0x0401ED58 RID: 126296
		TsDecoratorCheck,
		// Token: 0x0401ED59 RID: 126297
		TsDecoratorActorsLocation,
		// Token: 0x0401ED5A RID: 126298
		TsDecoratorBlackboardActorsLocation,
		// Token: 0x0401ED5B RID: 126299
		TsDecoratorBlackboardStringCompare,
		// Token: 0x0401ED5C RID: 126300
		TsDecoratorBlackboardIntCompare,
		// Token: 0x0401ED5D RID: 126301
		TsDecoratorBlackboardValuesCompare,
		// Token: 0x0401ED5E RID: 126302
		TsDecoratorWeatherStateCheck,
		// Token: 0x0401ED5F RID: 126303
		TsDecoratorTimeSpanCheck,
		// Token: 0x0401ED60 RID: 126304
		TsDecoratorTimePeriodCheck,
		// Token: 0x0401ED61 RID: 126305
		TsDecoratorLevelPlayStateCheck,
		// Token: 0x0401ED62 RID: 126306
		TsDecoratorEntityStateCheck,
		// Token: 0x0401ED63 RID: 126307
		TsDecoratorQuestStateCheck,
		// Token: 0x0401ED64 RID: 126308
		TsDecoratorQuestStepStateCheck,
		// Token: 0x0401ED65 RID: 126309
		TsDecoratorVarCompare,
		// Token: 0x0401ED66 RID: 126310
		TsDecoratorDistanceCheck,
		// Token: 0x0401ED67 RID: 126311
		TsDecoratorDoOnce,
		// Token: 0x0401ED68 RID: 126312
		TsServiceAnimalPerception
	}
}
