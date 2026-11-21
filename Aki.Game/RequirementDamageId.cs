using System;
using System.Runtime.CompilerServices;

// Token: 0x02002460 RID: 9312
[RequiredMember]
public class RequirementDamageId : IRequirement
{
	// Token: 0x1700245F RID: 9311
	// (get) Token: 0x06017456 RID: 95318 RVA: 0x006D7E12 File Offset: 0x006D6012
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedDamageId;
		}
	}

	// Token: 0x06017457 RID: 95319 RVA: 0x006D7E16 File Offset: 0x006D6016
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageId()
	{
	}

	// Token: 0x0400C514 RID: 50452
	[Nullable(1)]
	[RequiredMember]
	public long[] DamageIds;
}
