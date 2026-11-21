using System;
using System.Runtime.CompilerServices;

// Token: 0x02002469 RID: 9321
[RequiredMember]
public class RequirementMonsterGenre : IRequirement
{
	// Token: 0x17002468 RID: 9320
	// (get) Token: 0x06017468 RID: 95336 RVA: 0x006D7E7B File Offset: 0x006D607B
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.MonsterGenre;
		}
	}

	// Token: 0x06017469 RID: 95337 RVA: 0x006D7E7F File Offset: 0x006D607F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementMonsterGenre()
	{
	}

	// Token: 0x0400C520 RID: 50464
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C521 RID: 50465
	[Nullable(1)]
	[RequiredMember]
	public int[] MonsterGenres;
}
