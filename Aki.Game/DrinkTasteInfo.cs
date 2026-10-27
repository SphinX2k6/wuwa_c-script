using System;

// Token: 0x02000F52 RID: 3922
public class DrinkTasteInfo : IDrinkTasteInfo
{
	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06006463 RID: 25699 RVA: 0x0013D73C File Offset: 0x0013B93C
	// (set) Token: 0x06006464 RID: 25700 RVA: 0x0013D744 File Offset: 0x0013B944
	public EDrinksFlavorType Type { get; set; }

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x06006465 RID: 25701 RVA: 0x0013D74D File Offset: 0x0013B94D
	// (set) Token: 0x06006466 RID: 25702 RVA: 0x0013D755 File Offset: 0x0013B955
	public int Value { get; set; }
}
