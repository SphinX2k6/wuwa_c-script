using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B8C RID: 11148
[NullableContext(2)]
public interface ISurvivorsRogueCardBase
{
	// Token: 0x17001EE1 RID: 7905
	// (get) Token: 0x06017196 RID: 94614
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001EE2 RID: 7906
	// (get) Token: 0x06017197 RID: 94615
	int Id { get; }

	// Token: 0x17001EE3 RID: 7907
	// (get) Token: 0x06017198 RID: 94616
	int? IncId { get; }

	// Token: 0x17001EE4 RID: 7908
	// (get) Token: 0x06017199 RID: 94617
	int Index { get; }

	// Token: 0x17001EE5 RID: 7909
	// (get) Token: 0x0601719A RID: 94618
	int QualityId { get; }

	// Token: 0x17001EE6 RID: 7910
	// (get) Token: 0x0601719B RID: 94619
	string TitleId { get; }

	// Token: 0x17001EE7 RID: 7911
	// (get) Token: 0x0601719C RID: 94620
	string TitleText { get; }

	// Token: 0x17001EE8 RID: 7912
	// (get) Token: 0x0601719D RID: 94621
	[Nullable(1)]
	string DescId { [NullableContext(1)] get; }

	// Token: 0x17001EE9 RID: 7913
	// (get) Token: 0x0601719E RID: 94622
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] DescParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x17001EEA RID: 7914
	// (get) Token: 0x0601719F RID: 94623
	bool? TagVisible { get; }

	// Token: 0x17001EEB RID: 7915
	// (get) Token: 0x060171A0 RID: 94624
	string TagId { get; }

	// Token: 0x17001EEC RID: 7916
	// (get) Token: 0x060171A1 RID: 94625
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] TagParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x17001EED RID: 7917
	// (get) Token: 0x060171A2 RID: 94626
	bool? UseToggle { get; }

	// Token: 0x17001EEE RID: 7918
	// (get) Token: 0x060171A3 RID: 94627
	bool? IsLevelUp { get; }

	// Token: 0x17001EEF RID: 7919
	// (get) Token: 0x060171A4 RID: 94628
	bool? NeedLock { get; }

	// Token: 0x17001EF0 RID: 7920
	// (get) Token: 0x060171A5 RID: 94629
	bool? LockState { get; }

	// Token: 0x17001EF1 RID: 7921
	// (get) Token: 0x060171A6 RID: 94630
	int? Cost { get; }

	// Token: 0x17001EF2 RID: 7922
	// (get) Token: 0x060171A7 RID: 94631
	bool? CostEnoughCheck { get; }
}
