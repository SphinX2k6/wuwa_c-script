using System;
using System.Runtime.CompilerServices;

// Token: 0x0200245E RID: 9310
[RequiredMember]
public class RequirementSmashType : IRequirement
{
	// Token: 0x1700245D RID: 9309
	// (get) Token: 0x06017452 RID: 95314 RVA: 0x006D7DFC File Offset: 0x006D5FFC
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.SpecifiedSmashType;
		}
	}

	// Token: 0x06017453 RID: 95315 RVA: 0x006D7DFF File Offset: 0x006D5FFF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementSmashType()
	{
	}

	// Token: 0x0400C512 RID: 50450
	[Nullable(1)]
	[RequiredMember]
	public int[] SmashTypes;
}
