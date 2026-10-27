using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014CC RID: 5324
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleTrialData : ActivityBaseData
{
	// Token: 0x06009738 RID: 38712 RVA: 0x0020A883 File Offset: 0x00208A83
	public void SetRoleTrialState(ERoleTrialFlowState state)
	{
		this.RoleTrialState = state;
	}

	// Token: 0x06009739 RID: 38713 RVA: 0x0020A88C File Offset: 0x00208A8C
	public bool IsRolePreviewOn()
	{
		return this.RoleTrialState == ERoleTrialFlowState.RolePreview;
	}

	// Token: 0x0600973A RID: 38714 RVA: 0x0020A897 File Offset: 0x00208A97
	public bool IsRoleInstanceOn()
	{
		return this.RoleTrialState == ERoleTrialFlowState.RoleInstance;
	}

	// Token: 0x0600973B RID: 38715 RVA: 0x0020A8A4 File Offset: 0x00208AA4
	protected override void PhraseEx(ActivityData data)
	{
		if (this.CheckIfInShowTime() && !ActivityRoleTrialController.Instance.CurrentActivityIdList.Contains(data.Id))
		{
			ActivityRoleTrialController.Instance.CurrentActivityIdList.Add(data.Id);
		}
		this.RoleIdList.Clear();
		this.RoleTrialIdList.Clear();
		RoleTrialInfoActivity roleTrialInfoActivity = data.RoleTrialInfoActivity;
		if (roleTrialInfoActivity == null)
		{
			return;
		}
		this.RoleTrialTaskList = roleTrialInfoActivity.RoleTrialTask.ToList<RoleTrialTask>();
		this.RefreshExData();
		this.RefreshIsNewMap();
		ActivityRoleTrialController.Instance.TryRefreshIsNewMap(this);
	}

	// Token: 0x0600973C RID: 38716 RVA: 0x0020A930 File Offset: 0x00208B30
	public void RefreshExData()
	{
		this.RoleIdList.Clear();
		this.RoleTrialIdList.Clear();
		double serverTime = TimeUtil.Instance.GetServerTime();
		foreach (RoleTrialTask roleTrialTask in this.RoleTrialTaskList)
		{
			ERoleTrialRewardState value = this.StateResolver[roleTrialTask.ChallengeState];
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(roleTrialTask.RoleId);
			this.TrialToIdMap[roleTrialInfoConfigByRoleId.Value.TrialRoleId] = roleTrialTask.RoleId;
			this.RoleRewardStateMap[roleTrialTask.RoleId] = value;
			long beginOpenTime = roleTrialTask.BeginOpenTime;
			if (beginOpenTime != 0L)
			{
				long endOpenTime = roleTrialTask.EndOpenTime;
				this.RoleBeginEndTimeMap[roleTrialTask.RoleId] = new Tuple<double, double>((double)beginOpenTime, (double)endOpenTime);
				if (serverTime >= (double)beginOpenTime && serverTime < (double)endOpenTime)
				{
					this.RoleIdList.Add(roleTrialTask.RoleId);
					this.RoleTrialIdList.Add(roleTrialInfoConfigByRoleId.Value.TrialRoleId);
				}
			}
			else
			{
				this.RoleIdList.Add(roleTrialTask.RoleId);
				this.RoleTrialIdList.Add(roleTrialInfoConfigByRoleId.Value.TrialRoleId);
			}
		}
	}

	// Token: 0x0600973D RID: 38717 RVA: 0x0020AA9C File Offset: 0x00208C9C
	public ERoleTrialRewardState GetRewardStateByRoleId(int roleId)
	{
		ERoleTrialRewardState result;
		if (this.RoleRewardStateMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return ERoleTrialRewardState.InActive;
	}

	// Token: 0x0600973E RID: 38718 RVA: 0x0020AABC File Offset: 0x00208CBC
	public void SetRewardStateByRoleId(int roleId, ERoleTrialRewardState state)
	{
		this.RoleRewardStateMap[roleId] = state;
	}

	// Token: 0x0600973F RID: 38719 RVA: 0x0020AACC File Offset: 0x00208CCC
	public int? GetInstanceIdByRoleId(int roleId)
	{
		RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(roleId);
		if (roleTrialInfoConfigByRoleId == null)
		{
			return null;
		}
		return new int?(roleTrialInfoConfigByRoleId.GetValueOrDefault().InstanceId);
	}

	// Token: 0x06009740 RID: 38720 RVA: 0x0020AB0C File Offset: 0x00208D0C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<IItemGridData> GetRewardDataByRoleId(int roleId)
	{
		RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(roleId);
		if (roleTrialInfoConfigByRoleId == null || roleTrialInfoConfigByRoleId.Value.RewardItemLength == 0)
		{
			return null;
		}
		ERoleTrialRewardState rewardStateByRoleId = this.GetRewardStateByRoleId(roleId);
		List<IItemGridData> list = new List<IItemGridData>();
		for (int i = 0; i < roleTrialInfoConfigByRoleId.Value.RewardItemLength; i++)
		{
			DicIntInt value = roleTrialInfoConfigByRoleId.Value.RewardItem(i).Value;
			int key = value.Key;
			int value2 = value.Value;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value2);
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = (rewardStateByRoleId == ERoleTrialRewardState.FinishedAndClaimed)
			};
			list.Add(item2);
		}
		return list;
	}

	// Token: 0x06009741 RID: 38721 RVA: 0x0020ABD0 File Offset: 0x00208DD0
	public bool GetIsNewByRoleId(int roleId)
	{
		bool flag;
		return this.RoleIsNewMap.TryGetValue(roleId, out flag) && flag;
	}

	// Token: 0x06009742 RID: 38722 RVA: 0x0020ABF0 File Offset: 0x00208DF0
	public void RefreshIsNewMap()
	{
		Dictionary<int, Dictionary<int, double>> player = LocalStorage.GetPlayer<Dictionary<int, Dictionary<int, double>>>(ELocalStoragePlayerKey.RoleTrialRemindMap, null);
		foreach (RoleTrialTask roleTrialTask in this.RoleTrialTaskList)
		{
			int roleId = roleTrialTask.RoleId;
			Tuple<double, double> tuple;
			if (!this.RoleBeginEndTimeMap.TryGetValue(roleId, out tuple))
			{
				this.RoleIsNewMap[roleId] = false;
			}
			else
			{
				double serverTime = TimeUtil.Instance.GetServerTime();
				if (serverTime < tuple.Item1 || serverTime >= tuple.Item2)
				{
					this.RoleIsNewMap[roleId] = false;
				}
				else
				{
					double num = 0.0;
					Dictionary<int, double> dictionary;
					if (player != null && player.TryGetValue(base.Id, out dictionary))
					{
						dictionary.TryGetValue(roleId, out num);
					}
					this.RoleIsNewMap[roleId] = (num == 0.0 || num < tuple.Item1);
				}
			}
		}
	}

	// Token: 0x06009743 RID: 38723 RVA: 0x0020ACF0 File Offset: 0x00208EF0
	public RoleTrialInfo? GetConfigByRoleAndInstance(int roleInfoId, int instanceId)
	{
		foreach (int id in this.RoleIdList)
		{
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(id);
			if (roleTrialInfoConfigByRoleId != null && roleTrialInfoConfigByRoleId.Value.RoleId == roleInfoId && roleTrialInfoConfigByRoleId.Value.InstanceId == instanceId)
			{
				return roleTrialInfoConfigByRoleId;
			}
		}
		return null;
	}

	// Token: 0x06009744 RID: 38724 RVA: 0x0020AD88 File Offset: 0x00208F88
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06009745 RID: 38725 RVA: 0x0020AD8C File Offset: 0x00208F8C
	public override bool GetExDataRedPointShowState()
	{
		foreach (KeyValuePair<int, ERoleTrialRewardState> keyValuePair in this.RoleRewardStateMap)
		{
			if (keyValuePair.Value == ERoleTrialRewardState.FinishedAndUnClaimed && this.RoleIdList.Contains(keyValuePair.Key))
			{
				return true;
			}
		}
		foreach (KeyValuePair<int, bool> keyValuePair2 in this.RoleIsNewMap)
		{
			if (keyValuePair2.Value && this.RoleIdList.Contains(keyValuePair2.Key))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009746 RID: 38726 RVA: 0x0020AE5C File Offset: 0x0020905C
	protected override bool GetExDataFinishShowState()
	{
		if (this.RoleRewardStateMap.Count == 0)
		{
			return false;
		}
		foreach (KeyValuePair<int, ERoleTrialRewardState> keyValuePair in this.RoleRewardStateMap)
		{
			if (keyValuePair.Value != ERoleTrialRewardState.FinishedAndClaimed)
			{
				return false;
			}
		}
		using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator2 = this.RoleIsNewMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06009747 RID: 38727 RVA: 0x0020AF10 File Offset: 0x00209110
	public void SaveRemindTime(int roleId)
	{
		Dictionary<int, Dictionary<int, double>> dictionary = LocalStorage.GetPlayer<Dictionary<int, Dictionary<int, double>>>(ELocalStoragePlayerKey.RoleTrialRemindMap, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, Dictionary<int, double>>();
		}
		Dictionary<int, double> dictionary2;
		if (!dictionary.TryGetValue(base.Id, out dictionary2))
		{
			dictionary2 = new Dictionary<int, double>();
			dictionary[base.Id] = dictionary2;
		}
		dictionary2[roleId] = TimeUtil.Instance.GetServerTime();
		LocalStorage.SetPlayer<Dictionary<int, Dictionary<int, double>>>(ELocalStoragePlayerKey.RoleTrialRemindMap, dictionary);
		this.RoleIsNewMap[roleId] = false;
	}

	// Token: 0x04004291 RID: 17041
	public List<RoleTrialTask> RoleTrialTaskList = new List<RoleTrialTask>();

	// Token: 0x04004292 RID: 17042
	public readonly Dictionary<ChallengeState, ERoleTrialRewardState> StateResolver = new Dictionary<ChallengeState, ERoleTrialRewardState>
	{
		{
			ChallengeState.Running,
			ERoleTrialRewardState.InActive
		},
		{
			ChallengeState.WaitTakeReward,
			ERoleTrialRewardState.FinishedAndUnClaimed
		},
		{
			ChallengeState.Finish,
			ERoleTrialRewardState.FinishedAndClaimed
		}
	};

	// Token: 0x04004293 RID: 17043
	public List<int> RoleIdList = new List<int>();

	// Token: 0x04004294 RID: 17044
	public List<int> RoleTrialIdList = new List<int>();

	// Token: 0x04004295 RID: 17045
	public Dictionary<int, Tuple<double, double>> RoleBeginEndTimeMap = new Dictionary<int, Tuple<double, double>>();

	// Token: 0x04004296 RID: 17046
	public readonly Dictionary<int, int> TrialToIdMap = new Dictionary<int, int>();

	// Token: 0x04004297 RID: 17047
	private readonly Dictionary<int, ERoleTrialRewardState> RoleRewardStateMap = new Dictionary<int, ERoleTrialRewardState>();

	// Token: 0x04004298 RID: 17048
	private readonly Dictionary<int, bool> RoleIsNewMap = new Dictionary<int, bool>();

	// Token: 0x04004299 RID: 17049
	public int CurrentRoleId;

	// Token: 0x0400429A RID: 17050
	private ERoleTrialFlowState RoleTrialState;
}
