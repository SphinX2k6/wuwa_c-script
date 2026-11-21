using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C2E RID: 7214
[NullableContext(1)]
[Nullable(0)]
public class RecommendQualityItemData : IRecommendQualityItemData
{
	// Token: 0x17001B3B RID: 6971
	// (get) Token: 0x06011ECA RID: 73418 RVA: 0x00546637 File Offset: 0x00544837
	// (set) Token: 0x06011ECB RID: 73419 RVA: 0x0054663F File Offset: 0x0054483F
	public EGameQualitySettingLevel Quality { get; set; }

	// Token: 0x17001B3C RID: 6972
	// (get) Token: 0x06011ECC RID: 73420 RVA: 0x00546648 File Offset: 0x00544848
	// (set) Token: 0x06011ECD RID: 73421 RVA: 0x00546650 File Offset: 0x00544850
	public string Name { get; set; } = "";

	// Token: 0x17001B3D RID: 6973
	// (get) Token: 0x06011ECE RID: 73422 RVA: 0x00546659 File Offset: 0x00544859
	// (set) Token: 0x06011ECF RID: 73423 RVA: 0x00546661 File Offset: 0x00544861
	public bool IsRecommend { get; set; }

	// Token: 0x17001B3E RID: 6974
	// (get) Token: 0x06011ED0 RID: 73424 RVA: 0x0054666A File Offset: 0x0054486A
	// (set) Token: 0x06011ED1 RID: 73425 RVA: 0x00546672 File Offset: 0x00544872
	public string Bg { get; set; } = "";
}
