using System;
using System.Runtime.CompilerServices;

// Token: 0x0200245A RID: 9306
[RequiredMember]
public class RequirementSkillId : IRequirement
{
	// Token: 0x17002459 RID: 9305
	// (get) Token: 0x0601744B RID: 95307 RVA: 0x006D7DDB File Offset: 0x006D5FDB
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSkillId;
		}
	}

	// Token: 0x0601744C RID: 95308 RVA: 0x006D7DDE File Offset: 0x006D5FDE
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSkillId()
	{
	}

	// Token: 0x0400C50E RID: 50446
	[Nullable(1)]
	[RequiredMember]
	public long[] SkillIds;
}
