using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F1F RID: 12063
[NullableContext(1)]
[Nullable(0)]
public class RequireAndLimits
{
	// Token: 0x0400C195 RID: 49557
	public ERequirementsCheckType CheckType;

	// Token: 0x0400C196 RID: 49558
	public IRequirement[] Requirements = new IRequirement[0];

	// Token: 0x0400C197 RID: 49559
	public EffectLimits Limits = new EffectLimits();
}
