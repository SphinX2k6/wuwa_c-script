using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F6A RID: 3946
[NullableContext(1)]
[Nullable(0)]
public class MapAreaOnlyShowItemData : IMapAreaOnlyShowItemData
{
	// Token: 0x170010D8 RID: 4312
	// (get) Token: 0x06009E4B RID: 40523 RVA: 0x002ECA55 File Offset: 0x002EAC55
	// (set) Token: 0x06009E4C RID: 40524 RVA: 0x002ECA5D File Offset: 0x002EAC5D
	public string IconPath { get; set; }

	// Token: 0x170010D9 RID: 4313
	// (get) Token: 0x06009E4D RID: 40525 RVA: 0x002ECA66 File Offset: 0x002EAC66
	// (set) Token: 0x06009E4E RID: 40526 RVA: 0x002ECA6E File Offset: 0x002EAC6E
	public int OpenCount { get; set; }

	// Token: 0x170010DA RID: 4314
	// (get) Token: 0x06009E4F RID: 40527 RVA: 0x002ECA77 File Offset: 0x002EAC77
	// (set) Token: 0x06009E50 RID: 40528 RVA: 0x002ECA7F File Offset: 0x002EAC7F
	public int NewOpenCount { get; set; }
}
