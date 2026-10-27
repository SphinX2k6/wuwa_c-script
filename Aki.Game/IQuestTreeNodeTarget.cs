using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002691 RID: 9873
[NullableContext(2)]
public interface IQuestTreeNodeTarget
{
	// Token: 0x17001A19 RID: 6681
	// (get) Token: 0x060143D2 RID: 82898
	// (set) Token: 0x060143D3 RID: 82899
	EQuestTreeNodeTargetType Type { get; set; }

	// Token: 0x17001A1A RID: 6682
	// (get) Token: 0x060143D4 RID: 82900
	// (set) Token: 0x060143D5 RID: 82901
	string Text { get; set; }

	// Token: 0x17001A1B RID: 6683
	// (get) Token: 0x060143D6 RID: 82902
	// (set) Token: 0x060143D7 RID: 82903
	string TextKey { get; set; }

	// Token: 0x17001A1C RID: 6684
	// (get) Token: 0x060143D8 RID: 82904
	// (set) Token: 0x060143D9 RID: 82905
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

	// Token: 0x17001A1D RID: 6685
	// (get) Token: 0x060143DA RID: 82906
	// (set) Token: 0x060143DB RID: 82907
	bool? IsFinished { get; set; }

	// Token: 0x17001A1E RID: 6686
	// (get) Token: 0x060143DC RID: 82908
	// (set) Token: 0x060143DD RID: 82909
	int? HelpId { get; set; }

	// Token: 0x17001A1F RID: 6687
	// (get) Token: 0x060143DE RID: 82910
	// (set) Token: 0x060143DF RID: 82911
	int? GotoId { get; set; }

	// Token: 0x17001A20 RID: 6688
	// (get) Token: 0x060143E0 RID: 82912
	// (set) Token: 0x060143E1 RID: 82913
	Action OnGoto { get; set; }
}
