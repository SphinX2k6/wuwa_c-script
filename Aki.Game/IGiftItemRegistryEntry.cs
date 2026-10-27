using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002395 RID: 9109
[NullableContext(1)]
[Nullable(0)]
public class IGiftItemRegistryEntry
{
	// Token: 0x1700179F RID: 6047
	// (get) Token: 0x06012379 RID: 74617 RVA: 0x0047C903 File Offset: 0x0047AB03
	// (set) Token: 0x0601237A RID: 74618 RVA: 0x0047C90B File Offset: 0x0047AB0B
	public Func<PayShopGoods, bool> Check { get; set; }

	// Token: 0x170017A0 RID: 6048
	// (get) Token: 0x0601237B RID: 74619 RVA: 0x0047C914 File Offset: 0x0047AB14
	// (set) Token: 0x0601237C RID: 74620 RVA: 0x0047C91C File Offset: 0x0047AB1C
	public string Resource { get; set; }

	// Token: 0x170017A1 RID: 6049
	// (get) Token: 0x0601237D RID: 74621 RVA: 0x0047C925 File Offset: 0x0047AB25
	// (set) Token: 0x0601237E RID: 74622 RVA: 0x0047C92D File Offset: 0x0047AB2D
	public Func<IGiftDisplayItem> Create { get; set; }
}
