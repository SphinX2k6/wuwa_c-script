using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002BD1 RID: 11217
[NullableContext(1)]
[Nullable(0)]
public class TowerData : IStaticVariableResetter
{
	// Token: 0x060174D3 RID: 95443 RVA: 0x005EC8AE File Offset: 0x005EAAAE
	static TowerData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerData.CreateStaticDefaultValue), new Action(TowerData.ResetStaticDefaultValue));
	}

	// Token: 0x060174D4 RID: 95444 RVA: 0x005EC8D0 File Offset: 0x005EAAD0
	public static void CreateStaticDefaultValue()
	{
		TowerData.highColor = new FColor?(FColor.FromHex("FFE361"));
		TowerData.lowColor = new FColor?(FColor.FromHex("FFBD77"));
		TowerData.noneColor = new FColor?(FColor.FromHex("B11515"));
		TowerData.redColor = new FColor?(FColor.FromHex("E2524C"));
	}

	// Token: 0x060174D5 RID: 95445 RVA: 0x005EC92D File Offset: 0x005EAB2D
	public static void ResetStaticDefaultValue()
	{
		TowerData.highColor = null;
		TowerData.lowColor = null;
		TowerData.noneColor = null;
		TowerData.redColor = null;
	}

	// Token: 0x0400AE4D RID: 44621
	public const int LOW_RISK_DIFFICULTY = 1;

	// Token: 0x0400AE4E RID: 44622
	public const int HIGH_RISK_DIFFICULTY = 2;

	// Token: 0x0400AE4F RID: 44623
	public const int VARIATION_RISK_DIFFICULTY = 3;

	// Token: 0x0400AE50 RID: 44624
	public const int OVERLOCK_RISK_DIFFICULTY = 4;

	// Token: 0x0400AE51 RID: 44625
	public const string HIGH_COLOR = "FFE361";

	// Token: 0x0400AE52 RID: 44626
	public const string LOW_COLOR = "FFBD77";

	// Token: 0x0400AE53 RID: 44627
	public const string NONE_COLOR = "B11515";

	// Token: 0x0400AE54 RID: 44628
	public const string RED_COLOR = "E2524C";

	// Token: 0x0400AE55 RID: 44629
	public static FColor? highColor;

	// Token: 0x0400AE56 RID: 44630
	public static FColor? lowColor;

	// Token: 0x0400AE57 RID: 44631
	public static FColor? noneColor;

	// Token: 0x0400AE58 RID: 44632
	public static FColor? redColor;

	// Token: 0x0400AE59 RID: 44633
	public const int HIGH_COST = 4;

	// Token: 0x0400AE5A RID: 44634
	public const int TOWER_TEAM_MAX_NUMBER = 3;
}
