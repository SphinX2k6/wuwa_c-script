using System;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.BehaviorTree
{
	// Token: 0x02006DD7 RID: 28119
	public enum EBTNode
	{
		// Token: 0x04023AA0 RID: 146080
		TsTaskLog,
		// Token: 0x04023AA1 RID: 146081
		TsTaskPatrol,
		// Token: 0x04023AA2 RID: 146082
		TsTaskUseSkillDesignated,
		// Token: 0x04023AA3 RID: 146083
		TsTaskBlackBoardSetString,
		// Token: 0x04023AA4 RID: 146084
		TsTaskPatrolWithEvents,
		// Token: 0x04023AA5 RID: 146085
		TsTaskBlackboardSetValues,
		// Token: 0x04023AA6 RID: 146086
		TsTaskPlayMontage,
		// Token: 0x04023AA7 RID: 146087
		TsTaskPlayWalkingOverlayMontage,
		// Token: 0x04023AA8 RID: 146088
		TsTaskPatrolStateReset,
		// Token: 0x04023AA9 RID: 146089
		TsTaskPlayBubble,
		// Token: 0x04023AAA RID: 146090
		TsTaskAddPlayBubble,
		// Token: 0x04023AAB RID: 146091
		TsTaskClearPlayBubble,
		// Token: 0x04023AAC RID: 146092
		TsTaskTurnToPosition,
		// Token: 0x04023AAD RID: 146093
		TsTaskTurnToEntity,
		// Token: 0x04023AAE RID: 146094
		TsTaskNpcLeisureInteract,
		// Token: 0x04023AAF RID: 146095
		TsTaskNpcSitOnChair,
		// Token: 0x04023AB0 RID: 146096
		TsTaskMoveToTarget,
		// Token: 0x04023AB1 RID: 146097
		TsTaskEnterPatrolState,
		// Token: 0x04023AB2 RID: 146098
		TsTaskWait,
		// Token: 0x04023AB3 RID: 146099
		TsTaskChangeNpcAbpState,
		// Token: 0x04023AB4 RID: 146100
		TsTaskEnableEntityLookAt,
		// Token: 0x04023AB5 RID: 146101
		TsTaskDisableEntityLookAt,
		// Token: 0x04023AB6 RID: 146102
		TsDecoratorCheck,
		// Token: 0x04023AB7 RID: 146103
		TsDecoratorActorsLocation,
		// Token: 0x04023AB8 RID: 146104
		TsDecoratorBlackboardActorsLocation,
		// Token: 0x04023AB9 RID: 146105
		TsDecoratorBlackboardStringCompare,
		// Token: 0x04023ABA RID: 146106
		TsDecoratorBlackboardIntCompare,
		// Token: 0x04023ABB RID: 146107
		TsDecoratorBlackboardValuesCompare,
		// Token: 0x04023ABC RID: 146108
		TsDecoratorWeatherStateCheck,
		// Token: 0x04023ABD RID: 146109
		TsDecoratorTimeSpanCheck,
		// Token: 0x04023ABE RID: 146110
		TsDecoratorTimePeriodCheck,
		// Token: 0x04023ABF RID: 146111
		TsDecoratorLevelPlayStateCheck,
		// Token: 0x04023AC0 RID: 146112
		TsDecoratorEntityStateCheck,
		// Token: 0x04023AC1 RID: 146113
		TsDecoratorQuestStateCheck,
		// Token: 0x04023AC2 RID: 146114
		TsDecoratorQuestStepStateCheck,
		// Token: 0x04023AC3 RID: 146115
		TsDecoratorVarCompare,
		// Token: 0x04023AC4 RID: 146116
		TsDecoratorDistanceCheck,
		// Token: 0x04023AC5 RID: 146117
		TsDecoratorDoOnce,
		// Token: 0x04023AC6 RID: 146118
		TsServiceAnimalPerception
	}
}
