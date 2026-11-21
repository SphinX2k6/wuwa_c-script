using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017AD RID: 6061
[NullableContext(1)]
[Nullable(0)]
public class MusicSortViewOpenParams : IMusicSortViewOpenParams
{
	// Token: 0x1700167B RID: 5755
	// (get) Token: 0x0600EC64 RID: 60516 RVA: 0x00456D1A File Offset: 0x00454F1A
	// (set) Token: 0x0600EC65 RID: 60517 RVA: 0x00456D22 File Offset: 0x00454F22
	public IReadOnlyList<int> MusicList { get; set; } = new List<int>();

	// Token: 0x1700167C RID: 5756
	// (get) Token: 0x0600EC66 RID: 60518 RVA: 0x00456D2B File Offset: 0x00454F2B
	// (set) Token: 0x0600EC67 RID: 60519 RVA: 0x00456D33 File Offset: 0x00454F33
	public Action<List<int>> OnCallback { get; set; }
}
