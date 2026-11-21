using System;
using System.Runtime.CompilerServices;

// Token: 0x0200218B RID: 8587
public static class TrackDefine
{
	// Token: 0x0400B328 RID: 45864
	public const int INVALID_TRACKDISTANCE = 0;

	// Token: 0x0400B329 RID: 45865
	public const float MAX_A = 1176f;

	// Token: 0x0400B32A RID: 45866
	public const float MARGIN_A = 1008f;

	// Token: 0x0400B32B RID: 45867
	public const float MAX_B = 712.5f;

	// Token: 0x0400B32C RID: 45868
	public const float MARGIN_B = 495f;

	// Token: 0x0400B32D RID: 45869
	public const float CENTER_Y = 62.5f;

	// Token: 0x0400B32E RID: 45870
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Vector2D center = Vector2D.Create(0.0, 62.5);

	// Token: 0x0400B32F RID: 45871
	public const float RAD_2_DEG = 57.295776f;
}
