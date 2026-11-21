using System;
using System.Runtime.CompilerServices;

// Token: 0x0200246C RID: 9324
[RequiredMember]
public class RequirementCalculationType : IRequirement
{
	// Token: 0x1700246B RID: 9323
	// (get) Token: 0x0601746E RID: 95342 RVA: 0x006D7E9F File Offset: 0x006D609F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.CalculateType;
		}
	}

	// Token: 0x0601746F RID: 95343 RVA: 0x006D7EA3 File Offset: 0x006D60A3
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementCalculationType()
	{
	}

	// Token: 0x0400C52B RID: 50475
	[Nullable(1)]
	[RequiredMember]
	public ECalculationType[] CalculationTypes;
}
