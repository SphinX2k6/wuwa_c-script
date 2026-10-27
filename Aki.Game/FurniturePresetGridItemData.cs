using System;
using Aki.Config;

// Token: 0x02000FDF RID: 4063
public class FurniturePresetGridItemData : IFurniturePresetGridItemData
{
	// Token: 0x17000876 RID: 2166
	// (get) Token: 0x0600685A RID: 26714 RVA: 0x0014B7A0 File Offset: 0x001499A0
	// (set) Token: 0x0600685B RID: 26715 RVA: 0x0014B7A8 File Offset: 0x001499A8
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x17000877 RID: 2167
	// (get) Token: 0x0600685C RID: 26716 RVA: 0x0014B7B1 File Offset: 0x001499B1
	// (set) Token: 0x0600685D RID: 26717 RVA: 0x0014B7B9 File Offset: 0x001499B9
	public bool IsLock { get; set; }

	// Token: 0x17000878 RID: 2168
	// (get) Token: 0x0600685E RID: 26718 RVA: 0x0014B7C2 File Offset: 0x001499C2
	// (set) Token: 0x0600685F RID: 26719 RVA: 0x0014B7CA File Offset: 0x001499CA
	public bool IsFinished { get; set; }
}
