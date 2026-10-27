using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C10 RID: 11280
public static class TrackDefine
{
	// Token: 0x0400AF23 RID: 44835
	public const int INVALID_TRACKDISTANCE = 0;

	// Token: 0x0400AF24 RID: 44836
	public const float MAX_A = 1176f;

	// Token: 0x0400AF25 RID: 44837
	public const float MARGIN_A = 1008f;

	// Token: 0x0400AF26 RID: 44838
	public const float MAX_B = 712.5f;

	// Token: 0x0400AF27 RID: 44839
	public const float MARGIN_B = 495f;

	// Token: 0x0400AF28 RID: 44840
	public const float CENTER_Y = 62.5f;

	// Token: 0x0400AF29 RID: 44841
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Vector2D center = Vector2D.Create(0.0, 62.5);

	// Token: 0x0400AF2A RID: 44842
	public const float RAD_2_DEG = 57.295776f;
}
