using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F1A RID: 12058
[RequiredMember]
public class RequirementBattleFlags : IRequirement
{
	// Token: 0x170023AA RID: 9130
	// (get) Token: 0x06019B65 RID: 105317 RVA: 0x006B1B93 File Offset: 0x006AFD93
	public EExtraEffectRequire Type
	{
		get
		{
			return EExtraEffectRequire.BattleFlags;
		}
	}

	// Token: 0x06019B66 RID: 105318 RVA: 0x006B1B97 File Offset: 0x006AFD97
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public RequirementBattleFlags()
	{
	}

	// Token: 0x0400C18A RID: 49546
	[Nullable(1)]
	[RequiredMember]
	public string[] BattleFlags;
}
