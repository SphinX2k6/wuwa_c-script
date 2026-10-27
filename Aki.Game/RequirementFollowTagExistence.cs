using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;

// Token: 0x02002F18 RID: 12056
[RequiredMember]
public class RequirementFollowTagExistence : IRequirement
{
	// Token: 0x170023A8 RID: 9128
	// (get) Token: 0x06019B61 RID: 105313 RVA: 0x006B1B7B File Offset: 0x006AFD7B
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedFollowTagExistence;
		}
	}

	// Token: 0x06019B62 RID: 105314 RVA: 0x006B1B7F File Offset: 0x006AFD7F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementFollowTagExistence()
	{
	}

	// Token: 0x0400C184 RID: 49540
	[RequiredMember]
	public ESummonType SummonType;

	// Token: 0x0400C185 RID: 49541
	[RequiredMember]
	public int SummonIndex;

	// Token: 0x0400C186 RID: 49542
	[RequiredMember]
	public bool IsExist;

	// Token: 0x0400C187 RID: 49543
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C188 RID: 49544
	[Nullable(1)]
	[RequiredMember]
	public int[] RequireTagContainer;
}
