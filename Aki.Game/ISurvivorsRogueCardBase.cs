using System;
using System.Runtime.CompilerServices;

// Token: 0x02002108 RID: 8456
[NullableContext(2)]
public interface ISurvivorsRogueCardBase
{
	// Token: 0x17001F39 RID: 7993
	// (get) Token: 0x06014BC7 RID: 84935
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F3A RID: 7994
	// (get) Token: 0x06014BC8 RID: 84936
	int Id { get; }

	// Token: 0x17001F3B RID: 7995
	// (get) Token: 0x06014BC9 RID: 84937
	int? IncId { get; }

	// Token: 0x17001F3C RID: 7996
	// (get) Token: 0x06014BCA RID: 84938
	int Index { get; }

	// Token: 0x17001F3D RID: 7997
	// (get) Token: 0x06014BCB RID: 84939
	int QualityId { get; }

	// Token: 0x17001F3E RID: 7998
	// (get) Token: 0x06014BCC RID: 84940
	string TitleId { get; }

	// Token: 0x17001F3F RID: 7999
	// (get) Token: 0x06014BCD RID: 84941
	string TitleText { get; }

	// Token: 0x17001F40 RID: 8000
	// (get) Token: 0x06014BCE RID: 84942
	[Nullable(1)]
	string DescId { [NullableContext(1)] get; }

	// Token: 0x17001F41 RID: 8001
	// (get) Token: 0x06014BCF RID: 84943
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

	// Token: 0x17001F42 RID: 8002
	// (get) Token: 0x06014BD0 RID: 84944
	bool? TagVisible { get; }

	// Token: 0x17001F43 RID: 8003
	// (get) Token: 0x06014BD1 RID: 84945
	string TagId { get; }

	// Token: 0x17001F44 RID: 8004
	// (get) Token: 0x06014BD2 RID: 84946
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

	// Token: 0x17001F45 RID: 8005
	// (get) Token: 0x06014BD3 RID: 84947
	bool? UseToggle { get; }

	// Token: 0x17001F46 RID: 8006
	// (get) Token: 0x06014BD4 RID: 84948
	bool? IsLevelUp { get; }

	// Token: 0x17001F47 RID: 8007
	// (get) Token: 0x06014BD5 RID: 84949
	bool? NeedLock { get; }

	// Token: 0x17001F48 RID: 8008
	// (get) Token: 0x06014BD6 RID: 84950
	bool? LockState { get; }

	// Token: 0x17001F49 RID: 8009
	// (get) Token: 0x06014BD7 RID: 84951
	int? Cost { get; }

	// Token: 0x17001F4A RID: 8010
	// (get) Token: 0x06014BD8 RID: 84952
	bool? CostEnoughCheck { get; }
}
