using System;
using UnrealEngine;

// Token: 0x02000E78 RID: 3704
[StaticVariableRuleIgnore]
public class KscEntityRemoveReason
{
	// Token: 0x0400293A RID: 10554
	public static readonly FName Dead = FNameUtil.GetDynamicFName("Dead").Value;

	// Token: 0x0400293B RID: 10555
	public static readonly FName WorldKill = FNameUtil.GetDynamicFName("WorldKill").Value;

	// Token: 0x0400293C RID: 10556
	public static readonly FName Arrival = FNameUtil.GetDynamicFName("Arrival").Value;

	// Token: 0x0400293D RID: 10557
	public static readonly FName Coin = FNameUtil.GetDynamicFName("Coin").Value;

	// Token: 0x0400293E RID: 10558
	public static readonly FName LandFire = KscData.landFireRemoveReason;

	// Token: 0x0400293F RID: 10559
	public static readonly FName CombatDirty = FNameUtil.GetDynamicFName("CombatDirty").Value;

	// Token: 0x04002940 RID: 10560
	public static readonly FName Destroy = FNameUtil.GetDynamicFName("Destroy").Value;
}
