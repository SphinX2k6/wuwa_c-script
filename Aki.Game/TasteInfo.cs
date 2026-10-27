using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F5F RID: 3935
[NullableContext(1)]
[Nullable(0)]
public class TasteInfo : ITasteInfo
{
	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x060064AE RID: 25774 RVA: 0x0013F1BC File Offset: 0x0013D3BC
	// (set) Token: 0x060064AF RID: 25775 RVA: 0x0013F1C4 File Offset: 0x0013D3C4
	public EDrinksFlavorType Type { get; set; }

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x060064B0 RID: 25776 RVA: 0x0013F1CD File Offset: 0x0013D3CD
	// (set) Token: 0x060064B1 RID: 25777 RVA: 0x0013F1D5 File Offset: 0x0013D3D5
	public string Key { get; set; } = "";

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x060064B2 RID: 25778 RVA: 0x0013F1DE File Offset: 0x0013D3DE
	// (set) Token: 0x060064B3 RID: 25779 RVA: 0x0013F1E6 File Offset: 0x0013D3E6
	public string[] Value { get; set; } = Array.Empty<string>();
}
