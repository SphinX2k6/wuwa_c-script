using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017AE RID: 6062
[NullableContext(1)]
public interface IMusicSortViewOpenParams
{
	// Token: 0x1700167D RID: 5757
	// (get) Token: 0x0600EC69 RID: 60521
	// (set) Token: 0x0600EC6A RID: 60522
	IReadOnlyList<int> MusicList { get; set; }

	// Token: 0x1700167E RID: 5758
	// (get) Token: 0x0600EC6B RID: 60523
	// (set) Token: 0x0600EC6C RID: 60524
	Action<List<int>> OnCallback { get; set; }
}
