using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000BF4 RID: 3060
[NullableContext(1)]
[Nullable(0)]
public class CalabashDevelopRewardData
{
	// Token: 0x06007FBB RID: 32699 RVA: 0x002726F4 File Offset: 0x002708F4
	public CalabashDevelopRewardData(CalabashDevelopReward developReward, string skillName)
	{
		this.DevelopReward = developReward;
		this.SkillName = skillName;
		this.UnlockConditionMap = new Dictionary<int, bool>();
	}

	// Token: 0x17000E7C RID: 3708
	// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00272715 File Offset: 0x00270915
	// (set) Token: 0x06007FBD RID: 32701 RVA: 0x0027271D File Offset: 0x0027091D
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

	// Token: 0x17000E7D RID: 3709
	// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00272726 File Offset: 0x00270926
	// (set) Token: 0x06007FBF RID: 32703 RVA: 0x0027272E File Offset: 0x0027092E
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

	// Token: 0x17000E7E RID: 3710
	// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x00272737 File Offset: 0x00270937
	public CalabashDevelopReward DevelopRewardData
	{
		get
		{
			return this.DevelopReward;
		}
	}

	// Token: 0x17000E7F RID: 3711
	// (get) Token: 0x06007FC1 RID: 32705 RVA: 0x00272740 File Offset: 0x00270940
	public int RewardSumNumData
	{
		get
		{
			return this.DevelopRewardData.DevelopCondition().Length;
		}
	}

	// Token: 0x06007FC2 RID: 32706 RVA: 0x00272760 File Offset: 0x00270960
	public void SetUnlockConditionMap(List<ICalabashDevelopConditionState> list)
	{
		foreach (ICalabashDevelopConditionState calabashDevelopConditionState in list)
		{
			this.UnlockConditionMap[calabashDevelopConditionState.ConditionId] = calabashDevelopConditionState.Rewarded;
		}
	}

	// Token: 0x06007FC3 RID: 32707 RVA: 0x002727C0 File Offset: 0x002709C0
	public Dictionary<int, bool> GetUnlockConditionMap()
	{
		return this.UnlockConditionMap;
	}

	// Token: 0x17000E80 RID: 3712
	// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x002727C8 File Offset: 0x002709C8
	public int UnlockSize
	{
		get
		{
			return this.UnlockConditionMap.Count;
		}
	}

	// Token: 0x06007FC5 RID: 32709 RVA: 0x002727D8 File Offset: 0x002709D8
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

	// Token: 0x04004EA7 RID: 20135
	private bool Unlock;

	// Token: 0x04004EA8 RID: 20136
	private int RewardNum;

	// Token: 0x04004EA9 RID: 20137
	private readonly Dictionary<int, bool> UnlockConditionMap;

	// Token: 0x04004EAA RID: 20138
	public CalabashDevelopReward DevelopReward;

	// Token: 0x04004EAB RID: 20139
	public readonly string SkillName;
}
