using System;
using System.Runtime.CompilerServices;

// Token: 0x020010A8 RID: 4264
[NullableContext(2)]
public interface IActivityRewardData
{
	// Token: 0x17000927 RID: 2343
	// (get) Token: 0x06006ED6 RID: 28374
	// (set) Token: 0x06006ED7 RID: 28375
	int? Id { get; set; }

	// Token: 0x17000928 RID: 2344
	// (get) Token: 0x06006ED8 RID: 28376
	// (set) Token: 0x06006ED9 RID: 28377
	[Nullable(1)]
	string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000929 RID: 2345
	// (get) Token: 0x06006EDA RID: 28378
	// (set) Token: 0x06006EDB RID: 28379
	string NameTextId { get; set; }

	// Token: 0x1700092A RID: 2346
	// (get) Token: 0x06006EDC RID: 28380
	// (set) Token: 0x06006EDD RID: 28381
	[Nullable(new byte[]
	{
		2,
		1
	})]
	string[] NameTextArgs { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700092B RID: 2347
	// (get) Token: 0x06006EDE RID: 28382
	// (set) Token: 0x06006EDF RID: 28383
	TItem[] RewardList { get; set; }

	// Token: 0x1700092C RID: 2348
	// (get) Token: 0x06006EE0 RID: 28384
	// (set) Token: 0x06006EE1 RID: 28385
	EActivityRewardState RewardState { get; set; }

	// Token: 0x1700092D RID: 2349
	// (get) Token: 0x06006EE2 RID: 28386
	// (set) Token: 0x06006EE3 RID: 28387
	string RewardButtonTextId { get; set; }

	// Token: 0x1700092E RID: 2350
	// (get) Token: 0x06006EE4 RID: 28388
	// (set) Token: 0x06006EE5 RID: 28389
	string RewardButtonText { get; set; }

	// Token: 0x1700092F RID: 2351
	// (get) Token: 0x06006EE6 RID: 28390
	// (set) Token: 0x06006EE7 RID: 28391
	bool? RewardButtonRedDot { get; set; }

	// Token: 0x17000930 RID: 2352
	// (get) Token: 0x06006EE8 RID: 28392
	// (set) Token: 0x06006EE9 RID: 28393
	Action ClickFunction { get; set; }

	// Token: 0x17000931 RID: 2353
	// (get) Token: 0x06006EEA RID: 28394
	// (set) Token: 0x06006EEB RID: 28395
	bool? ClickFunctionAndCloseSelf { get; set; }

	// Token: 0x17000932 RID: 2354
	// (get) Token: 0x06006EEC RID: 28396
	// (set) Token: 0x06006EED RID: 28397
	string ProgressText { get; set; }
}
