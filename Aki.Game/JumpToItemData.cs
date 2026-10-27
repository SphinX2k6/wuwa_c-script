using System;

// Token: 0x02001170 RID: 4464
public class JumpToItemData : IJumpToItemData
{
	// Token: 0x17000A33 RID: 2611
	// (get) Token: 0x060075D6 RID: 30166 RVA: 0x00185C7E File Offset: 0x00183E7E
	// (set) Token: 0x060075D7 RID: 30167 RVA: 0x00185C86 File Offset: 0x00183E86
	public int LevelId { get; set; }

	// Token: 0x17000A34 RID: 2612
	// (get) Token: 0x060075D8 RID: 30168 RVA: 0x00185C8F File Offset: 0x00183E8F
	// (set) Token: 0x060075D9 RID: 30169 RVA: 0x00185C97 File Offset: 0x00183E97
	public bool Done { get; set; }

	// Token: 0x17000A35 RID: 2613
	// (get) Token: 0x060075DA RID: 30170 RVA: 0x00185CA0 File Offset: 0x00183EA0
	// (set) Token: 0x060075DB RID: 30171 RVA: 0x00185CA8 File Offset: 0x00183EA8
	public bool IsUnlock { get; set; }

	// Token: 0x17000A36 RID: 2614
	// (get) Token: 0x060075DC RID: 30172 RVA: 0x00185CB1 File Offset: 0x00183EB1
	// (set) Token: 0x060075DD RID: 30173 RVA: 0x00185CB9 File Offset: 0x00183EB9
	public int StarNumber { get; set; }
}
