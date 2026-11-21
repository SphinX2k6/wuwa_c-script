using System;

// Token: 0x020008DD RID: 2269
public class PinballItemDataMonster : IPinballItemDataMonster
{
	// Token: 0x17000CCE RID: 3278
	// (get) Token: 0x0600653D RID: 25917 RVA: 0x001FBB38 File Offset: 0x001F9D38
	// (set) Token: 0x0600653E RID: 25918 RVA: 0x001FBB40 File Offset: 0x001F9D40
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CCF RID: 3279
	// (get) Token: 0x0600653F RID: 25919 RVA: 0x001FBB49 File Offset: 0x001F9D49
	// (set) Token: 0x06006540 RID: 25920 RVA: 0x001FBB51 File Offset: 0x001F9D51
	public int Id { get; set; }
}
