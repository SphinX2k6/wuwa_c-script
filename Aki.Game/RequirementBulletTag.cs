using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F13 RID: 12051
[RequiredMember]
public class RequirementBulletTag : IRequirement
{
	// Token: 0x170023A3 RID: 9123
	// (get) Token: 0x06019B57 RID: 105303 RVA: 0x006B1B3F File Offset: 0x006AFD3F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedBulletTag;
		}
	}

	// Token: 0x06019B58 RID: 105304 RVA: 0x006B1B43 File Offset: 0x006AFD43
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBulletTag()
	{
	}

	// Token: 0x0400C17A RID: 49530
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireBulletTags;
}
