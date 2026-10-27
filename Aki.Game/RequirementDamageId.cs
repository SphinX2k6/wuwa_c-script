using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F0D RID: 12045
[RequiredMember]
public class RequirementDamageId : IRequirement
{
	// Token: 0x1700239D RID: 9117
	// (get) Token: 0x06019B4B RID: 105291 RVA: 0x006B1AFA File Offset: 0x006AFCFA
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedDamageId;
		}
	}

	// Token: 0x06019B4C RID: 105292 RVA: 0x006B1AFE File Offset: 0x006AFCFE
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageId()
	{
	}

	// Token: 0x0400C172 RID: 49522
	[Nullable(1)]
	[RequiredMember]
	public long[] DamageIds;
}
