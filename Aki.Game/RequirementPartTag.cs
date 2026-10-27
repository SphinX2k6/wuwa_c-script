using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F12 RID: 12050
[RequiredMember]
public class RequirementPartTag : IRequirement
{
	// Token: 0x170023A2 RID: 9122
	// (get) Token: 0x06019B55 RID: 105301 RVA: 0x006B1B33 File Offset: 0x006AFD33
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedPartTag;
		}
	}

	// Token: 0x06019B56 RID: 105302 RVA: 0x006B1B37 File Offset: 0x006AFD37
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementPartTag()
	{
	}

	// Token: 0x0400C179 RID: 49529
	[Nullable(1)]
	[RequiredMember]
	public int[] RequirePartTags;
}
