using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001738 RID: 5944
[NullableContext(1)]
[Nullable(0)]
public class CalabashInstance
{
	// Token: 0x0600ABB4 RID: 43956 RVA: 0x00267F87 File Offset: 0x00266187
	public CalabashInstance()
	{
		this.LevelCatchGainMap = new Dictionary<int, int>();
		this.DevelopRewards = new Dictionary<int, List<ICalabashDevelopConditionState>>();
		this.RewardedLevelsSet = new HashSet<int>();
	}

	// Token: 0x0600ABB5 RID: 43957 RVA: 0x00267FB0 File Offset: 0x002661B0
	public void SetBaseInfo(CalabashMsg baseInfo)
	{
		this.CalabashCurrentLevel = baseInfo.Level;
		this.CalabashCurrentExp = baseInfo.Exp;
		this.CalabashMaxLevel = CalabashConfig.Instance.GetCalabashMaxLevel();
		this.IdentifyGuaranteeCount = baseInfo.IdentifyGuaranteeCount;
		this.LowCostIdentifyGuaranteeCount = baseInfo.LowCostGuaranteeCount;
		this.SetUnlockCalabashDevelopRewards(baseInfo.UnlockedDevelopRewards.ToArray<CalabashDevelopInfo>());
	}

	// Token: 0x0600ABB6 RID: 43958 RVA: 0x00268010 File Offset: 0x00266210
	public void SetConfigInfo(CalabashCfg configInfo)
	{
		foreach (KeyValuePair<int, int> keyValuePair in configInfo.CatchGain)
		{
			int key = keyValuePair.Key;
			this.LevelCatchGainMap[key] = keyValuePair.Value;
		}
	}

	// Token: 0x17000E4E RID: 3662
	// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x00268074 File Offset: 0x00266274
	// (set) Token: 0x0600ABB8 RID: 43960 RVA: 0x0026807C File Offset: 0x0026627C
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

	// Token: 0x17000E4F RID: 3663
	// (get) Token: 0x0600ABB9 RID: 43961 RVA: 0x00268085 File Offset: 0x00266285
	// (set) Token: 0x0600ABBA RID: 43962 RVA: 0x0026808D File Offset: 0x0026628D
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

	// Token: 0x17000E50 RID: 3664
	// (get) Token: 0x0600ABBB RID: 43963 RVA: 0x00268096 File Offset: 0x00266296
	// (set) Token: 0x0600ABBC RID: 43964 RVA: 0x0026809E File Offset: 0x0026629E
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

	// Token: 0x17000E51 RID: 3665
	// (get) Token: 0x0600ABBD RID: 43965 RVA: 0x002680A7 File Offset: 0x002662A7
	// (set) Token: 0x0600ABBE RID: 43966 RVA: 0x002680AF File Offset: 0x002662AF
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

	// Token: 0x17000E52 RID: 3666
	// (get) Token: 0x0600ABBF RID: 43967 RVA: 0x002680B8 File Offset: 0x002662B8
	// (set) Token: 0x0600ABC0 RID: 43968 RVA: 0x002680C0 File Offset: 0x002662C0
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

	// Token: 0x0600ABC1 RID: 43969 RVA: 0x002680CC File Offset: 0x002662CC
	public void SetUnlockCalabashDevelopRewards(CalabashDevelopInfo[] developRewards)
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

	// Token: 0x0600ABC2 RID: 43970 RVA: 0x0026817C File Offset: 0x0026637C
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

	// Token: 0x0600ABC3 RID: 43971 RVA: 0x00268200 File Offset: 0x00266400
	public Dictionary<int, List<ICalabashDevelopConditionState>> GetUnlockCalabashDevelopRewards()
	{
		return this.DevelopRewards;
	}

	// Token: 0x0600ABC4 RID: 43972 RVA: 0x00268208 File Offset: 0x00266408
	public void SetRewardedLevelsSet(List<int> levelList)
	{
		this.RewardedLevelsSet.Clear();
		foreach (int item in levelList)
		{
			this.RewardedLevelsSet.Add(item);
		}
	}

	// Token: 0x0600ABC5 RID: 43973 RVA: 0x00268268 File Offset: 0x00266468
	public bool IsRewardedByLevel(int level)
	{
		return this.RewardedLevelsSet.Contains(level);
	}

	// Token: 0x0600ABC6 RID: 43974 RVA: 0x00268278 File Offset: 0x00266478
	public int? GetCatchGainByLevel(int level)
	{
		int value;
		if (this.LevelCatchGainMap.TryGetValue(level, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x04004DF3 RID: 19955
	private int CurrentLevel;

	// Token: 0x04004DF4 RID: 19956
	private int MaxLevel;

	// Token: 0x04004DF5 RID: 19957
	private int CurrentExp;

	// Token: 0x04004DF6 RID: 19958
	private int IdentifyGuaranteeCountInternal;

	// Token: 0x04004DF7 RID: 19959
	private int LowCostIdentifyGuaranteeCountInternal;

	// Token: 0x04004DF8 RID: 19960
	private readonly Dictionary<int, int> LevelCatchGainMap;

	// Token: 0x04004DF9 RID: 19961
	private readonly Dictionary<int, List<ICalabashDevelopConditionState>> DevelopRewards;

	// Token: 0x04004DFA RID: 19962
	private readonly HashSet<int> RewardedLevelsSet;
}
