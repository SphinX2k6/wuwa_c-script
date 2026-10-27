using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F08 RID: 12040
[RequiredMember]
public class RequirementSkillGenre : IRequirement
{
	// Token: 0x17002398 RID: 9112
	// (get) Token: 0x06019B42 RID: 105282 RVA: 0x006B1ACE File Offset: 0x006AFCCE
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSkillGenre;
		}
	}

	// Token: 0x06019B43 RID: 105283 RVA: 0x006B1AD1 File Offset: 0x006AFCD1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSkillGenre()
	{
	}

	// Token: 0x0400C16D RID: 49517
	[Nullable(1)]
	[RequiredMember]
	public int[] SkillGenres;
}
