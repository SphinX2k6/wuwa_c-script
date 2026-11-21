using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02000B14 RID: 2836
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsActivityData : ActivityBaseData
{
	// Token: 0x06007539 RID: 30009 RVA: 0x002436E8 File Offset: 0x002418E8
	protected override void PhraseEx(ActivityData data)
	{
		if (data == null)
		{
			return;
		}
		WuWuWeekActivity wuWuWeekActivity = data.WuWuWeekActivity;
		if (wuWuWeekActivity == null)
		{
			return;
		}
		if (wuWuWeekActivity.ConditionTasks != null)
		{
			foreach (ConditionTask taskInfo in wuWuWeekActivity.ConditionTasks)
			{
				this.UpdateTaskData(taskInfo, 0);
			}
		}
		if (wuWuWeekActivity.TaskPack != null)
		{
			foreach (WuWuTaskPack packInfo in wuWuWeekActivity.TaskPack)
			{
				this.UpdateTaskPackData(packInfo);
			}
		}
	}

	// Token: 0x0600753A RID: 30010 RVA: 0x00243794 File Offset: 0x00241994
	public void UpdateTaskData(ConditionTask taskInfo, int taskPackId = 0)
	{
		if (taskInfo == null)
		{
			return;
		}
		int id = taskInfo.Id;
		WuWuTaskData wuWuTaskData;
		if (!this.TaskMap.TryGetValue(id, out wuWuTaskData))
		{
			wuWuTaskData = new WuWuTaskData();
			this.TaskMap[id] = wuWuTaskData;
		}
		wuWuTaskData.TaskId = id;
		wuWuTaskData.TaskPackId = taskPackId;
		wuWuTaskData.Progress = taskInfo.Current;
		wuWuTaskData.TargetProgress = taskInfo.Target;
		wuWuTaskData.State = this.ConvertTaskState(taskInfo.Status);
	}

	// Token: 0x0600753B RID: 30011 RVA: 0x00243808 File Offset: 0x00241A08
	private void UpdateTaskPackData(WuWuTaskPack packInfo)
	{
		if (packInfo == null)
		{
			return;
		}
		int wuWuPackageId = packInfo.WuWuPackageId;
		WuWuTaskPackData wuWuTaskPackData;
		if (!this.TaskPackMap.TryGetValue(wuWuPackageId, out wuWuTaskPackData))
		{
			wuWuTaskPackData = new WuWuTaskPackData();
			this.TaskPackMap[wuWuPackageId] = wuWuTaskPackData;
			IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
			if (allTaskPackage != null)
			{
				int prePackCfgId = 0;
				foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
				{
					if (wuWuTaskPackage.Id == wuWuPackageId)
					{
						break;
					}
					prePackCfgId = wuWuTaskPackage.Id;
				}
				wuWuTaskPackData.PrePackCfgId = prePackCfgId;
			}
		}
		wuWuTaskPackData.TaskPackId = wuWuPackageId;
		wuWuTaskPackData.UnlockTime = packInfo.UnLockTime;
		wuWuTaskPackData.HadReward = packInfo.HadReward;
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x002438C8 File Offset: 0x00241AC8
	private EWuWuTaskState ConvertTaskState(ConditionTaskState protoState)
	{
		if (protoState == ConditionTaskState.ConditionTaskFinish)
		{
			return EWuWuTaskState.Finish;
		}
		if (protoState != ConditionTaskState.ConditionTaskTaken)
		{
			return EWuWuTaskState.Running;
		}
		return EWuWuTaskState.Taken;
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x002438DC File Offset: 0x00241ADC
	[NullableContext(2)]
	public WuWuTaskData GetTaskById(int taskId)
	{
		WuWuTaskData result;
		if (!this.TaskMap.TryGetValue(taskId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600753E RID: 30014 RVA: 0x002438FC File Offset: 0x00241AFC
	[NullableContext(2)]
	public WuWuTaskPackData GetTaskPackById(int taskPackId)
	{
		WuWuTaskPackData result;
		if (!this.TaskPackMap.TryGetValue(taskPackId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x0024391C File Offset: 0x00241B1C
	public bool HasRewardToClaim()
	{
		foreach (WuWuTaskData wuWuTaskData in this.TaskMap.Values)
		{
			if (this.IsPackUnlocked(wuWuTaskData.TaskPackId) && wuWuTaskData.CanReceiveReward)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007540 RID: 30016 RVA: 0x0024398C File Offset: 0x00241B8C
	public int GetCompletedPackCount()
	{
		int num = 0;
		foreach (WuWuTaskPackData wuWuTaskPackData in this.TaskPackMap.Values)
		{
			if (this.TargetPackIsFullyRewarded(wuWuTaskPackData.TaskPackId))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x002439F4 File Offset: 0x00241BF4
	public int GetTotalTaskCount()
	{
		return this.TaskMap.Count;
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x00243A01 File Offset: 0x00241C01
	public int GetTotalTaskPackCount()
	{
		return this.TaskPackMap.Count;
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x00243A10 File Offset: 0x00241C10
	public bool TargetPackIsAllCompleted(int packId)
	{
		IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(packId);
		if (weekTaskByWrapId == null)
		{
			return false;
		}
		foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
		{
			WuWuTaskData taskById = this.GetTaskById(wuWuWeekTask.Id);
			if (taskById == null)
			{
				return false;
			}
			if (!taskById.IsCompleted)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x00243A8C File Offset: 0x00241C8C
	public bool TargetPackIsAllRewarded(int packId)
	{
		IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(packId);
		if (weekTaskByWrapId == null)
		{
			return false;
		}
		foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
		{
			WuWuTaskData taskById = this.GetTaskById(wuWuWeekTask.Id);
			if (taskById == null)
			{
				return false;
			}
			if (!taskById.IsRewarded)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007545 RID: 30021 RVA: 0x00243B08 File Offset: 0x00241D08
	public bool TargetPackIsFullyRewarded(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && this.TargetPackIsAllRewarded(packId) && taskPackById.HadReward;
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x00243B34 File Offset: 0x00241D34
	public bool TargetPackChildTaskHasReceiveReward(int packId)
	{
		IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(packId);
		if (weekTaskByWrapId == null)
		{
			return false;
		}
		foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
		{
			WuWuTaskData taskById = this.GetTaskById(wuWuWeekTask.Id);
			if (taskById == null)
			{
				return false;
			}
			if (taskById.CanReceiveReward)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007547 RID: 30023 RVA: 0x00243BB0 File Offset: 0x00241DB0
	public bool TargetPackHasReceiveReward(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && !taskPackById.HadReward && this.TargetPackIsAllCompleted(packId);
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x00243BDC File Offset: 0x00241DDC
	public bool IsPackUnlocked(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && taskPackById.IsUnlock && (taskPackById.PrePackCfgId == 0 || (taskPackById.PrePackCfgId > 0 && this.TargetPackIsAllCompleted(taskPackById.PrePackCfgId)));
	}

	// Token: 0x06007549 RID: 30025 RVA: 0x00243C20 File Offset: 0x00241E20
	public int GetDefaultOpenPackCfgId()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null || allTaskPackage.Count == 0)
		{
			return 0;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
		{
			num2 = ((num2 == 0) ? wuWuTaskPackage.Id : num2);
			bool flag = true;
			if (this.IsPackUnlocked(wuWuTaskPackage.Id))
			{
				IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(wuWuTaskPackage.Id);
				if (weekTaskByWrapId != null)
				{
					foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
					{
						WuWuTaskData taskById = this.GetTaskById(wuWuWeekTask.Id);
						if (taskById == null || !taskById.IsCompleted)
						{
							num3 = ((num3 == 0) ? wuWuTaskPackage.Id : num3);
							flag = false;
						}
						else if (taskById.CanReceiveReward)
						{
							num = ((num == 0) ? wuWuTaskPackage.Id : num);
						}
					}
				}
				WuWuTaskPackData taskPackById = this.GetTaskPackById(wuWuTaskPackage.Id);
				if (flag && (taskPackById == null || !taskPackById.HadReward))
				{
					return wuWuTaskPackage.Id;
				}
			}
			else
			{
				num4 = ((num4 == 0) ? wuWuTaskPackage.Id : num4);
			}
		}
		if (num > 0)
		{
			return num;
		}
		if (num3 > 0)
		{
			return num3;
		}
		if (num4 > 0)
		{
			return num4;
		}
		return num2;
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x00243DB4 File Offset: 0x00241FB4
	public override bool GetExDataRedPointShowState()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null)
		{
			return false;
		}
		ServerStorageMapMap serverStorageMapMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Activity) as ServerStorageMapMap;
		foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
		{
			bool flag = this.IsPackUnlocked(wuWuTaskPackage.Id);
			WuWuTaskPackData taskPackById = this.GetTaskPackById(wuWuTaskPackage.Id);
			if (flag && taskPackById != null)
			{
				if (serverStorageMapMap.Get(base.Id, wuWuTaskPackage.Id) == null)
				{
					return true;
				}
				if (this.TargetPackHasReceiveReward(wuWuTaskPackage.Id))
				{
					return true;
				}
				if (this.TargetPackChildTaskHasReceiveReward(wuWuTaskPackage.Id))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x00243E88 File Offset: 0x00242088
	public bool HasFirstUnlockPack()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null)
		{
			return false;
		}
		ServerStorageMapMap serverStorageMapMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Activity) as ServerStorageMapMap;
		foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
		{
			if (serverStorageMapMap.Get(base.Id, wuWuTaskPackage.Id) == null && this.IsPackUnlocked(wuWuTaskPackage.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x00243F20 File Offset: 0x00242120
	public void SetFirstUnlockPack()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null)
		{
			return;
		}
		ServerStorageMapMap serverStorageMapMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Activity) as ServerStorageMapMap;
		foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
		{
			if (serverStorageMapMap.Get(base.Id, wuWuTaskPackage.Id) == null && this.IsPackUnlocked(wuWuTaskPackage.Id))
			{
				serverStorageMapMap.Set(base.Id, wuWuTaskPackage.Id, wuWuTaskPackage.Id);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00243FE0 File Offset: 0x002421E0
	[NullableContext(2)]
	public List<int> GetTargetPackCanReceiveTaskIds(int packId)
	{
		IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(packId);
		if (weekTaskByWrapId != null)
		{
			List<int> list = new List<int>();
			foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
			{
				WuWuTaskData taskById = this.GetTaskById(wuWuWeekTask.Id);
				if (taskById != null && taskById.CanReceiveReward)
				{
					list.Add(wuWuWeekTask.Id);
				}
			}
			return list;
		}
		return null;
	}

	// Token: 0x0600754E RID: 30030 RVA: 0x00244064 File Offset: 0x00242264
	protected override bool GetExDataFinishShowState()
	{
		if (this.TaskMap.Count == 0)
		{
			return false;
		}
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null)
		{
			return false;
		}
		foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
		{
			if (!this.TargetPackIsFullyRewarded(wuWuTaskPackage.Id))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04004A05 RID: 18949
	private readonly Dictionary<int, WuWuTaskData> TaskMap = new Dictionary<int, WuWuTaskData>();

	// Token: 0x04004A06 RID: 18950
	private readonly Dictionary<int, WuWuTaskPackData> TaskPackMap = new Dictionary<int, WuWuTaskPackData>();
}
