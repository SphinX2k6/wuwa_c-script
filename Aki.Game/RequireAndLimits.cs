using System;
using System.Runtime.CompilerServices;

// Token: 0x02002472 RID: 9330
[NullableContext(1)]
[Nullable(0)]
public class RequireAndLimits
{
	// Token: 0x0400C537 RID: 50487
	public ERequirementsCheckType CheckType;

	// Token: 0x0400C538 RID: 50488
	public IRequirement[] Requirements = new IRequirement[0];

	// Token: 0x0400C539 RID: 50489
	public EffectLimits Limits = new EffectLimits();
}
