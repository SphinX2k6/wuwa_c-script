using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001095 RID: 4245
[NullableContext(1)]
[Nullable(0)]
public class ActivityRecommendColors : IStaticVariableResetter
{
	// Token: 0x06006E87 RID: 28295 RVA: 0x001687C3 File Offset: 0x001669C3
	static ActivityRecommendColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendColors.CreateStaticDefaultValue), new Action(ActivityRecommendColors.ResetStaticDefaultValue));
	}

	// Token: 0x06006E88 RID: 28296 RVA: 0x001687E2 File Offset: 0x001669E2
	public static void CreateStaticDefaultValue()
	{
		ActivityRecommendColors.RecommendYellowColor = new FColor?(FColor.FromHex("8D784C"));
		ActivityRecommendColors.RecommendBlueColor = new FColor?(FColor.FromHex("476188"));
		ActivityRecommendColors.RecommendGreenColor = new FColor?(FColor.FromHex("4A6256"));
	}

	// Token: 0x06006E89 RID: 28297 RVA: 0x00168820 File Offset: 0x00166A20
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendColors.RecommendYellowColor = null;
		ActivityRecommendColors.RecommendBlueColor = null;
		ActivityRecommendColors.RecommendGreenColor = null;
	}

	// Token: 0x0400332F RID: 13103
	private const string YELLOW_COLOR = "8D784C";

	// Token: 0x04003330 RID: 13104
	public static FColor? RecommendYellowColor;

	// Token: 0x04003331 RID: 13105
	private const string BLUE_COLOR = "476188";

	// Token: 0x04003332 RID: 13106
	public static FColor? RecommendBlueColor;

	// Token: 0x04003333 RID: 13107
	private const string GREEN_COLOR = "4A6256";

	// Token: 0x04003334 RID: 13108
	public static FColor? RecommendGreenColor;
}
