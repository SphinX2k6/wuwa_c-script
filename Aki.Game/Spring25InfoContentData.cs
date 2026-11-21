using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020009CF RID: 2511
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class Spring25InfoContentData
{
	// Token: 0x06006DE6 RID: 28134 RVA: 0x0021F1EF File Offset: 0x0021D3EF
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public Spring25InfoContentData()
	{
	}

	// Token: 0x04004462 RID: 17506
	[RequiredMember]
	public int TaskId;

	// Token: 0x04004463 RID: 17507
	[RequiredMember]
	public ActivityTaskState State;

	// Token: 0x04004464 RID: 17508
	[RequiredMember]
	public string NameTextId;

	// Token: 0x04004465 RID: 17509
	[RequiredMember]
	public string SubtitleTextId;

	// Token: 0x04004466 RID: 17510
	[RequiredMember]
	public List<string> SubtitleTextArgs;

	// Token: 0x04004467 RID: 17511
	[RequiredMember]
	public List<TItem> ItemList;

	// Token: 0x04004468 RID: 17512
	[RequiredMember]
	public bool IsDone;

	// Token: 0x04004469 RID: 17513
	[RequiredMember]
	public bool CanReward;

	// Token: 0x0400446A RID: 17514
	[Nullable(2)]
	public string RightTextId;
}
