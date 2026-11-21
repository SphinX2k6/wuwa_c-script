using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000549 RID: 1353
[NullableContext(1)]
[Nullable(0)]
public class ActivityRecommendColors : IStaticVariableResetter
{
	// Token: 0x0600421C RID: 16924 RVA: 0x001710F7 File Offset: 0x0016F2F7
	static ActivityRecommendColors()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRecommendColors.CreateStaticDefaultValue), new Action(ActivityRecommendColors.ResetStaticDefaultValue));
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x00171116 File Offset: 0x0016F316
	public static void CreateStaticDefaultValue()
	{
		ActivityRecommendColors.RecommendYellowColor = new FColor?(FColor.FromHex("8D784C"));
		ActivityRecommendColors.RecommendBlueColor = new FColor?(FColor.FromHex("476188"));
		ActivityRecommendColors.RecommendGreenColor = new FColor?(FColor.FromHex("4A6256"));
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x00171154 File Offset: 0x0016F354
	public static void ResetStaticDefaultValue()
	{
		ActivityRecommendColors.RecommendYellowColor = null;
		ActivityRecommendColors.RecommendBlueColor = null;
		ActivityRecommendColors.RecommendGreenColor = null;
	}

	// Token: 0x040033C8 RID: 13256
	private const string YELLOW_COLOR = "8D784C";

	// Token: 0x040033C9 RID: 13257
	public static FColor? RecommendYellowColor;

	// Token: 0x040033CA RID: 13258
	private const string BLUE_COLOR = "476188";

	// Token: 0x040033CB RID: 13259
	public static FColor? RecommendBlueColor;

	// Token: 0x040033CC RID: 13260
	private const string GREEN_COLOR = "4A6256";

	// Token: 0x040033CD RID: 13261
	public static FColor? RecommendGreenColor;
}
