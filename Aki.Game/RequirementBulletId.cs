using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F0C RID: 12044
[RequiredMember]
public class RequirementBulletId : IRequirement
{
	// Token: 0x1700239C RID: 9116
	// (get) Token: 0x06019B49 RID: 105289 RVA: 0x006B1AEF File Offset: 0x006AFCEF
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedBulletId;
		}
	}

	// Token: 0x06019B4A RID: 105290 RVA: 0x006B1AF2 File Offset: 0x006AFCF2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBulletId()
	{
	}

	// Token: 0x0400C171 RID: 49521
	[Nullable(1)]
	[RequiredMember]
	public long[] BulletIds;
}
