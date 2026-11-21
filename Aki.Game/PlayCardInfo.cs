using System;
using System.Runtime.CompilerServices;

// Token: 0x0200050E RID: 1294
[NullableContext(1)]
[Nullable(0)]
public class PlayCardInfo : IPlayCardInfo
{
	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x06003ECB RID: 16075 RVA: 0x00161A69 File Offset: 0x0015FC69
	// (set) Token: 0x06003ECC RID: 16076 RVA: 0x00161A71 File Offset: 0x0015FC71
	public int Value { get; set; }

	// Token: 0x170008CC RID: 2252
	// (get) Token: 0x06003ECD RID: 16077 RVA: 0x00161A7A File Offset: 0x0015FC7A
	// (set) Token: 0x06003ECE RID: 16078 RVA: 0x00161A82 File Offset: 0x0015FC82
	public int[] CardIdList { get; set; } = Array.Empty<int>();
}
