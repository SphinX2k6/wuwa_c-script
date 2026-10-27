using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020013DC RID: 5084
[NullableContext(1)]
[Nullable(0)]
public class ActivityPhantomCollectData : ActivityBaseData
{
	// Token: 0x06008F90 RID: 36752 RVA: 0x001F048D File Offset: 0x001EE68D
	protected override void PhraseEx(ActivityData data)
	{
		if (data.PhantomCollectActivity == null)
		{
			return;
		}
		this.PhantomCollectRewardList = data.PhantomCollectActivity.PhantomCollectRewards.ToArray<PhantomCollectReward>();
	}

	// Token: 0x06008F91 RID: 36753 RVA: 0x001F04AE File Offset: 0x001EE6AE
	protected override bool GetExDataFinishShowState()
	{
		return !this.PhantomCollectRewardList.Any((PhantomCollectReward reward) => reward.State != SignState.IsReceive);
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x001F04DD File Offset: 0x001EE6DD
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public PhantomCollectReward[] GetPhantomCollectRewardList()
	{
		return this.PhantomCollectRewardList ?? new PhantomCollectReward[0];
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x001F04F0 File Offset: 0x001EE6F0
	[NullableContext(2)]
	public PhantomCollectReward GetPhantomCollectRewardById(int id)
	{
		PhantomCollectReward[] phantomCollectRewardList = this.PhantomCollectRewardList;
		if (phantomCollectRewardList == null)
		{
			return null;
		}
		return phantomCollectRewardList.FirstOrDefault((PhantomCollectReward reward) => reward.Type == (PhantomCollectRewardType)id);
	}

	// Token: 0x06008F94 RID: 36756 RVA: 0x001F0528 File Offset: 0x001EE728
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

	// Token: 0x06008F95 RID: 36757 RVA: 0x001F0578 File Offset: 0x001EE778
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

	// Token: 0x06008F96 RID: 36758 RVA: 0x001F05B4 File Offset: 0x001EE7B4
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

	// Token: 0x06008F97 RID: 36759 RVA: 0x001F05F0 File Offset: 0x001EE7F0
	public void UpadatePhantomCollectReward(PhantomCollectReward reward)
	{
		if (this.PhantomCollectRewardList == null)
		{
			return;
		}
		int num = this.PhantomCollectRewardList.ToList<PhantomCollectReward>().FindIndex((PhantomCollectReward item) => item.Type == reward.Type);
		if (num == -1)
		{
			return;
		}
		this.PhantomCollectRewardList[num] = reward;
	}

	// Token: 0x04003F76 RID: 16246
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public PhantomCollectReward[] PhantomCollectRewardList;
}
