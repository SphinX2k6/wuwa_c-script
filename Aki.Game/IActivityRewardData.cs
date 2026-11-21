using System;
using System.Runtime.CompilerServices;

// Token: 0x0200055C RID: 1372
[NullableContext(2)]
public interface IActivityRewardData
{
	// Token: 0x17000947 RID: 2375
	// (get) Token: 0x0600426C RID: 17004
	// (set) Token: 0x0600426D RID: 17005
	int? Id { get; set; }

	// Token: 0x17000948 RID: 2376
	// (get) Token: 0x0600426E RID: 17006
	// (set) Token: 0x0600426F RID: 17007
	[Nullable(1)]
	string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000949 RID: 2377
	// (get) Token: 0x06004270 RID: 17008
	// (set) Token: 0x06004271 RID: 17009
	string NameTextId { get; set; }

	// Token: 0x1700094A RID: 2378
	// (get) Token: 0x06004272 RID: 17010
	// (set) Token: 0x06004273 RID: 17011
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

	// Token: 0x1700094B RID: 2379
	// (get) Token: 0x06004274 RID: 17012
	// (set) Token: 0x06004275 RID: 17013
	TItem[] RewardList { get; set; }

	// Token: 0x1700094C RID: 2380
	// (get) Token: 0x06004276 RID: 17014
	// (set) Token: 0x06004277 RID: 17015
	EActivityRewardState RewardState { get; set; }

	// Token: 0x1700094D RID: 2381
	// (get) Token: 0x06004278 RID: 17016
	// (set) Token: 0x06004279 RID: 17017
	string RewardButtonTextId { get; set; }

	// Token: 0x1700094E RID: 2382
	// (get) Token: 0x0600427A RID: 17018
	// (set) Token: 0x0600427B RID: 17019
	string RewardButtonText { get; set; }

	// Token: 0x1700094F RID: 2383
	// (get) Token: 0x0600427C RID: 17020
	// (set) Token: 0x0600427D RID: 17021
	bool? RewardButtonRedDot { get; set; }

	// Token: 0x17000950 RID: 2384
	// (get) Token: 0x0600427E RID: 17022
	// (set) Token: 0x0600427F RID: 17023
	Action ClickFunction { get; set; }

	// Token: 0x17000951 RID: 2385
	// (get) Token: 0x06004280 RID: 17024
	// (set) Token: 0x06004281 RID: 17025
	bool? ClickFunctionAndCloseSelf { get; set; }

	// Token: 0x17000952 RID: 2386
	// (get) Token: 0x06004282 RID: 17026
	// (set) Token: 0x06004283 RID: 17027
	string ProgressText { get; set; }
}
