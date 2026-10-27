using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022CA RID: 8906
[NullableContext(1)]
public interface IMusicSortViewOpenParams
{
	// Token: 0x17001646 RID: 5702
	// (get) Token: 0x060117D2 RID: 71634
	// (set) Token: 0x060117D3 RID: 71635
	IReadOnlyList<int> MusicList { get; set; }

	// Token: 0x17001647 RID: 5703
	// (get) Token: 0x060117D4 RID: 71636
	// (set) Token: 0x060117D5 RID: 71637
	Action<List<int>> OnCallback { get; set; }
}
