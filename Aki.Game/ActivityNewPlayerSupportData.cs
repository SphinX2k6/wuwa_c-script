using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using Google.Protobuf.Collections;

// Token: 0x020013B5 RID: 5045
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportData : ActivityBaseData
{
	// Token: 0x17000BF1 RID: 3057
	// (get) Token: 0x06008E37 RID: 36407 RVA: 0x001EAD56 File Offset: 0x001E8F56
	// (set) Token: 0x06008E38 RID: 36408 RVA: 0x001EAD5E File Offset: 0x001E8F5E
	public bool AlreadyStartView
	{
		get
		{
			return this.IsAlreadyStartView;
		}
		set
		{
			this.IsAlreadyStartView = value;
		}
	}

	// Token: 0x17000BF2 RID: 3058
	// (get) Token: 0x06008E39 RID: 36409 RVA: 0x001EAD67 File Offset: 0x001E8F67
	public bool IsActivityFirstShow
	{
		get
		{
			return this.IsFirstShow;
		}
	}

	// Token: 0x17000BF3 RID: 3059
	// (get) Token: 0x06008E3A RID: 36410 RVA: 0x001EAD70 File Offset: 0x001E8F70
	public int? CurUseTrialRoleId
	{
		get
		{
			TrialRoleGroupData curUseTrialRole = TrialRoleModel.Instance.GetCurUseTrialRole(ETrialRoleType.NewbieSupportTrial);
			if (curUseTrialRole == null)
			{
				return null;
			}
			return new int?(curUseTrialRole.TrialRoleId);
		}
	}

	// Token: 0x17000BF4 RID: 3060
	// (get) Token: 0x06008E3B RID: 36411 RVA: 0x001EADA0 File Offset: 0x001E8FA0
	[Nullable(2)]
	public TrialRoleGroupData CurUseTrialRoleData
	{
		[NullableContext(2)]
		get
		{
			return TrialRoleModel.Instance.GetCurUseTrialRole(ETrialRoleType.NewbieSupportTrial);
		}
	}

	// Token: 0x06008E3C RID: 36412 RVA: 0x001EADAD File Offset: 0x001E8FAD
	protected override void OnInit(ActivityData data)
	{
		this.IsFirstShow = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, false);
	}

	// Token: 0x06008E3D RID: 36413 RVA: 0x001EADC0 File Offset: 0x001E8FC0
	protected override void PhraseEx(ActivityData data)
	{
		NewPlayerSupportActivityData newPlayerSupportActivityData = data.NewPlayerSupportActivityData;
		if (newPlayerSupportActivityData == null)
		{
			return;
		}
		this.ParseTrialRoles(newPlayerSupportActivityData.TrialRoleInfoList);
		this.ParseTaskInfos(newPlayerSupportActivityData.ConditionTasks);
		this.ParseCurUseTrialRole(newPlayerSupportActivityData.CurUseTrialRoleId, newPlayerSupportActivityData.CurUseRoleInfo);
		this.HaveFinishCarnivalRole = newPlayerSupportActivityData.NewPlayerPoolFinalGachaRoleId;
		this.CheckIsFirstShow();
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportInfoUpdate);
	}

	// Token: 0x06008E3E RID: 36414 RVA: 0x001EAE24 File Offset: 0x001E9024
	[NullableContext(2)]
	private void ParseCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x06008E3F RID: 36415 RVA: 0x001EAE3C File Offset: 0x001E903C
	private void ParseTrialRoles(RepeatedField<NewTrialRoleInfo> roleList)
	{
		List<ITrialRoleCreateData> list = new List<ITrialRoleCreateData>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (NewTrialRoleInfo newTrialRoleInfo in roleList)
		{
			list.Add(new TrialRoleCreateData
			{
				TrialRoleId = newTrialRoleInfo.TrialRoleId,
				IsUnlocked = true
			});
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			int? num = (instance != null) ? instance.GetTrialRoleGroupId(newTrialRoleInfo.TrialRoleId) : null;
			if (num != null)
			{
				hashSet.Add(num.Value);
			}
		}
		TrialRoleConfig instance2 = TrialRoleConfig.Instance;
		Dictionary<int, List<TrialRoleInfo>> dictionary = (instance2 != null) ? instance2.GetTrialRoleAllConfigByType(ETrialRoleType.NewbieSupportTrial) : null;
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, List<TrialRoleInfo>> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				List<TrialRoleInfo> value = keyValuePair.Value;
				if (!hashSet.Contains(key) && value.Count > 0)
				{
					list.Add(new TrialRoleCreateData
					{
						TrialRoleId = value[0].Id,
						IsUnlocked = false
					});
				}
			}
		}
		TrialRoleModel.Instance.AddTrialRoles(list);
	}

	// Token: 0x06008E40 RID: 36416 RVA: 0x001EAF8C File Offset: 0x001E918C
	private void ParseTaskInfos(RepeatedField<ConditionTask> tasks)
	{
		this.TaskDataList = new List<ActivityNewPlayerSupportTaskData>();
		this.UpdateTaskData(tasks);
	}

	// Token: 0x06008E41 RID: 36417 RVA: 0x001EAFA0 File Offset: 0x001E91A0
	private ActivityNewPlayerSupportTaskData GetOrCreateTaskData(int taskId)
	{
		ActivityNewPlayerSupportTaskData activityNewPlayerSupportTaskData = this.GetTaskData(taskId);
		if (activityNewPlayerSupportTaskData == null)
		{
			activityNewPlayerSupportTaskData = new ActivityNewPlayerSupportTaskData(taskId);
			this.TaskDataList.Add(activityNewPlayerSupportTaskData);
		}
		return activityNewPlayerSupportTaskData;
	}

	// Token: 0x06008E42 RID: 36418 RVA: 0x001EAFCC File Offset: 0x001E91CC
	private int SortTaskData(ActivityNewPlayerSupportTaskData a, ActivityNewPlayerSupportTaskData b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x06008E43 RID: 36419 RVA: 0x001EAFDB File Offset: 0x001E91DB
	public List<ActivityNewPlayerSupportTaskData> GetTaskDataList()
	{
		this.TaskDataList.Sort(new Comparison<ActivityNewPlayerSupportTaskData>(this.SortTaskData));
		return this.TaskDataList;
	}

	// Token: 0x06008E44 RID: 36420 RVA: 0x001EAFFC File Offset: 0x001E91FC
	[NullableContext(2)]
	public ActivityNewPlayerSupportTaskData GetTaskData(int id)
	{
		foreach (ActivityNewPlayerSupportTaskData activityNewPlayerSupportTaskData in this.TaskDataList)
		{
			if (activityNewPlayerSupportTaskData.Id == id)
			{
				return activityNewPlayerSupportTaskData;
			}
		}
		return null;
	}

	// Token: 0x06008E45 RID: 36421 RVA: 0x001EB058 File Offset: 0x001E9258
	public List<int> GetCanReceiveTaskIdList()
	{
		List<int> list = new List<int>();
		foreach (ActivityNewPlayerSupportTaskData activityNewPlayerSupportTaskData in this.TaskDataList)
		{
			if (activityNewPlayerSupportTaskData.CanReceiveReward())
			{
				list.Add(activityNewPlayerSupportTaskData.Id);
			}
		}
		return list;
	}

	// Token: 0x06008E46 RID: 36422 RVA: 0x001EB0C0 File Offset: 0x001E92C0
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.NewbieSupportTrial);
	}

	// Token: 0x06008E47 RID: 36423 RVA: 0x001EB0CD File Offset: 0x001E92CD
	[NullableContext(2)]
	public TrialRoleGroupData GetTrialRoleByGroupId(int groupId)
	{
		return TrialRoleModel.Instance.GetDataByGroupId(groupId);
	}

	// Token: 0x06008E48 RID: 36424 RVA: 0x001EB0DA File Offset: 0x001E92DA
	[NullableContext(2)]
	public void UpdateCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x06008E49 RID: 36425 RVA: 0x001EB0E8 File Offset: 0x001E92E8
	public void UpdateTaskData(RepeatedField<ConditionTask> taskData)
	{
		foreach (ConditionTask conditionTask in taskData)
		{
			this.GetOrCreateTaskData(conditionTask.Id).Refresh(conditionTask);
		}
	}

	// Token: 0x06008E4A RID: 36426 RVA: 0x001EB13C File Offset: 0x001E933C
	[NullableContext(2)]
	public void UpdateActivatedTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetGroupTrialRoleId(trialRoleId, trialRoleInfo);
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x001EB14C File Offset: 0x001E934C
	public string GetDesc()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.LocalConfig.Value.Desc, null);
	}

	// Token: 0x06008E4C RID: 36428 RVA: 0x001EB174 File Offset: 0x001E9374
	public bool HasUnlockTrialRole()
	{
		using (List<TrialRoleGroupData>.Enumerator enumerator = this.GetTrialRoleList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsUnlocked())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008E4D RID: 36429 RVA: 0x001EB1D0 File Offset: 0x001E93D0
	public int? GetFirstUnFinishMainQuestId()
	{
		global::Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(1);
		if (firstShowQuestByType == null)
		{
			return null;
		}
		return new int?(firstShowQuestByType.Id);
	}

	// Token: 0x06008E4E RID: 36430 RVA: 0x001EB200 File Offset: 0x001E9400
	public override bool GetExDataRedPointShowState()
	{
		return this.IsHasRewardRedPoint() || this.IsTrialRoleUpgradeRedPoint() || this.IsTrialRoleEntranceRedDot() || this.IsAdventureEntranceRedDot();
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x001EB224 File Offset: 0x001E9424
	public bool IsHasRewardRedPoint()
	{
		using (List<ActivityNewPlayerSupportTaskData>.Enumerator enumerator = this.TaskDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanReceiveReward())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008E50 RID: 36432 RVA: 0x001EB280 File Offset: 0x001E9480
	public bool IsTrialRoleUpgradeRedPoint()
	{
		using (List<TrialRoleGroupData>.Enumerator enumerator = this.GetTrialRoleList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanUpgrade())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x001EB2DC File Offset: 0x001E94DC
	public bool IsTrialRoleEntranceRedDot()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.NewPlayerSupportTrialRoleEntranceRedDot, false);
	}

	// Token: 0x06008E52 RID: 36434 RVA: 0x001EB2E9 File Offset: 0x001E94E9
	public bool IsAdventureEntranceRedDot()
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityRegressAdventureRedDotCheckedInPeriod, false);
	}

	// Token: 0x06008E53 RID: 36435 RVA: 0x001EB2F6 File Offset: 0x001E94F6
	public void SaveTrailRoleEntranceRedDot(bool value)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.NewPlayerSupportTrialRoleEntranceRedDot, value);
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008E54 RID: 36436 RVA: 0x001EB32C File Offset: 0x001E952C
	private void CheckIsFirstShow()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, false);
		bool player2 = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, true);
		bool? flag = (player == player2) ? new bool?(player) : null;
		if (flag == null)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, true);
		}
	}

	// Token: 0x06008E55 RID: 36437 RVA: 0x001EB37C File Offset: 0x001E957C
	public void RecordActivityFirstShow()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, false);
	}

	// Token: 0x04003EF7 RID: 16119
	private List<ActivityNewPlayerSupportTaskData> TaskDataList = new List<ActivityNewPlayerSupportTaskData>();

	// Token: 0x04003EF8 RID: 16120
	private bool IsFirstShow;

	// Token: 0x04003EF9 RID: 16121
	private bool IsAlreadyStartView;

	// Token: 0x04003EFA RID: 16122
	public int HaveFinishCarnivalRole;
}
