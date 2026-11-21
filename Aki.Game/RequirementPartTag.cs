using System;
using System.Runtime.CompilerServices;

// Token: 0x02002465 RID: 9317
[RequiredMember]
public class RequirementPartTag : IRequirement
{
	// Token: 0x17002464 RID: 9316
	// (get) Token: 0x06017460 RID: 95328 RVA: 0x006D7E4B File Offset: 0x006D604B
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedPartTag;
		}
	}

	// Token: 0x06017461 RID: 95329 RVA: 0x006D7E4F File Offset: 0x006D604F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementPartTag()
	{
	}

	// Token: 0x0400C51B RID: 50459
	[Nullable(1)]
	[RequiredMember]
	public int[] RequirePartTags;
}
