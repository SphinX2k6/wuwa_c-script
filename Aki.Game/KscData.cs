using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E77 RID: 3703
[StaticVariableRuleIgnore]
public static class KscData
{
	// Token: 0x04002938 RID: 10552
	public static readonly FName landFireRemoveReason = FNameUtil.GetDynamicFName("LandFireRemove").Value;

	// Token: 0x04002939 RID: 10553
	[Nullable(1)]
	public static readonly FName[] kscEntityRemoveReasonList = new FName[]
	{
		KscEntityRemoveReason.Dead,
		KscEntityRemoveReason.WorldKill,
		KscEntityRemoveReason.Coin,
		KscEntityRemoveReason.CombatDirty,
		KscEntityRemoveReason.Destroy
	};
}
