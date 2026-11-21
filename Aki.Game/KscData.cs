using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200032C RID: 812
[StaticVariableRuleIgnore]
public static class KscData
{
	// Token: 0x040029D3 RID: 10707
	public static readonly FName landFireRemoveReason = FNameUtil.GetDynamicFName("LandFireRemove").Value;

	// Token: 0x040029D4 RID: 10708
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
