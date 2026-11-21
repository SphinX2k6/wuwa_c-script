using System;

// Token: 0x020008D0 RID: 2256
public class BuffView : IBuffView
{
	// Token: 0x17000C8E RID: 3214
	// (get) Token: 0x060064B0 RID: 25776 RVA: 0x001FB66F File Offset: 0x001F986F
	// (set) Token: 0x060064B1 RID: 25777 RVA: 0x001FB677 File Offset: 0x001F9877
	public int BuffId { get; set; }

	// Token: 0x17000C8F RID: 3215
	// (get) Token: 0x060064B2 RID: 25778 RVA: 0x001FB680 File Offset: 0x001F9880
	// (set) Token: 0x060064B3 RID: 25779 RVA: 0x001FB688 File Offset: 0x001F9888
	public EPinballBuffType BuffType { get; set; }

	// Token: 0x17000C90 RID: 3216
	// (get) Token: 0x060064B4 RID: 25780 RVA: 0x001FB691 File Offset: 0x001F9891
	// (set) Token: 0x060064B5 RID: 25781 RVA: 0x001FB699 File Offset: 0x001F9899
	public int BuffCount { get; set; }

	// Token: 0x17000C91 RID: 3217
	// (get) Token: 0x060064B6 RID: 25782 RVA: 0x001FB6A2 File Offset: 0x001F98A2
	// (set) Token: 0x060064B7 RID: 25783 RVA: 0x001FB6AA File Offset: 0x001F98AA
	public int Sort { get; set; }
}
