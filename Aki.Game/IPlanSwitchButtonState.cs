using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D6E RID: 7534
[NullableContext(1)]
public interface IPlanSwitchButtonState
{
	// Token: 0x17001BFD RID: 7165
	// (get) Token: 0x060129F1 RID: 76273
	// (set) Token: 0x060129F2 RID: 76274
	bool IsShow { get; set; }

	// Token: 0x17001BFE RID: 7166
	// (get) Token: 0x060129F3 RID: 76275
	// (set) Token: 0x060129F4 RID: 76276
	string Text { get; set; }

	// Token: 0x17001BFF RID: 7167
	// (get) Token: 0x060129F5 RID: 76277
	// (set) Token: 0x060129F6 RID: 76278
	bool IsHighlight { get; set; }
}
