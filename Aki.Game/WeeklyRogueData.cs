using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002D5D RID: 11613
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueData : ActivityBaseData
{
	// Token: 0x060186B8 RID: 100024 RVA: 0x00637FA2 File Offset: 0x006361A2
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x060186B9 RID: 100025 RVA: 0x00637FA5 File Offset: 0x006361A5
	public bool GetRogueRedDotState()
	{
		return this.CheckIfInShowTime() && (this.HasScoreRewardEnable() || this.HasNewCycle());
	}

	// Token: 0x060186BA RID: 100026 RVA: 0x00637FC4 File Offset: 0x006361C4
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

	// Token: 0x060186BB RID: 100027 RVA: 0x00638031 File Offset: 0x00636231
	public bool HasNewCycle()
	{
		return base.GetPreGuideQuestFinishState() && !this.IsScoreRewardAllReceive() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, this.CycleId, 0, 0) == 0;
	}

	// Token: 0x060186BC RID: 100028 RVA: 0x00638064 File Offset: 0x00636264
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

	// Token: 0x060186BD RID: 100029 RVA: 0x006380C8 File Offset: 0x006362C8
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

	// Token: 0x060186BE RID: 100030 RVA: 0x0063812C File Offset: 0x0063632C
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

	// Token: 0x060186BF RID: 100031 RVA: 0x00638190 File Offset: 0x00636390
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

	// Token: 0x060186C0 RID: 100032 RVA: 0x006381F8 File Offset: 0x006363F8
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

	// Token: 0x060186C1 RID: 100033 RVA: 0x00638278 File Offset: 0x00636478
	public RogueWeeklyCycle? GetCycleConfig()
	{
		RogueWeeklyCycle? rogueWeeklyCycleConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyCycleConfig(this.CycleId);
		if (rogueWeeklyCycleConfig != null)
		{
			return new RogueWeeklyCycle?(rogueWeeklyCycleConfig.Value);
		}
		return null;
	}

	// Token: 0x060186C2 RID: 100034 RVA: 0x006382B5 File Offset: 0x006364B5
	public double GetCycleRemainTime()
	{
		return (double)base.EndShowTime - Time.Instance.ServerTimeStamp / 1000.0;
	}

	// Token: 0x060186C3 RID: 100035 RVA: 0x006382D4 File Offset: 0x006364D4
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

	// Token: 0x060186C4 RID: 100036 RVA: 0x006383DC File Offset: 0x006365DC
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

	// Token: 0x060186C5 RID: 100037 RVA: 0x006384D8 File Offset: 0x006366D8
	public int GetScoreRate()
	{
		RogueWeeklyCycle? cycleConfig = this.GetCycleConfig();
		if (cycleConfig == null)
		{
			return 0;
		}
		return (int)Math.Round((double)cycleConfig.Value.ScoreRate / 100.0);
	}

	// Token: 0x060186C6 RID: 100038 RVA: 0x00638518 File Offset: 0x00636718
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

	// Token: 0x060186C7 RID: 100039 RVA: 0x0063859C File Offset: 0x0063679C
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

	// Token: 0x060186C8 RID: 100040 RVA: 0x00638614 File Offset: 0x00636814
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

	// Token: 0x060186C9 RID: 100041 RVA: 0x00638738 File Offset: 0x00636938
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

	// Token: 0x0400B50A RID: 46346
	public int Score;

	// Token: 0x0400B50B RID: 46347
	[Nullable(2)]
	public RogueWeeklyLastInfo LastInstInfo;

	// Token: 0x0400B50C RID: 46348
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RogueWeeklyAward> AwardsInfoList;

	// Token: 0x0400B50D RID: 46349
	public int CycleId;

	// Token: 0x0400B50E RID: 46350
	public int WorldLevel;

	// Token: 0x0400B50F RID: 46351
	public int FreeCount;

	// Token: 0x0400B510 RID: 46352
	public int FreeCountMax;
}
