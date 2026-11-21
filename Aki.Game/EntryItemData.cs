using System;
using System.Runtime.CompilerServices;

// Token: 0x0200208A RID: 8330
[NullableContext(1)]
[Nullable(0)]
public class EntryItemData : IEntryItemData
{
	// Token: 0x17001EF1 RID: 7921
	// (get) Token: 0x060148BD RID: 84157 RVA: 0x005FCD86 File Offset: 0x005FAF86
	// (set) Token: 0x060148BE RID: 84158 RVA: 0x005FCD8E File Offset: 0x005FAF8E
	public string Text { get; set; } = "";

	// Token: 0x17001EF2 RID: 7922
	// (get) Token: 0x060148BF RID: 84159 RVA: 0x005FCD97 File Offset: 0x005FAF97
	// (set) Token: 0x060148C0 RID: 84160 RVA: 0x005FCD9F File Offset: 0x005FAF9F
	public string[] Args { get; set; } = Array.Empty<string>();

	// Token: 0x17001EF3 RID: 7923
	// (get) Token: 0x060148C1 RID: 84161 RVA: 0x005FCDA8 File Offset: 0x005FAFA8
	// (set) Token: 0x060148C2 RID: 84162 RVA: 0x005FCDB0 File Offset: 0x005FAFB0
	public string Color { get; set; } = "";
}
