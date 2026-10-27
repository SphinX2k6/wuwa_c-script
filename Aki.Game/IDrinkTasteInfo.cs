using System;

// Token: 0x02000F51 RID: 3921
public interface IDrinkTasteInfo
{
	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x0600645F RID: 25695
	// (set) Token: 0x06006460 RID: 25696
	EDrinksFlavorType Type { get; set; }

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06006461 RID: 25697
	// (set) Token: 0x06006462 RID: 25698
	int Value { get; set; }
}
