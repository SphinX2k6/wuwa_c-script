using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000A4 RID: 164
public class TsGameBudgetGroupConfig
{
	// Token: 0x060004E8 RID: 1256 RVA: 0x0001B4A8 File Offset: 0x000196A8
	public TsGameBudgetGroupConfig(FName groupName, ESignificanceGroup significanceGroup)
	{
		this.GroupName = groupName;
		this.SignificanceGroup = significanceGroup;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0001B4BE File Offset: 0x000196BE
	[NullableContext(1)]
	public TsGameBudgetGroupConfig(TsGameBudgetGroupConfigCache ConfigCache)
	{
		this.GroupName = ConfigCache.GroupName;
		this.SignificanceGroup = ConfigCache.SignificanceGroup;
	}

	// Token: 0x04000423 RID: 1059
	public readonly FName GroupName;

	// Token: 0x04000424 RID: 1060
	public readonly ESignificanceGroup SignificanceGroup;
}
