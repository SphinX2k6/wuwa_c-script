using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F15 RID: 12053
[RequiredMember]
public class RequirementDamageSubType : IRequirement
{
	// Token: 0x170023A5 RID: 9125
	// (get) Token: 0x06019B5B RID: 105307 RVA: 0x006B1B57 File Offset: 0x006AFD57
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.DamageSubType;
		}
	}

	// Token: 0x06019B5C RID: 105308 RVA: 0x006B1B5B File Offset: 0x006AFD5B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageSubType()
	{
	}

	// Token: 0x0400C17C RID: 49532
	[RequiredMember]
	public ERequirementsIncludeType IncludeType;

	// Token: 0x0400C17D RID: 49533
	[Nullable(1)]
	[RequiredMember]
	public int[] DamageSubTypes;
}
