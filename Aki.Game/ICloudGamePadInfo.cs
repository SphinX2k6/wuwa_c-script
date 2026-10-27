using System;

// Token: 0x02000243 RID: 579
public interface ICloudGamePadInfo
{
	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x0600237D RID: 9085
	// (set) Token: 0x0600237E RID: 9086
	int IsConnectPad { get; set; }

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x0600237F RID: 9087
	// (set) Token: 0x06002380 RID: 9088
	int VendorId { get; set; }

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x06002381 RID: 9089
	// (set) Token: 0x06002382 RID: 9090
	int ProductId { get; set; }
}
