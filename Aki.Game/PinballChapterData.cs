using System;
using System.Runtime.CompilerServices;

// Token: 0x020013E0 RID: 5088
public class PinballChapterData
{
	// Token: 0x04003F80 RID: 16256
	public int ChapterId;

	// Token: 0x04003F81 RID: 16257
	public int PreChapterId;

	// Token: 0x04003F82 RID: 16258
	public int UnlockTime;

	// Token: 0x04003F83 RID: 16259
	[Nullable(1)]
	public int[] LevelIds = Array.Empty<int>();
}
