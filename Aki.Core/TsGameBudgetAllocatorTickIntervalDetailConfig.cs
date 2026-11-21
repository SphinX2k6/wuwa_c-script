using System;
using UnrealEngine;

// Token: 0x020000A8 RID: 168
public class TsGameBudgetAllocatorTickIntervalDetailConfig
{
	// Token: 0x0600052C RID: 1324 RVA: 0x0001BBF9 File Offset: 0x00019DF9
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

	// Token: 0x04000436 RID: 1078
	public readonly EGameBudgetAllocatorGlobalMode GlobalMode;

	// Token: 0x04000437 RID: 1079
	public readonly EGameBudgetAllocatorActorMode ActorMode;

	// Token: 0x04000438 RID: 1080
	public readonly uint MaxInterval;

	// Token: 0x04000439 RID: 1081
	public readonly uint TickReductionStartSize;

	// Token: 0x0400043A RID: 1082
	public readonly uint TickReductionIntervalSize;

	// Token: 0x0400043B RID: 1083
	public readonly float TickReductionStartScreenRatio;

	// Token: 0x0400043C RID: 1084
	public readonly float TickReductionIntervalScreenRatio;
}
