using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200121D RID: 4637
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeData
{
	// Token: 0x06007C88 RID: 31880 RVA: 0x001A5035 File Offset: 0x001A3235
	public int GetChallengeId()
	{
		return this.ChallengeId;
	}

	// Token: 0x06007C89 RID: 31881 RVA: 0x001A503D File Offset: 0x001A323D
	public bool GetIfUnlock()
	{
		return this.IfUnlock;
	}

	// Token: 0x06007C8A RID: 31882 RVA: 0x001A5045 File Offset: 0x001A3245
	public bool GetCanChallenge()
	{
		return this.CanChallenge;
	}

	// Token: 0x06007C8B RID: 31883 RVA: 0x001A504D File Offset: 0x001A324D
	public bool GetConditionFinishState()
	{
		return this.ConditionFinishState;
	}

	// Token: 0x06007C8C RID: 31884 RVA: 0x001A5055 File Offset: 0x001A3255
	public long GetUnlockTime()
	{
		return this.UnlockTime;
	}

	// Token: 0x06007C8D RID: 31885 RVA: 0x001A505D File Offset: 0x001A325D
	public AbyssInst? GetConfig()
	{
		return ConfigAbyssInstById.GetConfig(this.ChallengeId, true);
	}

	// Token: 0x06007C8E RID: 31886 RVA: 0x001A506B File Offset: 0x001A326B
	public bool GetOverUnlockTime()
	{
		return TimeUtil.Instance.GetServerTime() >= (double)this.UnlockTime;
	}

	// Token: 0x06007C8F RID: 31887 RVA: 0x001A5084 File Offset: 0x001A3284
	public string GetLeftTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = Math.Max((double)this.UnlockTime - serverTime, 1.0);
		return TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText ?? "";
	}

	// Token: 0x06007C90 RID: 31888 RVA: 0x001A50D0 File Offset: 0x001A32D0
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

	// Token: 0x06007C91 RID: 31889 RVA: 0x001A5188 File Offset: 0x001A3388
	public int GetMaxProgress()
	{
		return this.MaxProgress;
	}

	// Token: 0x06007C92 RID: 31890 RVA: 0x001A5190 File Offset: 0x001A3390
	public bool GetIfPass()
	{
		return this.IfPass;
	}

	// Token: 0x06007C93 RID: 31891 RVA: 0x001A5198 File Offset: 0x001A3398
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

	// Token: 0x040038E2 RID: 14562
	private int ChallengeId;

	// Token: 0x040038E3 RID: 14563
	private bool IfUnlock;

	// Token: 0x040038E4 RID: 14564
	private bool CanChallenge;

	// Token: 0x040038E5 RID: 14565
	private long UnlockTime;

	// Token: 0x040038E6 RID: 14566
	private bool ConditionFinishState;

	// Token: 0x040038E7 RID: 14567
	private int MaxProgress;

	// Token: 0x040038E8 RID: 14568
	private bool IfPass;
}
