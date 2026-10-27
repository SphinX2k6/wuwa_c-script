using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200137F RID: 4991
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerData : ActivityBaseData
{
	// Token: 0x06008BC8 RID: 35784 RVA: 0x001DE50C File Offset: 0x001DC70C
	protected override void PhraseEx(ActivityData data)
	{
		this.CurrentLevelInfoMap.Clear();
		this.CurrentLevelRewardInfoMap.Clear();
		this.PhraseLevelInfo(data.MowTowerActivityInfo.MowTowerLevelInfos.ToList<MowTowerLevelsInfo>());
		this.CheckIfNewMowingTowerOpen();
		this.PhraseRewardInfo(data.MowTowerActivityInfo.MowTowerLevelInfos.ToList<MowTowerLevelsInfo>());
		this.CurrentData = data;
		EventSystem.Instance.Emit(EEventName.RefreshMowingTowerData);
		EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008BC9 RID: 35785 RVA: 0x001DE5A4 File Offset: 0x001DC7A4
	public void RebuildData()
	{
		if (this.CurrentData != null)
		{
			this.PhraseEx(this.CurrentData);
		}
	}

	// Token: 0x06008BCA RID: 35786 RVA: 0x001DE5BC File Offset: 0x001DC7BC
	public void PhraseRewardInfo(List<MowTowerLevelsInfo> levelData)
	{
		foreach (MowTowerLevelsInfo mowTowerLevelsInfo in levelData)
		{
			List<IActivityRewardData> value = this.CreateLevelReward(mowTowerLevelsInfo.LevelsId, mowTowerLevelsInfo);
			this.CurrentLevelRewardInfoMap[mowTowerLevelsInfo.LevelsId] = value;
		}
	}

	// Token: 0x06008BCB RID: 35787 RVA: 0x001DE624 File Offset: 0x001DC824
	public void PhraseLevelInfo(List<MowTowerLevelsInfo> data)
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

	// Token: 0x06008BCC RID: 35788 RVA: 0x001DE6F8 File Offset: 0x001DC8F8
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

	// Token: 0x06008BCD RID: 35789 RVA: 0x001DE75C File Offset: 0x001DC95C
	public MowingTowerLevelDetailInfo[] GetMowingTowerLevelDetailInfo()
	{
		return this.CurrentLevelInfoMap.Values.ToArray<MowingTowerLevelDetailInfo>();
	}

	// Token: 0x06008BCE RID: 35790 RVA: 0x001DE76E File Offset: 0x001DC96E
	public override bool GetExDataRedPointShowState()
	{
		return base.GetPreGuideQuestFinishState() && (this.NewOpenMowingTowerState || this.GetIfCanTakeReward());
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x001DE78A File Offset: 0x001DC98A
	public bool GetNewUnlockState()
	{
		return this.NeedShowNewUnlock;
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x001DE794 File Offset: 0x001DC994
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

	// Token: 0x06008BD1 RID: 35793 RVA: 0x001DE82C File Offset: 0x001DCA2C
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

	// Token: 0x06008BD2 RID: 35794 RVA: 0x001DE8B8 File Offset: 0x001DCAB8
	public void CheckIfNewMowingTowerOpen()
	{
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 0, 0);
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		this.NewOpenMowingTowerState = (currentOpenBossNum > activityCacheData);
		int activityCacheData2 = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.Id, 100, 0);
		this.NeedShowNewUnlock = (currentOpenBossNum > activityCacheData2);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008BD3 RID: 35795 RVA: 0x001DE92C File Offset: 0x001DCB2C
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

	// Token: 0x06008BD4 RID: 35796 RVA: 0x001DE960 File Offset: 0x001DCB60
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

	// Token: 0x06008BD5 RID: 35797 RVA: 0x001DE994 File Offset: 0x001DCB94
	public void CacheNewUnlock()
	{
		this.NeedShowNewUnlock = false;
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 100, 0, currentOpenBossNum);
		this.CheckIfNewMowingTowerOpen();
	}

	// Token: 0x06008BD6 RID: 35798 RVA: 0x001DE9D0 File Offset: 0x001DCBD0
	public void CacheCurrentOpenBossNum()
	{
		int currentOpenBossNum = this.GetCurrentOpenBossNum();
		ActivityModel.Instance.SaveActivityData(base.Id, base.Id, 0, 0, currentOpenBossNum);
		this.CheckIfNewMowingTowerOpen();
	}

	// Token: 0x06008BD7 RID: 35799 RVA: 0x001DEA03 File Offset: 0x001DCC03
	public bool EntranceRedDot()
	{
		return this.GetExDataRedPointShowState();
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x001DEA0B File Offset: 0x001DCC0B
	public bool HaveRewardCanTake()
	{
		return this.GetIfCanTakeReward();
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x001DEA13 File Offset: 0x001DCC13
	public bool HaveLevelRewardCanTake(int levelId)
	{
		return this.GetIfCanTakeRewardByLevelId(levelId);
	}

	// Token: 0x06008BDA RID: 35802 RVA: 0x001DEA1C File Offset: 0x001DCC1C
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

	// Token: 0x06008BDB RID: 35803 RVA: 0x001DEA7C File Offset: 0x001DCC7C
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

	// Token: 0x06008BDC RID: 35804 RVA: 0x001DEABC File Offset: 0x001DCCBC
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

	// Token: 0x06008BDD RID: 35805 RVA: 0x001DEB38 File Offset: 0x001DCD38
	private List<IActivityRewardData> CreateLevelReward(int levelId, MowTowerLevelsInfo levelData)
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		int[] array = levelData.LevelRewardStatus.Keys.ToArray<int>();
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

	// Token: 0x06008BDE RID: 35806 RVA: 0x001DECAC File Offset: 0x001DCEAC
	public List<IActivityRewardData> GetRewardByLevelId(int? levelId = null)
	{
		List<IActivityRewardData> result;
		if (this.CurrentLevelRewardInfoMap.TryGetValue(levelId.GetValueOrDefault(), out result))
		{
			return result;
		}
		return new List<IActivityRewardData>();
	}

	// Token: 0x06008BDF RID: 35807 RVA: 0x001DECD8 File Offset: 0x001DCED8
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

	// Token: 0x04003DFA RID: 15866
	private readonly Dictionary<int, List<IActivityRewardData>> CurrentLevelRewardInfoMap = new Dictionary<int, List<IActivityRewardData>>();

	// Token: 0x04003DFB RID: 15867
	private bool NewOpenMowingTowerState;

	// Token: 0x04003DFC RID: 15868
	private bool NeedShowNewUnlock;

	// Token: 0x04003DFD RID: 15869
	private readonly Dictionary<int, MowingTowerLevelDetailInfo> CurrentLevelInfoMap = new Dictionary<int, MowingTowerLevelDetailInfo>();

	// Token: 0x04003DFE RID: 15870
	[Nullable(2)]
	private ActivityData CurrentData;
}
