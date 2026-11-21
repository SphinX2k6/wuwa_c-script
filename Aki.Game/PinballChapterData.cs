using System;
using System.Runtime.CompilerServices;

// Token: 0x02000894 RID: 2196
public class PinballChapterData
{
	// Token: 0x04004018 RID: 16408
	public int ChapterId;

	// Token: 0x04004019 RID: 16409
	public int PreChapterId;

	// Token: 0x0400401A RID: 16410
	public int UnlockTime;

	// Token: 0x0400401B RID: 16411
	[Nullable(1)]
	public int[] LevelIds = Array.Empty<int>();
}
