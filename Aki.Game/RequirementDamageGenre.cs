using System;
using System.Runtime.CompilerServices;

// Token: 0x02002467 RID: 9319
[RequiredMember]
public class RequirementDamageGenre : IRequirement
{
	// Token: 0x17002466 RID: 9318
	// (get) Token: 0x06017464 RID: 95332 RVA: 0x006D7E63 File Offset: 0x006D6063
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedDamageGenre;
		}
	}

	// Token: 0x06017465 RID: 95333 RVA: 0x006D7E67 File Offset: 0x006D6067
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageGenre()
	{
	}

	// Token: 0x0400C51D RID: 50461
	[Nullable(1)]
	[RequiredMember]
	public int[] DamageTypes;
}
