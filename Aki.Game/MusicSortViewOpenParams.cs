using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022C9 RID: 8905
[NullableContext(1)]
[Nullable(0)]
public class MusicSortViewOpenParams : IMusicSortViewOpenParams
{
	// Token: 0x17001644 RID: 5700
	// (get) Token: 0x060117CD RID: 71629 RVA: 0x00449FF2 File Offset: 0x004481F2
	// (set) Token: 0x060117CE RID: 71630 RVA: 0x00449FFA File Offset: 0x004481FA
	public IReadOnlyList<int> MusicList { get; set; } = new List<int>();

	// Token: 0x17001645 RID: 5701
	// (get) Token: 0x060117CF RID: 71631 RVA: 0x0044A003 File Offset: 0x00448203
	// (set) Token: 0x060117D0 RID: 71632 RVA: 0x0044A00B File Offset: 0x0044820B
	public Action<List<int>> OnCallback { get; set; }
}
