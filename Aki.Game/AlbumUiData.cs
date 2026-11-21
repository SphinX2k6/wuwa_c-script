using System;
using Aki.Config;

// Token: 0x020017A8 RID: 6056
public class AlbumUiData : IAlbumUiData
{
	// Token: 0x17001672 RID: 5746
	// (get) Token: 0x0600EC37 RID: 60471 RVA: 0x0045611C File Offset: 0x0045431C
	// (set) Token: 0x0600EC38 RID: 60472 RVA: 0x00456124 File Offset: 0x00454324
	public int Id { get; set; }

	// Token: 0x17001673 RID: 5747
	// (get) Token: 0x0600EC39 RID: 60473 RVA: 0x0045612D File Offset: 0x0045432D
	// (set) Token: 0x0600EC3A RID: 60474 RVA: 0x00456135 File Offset: 0x00454335
	public PhonographAlbum Config { get; set; }

	// Token: 0x17001674 RID: 5748
	// (get) Token: 0x0600EC3B RID: 60475 RVA: 0x0045613E File Offset: 0x0045433E
	// (set) Token: 0x0600EC3C RID: 60476 RVA: 0x00456146 File Offset: 0x00454346
	public int UnlockMusicNum { get; set; }

	// Token: 0x17001675 RID: 5749
	// (get) Token: 0x0600EC3D RID: 60477 RVA: 0x0045614F File Offset: 0x0045434F
	// (set) Token: 0x0600EC3E RID: 60478 RVA: 0x00456157 File Offset: 0x00454357
	public int AllMusicNum { get; set; }

	// Token: 0x17001676 RID: 5750
	// (get) Token: 0x0600EC3F RID: 60479 RVA: 0x00456160 File Offset: 0x00454360
	// (set) Token: 0x0600EC40 RID: 60480 RVA: 0x00456168 File Offset: 0x00454368
	public bool? IsSelected { get; set; }
}
