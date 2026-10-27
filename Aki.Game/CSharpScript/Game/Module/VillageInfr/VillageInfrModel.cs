using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200489F RID: 18591
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class VillageInfrModel : ModelBase
	{
		// Token: 0x060309BC RID: 199100 RVA: 0x00B49147 File Offset: 0x00B47347
		public void SetData(InfrV2Pb data)
		{
			this.SetAllTreeData(data.TreeInfo);
			this.SetVillageData(data.FireInfo);
			this.SetTaskData(data.ConditionTasks);
			this.SetScoreRewardData(data.RewardScoreIds);
			this.SetAllTreeFinishConditionData(data.TreeFinishCond);
		}

		// Token: 0x060309BD RID: 199101 RVA: 0x00B49188 File Offset: 0x00B47388
		[NullableContext(2)]
		public IVillageInfrTreeData GetTreeData(int treeId)
		{
			IVillageInfrTreeData result;
			if (this.TreeDataMap.TryGetValue(treeId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060309BE RID: 199102 RVA: 0x00B491A8 File Offset: 0x00B473A8
		public List<IVillageInfrTreeData> GetAllTreeData()
		{
			return new List<IVillageInfrTreeData>(this.TreeDataMap.Values);
		}

		// Token: 0x060309BF RID: 199103 RVA: 0x00B491BC File Offset: 0x00B473BC
		public void SetAllTreeData(InfrV2TreePb data)
		{
			this.TreeDataMap.Clear();
			foreach (InfrV2OneTree infrV2OneTree in data.Trees)
			{
				this.TreeDataMap.Add(infrV2OneTree.TreeId, new VillageInfrTreeData
				{
					Id = infrV2OneTree.TreeId,
					Status = infrV2OneTree.Status,
					CompleteTime = infrV2OneTree.CompleteTime
				});
			}
			this.TraceTreeId = data.ManualTraceTree;
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeDataUpdate);
		}

		// Token: 0x060309C0 RID: 199104 RVA: 0x00B49264 File Offset: 0x00B47464
		public void SetTreeData(InfrV2OneTree treeData)
		{
			this.TreeDataMap[treeData.TreeId] = new VillageInfrTreeData
			{
				Id = treeData.TreeId,
				Status = treeData.Status,
				CompleteTime = treeData.CompleteTime
			};
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeDataUpdate);
		}

		// Token: 0x060309C1 RID: 199105 RVA: 0x00B492BB File Offset: 0x00B474BB
		public void SetTraceTreeId(int treeId)
		{
			this.TraceTreeId = treeId;
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeDataUpdate);
		}

		// Token: 0x060309C2 RID: 199106 RVA: 0x00B492D4 File Offset: 0x00B474D4
		public int GetTraceTreeId()
		{
			return this.TraceTreeId;
		}

		// Token: 0x060309C3 RID: 199107 RVA: 0x00B492DC File Offset: 0x00B474DC
		public long GetVillageExp()
		{
			return this.VillageExpInner;
		}

		// Token: 0x060309C4 RID: 199108 RVA: 0x00B492E4 File Offset: 0x00B474E4
		public int GetVillageLevel()
		{
			return this.VillageLevelInner;
		}

		// Token: 0x060309C5 RID: 199109 RVA: 0x00B492EC File Offset: 0x00B474EC
		public long GetVillageLevelReachTime()
		{
			return this.VillageLevelReachTimeInner;
		}

		// Token: 0x060309C6 RID: 199110 RVA: 0x00B492F4 File Offset: 0x00B474F4
		public InfrV2StatusPb GetVillageStatus()
		{
			return this.VillageStatusInner;
		}

		// Token: 0x060309C7 RID: 199111 RVA: 0x00B492FC File Offset: 0x00B474FC
		public void SetVillageData(InfrV2FirePb data)
		{
			this.VillageExpInner = data.FireExp;
			this.VillageLevelInner = data.FireLevel;
			this.VillageLevelReachTimeInner = data.FireLevelReachTime;
			this.VillageStatusInner = data.FireStatus;
			EventSystem.Instance.Emit(EEventName.VillageInfrVillageDataUpdate);
		}

		// Token: 0x060309C8 RID: 199112 RVA: 0x00B49349 File Offset: 0x00B47549
		public void SetActivityData(VillageInfrActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x060309C9 RID: 199113 RVA: 0x00B49354 File Offset: 0x00B47554
		[NullableContext(2)]
		public VillageInfrActivityData GetActivityData()
		{
			if (this.ActivityData == null)
			{
				Log.Instance.Error(ELogModule.VillageInfr, ELogAuthor.LYX, "VillageInfrActivityData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.ActivityData;
		}

		// Token: 0x060309CA RID: 199114 RVA: 0x00B49390 File Offset: 0x00B47590
		public void SetTaskData(IList<ConditionTask> activityTasks)
		{
			this.TaskDataMap.Clear();
			foreach (ConditionTask conditionTask in activityTasks)
			{
				VillageInfrLimitTaskData villageInfrLimitTaskData = new VillageInfrLimitTaskData(conditionTask.Id);
				this.TaskDataMap.Add(conditionTask.Id, villageInfrLimitTaskData);
				villageInfrLimitTaskData.UpdateData(conditionTask);
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrActivityTaskDataUpdate);
		}

		// Token: 0x060309CB RID: 199115 RVA: 0x00B49414 File Offset: 0x00B47614
		public void SetTaskReceive(List<int> taskIdList)
		{
			foreach (int key in taskIdList)
			{
				VillageInfrLimitTaskData villageInfrLimitTaskData;
				if (this.TaskDataMap.TryGetValue(key, out villageInfrLimitTaskData))
				{
					villageInfrLimitTaskData.Status = ConditionTaskState.ConditionTaskTaken;
				}
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrActivityTaskDataUpdate);
		}

		// Token: 0x060309CC RID: 199116 RVA: 0x00B49484 File Offset: 0x00B47684
		public void SetScoreRewardData(IList<int> scoreRewardIds)
		{
			this.ReceivedScoreRewardId.Clear();
			foreach (int item in scoreRewardIds)
			{
				this.ReceivedScoreRewardId.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrScoreRewardDataUpdate);
		}

		// Token: 0x060309CD RID: 199117 RVA: 0x00B494F0 File Offset: 0x00B476F0
		public void AddScoreRewardData(List<int> scoreRewardIds)
		{
			foreach (int item in scoreRewardIds)
			{
				this.ReceivedScoreRewardId.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrScoreRewardDataUpdate);
		}

		// Token: 0x060309CE RID: 199118 RVA: 0x00B49554 File Offset: 0x00B47754
		public void SetAllTreeFinishConditionData(IList<int> data)
		{
			this.TreeFinishConditions = new List<int>(data);
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeFinishCondDataUpdate);
		}

		// Token: 0x060309CF RID: 199119 RVA: 0x00B49572 File Offset: 0x00B47772
		public bool IsScoreRewardReceived(int id)
		{
			return this.ReceivedScoreRewardId.Contains(id);
		}

		// Token: 0x060309D0 RID: 199120 RVA: 0x00B49580 File Offset: 0x00B47780
		public void UpdateActivityTask(ConditionTask data)
		{
			VillageInfrLimitTaskData villageInfrLimitTaskData;
			if (!this.TaskDataMap.TryGetValue(data.Id, out villageInfrLimitTaskData))
			{
				villageInfrLimitTaskData = new VillageInfrLimitTaskData(data.Id);
			}
			villageInfrLimitTaskData.UpdateData(data);
			this.TaskDataMap[data.Id] = villageInfrLimitTaskData;
			EventSystem.Instance.Emit(EEventName.VillageInfrActivityTaskDataUpdate);
		}

		// Token: 0x060309D1 RID: 199121 RVA: 0x00B495D8 File Offset: 0x00B477D8
		public List<VillageInfrLimitTaskData> GetActivityTaskDataList()
		{
			List<VillageInfrLimitTaskData> list = new List<VillageInfrLimitTaskData>(this.TaskDataMap.Values);
			list.Sort(delegate(VillageInfrLimitTaskData a, VillageInfrLimitTaskData b)
			{
				if (a.Status != b.Status)
				{
					return this.GetStatusPriority(a.Status) - this.GetStatusPriority(b.Status);
				}
				return a.ConfigId - b.ConfigId;
			});
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Index = i + 1;
			}
			return list;
		}

		// Token: 0x060309D2 RID: 199122 RVA: 0x00B49629 File Offset: 0x00B47829
		private int GetStatusPriority(ConditionTaskState status)
		{
			switch (status)
			{
			case ConditionTaskState.ConditionTaskRunning:
				return 2;
			case ConditionTaskState.ConditionTaskFinish:
				return 1;
			case ConditionTaskState.ConditionTaskTaken:
				return 3;
			default:
				return 0;
			}
		}

		// Token: 0x060309D3 RID: 199123 RVA: 0x00B49648 File Offset: 0x00B47848
		public bool GetTaskRedDot()
		{
			using (Dictionary<int, VillageInfrLimitTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskFinish)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060309D4 RID: 199124 RVA: 0x00B496A8 File Offset: 0x00B478A8
		public bool GetTreeIsUnlock(int treeId)
		{
			IVillageInfrTreeData villageInfrTreeData;
			return this.TreeDataMap.TryGetValue(treeId, out villageInfrTreeData) && villageInfrTreeData.Status > InfrV2StatusPb.InfrV2StatusLock;
		}

		// Token: 0x060309D5 RID: 199125 RVA: 0x00B496D0 File Offset: 0x00B478D0
		public bool GetTreeIsComplete(int treeId)
		{
			IVillageInfrTreeData villageInfrTreeData;
			return this.TreeDataMap.TryGetValue(treeId, out villageInfrTreeData) && villageInfrTreeData.Status == InfrV2StatusPb.InfrV2StatusComplete;
		}

		// Token: 0x060309D6 RID: 199126 RVA: 0x00B496F8 File Offset: 0x00B478F8
		public bool GetCanVillageLevelUp()
		{
			int infrMaxLevel = VillageInfrConfig.Instance.GetInfrMaxLevel();
			if (this.VillageLevelInner == 0 || this.VillageLevelInner >= infrMaxLevel)
			{
				return false;
			}
			Dictionary<int, int>.Enumerator enumerator = VillageInfrConfig.Instance.GetInfrLevel(this.VillageLevelInner).Value.Requirement().GetEnumerator();
			enumerator.MoveNext();
			KeyValuePair<int, int> keyValuePair = enumerator.Current;
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			return InventoryModel.Instance.GetItemCountByConfigId(key, 0) >= value;
		}

		// Token: 0x060309D7 RID: 199127 RVA: 0x00B49780 File Offset: 0x00B47980
		public bool HasTreeCanLevelUp()
		{
			foreach (IVillageInfrTreeData villageInfrTreeData in this.TreeDataMap.Values)
			{
				if (this.GetCanTreeLevelUp(villageInfrTreeData.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060309D8 RID: 199128 RVA: 0x00B497E8 File Offset: 0x00B479E8
		public bool GetCanTreeLevelUp(int treeId)
		{
			IVillageInfrTreeData villageInfrTreeData;
			if (!this.TreeDataMap.TryGetValue(treeId, out villageInfrTreeData) || villageInfrTreeData.Status != InfrV2StatusPb.InfrV2StatusProgress)
			{
				return false;
			}
			Dictionary<int, int>.Enumerator enumerator = VillageInfrConfig.Instance.GetInfrTreeBuild(treeId).Value.Requirement().GetEnumerator();
			enumerator.MoveNext();
			KeyValuePair<int, int> keyValuePair = enumerator.Current;
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			return InventoryModel.Instance.GetItemCountByConfigId(key, 0) >= value;
		}

		// Token: 0x060309D9 RID: 199129 RVA: 0x00B49868 File Offset: 0x00B47A68
		public List<int> GetCanReceiveScoreRewardIds()
		{
			int rewardScore = this.GetRewardScore();
			List<int> list = new List<int>();
			foreach (InfrV2ScoreReward infrV2ScoreReward in VillageInfrConfig.Instance.GetScoreReward())
			{
				if (infrV2ScoreReward.Score <= rewardScore && !this.IsScoreRewardReceived(infrV2ScoreReward.Id))
				{
					list.Add(infrV2ScoreReward.Id);
				}
			}
			return list;
		}

		// Token: 0x060309DA RID: 199130 RVA: 0x00B498E8 File Offset: 0x00B47AE8
		public bool HasScoreReward()
		{
			return this.GetCanReceiveScoreRewardIds().Count > 0;
		}

		// Token: 0x060309DB RID: 199131 RVA: 0x00B498F8 File Offset: 0x00B47AF8
		public int GetRewardScore()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(ConfigCommonParamById.GetIntConfig("InfrV2ScoreItem").Value, 0);
		}

		// Token: 0x060309DC RID: 199132 RVA: 0x00B49924 File Offset: 0x00B47B24
		public bool CanShowNewTip(int itemId, int count)
		{
			int? treeIdByItemId = VillageInfrConfig.Instance.GetTreeIdByItemId(itemId);
			if (treeIdByItemId == null)
			{
				return false;
			}
			Dictionary<int, int>.Enumerator enumerator = VillageInfrConfig.Instance.GetInfrTreeBuild(treeIdByItemId.Value).Value.Requirement().GetEnumerator();
			enumerator.MoveNext();
			KeyValuePair<int, int> keyValuePair = enumerator.Current;
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key, 0);
			return itemCountByConfigId >= value && itemCountByConfigId - count < value;
		}

		// Token: 0x060309DD RID: 199133 RVA: 0x00B499B0 File Offset: 0x00B47BB0
		public List<int> GetTreeFinishConditions()
		{
			return this.TreeFinishConditions;
		}

		// Token: 0x17007952 RID: 31058
		// (get) Token: 0x060309DE RID: 199134 RVA: 0x00B499B8 File Offset: 0x00B47BB8
		public static VillageInfrModel Instance
		{
			get
			{
				return VillageInfrModel._Instance;
			}
		}

		// Token: 0x060309DF RID: 199135 RVA: 0x00B499BF File Offset: 0x00B47BBF
		public static VillageInfrModel GetOrCreateInstance()
		{
			if (VillageInfrModel._Instance == null)
			{
				VillageInfrModel.CreateInstance();
			}
			return VillageInfrModel._Instance;
		}

		// Token: 0x060309E0 RID: 199136 RVA: 0x00B499D3 File Offset: 0x00B47BD3
		public static bool CreateInstance()
		{
			if (VillageInfrModel._Instance != null)
			{
				return true;
			}
			VillageInfrModel._Instance = new VillageInfrModel();
			return true;
		}

		// Token: 0x060309E1 RID: 199137 RVA: 0x00B499E9 File Offset: 0x00B47BE9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060309E2 RID: 199138 RVA: 0x00B499EB File Offset: 0x00B47BEB
		public static void ResetStaticDefaultValue()
		{
			VillageInfrModel._Instance = null;
		}

		// Token: 0x060309E3 RID: 199139 RVA: 0x00B499F3 File Offset: 0x00B47BF3
		static VillageInfrModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrModel.CreateStaticDefaultValue), new Action(VillageInfrModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A1D1 RID: 106961
		private readonly Dictionary<int, IVillageInfrTreeData> TreeDataMap = new Dictionary<int, IVillageInfrTreeData>();

		// Token: 0x0401A1D2 RID: 106962
		private readonly Dictionary<int, VillageInfrLimitTaskData> TaskDataMap = new Dictionary<int, VillageInfrLimitTaskData>();

		// Token: 0x0401A1D3 RID: 106963
		private int TraceTreeId;

		// Token: 0x0401A1D4 RID: 106964
		private readonly HashSet<int> ReceivedScoreRewardId = new HashSet<int>();

		// Token: 0x0401A1D5 RID: 106965
		private long VillageExpInner;

		// Token: 0x0401A1D6 RID: 106966
		private int VillageLevelInner;

		// Token: 0x0401A1D7 RID: 106967
		private long VillageLevelReachTimeInner;

		// Token: 0x0401A1D8 RID: 106968
		private InfrV2StatusPb VillageStatusInner;

		// Token: 0x0401A1D9 RID: 106969
		[Nullable(2)]
		private VillageInfrActivityData ActivityData;

		// Token: 0x0401A1DA RID: 106970
		private List<int> TreeFinishConditions = new List<int>();

		// Token: 0x0401A1DB RID: 106971
		[Nullable(2)]
		private static VillageInfrModel _Instance;
	}
}
