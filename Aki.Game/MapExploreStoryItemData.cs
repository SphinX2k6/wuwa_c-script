using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA9 RID: 6825
[NullableContext(2)]
[Nullable(0)]
public class MapExploreStoryItemData : IMapExploreStoryItemData
{
	// Token: 0x170010AB RID: 4267
	// (get) Token: 0x0600CA29 RID: 51753 RVA: 0x002E18A8 File Offset: 0x002DFAA8
	// (set) Token: 0x0600CA2A RID: 51754 RVA: 0x002E18B0 File Offset: 0x002DFAB0
	public bool IsOpen { get; set; }

	// Token: 0x170010AC RID: 4268
	// (get) Token: 0x0600CA2B RID: 51755 RVA: 0x002E18B9 File Offset: 0x002DFAB9
	// (set) Token: 0x0600CA2C RID: 51756 RVA: 0x002E18C1 File Offset: 0x002DFAC1
	public string StoryContent { get; set; }

	// Token: 0x170010AD RID: 4269
	// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x002E18CA File Offset: 0x002DFACA
	// (set) Token: 0x0600CA2E RID: 51758 RVA: 0x002E18D2 File Offset: 0x002DFAD2
	public string StoryTitle { get; set; }

	// Token: 0x170010AE RID: 4270
	// (get) Token: 0x0600CA2F RID: 51759 RVA: 0x002E18DB File Offset: 0x002DFADB
	// (set) Token: 0x0600CA30 RID: 51760 RVA: 0x002E18E3 File Offset: 0x002DFAE3
	public string LockedDesc { get; set; }

	// Token: 0x170010AF RID: 4271
	// (get) Token: 0x0600CA31 RID: 51761 RVA: 0x002E18EC File Offset: 0x002DFAEC
	// (set) Token: 0x0600CA32 RID: 51762 RVA: 0x002E18F4 File Offset: 0x002DFAF4
	public bool? IsNewOpen { get; set; }
}
