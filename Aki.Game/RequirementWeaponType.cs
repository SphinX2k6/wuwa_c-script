using System;
using System.Runtime.CompilerServices;

// Token: 0x02002463 RID: 9315
[RequiredMember]
public class RequirementWeaponType : IRequirement
{
	// Token: 0x17002462 RID: 9314
	// (get) Token: 0x0601745C RID: 95324 RVA: 0x006D7E34 File Offset: 0x006D6034
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedWeaponType;
		}
	}

	// Token: 0x0601745D RID: 95325 RVA: 0x006D7E37 File Offset: 0x006D6037
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementWeaponType()
	{
	}

	// Token: 0x0400C517 RID: 50455
	[Nullable(1)]
	[RequiredMember]
	public int[] WeaponTypes;
}
