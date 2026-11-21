using System;

// Token: 0x02001FCF RID: 8143
public class UpdateViewContext
{
	// Token: 0x17001E4A RID: 7754
	// (get) Token: 0x0601436E RID: 82798 RVA: 0x005E550A File Offset: 0x005E370A
	// (set) Token: 0x0601436F RID: 82799 RVA: 0x005E5512 File Offset: 0x005E3712
	public EFlySkinTab Tab { get; set; }

	// Token: 0x17001E4B RID: 7755
	// (get) Token: 0x06014370 RID: 82800 RVA: 0x005E551B File Offset: 0x005E371B
	// (set) Token: 0x06014371 RID: 82801 RVA: 0x005E5523 File Offset: 0x005E3723
	public int SelectedSkinId { get; set; }

	// Token: 0x17001E4C RID: 7756
	// (get) Token: 0x06014372 RID: 82802 RVA: 0x005E552C File Offset: 0x005E372C
	// (set) Token: 0x06014373 RID: 82803 RVA: 0x005E5534 File Offset: 0x005E3734
	public bool UiShowState { get; set; }

	// Token: 0x17001E4D RID: 7757
	// (get) Token: 0x06014374 RID: 82804 RVA: 0x005E553D File Offset: 0x005E373D
	// (set) Token: 0x06014375 RID: 82805 RVA: 0x005E5545 File Offset: 0x005E3745
	public bool IsApplyToAll { get; set; }
}
