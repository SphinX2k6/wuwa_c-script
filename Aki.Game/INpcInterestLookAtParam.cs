using System;
using System.Runtime.CompilerServices;

// Token: 0x020031ED RID: 12781
[NullableContext(1)]
public interface INpcInterestLookAtParam
{
	// Token: 0x1700261D RID: 9757
	// (get) Token: 0x0601B938 RID: 112952
	// (set) Token: 0x0601B939 RID: 112953
	int TargetPbDataId { get; set; }

	// Token: 0x1700261E RID: 9758
	// (get) Token: 0x0601B93A RID: 112954
	// (set) Token: 0x0601B93B RID: 112955
	Vector TargetPosition { get; set; }

	// Token: 0x1700261F RID: 9759
	// (get) Token: 0x0601B93C RID: 112956
	// (set) Token: 0x0601B93D RID: 112957
	float MaxAngle { get; set; }

	// Token: 0x17002620 RID: 9760
	// (get) Token: 0x0601B93E RID: 112958
	// (set) Token: 0x0601B93F RID: 112959
	float MaxDistance { get; set; }
}
