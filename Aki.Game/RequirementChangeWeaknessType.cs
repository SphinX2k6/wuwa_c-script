using System;
using System.Runtime.CompilerServices;

// Token: 0x0200246F RID: 9327
[RequiredMember]
public class RequirementChangeWeaknessType : IRequirement
{
	// Token: 0x1700246E RID: 9326
	// (get) Token: 0x06017474 RID: 95348 RVA: 0x006D7EC3 File Offset: 0x006D60C3
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.ChangeWeaknessType;
		}
	}

	// Token: 0x06017475 RID: 95349 RVA: 0x006D7EC7 File Offset: 0x006D60C7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementChangeWeaknessType()
	{
	}

	// Token: 0x0400C52F RID: 50479
	[RequiredMember]
	public EChangeWeaknessType ChangeWeaknessType;
}
