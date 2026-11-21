using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200246E RID: 9326
[RequiredMember]
public class RequirementDamageSourceType : IRequirement
{
	// Token: 0x1700246D RID: 9325
	// (get) Token: 0x06017472 RID: 95346 RVA: 0x006D7EB7 File Offset: 0x006D60B7
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.DamageSourceType;
		}
	}

	// Token: 0x06017473 RID: 95347 RVA: 0x006D7EBB File Offset: 0x006D60BB
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageSourceType()
	{
	}

	// Token: 0x0400C52D RID: 50477
	[RequiredMember]
	public bool CheckInclude;

	// Token: 0x0400C52E RID: 50478
	[Nullable(1)]
	[RequiredMember]
	public DamageSourceType[] DamageSourceTypes;
}
