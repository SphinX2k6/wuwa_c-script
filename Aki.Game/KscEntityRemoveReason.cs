using System;
using UnrealEngine;

// Token: 0x0200032D RID: 813
[StaticVariableRuleIgnore]
public class KscEntityRemoveReason
{
	// Token: 0x040029D5 RID: 10709
	public static readonly FName Dead = FNameUtil.GetDynamicFName("Dead").Value;

	// Token: 0x040029D6 RID: 10710
	public static readonly FName WorldKill = FNameUtil.GetDynamicFName("WorldKill").Value;

	// Token: 0x040029D7 RID: 10711
	public static readonly FName Arrival = FNameUtil.GetDynamicFName("Arrival").Value;

	// Token: 0x040029D8 RID: 10712
	public static readonly FName Coin = FNameUtil.GetDynamicFName("Coin").Value;

	// Token: 0x040029D9 RID: 10713
	public static readonly FName LandFire = KscData.landFireRemoveReason;

	// Token: 0x040029DA RID: 10714
	public static readonly FName CombatDirty = FNameUtil.GetDynamicFName("CombatDirty").Value;

	// Token: 0x040029DB RID: 10715
	public static readonly FName Destroy = FNameUtil.GetDynamicFName("Destroy").Value;
}
