using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285D RID: 10333
[NullableContext(1)]
public interface IWaterfallMoveParams
{
	// Token: 0x17002AA7 RID: 10919
	// (get) Token: 0x0601A27A RID: 107130
	// (set) Token: 0x0601A27B RID: 107131
	int SplineId { get; set; }

	// Token: 0x17002AA8 RID: 10920
	// (get) Token: 0x0601A27C RID: 107132
	// (set) Token: 0x0601A27D RID: 107133
	Vector Direct { get; set; }

	// Token: 0x17002AA9 RID: 10921
	// (get) Token: 0x0601A27E RID: 107134
	// (set) Token: 0x0601A27F RID: 107135
	[Nullable(2)]
	Vector ChangeGravity { [NullableContext(2)] get; [NullableContext(2)] set; }
}
