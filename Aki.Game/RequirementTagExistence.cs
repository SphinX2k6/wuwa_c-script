using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F11 RID: 12049
[RequiredMember]
public class RequirementTagExistence : IRequirement
{
	// Token: 0x170023A1 RID: 9121
	// (get) Token: 0x06019B53 RID: 105299 RVA: 0x006B1B27 File Offset: 0x006AFD27
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedTagExistence;
		}
	}

	// Token: 0x06019B54 RID: 105300 RVA: 0x006B1B2B File Offset: 0x006AFD2B
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementTagExistence()
	{
	}

	// Token: 0x0400C176 RID: 49526
	[RequiredMember]
	public bool IsExist;

	// Token: 0x0400C177 RID: 49527
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C178 RID: 49528
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireTagContainer;
}
