using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F19 RID: 12057
[RequiredMember]
public class RequirementCalculationType : IRequirement
{
	// Token: 0x170023A9 RID: 9129
	// (get) Token: 0x06019B63 RID: 105315 RVA: 0x006B1B87 File Offset: 0x006AFD87
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.CalculateType;
		}
	}

	// Token: 0x06019B64 RID: 105316 RVA: 0x006B1B8B File Offset: 0x006AFD8B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementCalculationType()
	{
	}

	// Token: 0x0400C189 RID: 49545
	[Nullable(1)]
	[RequiredMember]
	public ECalculationType[] CalculationTypes;
}
