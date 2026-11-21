using System;
using System.Runtime.CompilerServices;

// Token: 0x020006EA RID: 1770
[NullableContext(1)]
public interface IDangoTipsInfo
{
	// Token: 0x17000AD8 RID: 2776
	// (get) Token: 0x0600519E RID: 20894
	// (set) Token: 0x0600519F RID: 20895
	string Text { get; set; }

	// Token: 0x17000AD9 RID: 2777
	// (get) Token: 0x060051A0 RID: 20896
	// (set) Token: 0x060051A1 RID: 20897
	[Nullable(2)]
	string Icon { [NullableContext(2)] get; [NullableContext(2)] set; }
}
