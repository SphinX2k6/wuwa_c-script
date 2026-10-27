using System;
using System.Runtime.CompilerServices;

// Token: 0x020027F1 RID: 10225
[NullableContext(1)]
public interface IButtonState
{
	// Token: 0x17001BA1 RID: 7073
	// (get) Token: 0x06014FE8 RID: 85992
	// (set) Token: 0x06014FE9 RID: 85993
	string Text { get; set; }

	// Token: 0x17001BA2 RID: 7074
	// (get) Token: 0x06014FEA RID: 85994
	// (set) Token: 0x06014FEB RID: 85995
	bool IsHighlight { get; set; }
}
