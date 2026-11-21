using System;
using System.Runtime.CompilerServices;

// Token: 0x0200245B RID: 9307
[RequiredMember]
public class RequirementSkillGenre : IRequirement
{
	// Token: 0x1700245A RID: 9306
	// (get) Token: 0x0601744D RID: 95309 RVA: 0x006D7DE6 File Offset: 0x006D5FE6
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSkillGenre;
		}
	}

	// Token: 0x0601744E RID: 95310 RVA: 0x006D7DE9 File Offset: 0x006D5FE9
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSkillGenre()
	{
	}

	// Token: 0x0400C50F RID: 50447
	[Nullable(1)]
	[RequiredMember]
	public int[] SkillGenres;
}
