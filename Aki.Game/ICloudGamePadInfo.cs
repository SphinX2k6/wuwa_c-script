using System;

// Token: 0x02000247 RID: 583
public interface ICloudGamePadInfo
{
	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x06002435 RID: 9269
	// (set) Token: 0x06002436 RID: 9270
	int IsConnectPad { get; set; }

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x06002437 RID: 9271
	// (set) Token: 0x06002438 RID: 9272
	int VendorId { get; set; }

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x06002439 RID: 9273
	// (set) Token: 0x0600243A RID: 9274
	int ProductId { get; set; }
}
