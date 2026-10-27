using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001223 RID: 4643
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyBoardData
{
	// Token: 0x06007D84 RID: 32132 RVA: 0x001A9A88 File Offset: 0x001A7C88
	public static DangoMonopolyBoardData Create(DangoMonopolyBoard config, int index)
	{
		DangoMonopolyBoardData dangoMonopolyBoardData = new DangoMonopolyBoardData(config.BoardId, index);
		dangoMonopolyBoardData.Init(config);
		return dangoMonopolyBoardData;
	}

	// Token: 0x06007D85 RID: 32133 RVA: 0x001A9AA0 File Offset: 0x001A7CA0
	private DangoMonopolyBoardData(int id, int index)
	{
		this.Id = id;
		this.Index = index;
	}

	// Token: 0x06007D86 RID: 32134 RVA: 0x001A9B04 File Offset: 0x001A7D04
	private void Init(DangoMonopolyBoard config)
	{
		this.RewardItemId = config.ItemId;
		this.RewardItemCount = config.ItemNum;
		this.GroupId = config.BoardGroupId;
		this.FinishTitle = config.FinishTitle;
		this.FinishDesc = config.FinishDesc;
		DangoMonopolyGrid[] gridList = ActivityDangoMonopolyConfig.Instance.GetGridList(config.GridGroupId);
		for (int i = 0; i < gridList.Length; i++)
		{
			DangoMonopolyGrid config2 = gridList[i];
			DangoMonopolyGridData dangoMonopolyGridData = DangoMonopolyGridData.Create(config2, i, this);
			this.GridList.Add(dangoMonopolyGridData);
			this.GridMap.Add(config2.GridId, dangoMonopolyGridData);
		}
	}

	// Token: 0x06007D87 RID: 32135 RVA: 0x001A9BA2 File Offset: 0x001A7DA2
	public void SetActivityData(ActivityDangoMonopolyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x06007D88 RID: 32136 RVA: 0x001A9BAB File Offset: 0x001A7DAB
	public void SetRewarded(bool isRewarded)
	{
		this.IsRewarded = isRewarded;
	}

	// Token: 0x06007D89 RID: 32137 RVA: 0x001A9BB4 File Offset: 0x001A7DB4
	public bool IsFinish()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		DangoMonopolyBoardData dangoMonopolyBoardData = (activityData != null) ? activityData.CurrentBoardData : null;
		if (dangoMonopolyBoardData != null && dangoMonopolyBoardData.IsGreaterIndex(this.Index))
		{
			return true;
		}
		if (dangoMonopolyBoardData != null && dangoMonopolyBoardData.IsEqualIndex(this.Index))
		{
			DangoMonopolyGridData currentGridData = this.GetCurrentGridData();
			if (currentGridData == null || !currentGridData.IsLessIndex(this.GridList.Count - 1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007D8A RID: 32138 RVA: 0x001A9C1C File Offset: 0x001A7E1C
	public bool IsRunning()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		DangoMonopolyBoardData dangoMonopolyBoardData = (activityData != null) ? activityData.CurrentBoardData : null;
		return dangoMonopolyBoardData != null && dangoMonopolyBoardData.IsEqualIndex(this.Index);
	}

	// Token: 0x06007D8B RID: 32139 RVA: 0x001A9C4D File Offset: 0x001A7E4D
	[NullableContext(2)]
	public DangoMonopolyGridData GetCurrentGridData()
	{
		if (!this.IsRunning())
		{
			return null;
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData == null)
		{
			return null;
		}
		return activityData.RunningGridData;
	}

	// Token: 0x06007D8C RID: 32140 RVA: 0x001A9C6A File Offset: 0x001A7E6A
	public bool IsGreaterIndex(int index)
	{
		return this.Index > index;
	}

	// Token: 0x06007D8D RID: 32141 RVA: 0x001A9C75 File Offset: 0x001A7E75
	public bool IsEqualIndex(int index)
	{
		return this.Index == index;
	}

	// Token: 0x06007D8E RID: 32142 RVA: 0x001A9C80 File Offset: 0x001A7E80
	public bool IsLessIndex(int index)
	{
		return this.Index < index;
	}

	// Token: 0x06007D8F RID: 32143 RVA: 0x001A9C8B File Offset: 0x001A7E8B
	public bool IsCanReceiveReward()
	{
		return !this.IsRewarded && this.IsFinish();
	}

	// Token: 0x06007D90 RID: 32144 RVA: 0x001A9CA4 File Offset: 0x001A7EA4
	public List<IDangoMonopolyRoundBuffData> GetDangoBuffShowList()
	{
		List<IDangoMonopolyRoundBuffData> list = new List<IDangoMonopolyRoundBuffData>();
		int finishGridNum = this.GetFinishGridNum();
		foreach (DangoMonopolyGridData dangoMonopolyGridData in this.GridList)
		{
			DangoData dangoData = dangoMonopolyGridData.GetDangoData();
			if (dangoData != null)
			{
				int id = dangoData.Id;
				DangoMonopolyProperty? addPropertyConfig = dangoMonopolyGridData.GetAddPropertyConfig();
				DangoMonopolyRoundBuffData dangoMonopolyRoundBuffData = new DangoMonopolyRoundBuffData();
				dangoMonopolyRoundBuffData.DangoId = id;
				dangoMonopolyRoundBuffData.PropertyId = ((addPropertyConfig != null) ? addPropertyConfig.GetValueOrDefault().Id : 0);
				dangoMonopolyRoundBuffData.GridId = dangoMonopolyGridData.Id;
				dangoMonopolyRoundBuffData.IsActive = (finishGridNum >= dangoMonopolyGridData.GetPosition());
				dangoMonopolyRoundBuffData.DangoIcon = dangoData.Icon;
				dangoMonopolyRoundBuffData.DangoName = dangoData.NameKey;
				string propertyDesc;
				if ((propertyDesc = ((addPropertyConfig != null) ? addPropertyConfig.GetValueOrDefault().Desc : null)) == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("not property, gridId: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(dangoMonopolyGridData.Id);
					propertyDesc = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				dangoMonopolyRoundBuffData.PropertyDesc = propertyDesc;
				string propertyTitle;
				if ((propertyTitle = ((addPropertyConfig != null) ? addPropertyConfig.GetValueOrDefault().Title : null)) == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("not property, gridId: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(dangoMonopolyGridData.Id);
					propertyTitle = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				dangoMonopolyRoundBuffData.PropertyTitle = propertyTitle;
				DangoMonopolyRoundBuffData item = dangoMonopolyRoundBuffData;
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06007D91 RID: 32145 RVA: 0x001A9E44 File Offset: 0x001A8044
	public List<RewardItemData> GetAllGridRewardItemList()
	{
		List<IDangoMonopolyItemShowData> list = new List<IDangoMonopolyItemShowData>();
		foreach (DangoMonopolyGridData dangoMonopolyGridData in this.GridList)
		{
			if (dangoMonopolyGridData.IsExistItem())
			{
				DangoMonopolyItemShowData item = new DangoMonopolyItemShowData
				{
					Id = dangoMonopolyGridData.ItemId,
					Num = dangoMonopolyGridData.ItemCount,
					IsDouble = dangoMonopolyGridData.IsActiveDouble(),
					UniqueId = 0
				};
				list.Add(item);
			}
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		return ((activityData != null) ? activityData.GetItemShowList(list) : null) ?? new List<RewardItemData>();
	}

	// Token: 0x06007D92 RID: 32146 RVA: 0x001A9EF4 File Offset: 0x001A80F4
	public int GetPosition()
	{
		return this.Index + 1;
	}

	// Token: 0x06007D93 RID: 32147 RVA: 0x001A9F00 File Offset: 0x001A8100
	public int GetFinishGridNum()
	{
		if (this.IsFinish())
		{
			return this.GridList.Count;
		}
		DangoMonopolyGridData currentGridData = this.GetCurrentGridData();
		if (currentGridData == null)
		{
			return 0;
		}
		return currentGridData.GetPosition();
	}

	// Token: 0x06007D94 RID: 32148 RVA: 0x001A9F34 File Offset: 0x001A8134
	public int InitStartMoveDango(int step)
	{
		if (!this.IsRunning())
		{
			return 0;
		}
		DangoMonopolyGridData currentGridData = this.GetCurrentGridData();
		if (currentGridData == null)
		{
			DangoMonopolyGridData dangoMonopolyGridData = (step < this.GridList.Count) ? this.GridList[step] : this.GridList[this.GridList.Count - 1];
			ActivityDangoMonopolyData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.UpdateTargetGrid((dangoMonopolyGridData != null) ? dangoMonopolyGridData.Id : 0);
			}
			if (dangoMonopolyGridData == null)
			{
				return 0;
			}
			return dangoMonopolyGridData.GetPosition();
		}
		else
		{
			int index = currentGridData.Index;
			int num = Math.Min(index + step, this.GridList.Count - 1);
			int result = num - index;
			DangoMonopolyGridData dangoMonopolyGridData2 = this.GridList[num];
			ActivityDangoMonopolyData activityData2 = this.ActivityData;
			if (activityData2 == null)
			{
				return result;
			}
			activityData2.UpdateTargetGrid(dangoMonopolyGridData2.Id);
			return result;
		}
	}

	// Token: 0x06007D95 RID: 32149 RVA: 0x001A9FFC File Offset: 0x001A81FC
	public bool MoveDangoOneStep()
	{
		if (!this.IsRunning())
		{
			return false;
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		int? num;
		if (activityData == null)
		{
			num = null;
		}
		else
		{
			DangoMonopolyGridData runningGridData = activityData.RunningGridData;
			num = ((runningGridData != null) ? new int?(runningGridData.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		ActivityDangoMonopolyData activityData2 = this.ActivityData;
		int? num3;
		if (activityData2 == null)
		{
			num3 = null;
		}
		else
		{
			DangoMonopolyGridData targetGridData = activityData2.TargetGridData;
			num3 = ((targetGridData != null) ? new int?(targetGridData.Id) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault();
		int id = Math.Min(valueOrDefault + 1, valueOrDefault2);
		ActivityDangoMonopolyData activityData3 = this.ActivityData;
		if (activityData3 != null)
		{
			activityData3.UpdateRunningGrid(id);
		}
		return true;
	}

	// Token: 0x06007D96 RID: 32150 RVA: 0x001AA0A8 File Offset: 0x001A82A8
	public bool IsMoveToTarget()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		int? num;
		if (activityData == null)
		{
			num = null;
		}
		else
		{
			DangoMonopolyGridData runningGridData = activityData.RunningGridData;
			num = ((runningGridData != null) ? new int?(runningGridData.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		ActivityDangoMonopolyData activityData2 = this.ActivityData;
		int? num3;
		if (activityData2 == null)
		{
			num3 = null;
		}
		else
		{
			DangoMonopolyGridData targetGridData = activityData2.TargetGridData;
			num3 = ((targetGridData != null) ? new int?(targetGridData.Id) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault();
		return valueOrDefault == valueOrDefault2;
	}

	// Token: 0x06007D97 RID: 32151 RVA: 0x001AA12F File Offset: 0x001A832F
	public int GetEndGridId()
	{
		if (this.GridList.Count <= 0)
		{
			return 0;
		}
		return this.GridList[this.GridList.Count - 1].Id;
	}

	// Token: 0x06007D98 RID: 32152 RVA: 0x001AA15E File Offset: 0x001A835E
	public int GetStartGridId()
	{
		if (this.GridList.Count <= 0)
		{
			return 0;
		}
		return this.GridList[0].Id;
	}

	// Token: 0x06007D99 RID: 32153 RVA: 0x001AA184 File Offset: 0x001A8384
	[NullableContext(2)]
	public DangoMonopolyGridData GetFirstDoubleGrid()
	{
		foreach (DangoMonopolyGridData dangoMonopolyGridData in this.GridList)
		{
			if (dangoMonopolyGridData.PropertyIsDouble())
			{
				return dangoMonopolyGridData;
			}
		}
		return null;
	}

	// Token: 0x06007D9A RID: 32154 RVA: 0x001AA1E0 File Offset: 0x001A83E0
	public bool IsLock()
	{
		return this.GetUnlockRemainTime() > 0.0;
	}

	// Token: 0x06007D9B RID: 32155 RVA: 0x001AA1F3 File Offset: 0x001A83F3
	public double GetUnlockRemainTime()
	{
		if (this.UnlockTime <= 0L)
		{
			return 0.0;
		}
		return Math.Max(0.0, (double)this.UnlockTime - TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06007D9C RID: 32156 RVA: 0x001AA229 File Offset: 0x001A8429
	public void UpdateUnlockTime(long time)
	{
		this.UnlockTime = time;
	}

	// Token: 0x06007D9D RID: 32157 RVA: 0x001AA232 File Offset: 0x001A8432
	public void UpdateRollDiceTimes(int num)
	{
		this.RecordRollDiceTimes = num;
	}

	// Token: 0x06007D9E RID: 32158 RVA: 0x001AA23B File Offset: 0x001A843B
	public void AddRollDiceTimes()
	{
		this.RecordRollDiceTimes++;
	}

	// Token: 0x06007D9F RID: 32159 RVA: 0x001AA24B File Offset: 0x001A844B
	public void UpdateRecordTriggerBuff(int id, int times)
	{
		this.RecordTriggerBuffMap[id] = times;
	}

	// Token: 0x06007DA0 RID: 32160 RVA: 0x001AA25C File Offset: 0x001A845C
	public void AddRecordTriggerBuff(int id)
	{
		if (id <= 0)
		{
			return;
		}
		int num;
		if (!this.RecordTriggerBuffMap.TryGetValue(id, out num))
		{
			num = 0;
		}
		this.RecordTriggerBuffMap[id] = num + 1;
	}

	// Token: 0x06007DA1 RID: 32161 RVA: 0x001AA28F File Offset: 0x001A848F
	public void ClearRecordTriggerBuff()
	{
		this.RecordTriggerBuffMap.Clear();
	}

	// Token: 0x06007DA2 RID: 32162 RVA: 0x001AA29C File Offset: 0x001A849C
	public int GetRecordTriggerBuffTotalTimes()
	{
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in this.RecordTriggerBuffMap)
		{
			ActivityDangoMonopolyData activityData = this.ActivityData;
			if (activityData == null || !activityData.BuffIsImplicit(keyValuePair.Key))
			{
				num += keyValuePair.Value;
			}
		}
		return num;
	}

	// Token: 0x06007DA3 RID: 32163 RVA: 0x001AA314 File Offset: 0x001A8514
	public void UpdateOwnedBuffIdList(int id)
	{
		this.OwnedBuffIdList.Add(id);
	}

	// Token: 0x06007DA4 RID: 32164 RVA: 0x001AA322 File Offset: 0x001A8522
	public void ClearOwnedBuffIdList()
	{
		this.OwnedBuffIdList.Clear();
	}

	// Token: 0x06007DA5 RID: 32165 RVA: 0x001AA330 File Offset: 0x001A8530
	public List<DangoMonopolyGridData> GetGridListDango()
	{
		List<DangoMonopolyGridData> list = new List<DangoMonopolyGridData>();
		foreach (DangoMonopolyGridData dangoMonopolyGridData in this.GridList)
		{
			if (dangoMonopolyGridData.IsExistDango())
			{
				list.Add(dangoMonopolyGridData);
			}
		}
		return list;
	}

	// Token: 0x06007DA6 RID: 32166 RVA: 0x001AA394 File Offset: 0x001A8594
	public int GetDangoIdByBuffId(int buffId)
	{
		foreach (DangoMonopolyGridData dangoMonopolyGridData in this.GetGridListDango())
		{
			if (dangoMonopolyGridData.AddPropertyId == buffId)
			{
				return dangoMonopolyGridData.DangoId;
			}
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		int? num;
		if (activityData == null)
		{
			num = null;
		}
		else
		{
			DangoData dango = activityData.Dango;
			num = ((dango != null) ? new int?(dango.Id) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x06007DA7 RID: 32167 RVA: 0x001AA430 File Offset: 0x001A8630
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x04003918 RID: 14616
	public int Id;

	// Token: 0x04003919 RID: 14617
	public int GroupId;

	// Token: 0x0400391A RID: 14618
	public int Index;

	// Token: 0x0400391B RID: 14619
	public bool IsRewarded;

	// Token: 0x0400391C RID: 14620
	public int RewardItemId;

	// Token: 0x0400391D RID: 14621
	public int RewardItemCount;

	// Token: 0x0400391E RID: 14622
	public string FinishTitle = "";

	// Token: 0x0400391F RID: 14623
	public string FinishDesc = "";

	// Token: 0x04003920 RID: 14624
	public readonly List<DangoMonopolyGridData> GridList = new List<DangoMonopolyGridData>();

	// Token: 0x04003921 RID: 14625
	public readonly Dictionary<int, DangoMonopolyGridData> GridMap = new Dictionary<int, DangoMonopolyGridData>();

	// Token: 0x04003922 RID: 14626
	[Nullable(2)]
	public ActivityDangoMonopolyData ActivityData;

	// Token: 0x04003923 RID: 14627
	public long UnlockTime;

	// Token: 0x04003924 RID: 14628
	public int RecordRollDiceTimes;

	// Token: 0x04003925 RID: 14629
	public readonly Dictionary<int, int> RecordTriggerBuffMap = new Dictionary<int, int>();

	// Token: 0x04003926 RID: 14630
	public readonly List<int> OwnedBuffIdList = new List<int>();
}
