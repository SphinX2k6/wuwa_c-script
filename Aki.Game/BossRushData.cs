using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;

// Token: 0x020011BA RID: 4538
[NullableContext(1)]
[Nullable(0)]
public class BossRushData : ActivityBaseData
{
	// Token: 0x0600789C RID: 30876 RVA: 0x001950A0 File Offset: 0x001932A0
	protected override void PhraseEx(ActivityData data)
	{
		this.CurrentBuffs = data.BossRushActivityData.UnlockedBuffIndices.ToArray<int>();
		this.PhraseLevelInfo(this.CurrentBuffs, data.BossRushActivityData.BossRushLevelInfo.ToArray<BossRushLevelData>());
		this.CheckIfNewBossRushOpen();
		this.PhraseRewardInfo(data.BossRushActivityData.BossRushScoreScoreRewardInfo.ToArray<BossRushScoreRewardData>());
		this.RefreshTaskData(data.BossRushActivityData.ActivityTasks.ToArray<ActivityTask>());
		this.CurrentData = data;
		EventSystem.Instance.Emit(EEventName.BossRushDataUpdate);
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
		{
			EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.GetRewardViewData());
		}
		EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, base.Id);
	}

	// Token: 0x0600789D RID: 30877 RVA: 0x00195168 File Offset: 0x00193368
	public void RefreshSingleTaskData(ActivityTask task)
	{
		global::ActivityTaskData activityTaskData;
		if (!this.TaskData.TryGetValue(task.Id, out activityTaskData))
		{
			activityTaskData = new global::ActivityTaskData();
			int tabId = BossRushConfig.Instance.GetBossRushTaskConfig(task.Id).TabId;
			List<global::ActivityTaskData> list;
			if (!this.TabTaskData.TryGetValue(tabId, out list))
			{
				list = new List<global::ActivityTaskData>();
			}
			list.Add(activityTaskData);
			this.TabTaskData[tabId] = list;
		}
		activityTaskData.Refresh(task, null);
		this.TaskData[task.Id] = activityTaskData;
	}

	// Token: 0x0600789E RID: 30878 RVA: 0x001951F0 File Offset: 0x001933F0
	public void RefreshTaskData(ActivityTask[] tasks)
	{
		foreach (ActivityTask task in tasks)
		{
			this.RefreshSingleTaskData(task);
		}
	}

	// Token: 0x0600789F RID: 30879 RVA: 0x00195218 File Offset: 0x00193418
	public int GetFinishTaskCount()
	{
		int num = 0;
		foreach (global::ActivityTaskData activityTaskData in this.TaskData.Values)
		{
			if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed || activityTaskData.Status == EActivityTaskState.FinishedAndClaimed)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060078A0 RID: 30880 RVA: 0x00195284 File Offset: 0x00193484
	public int GetAllTaskCount()
	{
		return this.TaskData.Count;
	}

	// Token: 0x060078A1 RID: 30881 RVA: 0x00195294 File Offset: 0x00193494
	public List<BossRushTaskTab> GetBossRushAllTabData()
	{
		IEnumerable<BossRushTaskTab> bossRushTabListByActivityId = BossRushConfig.Instance.GetBossRushTabListByActivityId(base.Id);
		List<BossRushTaskTab> list = new List<BossRushTaskTab>();
		foreach (BossRushTaskTab item in bossRushTabListByActivityId)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060078A2 RID: 30882 RVA: 0x001952F4 File Offset: 0x001934F4
	public bool GetTabRedDotState(int tabId)
	{
		List<global::ActivityTaskData> list;
		if (!this.TabTaskData.TryGetValue(tabId, out list))
		{
			return false;
		}
		using (List<global::ActivityTaskData>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060078A3 RID: 30883 RVA: 0x0019535C File Offset: 0x0019355C
	public void RebuildData()
	{
		if (this.CurrentData != null)
		{
			this.PhraseEx(this.CurrentData);
		}
	}

	// Token: 0x060078A4 RID: 30884 RVA: 0x00195372 File Offset: 0x00193572
	public void SetInsSelectedBuffIdMap(int levelId, int[] buffIds)
	{
		this.InsSelectedBuffIdMap[levelId] = buffIds;
	}

	// Token: 0x060078A5 RID: 30885 RVA: 0x00195384 File Offset: 0x00193584
	public int[] GetInsSelectedBuffId(int levelId)
	{
		int[] result;
		if (!this.InsSelectedBuffIdMap.TryGetValue(levelId, out result))
		{
			return new int[0];
		}
		return result;
	}

	// Token: 0x060078A6 RID: 30886 RVA: 0x001953AC File Offset: 0x001935AC
	public void PhraseRewardInfo(BossRushScoreRewardData[] rewardData)
	{
		this.CurrentScoreRewardInfo = new List<IActivityRewardData>();
		foreach (BossRushScoreRewardData reward in rewardData)
		{
			IActivityRewardData item = this.CreateScoreReward(reward);
			this.CurrentScoreRewardInfo.Add(item);
		}
		if (this.CurrentData != null && this.CurrentData.BossRushActivityData != null)
		{
			this.CurrentData.BossRushActivityData.BossRushScoreScoreRewardInfo.Clear();
			this.CurrentData.BossRushActivityData.BossRushScoreScoreRewardInfo.AddRange(rewardData);
		}
	}

	// Token: 0x060078A7 RID: 30887 RVA: 0x0019542C File Offset: 0x0019362C
	public void PhraseLevelInfo(int[] unlockBuffs, BossRushLevelData[] data)
	{
		this.CurrentLevelInfo = new List<BossRushLevelDetailInfo>();
		this.CurrentLevelRewardInfo = new List<IActivityRewardData>();
		this.CurrentLevelRewardInfoMap.Clear();
		foreach (BossRushLevelData bossRushLevelData in data)
		{
			BossRushLevelDetailInfo bossRushLevelDetailInfo = new BossRushLevelDetailInfo();
			bossRushLevelDetailInfo.Phrase(base.Id, bossRushLevelData, unlockBuffs);
			this.CurrentLevelInfo.Add(bossRushLevelDetailInfo);
			List<IActivityRewardData> list = this.CreateLevelReward(bossRushLevelDetailInfo, bossRushLevelData);
			this.CurrentLevelRewardInfo.AddRange(list);
			this.CurrentLevelRewardInfoMap[bossRushLevelDetailInfo.GetId()] = list;
		}
		this.CurrentLevelRewardInfo.Reverse();
		if (this.CurrentData != null && this.CurrentData.BossRushActivityData != null)
		{
			this.CurrentData.BossRushActivityData.BossRushLevelInfo.Clear();
			this.CurrentData.BossRushActivityData.BossRushLevelInfo.AddRange(data);
			this.CurrentData.BossRushActivityData.UnlockedBuffIndices.Clear();
			this.CurrentData.BossRushActivityData.UnlockedBuffIndices.AddRange(unlockBuffs);
		}
	}

	// Token: 0x060078A8 RID: 30888 RVA: 0x00195530 File Offset: 0x00193730
	[NullableContext(2)]
	public BossRushLevelDetailInfo GetBossRushLevelDetailInfoById(int instanceId)
	{
		foreach (BossRushLevelDetailInfo bossRushLevelDetailInfo in this.CurrentLevelInfo)
		{
			if (bossRushLevelDetailInfo.GetId() == instanceId)
			{
				return bossRushLevelDetailInfo;
			}
		}
		return null;
	}

	// Token: 0x060078A9 RID: 30889 RVA: 0x0019558C File Offset: 0x0019378C
	public List<BossRushLevelDetailInfo> GetBossRushLevelDetailInfo()
	{
		return this.CurrentLevelInfo;
	}

	// Token: 0x060078AA RID: 30890 RVA: 0x00195594 File Offset: 0x00193794
	public override bool GetExDataRedPointShowState()
	{
		return base.GetPreGuideQuestFinishState() && (this.NewOpenBossRushState || this.GetIfCanTakeReward());
	}

	// Token: 0x060078AB RID: 30891 RVA: 0x001955B0 File Offset: 0x001937B0
	public bool GetNewUnlockState()
	{
		return this.NeedShowNewUnlock;
	}

	// Token: 0x060078AC RID: 30892 RVA: 0x001955B8 File Offset: 0x001937B8
	public bool GetNewBuffState()
	{
		return this.NeedShowNewBuff;
	}

	// Token: 0x060078AD RID: 30893 RVA: 0x001955C0 File Offset: 0x001937C0
	private bool GetIfCanTakeReward()
	{
		using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.TaskData.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060078AE RID: 30894 RVA: 0x00195620 File Offset: 0x00193820
	private bool GetIfCanTakeRewardByLevelId(int levelId)
	{
		foreach (IActivityRewardData activityRewardData in this.CurrentLevelRewardInfo)
		{
			int? id = activityRewardData.Id;
			if ((id.GetValueOrDefault() == levelId & id != null) && activityRewardData.RewardState == EActivityRewardState.Enable)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060078AF RID: 30895 RVA: 0x0019569C File Offset: 0x0019389C
	public int[] GetUnlockedBuffIndices()
	{
		return this.CurrentBuffs;
	}

	// Token: 0x060078B0 RID: 30896 RVA: 0x001956A4 File Offset: 0x001938A4
	public void CheckIfNewBossRushOpen()
	{
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 0, 0);
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		this.NewOpenBossRushState = (currentOpenBossNum > activityCacheData);
		int activityCacheData2 = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 100, 0);
		this.NeedShowNewUnlock = (currentOpenBossNum > activityCacheData2);
		this.CheckIfNewBuffOpen();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060078B1 RID: 30897 RVA: 0x00195720 File Offset: 0x00193920
	private void CheckIfNewBuffOpen()
	{
		this.NeedShowNewBuff = false;
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 200, 0);
		int currentCheckBuffIndex = this.GetCurrentCheckBuffIndex();
		if (currentCheckBuffIndex > activityCacheData && currentCheckBuffIndex > 0)
		{
			BossRushLevelDetailInfo bossRushLevelDetailInfo = this.GetBossRushLevelDetailInfo()[currentCheckBuffIndex - 1];
			if (bossRushLevelDetailInfo != null && bossRushLevelDetailInfo.GetConfig() != null)
			{
				int[] array = bossRushLevelDetailInfo.GetConfig().Value.UnlockBuff();
				this.NeedShowNewBuff = (array != null && array.Length != 0);
			}
		}
	}

	// Token: 0x060078B2 RID: 30898 RVA: 0x001957B0 File Offset: 0x001939B0
	private int GetCurrentCheckBuffIndex()
	{
		int result = 0;
		List<BossRushLevelDetailInfo> bossRushLevelDetailInfo = this.GetBossRushLevelDetailInfo();
		int count = bossRushLevelDetailInfo.Count;
		for (int i = 0; i < count; i++)
		{
			if (bossRushLevelDetailInfo[i].GetUnLockState())
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x060078B3 RID: 30899 RVA: 0x001957EC File Offset: 0x001939EC
	private int GetCurrentOpenBossNum()
	{
		int num = 0;
		using (List<BossRushLevelDetailInfo>.Enumerator enumerator = this.GetBossRushLevelDetailInfo().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetUnLockState())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060078B4 RID: 30900 RVA: 0x00195848 File Offset: 0x00193A48
	public void CacheNewBuffUnlock()
	{
		this.NeedShowNewBuff = false;
		int currentCheckBuffIndex = this.GetCurrentCheckBuffIndex();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 200, 0, currentCheckBuffIndex);
		this.CheckIfNewBuffOpen();
	}

	// Token: 0x060078B5 RID: 30901 RVA: 0x00195888 File Offset: 0x00193A88
	public void CacheNewUnlock()
	{
		this.NeedShowNewUnlock = false;
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 100, 0, currentOpenBossNum);
		this.CheckIfNewBossRushOpen();
	}

	// Token: 0x060078B6 RID: 30902 RVA: 0x001958C4 File Offset: 0x00193AC4
	public void CacheCurrentOpenBossNum()
	{
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 0, 0, currentOpenBossNum);
		this.CheckIfNewBossRushOpen();
	}

	// Token: 0x060078B7 RID: 30903 RVA: 0x001958F7 File Offset: 0x00193AF7
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x060078B8 RID: 30904 RVA: 0x001958FF File Offset: 0x00193AFF
	public bool HaveRewardCanTake()
	{
		return this.GetIfCanTakeReward();
	}

	// Token: 0x060078B9 RID: 30905 RVA: 0x00195907 File Offset: 0x00193B07
	public bool HaveLevelRewardCanTake(int levelId)
	{
		return this.GetIfCanTakeRewardByLevelId(levelId);
	}

	// Token: 0x060078BA RID: 30906 RVA: 0x00195910 File Offset: 0x00193B10
	public IActivityRewardViewData GetRewardPopUpViewData()
	{
		this.RebuildData();
		return this.GetRewardViewData();
	}

	// Token: 0x060078BB RID: 30907 RVA: 0x00195920 File Offset: 0x00193B20
	public IActivityRewardViewData GetRewardViewData()
	{
		string tabTips = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("BossRushFullPoint", null) ?? "", new string[]
		{
			this.GetFullScore().ToString()
		});
		List<IActivityRewardData> dataList = (from a in this.CurrentLevelRewardInfo
		orderby this.GetRewardSort(a) descending, a.Id.GetValueOrDefault()
		select a).ToList<IActivityRewardData>();
		ActivityRewardDataPage item = new ActivityRewardDataPage
		{
			DataList = dataList,
			TabName = ConfigMultiTextLang.GetLocalTextNew("BossRushLevelRewardText", null),
			TabTips = " "
		};
		ActivityRewardDataPage activityRewardDataPage = new ActivityRewardDataPage();
		activityRewardDataPage.DataList = (from a in this.CurrentScoreRewardInfo
		orderby this.GetRewardSort(a), a.Id.GetValueOrDefault()
		select a).ToList<IActivityRewardData>();
		activityRewardDataPage.TabName = ConfigMultiTextLang.GetLocalTextNew("BossRushScoreRewardText", null);
		activityRewardDataPage.TabTips = tabTips;
		ActivityRewardDataPage item2 = activityRewardDataPage;
		return new ActivityRewardViewData
		{
			DataPageList = new List<IActivityRewardDataPage>
			{
				item,
				item2
			},
			Source = EActivityRewardSource.BossRush
		};
	}

	// Token: 0x060078BC RID: 30908 RVA: 0x00195A58 File Offset: 0x00193C58
	private int GetRewardSort(IActivityRewardData data)
	{
		int result;
		switch (data.RewardState)
		{
		case EActivityRewardState.Disabled:
			result = 2;
			break;
		case EActivityRewardState.Enable:
			result = 3;
			break;
		case EActivityRewardState.Claimed:
			result = 1;
			break;
		default:
			result = 4;
			break;
		}
		return result;
	}

	// Token: 0x060078BD RID: 30909 RVA: 0x00195A94 File Offset: 0x00193C94
	public int GetFullScore()
	{
		int num = 0;
		foreach (BossRushLevelDetailInfo bossRushLevelDetailInfo in this.CurrentLevelInfo)
		{
			num += bossRushLevelDetailInfo.GetScore();
		}
		return num;
	}

	// Token: 0x060078BE RID: 30910 RVA: 0x00195AEC File Offset: 0x00193CEC
	private IActivityRewardData CreateScoreReward(BossRushScoreRewardData reward)
	{
		BossRushScore? bossRushScoreConfigById = BossRushConfig.Instance.GetBossRushScoreConfigById(reward.RewardId);
		if (bossRushScoreConfigById == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
			defaultInterpolatedStringHandler.AppendLiteral("BossRushScoreConfig not found for id: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(reward.RewardId);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string nameText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("BossRushFullScoreTips", null) ?? "", new string[]
		{
			bossRushScoreConfigById.Value.Score.ToString()
		});
		return new ActivityRewardData
		{
			Id = new int?(reward.RewardId),
			NameText = nameText,
			RewardState = (EActivityRewardState)reward.RewardClaimStatus,
			ClickFunction = delegate
			{
				BossRushController.Instance.RequestGetBossRushReward(this.Id, reward.RewardId, BossRushRewardType.Score);
			},
			RewardList = this.GetRewardItems(bossRushScoreConfigById.Value.RewardId),
			RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)reward.RewardClaimStatus), null)
		};
	}

	// Token: 0x060078BF RID: 30911 RVA: 0x00195C1C File Offset: 0x00193E1C
	private string GetButtonText(int state)
	{
		string result = "";
		switch (state)
		{
		case 0:
			result = "PrefabTextItem_1443074454_Text";
			break;
		case 1:
			result = "CollectActivity_state_CanRecive";
			break;
		case 2:
			result = "CollectActivity_state_recived";
			break;
		}
		return result;
	}

	// Token: 0x060078C0 RID: 30912 RVA: 0x00195C5C File Offset: 0x00193E5C
	private TItem[] GetRewardItems(int dropId)
	{
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(dropId);
		if (dropPackagePreview != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			}
		}
		return list.ToArray();
	}

	// Token: 0x060078C1 RID: 30913 RVA: 0x00195CE0 File Offset: 0x00193EE0
	private List<IActivityRewardData> CreateLevelReward(BossRushLevelDetailInfo levelInfo, BossRushLevelData levelData)
	{
		BossRushActivity? config = BossRushConfig.Instance.GetBossRushByActivityIdAndInstanceId(base.Id, levelData.InstId);
		if (config == null)
		{
			return new List<IActivityRewardData>();
		}
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		int index = 0;
		Action <>9__0;
		foreach (BossRushRewardClaimStatus bossRushRewardClaimStatus in levelData.LevelScoreRewardStatus)
		{
			IntPair intPair = config.Value.LevelScoreRewardList()[index];
			ActivityRewardData activityRewardData = new ActivityRewardData();
			activityRewardData.Id = new int?(levelInfo.GetId());
			activityRewardData.NameText = (ConfigMultiTextLang.GetLocalTextNew(config.Value.LevelRewardDesc, null) ?? "");
			activityRewardData.NameTextArgs = new string[]
			{
				intPair.Item1.ToString() ?? "",
				levelData.Score.ToString() ?? ""
			};
			activityRewardData.RewardState = (EActivityRewardState)bossRushRewardClaimStatus;
			ActivityRewardData activityRewardData2 = activityRewardData;
			Action clickFunction;
			if ((clickFunction = <>9__0) == null)
			{
				clickFunction = (<>9__0 = delegate()
				{
					int index2 = index;
					BossRushController.Instance.RequestGetBossRushLevelReward(this.Id, config.Value.Id, config.Value.InstId, index2);
				});
			}
			activityRewardData2.ClickFunction = clickFunction;
			activityRewardData.RewardList = this.GetRewardItems(intPair.Item2);
			activityRewardData.RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)bossRushRewardClaimStatus), null);
			ActivityRewardData item = activityRewardData;
			list.Add(item);
			int index3 = index;
			index = index3 + 1;
		}
		return list;
	}

	// Token: 0x060078C2 RID: 30914 RVA: 0x00195EA0 File Offset: 0x001940A0
	private IActivityRewardData CreateTaskReward(global::ActivityTaskData task)
	{
		EActivityTaskState status = task.Status;
		int current = task.Current;
		int target = task.Target;
		BossRushTaskConfig config = BossRushConfig.Instance.GetBossRushTaskConfig(task.Id);
		return new ActivityRewardData
		{
			Id = new int?(task.Id),
			NameText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(config.Title, null) ?? "", new string[]
			{
				target.ToString()
			}),
			NameTextArgs = new string[]
			{
				current.ToString() ?? "",
				target.ToString() ?? ""
			},
			RewardState = TaskStateToRewardStateResolver.Value[status],
			ClickFunction = delegate
			{
				BossRushController.Instance.RequestBossRushTaskReward(config.ActivityId);
			},
			RewardList = this.GetRewardItems(config.DropId),
			RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)TaskStateToRewardStateResolver.Value[status]), null)
		};
	}

	// Token: 0x060078C3 RID: 30915 RVA: 0x00195FC0 File Offset: 0x001941C0
	public List<IActivityRewardData> GetTabRewardData(int tabId)
	{
		if (tabId == 0)
		{
			return new List<IActivityRewardData>();
		}
		List<global::ActivityTaskData> list;
		if (!this.TabTaskData.TryGetValue(tabId, out list))
		{
			return new List<IActivityRewardData>();
		}
		List<IActivityRewardData> list2 = new List<IActivityRewardData>();
		foreach (global::ActivityTaskData task in list)
		{
			IActivityRewardData item = this.CreateTaskReward(task);
			list2.Add(item);
		}
		return (from a in list2
		orderby this.GetRewardSort(a), a.Id.GetValueOrDefault()
		select a).ToList<IActivityRewardData>();
	}

	// Token: 0x060078C4 RID: 30916 RVA: 0x00196078 File Offset: 0x00194278
	public List<IActivityRewardData> GetRewardByLevelId(int? levelId = null)
	{
		int valueOrDefault = levelId.GetValueOrDefault();
		List<IActivityRewardData> result;
		if (!this.CurrentLevelRewardInfoMap.TryGetValue(valueOrDefault, out result))
		{
			return new List<IActivityRewardData>();
		}
		return result;
	}

	// Token: 0x060078C5 RID: 30917 RVA: 0x001960A4 File Offset: 0x001942A4
	public void SetRewardStateClaimed(int levelId, int index)
	{
		List<IActivityRewardData> list;
		if (!this.CurrentLevelRewardInfoMap.TryGetValue(levelId, out list))
		{
			return;
		}
		if (index >= list.Count)
		{
			return;
		}
		IActivityRewardData activityRewardData = list[index];
		if (activityRewardData == null)
		{
			return;
		}
		activityRewardData.RewardState = EActivityRewardState.Claimed;
	}

	// Token: 0x060078C6 RID: 30918 RVA: 0x001960E0 File Offset: 0x001942E0
	protected override bool GetExDataFinishShowState()
	{
		using (Dictionary<int, global::ActivityTaskData>.ValueCollection.Enumerator enumerator = this.TaskData.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060078C7 RID: 30919 RVA: 0x00196140 File Offset: 0x00194340
	public int[] GetFinishAndUnclaimedTaskList()
	{
		List<int> list = new List<int>();
		foreach (global::ActivityTaskData activityTaskData in this.TaskData.Values)
		{
			if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				list.Add(activityTaskData.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x04003773 RID: 14195
	private const int UNLOCKLOCALKEY = 100;

	// Token: 0x04003774 RID: 14196
	private const int UNLOCKBUFFKEY = 200;

	// Token: 0x04003775 RID: 14197
	private List<IActivityRewardData> CurrentLevelRewardInfo = new List<IActivityRewardData>();

	// Token: 0x04003776 RID: 14198
	private readonly Dictionary<int, List<IActivityRewardData>> CurrentLevelRewardInfoMap = new Dictionary<int, List<IActivityRewardData>>();

	// Token: 0x04003777 RID: 14199
	private readonly Dictionary<int, global::ActivityTaskData> TaskData = new Dictionary<int, global::ActivityTaskData>();

	// Token: 0x04003778 RID: 14200
	private readonly Dictionary<int, List<global::ActivityTaskData>> TabTaskData = new Dictionary<int, List<global::ActivityTaskData>>();

	// Token: 0x04003779 RID: 14201
	private List<IActivityRewardData> CurrentScoreRewardInfo = new List<IActivityRewardData>();

	// Token: 0x0400377A RID: 14202
	private bool NewOpenBossRushState;

	// Token: 0x0400377B RID: 14203
	private bool NeedShowNewUnlock;

	// Token: 0x0400377C RID: 14204
	private bool NeedShowNewBuff;

	// Token: 0x0400377D RID: 14205
	private List<BossRushLevelDetailInfo> CurrentLevelInfo = new List<BossRushLevelDetailInfo>();

	// Token: 0x0400377E RID: 14206
	private int[] CurrentBuffs = new int[0];

	// Token: 0x0400377F RID: 14207
	[Nullable(2)]
	private ActivityData CurrentData;

	// Token: 0x04003780 RID: 14208
	private readonly Dictionary<int, int[]> InsSelectedBuffIdMap = new Dictionary<int, int[]>();
}
