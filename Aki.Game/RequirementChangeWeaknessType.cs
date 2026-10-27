using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F1C RID: 12060
[RequiredMember]
public class RequirementChangeWeaknessType : IRequirement
{
	// Token: 0x170023AC RID: 9132
	// (get) Token: 0x06019B69 RID: 105321 RVA: 0x006B1BAB File Offset: 0x006AFDAB
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.ChangeWeaknessType;
		}
	}

	// Token: 0x06019B6A RID: 105322 RVA: 0x006B1BAF File Offset: 0x006AFDAF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementChangeWeaknessType()
	{
	}

	// Token: 0x0400C18D RID: 49549
	[RequiredMember]
	public EChangeWeaknessType ChangeWeaknessType;
}
