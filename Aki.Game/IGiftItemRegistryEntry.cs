using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200187A RID: 6266
[NullableContext(1)]
[Nullable(0)]
public class IGiftItemRegistryEntry
{
	// Token: 0x170017D9 RID: 6105
	// (get) Token: 0x0600F82B RID: 63531 RVA: 0x00489D43 File Offset: 0x00487F43
	// (set) Token: 0x0600F82C RID: 63532 RVA: 0x00489D4B File Offset: 0x00487F4B
	public Func<PayShopGoods, bool> Check { get; set; }

	// Token: 0x170017DA RID: 6106
	// (get) Token: 0x0600F82D RID: 63533 RVA: 0x00489D54 File Offset: 0x00487F54
	// (set) Token: 0x0600F82E RID: 63534 RVA: 0x00489D5C File Offset: 0x00487F5C
	public string Resource { get; set; }

	// Token: 0x170017DB RID: 6107
	// (get) Token: 0x0600F82F RID: 63535 RVA: 0x00489D65 File Offset: 0x00487F65
	// (set) Token: 0x0600F830 RID: 63536 RVA: 0x00489D6D File Offset: 0x00487F6D
	public Func<IGiftDisplayItem> Create { get; set; }
}
