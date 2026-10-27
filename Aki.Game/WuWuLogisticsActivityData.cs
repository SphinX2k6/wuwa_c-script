using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200165C RID: 5724
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsActivityData : ActivityBaseData
{
	// Token: 0x0600A15B RID: 41307 RVA: 0x0023984C File Offset: 0x00237A4C
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

	// Token: 0x0600A15C RID: 41308 RVA: 0x002398F8 File Offset: 0x00237AF8
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

	// Token: 0x0600A15D RID: 41309 RVA: 0x0023996C File Offset: 0x00237B6C
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

	// Token: 0x0600A15E RID: 41310 RVA: 0x00239A2C File Offset: 0x00237C2C
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

	// Token: 0x0600A15F RID: 41311 RVA: 0x00239A40 File Offset: 0x00237C40
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

	// Token: 0x0600A160 RID: 41312 RVA: 0x00239A60 File Offset: 0x00237C60
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

	// Token: 0x0600A161 RID: 41313 RVA: 0x00239A80 File Offset: 0x00237C80
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

	// Token: 0x0600A162 RID: 41314 RVA: 0x00239AF0 File Offset: 0x00237CF0
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

	// Token: 0x0600A163 RID: 41315 RVA: 0x00239B58 File Offset: 0x00237D58
	public int GetTotalTaskCount()
	{
		return this.TaskMap.Count;
	}

	// Token: 0x0600A164 RID: 41316 RVA: 0x00239B65 File Offset: 0x00237D65
	public int GetTotalTaskPackCount()
	{
		return this.TaskPackMap.Count;
	}

	// Token: 0x0600A165 RID: 41317 RVA: 0x00239B74 File Offset: 0x00237D74
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

	// Token: 0x0600A166 RID: 41318 RVA: 0x00239BF0 File Offset: 0x00237DF0
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

	// Token: 0x0600A167 RID: 41319 RVA: 0x00239C6C File Offset: 0x00237E6C
	public bool TargetPackIsFullyRewarded(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && this.TargetPackIsAllRewarded(packId) && taskPackById.HadReward;
	}

	// Token: 0x0600A168 RID: 41320 RVA: 0x00239C98 File Offset: 0x00237E98
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

	// Token: 0x0600A169 RID: 41321 RVA: 0x00239D14 File Offset: 0x00237F14
	public bool TargetPackHasReceiveReward(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && !taskPackById.HadReward && this.TargetPackIsAllCompleted(packId);
	}

	// Token: 0x0600A16A RID: 41322 RVA: 0x00239D40 File Offset: 0x00237F40
	public bool IsPackUnlocked(int packId)
	{
		WuWuTaskPackData taskPackById = this.GetTaskPackById(packId);
		return taskPackById != null && taskPackById.IsUnlock && (taskPackById.PrePackCfgId == 0 || (taskPackById.PrePackCfgId > 0 && this.TargetPackIsAllCompleted(taskPackById.PrePackCfgId)));
	}

	// Token: 0x0600A16B RID: 41323 RVA: 0x00239D84 File Offset: 0x00237F84
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

	// Token: 0x0600A16C RID: 41324 RVA: 0x00239F18 File Offset: 0x00238118
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

	// Token: 0x0600A16D RID: 41325 RVA: 0x00239FEC File Offset: 0x002381EC
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

	// Token: 0x0600A16E RID: 41326 RVA: 0x0023A084 File Offset: 0x00238284
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

	// Token: 0x0600A16F RID: 41327 RVA: 0x0023A144 File Offset: 0x00238344
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

	// Token: 0x0600A170 RID: 41328 RVA: 0x0023A1C8 File Offset: 0x002383C8
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

	// Token: 0x0400495F RID: 18783
	private readonly Dictionary<int, WuWuTaskData> TaskMap = new Dictionary<int, WuWuTaskData>();

	// Token: 0x04004960 RID: 18784
	private readonly Dictionary<int, WuWuTaskPackData> TaskPackMap = new Dictionary<int, WuWuTaskPackData>();
}
