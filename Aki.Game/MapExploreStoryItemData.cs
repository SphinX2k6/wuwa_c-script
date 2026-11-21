using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F68 RID: 3944
[NullableContext(2)]
[Nullable(0)]
public class MapExploreStoryItemData : IMapExploreStoryItemData
{
	// Token: 0x170010D0 RID: 4304
	// (get) Token: 0x06009E3A RID: 40506 RVA: 0x002EC9F8 File Offset: 0x002EABF8
	// (set) Token: 0x06009E3B RID: 40507 RVA: 0x002ECA00 File Offset: 0x002EAC00
	public bool IsOpen { get; set; }

	// Token: 0x170010D1 RID: 4305
	// (get) Token: 0x06009E3C RID: 40508 RVA: 0x002ECA09 File Offset: 0x002EAC09
	// (set) Token: 0x06009E3D RID: 40509 RVA: 0x002ECA11 File Offset: 0x002EAC11
	public string StoryContent { get; set; }

	// Token: 0x170010D2 RID: 4306
	// (get) Token: 0x06009E3E RID: 40510 RVA: 0x002ECA1A File Offset: 0x002EAC1A
	// (set) Token: 0x06009E3F RID: 40511 RVA: 0x002ECA22 File Offset: 0x002EAC22
	public string StoryTitle { get; set; }

	// Token: 0x170010D3 RID: 4307
	// (get) Token: 0x06009E40 RID: 40512 RVA: 0x002ECA2B File Offset: 0x002EAC2B
	// (set) Token: 0x06009E41 RID: 40513 RVA: 0x002ECA33 File Offset: 0x002EAC33
	public string LockedDesc { get; set; }

	// Token: 0x170010D4 RID: 4308
	// (get) Token: 0x06009E42 RID: 40514 RVA: 0x002ECA3C File Offset: 0x002EAC3C
	// (set) Token: 0x06009E43 RID: 40515 RVA: 0x002ECA44 File Offset: 0x002EAC44
	public bool? IsNewOpen { get; set; }
}
