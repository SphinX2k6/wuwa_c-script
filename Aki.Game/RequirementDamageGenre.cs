using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F14 RID: 12052
[RequiredMember]
public class RequirementDamageGenre : IRequirement
{
	// Token: 0x170023A4 RID: 9124
	// (get) Token: 0x06019B59 RID: 105305 RVA: 0x006B1B4B File Offset: 0x006AFD4B
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedDamageGenre;
		}
	}

	// Token: 0x06019B5A RID: 105306 RVA: 0x006B1B4F File Offset: 0x006AFD4F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageGenre()
	{
	}

	// Token: 0x0400C17B RID: 49531
	[Nullable(1)]
	[RequiredMember]
	public int[] DamageTypes;
}
