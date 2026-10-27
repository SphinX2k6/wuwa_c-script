using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F16 RID: 12054
[RequiredMember]
public class RequirementMonsterGenre : IRequirement
{
	// Token: 0x170023A6 RID: 9126
	// (get) Token: 0x06019B5D RID: 105309 RVA: 0x006B1B63 File Offset: 0x006AFD63
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.MonsterGenre;
		}
	}

	// Token: 0x06019B5E RID: 105310 RVA: 0x006B1B67 File Offset: 0x006AFD67
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementMonsterGenre()
	{
	}

	// Token: 0x0400C17E RID: 49534
	[RequiredMember]
	public ERequirementTargetType RequireTargetType;

	// Token: 0x0400C17F RID: 49535
	[Nullable(1)]
	[RequiredMember]
	public int[] MonsterGenres;
}
