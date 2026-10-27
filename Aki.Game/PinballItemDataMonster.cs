using System;

// Token: 0x02001429 RID: 5161
public class PinballItemDataMonster : IPinballItemDataMonster
{
	// Token: 0x17000CAE RID: 3246
	// (get) Token: 0x060091A8 RID: 37288 RVA: 0x001F2FFC File Offset: 0x001F11FC
	// (set) Token: 0x060091A9 RID: 37289 RVA: 0x001F3004 File Offset: 0x001F1204
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CAF RID: 3247
	// (get) Token: 0x060091AA RID: 37290 RVA: 0x001F300D File Offset: 0x001F120D
	// (set) Token: 0x060091AB RID: 37291 RVA: 0x001F3015 File Offset: 0x001F1215
	public int Id { get; set; }
}
