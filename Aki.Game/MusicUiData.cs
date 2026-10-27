using System;

// Token: 0x020022C7 RID: 8903
public class MusicUiData : IMusicUiData
{
	// Token: 0x17001642 RID: 5698
	// (get) Token: 0x060117BD RID: 71613 RVA: 0x00449B54 File Offset: 0x00447D54
	// (set) Token: 0x060117BE RID: 71614 RVA: 0x00449B5C File Offset: 0x00447D5C
	public int Id { get; set; }

	// Token: 0x17001643 RID: 5699
	// (get) Token: 0x060117BF RID: 71615 RVA: 0x00449B65 File Offset: 0x00447D65
	// (set) Token: 0x060117C0 RID: 71616 RVA: 0x00449B6D File Offset: 0x00447D6D
	public bool? IsFavorite { get; set; }
}
