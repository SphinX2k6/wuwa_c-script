using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001403 RID: 5123
[NullableContext(1)]
public interface IPinballSettleResultViewContext
{
	// Token: 0x060090BC RID: 37052
	void ShowStarLayout(bool[] starInfo);

	// Token: 0x060090BD RID: 37053
	bool GetNeedAdjustFormation();

	// Token: 0x060090BE RID: 37054
	void ShowRewards(List<TItem> rewardList);

	// Token: 0x060090BF RID: 37055
	void ShowRewardsGot();

	// Token: 0x060090C0 RID: 37056
	void ShowProgressRewardList(int score, int[] scoreLevel, int[] scoreLevelDropId);

	// Token: 0x060090C1 RID: 37057
	void ShowSuccessTips(string successTitle);

	// Token: 0x060090C2 RID: 37058
	void BindRestartButton();

	// Token: 0x060090C3 RID: 37059
	void BindNextButton();

	// Token: 0x060090C4 RID: 37060
	void BindBackButton();

	// Token: 0x060090C5 RID: 37061
	IPinballSettleResultViewParam GetOpenParam();
}
