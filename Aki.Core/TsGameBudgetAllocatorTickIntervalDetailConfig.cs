using System;
using UnrealEngine;

// Token: 0x020000A6 RID: 166
public class TsGameBudgetAllocatorTickIntervalDetailConfig
{
	// Token: 0x060004EB RID: 1259 RVA: 0x0001B511 File Offset: 0x00019711
	public TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode globalMode, EGameBudgetAllocatorActorMode actorMode, uint maxInterval, uint tickReductionStartSize, uint tickReductionIntervalSize, float tickReductionStartScreenRatio = 0f, float tickReductionIntervalScreenRatio = 0f)
	{
		this.GlobalMode = globalMode;
		this.ActorMode = actorMode;
		this.MaxInterval = maxInterval;
		this.TickReductionStartSize = tickReductionStartSize;
		this.TickReductionIntervalSize = tickReductionIntervalSize;
		this.TickReductionStartScreenRatio = tickReductionStartScreenRatio;
		this.TickReductionIntervalScreenRatio = tickReductionIntervalScreenRatio;
	}

	// Token: 0x04000428 RID: 1064
	public readonly EGameBudgetAllocatorGlobalMode GlobalMode;

	// Token: 0x04000429 RID: 1065
	public readonly EGameBudgetAllocatorActorMode ActorMode;

	// Token: 0x0400042A RID: 1066
	public readonly uint MaxInterval;

	// Token: 0x0400042B RID: 1067
	public readonly uint TickReductionStartSize;

	// Token: 0x0400042C RID: 1068
	public readonly uint TickReductionIntervalSize;

	// Token: 0x0400042D RID: 1069
	public readonly float TickReductionStartScreenRatio;

	// Token: 0x0400042E RID: 1070
	public readonly float TickReductionIntervalScreenRatio;
}
