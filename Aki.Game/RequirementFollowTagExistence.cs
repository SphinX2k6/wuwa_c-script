using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;

// Token: 0x0200246B RID: 9323
[RequiredMember]
public class RequirementFollowTagExistence : IRequirement
{
	// Token: 0x1700246A RID: 9322
	// (get) Token: 0x0601746C RID: 95340 RVA: 0x006D7E93 File Offset: 0x006D6093
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedFollowTagExistence;
		}
	}

	// Token: 0x0601746D RID: 95341 RVA: 0x006D7E97 File Offset: 0x006D6097
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementFollowTagExistence()
	{
	}

	// Token: 0x0400C526 RID: 50470
	[RequiredMember]
	public ESummonType SummonType;

	// Token: 0x0400C527 RID: 50471
	[RequiredMember]
	public int SummonIndex;

	// Token: 0x0400C528 RID: 50472
	[RequiredMember]
	public bool IsExist;

	// Token: 0x0400C529 RID: 50473
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C52A RID: 50474
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireTagContainer;
}
