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

// Token: 0x0200066E RID: 1646
[NullableContext(1)]
[Nullable(0)]
public class BossRushData : ActivityBaseData
{
	// Token: 0x06004C33 RID: 19507 RVA: 0x0019DCA8 File Offset: 0x0019BEA8
	protected override void PhraseEx(ActivityData data)
	{
		this.CurrentBuffs = data.BossRushActivityData.UnlockedBuffIndices.ToArray<int>();
		this.PhraseLevelInfo(this.CurrentBuffs, data.BossRushActivityData.BossRushLevelInfo);
		this.CheckIfNewBossRushOpen();
		this.PhraseRewardInfo(data.BossRushActivityData.BossRushScoreScoreRewardInfo);
		this.RefreshTaskData(data.BossRushActivityData.ActivityTasks);
		this.CurrentData = data;
		EventSystem.Instance.Emit(EEventName.BossRushDataUpdate);
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
		{
			EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.GetRewardViewData());
		}
		EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, base.Id);
	}

	// Token: 0x06004C34 RID: 19508 RVA: 0x0019DD60 File Offset: 0x0019BF60
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

	// Token: 0x06004C35 RID: 19509 RVA: 0x0019DDE8 File Offset: 0x0019BFE8
	public void RefreshTaskData(IReadOnlyList<ActivityTask> tasks)
	{
		foreach (ActivityTask task in tasks)
		{
			this.RefreshSingleTaskData(task);
		}
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x0019DE30 File Offset: 0x0019C030
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

	// Token: 0x06004C37 RID: 19511 RVA: 0x0019DE9C File Offset: 0x0019C09C
	public int GetAllTaskCount()
	{
		return this.TaskData.Count;
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x0019DEAC File Offset: 0x0019C0AC
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

	// Token: 0x06004C39 RID: 19513 RVA: 0x0019DF0C File Offset: 0x0019C10C
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

	// Token: 0x06004C3A RID: 19514 RVA: 0x0019DF74 File Offset: 0x0019C174
	public void RebuildData()
	{
		if (this.CurrentData != null)
		{
			this.PhraseEx(this.CurrentData);
		}
	}

	// Token: 0x06004C3B RID: 19515 RVA: 0x0019DF8A File Offset: 0x0019C18A
	public void SetInsSelectedBuffIdMap(int levelId, int[] buffIds)
	{
		this.InsSelectedBuffIdMap[levelId] = buffIds;
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x0019DF9C File Offset: 0x0019C19C
	public int[] GetInsSelectedBuffId(int levelId)
	{
		int[] result;
		if (!this.InsSelectedBuffIdMap.TryGetValue(levelId, out result))
		{
			return new int[0];
		}
		return result;
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x0019DFC4 File Offset: 0x0019C1C4
	public void PhraseRewardInfo(IReadOnlyList<BossRushScoreRewardData> rewardData)
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

	// Token: 0x06004C3E RID: 19518 RVA: 0x0019E064 File Offset: 0x0019C264
	public void PhraseLevelInfo(int[] unlockBuffs, IReadOnlyList<BossRushLevelData> data)
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

	// Token: 0x06004C3F RID: 19519 RVA: 0x0019E184 File Offset: 0x0019C384
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

	// Token: 0x06004C40 RID: 19520 RVA: 0x0019E1E0 File Offset: 0x0019C3E0
	public List<BossRushLevelDetailInfo> GetBossRushLevelDetailInfo()
	{
		return this.CurrentLevelInfo;
	}

	// Token: 0x06004C41 RID: 19521 RVA: 0x0019E1E8 File Offset: 0x0019C3E8
	public override bool GetExDataRedPointShowState()
	{
		return base.GetPreGuideQuestFinishState() && (this.NewOpenBossRushState || this.GetIfCanTakeReward());
	}

	// Token: 0x06004C42 RID: 19522 RVA: 0x0019E204 File Offset: 0x0019C404
	public bool GetNewUnlockState()
	{
		return this.NeedShowNewUnlock;
	}

	// Token: 0x06004C43 RID: 19523 RVA: 0x0019E20C File Offset: 0x0019C40C
	public bool GetNewBuffState()
	{
		return this.NeedShowNewBuff;
	}

	// Token: 0x06004C44 RID: 19524 RVA: 0x0019E214 File Offset: 0x0019C414
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

	// Token: 0x06004C45 RID: 19525 RVA: 0x0019E274 File Offset: 0x0019C474
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

	// Token: 0x06004C46 RID: 19526 RVA: 0x0019E2F0 File Offset: 0x0019C4F0
	public int[] GetUnlockedBuffIndices()
	{
		return this.CurrentBuffs;
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x0019E2F8 File Offset: 0x0019C4F8
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

	// Token: 0x06004C48 RID: 19528 RVA: 0x0019E374 File Offset: 0x0019C574
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

	// Token: 0x06004C49 RID: 19529 RVA: 0x0019E404 File Offset: 0x0019C604
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

	// Token: 0x06004C4A RID: 19530 RVA: 0x0019E440 File Offset: 0x0019C640
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

	// Token: 0x06004C4B RID: 19531 RVA: 0x0019E49C File Offset: 0x0019C69C
	public void CacheNewBuffUnlock()
	{
		this.NeedShowNewBuff = false;
		int currentCheckBuffIndex = this.GetCurrentCheckBuffIndex();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 200, 0, currentCheckBuffIndex);
		this.CheckIfNewBuffOpen();
	}

	// Token: 0x06004C4C RID: 19532 RVA: 0x0019E4DC File Offset: 0x0019C6DC
	public void CacheNewUnlock()
	{
		this.NeedShowNewUnlock = false;
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 100, 0, currentOpenBossNum);
		this.CheckIfNewBossRushOpen();
	}

	// Token: 0x06004C4D RID: 19533 RVA: 0x0019E518 File Offset: 0x0019C718
	public void CacheCurrentOpenBossNum()
	{
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 0, 0, currentOpenBossNum);
		this.CheckIfNewBossRushOpen();
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x0019E54B File Offset: 0x0019C74B
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x0019E553 File Offset: 0x0019C753
	public bool HaveRewardCanTake()
	{
		return this.GetIfCanTakeReward();
	}

	// Token: 0x06004C50 RID: 19536 RVA: 0x0019E55B File Offset: 0x0019C75B
	public bool HaveLevelRewardCanTake(int levelId)
	{
		return this.GetIfCanTakeRewardByLevelId(levelId);
	}

	// Token: 0x06004C51 RID: 19537 RVA: 0x0019E564 File Offset: 0x0019C764
	public IActivityRewardViewData GetRewardPopUpViewData()
	{
		this.RebuildData();
		return this.GetRewardViewData();
	}

	// Token: 0x06004C52 RID: 19538 RVA: 0x0019E574 File Offset: 0x0019C774
	public IActivityRewardViewData GetRewardViewData()
	{
		string tabTips = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("BossRushFullPoint", null) ?? "", new string[]
		{
			this.GetFullScore().ToString()
		});
		List<IActivityRewardData> dataList = NoLinq.SortToList<IActivityRewardData>(this.CurrentLevelRewardInfo, delegate(IActivityRewardData left, IActivityRewardData right)
		{
			int num = this.GetRewardSort(right).CompareTo(this.GetRewardSort(left));
			if (num == 0)
			{
				return left.Id.GetValueOrDefault().CompareTo(right.Id.GetValueOrDefault());
			}
			return num;
		});
		ActivityRewardDataPage item = new ActivityRewardDataPage
		{
			DataList = dataList,
			TabName = ConfigMultiTextLang.GetLocalTextNew("BossRushLevelRewardText", null),
			TabTips = " "
		};
		List<IActivityRewardData> dataList2 = NoLinq.SortToList<IActivityRewardData>(this.CurrentScoreRewardInfo, delegate(IActivityRewardData left, IActivityRewardData right)
		{
			int num = this.GetRewardSort(left).CompareTo(this.GetRewardSort(right));
			if (num == 0)
			{
				return left.Id.GetValueOrDefault().CompareTo(right.Id.GetValueOrDefault());
			}
			return num;
		});
		ActivityRewardDataPage item2 = new ActivityRewardDataPage
		{
			DataList = dataList2,
			TabName = ConfigMultiTextLang.GetLocalTextNew("BossRushScoreRewardText", null),
			TabTips = tabTips
		};
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

	// Token: 0x06004C53 RID: 19539 RVA: 0x0019E65C File Offset: 0x0019C85C
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

	// Token: 0x06004C54 RID: 19540 RVA: 0x0019E698 File Offset: 0x0019C898
	public int GetFullScore()
	{
		int num = 0;
		foreach (BossRushLevelDetailInfo bossRushLevelDetailInfo in this.CurrentLevelInfo)
		{
			num += bossRushLevelDetailInfo.GetScore();
		}
		return num;
	}

	// Token: 0x06004C55 RID: 19541 RVA: 0x0019E6F0 File Offset: 0x0019C8F0
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

	// Token: 0x06004C56 RID: 19542 RVA: 0x0019E820 File Offset: 0x0019CA20
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

	// Token: 0x06004C57 RID: 19543 RVA: 0x0019E860 File Offset: 0x0019CA60
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

	// Token: 0x06004C58 RID: 19544 RVA: 0x0019E8E4 File Offset: 0x0019CAE4
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

	// Token: 0x06004C59 RID: 19545 RVA: 0x0019EAA4 File Offset: 0x0019CCA4
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

	// Token: 0x06004C5A RID: 19546 RVA: 0x0019EBC4 File Offset: 0x0019CDC4
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
		NoLinq.SortStable<IActivityRewardData>(list2, delegate(IActivityRewardData left, IActivityRewardData right)
		{
			int num = this.GetRewardSort(left).CompareTo(this.GetRewardSort(right));
			if (num == 0)
			{
				return left.Id.GetValueOrDefault().CompareTo(right.Id.GetValueOrDefault());
			}
			return num;
		});
		return list2;
	}

	// Token: 0x06004C5B RID: 19547 RVA: 0x0019EC54 File Offset: 0x0019CE54
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

	// Token: 0x06004C5C RID: 19548 RVA: 0x0019EC80 File Offset: 0x0019CE80
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

	// Token: 0x06004C5D RID: 19549 RVA: 0x0019ECBC File Offset: 0x0019CEBC
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

	// Token: 0x06004C5E RID: 19550 RVA: 0x0019ED1C File Offset: 0x0019CF1C
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

	// Token: 0x0400380C RID: 14348
	private const int UNLOCKLOCALKEY = 100;

	// Token: 0x0400380D RID: 14349
	private const int UNLOCKBUFFKEY = 200;

	// Token: 0x0400380E RID: 14350
	private List<IActivityRewardData> CurrentLevelRewardInfo = new List<IActivityRewardData>();

	// Token: 0x0400380F RID: 14351
	private readonly Dictionary<int, List<IActivityRewardData>> CurrentLevelRewardInfoMap = new Dictionary<int, List<IActivityRewardData>>();

	// Token: 0x04003810 RID: 14352
	private readonly Dictionary<int, global::ActivityTaskData> TaskData = new Dictionary<int, global::ActivityTaskData>();

	// Token: 0x04003811 RID: 14353
	private readonly Dictionary<int, List<global::ActivityTaskData>> TabTaskData = new Dictionary<int, List<global::ActivityTaskData>>();

	// Token: 0x04003812 RID: 14354
	private List<IActivityRewardData> CurrentScoreRewardInfo = new List<IActivityRewardData>();

	// Token: 0x04003813 RID: 14355
	private bool NewOpenBossRushState;

	// Token: 0x04003814 RID: 14356
	private bool NeedShowNewUnlock;

	// Token: 0x04003815 RID: 14357
	private bool NeedShowNewBuff;

	// Token: 0x04003816 RID: 14358
	private List<BossRushLevelDetailInfo> CurrentLevelInfo = new List<BossRushLevelDetailInfo>();

	// Token: 0x04003817 RID: 14359
	private int[] CurrentBuffs = new int[0];

	// Token: 0x04003818 RID: 14360
	[Nullable(2)]
	private ActivityData CurrentData;

	// Token: 0x04003819 RID: 14361
	private readonly Dictionary<int, int[]> InsSelectedBuffIdMap = new Dictionary<int, int[]>();
}
