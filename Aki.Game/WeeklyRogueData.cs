using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020022B7 RID: 8887
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueData : ActivityBaseData
{
	// Token: 0x06015F5A RID: 89946 RVA: 0x0065DFB2 File Offset: 0x0065C1B2
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x06015F5B RID: 89947 RVA: 0x0065DFB5 File Offset: 0x0065C1B5
	public bool GetRogueRedDotState()
	{
		return this.CheckIfInShowTime() && (this.HasScoreRewardEnable() || this.HasNewCycle());
	}

	// Token: 0x06015F5C RID: 89948 RVA: 0x0065DFD4 File Offset: 0x0065C1D4
	public bool SaveFirstCheckRedDotState()
	{
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, this.CycleId, 0, 0) == 1)
		{
			return true;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, this.CycleId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueRedDotInfoRefresh);
		return false;
	}

	// Token: 0x06015F5D RID: 89949 RVA: 0x0065E041 File Offset: 0x0065C241
	public bool HasNewCycle()
	{
		return base.GetPreGuideQuestFinishState() && !this.IsScoreRewardAllReceive() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, this.CycleId, 0, 0) == 0;
	}

	// Token: 0x06015F5E RID: 89950 RVA: 0x0065E074 File Offset: 0x0065C274
	public bool HasScoreRewardEnable()
	{
		if (this.AwardsInfoList == null)
		{
			return false;
		}
		using (List<RogueWeeklyAward>.Enumerator enumerator = this.AwardsInfoList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SignState == SignState.Unlock)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06015F5F RID: 89951 RVA: 0x0065E0D8 File Offset: 0x0065C2D8
	public bool IsScoreRewardAllDone()
	{
		if (this.AwardsInfoList == null)
		{
			return true;
		}
		using (List<RogueWeeklyAward>.Enumerator enumerator = this.AwardsInfoList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SignState == SignState.Lock)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06015F60 RID: 89952 RVA: 0x0065E13C File Offset: 0x0065C33C
	public bool IsScoreRewardAllReceive()
	{
		if (this.AwardsInfoList == null)
		{
			return true;
		}
		using (List<RogueWeeklyAward>.Enumerator enumerator = this.AwardsInfoList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SignState != SignState.IsReceive)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06015F61 RID: 89953 RVA: 0x0065E1A0 File Offset: 0x0065C3A0
	public void SetScoreRewardState(int id, SignState state)
	{
		if (this.AwardsInfoList == null)
		{
			return;
		}
		foreach (RogueWeeklyAward rogueWeeklyAward in this.AwardsInfoList)
		{
			if (rogueWeeklyAward.ConfigId == id)
			{
				rogueWeeklyAward.SignState = state;
				break;
			}
		}
	}

	// Token: 0x06015F62 RID: 89954 RVA: 0x0065E208 File Offset: 0x0065C408
	public EActivityRewardState GetScoreRewardStateById(int id)
	{
		RogueWeeklyAward rogueWeeklyAward = null;
		if (this.AwardsInfoList != null)
		{
			foreach (RogueWeeklyAward rogueWeeklyAward2 in this.AwardsInfoList)
			{
				if (rogueWeeklyAward2.ConfigId == id)
				{
					rogueWeeklyAward = rogueWeeklyAward2;
					break;
				}
			}
		}
		if (rogueWeeklyAward != null && rogueWeeklyAward.SignState == SignState.IsReceive)
		{
			return EActivityRewardState.Claimed;
		}
		if (rogueWeeklyAward != null && rogueWeeklyAward.SignState == SignState.Lock)
		{
			return EActivityRewardState.Disabled;
		}
		return EActivityRewardState.Enable;
	}

	// Token: 0x06015F63 RID: 89955 RVA: 0x0065E288 File Offset: 0x0065C488
	public RogueWeeklyCycle? GetCycleConfig()
	{
		RogueWeeklyCycle? rogueWeeklyCycleConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyCycleConfig(this.CycleId);
		if (rogueWeeklyCycleConfig != null)
		{
			return new RogueWeeklyCycle?(rogueWeeklyCycleConfig.Value);
		}
		return null;
	}

	// Token: 0x06015F64 RID: 89956 RVA: 0x0065E2C5 File Offset: 0x0065C4C5
	public double GetCycleRemainTime()
	{
		return (double)base.EndShowTime - Time.Instance.ServerTimeStamp / 1000.0;
	}

	// Token: 0x06015F65 RID: 89957 RVA: 0x0065E2E4 File Offset: 0x0065C4E4
	public int GetCycleBlackFlowerCost()
	{
		if (this.FreeCount > 0)
		{
			return 0;
		}
		RogueWeeklyCycle? cycleConfig = this.GetCycleConfig();
		if (cycleConfig == null)
		{
			return 0;
		}
		int num = 999;
		int num2 = 0;
		int blackFlowerCostLength = cycleConfig.Value.BlackFlowerCostLength;
		for (int i = 0; i < blackFlowerCostLength; i++)
		{
			int key = cycleConfig.Value.BlackFlowerCost(i).Value.Key;
			if (key < num)
			{
				num = key;
			}
			if (key > num2)
			{
				num2 = key;
			}
		}
		int result = 0;
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		int num3;
		if (curWorldLevel < num)
		{
			num3 = num;
		}
		else if (curWorldLevel > num2)
		{
			num3 = num2;
		}
		else
		{
			num3 = curWorldLevel;
		}
		for (int j = 0; j < blackFlowerCostLength; j++)
		{
			DicIntInt? dicIntInt = cycleConfig.Value.BlackFlowerCost(j);
			if (dicIntInt != null && dicIntInt.Value.Key == num3)
			{
				result = dicIntInt.Value.Value;
				break;
			}
		}
		return result;
	}

	// Token: 0x06015F66 RID: 89958 RVA: 0x0065E3EC File Offset: 0x0065C5EC
	public int GetLvInfo()
	{
		RogueWeeklyCycle? cycleConfig = this.GetCycleConfig();
		if (cycleConfig == null)
		{
			return 0;
		}
		int num = 999;
		int num2 = 0;
		int diffLength = cycleConfig.Value.DiffLength;
		for (int i = 0; i < diffLength; i++)
		{
			int key = cycleConfig.Value.Diff(i).Value.Key;
			if (key < num)
			{
				num = key;
			}
			if (key > num2)
			{
				num2 = key;
			}
		}
		int result = 0;
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		int num3;
		if (curWorldLevel < num)
		{
			num3 = num;
		}
		else if (curWorldLevel > num2)
		{
			num3 = num2;
		}
		else
		{
			num3 = curWorldLevel;
		}
		for (int j = 0; j < diffLength; j++)
		{
			DicIntInt? dicIntInt = cycleConfig.Value.Diff(j);
			if (dicIntInt != null && dicIntInt.Value.Key == num3)
			{
				result = dicIntInt.Value.Value;
				break;
			}
		}
		return result;
	}

	// Token: 0x06015F67 RID: 89959 RVA: 0x0065E4E8 File Offset: 0x0065C6E8
	public int GetScoreRate()
	{
		RogueWeeklyCycle? cycleConfig = this.GetCycleConfig();
		if (cycleConfig == null)
		{
			return 0;
		}
		return (int)Math.Round((double)cycleConfig.Value.ScoreRate / 100.0);
	}

	// Token: 0x06015F68 RID: 89960 RVA: 0x0065E528 File Offset: 0x0065C728
	public CommonDefine.ICountDown GetCycleCountDownData()
	{
		double num = this.GetCycleRemainTime();
		if (num <= 1.0)
		{
			num = 1.0;
		}
		CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
	}

	// Token: 0x06015F69 RID: 89961 RVA: 0x0065E5AC File Offset: 0x0065C7AC
	public void OnQuestStateChange(int questId, QuestState state)
	{
		if (this.LocalConfig == null)
		{
			return;
		}
		int[] array = this.LocalConfig.Value.PreShowGuideQuest();
		bool flag = false;
		int[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] == questId)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (state < QuestState.Finish)
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueRedDotInfoRefresh);
	}

	// Token: 0x06015F6A RID: 89962 RVA: 0x0065E624 File Offset: 0x0065C824
	protected override void PhraseEx(ActivityData data)
	{
		RogueWeeklyData rogueWeeklyData = data.RogueWeeklyData;
		if (rogueWeeklyData == null)
		{
			Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LPH, "WeeklyRogueData无周常数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CheckIfInShowTime())
		{
			WeeklyRogueModel.Instance.CurrentActivityId = data.Id;
		}
		int cycleId = this.CycleId;
		this.CycleId = rogueWeeklyData.CycleId;
		if (cycleId != rogueWeeklyData.CycleId)
		{
			EventSystem.Instance.Emit(EEventName.WeeklyRogueCycleRefresh);
		}
		this.LastInstInfo = rogueWeeklyData.RogueWeeklyLastInfo;
		this.Score = rogueWeeklyData.Score;
		this.AwardsInfoList = new List<RogueWeeklyAward>();
		foreach (RogueWeeklyAward item in rogueWeeklyData.RogueWeeklyAwards)
		{
			this.AwardsInfoList.Add(item);
		}
		this.WorldLevel = rogueWeeklyData.CurWorldLevel;
		this.FreeCount = Math.Max(0, rogueWeeklyData.MaxFreeCount - rogueWeeklyData.UseFreeCount);
		this.FreeCountMax = rogueWeeklyData.MaxFreeCount;
		EventSystem.Instance.Emit(EEventName.WeeklyRogueRedDotInfoRefresh);
	}

	// Token: 0x06015F6B RID: 89963 RVA: 0x0065E748 File Offset: 0x0065C948
	protected override bool GetExDataFinishShowState()
	{
		if (!base.IsUnLock())
		{
			return false;
		}
		if (!base.GetPreGuideQuestFinishState())
		{
			return false;
		}
		if (this.AwardsInfoList == null)
		{
			return false;
		}
		using (List<RogueWeeklyAward>.Enumerator enumerator = this.AwardsInfoList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SignState != SignState.IsReceive)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0400B87F RID: 47231
	public int Score;

	// Token: 0x0400B880 RID: 47232
	[Nullable(2)]
	public RogueWeeklyLastInfo LastInstInfo;

	// Token: 0x0400B881 RID: 47233
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RogueWeeklyAward> AwardsInfoList;

	// Token: 0x0400B882 RID: 47234
	public int CycleId;

	// Token: 0x0400B883 RID: 47235
	public int WorldLevel;

	// Token: 0x0400B884 RID: 47236
	public int FreeCount;

	// Token: 0x0400B885 RID: 47237
	public int FreeCountMax;
}
