using System;

// Token: 0x02000244 RID: 580
public class CloudGamePadInfo : ICloudGamePadInfo
{
	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x06002383 RID: 9091 RVA: 0x000DAABB File Offset: 0x000D8CBB
	// (set) Token: 0x06002384 RID: 9092 RVA: 0x000DAAC3 File Offset: 0x000D8CC3
	public int IsConnectPad { get; set; }

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06002385 RID: 9093 RVA: 0x000DAACC File Offset: 0x000D8CCC
	// (set) Token: 0x06002386 RID: 9094 RVA: 0x000DAAD4 File Offset: 0x000D8CD4
	public int VendorId { get; set; }

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06002387 RID: 9095 RVA: 0x000DAADD File Offset: 0x000D8CDD
	// (set) Token: 0x06002388 RID: 9096 RVA: 0x000DAAE5 File Offset: 0x000D8CE5
	public int ProductId { get; set; }
}
