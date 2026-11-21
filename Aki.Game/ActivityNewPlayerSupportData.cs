using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

// Token: 0x02000869 RID: 2153
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportData : ActivityBaseData
{
	// Token: 0x17000C11 RID: 3089
	// (get) Token: 0x060061CC RID: 25036 RVA: 0x001F3846 File Offset: 0x001F1A46
	// (set) Token: 0x060061CD RID: 25037 RVA: 0x001F384E File Offset: 0x001F1A4E
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

	// Token: 0x17000C12 RID: 3090
	// (get) Token: 0x060061CE RID: 25038 RVA: 0x001F3857 File Offset: 0x001F1A57
	public bool IsActivityFirstShow
	{
		get
		{
			return this.IsFirstShow;
		}
	}

	// Token: 0x17000C13 RID: 3091
	// (get) Token: 0x060061CF RID: 25039 RVA: 0x001F3860 File Offset: 0x001F1A60
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

	// Token: 0x17000C14 RID: 3092
	// (get) Token: 0x060061D0 RID: 25040 RVA: 0x001F3890 File Offset: 0x001F1A90
	[Nullable(2)]
	public TrialRoleGroupData CurUseTrialRoleData
	{
		[NullableContext(2)]
		get
		{
			return TrialRoleModel.Instance.GetCurUseTrialRole(ETrialRoleType.NewbieSupportTrial);
		}
	}

	// Token: 0x060061D1 RID: 25041 RVA: 0x001F389D File Offset: 0x001F1A9D
	protected override void OnInit(ActivityData data)
	{
		this.IsFirstShow = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, false);
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x001F38B0 File Offset: 0x001F1AB0
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

	// Token: 0x060061D3 RID: 25043 RVA: 0x001F3914 File Offset: 0x001F1B14
	[NullableContext(2)]
	private void ParseCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x001F392C File Offset: 0x001F1B2C
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

	// Token: 0x060061D5 RID: 25045 RVA: 0x001F3A7C File Offset: 0x001F1C7C
	private void ParseTaskInfos(RepeatedField<ConditionTask> tasks)
	{
		this.TaskDataList = new List<ActivityNewPlayerSupportTaskData>();
		this.UpdateTaskData(tasks);
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x001F3A90 File Offset: 0x001F1C90
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

	// Token: 0x060061D7 RID: 25047 RVA: 0x001F3ABC File Offset: 0x001F1CBC
	private int SortTaskData(ActivityNewPlayerSupportTaskData a, ActivityNewPlayerSupportTaskData b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x001F3ACB File Offset: 0x001F1CCB
	public List<ActivityNewPlayerSupportTaskData> GetTaskDataList()
	{
		this.TaskDataList.Sort(new Comparison<ActivityNewPlayerSupportTaskData>(this.SortTaskData));
		return this.TaskDataList;
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x001F3AEC File Offset: 0x001F1CEC
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

	// Token: 0x060061DA RID: 25050 RVA: 0x001F3B48 File Offset: 0x001F1D48
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

	// Token: 0x060061DB RID: 25051 RVA: 0x001F3BB0 File Offset: 0x001F1DB0
	public List<TrialRoleGroupData> GetTrialRoleList()
	{
		return TrialRoleModel.Instance.GetDataListByType(ETrialRoleType.NewbieSupportTrial);
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x001F3BBD File Offset: 0x001F1DBD
	[NullableContext(2)]
	public TrialRoleGroupData GetTrialRoleByGroupId(int groupId)
	{
		return TrialRoleModel.Instance.GetDataByGroupId(groupId);
	}

	// Token: 0x060061DD RID: 25053 RVA: 0x001F3BCA File Offset: 0x001F1DCA
	[NullableContext(2)]
	public void UpdateCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetCurUseTrialRole(trialRoleId, trialRoleInfo);
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x001F3BD8 File Offset: 0x001F1DD8
	public void UpdateTaskData(RepeatedField<ConditionTask> taskData)
	{
		foreach (ConditionTask conditionTask in taskData)
		{
			this.GetOrCreateTaskData(conditionTask.Id).Refresh(conditionTask);
		}
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x001F3C2C File Offset: 0x001F1E2C
	[NullableContext(2)]
	public void UpdateActivatedTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleModel.Instance.SetGroupTrialRoleId(trialRoleId, trialRoleInfo);
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x001F3C3C File Offset: 0x001F1E3C
	public string GetDesc()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.LocalConfig.Value.Desc, null);
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x001F3C64 File Offset: 0x001F1E64
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

	// Token: 0x060061E2 RID: 25058 RVA: 0x001F3CC0 File Offset: 0x001F1EC0
	public int? GetFirstUnFinishMainQuestId()
	{
		global::Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(1);
		if (firstShowQuestByType == null)
		{
			return null;
		}
		return new int?(firstShowQuestByType.Id);
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x001F3CF0 File Offset: 0x001F1EF0
	public override bool GetExDataRedPointShowState()
	{
		return this.IsHasRewardRedPoint() || this.IsTrialRoleUpgradeRedPoint() || this.IsTrialRoleEntranceRedDot() || this.IsAdventureEntranceRedDot();
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x001F3D14 File Offset: 0x001F1F14
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

	// Token: 0x060061E5 RID: 25061 RVA: 0x001F3D70 File Offset: 0x001F1F70
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

	// Token: 0x060061E6 RID: 25062 RVA: 0x001F3DCC File Offset: 0x001F1FCC
	public bool IsTrialRoleEntranceRedDot()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.NewPlayerSupportTrialRoleEntranceRedDot, false);
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x001F3DDC File Offset: 0x001F1FDC
	public bool IsAdventureEntranceRedDot()
	{
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ActivityRegressAdventureRedDotCheckedInPeriod, EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod, true);
		return !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ActivityRegressAdventureRedDotCheckedInPeriod) as ServerStorageBoolean).Get().GetValueOrDefault();
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x001F3E15 File Offset: 0x001F2015
	public void SaveTrailRoleEntranceRedDot(bool value)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.NewPlayerSupportTrialRoleEntranceRedDot, value);
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x001F3E4C File Offset: 0x001F204C
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

	// Token: 0x060061EA RID: 25066 RVA: 0x001F3E9C File Offset: 0x001F209C
	public void RecordActivityFirstShow()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ActivityNewPlayerSupportFirstShow, false);
	}

	// Token: 0x04003F8F RID: 16271
	private List<ActivityNewPlayerSupportTaskData> TaskDataList = new List<ActivityNewPlayerSupportTaskData>();

	// Token: 0x04003F90 RID: 16272
	private bool IsFirstShow;

	// Token: 0x04003F91 RID: 16273
	private bool IsAlreadyStartView;

	// Token: 0x04003F92 RID: 16274
	public int HaveFinishCarnivalRole;
}
