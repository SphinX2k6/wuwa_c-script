using System;
using System.Runtime.CompilerServices;

// Token: 0x020008B9 RID: 2233
[NullableContext(2)]
public interface IPinballItemDataRole
{
	// Token: 0x17000C63 RID: 3171
	// (get) Token: 0x0600645B RID: 25691
	// (set) Token: 0x0600645C RID: 25692
	EPinballItemType Type { get; set; }

	// Token: 0x17000C64 RID: 3172
	// (get) Token: 0x0600645D RID: 25693
	// (set) Token: 0x0600645E RID: 25694
	int Id { get; set; }

	// Token: 0x17000C65 RID: 3173
	// (get) Token: 0x0600645F RID: 25695
	// (set) Token: 0x06006460 RID: 25696
	bool? IsRecommend { get; set; }

	// Token: 0x17000C66 RID: 3174
	// (get) Token: 0x06006461 RID: 25697
	// (set) Token: 0x06006462 RID: 25698
	int? BdId { get; set; }

	// Token: 0x17000C67 RID: 3175
	// (get) Token: 0x06006463 RID: 25699
	// (set) Token: 0x06006464 RID: 25700
	bool? IsLocked { get; set; }

	// Token: 0x17000C68 RID: 3176
	// (get) Token: 0x06006465 RID: 25701
	// (set) Token: 0x06006466 RID: 25702
	bool? IsUnavailable { get; set; }

	// Token: 0x17000C69 RID: 3177
	// (get) Token: 0x06006467 RID: 25703
	// (set) Token: 0x06006468 RID: 25704
	TableTextArgNew BottomText { get; set; }

	// Token: 0x17000C6A RID: 3178
	// (get) Token: 0x06006469 RID: 25705
	// (set) Token: 0x0600646A RID: 25706
	string BottomPlainText { get; set; }

	// Token: 0x17000C6B RID: 3179
	// (get) Token: 0x0600646B RID: 25707
	// (set) Token: 0x0600646C RID: 25708
	int? ClassId { get; set; }
}
