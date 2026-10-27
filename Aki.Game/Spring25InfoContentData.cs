using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001517 RID: 5399
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25InfoContentData
{
	// Token: 0x06009A08 RID: 39432 RVA: 0x00215453 File Offset: 0x00213653
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25InfoContentData()
	{
	}

	// Token: 0x040043BC RID: 17340
	[RequiredMember]
	public int TaskId;

	// Token: 0x040043BD RID: 17341
	[RequiredMember]
	public ActivityTaskState State;

	// Token: 0x040043BE RID: 17342
	[RequiredMember]
	public string NameTextId;

	// Token: 0x040043BF RID: 17343
	[RequiredMember]
	public string SubtitleTextId;

	// Token: 0x040043C0 RID: 17344
	[RequiredMember]
	public List<string> SubtitleTextArgs;

	// Token: 0x040043C1 RID: 17345
	[RequiredMember]
	public List<TItem> ItemList;

	// Token: 0x040043C2 RID: 17346
	[RequiredMember]
	public bool IsDone;

	// Token: 0x040043C3 RID: 17347
	[RequiredMember]
	public bool CanReward;

	// Token: 0x040043C4 RID: 17348
	[Nullable(2)]
	public string RightTextId;
}
