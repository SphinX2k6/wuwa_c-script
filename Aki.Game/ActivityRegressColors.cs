using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000920 RID: 2336
public class ActivityRegressColors : IStaticVariableResetter
{
	// Token: 0x06006722 RID: 26402 RVA: 0x002044AC File Offset: 0x002026AC
	static ActivityRegressColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressColors.CreateStaticDefaultValue), new Action(ActivityRegressColors.ResetStaticDefaultValue));
	}

	// Token: 0x06006723 RID: 26403 RVA: 0x002044CB File Offset: 0x002026CB
	public static void CreateStaticDefaultValue()
	{
		ActivityRegressColors.RegressYellowColor = new FColor?(FColor.FromHex("8D784C"));
		ActivityRegressColors.RegressBlueColor = new FColor?(FColor.FromHex("476188"));
	}

	// Token: 0x06006724 RID: 26404 RVA: 0x002044F5 File Offset: 0x002026F5
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressColors.RegressYellowColor = null;
		ActivityRegressColors.RegressBlueColor = null;
	}

	// Token: 0x0400421D RID: 16925
	[Nullable(1)]
	private const string YELLOW_COLOR = "8D784C";

	// Token: 0x0400421E RID: 16926
	public static FColor? RegressYellowColor;

	// Token: 0x0400421F RID: 16927
	[Nullable(1)]
	private const string BLUE_COLOR = "476188";

	// Token: 0x04004220 RID: 16928
	public static FColor? RegressBlueColor;
}
