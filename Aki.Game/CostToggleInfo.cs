using System;

// Token: 0x0200195B RID: 6491
public class CostToggleInfo : ICostToggleInfo
{
	// Token: 0x170018C7 RID: 6343
	// (get) Token: 0x0601006F RID: 65647 RVA: 0x004AC44A File Offset: 0x004AA64A
	// (set) Token: 0x06010070 RID: 65648 RVA: 0x004AC452 File Offset: 0x004AA652
	public int Component { get; set; }

	// Token: 0x170018C8 RID: 6344
	// (get) Token: 0x06010071 RID: 65649 RVA: 0x004AC45B File Offset: 0x004AA65B
	// (set) Token: 0x06010072 RID: 65650 RVA: 0x004AC463 File Offset: 0x004AA663
	public int CostValue { get; set; }
}
