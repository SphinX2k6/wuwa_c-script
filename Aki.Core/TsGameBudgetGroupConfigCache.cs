using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000A7 RID: 167
[NullableContext(1)]
[Nullable(0)]
public class TsGameBudgetGroupConfigCache : TsGameBudgetGroupConfig
{
	// Token: 0x0600052B RID: 1323 RVA: 0x0001BBC6 File Offset: 0x00019DC6
	public TsGameBudgetGroupConfigCache(FGameBudgetAllocatorGroupConfig ueGroupConfig) : base(ueGroupConfig.GroupName, ueGroupConfig.SignificanceGroup)
	{
		this.ueGroupConfig = ueGroupConfig;
		this.DefaultDisableActorTickDistance = ueGroupConfig.DisableActorTickDistance;
		this.DefaultDisableActorTickStrategy = ueGroupConfig.DisableActorTickStrategy;
	}

	// Token: 0x04000433 RID: 1075
	public uint DefaultDisableActorTickDistance;

	// Token: 0x04000434 RID: 1076
	public EDisableActorTickStrategy DefaultDisableActorTickStrategy;

	// Token: 0x04000435 RID: 1077
	public readonly FGameBudgetAllocatorGroupConfig ueGroupConfig;
}
