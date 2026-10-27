using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200173B RID: 5947
[NullableContext(1)]
[Nullable(0)]
public class CalabashDevelopRewardData
{
	// Token: 0x0600ABD4 RID: 43988 RVA: 0x002682E0 File Offset: 0x002664E0
	public CalabashDevelopRewardData(CalabashDevelopReward developReward, string skillName)
	{
		this.DevelopReward = developReward;
		this.SkillName = skillName;
		this.UnlockConditionMap = new Dictionary<int, bool>();
	}

	// Token: 0x17000E59 RID: 3673
	// (get) Token: 0x0600ABD5 RID: 43989 RVA: 0x00268301 File Offset: 0x00266501
	// (set) Token: 0x0600ABD6 RID: 43990 RVA: 0x00268309 File Offset: 0x00266509
	public bool UnlockData
	{
		get
		{
			return this.Unlock;
		}
		set
		{
			this.Unlock = value;
		}
	}

	// Token: 0x17000E5A RID: 3674
	// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x00268312 File Offset: 0x00266512
	// (set) Token: 0x0600ABD8 RID: 43992 RVA: 0x0026831A File Offset: 0x0026651A
	public int RewardNumData
	{
		get
		{
			return this.RewardNum;
		}
		set
		{
			this.RewardNum = value;
		}
	}

	// Token: 0x17000E5B RID: 3675
	// (get) Token: 0x0600ABD9 RID: 43993 RVA: 0x00268323 File Offset: 0x00266523
	public CalabashDevelopReward DevelopRewardData
	{
		get
		{
			return this.DevelopReward;
		}
	}

	// Token: 0x17000E5C RID: 3676
	// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x0026832C File Offset: 0x0026652C
	public int RewardSumNumData
	{
		get
		{
			return this.DevelopRewardData.DevelopCondition().Length;
		}
	}

	// Token: 0x0600ABDB RID: 43995 RVA: 0x0026834C File Offset: 0x0026654C
	public void SetUnlockConditionMap(List<ICalabashDevelopConditionState> list)
	{
		foreach (ICalabashDevelopConditionState calabashDevelopConditionState in list)
		{
			this.UnlockConditionMap[calabashDevelopConditionState.ConditionId] = calabashDevelopConditionState.Rewarded;
		}
	}

	// Token: 0x0600ABDC RID: 43996 RVA: 0x002683AC File Offset: 0x002665AC
	public Dictionary<int, bool> GetUnlockConditionMap()
	{
		return this.UnlockConditionMap;
	}

	// Token: 0x17000E5D RID: 3677
	// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x002683B4 File Offset: 0x002665B4
	public int UnlockSize
	{
		get
		{
			return this.UnlockConditionMap.Count;
		}
	}

	// Token: 0x0600ABDE RID: 43998 RVA: 0x002683C4 File Offset: 0x002665C4
	public bool CheckCanGetReward()
	{
		using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator = this.UnlockConditionMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04004DFE RID: 19966
	private bool Unlock;

	// Token: 0x04004DFF RID: 19967
	private int RewardNum;

	// Token: 0x04004E00 RID: 19968
	private readonly Dictionary<int, bool> UnlockConditionMap;

	// Token: 0x04004E01 RID: 19969
	public CalabashDevelopReward DevelopReward;

	// Token: 0x04004E02 RID: 19970
	public readonly string SkillName;
}
