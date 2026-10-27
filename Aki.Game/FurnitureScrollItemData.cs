using System;
using Aki.Config;

// Token: 0x02000F85 RID: 3973
public class FurnitureScrollItemData : IFurnitureScrollItemData
{
	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x060065EC RID: 26092 RVA: 0x00143E14 File Offset: 0x00142014
	// (set) Token: 0x060065ED RID: 26093 RVA: 0x00143E1C File Offset: 0x0014201C
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x170007DD RID: 2013
	// (get) Token: 0x060065EE RID: 26094 RVA: 0x00143E25 File Offset: 0x00142025
	// (set) Token: 0x060065EF RID: 26095 RVA: 0x00143E2D File Offset: 0x0014202D
	public bool RedDotShowState { get; set; }

	// Token: 0x170007DE RID: 2014
	// (get) Token: 0x060065F0 RID: 26096 RVA: 0x00143E36 File Offset: 0x00142036
	// (set) Token: 0x060065F1 RID: 26097 RVA: 0x00143E3E File Offset: 0x0014203E
	public bool IsSelected { get; set; }

	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x060065F2 RID: 26098 RVA: 0x00143E47 File Offset: 0x00142047
	// (set) Token: 0x060065F3 RID: 26099 RVA: 0x00143E4F File Offset: 0x0014204F
	public int LeftCount { get; set; }

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x060065F4 RID: 26100 RVA: 0x00143E58 File Offset: 0x00142058
	// (set) Token: 0x060065F5 RID: 26101 RVA: 0x00143E60 File Offset: 0x00142060
	public bool IsLock { get; set; }

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x060065F6 RID: 26102 RVA: 0x00143E69 File Offset: 0x00142069
	// (set) Token: 0x060065F7 RID: 26103 RVA: 0x00143E71 File Offset: 0x00142071
	public bool IsCheck { get; set; }
}
