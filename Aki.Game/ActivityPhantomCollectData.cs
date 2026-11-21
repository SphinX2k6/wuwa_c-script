using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000890 RID: 2192
[NullableContext(1)]
[Nullable(0)]
public class ActivityPhantomCollectData : ActivityBaseData
{
	// Token: 0x06006325 RID: 25381 RVA: 0x001F8FC5 File Offset: 0x001F71C5
	protected override void PhraseEx(ActivityData data)
	{
		if (data.PhantomCollectActivity == null)
		{
			return;
		}
		this.PhantomCollectRewardList = data.PhantomCollectActivity.PhantomCollectRewards.ToArray<PhantomCollectReward>();
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x001F8FE8 File Offset: 0x001F71E8
	protected override bool GetExDataFinishShowState()
	{
		PhantomCollectReward[] phantomCollectRewardList = this.PhantomCollectRewardList;
		for (int i = 0; i < phantomCollectRewardList.Length; i++)
		{
			if (phantomCollectRewardList[i].State != SignState.IsReceive)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006327 RID: 25383 RVA: 0x001F9018 File Offset: 0x001F7218
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public PhantomCollectReward[] GetPhantomCollectRewardList()
	{
		return this.PhantomCollectRewardList ?? new PhantomCollectReward[0];
	}

	// Token: 0x06006328 RID: 25384 RVA: 0x001F902C File Offset: 0x001F722C
	[NullableContext(2)]
	public PhantomCollectReward GetPhantomCollectRewardById(int id)
	{
		if (this.PhantomCollectRewardList == null)
		{
			return null;
		}
		foreach (PhantomCollectReward phantomCollectReward in this.PhantomCollectRewardList)
		{
			if (phantomCollectReward.Type == (PhantomCollectRewardType)id)
			{
				return phantomCollectReward;
			}
		}
		return null;
	}

	// Token: 0x06006329 RID: 25385 RVA: 0x001F9068 File Offset: 0x001F7268
	public int[] GetCollectPhantomList()
	{
		ActivityPhantomCollectConfig instance = ActivityPhantomCollectConfig.Instance;
		Aki.Config.PhantomCollectActivity? phantomCollectActivity = (instance != null) ? instance.GetPhantomCollectConfig(ActivityPhantomCollectController.Instance.ActivityId) : null;
		if (phantomCollectActivity == null)
		{
			return new int[0];
		}
		return phantomCollectActivity.Value.Phantoms();
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x001F90B8 File Offset: 0x001F72B8
	public override bool GetExDataRedPointShowState()
	{
		bool result = false;
		if (this.PhantomCollectRewardList != null)
		{
			PhantomCollectReward[] phantomCollectRewardList = this.PhantomCollectRewardList;
			for (int i = 0; i < phantomCollectRewardList.Length; i++)
			{
				if (phantomCollectRewardList[i].State == SignState.Unlock)
				{
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x0600632B RID: 25387 RVA: 0x001F90F4 File Offset: 0x001F72F4
	public int GetCollectPhantomCount()
	{
		int[] collectPhantomList = this.GetCollectPhantomList();
		int num = 0;
		foreach (int monsterId in collectPhantomList)
		{
			if (PhantomBattleModel.Instance.GetPhantomIsUnlock(monsterId))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600632C RID: 25388 RVA: 0x001F9130 File Offset: 0x001F7330
	public void UpadatePhantomCollectReward(PhantomCollectReward reward)
	{
		if (this.PhantomCollectRewardList == null)
		{
			return;
		}
		int num = Array.FindIndex<PhantomCollectReward>(this.PhantomCollectRewardList, (PhantomCollectReward item) => item.Type == reward.Type);
		if (num == -1)
		{
			return;
		}
		this.PhantomCollectRewardList[num] = reward;
	}

	// Token: 0x0400400E RID: 16398
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public PhantomCollectReward[] PhantomCollectRewardList;
}
