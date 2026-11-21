using System;

// Token: 0x020009F4 RID: 2548
public class TurntableReward : ITurntableReward
{
	// Token: 0x17000D7A RID: 3450
	// (get) Token: 0x06006F54 RID: 28500 RVA: 0x0022472D File Offset: 0x0022292D
	// (set) Token: 0x06006F55 RID: 28501 RVA: 0x00224735 File Offset: 0x00222935
	public int Id { get; set; }

	// Token: 0x17000D7B RID: 3451
	// (get) Token: 0x06006F56 RID: 28502 RVA: 0x0022473E File Offset: 0x0022293E
	// (set) Token: 0x06006F57 RID: 28503 RVA: 0x00224746 File Offset: 0x00222946
	public int RoundId { get; set; }

	// Token: 0x17000D7C RID: 3452
	// (get) Token: 0x06006F58 RID: 28504 RVA: 0x0022474F File Offset: 0x0022294F
	// (set) Token: 0x06006F59 RID: 28505 RVA: 0x00224757 File Offset: 0x00222957
	public bool IsClaimed { get; set; }

	// Token: 0x17000D7D RID: 3453
	// (get) Token: 0x06006F5A RID: 28506 RVA: 0x00224760 File Offset: 0x00222960
	// (set) Token: 0x06006F5B RID: 28507 RVA: 0x00224768 File Offset: 0x00222968
	public TItem RewardItem { get; set; }

	// Token: 0x17000D7E RID: 3454
	// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00224771 File Offset: 0x00222971
	// (set) Token: 0x06006F5D RID: 28509 RVA: 0x00224779 File Offset: 0x00222979
	public bool IsSpecial { get; set; }
}
