using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000984 RID: 2436
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleTrialData : ActivityBaseData
{
	// Token: 0x06006B12 RID: 27410 RVA: 0x002145C3 File Offset: 0x002127C3
	public void SetRoleTrialState(ERoleTrialFlowState state)
	{
		this.RoleTrialState = state;
	}

	// Token: 0x06006B13 RID: 27411 RVA: 0x002145CC File Offset: 0x002127CC
	public bool IsRolePreviewOn()
	{
		return this.RoleTrialState == ERoleTrialFlowState.RolePreview;
	}

	// Token: 0x06006B14 RID: 27412 RVA: 0x002145D7 File Offset: 0x002127D7
	public bool IsRoleInstanceOn()
	{
		return this.RoleTrialState == ERoleTrialFlowState.RoleInstance;
	}

	// Token: 0x06006B15 RID: 27413 RVA: 0x002145E4 File Offset: 0x002127E4
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
		this.RoleTrialTaskList = new List<RoleTrialTask>(roleTrialInfoActivity.RoleTrialTask);
		this.RefreshExData();
		this.RefreshIsNewMap();
		ActivityRoleTrialController.Instance.TryRefreshIsNewMap(this);
	}

	// Token: 0x06006B16 RID: 27414 RVA: 0x00214670 File Offset: 0x00212870
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

	// Token: 0x06006B17 RID: 27415 RVA: 0x002147DC File Offset: 0x002129DC
	public ERoleTrialRewardState GetRewardStateByRoleId(int roleId)
	{
		ERoleTrialRewardState result;
		if (this.RoleRewardStateMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return ERoleTrialRewardState.InActive;
	}

	// Token: 0x06006B18 RID: 27416 RVA: 0x002147FC File Offset: 0x002129FC
	public void SetRewardStateByRoleId(int roleId, ERoleTrialRewardState state)
	{
		this.RoleRewardStateMap[roleId] = state;
	}

	// Token: 0x06006B19 RID: 27417 RVA: 0x0021480C File Offset: 0x00212A0C
	public int? GetInstanceIdByRoleId(int roleId)
	{
		RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(roleId);
		if (roleTrialInfoConfigByRoleId == null)
		{
			return null;
		}
		return new int?(roleTrialInfoConfigByRoleId.GetValueOrDefault().InstanceId);
	}

	// Token: 0x06006B1A RID: 27418 RVA: 0x0021484C File Offset: 0x00212A4C
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

	// Token: 0x06006B1B RID: 27419 RVA: 0x00214910 File Offset: 0x00212B10
	public bool GetIsNewByRoleId(int roleId)
	{
		bool flag;
		return this.RoleIsNewMap.TryGetValue(roleId, out flag) && flag;
	}

	// Token: 0x06006B1C RID: 27420 RVA: 0x00214930 File Offset: 0x00212B30
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

	// Token: 0x06006B1D RID: 27421 RVA: 0x00214A30 File Offset: 0x00212C30
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

	// Token: 0x06006B1E RID: 27422 RVA: 0x00214AC8 File Offset: 0x00212CC8
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06006B1F RID: 27423 RVA: 0x00214ACC File Offset: 0x00212CCC
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

	// Token: 0x06006B20 RID: 27424 RVA: 0x00214B9C File Offset: 0x00212D9C
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

	// Token: 0x06006B21 RID: 27425 RVA: 0x00214C50 File Offset: 0x00212E50
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

	// Token: 0x04004336 RID: 17206
	public List<RoleTrialTask> RoleTrialTaskList = new List<RoleTrialTask>();

	// Token: 0x04004337 RID: 17207
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

	// Token: 0x04004338 RID: 17208
	public List<int> RoleIdList = new List<int>();

	// Token: 0x04004339 RID: 17209
	public List<int> RoleTrialIdList = new List<int>();

	// Token: 0x0400433A RID: 17210
	public Dictionary<int, Tuple<double, double>> RoleBeginEndTimeMap = new Dictionary<int, Tuple<double, double>>();

	// Token: 0x0400433B RID: 17211
	public readonly Dictionary<int, int> TrialToIdMap = new Dictionary<int, int>();

	// Token: 0x0400433C RID: 17212
	private readonly Dictionary<int, ERoleTrialRewardState> RoleRewardStateMap = new Dictionary<int, ERoleTrialRewardState>();

	// Token: 0x0400433D RID: 17213
	private readonly Dictionary<int, bool> RoleIsNewMap = new Dictionary<int, bool>();

	// Token: 0x0400433E RID: 17214
	public int CurrentRoleId;

	// Token: 0x0400433F RID: 17215
	private ERoleTrialFlowState RoleTrialState;
}
