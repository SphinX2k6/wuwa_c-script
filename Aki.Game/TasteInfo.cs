using System;
using System.Runtime.CompilerServices;

// Token: 0x02000414 RID: 1044
[NullableContext(1)]
[Nullable(0)]
public class TasteInfo : ITasteInfo
{
	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x06003846 RID: 14406 RVA: 0x00147A58 File Offset: 0x00145C58
	// (set) Token: 0x06003847 RID: 14407 RVA: 0x00147A60 File Offset: 0x00145C60
	public EDrinksFlavorType Type { get; set; }

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x06003848 RID: 14408 RVA: 0x00147A69 File Offset: 0x00145C69
	// (set) Token: 0x06003849 RID: 14409 RVA: 0x00147A71 File Offset: 0x00145C71
	public string Key { get; set; } = "";

	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x0600384A RID: 14410 RVA: 0x00147A7A File Offset: 0x00145C7A
	// (set) Token: 0x0600384B RID: 14411 RVA: 0x00147A82 File Offset: 0x00145C82
	public string[] Value { get; set; } = Array.Empty<string>();
}
