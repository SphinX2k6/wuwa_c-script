using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200107B RID: 4219
[NullableContext(1)]
[Nullable(0)]
public class FormationRuleChain
{
	// Token: 0x0600A7B6 RID: 42934 RVA: 0x00315A56 File Offset: 0x00313C56
	public FormationRuleChain(IReadOnlyList<Func<TRuleResult>> rules)
	{
		this.Rules = rules;
	}

	// Token: 0x0600A7B7 RID: 42935 RVA: 0x00315A70 File Offset: 0x00313C70
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

	// Token: 0x0400619B RID: 24987
	private readonly IReadOnlyList<Func<TRuleResult>> Rules = new List<Func<TRuleResult>>();
}
