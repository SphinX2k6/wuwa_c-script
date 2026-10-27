using System;

// Token: 0x02002B61 RID: 11105
public class SurvivorsLvNodeData : ISurvivorsLvNodeData
{
	// Token: 0x17001EB0 RID: 7856
	// (get) Token: 0x0601704D RID: 94285 RVA: 0x005D82C6 File Offset: 0x005D64C6
	// (set) Token: 0x0601704E RID: 94286 RVA: 0x005D82CE File Offset: 0x005D64CE
	public int Lv { get; set; }

	// Token: 0x17001EB1 RID: 7857
	// (get) Token: 0x0601704F RID: 94287 RVA: 0x005D82D7 File Offset: 0x005D64D7
	// (set) Token: 0x06017050 RID: 94288 RVA: 0x005D82DF File Offset: 0x005D64DF
	public bool IsImportant { get; set; }

	// Token: 0x17001EB2 RID: 7858
	// (get) Token: 0x06017051 RID: 94289 RVA: 0x005D82E8 File Offset: 0x005D64E8
	// (set) Token: 0x06017052 RID: 94290 RVA: 0x005D82F0 File Offset: 0x005D64F0
	public ESurvivorsLvState State { get; set; }
}
