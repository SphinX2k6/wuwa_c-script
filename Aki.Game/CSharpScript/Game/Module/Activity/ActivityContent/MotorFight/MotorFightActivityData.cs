using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200537C RID: 21372
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightActivityData : ActivityBaseData
	{
		// Token: 0x060352C5 RID: 217797 RVA: 0x00ED9C6C File Offset: 0x00ED7E6C
		protected override void OnInit(ActivityData data)
		{
			if (data.MotorFightActivityPb == null)
			{
				Log.Instance.Error(ELogModule.MotorFightActivity, ELogAuthor.CXJ, "摩托战斗活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.TalentTreeItemId = MotorFightConfig.Instance.GetMotorFightActivityConfig(base.Id).Value.TalentTreeItemId;
			this.InitLevelData();
			this.InitTaskData();
			this.InitMotorFightItemData();
			this.InitMotorFightTalentData();
			this.InitRoleData();
		}

		// Token: 0x060352C6 RID: 217798 RVA: 0x00ED9CE8 File Offset: 0x00ED7EE8
		protected override void PhraseEx(ActivityData data)
		{
			MotorFightActivityPb motorFightActivityPb = data.MotorFightActivityPb;
			if (motorFightActivityPb == null)
			{
				Log.Instance.Error(ELogModule.MotorFightActivity, ELogAuthor.CXJ, "摩托战斗活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateLevelDataList(motorFightActivityPb.MotorFightLevelPb, false);
			this.UpdateTaskData(motorFightActivityPb.Task, false);
			this.UpdateMotorFightItemDataList(motorFightActivityPb.UnlockedItem, false);
			if (motorFightActivityPb.TalentTree != null)
			{
				this.UpdateMotorFightTalentDataList(motorFightActivityPb.TalentTree.Talent, false);
			}
			this.UpdateRoleData(motorFightActivityPb.UnlockedRole, false);
		}

		// Token: 0x060352C7 RID: 217799 RVA: 0x00ED9D6D File Offset: 0x00ED7F6D
		public override bool GetExDataRedPointShowState()
		{
			return base.IsUnLock() && (this.IsLevelHasRedDot() || this.IsTaskHasRedDot() || this.IsTalentTreeHasRedDot() || this.IsHandBookHasRedDot());
		}

		// Token: 0x060352C8 RID: 217800 RVA: 0x00ED9D9C File Offset: 0x00ED7F9C
		protected override bool GetExDataFinishShowState()
		{
			using (Dictionary<int, MotorFightLevelData>.ValueCollection.Enumerator enumerator = this.LevelDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsFinished)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, MotorFightTaskData>.ValueCollection.Enumerator enumerator2 = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (!enumerator2.Current.IsFinished)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060352C9 RID: 217801 RVA: 0x00ED9E44 File Offset: 0x00ED8044
		private void InitLevelData()
		{
			foreach (MotorFightLevel config in ConfigMotorFightLevelByActivityId.GetConfigList(base.Id, true))
			{
				MotorFightLevelData motorFightLevelData = new MotorFightLevelData(config);
				this.LevelDataMap[config.Id] = motorFightLevelData;
				while (this.LevelTreeList.Count <= motorFightLevelData.Column)
				{
					this.LevelTreeList.Add(new List<MotorFightLevelData>());
				}
				this.LevelTreeList[motorFightLevelData.Column].Add(motorFightLevelData);
			}
			using (List<List<MotorFightLevelData>>.Enumerator enumerator2 = this.LevelTreeList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Sort((MotorFightLevelData a, MotorFightLevelData b) => a.Row - b.Row);
				}
			}
			foreach (MotorFightLevelData motorFightLevelData2 in this.LevelDataMap.Values)
			{
				if (motorFightLevelData2.PreLevelIds.Count > 0)
				{
					motorFightLevelData2.PreMotorFightLevelData = this.GetLevelDataById(motorFightLevelData2.PreLevelIds[0]);
				}
			}
		}

		// Token: 0x060352CA RID: 217802 RVA: 0x00ED9FB0 File Offset: 0x00ED81B0
		[NullableContext(2)]
		public MotorFightLevelData GetLevelDataById(int id)
		{
			MotorFightLevelData result;
			if (this.LevelDataMap.TryGetValue(id, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorFightActivity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "摩托战斗关卡数据不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060352CB RID: 217803 RVA: 0x00EDA000 File Offset: 0x00ED8200
		public void UpdateLevelDataList(IReadOnlyList<MotorFightLevelPb> levelInfoList, bool needEmit = false)
		{
			foreach (MotorFightLevelPb motorFightLevelPb in levelInfoList)
			{
				MotorFightLevelData levelDataById = this.GetLevelDataById(motorFightLevelPb.LevelId);
				if (levelDataById != null)
				{
					levelDataById.UnlockTime = motorFightLevelPb.OpenTime;
					levelDataById.BestScore = motorFightLevelPb.BestScore;
					levelDataById.IsFinished = motorFightLevelPb.Cleared;
					levelDataById.RoleId = motorFightLevelPb.LastRoleId;
				}
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352CC RID: 217804 RVA: 0x00EDA09C File Offset: 0x00ED829C
		public bool IsLevelHasRedDot()
		{
			using (Dictionary<int, MotorFightLevelData>.ValueCollection.Enumerator enumerator = this.LevelDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasLevelRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060352CD RID: 217805 RVA: 0x00EDA0FC File Offset: 0x00ED82FC
		public bool IsEndlessLevelUnlock()
		{
			foreach (MotorFightLevelData motorFightLevelData in this.LevelDataMap.Values)
			{
				if (motorFightLevelData.Type == EMotorFightLevelType.Endless && motorFightLevelData.IsUnLock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060352CE RID: 217806 RVA: 0x00EDA168 File Offset: 0x00ED8368
		public List<List<MotorFightLevelData>> GetLevelTreeList()
		{
			return this.LevelTreeList;
		}

		// Token: 0x060352CF RID: 217807 RVA: 0x00EDA170 File Offset: 0x00ED8370
		public void SetLastSavedLevelData(MotorFightLastSaveData lastSavedLevelData)
		{
			this.LastSavedLevelData = lastSavedLevelData;
		}

		// Token: 0x060352D0 RID: 217808 RVA: 0x00EDA179 File Offset: 0x00ED8379
		[NullableContext(2)]
		public MotorFightLastSaveData GetLastSavedLevelData()
		{
			return this.LastSavedLevelData;
		}

		// Token: 0x060352D1 RID: 217809 RVA: 0x00EDA181 File Offset: 0x00ED8381
		public bool HasLastSavedLevelData()
		{
			return this.LastSavedLevelData != null;
		}

		// Token: 0x060352D2 RID: 217810 RVA: 0x00EDA18C File Offset: 0x00ED838C
		private void InitTaskData()
		{
			foreach (MotorFightTask config in ConfigMotorFightTaskByActivityId.GetConfigList(base.Id, true))
			{
				MotorFightTaskData motorFightTaskData = new MotorFightTaskData(config);
				this.TaskDataMap[config.Id] = motorFightTaskData;
				if (!this.TabToTaskDataListMap.ContainsKey(config.PageType))
				{
					this.TabToTaskDataListMap[config.PageType] = new List<MotorFightTaskData>();
				}
				this.TabToTaskDataListMap[config.PageType].Add(motorFightTaskData);
			}
		}

		// Token: 0x060352D3 RID: 217811 RVA: 0x00EDA238 File Offset: 0x00ED8438
		[NullableContext(2)]
		private MotorFightTaskData GetMotorFightTaskData(int taskId)
		{
			MotorFightTaskData result;
			if (this.TaskDataMap.TryGetValue(taskId, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorFightActivity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "摩托战斗任务配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060352D4 RID: 217812 RVA: 0x00EDA288 File Offset: 0x00ED8488
		public void UpdateTaskData(IReadOnlyList<ConditionTask> taskList, bool needEmit = false)
		{
			foreach (ConditionTask conditionTask in taskList)
			{
				MotorFightTaskData motorFightTaskData = this.GetMotorFightTaskData(conditionTask.Id);
				motorFightTaskData.Status = TaskStateResolver.ConditionState[conditionTask.Status];
				motorFightTaskData.Current = conditionTask.Current;
				motorFightTaskData.Target = conditionTask.Target;
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352D5 RID: 217813 RVA: 0x00EDA31C File Offset: 0x00ED851C
		public void RequestTaskReward(int tabId)
		{
			List<MotorFightTaskData> taskDataList = this.GetTaskDataList(tabId);
			List<int> list = new List<int>();
			foreach (MotorFightTaskData motorFightTaskData in taskDataList)
			{
				if (motorFightTaskData.IsUnclaimed)
				{
					list.Add(motorFightTaskData.Id);
				}
			}
			MotorFightController.Instance.RequestTaskReward(list);
		}

		// Token: 0x060352D6 RID: 217814 RVA: 0x00EDA390 File Offset: 0x00ED8590
		public void UpdateTaskRewardStatus(List<ConditionTask> taskInfoList, bool needEmit = false)
		{
			foreach (ConditionTask conditionTask in taskInfoList)
			{
				this.GetMotorFightTaskData(conditionTask.Id).Status = TaskStateResolver.ConditionState[conditionTask.Status];
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352D7 RID: 217815 RVA: 0x00EDA414 File Offset: 0x00ED8614
		public void GetTaskReward(List<int> taskIds)
		{
			foreach (int taskId in taskIds)
			{
				this.GetMotorFightTaskData(taskId).Status = EActivityTaskState.FinishedAndClaimed;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060352D8 RID: 217816 RVA: 0x00EDA480 File Offset: 0x00ED8680
		public bool IsTaskHasRedDot()
		{
			using (Dictionary<int, MotorFightTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060352D9 RID: 217817 RVA: 0x00EDA4E0 File Offset: 0x00ED86E0
		public bool IsTaskHasRedDotByTab(int tabId)
		{
			List<MotorFightTaskData> list;
			using (List<MotorFightTaskData>.Enumerator enumerator = (this.TabToTaskDataListMap.TryGetValue(tabId, out list) ? list : new List<MotorFightTaskData>()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060352DA RID: 217818 RVA: 0x00EDA54C File Offset: 0x00ED874C
		public List<MotorFightTaskData> GetTaskDataList(int tabId)
		{
			List<MotorFightTaskData> list2;
			List<MotorFightTaskData> list = this.TabToTaskDataListMap.TryGetValue(tabId, out list2) ? list2 : new List<MotorFightTaskData>();
			list.Sort(new Comparison<MotorFightTaskData>(this.SortTaskData));
			return list;
		}

		// Token: 0x060352DB RID: 217819 RVA: 0x00EDA583 File Offset: 0x00ED8783
		private int SortTaskData(MotorFightTaskData a, MotorFightTaskData b)
		{
			if (a.Status != b.Status)
			{
				return a.Status - b.Status;
			}
			return a.Id - b.Id;
		}

		// Token: 0x060352DC RID: 217820 RVA: 0x00EDA5AE File Offset: 0x00ED87AE
		public int GetTotalTaskNum()
		{
			return this.TaskDataMap.Count;
		}

		// Token: 0x060352DD RID: 217821 RVA: 0x00EDA5BC File Offset: 0x00ED87BC
		public int GetFinishedTaskNum()
		{
			int num = 0;
			using (Dictionary<int, MotorFightTaskData>.ValueCollection.Enumerator enumerator = this.TaskDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinished)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060352DE RID: 217822 RVA: 0x00EDA61C File Offset: 0x00ED881C
		public List<MotorFightTaskTab> GetMotorFightTaskTabList()
		{
			if (this.MotorFightTaskTabList.Count == 0)
			{
				IReadOnlyList<MotorFightTaskTab> configList = ConfigMotorFightTaskTabByActivityId.GetConfigList(base.Id, true);
				this.MotorFightTaskTabList = new List<MotorFightTaskTab>(configList);
			}
			return this.MotorFightTaskTabList;
		}

		// Token: 0x060352DF RID: 217823 RVA: 0x00EDA658 File Offset: 0x00ED8858
		private void InitMotorFightItemData()
		{
			foreach (MotorFightItem config in ConfigMotorFightItemByActivityId.GetConfigList(base.Id, true))
			{
				if (config.IsShowInHandBook)
				{
					MotorFightItemData motorFightItemData = new MotorFightItemData(config, null);
					this.ItemDataMap[config.Id] = motorFightItemData;
					int type = config.Type;
					if (!this.TypeToItemDataMap.ContainsKey(type))
					{
						this.TypeToItemDataMap[type] = new List<MotorFightItemData>();
					}
					this.TypeToItemDataMap[type].Add(motorFightItemData);
				}
			}
		}

		// Token: 0x060352E0 RID: 217824 RVA: 0x00EDA70C File Offset: 0x00ED890C
		public void UpdateMotorFightItemDataList(IReadOnlyList<int> itemIdList, bool needEmit = false)
		{
			foreach (int itemId in itemIdList)
			{
				this.UpdateMotorFightItemData(itemId);
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352E1 RID: 217825 RVA: 0x00EDA770 File Offset: 0x00ED8970
		public void UpdateMotorFightItemData(int itemId)
		{
			MotorFightItemData motorFightItemData = this.GetMotorFightItemData(itemId);
			if (motorFightItemData == null)
			{
				return;
			}
			motorFightItemData.IsUnLock = true;
		}

		// Token: 0x060352E2 RID: 217826 RVA: 0x00EDA790 File Offset: 0x00ED8990
		[NullableContext(2)]
		public MotorFightItemData GetMotorFightItemData(int id)
		{
			MotorFightItemData result;
			if (this.ItemDataMap.TryGetValue(id, out result))
			{
				return result;
			}
			if (MotorFightConfig.Instance.GetMotorFightItemConfig(id).Value.IsShowInHandBook)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorFightActivity;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "获取MotorFightItemData失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}

		// Token: 0x060352E3 RID: 217827 RVA: 0x00EDA7FC File Offset: 0x00ED89FC
		public Tuple<int, int> GetItemUnlockNum(int type)
		{
			int num = 0;
			List<MotorFightItemData> list;
			if (!this.TypeToItemDataMap.TryGetValue(type, out list))
			{
				return new Tuple<int, int>(0, 0);
			}
			using (List<MotorFightItemData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			return new Tuple<int, int>(num, list.Count);
		}

		// Token: 0x060352E4 RID: 217828 RVA: 0x00EDA874 File Offset: 0x00ED8A74
		[NullableContext(0)]
		public ValueTuple<int, int> GetAllItemUnlockNum()
		{
			int num = 0;
			using (Dictionary<int, MotorFightItemData>.ValueCollection.Enumerator enumerator = this.ItemDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, this.ItemDataMap.Count);
		}

		// Token: 0x060352E5 RID: 217829 RVA: 0x00EDA8E4 File Offset: 0x00ED8AE4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MotorFightItemData> GetMotorFightItemDataListByType(int type)
		{
			List<MotorFightItemData> source;
			if (!this.TypeToItemDataMap.TryGetValue(type, out source))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorFightActivity;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "通过类型获取MotorFightItemDataList失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TypeId", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return NoLinq.SortToList<MotorFightItemData>(source, delegate(MotorFightItemData left, MotorFightItemData right)
			{
				int num = right.IsUnLock.CompareTo(left.IsUnLock);
				if (num != 0)
				{
					return num;
				}
				num = right.Quality.CompareTo(left.Quality);
				if (num == 0)
				{
					return left.Id.CompareTo(right.Id);
				}
				return num;
			});
		}

		// Token: 0x060352E6 RID: 217830 RVA: 0x00EDA958 File Offset: 0x00ED8B58
		public bool IsHandBookHasRedDot()
		{
			using (Dictionary<int, MotorFightItemData>.ValueCollection.Enumerator enumerator = this.ItemDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasItemRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060352E7 RID: 217831 RVA: 0x00EDA9B8 File Offset: 0x00ED8BB8
		public void ReadHandBookRedDot()
		{
			foreach (MotorFightItemData motorFightItemData in this.ItemDataMap.Values)
			{
				if (motorFightItemData.HasItemRedDot)
				{
					motorFightItemData.ReadItemRedDot();
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060352E8 RID: 217832 RVA: 0x00EDAA30 File Offset: 0x00ED8C30
		public List<MotorFightItemType> GetMotorFightItemTypeList()
		{
			if (this.MotorFightItemTypeList.Count == 0)
			{
				IReadOnlyList<MotorFightItemType> configList = ConfigMotorFightItemTypeAll.GetConfigList(true);
				this.MotorFightItemTypeList = new List<MotorFightItemType>(configList);
			}
			return this.MotorFightItemTypeList;
		}

		// Token: 0x060352E9 RID: 217833 RVA: 0x00EDAA64 File Offset: 0x00ED8C64
		private void InitMotorFightTalentData()
		{
			foreach (MotorFightTalent config in ConfigMotorFightTalentByActivityId.GetConfigList(base.Id, true))
			{
				MotorFightTalentData motorFightTalentData = new MotorFightTalentData(config);
				this.TalentDataMap[config.Id] = motorFightTalentData;
				this.TalentList.Add(motorFightTalentData);
				while (this.TalentTreeList.Count <= motorFightTalentData.Column)
				{
					this.TalentTreeList.Add(new List<MotorFightTalentData>());
				}
				this.TalentTreeList[motorFightTalentData.Column].Add(motorFightTalentData);
			}
			foreach (List<MotorFightTalentData> list in this.TalentTreeList)
			{
				if (list != null)
				{
					list.Sort((MotorFightTalentData a, MotorFightTalentData b) => a.Row - b.Row);
				}
			}
			this.TalentList.Sort((MotorFightTalentData a, MotorFightTalentData b) => a.Id - b.Id);
		}

		// Token: 0x060352EA RID: 217834 RVA: 0x00EDABA0 File Offset: 0x00ED8DA0
		public void UpdateMotorFightTalentDataList(IReadOnlyList<MotorFightTalentPb> talentInfoList, bool needEmit = false)
		{
			foreach (MotorFightTalentPb motorFightTalentPb in talentInfoList)
			{
				MotorFightTalentData motorFightTalentData = this.GetMotorFightTalentData(motorFightTalentPb.Id);
				if (motorFightTalentData != null)
				{
					motorFightTalentData.IsFinishPreCondition = motorFightTalentPb.Unlock;
					motorFightTalentData.IsUnLock = motorFightTalentPb.InUse;
				}
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352EB RID: 217835 RVA: 0x00EDAC24 File Offset: 0x00ED8E24
		public void UpdateMotorFightTalentData(int talentId)
		{
			MotorFightTalentData motorFightTalentData = this.GetMotorFightTalentData(talentId);
			if (motorFightTalentData == null)
			{
				return;
			}
			motorFightTalentData.IsUnLock = true;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060352EC RID: 217836 RVA: 0x00EDAC5C File Offset: 0x00ED8E5C
		[NullableContext(2)]
		public MotorFightTalentData GetMotorFightTalentData(int id)
		{
			MotorFightTalentData result;
			if (this.TalentDataMap.TryGetValue(id, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorFightActivity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "获取MotorFightTalentData失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060352ED RID: 217837 RVA: 0x00EDACAB File Offset: 0x00ED8EAB
		public List<List<MotorFightTalentData>> GetTalentTreeList()
		{
			return this.TalentTreeList;
		}

		// Token: 0x060352EE RID: 217838 RVA: 0x00EDACB4 File Offset: 0x00ED8EB4
		public string GetTalentProgress()
		{
			int count = this.TalentDataMap.Count;
			int num = 0;
			using (Dictionary<int, MotorFightTalentData>.ValueCollection.Enumerator enumerator = this.TalentDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnLock)
					{
						num++;
					}
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060352EF RID: 217839 RVA: 0x00EDAD4C File Offset: 0x00ED8F4C
		public int GetTalentCoinNum()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.TalentTreeItemId, 0);
		}

		// Token: 0x060352F0 RID: 217840 RVA: 0x00EDAD60 File Offset: 0x00ED8F60
		public unsafe bool IsPreNodeAllUnlock(MotorFightTalentData data)
		{
			Span<int> preNode = data.PreNode;
			for (int i = 0; i < preNode.Length; i++)
			{
				int id = *preNode[i];
				MotorFightTalentData motorFightTalentData = this.GetMotorFightTalentData(id);
				if (motorFightTalentData == null || !motorFightTalentData.IsUnLock)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060352F1 RID: 217841 RVA: 0x00EDADAB File Offset: 0x00ED8FAB
		public bool IsTalentCanUnlock(MotorFightTalentData data)
		{
			return !data.IsUnLock && data.IsFinishPreCondition && this.IsPreNodeAllUnlock(data) && this.GetTalentCoinNum() >= data.Cost;
		}

		// Token: 0x060352F2 RID: 217842 RVA: 0x00EDADD8 File Offset: 0x00ED8FD8
		public bool IsTalentTreeHasRedDot()
		{
			foreach (MotorFightTalentData data in this.TalentDataMap.Values)
			{
				if (this.IsTalentCanUnlock(data))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060352F3 RID: 217843 RVA: 0x00EDAE3C File Offset: 0x00ED903C
		public int GetNextCanUnlockTalentId()
		{
			int num = -1;
			foreach (MotorFightTalentData motorFightTalentData in this.TalentList)
			{
				if (num == -1 && !motorFightTalentData.IsUnLock)
				{
					num = motorFightTalentData.Id;
				}
				if (this.IsTalentCanUnlock(motorFightTalentData))
				{
					return motorFightTalentData.Id;
				}
			}
			if (num != -1)
			{
				return num;
			}
			return this.TalentList[this.TalentList.Count - 1].Id;
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x060352F4 RID: 217844 RVA: 0x00EDAED4 File Offset: 0x00ED90D4
		// (set) Token: 0x060352F5 RID: 217845 RVA: 0x00EDAEF0 File Offset: 0x00ED90F0
		public int SelectedTalentNodeId
		{
			get
			{
				if (this.SelectedTalentNodeIdInternal == 0)
				{
					this.SelectedTalentNodeIdInternal = this.GetNextCanUnlockTalentId();
				}
				return this.SelectedTalentNodeIdInternal;
			}
			set
			{
				this.SelectedTalentNodeIdInternal = value;
			}
		}

		// Token: 0x060352F6 RID: 217846 RVA: 0x00EDAEFC File Offset: 0x00ED90FC
		private void InitRoleData()
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			foreach (MotorFightRole config in MotorFightConfig.Instance.GetMotorFightRoleList(base.Id))
			{
				MotorFightRoleData motorFightRoleData = new MotorFightRoleData(config);
				this.RoleMap[config.Id] = motorFightRoleData;
				if (this.CheckRoleIsValid((EMotorFightRoleType)config.Type, playerGender))
				{
					this.RoleList.Add(motorFightRoleData);
				}
			}
			this.RoleList.Sort((MotorFightRoleData a, MotorFightRoleData b) => a.Id - b.Id);
		}

		// Token: 0x060352F7 RID: 217847 RVA: 0x00EDAFB8 File Offset: 0x00ED91B8
		private bool CheckRoleIsValid(EMotorFightRoleType type, EPlayerGender gender)
		{
			return type == EMotorFightRoleType.Normal || (type == EMotorFightRoleType.MainRoleMale && gender == EPlayerGender.Male) || (type == EMotorFightRoleType.MainRoleFemale && gender == EPlayerGender.Female);
		}

		// Token: 0x060352F8 RID: 217848 RVA: 0x00EDAFD0 File Offset: 0x00ED91D0
		[NullableContext(2)]
		public MotorFightRoleData GetMotorFightRoleData(int id)
		{
			MotorFightRoleData result;
			if (this.RoleMap.TryGetValue(id, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorFightActivity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "获取MotorFightRoleData失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060352F9 RID: 217849 RVA: 0x00EDB020 File Offset: 0x00ED9220
		public void UpdateRoleData(IReadOnlyList<int> roleIds, bool needEmit = false)
		{
			foreach (int id in roleIds)
			{
				MotorFightRoleData motorFightRoleData = this.GetMotorFightRoleData(id);
				if (motorFightRoleData != null)
				{
					motorFightRoleData.IsUnLock = true;
				}
			}
			if (needEmit)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x060352FA RID: 217850 RVA: 0x00EDB08C File Offset: 0x00ED928C
		public List<MotorFightRoleData> GetMotorFightRoleList()
		{
			return this.RoleList;
		}

		// Token: 0x060352FB RID: 217851 RVA: 0x00EDB094 File Offset: 0x00ED9294
		public int GetLevelUsedRole(int levelId)
		{
			int id = this.RoleList[0].Id;
			MotorFightLevelData levelDataById = this.GetLevelDataById(levelId);
			if (levelDataById.RoleId != 0)
			{
				return levelDataById.RoleId;
			}
			int num = (levelDataById.PreLevelIds.Count > 0) ? levelDataById.PreLevelIds[0] : 0;
			if (num == 0)
			{
				return id;
			}
			MotorFightLevelData levelDataById2 = this.GetLevelDataById(num);
			if (levelDataById2.RoleId != 0)
			{
				return levelDataById2.RoleId;
			}
			return id;
		}

		// Token: 0x060352FC RID: 217852 RVA: 0x00EDB108 File Offset: 0x00ED9308
		public bool IsRoleHasRedDot()
		{
			using (Dictionary<int, MotorFightRoleData>.ValueCollection.Enumerator enumerator = this.RoleMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060352FD RID: 217853 RVA: 0x00EDB168 File Offset: 0x00ED9368
		public void UpdateFriendsRankList(IReadOnlyList<MotorFightPlayerRankingInfo> list)
		{
			this.MotorFightFriendsRankList = new List<MotorFightRankData>();
			foreach (MotorFightPlayerRankingInfo dataByServerInfo in list)
			{
				MotorFightRankData motorFightRankData = new MotorFightRankData(false);
				motorFightRankData.SetDataByServerInfo(dataByServerInfo);
				this.MotorFightFriendsRankList.Add(motorFightRankData);
			}
		}

		// Token: 0x060352FE RID: 217854 RVA: 0x00EDB1D0 File Offset: 0x00ED93D0
		[NullableContext(2)]
		public void UpdateMyRank(MotorFightPlayerRankingInfo rankInfo)
		{
			this.MyRankData.SetDataByServerInfo(rankInfo);
		}

		// Token: 0x060352FF RID: 217855 RVA: 0x00EDB1E0 File Offset: 0x00ED93E0
		private List<MotorFightRankData> GetRobotRankList()
		{
			if (this.MotorFightRobotRankList.Count == 0)
			{
				foreach (MotorFightRank dataByConfig in MotorFightConfig.Instance.GetMotorFightRobotRankList())
				{
					MotorFightRankData motorFightRankData = new MotorFightRankData(false);
					motorFightRankData.SetDataByConfig(dataByConfig);
					this.MotorFightRobotRankList.Add(motorFightRankData);
				}
			}
			return this.MotorFightRobotRankList;
		}

		// Token: 0x06035300 RID: 217856 RVA: 0x00EDB258 File Offset: 0x00ED9458
		public List<MotorFightRankData> GetRankList()
		{
			List<MotorFightRankData> list = new List<MotorFightRankData>(this.MotorFightFriendsRankList);
			if (this.MyRankData.HasData)
			{
				list.Add(this.MyRankData);
			}
			int count = list.Count;
			foreach (MotorFightRankData motorFightRankData in this.GetRobotRankList())
			{
				if (count < motorFightRankData.DisplayThreshold)
				{
					list.Add(motorFightRankData);
				}
			}
			list.Sort((MotorFightRankData a, MotorFightRankData b) => b.Score - a.Score);
			return list;
		}

		// Token: 0x0401C0E5 RID: 114917
		private readonly Dictionary<int, MotorFightLevelData> LevelDataMap = new Dictionary<int, MotorFightLevelData>();

		// Token: 0x0401C0E6 RID: 114918
		private List<List<MotorFightLevelData>> LevelTreeList = new List<List<MotorFightLevelData>>();

		// Token: 0x0401C0E7 RID: 114919
		private MotorFightLastSaveData LastSavedLevelData;

		// Token: 0x0401C0E8 RID: 114920
		private readonly Dictionary<int, MotorFightTaskData> TaskDataMap = new Dictionary<int, MotorFightTaskData>();

		// Token: 0x0401C0E9 RID: 114921
		private readonly Dictionary<int, List<MotorFightTaskData>> TabToTaskDataListMap = new Dictionary<int, List<MotorFightTaskData>>();

		// Token: 0x0401C0EA RID: 114922
		private List<MotorFightTaskTab> MotorFightTaskTabList = new List<MotorFightTaskTab>();

		// Token: 0x0401C0EB RID: 114923
		private readonly Dictionary<int, MotorFightItemData> ItemDataMap = new Dictionary<int, MotorFightItemData>();

		// Token: 0x0401C0EC RID: 114924
		private readonly Dictionary<int, List<MotorFightItemData>> TypeToItemDataMap = new Dictionary<int, List<MotorFightItemData>>();

		// Token: 0x0401C0ED RID: 114925
		private List<MotorFightItemType> MotorFightItemTypeList = new List<MotorFightItemType>();

		// Token: 0x0401C0EE RID: 114926
		private readonly Dictionary<int, MotorFightTalentData> TalentDataMap = new Dictionary<int, MotorFightTalentData>();

		// Token: 0x0401C0EF RID: 114927
		private readonly List<MotorFightTalentData> TalentList = new List<MotorFightTalentData>();

		// Token: 0x0401C0F0 RID: 114928
		private List<List<MotorFightTalentData>> TalentTreeList = new List<List<MotorFightTalentData>>();

		// Token: 0x0401C0F1 RID: 114929
		public int TalentTreeItemId;

		// Token: 0x0401C0F2 RID: 114930
		private int SelectedTalentNodeIdInternal;

		// Token: 0x0401C0F3 RID: 114931
		private readonly Dictionary<int, MotorFightRoleData> RoleMap = new Dictionary<int, MotorFightRoleData>();

		// Token: 0x0401C0F4 RID: 114932
		private readonly List<MotorFightRoleData> RoleList = new List<MotorFightRoleData>();

		// Token: 0x0401C0F5 RID: 114933
		private List<MotorFightRankData> MotorFightFriendsRankList = new List<MotorFightRankData>();

		// Token: 0x0401C0F6 RID: 114934
		private readonly List<MotorFightRankData> MotorFightRobotRankList = new List<MotorFightRankData>();

		// Token: 0x0401C0F7 RID: 114935
		public readonly MotorFightRankData MyRankData = new MotorFightRankData(true);
	}
}
