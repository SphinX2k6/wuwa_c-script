using System;
using System.Runtime.CompilerServices;

// Token: 0x0200188C RID: 6284
[NullableContext(1)]
[Nullable(0)]
public class WeekScoreData : IWeekScoreData
{
	// Token: 0x170017F0 RID: 6128
	// (get) Token: 0x0600F8B9 RID: 63673 RVA: 0x0048BC8E File Offset: 0x00489E8E
	// (set) Token: 0x0600F8BA RID: 63674 RVA: 0x0048BC96 File Offset: 0x00489E96
	public string Tips { get; set; }

	// Token: 0x170017F1 RID: 6129
	// (get) Token: 0x0600F8BB RID: 63675 RVA: 0x0048BC9F File Offset: 0x00489E9F
	// (set) Token: 0x0600F8BC RID: 63676 RVA: 0x0048BCA7 File Offset: 0x00489EA7
	public string IconPath { get; set; }

	// Token: 0x170017F2 RID: 6130
	// (get) Token: 0x0600F8BD RID: 63677 RVA: 0x0048BCB0 File Offset: 0x00489EB0
	// (set) Token: 0x0600F8BE RID: 63678 RVA: 0x0048BCB8 File Offset: 0x00489EB8
	public int Count { get; set; }
}
