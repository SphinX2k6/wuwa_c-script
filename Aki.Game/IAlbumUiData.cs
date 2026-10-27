using System;
using Aki.Config;

// Token: 0x020022C3 RID: 8899
public interface IAlbumUiData
{
	// Token: 0x17001636 RID: 5686
	// (get) Token: 0x06011796 RID: 71574
	// (set) Token: 0x06011797 RID: 71575
	int Id { get; set; }

	// Token: 0x17001637 RID: 5687
	// (get) Token: 0x06011798 RID: 71576
	// (set) Token: 0x06011799 RID: 71577
	PhonographAlbum Config { get; set; }

	// Token: 0x17001638 RID: 5688
	// (get) Token: 0x0601179A RID: 71578
	// (set) Token: 0x0601179B RID: 71579
	int UnlockMusicNum { get; set; }

	// Token: 0x17001639 RID: 5689
	// (get) Token: 0x0601179C RID: 71580
	// (set) Token: 0x0601179D RID: 71581
	int AllMusicNum { get; set; }

	// Token: 0x1700163A RID: 5690
	// (get) Token: 0x0601179E RID: 71582
	// (set) Token: 0x0601179F RID: 71583
	bool? IsSelected { get; set; }
}
