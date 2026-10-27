using System;
using System.Runtime.CompilerServices;

// Token: 0x02001402 RID: 5122
[NullableContext(1)]
public interface IPinballSettleResultStrategy
{
	// Token: 0x17000C42 RID: 3138
	// (get) Token: 0x060090AA RID: 37034
	// (set) Token: 0x060090AB RID: 37035
	IPinballSettleResultViewContext Context { get; set; }

	// Token: 0x060090AC RID: 37036
	void RefreshStarLayout();

	// Token: 0x060090AD RID: 37037
	void RefreshRewards();

	// Token: 0x060090AE RID: 37038
	void RefreshButtons();

	// Token: 0x060090AF RID: 37039
	void RefreshProgressRewards();

	// Token: 0x060090B0 RID: 37040
	void RefreshUnlockTips();

	// Token: 0x060090B1 RID: 37041
	void RefreshFailTips();

	// Token: 0x060090B2 RID: 37042
	void RefreshDialog();

	// Token: 0x060090B3 RID: 37043
	void RefreshTitle();

	// Token: 0x060090B4 RID: 37044
	void OnClickBtnRestart(Action callback);

	// Token: 0x060090B5 RID: 37045
	void OnClickBtnNext(Action callback);

	// Token: 0x060090B6 RID: 37046
	void OnClickBtnBack(Action callback);

	// Token: 0x060090B7 RID: 37047
	bool GetIsNeedRewardView();

	// Token: 0x060090B8 RID: 37048
	bool GetIsNeedProgressRewardView();

	// Token: 0x060090B9 RID: 37049
	bool GetIsNeedFailTipsView();

	// Token: 0x060090BA RID: 37050
	bool GetIsNeedUnlockTipsView();

	// Token: 0x060090BB RID: 37051
	bool GetIsNeedDialogView();
}
