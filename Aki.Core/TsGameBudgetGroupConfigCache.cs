using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000A5 RID: 165
[NullableContext(1)]
[Nullable(0)]
public class TsGameBudgetGroupConfigCache : TsGameBudgetGroupConfig
{
	// Token: 0x060004EA RID: 1258 RVA: 0x0001B4DE File Offset: 0x000196DE
	public TsGameBudgetGroupConfigCache(FGameBudgetAllocatorGroupConfig ueGroupConfig) : base(ueGroupConfig.GroupName, ueGroupConfig.SignificanceGroup)
	{
		this.ueGroupConfig = ueGroupConfig;
		this.DefaultDisableActorTickDistance = ueGroupConfig.DisableActorTickDistance;
		this.DefaultDisableActorTickStrategy = ueGroupConfig.DisableActorTickStrategy;
	}

	// Token: 0x04000425 RID: 1061
	public uint DefaultDisableActorTickDistance;

	// Token: 0x04000426 RID: 1062
	public EDisableActorTickStrategy DefaultDisableActorTickStrategy;

	// Token: 0x04000427 RID: 1063
	public readonly FGameBudgetAllocatorGroupConfig ueGroupConfig;
}
