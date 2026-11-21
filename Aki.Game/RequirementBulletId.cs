using System;
using System.Runtime.CompilerServices;

// Token: 0x0200245F RID: 9311
[RequiredMember]
public class RequirementBulletId : IRequirement
{
	// Token: 0x1700245E RID: 9310
	// (get) Token: 0x06017454 RID: 95316 RVA: 0x006D7E07 File Offset: 0x006D6007
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedBulletId;
		}
	}

	// Token: 0x06017455 RID: 95317 RVA: 0x006D7E0A File Offset: 0x006D600A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBulletId()
	{
	}

	// Token: 0x0400C513 RID: 50451
	[Nullable(1)]
	[RequiredMember]
	public long[] BulletIds;
}
