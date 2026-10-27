using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022BA RID: 8890
[NullableContext(1)]
public interface IAlbumTimeInfo
{
	// Token: 0x17001629 RID: 5673
	// (get) Token: 0x060116F1 RID: 71409
	// (set) Token: 0x060116F2 RID: 71410
	int AlbumId { get; set; }

	// Token: 0x1700162A RID: 5674
	// (get) Token: 0x060116F3 RID: 71411
	// (set) Token: 0x060116F4 RID: 71412
	long BeginTime { get; set; }

	// Token: 0x1700162B RID: 5675
	// (get) Token: 0x060116F5 RID: 71413
	// (set) Token: 0x060116F6 RID: 71414
	long EndTime { get; set; }

	// Token: 0x1700162C RID: 5676
	// (get) Token: 0x060116F7 RID: 71415
	// (set) Token: 0x060116F8 RID: 71416
	HashSet<int> MusicIds { get; set; }
}
