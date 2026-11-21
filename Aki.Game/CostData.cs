using System;

// Token: 0x020014ED RID: 5357
public class CostData : ICostData
{
	// Token: 0x170013D9 RID: 5081
	// (get) Token: 0x0600D621 RID: 54817 RVA: 0x003F8562 File Offset: 0x003F6762
	// (set) Token: 0x0600D622 RID: 54818 RVA: 0x003F856A File Offset: 0x003F676A
	public int ItemId { get; set; }

	// Token: 0x170013DA RID: 5082
	// (get) Token: 0x0600D623 RID: 54819 RVA: 0x003F8573 File Offset: 0x003F6773
	// (set) Token: 0x0600D624 RID: 54820 RVA: 0x003F857B File Offset: 0x003F677B
	public int Count { get; set; }

	// Token: 0x170013DB RID: 5083
	// (get) Token: 0x0600D625 RID: 54821 RVA: 0x003F8584 File Offset: 0x003F6784
	// (set) Token: 0x0600D626 RID: 54822 RVA: 0x003F858C File Offset: 0x003F678C
	public int Cost { get; set; }
}
