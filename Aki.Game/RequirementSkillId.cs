using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F07 RID: 12039
[RequiredMember]
public class RequirementSkillId : IRequirement
{
	// Token: 0x17002397 RID: 9111
	// (get) Token: 0x06019B40 RID: 105280 RVA: 0x006B1AC3 File Offset: 0x006AFCC3
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSkillId;
		}
	}

	// Token: 0x06019B41 RID: 105281 RVA: 0x006B1AC6 File Offset: 0x006AFCC6
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSkillId()
	{
	}

	// Token: 0x0400C16C RID: 49516
	[Nullable(1)]
	[RequiredMember]
	public long[] SkillIds;
}
