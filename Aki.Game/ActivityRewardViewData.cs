using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000562 RID: 1378
[NullableContext(1)]
[Nullable(0)]
public class ActivityRewardViewData : IActivityRewardViewData
{
	// Token: 0x1700096A RID: 2410
	// (get) Token: 0x060042BC RID: 17084 RVA: 0x00173EE1 File Offset: 0x001720E1
	// (set) Token: 0x060042BD RID: 17085 RVA: 0x00173EE9 File Offset: 0x001720E9
	public List<IActivityRewardDataPage> DataPageList { get; set; }

	// Token: 0x1700096B RID: 2411
	// (get) Token: 0x060042BE RID: 17086 RVA: 0x00173EF2 File Offset: 0x001720F2
	// (set) Token: 0x060042BF RID: 17087 RVA: 0x00173EFA File Offset: 0x001720FA
	public EActivityRewardSource Source { get; set; }

	// Token: 0x1700096C RID: 2412
	// (get) Token: 0x060042C0 RID: 17088 RVA: 0x00173F03 File Offset: 0x00172103
	// (set) Token: 0x060042C1 RID: 17089 RVA: 0x00173F0B File Offset: 0x0017210B
	[Nullable(2)]
	public string TitleTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
}
