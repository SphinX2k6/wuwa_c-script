using System;
using System.Runtime.CompilerServices;

// Token: 0x020018A6 RID: 6310
[NullableContext(1)]
[Nullable(0)]
public class SortViewBaseSort
{
	// Token: 0x0600B8AC RID: 47276 RVA: 0x0029E91F File Offset: 0x0029CB1F
	public SortViewBaseSort(int ruleId, string ruleName)
	{
		this.RuleId = ruleId;
		this.RuleName = ruleName;
	}

	// Token: 0x040053AF RID: 21423
	public int RuleId;

	// Token: 0x040053B0 RID: 21424
	public string RuleName;
}
