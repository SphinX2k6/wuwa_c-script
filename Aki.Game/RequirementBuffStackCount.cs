using System;
using System.Runtime.CompilerServices;

// Token: 0x0200246A RID: 9322
[RequiredMember]
public class RequirementBuffStackCount : IRequirement
{
	// Token: 0x17002469 RID: 9321
	// (get) Token: 0x0601746A RID: 95338 RVA: 0x006D7E87 File Offset: 0x006D6087
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.BuffStackCount;
		}
	}

	// Token: 0x0601746B RID: 95339 RVA: 0x006D7E8B File Offset: 0x006D608B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBuffStackCount()
	{
	}

	// Token: 0x0400C522 RID: 50466
	[RequiredMember]
	public long BuffId;

	// Token: 0x0400C523 RID: 50467
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C524 RID: 50468
	[RequiredMember]
	public int MinStack;

	// Token: 0x0400C525 RID: 50469
	[RequiredMember]
	public int MaxStack;
}
