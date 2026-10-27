using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F0B RID: 12043
[RequiredMember]
public class RequirementSmashType : IRequirement
{
	// Token: 0x1700239B RID: 9115
	// (get) Token: 0x06019B47 RID: 105287 RVA: 0x006B1AE4 File Offset: 0x006AFCE4
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSmashType;
		}
	}

	// Token: 0x06019B48 RID: 105288 RVA: 0x006B1AE7 File Offset: 0x006AFCE7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSmashType()
	{
	}

	// Token: 0x0400C170 RID: 49520
	[Nullable(1)]
	[RequiredMember]
	public int[] SmashTypes;
}
