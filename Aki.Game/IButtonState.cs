using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D6C RID: 7532
[NullableContext(1)]
public interface IButtonState
{
	// Token: 0x17001BF9 RID: 7161
	// (get) Token: 0x060129E8 RID: 76264
	// (set) Token: 0x060129E9 RID: 76265
	string Text { get; set; }

	// Token: 0x17001BFA RID: 7162
	// (get) Token: 0x060129EA RID: 76266
	// (set) Token: 0x060129EB RID: 76267
	bool IsHighlight { get; set; }
}
