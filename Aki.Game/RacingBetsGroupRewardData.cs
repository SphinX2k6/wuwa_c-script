using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BC8 RID: 7112
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGroupRewardData
{
	// Token: 0x06011B4B RID: 72523 RVA: 0x00537D68 File Offset: 0x00535F68
	public RacingBetsGroupRewardData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06011B4C RID: 72524 RVA: 0x00537D84 File Offset: 0x00535F84
	public void AddRewardData(RacingBetsRewardData rewardData)
	{
		using (List<RacingBetsRewardData>.Enumerator enumerator = this.RewardDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Id == rewardData.Id)
				{
					return;
				}
			}
		}
		this.RewardDataList.Add(rewardData);
	}

	// Token: 0x06011B4D RID: 72525 RVA: 0x00537DEC File Offset: 0x00535FEC
	public List<RacingBetsRewardData> GetRewardDataList()
	{
		List<RacingBetsRewardData> list = new List<RacingBetsRewardData>(this.RewardDataList);
		list.Sort(delegate(RacingBetsRewardData a, RacingBetsRewardData b)
		{
			int num = (!a.CanReceiveReward()) ? 1 : 0;
			int num2 = (!b.CanReceiveReward()) ? 1 : 0;
			if (num != num2)
			{
				return num.CompareTo(num2);
			}
			int num3 = (a.IsTaskReceived() > false) ? 1 : 0;
			int num4 = (b.IsTaskReceived() > false) ? 1 : 0;
			if (num3 != num4)
			{
				return num3.CompareTo(num4);
			}
			return a.Id.CompareTo(b.Id);
		});
		return list;
	}

	// Token: 0x06011B4E RID: 72526 RVA: 0x00537E20 File Offset: 0x00536020
	public bool CanReceiveRewards()
	{
		using (List<RacingBetsRewardData>.Enumerator enumerator = this.RewardDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanReceiveReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04009A9D RID: 39581
	public readonly int Id;

	// Token: 0x04009A9E RID: 39582
	private readonly List<RacingBetsRewardData> RewardDataList = new List<RacingBetsRewardData>();
}
