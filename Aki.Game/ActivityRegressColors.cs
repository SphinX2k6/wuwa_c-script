using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200146C RID: 5228
public class ActivityRegressColors : IStaticVariableResetter
{
	// Token: 0x0600938D RID: 37773 RVA: 0x001FB6A4 File Offset: 0x001F98A4
	static ActivityRegressColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressColors.CreateStaticDefaultValue), new Action(ActivityRegressColors.ResetStaticDefaultValue));
	}

	// Token: 0x0600938E RID: 37774 RVA: 0x001FB6C3 File Offset: 0x001F98C3
	public static void CreateStaticDefaultValue()
	{
		ActivityRegressColors.RegressYellowColor = new FColor?(FColor.FromHex("8D784C"));
		ActivityRegressColors.RegressBlueColor = new FColor?(FColor.FromHex("476188"));
	}

	// Token: 0x0600938F RID: 37775 RVA: 0x001FB6ED File Offset: 0x001F98ED
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressColors.RegressYellowColor = null;
		ActivityRegressColors.RegressBlueColor = null;
	}

	// Token: 0x04004185 RID: 16773
	[Nullable(1)]
	private const string YELLOW_COLOR = "8D784C";

	// Token: 0x04004186 RID: 16774
	public static FColor? RegressYellowColor;

	// Token: 0x04004187 RID: 16775
	[Nullable(1)]
	private const string BLUE_COLOR = "476188";

	// Token: 0x04004188 RID: 16776
	public static FColor? RegressBlueColor;
}
