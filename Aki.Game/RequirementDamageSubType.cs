using System;
using System.Runtime.CompilerServices;

// Token: 0x02002468 RID: 9320
[RequiredMember]
public class RequirementDamageSubType : IRequirement
{
	// Token: 0x17002467 RID: 9319
	// (get) Token: 0x06017466 RID: 95334 RVA: 0x006D7E6F File Offset: 0x006D606F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.DamageSubType;
		}
	}

	// Token: 0x06017467 RID: 95335 RVA: 0x006D7E73 File Offset: 0x006D6073
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageSubType()
	{
	}

	// Token: 0x0400C51E RID: 50462
	[RequiredMember]
	public ERequirementsIncludeType IncludeType;

	// Token: 0x0400C51F RID: 50463
	[Nullable(1)]
	[RequiredMember]
	public int[] DamageSubTypes;
}
