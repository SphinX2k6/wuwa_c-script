using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200179E RID: 6046
[NullableContext(1)]
public interface IAlbumTimeInfo
{
	// Token: 0x17001660 RID: 5728
	// (get) Token: 0x0600EB89 RID: 60297
	// (set) Token: 0x0600EB8A RID: 60298
	int AlbumId { get; set; }

	// Token: 0x17001661 RID: 5729
	// (get) Token: 0x0600EB8B RID: 60299
	// (set) Token: 0x0600EB8C RID: 60300
	long BeginTime { get; set; }

	// Token: 0x17001662 RID: 5730
	// (get) Token: 0x0600EB8D RID: 60301
	// (set) Token: 0x0600EB8E RID: 60302
	long EndTime { get; set; }

	// Token: 0x17001663 RID: 5731
	// (get) Token: 0x0600EB8F RID: 60303
	// (set) Token: 0x0600EB90 RID: 60304
	HashSet<int> MusicIds { get; set; }
}
