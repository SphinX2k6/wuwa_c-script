using System;

// Token: 0x02000564 RID: 1380
public class ItemGridData : IItemGridData
{
	// Token: 0x1700096F RID: 2415
	// (get) Token: 0x060042C7 RID: 17095 RVA: 0x00173F1C File Offset: 0x0017211C
	// (set) Token: 0x060042C8 RID: 17096 RVA: 0x00173F24 File Offset: 0x00172124
	public TItem Item { get; set; }

	// Token: 0x17000970 RID: 2416
	// (get) Token: 0x060042C9 RID: 17097 RVA: 0x00173F2D File Offset: 0x0017212D
	// (set) Token: 0x060042CA RID: 17098 RVA: 0x00173F35 File Offset: 0x00172135
	public bool HasClaimed { get; set; }
}
