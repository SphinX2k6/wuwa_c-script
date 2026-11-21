using System;

// Token: 0x02000248 RID: 584
public class CloudGamePadInfo : ICloudGamePadInfo
{
	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x0600243B RID: 9275 RVA: 0x000E1003 File Offset: 0x000DF203
	// (set) Token: 0x0600243C RID: 9276 RVA: 0x000E100B File Offset: 0x000DF20B
	public int IsConnectPad { get; set; }

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x0600243D RID: 9277 RVA: 0x000E1014 File Offset: 0x000DF214
	// (set) Token: 0x0600243E RID: 9278 RVA: 0x000E101C File Offset: 0x000DF21C
	public int VendorId { get; set; }

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x0600243F RID: 9279 RVA: 0x000E1025 File Offset: 0x000DF225
	// (set) Token: 0x06002440 RID: 9280 RVA: 0x000E102D File Offset: 0x000DF22D
	public int ProductId { get; set; }
}
