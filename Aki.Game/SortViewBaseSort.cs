using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D5F RID: 3423
[NullableContext(1)]
[Nullable(0)]
public class SortViewBaseSort
{
	// Token: 0x06008C95 RID: 35989 RVA: 0x002A903F File Offset: 0x002A723F
	public SortViewBaseSort(int ruleId, string ruleName)
	{
		this.RuleId = ruleId;
		this.RuleName = ruleName;
	}

	// Token: 0x0400545A RID: 21594
	public int RuleId;

	// Token: 0x0400545B RID: 21595
	public string RuleName;
}
