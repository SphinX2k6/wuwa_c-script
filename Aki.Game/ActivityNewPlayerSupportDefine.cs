using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200086B RID: 2155
public static class ActivityNewPlayerSupportDefine
{
	// Token: 0x04003F97 RID: 16279
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<int, string> RoleBgColor = new Dictionary<int, string>
	{
		{
			1205,
			"dee7df"
		},
		{
			1302,
			"c04e4f"
		},
		{
			1304,
			"2bb4c3"
		},
		{
			1505,
			"2a67de"
		},
		{
			1603,
			"cb2f16"
		}
	};

	// Token: 0x04003F98 RID: 16280
	public const int TRAIL_ROLE_HELP_ID = 465;

	// Token: 0x04003F99 RID: 16281
	public const float RECEIVED_TASK_ITEM_ALPHA = 0.6f;

	// Token: 0x04003F9A RID: 16282
	[Nullable(1)]
	public const string TRIAL_ROLE_LIST_ITEM_RESOURCE_ID = "TogRoleTrial";

	// Token: 0x04003F9B RID: 16283
	[StaticVariableRuleIgnore]
	public static readonly FColor FinishTaskTextColor = FColor.FromHex("6586c1");

	// Token: 0x04003F9C RID: 16284
	[StaticVariableRuleIgnore]
	public static readonly FColor NormalTaskTextColor = FColor.FromHex("b6e1ff");

	// Token: 0x02006BB2 RID: 27570
	public enum ETrialRoleStatus
	{
		// Token: 0x0402368A RID: 145034
		Locked,
		// Token: 0x0402368B RID: 145035
		Unlocked
	}
}
