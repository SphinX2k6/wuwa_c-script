using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x020006D1 RID: 1745
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeData
{
	// Token: 0x0600501E RID: 20510 RVA: 0x001ADCBD File Offset: 0x001ABEBD
	public int GetChallengeId()
	{
		return this.ChallengeId;
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x001ADCC5 File Offset: 0x001ABEC5
	public bool GetIfUnlock()
	{
		return this.IfUnlock;
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x001ADCCD File Offset: 0x001ABECD
	public bool GetCanChallenge()
	{
		return this.CanChallenge;
	}

	// Token: 0x06005021 RID: 20513 RVA: 0x001ADCD5 File Offset: 0x001ABED5
	public bool GetConditionFinishState()
	{
		return this.ConditionFinishState;
	}

	// Token: 0x06005022 RID: 20514 RVA: 0x001ADCDD File Offset: 0x001ABEDD
	public long GetUnlockTime()
	{
		return this.UnlockTime;
	}

	// Token: 0x06005023 RID: 20515 RVA: 0x001ADCE5 File Offset: 0x001ABEE5
	public AbyssInst? GetConfig()
	{
		return ConfigAbyssInstById.GetConfig(this.ChallengeId, true);
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x001ADCF3 File Offset: 0x001ABEF3
	public bool GetOverUnlockTime()
	{
		return TimeUtil.Instance.GetServerTime() >= (double)this.UnlockTime;
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x001ADD0C File Offset: 0x001ABF0C
	public string GetLeftTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = Math.Max((double)this.UnlockTime - serverTime, 1.0);
		return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? "";
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x001ADD58 File Offset: 0x001ABF58
	public TItem[] GetReward()
	{
		List<TItem> list = new List<TItem>();
		int dropPreviewId = this.GetConfig().Value.DropPreviewId;
		if (dropPreviewId > 0)
		{
			foreach (KeyValuePair<int, int> keyValuePair in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropPreviewId).Value.DropPreview())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x001ADE10 File Offset: 0x001AC010
	public int GetMaxProgress()
	{
		return this.MaxProgress;
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x001ADE18 File Offset: 0x001AC018
	public bool GetIfPass()
	{
		return this.IfPass;
	}

	// Token: 0x06005029 RID: 20521 RVA: 0x001ADE20 File Offset: 0x001AC020
	public void Phrase(AbyssChallenge data)
	{
		this.ChallengeId = data.ChallengeId;
		this.IfUnlock = data.Unlock;
		this.CanChallenge = data.CanChallenge;
		this.UnlockTime = data.UnlockTime / 1000L;
		this.ConditionFinishState = data.IsConditionUnlock;
		this.MaxProgress = data.MaxProgress;
		this.IfPass = data.Passed;
	}

	// Token: 0x0400397B RID: 14715
	private int ChallengeId;

	// Token: 0x0400397C RID: 14716
	private bool IfUnlock;

	// Token: 0x0400397D RID: 14717
	private bool CanChallenge;

	// Token: 0x0400397E RID: 14718
	private long UnlockTime;

	// Token: 0x0400397F RID: 14719
	private bool ConditionFinishState;

	// Token: 0x04003980 RID: 14720
	private int MaxProgress;

	// Token: 0x04003981 RID: 14721
	private bool IfPass;
}
