using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026DD RID: 9949
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGroupRewardData
{
	// Token: 0x06014669 RID: 83561 RVA: 0x00529030 File Offset: 0x00527230
	public RacingBetsGroupRewardData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0601466A RID: 83562 RVA: 0x0052904C File Offset: 0x0052724C
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

	// Token: 0x0601466B RID: 83563 RVA: 0x005290B4 File Offset: 0x005272B4
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

	// Token: 0x0601466C RID: 83564 RVA: 0x005290E8 File Offset: 0x005272E8
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

	// Token: 0x04009945 RID: 39237
	public readonly int Id;

	// Token: 0x04009946 RID: 39238
	private readonly List<RacingBetsRewardData> RewardDataList = new List<RacingBetsRewardData>();
}
