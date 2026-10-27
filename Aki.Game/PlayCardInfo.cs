using System;
using System.Runtime.CompilerServices;

// Token: 0x0200105A RID: 4186
[NullableContext(1)]
[Nullable(0)]
public class PlayCardInfo : IPlayCardInfo
{
	// Token: 0x170008AB RID: 2219
	// (get) Token: 0x06006B36 RID: 27446 RVA: 0x00159141 File Offset: 0x00157341
	// (set) Token: 0x06006B37 RID: 27447 RVA: 0x00159149 File Offset: 0x00157349
	public int Value { get; set; }

	// Token: 0x170008AC RID: 2220
	// (get) Token: 0x06006B38 RID: 27448 RVA: 0x00159152 File Offset: 0x00157352
	// (set) Token: 0x06006B39 RID: 27449 RVA: 0x0015915A File Offset: 0x0015735A
	public int[] CardIdList { get; set; } = Array.Empty<int>();
}
