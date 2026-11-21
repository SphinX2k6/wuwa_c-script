using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020008B7 RID: 2231
[NullableContext(1)]
public interface IPinballSettleResultViewContext
{
	// Token: 0x06006451 RID: 25681
	void ShowStarLayout(bool[] starInfo);

	// Token: 0x06006452 RID: 25682
	bool GetNeedAdjustFormation();

	// Token: 0x06006453 RID: 25683
	void ShowRewards(List<TItem> rewardList);

	// Token: 0x06006454 RID: 25684
	void ShowRewardsGot();

	// Token: 0x06006455 RID: 25685
	void ShowProgressRewardList(int score, int[] scoreLevel, int[] scoreLevelDropId);

	// Token: 0x06006456 RID: 25686
	void ShowSuccessTips(string successTitle);

	// Token: 0x06006457 RID: 25687
	void BindRestartButton();

	// Token: 0x06006458 RID: 25688
	void BindNextButton();

	// Token: 0x06006459 RID: 25689
	void BindBackButton();

	// Token: 0x0600645A RID: 25690
	IPinballSettleResultViewParam GetOpenParam();
}
