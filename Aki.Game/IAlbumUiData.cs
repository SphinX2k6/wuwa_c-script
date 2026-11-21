using System;
using Aki.Config;

// Token: 0x020017A7 RID: 6055
public interface IAlbumUiData
{
	// Token: 0x1700166D RID: 5741
	// (get) Token: 0x0600EC2D RID: 60461
	// (set) Token: 0x0600EC2E RID: 60462
	int Id { get; set; }

	// Token: 0x1700166E RID: 5742
	// (get) Token: 0x0600EC2F RID: 60463
	// (set) Token: 0x0600EC30 RID: 60464
	PhonographAlbum Config { get; set; }

	// Token: 0x1700166F RID: 5743
	// (get) Token: 0x0600EC31 RID: 60465
	// (set) Token: 0x0600EC32 RID: 60466
	int UnlockMusicNum { get; set; }

	// Token: 0x17001670 RID: 5744
	// (get) Token: 0x0600EC33 RID: 60467
	// (set) Token: 0x0600EC34 RID: 60468
	int AllMusicNum { get; set; }

	// Token: 0x17001671 RID: 5745
	// (get) Token: 0x0600EC35 RID: 60469
	// (set) Token: 0x0600EC36 RID: 60470
	bool? IsSelected { get; set; }
}
