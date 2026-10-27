using System;

// Token: 0x02000F9D RID: 3997
public class FurnitureSlotContext : IFurnitureSlotContext
{
	// Token: 0x17000814 RID: 2068
	// (get) Token: 0x0600664C RID: 26188 RVA: 0x00144062 File Offset: 0x00142262
	// (set) Token: 0x0600664D RID: 26189 RVA: 0x0014406A File Offset: 0x0014226A
	public int SlotEntityId { get; set; }

	// Token: 0x17000815 RID: 2069
	// (get) Token: 0x0600664E RID: 26190 RVA: 0x00144073 File Offset: 0x00142273
	// (set) Token: 0x0600664F RID: 26191 RVA: 0x0014407B File Offset: 0x0014227B
	public int SubSlotIndex { get; set; }
}
