using System;
using System.Runtime.CompilerServices;

// Token: 0x02002464 RID: 9316
[RequiredMember]
public class RequirementTagExistence : IRequirement
{
	// Token: 0x17002463 RID: 9315
	// (get) Token: 0x0601745E RID: 95326 RVA: 0x006D7E3F File Offset: 0x006D603F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedTagExistence;
		}
	}

	// Token: 0x0601745F RID: 95327 RVA: 0x006D7E43 File Offset: 0x006D6043
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementTagExistence()
	{
	}

	// Token: 0x0400C518 RID: 50456
	[RequiredMember]
	public bool IsExist;

	// Token: 0x0400C519 RID: 50457
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C51A RID: 50458
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireTagContainer;
}
