using System;

// Token: 0x020010EF RID: 4335
public class ArtemisDayItemData : IArtemisDayItemData
{
	// Token: 0x1700098C RID: 2444
	// (get) Token: 0x06007101 RID: 28929 RVA: 0x00171305 File Offset: 0x0016F505
	// (set) Token: 0x06007102 RID: 28930 RVA: 0x0017130D File Offset: 0x0016F50D
	public int Index { get; set; }

	// Token: 0x1700098D RID: 2445
	// (get) Token: 0x06007103 RID: 28931 RVA: 0x00171316 File Offset: 0x0016F516
	// (set) Token: 0x06007104 RID: 28932 RVA: 0x0017131E File Offset: 0x0016F51E
	public EArtemisState? State { get; set; }
}
