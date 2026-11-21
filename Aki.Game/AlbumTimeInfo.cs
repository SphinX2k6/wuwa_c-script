using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200179F RID: 6047
[NullableContext(1)]
[Nullable(0)]
public class AlbumTimeInfo : IAlbumTimeInfo
{
	// Token: 0x17001664 RID: 5732
	// (get) Token: 0x0600EB91 RID: 60305 RVA: 0x00452403 File Offset: 0x00450603
	// (set) Token: 0x0600EB92 RID: 60306 RVA: 0x0045240B File Offset: 0x0045060B
	public int AlbumId { get; set; }

	// Token: 0x17001665 RID: 5733
	// (get) Token: 0x0600EB93 RID: 60307 RVA: 0x00452414 File Offset: 0x00450614
	// (set) Token: 0x0600EB94 RID: 60308 RVA: 0x0045241C File Offset: 0x0045061C
	public long BeginTime { get; set; }

	// Token: 0x17001666 RID: 5734
	// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x00452425 File Offset: 0x00450625
	// (set) Token: 0x0600EB96 RID: 60310 RVA: 0x0045242D File Offset: 0x0045062D
	public long EndTime { get; set; }

	// Token: 0x17001667 RID: 5735
	// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x00452436 File Offset: 0x00450636
	// (set) Token: 0x0600EB98 RID: 60312 RVA: 0x0045243E File Offset: 0x0045063E
	public HashSet<int> MusicIds { get; set; } = new HashSet<int>();
}
