using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A6E RID: 19054
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkData : ActivityBaseData
	{
		// Token: 0x0602FB03 RID: 195331 RVA: 0x00D4D9CC File Offset: 0x00D4BBCC
		protected override void OnInit(ActivityData data)
		{
			if (data.RogueWhiteCatData == null)
			{
				return;
			}
			this.InitEnergyRewardData();
			this.InitBossRewardData();
			this.InitBossInstData();
		}

		// Token: 0x0602FB04 RID: 195332 RVA: 0x00D4D9E9 File Offset: 0x00D4BBE9
		protected override void PhraseEx(ActivityData data)
		{
			this.RefreshDreamLinkData(data.RogueWhiteCatData);
		}

		// Token: 0x0602FB05 RID: 195333 RVA: 0x00D4D9F7 File Offset: 0x00D4BBF7
		public void UpdateData(RogueWhiteCatDataUpdateNotify data)
		{
			this.RefreshDreamLinkData(data.RogueWhiteCatData);
		}

		// Token: 0x0602FB06 RID: 195334 RVA: 0x00D4DA08 File Offset: 0x00D4BC08
		protected override bool GetExDataFinishShowState()
		{
			using (List<DreamLinkRewardData>.Enumerator enumerator = this.GetEnergyRewardDataList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != EActivityTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, DreamLinkRewardData>.ValueCollection.Enumerator enumerator2 = this.BossRewardMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.Status != EActivityTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, DreamLinkRunTaskData>.ValueCollection.Enumerator enumerator3 = this.RunTaskMap.Values.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					if (enumerator3.Current.Status != EDreamLinkRunTaskState.FinishedAndClaimed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0602FB07 RID: 195335 RVA: 0x00D4DAFC File Offset: 0x00D4BCFC
		public override bool GetExDataRedPointShowState()
		{
			if (!this.IsDreamLinkFunctionUnlock(0))
			{
				return this.GetQuestRedDotState() || this.CheckHasLimitTimeReward() || this.CheckHasEnergyReward();
			}
			if (this.IsDreamLinkFunctionUnlock(1))
			{
				bool flag = this.CheckHasRunRedDot();
				if (flag)
				{
					return flag;
				}
			}
			if (this.IsDreamLinkFunctionUnlock(2))
			{
				bool flag2 = this.CheckDungeonRedDotState();
				if (flag2)
				{
					return flag2;
				}
			}
			if (this.IsDreamLinkFunctionUnlock(3))
			{
				bool flag3 = this.CheckHasBossReward() || this.CheckAllBossInstRedDotState();
				if (flag3)
				{
					return flag3;
				}
			}
			return this.CheckHasLimitTimeReward() || this.CheckHasEnergyReward();
		}

		// Token: 0x0602FB08 RID: 195336 RVA: 0x00D4DB85 File Offset: 0x00D4BD85
		public override bool GetExternalButtonRedPointState()
		{
			if (!this.IsDreamLinkFunctionUnlock(0))
			{
				return this.GetQuestRedDotState();
			}
			return this.RedPointShowState;
		}

		// Token: 0x0602FB09 RID: 195337 RVA: 0x00D4DBA0 File Offset: 0x00D4BDA0
		[NullableContext(2)]
		private void RefreshDreamLinkData(RogueWhiteCatData data)
		{
			if (data == null)
			{
				return;
			}
			this.MaxEnergy = data.MaxEnergy;
			this.RoleInstanceList = new List<RogueRoleInstData>(data.RogueRoleInstData);
			this.LimitTimeRewardOpenTime = data.LimitedStartTime;
			this.LimitTimeRewardEndTime = data.LimitedEndTime;
			this.DungeonProgressRecord = data.Record;
			this.RefreshEnergyDataState(data.SignStateList);
			this.RefreshBossRewardState(data.BossRewardStateList);
			this.RefreshAllLimitTimeReward(data.RogueLimitedAwards);
			this.UnlockMainFunction = new List<int>(data.UnlockButtons);
			foreach (RogueLevelPlayData runTaskData in data.RogueLevelPlayData)
			{
				this.RefreshRunTask(runTaskData);
			}
			foreach (int num in data.ScoreMap.Keys)
			{
				int value = data.ScoreMap[num];
				this.RefreshBossInstDataByInstId(num, new int?(value), null, null, null);
			}
			foreach (RogueBossInstData rogueBossInstData in data.RogueBossInstDatas)
			{
				this.RefreshBossInstDataByInstId(rogueBossInstData.InstId, null, new bool?(rogueBossInstData.IsUnlock), new bool?(rogueBossInstData.IsFinish), new long?(rogueBossInstData.UnlockTime));
				this.RefreshBossInstDataRole(rogueBossInstData.InstId);
			}
			this.RefreshRewardPerformance();
		}

		// Token: 0x0602FB0A RID: 195338 RVA: 0x00D4DD64 File Offset: 0x00D4BF64
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0602FB0B RID: 195339 RVA: 0x00D4DD7C File Offset: 0x00D4BF7C
		public void RefreshRewardPerformance()
		{
			EventSystem.Instance.Emit(EEventName.DreamLinkRewardRefresh);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
			{
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.GetBossRewardData());
			}
		}

		// Token: 0x0602FB0C RID: 195340 RVA: 0x00D4DDD6 File Offset: 0x00D4BFD6
		public void RefreshLimitRewardPerformance()
		{
			if (this.IsLimitTimeRewardOn())
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				EventSystem.Instance.Emit(EEventName.DreamLinkLimitRewardRefresh);
			}
		}

		// Token: 0x0602FB0D RID: 195341 RVA: 0x00D4DE08 File Offset: 0x00D4C008
		public int GetLastUnFinishInst()
		{
			int result = 6;
			for (int i = 0; i < this.RoleInstanceList.Count; i++)
			{
				if (!this.RoleInstanceList[i].IsFinish)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0602FB0E RID: 195342 RVA: 0x00D4DE48 File Offset: 0x00D4C048
		public int GetLastUnlockInst()
		{
			int result = 0;
			for (int i = this.RoleInstanceList.Count - 1; i >= 0; i--)
			{
				if (this.RoleInstanceList[i].IsUnlock)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0602FB0F RID: 195343 RVA: 0x00D4DE88 File Offset: 0x00D4C088
		public int GetLastFinishInst()
		{
			int result = 0;
			for (int i = this.RoleInstanceList.Count - 1; i >= 0; i--)
			{
				if (this.RoleInstanceList[i].IsFinish)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0602FB10 RID: 195344 RVA: 0x00D4DEC8 File Offset: 0x00D4C0C8
		public List<RogueRoleInstData> GetInstListByPages(int page, int pageSize)
		{
			int num = page * pageSize;
			int num2 = num + pageSize;
			return this.RoleInstanceList.GetRange(num, Math.Min(num2 - num, this.RoleInstanceList.Count - num));
		}

		// Token: 0x0602FB11 RID: 195345 RVA: 0x00D4DF00 File Offset: 0x00D4C100
		public int GetRoleInstDataIndex(int instId)
		{
			return this.RoleInstanceList.FindIndex((RogueRoleInstData roleInst) => roleInst.InstId == instId);
		}

		// Token: 0x0602FB12 RID: 195346 RVA: 0x00D4DF31 File Offset: 0x00D4C131
		[NullableContext(2)]
		public RogueRoleInstData GetRoleInstDataByIndex(int index)
		{
			if (index < 0 || index >= this.RoleInstanceList.Count)
			{
				return null;
			}
			return this.RoleInstanceList[index];
		}

		// Token: 0x0602FB13 RID: 195347 RVA: 0x00D4DF54 File Offset: 0x00D4C154
		public int GetCurrentCatProgress()
		{
			int num = 0;
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			foreach (RogueRoleInstData rogueRoleInstData in this.RoleInstanceList)
			{
				DreamLinkRoleDungeon? dreamLinkRoleDungeonConfig = DreamLinkConfig.Instance.GetDreamLinkRoleDungeonConfig(rogueRoleInstData.InstId);
				if (rogueRoleInstData.IsFinish)
				{
					num += dreamLinkRoleDungeonConfig.Value.AddProgress;
				}
			}
			return num + activityConfig.DungeonBaseProgress;
		}

		// Token: 0x0602FB14 RID: 195348 RVA: 0x00D4DFE0 File Offset: 0x00D4C1E0
		public RogueWhiteCat GetActivityConfig()
		{
			return DreamLinkConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x0602FB15 RID: 195349 RVA: 0x00D4E008 File Offset: 0x00D4C208
		public bool IsDreamLinkInst(int id)
		{
			return this.RoleInstanceList.FindIndex((RogueRoleInstData roleInst) => roleInst.InstId == id) != -1;
		}

		// Token: 0x0602FB16 RID: 195350 RVA: 0x00D4E03F File Offset: 0x00D4C23F
		public bool IsDreamLinkFunctionUnlock(int id)
		{
			return this.UnlockMainFunction.Contains(id);
		}

		// Token: 0x0602FB17 RID: 195351 RVA: 0x00D4E050 File Offset: 0x00D4C250
		public int GetFinishInstCount()
		{
			int num = 0;
			using (List<RogueRoleInstData>.Enumerator enumerator = this.RoleInstanceList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinish)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0602FB18 RID: 195352 RVA: 0x00D4E0AC File Offset: 0x00D4C2AC
		public bool IsAllInstFinished()
		{
			return this.GetFinishInstCount() == this.RoleInstanceList.Count;
		}

		// Token: 0x0602FB19 RID: 195353 RVA: 0x00D4E0C1 File Offset: 0x00D4C2C1
		public EDreamLinkStage GetInstStage()
		{
			if (this.GetFinishInstCount() >= 3)
			{
				return EDreamLinkStage.Second;
			}
			return EDreamLinkStage.First;
		}

		// Token: 0x0602FB1A RID: 195354 RVA: 0x00D4E0D0 File Offset: 0x00D4C2D0
		public IDreamLinkDungeonToggleItemParams GetDungeonToggleItemParams()
		{
			if (this.GetFinishInstCount() >= 3)
			{
				return new DreamLinkDungeonToggleItemParams
				{
					TextureBgPath = (UiResourceConfig.Instance.GetResourcePath("DreamLinkDungeonBgRed") ?? ""),
					TextureLightPath = (UiResourceConfig.Instance.GetResourcePath("DreamLinkDungeonLightRed") ?? ""),
					EffectColor = "#cff7ff"
				};
			}
			return new DreamLinkDungeonToggleItemParams
			{
				TextureBgPath = (UiResourceConfig.Instance.GetResourcePath("DreamLinkDungeonBgBlue") ?? ""),
				TextureLightPath = (UiResourceConfig.Instance.GetResourcePath("DreamLinkDungeonLightBlue") ?? ""),
				EffectColor = "#ffe5e7"
			};
		}

		// Token: 0x0602FB1B RID: 195355 RVA: 0x00D4E180 File Offset: 0x00D4C380
		public bool CheckDungeonRedDotStateByInstId(int instId)
		{
			int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, instId, 0);
			int roleInstDataIndex = this.GetRoleInstDataIndex(instId);
			RogueRoleInstData rogueRoleInstData = this.RoleInstanceList[roleInstDataIndex];
			bool flag = rogueRoleInstData.IsUnlock && !rogueRoleInstData.IsFinish;
			if (activityCacheData == 0)
			{
				return flag;
			}
			return TimeUtil.Instance.GetServerTime() - (double)activityCacheData > 259200.0 && flag;
		}

		// Token: 0x0602FB1C RID: 195356 RVA: 0x00D4E1EC File Offset: 0x00D4C3EC
		public void SaveDungeonRedDotStateByInstId(int instId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			ActivityModel.Instance.SaveActivityData(base.Id, 2, instId, 0, (int)serverTime);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0602FB1D RID: 195357 RVA: 0x00D4E220 File Offset: 0x00D4C420
		public bool CheckDungeonRedDotStateByPage(int page, int pageCount)
		{
			if (page < 0 || pageCount <= 0)
			{
				return false;
			}
			int num = page * pageCount;
			while (num < (page + 1) * pageCount && num < this.RoleInstanceList.Count)
			{
				RogueRoleInstData rogueRoleInstData = this.RoleInstanceList[num];
				if (this.CheckDungeonRedDotStateByInstId(rogueRoleInstData.InstId))
				{
					return true;
				}
				num++;
			}
			return false;
		}

		// Token: 0x0602FB1E RID: 195358 RVA: 0x00D4E278 File Offset: 0x00D4C478
		public bool CheckDungeonRedDotState()
		{
			foreach (RogueRoleInstData rogueRoleInstData in this.RoleInstanceList)
			{
				if (this.CheckDungeonRedDotStateByInstId(rogueRoleInstData.InstId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602FB1F RID: 195359 RVA: 0x00D4E2DC File Offset: 0x00D4C4DC
		public bool GetQuestRedDotState()
		{
			int unFinishPreGuideQuestId = base.GetUnFinishPreGuideQuestId();
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 6, unFinishPreGuideQuestId, 0) == 0;
		}

		// Token: 0x0602FB20 RID: 195360 RVA: 0x00D4E308 File Offset: 0x00D4C508
		public void SaveQuestRedDotState()
		{
			if (base.GetPreGuideQuestFinishState())
			{
				return;
			}
			int unFinishPreGuideQuestId = base.GetUnFinishPreGuideQuestId();
			ActivityModel.Instance.SaveActivityData(base.Id, 6, unFinishPreGuideQuestId, 0, 1);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0602FB21 RID: 195361 RVA: 0x00D4E33F File Offset: 0x00D4C53F
		public void SaveFirstCheckRedDotState(int functionId, int id = 0)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, functionId, id, 0, 1);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0602FB22 RID: 195362 RVA: 0x00D4E35C File Offset: 0x00D4C55C
		private void InitBossInstData()
		{
			this.BossInstDataMap.Clear();
			foreach (int num in this.GetActivityConfig().BossInstanceList())
			{
				RogueBossInstance? rogueBossInstanceConfig = DreamLinkConfig.Instance.GetRogueBossInstanceConfig(num);
				int instanceId = rogueBossInstanceConfig.Value.InstanceId;
				DreamLinkBossInstanceData value = new DreamLinkBossInstanceData(num, instanceId, rogueBossInstanceConfig.Value.ConditionGroupId);
				this.BossInstDataMap.Add(instanceId, value);
			}
		}

		// Token: 0x0602FB23 RID: 195363 RVA: 0x00D4E3E0 File Offset: 0x00D4C5E0
		private void RefreshBossInstDataByInstId(int instId, int? score = null, bool? isUnlock = null, bool? isFinished = null, long? unlockTime = null)
		{
			DreamLinkBossInstanceData dreamLinkBossInstanceData;
			if (!this.BossInstDataMap.TryGetValue(instId, out dreamLinkBossInstanceData))
			{
				return;
			}
			if (score != null)
			{
				dreamLinkBossInstanceData.Score = score.Value;
			}
			if (isUnlock != null)
			{
				dreamLinkBossInstanceData.IsUnlock = isUnlock.Value;
			}
			if (isFinished != null)
			{
				dreamLinkBossInstanceData.IsFinished = isFinished.Value;
			}
			if (unlockTime != null)
			{
				dreamLinkBossInstanceData.UnlockTime = unlockTime.Value;
			}
		}

		// Token: 0x0602FB24 RID: 195364 RVA: 0x00D4E458 File Offset: 0x00D4C658
		private void RefreshBossInstDataRole(int instId)
		{
			DreamLinkBossInstanceData dreamLinkBossInstanceData;
			if (!this.BossInstDataMap.TryGetValue(instId, out dreamLinkBossInstanceData))
			{
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, instId, i, 0);
				dreamLinkBossInstanceData.SetBossRoleIdByIndex(i, activityCacheData);
			}
		}

		// Token: 0x0602FB25 RID: 195365 RVA: 0x00D4E49F File Offset: 0x00D4C69F
		public List<DreamLinkBossInstanceData> GetAllBossInstData()
		{
			return NoLinq.OrderByToList<DreamLinkBossInstanceData, int>(this.BossInstDataMap.Values, (DreamLinkBossInstanceData data) => data.TypeId);
		}

		// Token: 0x0602FB26 RID: 195366 RVA: 0x00D4E4D0 File Offset: 0x00D4C6D0
		public void FixBossRoleId(int instId)
		{
			List<int> allBossRoleId = this.GetAllBossRoleId(instId);
			for (int i = 0; i < allBossRoleId.Count; i++)
			{
				int num = allBossRoleId[i];
				if (RoleModel.Instance.IsMainRole(num))
				{
					int num2 = num;
					int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
					if (!(num2 == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null))
					{
						this.SetBossRoleId(instId, i, 0);
					}
				}
			}
		}

		// Token: 0x0602FB27 RID: 195367 RVA: 0x00D4E533 File Offset: 0x00D4C733
		public int GetBossRoleId(int instId, int index)
		{
			return this.BossInstDataMap[instId].GetBossRoleIdByIndex(index);
		}

		// Token: 0x0602FB28 RID: 195368 RVA: 0x00D4E547 File Offset: 0x00D4C747
		public void SetBossRoleId(int instId, int index, int roleId)
		{
			this.BossInstDataMap[instId].SetBossRoleIdByIndex(index, roleId);
			ActivityModel.Instance.SaveActivityData(base.Id, instId, index, 0, roleId);
		}

		// Token: 0x0602FB29 RID: 195369 RVA: 0x00D4E570 File Offset: 0x00D4C770
		public List<int> GetAllBossRoleId(int instId)
		{
			return new List<int>(this.BossInstDataMap[instId].GetBossRoleIdList());
		}

		// Token: 0x0602FB2A RID: 195370 RVA: 0x00D4E588 File Offset: 0x00D4C788
		public bool CheckAllBossInstRedDotState()
		{
			foreach (DreamLinkBossInstanceData dreamLinkBossInstanceData in this.BossInstDataMap.Values)
			{
				if (dreamLinkBossInstanceData.IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, dreamLinkBossInstanceData.InstId, 0) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602FB2B RID: 195371 RVA: 0x00D4E604 File Offset: 0x00D4C804
		public bool GetBossInstRedDotState(int instId)
		{
			return this.BossInstDataMap[instId].IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, instId, 0) == 0;
		}

		// Token: 0x0602FB2C RID: 195372 RVA: 0x00D4E632 File Offset: 0x00D4C832
		public void SaveBossInstRedDotState(int instId)
		{
			if (!this.BossInstDataMap[instId].IsUnlock)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 3, instId, 0, 1);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0602FB2D RID: 195373 RVA: 0x00D4E662 File Offset: 0x00D4C862
		public void SetRunTaskDone(int id)
		{
			this.RunTaskMap[id].Status = EDreamLinkRunTaskState.FinishedAndClaimed;
		}

		// Token: 0x0602FB2E RID: 195374 RVA: 0x00D4E676 File Offset: 0x00D4C876
		public List<DreamLinkRunTaskData> GetDreamLinkRunTaskDataList()
		{
			return NoLinq.OrderByToList<DreamLinkRunTaskData, int>(this.RunTaskMap.Values, (DreamLinkRunTaskData data) => data.Id);
		}

		// Token: 0x0602FB2F RID: 195375 RVA: 0x00D4E6A8 File Offset: 0x00D4C8A8
		public bool IsDreamLinkRunMarkShow(int markId)
		{
			DreamLinkWorldRun? worldRunConfigByMarkId = DreamLinkConfig.Instance.GetWorldRunConfigByMarkId(markId);
			DreamLinkRunTaskData dreamLinkRunTaskData;
			return worldRunConfigByMarkId != null && this.RunTaskMap.TryGetValue(worldRunConfigByMarkId.Value.Id, out dreamLinkRunTaskData) && dreamLinkRunTaskData.Status > EDreamLinkRunTaskState.Lock;
		}

		// Token: 0x0602FB30 RID: 195376 RVA: 0x00D4E6F8 File Offset: 0x00D4C8F8
		public bool CheckHasRunRedDot()
		{
			foreach (DreamLinkRunTaskData dreamLinkRunTaskData in this.RunTaskMap.Values)
			{
				EDreamLinkRunTaskState status = dreamLinkRunTaskData.Status;
				if (status != EDreamLinkRunTaskState.Active)
				{
					if (status == EDreamLinkRunTaskState.FinishedAndUnclaimed)
					{
						return true;
					}
				}
				else if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, dreamLinkRunTaskData.Id, 0) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602FB31 RID: 195377 RVA: 0x00D4E780 File Offset: 0x00D4C980
		public bool GetRunRedDotState(int id)
		{
			DreamLinkRunTaskData dreamLinkRunTaskData = this.RunTaskMap[id];
			EDreamLinkRunTaskState status = dreamLinkRunTaskData.Status;
			if (status != EDreamLinkRunTaskState.Active)
			{
				return status == EDreamLinkRunTaskState.FinishedAndUnclaimed;
			}
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, dreamLinkRunTaskData.Id, 0) == 0;
		}

		// Token: 0x0602FB32 RID: 195378 RVA: 0x00D4E7CC File Offset: 0x00D4C9CC
		public bool CheckHasRunFinished()
		{
			foreach (DreamLinkRunTaskData dreamLinkRunTaskData in this.RunTaskMap.Values)
			{
				if (dreamLinkRunTaskData.Status == EDreamLinkRunTaskState.Active || dreamLinkRunTaskData.Status == EDreamLinkRunTaskState.Lock)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602FB33 RID: 195379 RVA: 0x00D4E838 File Offset: 0x00D4CA38
		[NullableContext(2)]
		private DreamLinkRunTaskData CreateRunTask(int id)
		{
			DreamLinkWorldRun? worldRunConfig = DreamLinkConfig.Instance.GetWorldRunConfig(id);
			if (worldRunConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[DreamLink] RunTask Config Error";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			DreamLinkRunTaskData dreamLinkRunTaskData = new DreamLinkRunTaskData(id);
			dreamLinkRunTaskData.ConditionGroupId = worldRunConfig.Value.ConditionGroupId;
			dreamLinkRunTaskData.TitleTextId = worldRunConfig.Value.Title;
			dreamLinkRunTaskData.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(worldRunConfig.Value.RewardId);
			dreamLinkRunTaskData.MarkId = worldRunConfig.Value.MarkId;
			this.RunTaskMap.Add(id, dreamLinkRunTaskData);
			return dreamLinkRunTaskData;
		}

		// Token: 0x0602FB34 RID: 195380 RVA: 0x00D4E900 File Offset: 0x00D4CB00
		private void RefreshRunTask(RogueLevelPlayData runTaskData)
		{
			DreamLinkRunTaskData dreamLinkRunTaskData;
			if (!this.RunTaskMap.TryGetValue(runTaskData.Index, out dreamLinkRunTaskData))
			{
				dreamLinkRunTaskData = this.CreateRunTask(runTaskData.Index);
				if (dreamLinkRunTaskData == null)
				{
					return;
				}
			}
			dreamLinkRunTaskData.PlayTime = runTaskData.Record;
			dreamLinkRunTaskData.UnlockTime = runTaskData.UnlockTime;
			switch (runTaskData.Reward)
			{
			case SignState.Lock:
				dreamLinkRunTaskData.Status = (runTaskData.IsUnlock ? EDreamLinkRunTaskState.Active : EDreamLinkRunTaskState.Lock);
				return;
			case SignState.Unlock:
				dreamLinkRunTaskData.Status = EDreamLinkRunTaskState.FinishedAndUnclaimed;
				return;
			case SignState.IsReceive:
				dreamLinkRunTaskData.Status = EDreamLinkRunTaskState.FinishedAndClaimed;
				return;
			default:
				return;
			}
		}

		// Token: 0x0602FB35 RID: 195381 RVA: 0x00D4E988 File Offset: 0x00D4CB88
		public int GetEnergyItemId()
		{
			return this.GetActivityConfig().EnergyId;
		}

		// Token: 0x0602FB36 RID: 195382 RVA: 0x00D4E9A3 File Offset: 0x00D4CBA3
		public int GetEnergyItemCount()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.GetEnergyItemId(), 0);
		}

		// Token: 0x0602FB37 RID: 195383 RVA: 0x00D4E9B6 File Offset: 0x00D4CBB6
		public List<DreamLinkRewardData> GetEnergyRewardDataList()
		{
			return NoLinq.OrderByToList<DreamLinkRewardData, int>(this.EnergyRewardMap.Values, (DreamLinkRewardData data) => data.Id);
		}

		// Token: 0x0602FB38 RID: 195384 RVA: 0x00D4E9E8 File Offset: 0x00D4CBE8
		public bool CheckHasEnergyReward()
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, 0, 0) == 0)
			{
				return true;
			}
			using (Dictionary<int, DreamLinkRewardData>.ValueCollection.Enumerator enumerator = this.EnergyRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602FB39 RID: 195385 RVA: 0x00D4EA64 File Offset: 0x00D4CC64
		private void InitEnergyRewardData()
		{
			this.EnergyRewardMap.Clear();
			foreach (int num in this.GetActivityConfig().Rewards())
			{
				RogueWhiteCatReward? energyRewardConfig = DreamLinkConfig.Instance.GetEnergyRewardConfig(num);
				DreamLinkRewardData dreamLinkRewardData = new DreamLinkRewardData(num);
				dreamLinkRewardData.Status = EActivityTaskState.Active;
				dreamLinkRewardData.Target = energyRewardConfig.Value.NeedEnergy;
				this.EnergyRewardMap.Add(num, dreamLinkRewardData);
			}
		}

		// Token: 0x0602FB3A RID: 195386 RVA: 0x00D4EAE0 File Offset: 0x00D4CCE0
		private void RefreshEnergyDataState(IReadOnlyList<SignState> rewardStateList)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			for (int i = 0; i < rewardStateList.Count; i++)
			{
				int id = activityConfig.Rewards(i);
				this.RefreshEnergyRewardData(id, DreamLinkDefine.signStateResolver[rewardStateList[i]]);
			}
		}

		// Token: 0x0602FB3B RID: 195387 RVA: 0x00D4EB28 File Offset: 0x00D4CD28
		public void RefreshEnergyRewardData(int id, EActivityTaskState status)
		{
			DreamLinkRewardData dreamLinkRewardData;
			if (!this.EnergyRewardMap.TryGetValue(id, out dreamLinkRewardData))
			{
				return;
			}
			dreamLinkRewardData.Status = status;
		}

		// Token: 0x0602FB3C RID: 195388 RVA: 0x00D4EB50 File Offset: 0x00D4CD50
		private void InitBossRewardData()
		{
			this.BossRewardMap.Clear();
			this.BossTypeRewardMap.Clear();
			foreach (int num in this.GetActivityConfig().BossRewards())
			{
				DreamLinkRewardData dreamLinkRewardData = new DreamLinkRewardData(num);
				dreamLinkRewardData.Status = EActivityTaskState.Active;
				RogueWhiteCatBossReward? bossRewardConfig = DreamLinkConfig.Instance.GetBossRewardConfig(num);
				List<DreamLinkRewardData> list;
				if (!this.BossTypeRewardMap.TryGetValue(bossRewardConfig.Value.InstanceType, out list))
				{
					list = new List<DreamLinkRewardData>();
					this.BossTypeRewardMap.Add(bossRewardConfig.Value.InstanceType, list);
				}
				list.Add(dreamLinkRewardData);
				this.BossRewardMap.Add(num, dreamLinkRewardData);
			}
		}

		// Token: 0x0602FB3D RID: 195389 RVA: 0x00D4EC10 File Offset: 0x00D4CE10
		private void RefreshBossRewardState(IReadOnlyList<SignState> rewardStateList)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			for (int i = 0; i < rewardStateList.Count; i++)
			{
				int id = activityConfig.BossRewards(i);
				this.RefreshBossRewardData(id, DreamLinkDefine.signStateResolver[rewardStateList[i]]);
			}
		}

		// Token: 0x0602FB3E RID: 195390 RVA: 0x00D4EC58 File Offset: 0x00D4CE58
		public void RefreshBossRewardData(int id, EActivityTaskState status)
		{
			DreamLinkRewardData dreamLinkRewardData;
			if (!this.BossRewardMap.TryGetValue(id, out dreamLinkRewardData))
			{
				return;
			}
			dreamLinkRewardData.Status = status;
		}

		// Token: 0x0602FB3F RID: 195391 RVA: 0x00D4EC80 File Offset: 0x00D4CE80
		public IActivityRewardViewData GetBossRewardData()
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			List<IActivityRewardDataPage> list = new List<IActivityRewardDataPage>();
			foreach (int num in activityConfig.BossTabText().Keys)
			{
				List<IActivityRewardData> list2 = new List<IActivityRewardData>();
				List<DreamLinkRewardData> list3;
				if (this.BossTypeRewardMap.TryGetValue(num, out list3))
				{
					foreach (DreamLinkRewardData data in list3)
					{
						IActivityRewardData bossRewardViewData = this.GetBossRewardViewData(data);
						list2.Add(bossRewardViewData);
					}
				}
				list2.Sort(new Comparison<IActivityRewardData>(this.SortReward));
				ActivityRewardDataPage item = new ActivityRewardDataPage
				{
					TabName = this.GetRewardTabNameByType(num),
					DataList = list2
				};
				list.Add(item);
			}
			return new ActivityRewardViewData
			{
				DataPageList = list,
				Source = EActivityRewardSource.DreamLink
			};
		}

		// Token: 0x0602FB40 RID: 195392 RVA: 0x00D4ED98 File Offset: 0x00D4CF98
		private string GetRewardTabNameByType(int type)
		{
			string text;
			return ConfigMultiTextLang.GetLocalTextNew(this.GetActivityConfig().BossTabText().TryGetValue(type, out text) ? text : "", null) ?? "";
		}

		// Token: 0x0602FB41 RID: 195393 RVA: 0x00D4EDD4 File Offset: 0x00D4CFD4
		private IActivityRewardData GetBossRewardViewData(DreamLinkRewardData data)
		{
			RogueWhiteCatBossReward? bossRewardConfig = DreamLinkConfig.Instance.GetBossRewardConfig(data.Id);
			EActivityRewardState rewardState = EActivityRewardState.Disabled;
			string text = "";
			Action clickFunction = delegate()
			{
			};
			bool value = false;
			switch (data.Status)
			{
			case EActivityTaskState.FinishedAndUnclaimed:
				rewardState = EActivityRewardState.Enable;
				text = "Text_DaMaoZhan_Gain";
				value = true;
				clickFunction = delegate()
				{
					DreamLinkController.Instance.BossRewardRequest(data.Id);
				};
				break;
			case EActivityTaskState.Active:
				text = "Text_DaMaoZhan_OnProgress";
				break;
			case EActivityTaskState.FinishedAndClaimed:
				rewardState = EActivityRewardState.Claimed;
				break;
			}
			if (!StringUtils.IsEmpty(text))
			{
				text = (ConfigMultiTextLang.GetLocalTextNew(text, null) ?? "");
			}
			return new ActivityRewardData
			{
				Id = new int?(data.Id),
				NameText = "",
				NameTextId = bossRewardConfig.Value.Title,
				RewardList = base.GetPreviewReward(new int?(bossRewardConfig.Value.DropId)).ToArray(),
				RewardState = rewardState,
				RewardButtonText = text,
				RewardButtonRedDot = new bool?(value),
				ClickFunction = clickFunction
			};
		}

		// Token: 0x0602FB42 RID: 195394 RVA: 0x00D4EF18 File Offset: 0x00D4D118
		private int SortReward(IActivityRewardData a, IActivityRewardData b)
		{
			DreamLinkRewardData dreamLinkRewardData = this.BossRewardMap[a.Id.Value];
			DreamLinkRewardData dreamLinkRewardData2 = this.BossRewardMap[b.Id.Value];
			if (dreamLinkRewardData.Status == dreamLinkRewardData2.Status)
			{
				return dreamLinkRewardData.Id - dreamLinkRewardData2.Id;
			}
			return dreamLinkRewardData.Status - dreamLinkRewardData2.Status;
		}

		// Token: 0x0602FB43 RID: 195395 RVA: 0x00D4EF84 File Offset: 0x00D4D184
		public bool CheckHasBossReward()
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 7, 0, 0) == 0)
			{
				return true;
			}
			using (Dictionary<int, DreamLinkRewardData>.ValueCollection.Enumerator enumerator = this.BossRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602FB44 RID: 195396 RVA: 0x00D4F000 File Offset: 0x00D4D200
		public int GetLimitTimeRewardTypeLength()
		{
			return this.GetActivityConfig().TabTextLength;
		}

		// Token: 0x0602FB45 RID: 195397 RVA: 0x00D4F01C File Offset: 0x00D4D21C
		public void RefreshAllLimitTimeReward(IEnumerable<RogueLimitedAward> data)
		{
			foreach (RogueLimitedAward rogueLimitedAward in data)
			{
				this.RefreshLimitTimeRewardData(rogueLimitedAward.ConfigId, DreamLinkDefine.signStateResolver[rogueLimitedAward.SignState], new int?(rogueLimitedAward.CurProgress), new int?(rogueLimitedAward.MaxProgress));
			}
		}

		// Token: 0x0602FB46 RID: 195398 RVA: 0x00D4F090 File Offset: 0x00D4D290
		public void RefreshLimitTimeRewardData(int id, EActivityTaskState status, int? current = null, int? target = null)
		{
			DreamLinkRewardData dreamLinkRewardData;
			if (!this.LimitTimeRewardMap.TryGetValue(id, out dreamLinkRewardData))
			{
				dreamLinkRewardData = new DreamLinkRewardData(id);
				this.LimitTimeRewardMap.Add(id, dreamLinkRewardData);
				RogueLimitTimeReward? limitTimeRewardConfig = DreamLinkConfig.Instance.GetLimitTimeRewardConfig(id);
				List<DreamLinkRewardData> list;
				if (!this.LimitTimeTypeRewardMap.TryGetValue((EDreamLinkRewardType)limitTimeRewardConfig.Value.Type, out list))
				{
					list = new List<DreamLinkRewardData>();
					this.LimitTimeTypeRewardMap.Add((EDreamLinkRewardType)limitTimeRewardConfig.Value.Type, list);
				}
				list.Add(dreamLinkRewardData);
			}
			if (current != null)
			{
				dreamLinkRewardData.Current = current.Value;
			}
			if (target != null)
			{
				dreamLinkRewardData.Target = target.Value;
			}
			dreamLinkRewardData.Status = status;
		}

		// Token: 0x0602FB47 RID: 195399 RVA: 0x00D4F146 File Offset: 0x00D4D346
		private int SortTargetData(DreamLinkRewardData a, DreamLinkRewardData b)
		{
			if (a.Status == b.Status)
			{
				return a.Id - b.Id;
			}
			return a.Status - b.Status;
		}

		// Token: 0x0602FB48 RID: 195400 RVA: 0x00D4F171 File Offset: 0x00D4D371
		public long GetLimitTimeEndTime()
		{
			return this.LimitTimeRewardEndTime;
		}

		// Token: 0x0602FB49 RID: 195401 RVA: 0x00D4F17C File Offset: 0x00D4D37C
		public bool IsLimitTimeRewardOn()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return serverTime >= (double)this.LimitTimeRewardOpenTime && serverTime <= (double)this.LimitTimeRewardEndTime;
		}

		// Token: 0x0602FB4A RID: 195402 RVA: 0x00D4F1B8 File Offset: 0x00D4D3B8
		public bool CheckHasLimitTimeReward()
		{
			if (!this.IsLimitTimeRewardOn())
			{
				return false;
			}
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, 0, 0) == 0)
			{
				return true;
			}
			using (Dictionary<int, DreamLinkRewardData>.ValueCollection.Enumerator enumerator = this.LimitTimeRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602FB4B RID: 195403 RVA: 0x00D4F23C File Offset: 0x00D4D43C
		public bool CheckHasLimitTimeTabReward(int tabId)
		{
			if (!this.IsLimitTimeRewardOn())
			{
				return false;
			}
			List<DreamLinkRewardData> list;
			if (this.LimitTimeTypeRewardMap.TryGetValue((EDreamLinkRewardType)tabId, out list))
			{
				using (List<DreamLinkRewardData>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Status == EActivityTaskState.FinishedAndUnclaimed)
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0602FB4C RID: 195404 RVA: 0x00D4F2AC File Offset: 0x00D4D4AC
		public Tuple<string, string> GetTypeInfoByTabId(int tabId)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			string text;
			string item = activityConfig.TabText().TryGetValue(tabId, out text) ? text : "";
			string text2;
			string item2 = activityConfig.TabIcon().TryGetValue(tabId, out text2) ? text2 : "";
			return Tuple.Create<string, string>(item, item2);
		}

		// Token: 0x0602FB4D RID: 195405 RVA: 0x00D4F2FC File Offset: 0x00D4D4FC
		public List<DreamLinkRewardData> GetLimitTimeRewardListByTabId(int tabId)
		{
			List<DreamLinkRewardData> list;
			if (!this.LimitTimeTypeRewardMap.TryGetValue((EDreamLinkRewardType)tabId, out list))
			{
				return new List<DreamLinkRewardData>();
			}
			list.Sort(new Comparison<DreamLinkRewardData>(this.SortTargetData));
			return list;
		}

		// Token: 0x0602FB4E RID: 195406 RVA: 0x00D4F334 File Offset: 0x00D4D534
		public int GetPreviewWeaponId()
		{
			return this.GetActivityConfig().WeaponPreviewId;
		}

		// Token: 0x04019510 RID: 103696
		public List<RogueRoleInstData> RoleInstanceList = new List<RogueRoleInstData>();

		// Token: 0x04019511 RID: 103697
		public Dictionary<int, DreamLinkRunTaskData> RunTaskMap = new Dictionary<int, DreamLinkRunTaskData>();

		// Token: 0x04019512 RID: 103698
		public int MaxEnergy;

		// Token: 0x04019513 RID: 103699
		private long LimitTimeRewardOpenTime;

		// Token: 0x04019514 RID: 103700
		private long LimitTimeRewardEndTime;

		// Token: 0x04019515 RID: 103701
		private List<int> UnlockMainFunction = new List<int>();

		// Token: 0x04019516 RID: 103702
		private readonly Dictionary<int, DreamLinkRewardData> EnergyRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x04019517 RID: 103703
		private readonly Dictionary<int, DreamLinkRewardData> LimitTimeRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x04019518 RID: 103704
		private readonly Dictionary<int, DreamLinkRewardData> BossRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x04019519 RID: 103705
		private readonly Dictionary<int, List<DreamLinkRewardData>> BossTypeRewardMap = new Dictionary<int, List<DreamLinkRewardData>>();

		// Token: 0x0401951A RID: 103706
		private readonly Dictionary<EDreamLinkRewardType, List<DreamLinkRewardData>> LimitTimeTypeRewardMap = new Dictionary<EDreamLinkRewardType, List<DreamLinkRewardData>>();

		// Token: 0x0401951B RID: 103707
		private readonly Dictionary<int, DreamLinkBossInstanceData> BossInstDataMap = new Dictionary<int, DreamLinkBossInstanceData>();

		// Token: 0x0401951C RID: 103708
		public int DungeonProgressRecord;
	}
}
