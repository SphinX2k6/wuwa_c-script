using System;

// Token: 0x020017AB RID: 6059
public class MusicUiData : IMusicUiData
{
	// Token: 0x17001679 RID: 5753
	// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x0045687C File Offset: 0x00454A7C
	// (set) Token: 0x0600EC55 RID: 60501 RVA: 0x00456884 File Offset: 0x00454A84
	public int Id { get; set; }

	// Token: 0x1700167A RID: 5754
	// (get) Token: 0x0600EC56 RID: 60502 RVA: 0x0045688D File Offset: 0x00454A8D
	// (set) Token: 0x0600EC57 RID: 60503 RVA: 0x00456895 File Offset: 0x00454A95
	public bool? IsFavorite { get; set; }
}
