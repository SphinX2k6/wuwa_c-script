using System;
using System.Runtime.CompilerServices;

// Token: 0x02001678 RID: 5752
[NullableContext(1)]
[Nullable(0)]
public class ButtonPreset : IButtonPreset
{
	// Token: 0x17001565 RID: 5477
	// (get) Token: 0x0600DFEF RID: 57327 RVA: 0x0041BF03 File Offset: 0x0041A103
	// (set) Token: 0x0600DFF0 RID: 57328 RVA: 0x0041BF0B File Offset: 0x0041A10B
	public string Title { get; set; }

	// Token: 0x17001566 RID: 5478
	// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x0041BF14 File Offset: 0x0041A114
	// (set) Token: 0x0600DFF2 RID: 57330 RVA: 0x0041BF1C File Offset: 0x0041A11C
	public Action ClickFunc { get; set; }
}
