using System;
using System.Runtime.CompilerServices;

// Token: 0x02001664 RID: 5732
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsInfoItemData : IWuWuLogisticsInfoItemData
{
	// Token: 0x17000D9E RID: 3486
	// (get) Token: 0x0600A196 RID: 41366 RVA: 0x0023A7F5 File Offset: 0x002389F5
	// (set) Token: 0x0600A197 RID: 41367 RVA: 0x0023A7FD File Offset: 0x002389FD
	public int CfgId { get; set; }

	// Token: 0x17000D9F RID: 3487
	// (get) Token: 0x0600A198 RID: 41368 RVA: 0x0023A806 File Offset: 0x00238A06
	// (set) Token: 0x0600A199 RID: 41369 RVA: 0x0023A80E File Offset: 0x00238A0E
	public bool IsToday { get; set; }

	// Token: 0x17000DA0 RID: 3488
	// (get) Token: 0x0600A19A RID: 41370 RVA: 0x0023A817 File Offset: 0x00238A17
	// (set) Token: 0x0600A19B RID: 41371 RVA: 0x0023A81F File Offset: 0x00238A1F
	public string Content { get; set; }
}
