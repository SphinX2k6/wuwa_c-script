using System;
using System.Runtime.CompilerServices;

// Token: 0x02002466 RID: 9318
[RequiredMember]
public class RequirementBulletTag : IRequirement
{
	// Token: 0x17002465 RID: 9317
	// (get) Token: 0x06017462 RID: 95330 RVA: 0x006D7E57 File Offset: 0x006D6057
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedBulletTag;
		}
	}

	// Token: 0x06017463 RID: 95331 RVA: 0x006D7E5B File Offset: 0x006D605B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBulletTag()
	{
	}

	// Token: 0x0400C51C RID: 50460
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireBulletTags;
}
