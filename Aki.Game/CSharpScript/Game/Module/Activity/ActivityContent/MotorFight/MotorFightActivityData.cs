using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020063FE RID: 25598
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightActivityData : ActivityBaseData
	{
		// Token: 0x06040604 RID: 263684 RVA: 0x00F92C8C File Offset: 0x00F90E8C
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

		// Token: 0x06040605 RID: 263685 RVA: 0x00F92D08 File Offset: 0x00F90F08
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

		// Token: 0x06040606 RID: 263686 RVA: 0x00F92D8D File Offset: 0x00F90F8D
		public override bool GetExDataRedPointShowState()
		{
			return base.IsUnLock() && (this.IsLevelHasRedDot() || this.IsTaskHasRedDot() || this.IsTalentTreeHasRedDot() || this.IsHandBookHasRedDot());
		}

		// Token: 0x06040607 RID: 263687 RVA: 0x00F92DBC File Offset: 0x00F90FBC
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

		// Token: 0x06040608 RID: 263688 RVA: 0x00F92E64 File Offset: 0x00F91064
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

		// Token: 0x06040609 RID: 263689 RVA: 0x00F92FD0 File Offset: 0x00F911D0
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

		// Token: 0x0604060A RID: 263690 RVA: 0x00F93020 File Offset: 0x00F91220
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

		// Token: 0x0604060B RID: 263691 RVA: 0x00F930BC File Offset: 0x00F912BC
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

		// Token: 0x0604060C RID: 263692 RVA: 0x00F9311C File Offset: 0x00F9131C
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

		// Token: 0x0604060D RID: 263693 RVA: 0x00F93188 File Offset: 0x00F91388
		public List<List<MotorFightLevelData>> GetLevelTreeList()
		{
			return this.LevelTreeList;
		}

		// Token: 0x0604060E RID: 263694 RVA: 0x00F93190 File Offset: 0x00F91390
		public void SetLastSavedLevelData(MotorFightLastSaveData lastSavedLevelData)
		{
			this.LastSavedLevelData = lastSavedLevelData;
		}

		// Token: 0x0604060F RID: 263695 RVA: 0x00F93199 File Offset: 0x00F91399
		[NullableContext(2)]
		public MotorFightLastSaveData GetLastSavedLevelData()
		{
			return this.LastSavedLevelData;
		}

		// Token: 0x06040610 RID: 263696 RVA: 0x00F931A1 File Offset: 0x00F913A1
		public bool HasLastSavedLevelData()
		{
			return this.LastSavedLevelData != null;
		}

		// Token: 0x06040611 RID: 263697 RVA: 0x00F931AC File Offset: 0x00F913AC
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

		// Token: 0x06040612 RID: 263698 RVA: 0x00F93258 File Offset: 0x00F91458
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

		// Token: 0x06040613 RID: 263699 RVA: 0x00F932A8 File Offset: 0x00F914A8
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

		// Token: 0x06040614 RID: 263700 RVA: 0x00F9333C File Offset: 0x00F9153C
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

		// Token: 0x06040615 RID: 263701 RVA: 0x00F933B0 File Offset: 0x00F915B0
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

		// Token: 0x06040616 RID: 263702 RVA: 0x00F93434 File Offset: 0x00F91634
		public void GetTaskReward(List<int> taskIds)
		{
			foreach (int taskId in taskIds)
			{
				this.GetMotorFightTaskData(taskId).Status = EActivityTaskState.FinishedAndClaimed;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040617 RID: 263703 RVA: 0x00F934A0 File Offset: 0x00F916A0
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

		// Token: 0x06040618 RID: 263704 RVA: 0x00F93500 File Offset: 0x00F91700
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

		// Token: 0x06040619 RID: 263705 RVA: 0x00F9356C File Offset: 0x00F9176C
		public List<MotorFightTaskData> GetTaskDataList(int tabId)
		{
			List<MotorFightTaskData> list2;
			List<MotorFightTaskData> list = this.TabToTaskDataListMap.TryGetValue(tabId, out list2) ? list2 : new List<MotorFightTaskData>();
			list.Sort(new Comparison<MotorFightTaskData>(this.SortTaskData));
			return list;
		}

		// Token: 0x0604061A RID: 263706 RVA: 0x00F935A3 File Offset: 0x00F917A3
		private int SortTaskData(MotorFightTaskData a, MotorFightTaskData b)
		{
			if (a.Status != b.Status)
			{
				return a.Status - b.Status;
			}
			return a.Id - b.Id;
		}

		// Token: 0x0604061B RID: 263707 RVA: 0x00F935CE File Offset: 0x00F917CE
		public int GetTotalTaskNum()
		{
			return this.TaskDataMap.Count;
		}

		// Token: 0x0604061C RID: 263708 RVA: 0x00F935DC File Offset: 0x00F917DC
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

		// Token: 0x0604061D RID: 263709 RVA: 0x00F9363C File Offset: 0x00F9183C
		public List<MotorFightTaskTab> GetMotorFightTaskTabList()
		{
			if (this.MotorFightTaskTabList.Count == 0)
			{
				IReadOnlyList<MotorFightTaskTab> configList = ConfigMotorFightTaskTabByActivityId.GetConfigList(base.Id, true);
				this.MotorFightTaskTabList = new List<MotorFightTaskTab>(configList);
			}
			return this.MotorFightTaskTabList;
		}

		// Token: 0x0604061E RID: 263710 RVA: 0x00F93678 File Offset: 0x00F91878
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

		// Token: 0x0604061F RID: 263711 RVA: 0x00F9372C File Offset: 0x00F9192C
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

		// Token: 0x06040620 RID: 263712 RVA: 0x00F93790 File Offset: 0x00F91990
		public void UpdateMotorFightItemData(int itemId)
		{
			MotorFightItemData motorFightItemData = this.GetMotorFightItemData(itemId);
			if (motorFightItemData == null)
			{
				return;
			}
			motorFightItemData.IsUnLock = true;
		}

		// Token: 0x06040621 RID: 263713 RVA: 0x00F937B0 File Offset: 0x00F919B0
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

		// Token: 0x06040622 RID: 263714 RVA: 0x00F9381C File Offset: 0x00F91A1C
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

		// Token: 0x06040623 RID: 263715 RVA: 0x00F93894 File Offset: 0x00F91A94
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

		// Token: 0x06040624 RID: 263716 RVA: 0x00F93904 File Offset: 0x00F91B04
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
			return (from x in source
			orderby x.IsUnLock descending, x.Quality descending, x.Id
			select x).ToList<MotorFightItemData>();
		}

		// Token: 0x06040625 RID: 263717 RVA: 0x00F939C4 File Offset: 0x00F91BC4
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

		// Token: 0x06040626 RID: 263718 RVA: 0x00F93A24 File Offset: 0x00F91C24
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

		// Token: 0x06040627 RID: 263719 RVA: 0x00F93A9C File Offset: 0x00F91C9C
		public List<MotorFightItemType> GetMotorFightItemTypeList()
		{
			if (this.MotorFightItemTypeList.Count == 0)
			{
				IReadOnlyList<MotorFightItemType> configList = ConfigMotorFightItemTypeAll.GetConfigList(true);
				this.MotorFightItemTypeList = new List<MotorFightItemType>(configList);
			}
			return this.MotorFightItemTypeList;
		}

		// Token: 0x06040628 RID: 263720 RVA: 0x00F93AD0 File Offset: 0x00F91CD0
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

		// Token: 0x06040629 RID: 263721 RVA: 0x00F93C0C File Offset: 0x00F91E0C
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

		// Token: 0x0604062A RID: 263722 RVA: 0x00F93C90 File Offset: 0x00F91E90
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

		// Token: 0x0604062B RID: 263723 RVA: 0x00F93CC8 File Offset: 0x00F91EC8
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

		// Token: 0x0604062C RID: 263724 RVA: 0x00F93D17 File Offset: 0x00F91F17
		public List<List<MotorFightTalentData>> GetTalentTreeList()
		{
			return this.TalentTreeList;
		}

		// Token: 0x0604062D RID: 263725 RVA: 0x00F93D20 File Offset: 0x00F91F20
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

		// Token: 0x0604062E RID: 263726 RVA: 0x00F93DB8 File Offset: 0x00F91FB8
		public int GetTalentCoinNum()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.TalentTreeItemId, 0);
		}

		// Token: 0x0604062F RID: 263727 RVA: 0x00F93DCC File Offset: 0x00F91FCC
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

		// Token: 0x06040630 RID: 263728 RVA: 0x00F93E17 File Offset: 0x00F92017
		public bool IsTalentCanUnlock(MotorFightTalentData data)
		{
			return !data.IsUnLock && data.IsFinishPreCondition && this.IsPreNodeAllUnlock(data) && this.GetTalentCoinNum() >= data.Cost;
		}

		// Token: 0x06040631 RID: 263729 RVA: 0x00F93E44 File Offset: 0x00F92044
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

		// Token: 0x06040632 RID: 263730 RVA: 0x00F93EA8 File Offset: 0x00F920A8
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
			return this.TalentList.Last<MotorFightTalentData>().Id;
		}

		// Token: 0x17009431 RID: 37937
		// (get) Token: 0x06040633 RID: 263731 RVA: 0x00F93F34 File Offset: 0x00F92134
		// (set) Token: 0x06040634 RID: 263732 RVA: 0x00F93F50 File Offset: 0x00F92150
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

		// Token: 0x06040635 RID: 263733 RVA: 0x00F93F5C File Offset: 0x00F9215C
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

		// Token: 0x06040636 RID: 263734 RVA: 0x00F94018 File Offset: 0x00F92218
		private bool CheckRoleIsValid(EMotorFightRoleType type, EPlayerGender gender)
		{
			return type == EMotorFightRoleType.Normal || (type == EMotorFightRoleType.MainRoleMale && gender == EPlayerGender.Male) || (type == EMotorFightRoleType.MainRoleFemale && gender == EPlayerGender.Female);
		}

		// Token: 0x06040637 RID: 263735 RVA: 0x00F94030 File Offset: 0x00F92230
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

		// Token: 0x06040638 RID: 263736 RVA: 0x00F94080 File Offset: 0x00F92280
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

		// Token: 0x06040639 RID: 263737 RVA: 0x00F940EC File Offset: 0x00F922EC
		public List<MotorFightRoleData> GetMotorFightRoleList()
		{
			return this.RoleList;
		}

		// Token: 0x0604063A RID: 263738 RVA: 0x00F940F4 File Offset: 0x00F922F4
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

		// Token: 0x0604063B RID: 263739 RVA: 0x00F94168 File Offset: 0x00F92368
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

		// Token: 0x0604063C RID: 263740 RVA: 0x00F941C8 File Offset: 0x00F923C8
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

		// Token: 0x0604063D RID: 263741 RVA: 0x00F94230 File Offset: 0x00F92430
		[NullableContext(2)]
		public void UpdateMyRank(MotorFightPlayerRankingInfo rankInfo)
		{
			this.MyRankData.SetDataByServerInfo(rankInfo);
		}

		// Token: 0x0604063E RID: 263742 RVA: 0x00F94240 File Offset: 0x00F92440
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

		// Token: 0x0604063F RID: 263743 RVA: 0x00F942B8 File Offset: 0x00F924B8
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

		// Token: 0x040217B6 RID: 137142
		private readonly Dictionary<int, MotorFightLevelData> LevelDataMap = new Dictionary<int, MotorFightLevelData>();

		// Token: 0x040217B7 RID: 137143
		private List<List<MotorFightLevelData>> LevelTreeList = new List<List<MotorFightLevelData>>();

		// Token: 0x040217B8 RID: 137144
		private MotorFightLastSaveData LastSavedLevelData;

		// Token: 0x040217B9 RID: 137145
		private readonly Dictionary<int, MotorFightTaskData> TaskDataMap = new Dictionary<int, MotorFightTaskData>();

		// Token: 0x040217BA RID: 137146
		private readonly Dictionary<int, List<MotorFightTaskData>> TabToTaskDataListMap = new Dictionary<int, List<MotorFightTaskData>>();

		// Token: 0x040217BB RID: 137147
		private List<MotorFightTaskTab> MotorFightTaskTabList = new List<MotorFightTaskTab>();

		// Token: 0x040217BC RID: 137148
		private readonly Dictionary<int, MotorFightItemData> ItemDataMap = new Dictionary<int, MotorFightItemData>();

		// Token: 0x040217BD RID: 137149
		private readonly Dictionary<int, List<MotorFightItemData>> TypeToItemDataMap = new Dictionary<int, List<MotorFightItemData>>();

		// Token: 0x040217BE RID: 137150
		private List<MotorFightItemType> MotorFightItemTypeList = new List<MotorFightItemType>();

		// Token: 0x040217BF RID: 137151
		private readonly Dictionary<int, MotorFightTalentData> TalentDataMap = new Dictionary<int, MotorFightTalentData>();

		// Token: 0x040217C0 RID: 137152
		private readonly List<MotorFightTalentData> TalentList = new List<MotorFightTalentData>();

		// Token: 0x040217C1 RID: 137153
		private List<List<MotorFightTalentData>> TalentTreeList = new List<List<MotorFightTalentData>>();

		// Token: 0x040217C2 RID: 137154
		public int TalentTreeItemId;

		// Token: 0x040217C3 RID: 137155
		private int SelectedTalentNodeIdInternal;

		// Token: 0x040217C4 RID: 137156
		private readonly Dictionary<int, MotorFightRoleData> RoleMap = new Dictionary<int, MotorFightRoleData>();

		// Token: 0x040217C5 RID: 137157
		private readonly List<MotorFightRoleData> RoleList = new List<MotorFightRoleData>();

		// Token: 0x040217C6 RID: 137158
		private List<MotorFightRankData> MotorFightFriendsRankList = new List<MotorFightRankData>();

		// Token: 0x040217C7 RID: 137159
		private readonly List<MotorFightRankData> MotorFightRobotRankList = new List<MotorFightRankData>();

		// Token: 0x040217C8 RID: 137160
		public readonly MotorFightRankData MyRankData = new MotorFightRankData(true);
	}
}
