using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B7C RID: 7036
[NullableContext(2)]
public interface IQuestTreeNodeTarget
{
	// Token: 0x17001A51 RID: 6737
	// (get) Token: 0x060118B4 RID: 71860
	// (set) Token: 0x060118B5 RID: 71861
	EQuestTreeNodeTargetType Type { get; set; }

	// Token: 0x17001A52 RID: 6738
	// (get) Token: 0x060118B6 RID: 71862
	// (set) Token: 0x060118B7 RID: 71863
	string Text { get; set; }

	// Token: 0x17001A53 RID: 6739
	// (get) Token: 0x060118B8 RID: 71864
	// (set) Token: 0x060118B9 RID: 71865
	string TextKey { get; set; }

	// Token: 0x17001A54 RID: 6740
	// (get) Token: 0x060118BA RID: 71866
	// (set) Token: 0x060118BB RID: 71867
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<object> TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001A55 RID: 6741
	// (get) Token: 0x060118BC RID: 71868
	// (set) Token: 0x060118BD RID: 71869
	bool? IsFinished { get; set; }

	// Token: 0x17001A56 RID: 6742
	// (get) Token: 0x060118BE RID: 71870
	// (set) Token: 0x060118BF RID: 71871
	int? HelpId { get; set; }

	// Token: 0x17001A57 RID: 6743
	// (get) Token: 0x060118C0 RID: 71872
	// (set) Token: 0x060118C1 RID: 71873
	int? GotoId { get; set; }

	// Token: 0x17001A58 RID: 6744
	// (get) Token: 0x060118C2 RID: 71874
	// (set) Token: 0x060118C3 RID: 71875
	Action OnGoto { get; set; }
}
