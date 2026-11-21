using System;

// Token: 0x020020DD RID: 8413
public class SurvivorsLvNodeData : ISurvivorsLvNodeData
{
	// Token: 0x17001F08 RID: 7944
	// (get) Token: 0x06014A7E RID: 84606 RVA: 0x00604E2E File Offset: 0x0060302E
	// (set) Token: 0x06014A7F RID: 84607 RVA: 0x00604E36 File Offset: 0x00603036
	public int Lv { get; set; }

	// Token: 0x17001F09 RID: 7945
	// (get) Token: 0x06014A80 RID: 84608 RVA: 0x00604E3F File Offset: 0x0060303F
	// (set) Token: 0x06014A81 RID: 84609 RVA: 0x00604E47 File Offset: 0x00603047
	public bool IsImportant { get; set; }

	// Token: 0x17001F0A RID: 7946
	// (get) Token: 0x06014A82 RID: 84610 RVA: 0x00604E50 File Offset: 0x00603050
	// (set) Token: 0x06014A83 RID: 84611 RVA: 0x00604E58 File Offset: 0x00603058
	public ESurvivorsLvState State { get; set; }
}
