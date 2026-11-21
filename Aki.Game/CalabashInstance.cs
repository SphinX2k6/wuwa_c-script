using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000BF1 RID: 3057
[NullableContext(1)]
[Nullable(0)]
public class CalabashInstance
{
	// Token: 0x06007F9B RID: 32667 RVA: 0x00272387 File Offset: 0x00270587
	public CalabashInstance()
	{
		this.LevelCatchGainMap = new Dictionary<int, int>();
		this.DevelopRewards = new Dictionary<int, List<ICalabashDevelopConditionState>>();
		this.RewardedLevelsSet = new HashSet<int>();
	}

	// Token: 0x06007F9C RID: 32668 RVA: 0x002723B0 File Offset: 0x002705B0
	public void SetBaseInfo(CalabashMsg baseInfo)
	{
		this.CalabashCurrentLevel = baseInfo.Level;
		this.CalabashCurrentExp = baseInfo.Exp;
		this.CalabashMaxLevel = CalabashConfig.Instance.GetCalabashMaxLevel();
		this.IdentifyGuaranteeCount = baseInfo.IdentifyGuaranteeCount;
		this.LowCostIdentifyGuaranteeCount = baseInfo.LowCostGuaranteeCount;
		this.SetUnlockCalabashDevelopRewards(baseInfo.UnlockedDevelopRewards);
	}

	// Token: 0x06007F9D RID: 32669 RVA: 0x0027240C File Offset: 0x0027060C
	public void SetConfigInfo(CalabashCfg configInfo)
	{
		foreach (KeyValuePair<int, int> keyValuePair in configInfo.CatchGain)
		{
			int key = keyValuePair.Key;
			this.LevelCatchGainMap[key] = keyValuePair.Value;
		}
	}

	// Token: 0x17000E71 RID: 3697
	// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00272470 File Offset: 0x00270670
	// (set) Token: 0x06007F9F RID: 32671 RVA: 0x00272478 File Offset: 0x00270678
	public int CalabashCurrentLevel
	{
		get
		{
			return this.CurrentLevel;
		}
		set
		{
			this.CurrentLevel = value;
		}
	}

	// Token: 0x17000E72 RID: 3698
	// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00272481 File Offset: 0x00270681
	// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x00272489 File Offset: 0x00270689
	public int CalabashMaxLevel
	{
		get
		{
			return this.MaxLevel;
		}
		set
		{
			this.MaxLevel = value;
		}
	}

	// Token: 0x17000E73 RID: 3699
	// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x00272492 File Offset: 0x00270692
	// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x0027249A File Offset: 0x0027069A
	public int CalabashCurrentExp
	{
		get
		{
			return this.CurrentExp;
		}
		set
		{
			this.CurrentExp = value;
		}
	}

	// Token: 0x17000E74 RID: 3700
	// (get) Token: 0x06007FA4 RID: 32676 RVA: 0x002724A3 File Offset: 0x002706A3
	// (set) Token: 0x06007FA5 RID: 32677 RVA: 0x002724AB File Offset: 0x002706AB
	public int IdentifyGuaranteeCount
	{
		get
		{
			return this.IdentifyGuaranteeCountInternal;
		}
		set
		{
			this.IdentifyGuaranteeCountInternal = value;
		}
	}

	// Token: 0x17000E75 RID: 3701
	// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x002724B4 File Offset: 0x002706B4
	// (set) Token: 0x06007FA7 RID: 32679 RVA: 0x002724BC File Offset: 0x002706BC
	public int LowCostIdentifyGuaranteeCount
	{
		get
		{
			return this.LowCostIdentifyGuaranteeCountInternal;
		}
		set
		{
			this.LowCostIdentifyGuaranteeCountInternal = value;
		}
	}

	// Token: 0x06007FA8 RID: 32680 RVA: 0x002724C8 File Offset: 0x002706C8
	public void SetUnlockCalabashDevelopRewards(IReadOnlyList<CalabashDevelopInfo> developRewards)
	{
		this.DevelopRewards.Clear();
		foreach (CalabashDevelopInfo calabashDevelopInfo in developRewards)
		{
			List<ICalabashDevelopConditionState> list = new List<ICalabashDevelopConditionState>();
			foreach (Aki.Protocol.CalabashDevelopConditionState calabashDevelopConditionState in calabashDevelopInfo.UnlockConditions)
			{
				list.Add(new global::CalabashDevelopConditionState
				{
					ConditionId = calabashDevelopConditionState.ConditionId,
					Rewarded = calabashDevelopConditionState.Rewarded
				});
			}
			this.DevelopRewards[calabashDevelopInfo.MonsterId] = list;
		}
	}

	// Token: 0x06007FA9 RID: 32681 RVA: 0x00272590 File Offset: 0x00270790
	public void SetUnlockCalabashDevelopReward(CalabashDevelopInfo developReward)
	{
		List<ICalabashDevelopConditionState> list = new List<ICalabashDevelopConditionState>();
		foreach (Aki.Protocol.CalabashDevelopConditionState calabashDevelopConditionState in developReward.UnlockConditions)
		{
			list.Add(new global::CalabashDevelopConditionState
			{
				ConditionId = calabashDevelopConditionState.ConditionId,
				Rewarded = calabashDevelopConditionState.Rewarded
			});
		}
		this.DevelopRewards[developReward.MonsterId] = list;
	}

	// Token: 0x06007FAA RID: 32682 RVA: 0x00272614 File Offset: 0x00270814
	public Dictionary<int, List<ICalabashDevelopConditionState>> GetUnlockCalabashDevelopRewards()
	{
		return this.DevelopRewards;
	}

	// Token: 0x06007FAB RID: 32683 RVA: 0x0027261C File Offset: 0x0027081C
	public void SetRewardedLevelsSet(List<int> levelList)
	{
		this.RewardedLevelsSet.Clear();
		foreach (int item in levelList)
		{
			this.RewardedLevelsSet.Add(item);
		}
	}

	// Token: 0x06007FAC RID: 32684 RVA: 0x0027267C File Offset: 0x0027087C
	public bool IsRewardedByLevel(int level)
	{
		return this.RewardedLevelsSet.Contains(level);
	}

	// Token: 0x06007FAD RID: 32685 RVA: 0x0027268C File Offset: 0x0027088C
	public int? GetCatchGainByLevel(int level)
	{
		int value;
		if (this.LevelCatchGainMap.TryGetValue(level, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x04004E9C RID: 20124
	private int CurrentLevel;

	// Token: 0x04004E9D RID: 20125
	private int MaxLevel;

	// Token: 0x04004E9E RID: 20126
	private int CurrentExp;

	// Token: 0x04004E9F RID: 20127
	private int IdentifyGuaranteeCountInternal;

	// Token: 0x04004EA0 RID: 20128
	private int LowCostIdentifyGuaranteeCountInternal;

	// Token: 0x04004EA1 RID: 20129
	private readonly Dictionary<int, int> LevelCatchGainMap;

	// Token: 0x04004EA2 RID: 20130
	private readonly Dictionary<int, List<ICalabashDevelopConditionState>> DevelopRewards;

	// Token: 0x04004EA3 RID: 20131
	private readonly HashSet<int> RewardedLevelsSet;
}
