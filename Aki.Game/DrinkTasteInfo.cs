using System;

// Token: 0x02000407 RID: 1031
public class DrinkTasteInfo : IDrinkTasteInfo
{
	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x060037FB RID: 14331 RVA: 0x00145FD8 File Offset: 0x001441D8
	// (set) Token: 0x060037FC RID: 14332 RVA: 0x00145FE0 File Offset: 0x001441E0
	public EDrinksFlavorType Type { get; set; }

	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x060037FD RID: 14333 RVA: 0x00145FE9 File Offset: 0x001441E9
	// (set) Token: 0x060037FE RID: 14334 RVA: 0x00145FF1 File Offset: 0x001441F1
	public int Value { get; set; }
}
