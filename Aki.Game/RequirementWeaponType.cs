using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F10 RID: 12048
[RequiredMember]
public class RequirementWeaponType : IRequirement
{
	// Token: 0x170023A0 RID: 9120
	// (get) Token: 0x06019B51 RID: 105297 RVA: 0x006B1B1C File Offset: 0x006AFD1C
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedWeaponType;
		}
	}

	// Token: 0x06019B52 RID: 105298 RVA: 0x006B1B1F File Offset: 0x006AFD1F
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementWeaponType()
	{
	}

	// Token: 0x0400C175 RID: 49525
	[Nullable(1)]
	[RequiredMember]
	public int[] WeaponTypes;
}
