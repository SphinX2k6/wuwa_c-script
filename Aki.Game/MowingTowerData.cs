using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000833 RID: 2099
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerData : ActivityBaseData
{
	// Token: 0x06005F63 RID: 24419 RVA: 0x001E733C File Offset: 0x001E553C
	protected override void PhraseEx(ActivityData data)
	{
		this.CurrentLevelInfoMap.Clear();
		this.CurrentLevelRewardInfoMap.Clear();
		this.PhraseLevelInfo(data.MowTowerActivityInfo.MowTowerLevelInfos);
		this.CheckIfNewMowingTowerOpen();
		this.PhraseRewardInfo(data.MowTowerActivityInfo.MowTowerLevelInfos);
		this.CurrentData = data;
		EventSystem.Instance.Emit(EEventName.RefreshMowingTowerData);
		EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06005F64 RID: 24420 RVA: 0x001E73CA File Offset: 0x001E55CA
	public void RebuildData()
	{
		if (this.CurrentData != null)
		{
			this.PhraseEx(this.CurrentData);
		}
	}

	// Token: 0x06005F65 RID: 24421 RVA: 0x001E73E0 File Offset: 0x001E55E0
	public void PhraseRewardInfo(IEnumerable<MowTowerLevelsInfo> levelData)
	{
		foreach (MowTowerLevelsInfo mowTowerLevelsInfo in levelData)
		{
			List<IActivityRewardData> value = this.CreateLevelReward(mowTowerLevelsInfo.LevelsId, mowTowerLevelsInfo);
			this.CurrentLevelRewardInfoMap[mowTowerLevelsInfo.LevelsId] = value;
		}
	}

	// Token: 0x06005F66 RID: 24422 RVA: 0x001E7444 File Offset: 0x001E5644
	public void PhraseLevelInfo(IEnumerable<MowTowerLevelsInfo> data)
	{
		foreach (MowTowerLevelsInfo mowTowerLevelsInfo in data)
		{
			MowingTowerLevelDetailInfo mowingTowerLevelDetailInfo;
			if (!this.CurrentLevelInfoMap.TryGetValue(mowTowerLevelsInfo.LevelsId, out mowingTowerLevelDetailInfo))
			{
				mowingTowerLevelDetailInfo = new MowingTowerLevelDetailInfo();
			}
			mowingTowerLevelDetailInfo.Phrase(base.Id, mowTowerLevelsInfo);
			this.CurrentLevelInfoMap[mowTowerLevelsInfo.LevelsId] = mowingTowerLevelDetailInfo;
			List<IActivityRewardData> value = this.CreateLevelReward(mowingTowerLevelDetailInfo.GetId(), mowTowerLevelsInfo);
			this.CurrentLevelRewardInfoMap[mowingTowerLevelDetailInfo.GetId()] = value;
		}
		if (this.CurrentData != null)
		{
			this.CurrentData.MowTowerActivityInfo.MowTowerLevelInfos.Clear();
			this.CurrentData.MowTowerActivityInfo.MowTowerLevelInfos.AddRange(data);
		}
	}

	// Token: 0x06005F67 RID: 24423 RVA: 0x001E7514 File Offset: 0x001E5714
	[NullableContext(2)]
	public MowingTowerLevelDetailInfo GetMowingTowerLevelDetailInfoById(int levelsId)
	{
		foreach (KeyValuePair<int, MowingTowerLevelDetailInfo> keyValuePair in this.CurrentLevelInfoMap)
		{
			MowingTowerLevelDetailInfo value = keyValuePair.Value;
			if (value.GetId() == levelsId)
			{
				return value;
			}
		}
		return null;
	}

	// Token: 0x06005F68 RID: 24424 RVA: 0x001E7578 File Offset: 0x001E5778
	public MowingTowerLevelDetailInfo[] GetMowingTowerLevelDetailInfo()
	{
		MowingTowerLevelDetailInfo[] array = new MowingTowerLevelDetailInfo[this.CurrentLevelInfoMap.Count];
		this.CurrentLevelInfoMap.Values.CopyTo(array, 0);
		return array;
	}

	// Token: 0x06005F69 RID: 24425 RVA: 0x001E75A9 File Offset: 0x001E57A9
	public override bool GetExDataRedPointShowState()
	{
		return base.GetPreGuideQuestFinishState() && (this.NewOpenMowingTowerState || this.GetIfCanTakeReward());
	}

	// Token: 0x06005F6A RID: 24426 RVA: 0x001E75C5 File Offset: 0x001E57C5
	public bool GetNewUnlockState()
	{
		return this.NeedShowNewUnlock;
	}

	// Token: 0x06005F6B RID: 24427 RVA: 0x001E75D0 File Offset: 0x001E57D0
	private bool GetIfCanTakeReward()
	{
		foreach (KeyValuePair<int, List<IActivityRewardData>> keyValuePair in this.CurrentLevelRewardInfoMap)
		{
			using (List<IActivityRewardData>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005F6C RID: 24428 RVA: 0x001E7668 File Offset: 0x001E5868
	private bool GetIfCanTakeRewardByLevelId(int levelId)
	{
		List<IActivityRewardData> list;
		if (!this.CurrentLevelRewardInfoMap.TryGetValue(levelId, out list))
		{
			return false;
		}
		foreach (IActivityRewardData activityRewardData in list)
		{
			int? id = activityRewardData.Id;
			if ((id.GetValueOrDefault() == levelId & id != null) && activityRewardData.RewardState == EActivityRewardState.Enable)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005F6D RID: 24429 RVA: 0x001E76F4 File Offset: 0x001E58F4
	public void CheckIfNewMowingTowerOpen()
	{
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 0, 0);
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		this.NewOpenMowingTowerState = (currentOpenBossNum > activityCacheData);
		int activityCacheData2 = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 100, 0);
		this.NeedShowNewUnlock = (currentOpenBossNum > activityCacheData2);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06005F6E RID: 24430 RVA: 0x001E7768 File Offset: 0x001E5968
	public int GetCurrentCheckBuffIndex()
	{
		int result = 0;
		MowingTowerLevelDetailInfo[] mowingTowerLevelDetailInfo = this.GetMowingTowerLevelDetailInfo();
		int num = mowingTowerLevelDetailInfo.Length;
		for (int i = 0; i < num; i++)
		{
			if (mowingTowerLevelDetailInfo[i].GetUnLockState())
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06005F6F RID: 24431 RVA: 0x001E779C File Offset: 0x001E599C
	private int GetCurrentOpenBossNum()
	{
		int num = 0;
		MowingTowerLevelDetailInfo[] mowingTowerLevelDetailInfo = this.GetMowingTowerLevelDetailInfo();
		for (int i = 0; i < mowingTowerLevelDetailInfo.Length; i++)
		{
			if (mowingTowerLevelDetailInfo[i].GetUnLockState())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06005F70 RID: 24432 RVA: 0x001E77D0 File Offset: 0x001E59D0
	public void CacheNewUnlock()
	{
		this.NeedShowNewUnlock = false;
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 100, 0, currentOpenBossNum);
		this.CheckIfNewMowingTowerOpen();
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x001E780C File Offset: 0x001E5A0C
	public void CacheCurrentOpenBossNum()
	{
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 0, 0, currentOpenBossNum);
		this.CheckIfNewMowingTowerOpen();
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x001E783F File Offset: 0x001E5A3F
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x001E7847 File Offset: 0x001E5A47
	public bool HaveRewardCanTake()
	{
		return this.GetIfCanTakeReward();
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x001E784F File Offset: 0x001E5A4F
	public bool HaveLevelRewardCanTake(int levelId)
	{
		return this.GetIfCanTakeRewardByLevelId(levelId);
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x001E7858 File Offset: 0x001E5A58
	public int GetFullScore()
	{
		int num = 0;
		foreach (KeyValuePair<int, MowingTowerLevelDetailInfo> keyValuePair in this.CurrentLevelInfoMap)
		{
			MowingTowerLevelDetailInfo value = keyValuePair.Value;
			num += value.GetScore();
		}
		return num;
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x001E78B8 File Offset: 0x001E5AB8
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

	// Token: 0x06005F77 RID: 24439 RVA: 0x001E78F8 File Offset: 0x001E5AF8
	private List<TItem> GetRewardItems(int dropId)
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
		return list;
	}

	// Token: 0x06005F78 RID: 24440 RVA: 0x001E7974 File Offset: 0x001E5B74
	private List<IActivityRewardData> CreateLevelReward(int levelId, MowTowerLevelsInfo levelData)
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		int[] array = new int[levelData.LevelRewardStatus.Keys.Count];
		levelData.LevelRewardStatus.Keys.CopyTo(array, 0);
		for (int i = 0; i < array.Length; i++)
		{
			int num = array[i];
			MowTowerRewardRe? config = MowingTowerConfig.Instance.GetMowingTowerRewardById(num);
			if (config != null)
			{
				MowTowerRewardStatus mowTowerRewardStatus = levelData.LevelRewardStatus[num];
				int score = config.Value.Score;
				int capturedIndex = i;
				ActivityRewardData item = new ActivityRewardData
				{
					Id = new int?(levelId),
					NameText = ConfigMultiTextLang.GetLocalTextNew(config.Value.LevelRewardDesc, null),
					NameTextArgs = new string[]
					{
						score.ToString() ?? "",
						(levelData.FirstScore + levelData.SecondScore).ToString() ?? ""
					},
					RewardState = (EActivityRewardState)mowTowerRewardStatus,
					ClickFunction = delegate
					{
						MowingTowerController.Instance.RequestGetMowingTowerLevelReward(this.Id, config.Value.Id, config.Value.MowTowerLevelsId, capturedIndex);
					},
					RewardList = this.GetRewardItems(config.Value.RewardId).ToArray(),
					RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)mowTowerRewardStatus), null)
				};
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x001E7B00 File Offset: 0x001E5D00
	public List<IActivityRewardData> GetRewardByLevelId(int? levelId = null)
	{
		List<IActivityRewardData> result;
		if (this.CurrentLevelRewardInfoMap.TryGetValue(levelId.GetValueOrDefault(), out result))
		{
			return result;
		}
		return new List<IActivityRewardData>();
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x001E7B2C File Offset: 0x001E5D2C
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

	// Token: 0x04003E92 RID: 16018
	private readonly Dictionary<int, List<IActivityRewardData>> CurrentLevelRewardInfoMap = new Dictionary<int, List<IActivityRewardData>>();

	// Token: 0x04003E93 RID: 16019
	private bool NewOpenMowingTowerState;

	// Token: 0x04003E94 RID: 16020
	private bool NeedShowNewUnlock;

	// Token: 0x04003E95 RID: 16021
	private readonly Dictionary<int, MowingTowerLevelDetailInfo> CurrentLevelInfoMap = new Dictionary<int, MowingTowerLevelDetailInfo>();

	// Token: 0x04003E96 RID: 16022
	[Nullable(2)]
	private ActivityData CurrentData;
}
