using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000A6 RID: 166
public class TsGameBudgetGroupConfig
{
	// Token: 0x06000529 RID: 1321 RVA: 0x0001BB90 File Offset: 0x00019D90
	public TsGameBudgetGroupConfig(FName groupName, ESignificanceGroup significanceGroup)
	{
		this.GroupName = groupName;
		this.SignificanceGroup = significanceGroup;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0001BBA6 File Offset: 0x00019DA6
	[NullableContext(1)]
	public TsGameBudgetGroupConfig(TsGameBudgetGroupConfigCache ConfigCache)
	{
		this.GroupName = ConfigCache.GroupName;
		this.SignificanceGroup = ConfigCache.SignificanceGroup;
	}

	// Token: 0x04000431 RID: 1073
	public readonly FName GroupName;

	// Token: 0x04000432 RID: 1074
	public readonly ESignificanceGroup SignificanceGroup;
}
