using System;
using System.Runtime.CompilerServices;

// Token: 0x020008B6 RID: 2230
[NullableContext(1)]
public interface IPinballSettleResultStrategy
{
	// Token: 0x17000C62 RID: 3170
	// (get) Token: 0x0600643F RID: 25663
	// (set) Token: 0x06006440 RID: 25664
	IPinballSettleResultViewContext Context { get; set; }

	// Token: 0x06006441 RID: 25665
	void RefreshStarLayout();

	// Token: 0x06006442 RID: 25666
	void RefreshRewards();

	// Token: 0x06006443 RID: 25667
	void RefreshButtons();

	// Token: 0x06006444 RID: 25668
	void RefreshProgressRewards();

	// Token: 0x06006445 RID: 25669
	void RefreshUnlockTips();

	// Token: 0x06006446 RID: 25670
	void RefreshFailTips();

	// Token: 0x06006447 RID: 25671
	void RefreshDialog();

	// Token: 0x06006448 RID: 25672
	void RefreshTitle();

	// Token: 0x06006449 RID: 25673
	void OnClickBtnRestart(Action callback);

	// Token: 0x0600644A RID: 25674
	void OnClickBtnNext(Action callback);

	// Token: 0x0600644B RID: 25675
	void OnClickBtnBack(Action callback);

	// Token: 0x0600644C RID: 25676
	bool GetIsNeedRewardView();

	// Token: 0x0600644D RID: 25677
	bool GetIsNeedProgressRewardView();

	// Token: 0x0600644E RID: 25678
	bool GetIsNeedFailTipsView();

	// Token: 0x0600644F RID: 25679
	bool GetIsNeedUnlockTipsView();

	// Token: 0x06006450 RID: 25680
	bool GetIsNeedDialogView();
}
