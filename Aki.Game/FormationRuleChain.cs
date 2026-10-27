using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BBC RID: 7100
[NullableContext(1)]
[Nullable(0)]
public class FormationRuleChain
{
	// Token: 0x0600D3A4 RID: 54180 RVA: 0x0030A962 File Offset: 0x00308B62
	public FormationRuleChain(IReadOnlyList<Func<TRuleResult>> rules)
	{
		this.Rules = rules;
	}

	// Token: 0x0600D3A5 RID: 54181 RVA: 0x0030A97C File Offset: 0x00308B7C
	public EOpenViewBlockReason Run()
	{
		foreach (Func<TRuleResult> func in this.Rules)
		{
			TRuleResult truleResult = func();
			if (!truleResult.Pass)
			{
				return truleResult.Reason;
			}
		}
		return EOpenViewBlockReason.None;
	}

	// Token: 0x040060CC RID: 24780
	private readonly IReadOnlyList<Func<TRuleResult>> Rules = new List<Func<TRuleResult>>();
}
