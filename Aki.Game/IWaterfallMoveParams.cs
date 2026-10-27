using System;
using System.Runtime.CompilerServices;

// Token: 0x020032EB RID: 13035
[NullableContext(1)]
public interface IWaterfallMoveParams
{
	// Token: 0x17002740 RID: 10048
	// (get) Token: 0x0601C5BF RID: 116159
	// (set) Token: 0x0601C5C0 RID: 116160
	int SplineId { get; set; }

	// Token: 0x17002741 RID: 10049
	// (get) Token: 0x0601C5C1 RID: 116161
	// (set) Token: 0x0601C5C2 RID: 116162
	Vector Direct { get; set; }

	// Token: 0x17002742 RID: 10050
	// (get) Token: 0x0601C5C3 RID: 116163
	// (set) Token: 0x0601C5C4 RID: 116164
	[Nullable(2)]
	Vector ChangeGravity { [NullableContext(2)] get; [NullableContext(2)] set; }
}
