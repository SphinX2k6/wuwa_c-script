using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FC6 RID: 8134
[NullableContext(1)]
[Nullable(0)]
public class FlySkinGetWayData : IFlySkinGetWayData
{
	// Token: 0x17001E43 RID: 7747
	// (get) Token: 0x06014303 RID: 82691 RVA: 0x005E3962 File Offset: 0x005E1B62
	// (set) Token: 0x06014304 RID: 82692 RVA: 0x005E396A File Offset: 0x005E1B6A
	public int Id { get; set; }

	// Token: 0x17001E44 RID: 7748
	// (get) Token: 0x06014305 RID: 82693 RVA: 0x005E3973 File Offset: 0x005E1B73
	// (set) Token: 0x06014306 RID: 82694 RVA: 0x005E397B File Offset: 0x005E1B7B
	public int ConfigId { get; set; }

	// Token: 0x17001E45 RID: 7749
	// (get) Token: 0x06014307 RID: 82695 RVA: 0x005E3984 File Offset: 0x005E1B84
	// (set) Token: 0x06014308 RID: 82696 RVA: 0x005E398C File Offset: 0x005E1B8C
	public EFlySkinGetWayType Type { get; set; }

	// Token: 0x17001E46 RID: 7750
	// (get) Token: 0x06014309 RID: 82697 RVA: 0x005E3995 File Offset: 0x005E1B95
	// (set) Token: 0x0601430A RID: 82698 RVA: 0x005E399D File Offset: 0x005E1B9D
	public string Text { get; set; }

	// Token: 0x17001E47 RID: 7751
	// (get) Token: 0x0601430B RID: 82699 RVA: 0x005E39A6 File Offset: 0x005E1BA6
	// (set) Token: 0x0601430C RID: 82700 RVA: 0x005E39AE File Offset: 0x005E1BAE
	public int SortIndex { get; set; }
}
