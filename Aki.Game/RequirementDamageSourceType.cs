using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F1B RID: 12059
[RequiredMember]
public class RequirementDamageSourceType : IRequirement
{
	// Token: 0x170023AB RID: 9131
	// (get) Token: 0x06019B67 RID: 105319 RVA: 0x006B1B9F File Offset: 0x006AFD9F
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.DamageSourceType;
		}
	}

	// Token: 0x06019B68 RID: 105320 RVA: 0x006B1BA3 File Offset: 0x006AFDA3
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementDamageSourceType()
	{
	}

	// Token: 0x0400C18B RID: 49547
	[RequiredMember]
	public bool CheckInclude;

	// Token: 0x0400C18C RID: 49548
	[Nullable(1)]
	[RequiredMember]
	public DamageSourceType[] DamageSourceTypes;
}
