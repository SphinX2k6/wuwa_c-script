using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200059D RID: 1437
public class ArtemisActivityData : ActivityBaseData
{
	// Token: 0x170009A7 RID: 2471
	// (get) Token: 0x06004451 RID: 17489 RVA: 0x0017886E File Offset: 0x00176A6E
	public int GetCacheActivityId
	{
		get
		{
			return this.CacheActivityId;
		}
	}

	// Token: 0x170009A8 RID: 2472
	// (get) Token: 0x06004452 RID: 17490 RVA: 0x00178876 File Offset: 0x00176A76
	public int GetUnlockIndex
	{
		get
		{
			return this.UnlockIndex;
		}
	}

	// Token: 0x170009A9 RID: 2473
	// (get) Token: 0x06004453 RID: 17491 RVA: 0x0017887E File Offset: 0x00176A7E
	public int GetRewardedIndex
	{
		get
		{
			return this.RewardedIndex;
		}
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x00178888 File Offset: 0x00176A88
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		if (data == null)
		{
			return;
		}
		ArtemisActivityInfo artemisActivityInfo = data.ArtemisActivityInfo;
		if (artemisActivityInfo == null)
		{
			return;
		}
		this.SetCacheActivityId(artemisActivityInfo.ActivityId);
		this.SetUnlockIndex(artemisActivityInfo.UnlockIndex);
		this.SetRewardedIndex(artemisActivityInfo.RewardedIndex);
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x001788C8 File Offset: 0x00176AC8
	public void SetCacheActivityId(int id)
	{
		this.CacheActivityId = id;
	}

	// Token: 0x06004456 RID: 17494 RVA: 0x001788D1 File Offset: 0x00176AD1
	public void SetUnlockIndex(int index)
	{
		this.UnlockIndex = index;
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x001788DA File Offset: 0x00176ADA
	public void SetRewardedIndex(int index)
	{
		this.RewardedIndex = index;
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x001788E4 File Offset: 0x00176AE4
	public EArtemisState? GetArtemisStatus(int day)
	{
		int num = day + 1;
		if (num <= this.UnlockIndex)
		{
			if (num <= this.RewardedIndex)
			{
				return new EArtemisState?(EArtemisState.Rewarded);
			}
			if (num == this.RewardedIndex + 1)
			{
				return new EArtemisState?(EArtemisState.Unlock);
			}
		}
		return new EArtemisState?(EArtemisState.Lock);
	}

	// Token: 0x06004459 RID: 17497 RVA: 0x00178926 File Offset: 0x00176B26
	public int GetArtemisRewardedIndex()
	{
		return Math.Max(this.RewardedIndex - 1, 0);
	}

	// Token: 0x0600445A RID: 17498 RVA: 0x00178936 File Offset: 0x00176B36
	public int GetArtemisUnlockIndex()
	{
		return Math.Max(this.UnlockIndex - 1, 0);
	}

	// Token: 0x0600445B RID: 17499 RVA: 0x00178948 File Offset: 0x00176B48
	public int GetArtemisDefaultOpenIndex()
	{
		int num;
		if (this.UnlockIndex > this.RewardedIndex)
		{
			num = this.RewardedIndex + 1;
		}
		else
		{
			num = this.UnlockIndex;
		}
		return Math.Max(num - 1, 0);
	}

	// Token: 0x0600445C RID: 17500 RVA: 0x0017897E File Offset: 0x00176B7E
	public bool GetCanReceive()
	{
		return this.UnlockIndex > this.RewardedIndex;
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x0017898E File Offset: 0x00176B8E
	public override bool GetExDataRedPointShowState()
	{
		return this.GetCanReceive();
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x00178998 File Offset: 0x00176B98
	protected override bool GetExDataFinishShowState()
	{
		if (this.UnlockIndex == this.RewardedIndex)
		{
			IReadOnlyList<Artemis> artemisGroupByActivityId = ArtemisActivityConfig.Instance.GetArtemisGroupByActivityId(this.CacheActivityId);
			return this.UnlockIndex == ((artemisGroupByActivityId != null) ? artemisGroupByActivityId.Count : 0);
		}
		return false;
	}

	// Token: 0x040034E1 RID: 13537
	private int CacheActivityId;

	// Token: 0x040034E2 RID: 13538
	private int UnlockIndex;

	// Token: 0x040034E3 RID: 13539
	private int RewardedIndex;
}
