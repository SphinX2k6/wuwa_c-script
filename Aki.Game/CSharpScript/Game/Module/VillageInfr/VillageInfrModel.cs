using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003816 RID: 14358
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class VillageInfrModel : ModelBase
	{
		// Token: 0x060254E8 RID: 152808 RVA: 0x00A83F4F File Offset: 0x00A8214F
		public void SetData(InfrV2Pb data)
		{
			this.SetAllTreeData(data.TreeInfo);
			this.SetVillageData(data.FireInfo);
			this.SetTaskData(data.ConditionTasks);
			this.SetScoreRewardData(data.RewardScoreIds);
			this.SetAllTreeFinishConditionData(data.TreeFinishCond);
		}

		// Token: 0x060254E9 RID: 152809 RVA: 0x00A83F90 File Offset: 0x00A82190
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

		// Token: 0x060254EA RID: 152810 RVA: 0x00A83FB0 File Offset: 0x00A821B0
		public List<IVillageInfrTreeData> GetAllTreeData()
		{
			return new List<IVillageInfrTreeData>(this.TreeDataMap.Values);
		}

		// Token: 0x060254EB RID: 152811 RVA: 0x00A83FC4 File Offset: 0x00A821C4
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

		// Token: 0x060254EC RID: 152812 RVA: 0x00A8406C File Offset: 0x00A8226C
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

		// Token: 0x060254ED RID: 152813 RVA: 0x00A840C3 File Offset: 0x00A822C3
		public void SetTraceTreeId(int treeId)
		{
			this.TraceTreeId = treeId;
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeDataUpdate);
		}

		// Token: 0x060254EE RID: 152814 RVA: 0x00A840DC File Offset: 0x00A822DC
		public int GetTraceTreeId()
		{
			return this.TraceTreeId;
		}

		// Token: 0x060254EF RID: 152815 RVA: 0x00A840E4 File Offset: 0x00A822E4
		public long GetVillageExp()
		{
			return this.VillageExpInner;
		}

		// Token: 0x060254F0 RID: 152816 RVA: 0x00A840EC File Offset: 0x00A822EC
		public int GetVillageLevel()
		{
			return this.VillageLevelInner;
		}

		// Token: 0x060254F1 RID: 152817 RVA: 0x00A840F4 File Offset: 0x00A822F4
		public long GetVillageLevelReachTime()
		{
			return this.VillageLevelReachTimeInner;
		}

		// Token: 0x060254F2 RID: 152818 RVA: 0x00A840FC File Offset: 0x00A822FC
		public InfrV2StatusPb GetVillageStatus()
		{
			return this.VillageStatusInner;
		}

		// Token: 0x060254F3 RID: 152819 RVA: 0x00A84104 File Offset: 0x00A82304
		public void SetVillageData(InfrV2FirePb data)
		{
			this.VillageExpInner = data.FireExp;
			this.VillageLevelInner = data.FireLevel;
			this.VillageLevelReachTimeInner = data.FireLevelReachTime;
			this.VillageStatusInner = data.FireStatus;
			EventSystem.Instance.Emit(EEventName.VillageInfrVillageDataUpdate);
		}

		// Token: 0x060254F4 RID: 152820 RVA: 0x00A84151 File Offset: 0x00A82351
		public void SetActivityData(VillageInfrActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x060254F5 RID: 152821 RVA: 0x00A8415C File Offset: 0x00A8235C
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

		// Token: 0x060254F6 RID: 152822 RVA: 0x00A84198 File Offset: 0x00A82398
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

		// Token: 0x060254F7 RID: 152823 RVA: 0x00A8421C File Offset: 0x00A8241C
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

		// Token: 0x060254F8 RID: 152824 RVA: 0x00A8428C File Offset: 0x00A8248C
		public void SetScoreRewardData(IList<int> scoreRewardIds)
		{
			this.ReceivedScoreRewardId.Clear();
			foreach (int item in scoreRewardIds)
			{
				this.ReceivedScoreRewardId.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrScoreRewardDataUpdate);
		}

		// Token: 0x060254F9 RID: 152825 RVA: 0x00A842F8 File Offset: 0x00A824F8
		public void AddScoreRewardData(List<int> scoreRewardIds)
		{
			foreach (int item in scoreRewardIds)
			{
				this.ReceivedScoreRewardId.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.VillageInfrScoreRewardDataUpdate);
		}

		// Token: 0x060254FA RID: 152826 RVA: 0x00A8435C File Offset: 0x00A8255C
		public void SetAllTreeFinishConditionData(IList<int> data)
		{
			this.TreeFinishConditions = new List<int>(data);
			EventSystem.Instance.Emit(EEventName.VillageInfrTreeFinishCondDataUpdate);
		}

		// Token: 0x060254FB RID: 152827 RVA: 0x00A8437A File Offset: 0x00A8257A
		public bool IsScoreRewardReceived(int id)
		{
			return this.ReceivedScoreRewardId.Contains(id);
		}

		// Token: 0x060254FC RID: 152828 RVA: 0x00A84388 File Offset: 0x00A82588
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

		// Token: 0x060254FD RID: 152829 RVA: 0x00A843E0 File Offset: 0x00A825E0
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

		// Token: 0x060254FE RID: 152830 RVA: 0x00A84431 File Offset: 0x00A82631
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

		// Token: 0x060254FF RID: 152831 RVA: 0x00A84450 File Offset: 0x00A82650
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

		// Token: 0x06025500 RID: 152832 RVA: 0x00A844B0 File Offset: 0x00A826B0
		public bool GetTreeIsUnlock(int treeId)
		{
			IVillageInfrTreeData villageInfrTreeData;
			return this.TreeDataMap.TryGetValue(treeId, out villageInfrTreeData) && villageInfrTreeData.Status > InfrV2StatusPb.InfrV2StatusLock;
		}

		// Token: 0x06025501 RID: 152833 RVA: 0x00A844D8 File Offset: 0x00A826D8
		public bool GetTreeIsComplete(int treeId)
		{
			IVillageInfrTreeData villageInfrTreeData;
			return this.TreeDataMap.TryGetValue(treeId, out villageInfrTreeData) && villageInfrTreeData.Status == InfrV2StatusPb.InfrV2StatusComplete;
		}

		// Token: 0x06025502 RID: 152834 RVA: 0x00A84500 File Offset: 0x00A82700
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

		// Token: 0x06025503 RID: 152835 RVA: 0x00A84588 File Offset: 0x00A82788
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

		// Token: 0x06025504 RID: 152836 RVA: 0x00A845F0 File Offset: 0x00A827F0
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

		// Token: 0x06025505 RID: 152837 RVA: 0x00A84670 File Offset: 0x00A82870
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

		// Token: 0x06025506 RID: 152838 RVA: 0x00A846F0 File Offset: 0x00A828F0
		public bool HasScoreReward()
		{
			return this.GetCanReceiveScoreRewardIds().Count > 0;
		}

		// Token: 0x06025507 RID: 152839 RVA: 0x00A84700 File Offset: 0x00A82900
		public int GetRewardScore()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(ConfigCommonParamById.GetIntConfig("InfrV2ScoreItem").Value, 0);
		}

		// Token: 0x06025508 RID: 152840 RVA: 0x00A8472C File Offset: 0x00A8292C
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

		// Token: 0x06025509 RID: 152841 RVA: 0x00A847B8 File Offset: 0x00A829B8
		public List<int> GetTreeFinishConditions()
		{
			return this.TreeFinishConditions;
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x0602550A RID: 152842 RVA: 0x00A847C0 File Offset: 0x00A829C0
		public static VillageInfrModel Instance
		{
			get
			{
				return VillageInfrModel._Instance;
			}
		}

		// Token: 0x0602550B RID: 152843 RVA: 0x00A847C7 File Offset: 0x00A829C7
		public static VillageInfrModel GetOrCreateInstance()
		{
			if (VillageInfrModel._Instance == null)
			{
				VillageInfrModel.CreateInstance();
			}
			return VillageInfrModel._Instance;
		}

		// Token: 0x0602550C RID: 152844 RVA: 0x00A847DB File Offset: 0x00A829DB
		public static bool CreateInstance()
		{
			if (VillageInfrModel._Instance != null)
			{
				return true;
			}
			VillageInfrModel._Instance = new VillageInfrModel();
			return true;
		}

		// Token: 0x0602550D RID: 152845 RVA: 0x00A847F1 File Offset: 0x00A829F1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602550E RID: 152846 RVA: 0x00A847F3 File Offset: 0x00A829F3
		public static void ResetStaticDefaultValue()
		{
			VillageInfrModel._Instance = null;
		}

		// Token: 0x0602550F RID: 152847 RVA: 0x00A847FB File Offset: 0x00A829FB
		static VillageInfrModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrModel.CreateStaticDefaultValue), new Action(VillageInfrModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014A44 RID: 84548
		private readonly Dictionary<int, IVillageInfrTreeData> TreeDataMap = new Dictionary<int, IVillageInfrTreeData>();

		// Token: 0x04014A45 RID: 84549
		private readonly Dictionary<int, VillageInfrLimitTaskData> TaskDataMap = new Dictionary<int, VillageInfrLimitTaskData>();

		// Token: 0x04014A46 RID: 84550
		private int TraceTreeId;

		// Token: 0x04014A47 RID: 84551
		private readonly HashSet<int> ReceivedScoreRewardId = new HashSet<int>();

		// Token: 0x04014A48 RID: 84552
		private long VillageExpInner;

		// Token: 0x04014A49 RID: 84553
		private int VillageLevelInner;

		// Token: 0x04014A4A RID: 84554
		private long VillageLevelReachTimeInner;

		// Token: 0x04014A4B RID: 84555
		private InfrV2StatusPb VillageStatusInner;

		// Token: 0x04014A4C RID: 84556
		[Nullable(2)]
		private VillageInfrActivityData ActivityData;

		// Token: 0x04014A4D RID: 84557
		private List<int> TreeFinishConditions = new List<int>();

		// Token: 0x04014A4E RID: 84558
		[Nullable(2)]
		private static VillageInfrModel _Instance;
	}
}
