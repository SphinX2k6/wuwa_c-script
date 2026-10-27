using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020013B7 RID: 5047
public static class ActivityNewPlayerSupportDefine
{
	// Token: 0x04003EFF RID: 16127
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

	// Token: 0x04003F00 RID: 16128
	public const int TRAIL_ROLE_HELP_ID = 465;

	// Token: 0x04003F01 RID: 16129
	public const float RECEIVED_TASK_ITEM_ALPHA = 0.6f;

	// Token: 0x04003F02 RID: 16130
	[Nullable(1)]
	public const string TRIAL_ROLE_LIST_ITEM_RESOURCE_ID = "TogRoleTrial";

	// Token: 0x04003F03 RID: 16131
	[StaticVariableRuleIgnore]
	public static readonly FColor FinishTaskTextColor = FColor.FromHex("6586c1");

	// Token: 0x04003F04 RID: 16132
	[StaticVariableRuleIgnore]
	public static readonly FColor NormalTaskTextColor = FColor.FromHex("b6e1ff");

	// Token: 0x02007A2C RID: 31276
	public enum ETrialRoleStatus
	{
		// Token: 0x0402836D RID: 164717
		Locked,
		// Token: 0x0402836E RID: 164718
		Unlocked
	}
}
