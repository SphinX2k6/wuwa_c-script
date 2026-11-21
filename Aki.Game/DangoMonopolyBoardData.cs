using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020006D7 RID: 1751
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyBoardData
{
	// Token: 0x0600511B RID: 20763 RVA: 0x001B2748 File Offset: 0x001B0948
	public static DangoMonopolyBoardData Create(DangoMonopolyBoard config, int index)
	{
		DangoMonopolyBoardData dangoMonopolyBoardData = new DangoMonopolyBoardData(config.BoardId, index);
		dangoMonopolyBoardData.Init(config);
		return dangoMonopolyBoardData;
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x001B2760 File Offset: 0x001B0960
	private DangoMonopolyBoardData(int id, int index)
	{
		this.Id = id;
		this.Index = index;
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x001B27C4 File Offset: 0x001B09C4
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

	// Token: 0x0600511E RID: 20766 RVA: 0x001B2862 File Offset: 0x001B0A62
	public void SetActivityData(ActivityDangoMonopolyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x001B286B File Offset: 0x001B0A6B
	public void SetRewarded(bool isRewarded)
	{
		this.IsRewarded = isRewarded;
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x001B2874 File Offset: 0x001B0A74
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

	// Token: 0x06005121 RID: 20769 RVA: 0x001B28DC File Offset: 0x001B0ADC
	public bool IsRunning()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		DangoMonopolyBoardData dangoMonopolyBoardData = (activityData != null) ? activityData.CurrentBoardData : null;
		return dangoMonopolyBoardData != null && dangoMonopolyBoardData.IsEqualIndex(this.Index);
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x001B290D File Offset: 0x001B0B0D
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

	// Token: 0x06005123 RID: 20771 RVA: 0x001B292A File Offset: 0x001B0B2A
	public bool IsGreaterIndex(int index)
	{
		return this.Index > index;
	}

	// Token: 0x06005124 RID: 20772 RVA: 0x001B2935 File Offset: 0x001B0B35
	public bool IsEqualIndex(int index)
	{
		return this.Index == index;
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x001B2940 File Offset: 0x001B0B40
	public bool IsLessIndex(int index)
	{
		return this.Index < index;
	}

	// Token: 0x06005126 RID: 20774 RVA: 0x001B294B File Offset: 0x001B0B4B
	public bool IsCanReceiveReward()
	{
		return !this.IsRewarded && this.IsFinish();
	}

	// Token: 0x06005127 RID: 20775 RVA: 0x001B2964 File Offset: 0x001B0B64
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

	// Token: 0x06005128 RID: 20776 RVA: 0x001B2B04 File Offset: 0x001B0D04
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

	// Token: 0x06005129 RID: 20777 RVA: 0x001B2BB4 File Offset: 0x001B0DB4
	public int GetPosition()
	{
		return this.Index + 1;
	}

	// Token: 0x0600512A RID: 20778 RVA: 0x001B2BC0 File Offset: 0x001B0DC0
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

	// Token: 0x0600512B RID: 20779 RVA: 0x001B2BF4 File Offset: 0x001B0DF4
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

	// Token: 0x0600512C RID: 20780 RVA: 0x001B2CBC File Offset: 0x001B0EBC
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

	// Token: 0x0600512D RID: 20781 RVA: 0x001B2D68 File Offset: 0x001B0F68
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

	// Token: 0x0600512E RID: 20782 RVA: 0x001B2DEF File Offset: 0x001B0FEF
	public int GetEndGridId()
	{
		if (this.GridList.Count <= 0)
		{
			return 0;
		}
		return this.GridList[this.GridList.Count - 1].Id;
	}

	// Token: 0x0600512F RID: 20783 RVA: 0x001B2E1E File Offset: 0x001B101E
	public int GetStartGridId()
	{
		if (this.GridList.Count <= 0)
		{
			return 0;
		}
		return this.GridList[0].Id;
	}

	// Token: 0x06005130 RID: 20784 RVA: 0x001B2E44 File Offset: 0x001B1044
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

	// Token: 0x06005131 RID: 20785 RVA: 0x001B2EA0 File Offset: 0x001B10A0
	public bool IsLock()
	{
		return this.GetUnlockRemainTime() > 0.0;
	}

	// Token: 0x06005132 RID: 20786 RVA: 0x001B2EB3 File Offset: 0x001B10B3
	public double GetUnlockRemainTime()
	{
		if (this.UnlockTime <= 0L)
		{
			return 0.0;
		}
		return Math.Max(0.0, (double)this.UnlockTime - TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06005133 RID: 20787 RVA: 0x001B2EE9 File Offset: 0x001B10E9
	public void UpdateUnlockTime(long time)
	{
		this.UnlockTime = time;
	}

	// Token: 0x06005134 RID: 20788 RVA: 0x001B2EF2 File Offset: 0x001B10F2
	public void UpdateRollDiceTimes(int num)
	{
		this.RecordRollDiceTimes = num;
	}

	// Token: 0x06005135 RID: 20789 RVA: 0x001B2EFB File Offset: 0x001B10FB
	public void AddRollDiceTimes()
	{
		this.RecordRollDiceTimes++;
	}

	// Token: 0x06005136 RID: 20790 RVA: 0x001B2F0B File Offset: 0x001B110B
	public void UpdateRecordTriggerBuff(int id, int times)
	{
		this.RecordTriggerBuffMap[id] = times;
	}

	// Token: 0x06005137 RID: 20791 RVA: 0x001B2F1C File Offset: 0x001B111C
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

	// Token: 0x06005138 RID: 20792 RVA: 0x001B2F4F File Offset: 0x001B114F
	public void ClearRecordTriggerBuff()
	{
		this.RecordTriggerBuffMap.Clear();
	}

	// Token: 0x06005139 RID: 20793 RVA: 0x001B2F5C File Offset: 0x001B115C
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

	// Token: 0x0600513A RID: 20794 RVA: 0x001B2FD4 File Offset: 0x001B11D4
	public void UpdateOwnedBuffIdList(int id)
	{
		this.OwnedBuffIdList.Add(id);
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x001B2FE2 File Offset: 0x001B11E2
	public void ClearOwnedBuffIdList()
	{
		this.OwnedBuffIdList.Clear();
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x001B2FF0 File Offset: 0x001B11F0
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

	// Token: 0x0600513D RID: 20797 RVA: 0x001B3054 File Offset: 0x001B1254
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

	// Token: 0x0600513E RID: 20798 RVA: 0x001B30F0 File Offset: 0x001B12F0
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x040039B0 RID: 14768
	public int Id;

	// Token: 0x040039B1 RID: 14769
	public int GroupId;

	// Token: 0x040039B2 RID: 14770
	public int Index;

	// Token: 0x040039B3 RID: 14771
	public bool IsRewarded;

	// Token: 0x040039B4 RID: 14772
	public int RewardItemId;

	// Token: 0x040039B5 RID: 14773
	public int RewardItemCount;

	// Token: 0x040039B6 RID: 14774
	public string FinishTitle = "";

	// Token: 0x040039B7 RID: 14775
	public string FinishDesc = "";

	// Token: 0x040039B8 RID: 14776
	public readonly List<DangoMonopolyGridData> GridList = new List<DangoMonopolyGridData>();

	// Token: 0x040039B9 RID: 14777
	public readonly Dictionary<int, DangoMonopolyGridData> GridMap = new Dictionary<int, DangoMonopolyGridData>();

	// Token: 0x040039BA RID: 14778
	[Nullable(2)]
	public ActivityDangoMonopolyData ActivityData;

	// Token: 0x040039BB RID: 14779
	public long UnlockTime;

	// Token: 0x040039BC RID: 14780
	public int RecordRollDiceTimes;

	// Token: 0x040039BD RID: 14781
	public readonly Dictionary<int, int> RecordTriggerBuffMap = new Dictionary<int, int>();

	// Token: 0x040039BE RID: 14782
	public readonly List<int> OwnedBuffIdList = new List<int>();
}
