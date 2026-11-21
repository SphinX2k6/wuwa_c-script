using System;
using System.Runtime.CompilerServices;

// Token: 0x0200246D RID: 9325
[RequiredMember]
public class RequirementBattleFlags : IRequirement
{
	// Token: 0x1700246C RID: 9324
	// (get) Token: 0x06017470 RID: 95344 RVA: 0x006D7EAB File Offset: 0x006D60AB
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.BattleFlags;
		}
	}

	// Token: 0x06017471 RID: 95345 RVA: 0x006D7EAF File Offset: 0x006D60AF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBattleFlags()
	{
	}

	// Token: 0x0400C52C RID: 50476
	[Nullable(1)]
	[RequiredMember]
	public string[] BattleFlags;
}
