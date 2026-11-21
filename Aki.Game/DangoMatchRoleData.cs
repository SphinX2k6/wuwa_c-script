using System;

// Token: 0x02001BE9 RID: 7145
public class DangoMatchRoleData : IDangoMatchRoleData
{
	// Token: 0x17001B0F RID: 6927
	// (get) Token: 0x06011C6C RID: 72812 RVA: 0x0053A90C File Offset: 0x00538B0C
	// (set) Token: 0x06011C6D RID: 72813 RVA: 0x0053A914 File Offset: 0x00538B14
	public int GroupMatchId { get; set; }

	// Token: 0x17001B10 RID: 6928
	// (get) Token: 0x06011C6E RID: 72814 RVA: 0x0053A91D File Offset: 0x00538B1D
	// (set) Token: 0x06011C6F RID: 72815 RVA: 0x0053A925 File Offset: 0x00538B25
	public int DangoId { get; set; }

	// Token: 0x17001B11 RID: 6929
	// (get) Token: 0x06011C70 RID: 72816 RVA: 0x0053A92E File Offset: 0x00538B2E
	// (set) Token: 0x06011C71 RID: 72817 RVA: 0x0053A936 File Offset: 0x00538B36
	public bool IsMatchFinished { get; set; }

	// Token: 0x17001B12 RID: 6930
	// (get) Token: 0x06011C72 RID: 72818 RVA: 0x0053A93F File Offset: 0x00538B3F
	// (set) Token: 0x06011C73 RID: 72819 RVA: 0x0053A947 File Offset: 0x00538B47
	public bool IsPromote { get; set; }

	// Token: 0x17001B13 RID: 6931
	// (get) Token: 0x06011C74 RID: 72820 RVA: 0x0053A950 File Offset: 0x00538B50
	// (set) Token: 0x06011C75 RID: 72821 RVA: 0x0053A958 File Offset: 0x00538B58
	public bool IsBasicGroupMatch { get; set; }
}
