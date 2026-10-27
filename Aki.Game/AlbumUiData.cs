using System;
using Aki.Config;

// Token: 0x020022C4 RID: 8900
public class AlbumUiData : IAlbumUiData
{
	// Token: 0x1700163B RID: 5691
	// (get) Token: 0x060117A0 RID: 71584 RVA: 0x004493F4 File Offset: 0x004475F4
	// (set) Token: 0x060117A1 RID: 71585 RVA: 0x004493FC File Offset: 0x004475FC
	public int Id { get; set; }

	// Token: 0x1700163C RID: 5692
	// (get) Token: 0x060117A2 RID: 71586 RVA: 0x00449405 File Offset: 0x00447605
	// (set) Token: 0x060117A3 RID: 71587 RVA: 0x0044940D File Offset: 0x0044760D
	public PhonographAlbum Config { get; set; }

	// Token: 0x1700163D RID: 5693
	// (get) Token: 0x060117A4 RID: 71588 RVA: 0x00449416 File Offset: 0x00447616
	// (set) Token: 0x060117A5 RID: 71589 RVA: 0x0044941E File Offset: 0x0044761E
	public int UnlockMusicNum { get; set; }

	// Token: 0x1700163E RID: 5694
	// (get) Token: 0x060117A6 RID: 71590 RVA: 0x00449427 File Offset: 0x00447627
	// (set) Token: 0x060117A7 RID: 71591 RVA: 0x0044942F File Offset: 0x0044762F
	public int AllMusicNum { get; set; }

	// Token: 0x1700163F RID: 5695
	// (get) Token: 0x060117A8 RID: 71592 RVA: 0x00449438 File Offset: 0x00447638
	// (set) Token: 0x060117A9 RID: 71593 RVA: 0x00449440 File Offset: 0x00447640
	public bool? IsSelected { get; set; }
}
