using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200214C RID: 8524
[NullableContext(1)]
[Nullable(0)]
public class TowerData : IStaticVariableResetter
{
	// Token: 0x06014F04 RID: 85764 RVA: 0x006193EA File Offset: 0x006175EA
	static TowerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerData.CreateStaticDefaultValue), new Action(TowerData.ResetStaticDefaultValue));
	}

	// Token: 0x06014F05 RID: 85765 RVA: 0x0061940C File Offset: 0x0061760C
	public static void CreateStaticDefaultValue()
	{
		TowerData.highColor = new FColor?(FColor.FromHex("FFE361"));
		TowerData.lowColor = new FColor?(FColor.FromHex("FFBD77"));
		TowerData.noneColor = new FColor?(FColor.FromHex("B11515"));
		TowerData.redColor = new FColor?(FColor.FromHex("E2524C"));
	}

	// Token: 0x06014F06 RID: 85766 RVA: 0x00619469 File Offset: 0x00617669
	public static void ResetStaticDefaultValue()
	{
		TowerData.highColor = null;
		TowerData.lowColor = null;
		TowerData.noneColor = null;
		TowerData.redColor = null;
	}

	// Token: 0x0400B252 RID: 45650
	public const int LOW_RISK_DIFFICULTY = 1;

	// Token: 0x0400B253 RID: 45651
	public const int HIGH_RISK_DIFFICULTY = 2;

	// Token: 0x0400B254 RID: 45652
	public const int VARIATION_RISK_DIFFICULTY = 3;

	// Token: 0x0400B255 RID: 45653
	public const int OVERLOCK_RISK_DIFFICULTY = 4;

	// Token: 0x0400B256 RID: 45654
	public const string HIGH_COLOR = "FFE361";

	// Token: 0x0400B257 RID: 45655
	public const string LOW_COLOR = "FFBD77";

	// Token: 0x0400B258 RID: 45656
	public const string NONE_COLOR = "B11515";

	// Token: 0x0400B259 RID: 45657
	public const string RED_COLOR = "E2524C";

	// Token: 0x0400B25A RID: 45658
	public static FColor? highColor;

	// Token: 0x0400B25B RID: 45659
	public static FColor? lowColor;

	// Token: 0x0400B25C RID: 45660
	public static FColor? noneColor;

	// Token: 0x0400B25D RID: 45661
	public static FColor? redColor;

	// Token: 0x0400B25E RID: 45662
	public const int HIGH_COST = 4;

	// Token: 0x0400B25F RID: 45663
	public const int TOWER_TEAM_MAX_NUMBER = 3;
}
