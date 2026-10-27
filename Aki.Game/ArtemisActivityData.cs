using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020010E9 RID: 4329
public class ArtemisActivityData : ActivityBaseData
{
	// Token: 0x17000987 RID: 2439
	// (get) Token: 0x060070BB RID: 28859 RVA: 0x0016FEB2 File Offset: 0x0016E0B2
	public int GetCacheActivityId
	{
		get
		{
			return this.CacheActivityId;
		}
	}

	// Token: 0x17000988 RID: 2440
	// (get) Token: 0x060070BC RID: 28860 RVA: 0x0016FEBA File Offset: 0x0016E0BA
	public int GetUnlockIndex
	{
		get
		{
			return this.UnlockIndex;
		}
	}

	// Token: 0x17000989 RID: 2441
	// (get) Token: 0x060070BD RID: 28861 RVA: 0x0016FEC2 File Offset: 0x0016E0C2
	public int GetRewardedIndex
	{
		get
		{
			return this.RewardedIndex;
		}
	}

	// Token: 0x060070BE RID: 28862 RVA: 0x0016FECC File Offset: 0x0016E0CC
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

	// Token: 0x060070BF RID: 28863 RVA: 0x0016FF0C File Offset: 0x0016E10C
	public void SetCacheActivityId(int id)
	{
		this.CacheActivityId = id;
	}

	// Token: 0x060070C0 RID: 28864 RVA: 0x0016FF15 File Offset: 0x0016E115
	public void SetUnlockIndex(int index)
	{
		this.UnlockIndex = index;
	}

	// Token: 0x060070C1 RID: 28865 RVA: 0x0016FF1E File Offset: 0x0016E11E
	public void SetRewardedIndex(int index)
	{
		this.RewardedIndex = index;
	}

	// Token: 0x060070C2 RID: 28866 RVA: 0x0016FF28 File Offset: 0x0016E128
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

	// Token: 0x060070C3 RID: 28867 RVA: 0x0016FF6A File Offset: 0x0016E16A
	public int GetArtemisRewardedIndex()
	{
		return Math.Max(this.RewardedIndex - 1, 0);
	}

	// Token: 0x060070C4 RID: 28868 RVA: 0x0016FF7A File Offset: 0x0016E17A
	public int GetArtemisUnlockIndex()
	{
		return Math.Max(this.UnlockIndex - 1, 0);
	}

	// Token: 0x060070C5 RID: 28869 RVA: 0x0016FF8C File Offset: 0x0016E18C
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

	// Token: 0x060070C6 RID: 28870 RVA: 0x0016FFC2 File Offset: 0x0016E1C2
	public bool GetCanReceive()
	{
		return this.UnlockIndex > this.RewardedIndex;
	}

	// Token: 0x060070C7 RID: 28871 RVA: 0x0016FFD2 File Offset: 0x0016E1D2
	public override bool GetExDataRedPointShowState()
	{
		return this.GetCanReceive();
	}

	// Token: 0x060070C8 RID: 28872 RVA: 0x0016FFDC File Offset: 0x0016E1DC
	protected override bool GetExDataFinishShowState()
	{
		if (this.UnlockIndex == this.RewardedIndex)
		{
			IReadOnlyList<Artemis> artemisGroupByActivityId = ArtemisActivityConfig.Instance.GetArtemisGroupByActivityId(this.CacheActivityId);
			return this.UnlockIndex == ((artemisGroupByActivityId != null) ? artemisGroupByActivityId.Count : 0);
		}
		return false;
	}

	// Token: 0x04003448 RID: 13384
	private int CacheActivityId;

	// Token: 0x04003449 RID: 13385
	private int UnlockIndex;

	// Token: 0x0400344A RID: 13386
	private int RewardedIndex;
}
