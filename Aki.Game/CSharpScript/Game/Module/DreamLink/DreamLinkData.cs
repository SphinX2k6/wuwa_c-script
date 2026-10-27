using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A92 RID: 23186
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkData : ActivityBaseData
	{
		// Token: 0x0603ABBA RID: 240570 RVA: 0x00DFD43C File Offset: 0x00DFB63C
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

		// Token: 0x0603ABBB RID: 240571 RVA: 0x00DFD459 File Offset: 0x00DFB659
		protected override void PhraseEx(ActivityData data)
		{
			this.RefreshDreamLinkData(data.RogueWhiteCatData);
		}

		// Token: 0x0603ABBC RID: 240572 RVA: 0x00DFD467 File Offset: 0x00DFB667
		public void UpdateData(RogueWhiteCatDataUpdateNotify data)
		{
			this.RefreshDreamLinkData(data.RogueWhiteCatData);
		}

		// Token: 0x0603ABBD RID: 240573 RVA: 0x00DFD478 File Offset: 0x00DFB678
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

		// Token: 0x0603ABBE RID: 240574 RVA: 0x00DFD56C File Offset: 0x00DFB76C
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

		// Token: 0x0603ABBF RID: 240575 RVA: 0x00DFD5F5 File Offset: 0x00DFB7F5
		public override bool GetExternalButtonRedPointState()
		{
			if (!this.IsDreamLinkFunctionUnlock(0))
			{
				return this.GetQuestRedDotState();
			}
			return this.RedPointShowState;
		}

		// Token: 0x0603ABC0 RID: 240576 RVA: 0x00DFD610 File Offset: 0x00DFB810
		[NullableContext(2)]
		private void RefreshDreamLinkData(RogueWhiteCatData data)
		{
			if (data == null)
			{
				return;
			}
			this.MaxEnergy = data.MaxEnergy;
			this.RoleInstanceList = data.RogueRoleInstData.ToList<RogueRoleInstData>();
			this.LimitTimeRewardOpenTime = data.LimitedStartTime;
			this.LimitTimeRewardEndTime = data.LimitedEndTime;
			this.DungeonProgressRecord = data.Record;
			this.RefreshEnergyDataState(data.SignStateList.ToList<SignState>());
			this.RefreshBossRewardState(data.BossRewardStateList.ToList<SignState>());
			this.RefreshAllLimitTimeReward(data.RogueLimitedAwards.ToList<RogueLimitedAward>());
			this.UnlockMainFunction = data.UnlockButtons.ToList<int>();
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

		// Token: 0x0603ABC1 RID: 240577 RVA: 0x00DFD7E4 File Offset: 0x00DFB9E4
		public void RefreshActivityRedDotState()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603ABC2 RID: 240578 RVA: 0x00DFD7FC File Offset: 0x00DFB9FC
		public void RefreshRewardPerformance()
		{
			EventSystem.Instance.Emit(EEventName.DreamLinkRewardRefresh);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
			{
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, this.GetBossRewardData());
			}
		}

		// Token: 0x0603ABC3 RID: 240579 RVA: 0x00DFD856 File Offset: 0x00DFBA56
		public void RefreshLimitRewardPerformance()
		{
			if (this.IsLimitTimeRewardOn())
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				EventSystem.Instance.Emit(EEventName.DreamLinkLimitRewardRefresh);
			}
		}

		// Token: 0x0603ABC4 RID: 240580 RVA: 0x00DFD888 File Offset: 0x00DFBA88
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

		// Token: 0x0603ABC5 RID: 240581 RVA: 0x00DFD8C8 File Offset: 0x00DFBAC8
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

		// Token: 0x0603ABC6 RID: 240582 RVA: 0x00DFD908 File Offset: 0x00DFBB08
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

		// Token: 0x0603ABC7 RID: 240583 RVA: 0x00DFD948 File Offset: 0x00DFBB48
		public List<RogueRoleInstData> GetInstListByPages(int page, int pageSize)
		{
			int num = page * pageSize;
			int num2 = num + pageSize;
			return this.RoleInstanceList.GetRange(num, Math.Min(num2 - num, this.RoleInstanceList.Count - num));
		}

		// Token: 0x0603ABC8 RID: 240584 RVA: 0x00DFD980 File Offset: 0x00DFBB80
		public int GetRoleInstDataIndex(int instId)
		{
			return this.RoleInstanceList.FindIndex((RogueRoleInstData roleInst) => roleInst.InstId == instId);
		}

		// Token: 0x0603ABC9 RID: 240585 RVA: 0x00DFD9B1 File Offset: 0x00DFBBB1
		[NullableContext(2)]
		public RogueRoleInstData GetRoleInstDataByIndex(int index)
		{
			if (index < 0 || index >= this.RoleInstanceList.Count)
			{
				return null;
			}
			return this.RoleInstanceList[index];
		}

		// Token: 0x0603ABCA RID: 240586 RVA: 0x00DFD9D4 File Offset: 0x00DFBBD4
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

		// Token: 0x0603ABCB RID: 240587 RVA: 0x00DFDA60 File Offset: 0x00DFBC60
		public RogueWhiteCat GetActivityConfig()
		{
			return DreamLinkConfig.Instance.GetActivityConfig(base.Id).Value;
		}

		// Token: 0x0603ABCC RID: 240588 RVA: 0x00DFDA88 File Offset: 0x00DFBC88
		public bool IsDreamLinkInst(int id)
		{
			return this.RoleInstanceList.FindIndex((RogueRoleInstData roleInst) => roleInst.InstId == id) != -1;
		}

		// Token: 0x0603ABCD RID: 240589 RVA: 0x00DFDABF File Offset: 0x00DFBCBF
		public bool IsDreamLinkFunctionUnlock(int id)
		{
			return this.UnlockMainFunction.Contains(id);
		}

		// Token: 0x0603ABCE RID: 240590 RVA: 0x00DFDAD0 File Offset: 0x00DFBCD0
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

		// Token: 0x0603ABCF RID: 240591 RVA: 0x00DFDB2C File Offset: 0x00DFBD2C
		public bool IsAllInstFinished()
		{
			return this.GetFinishInstCount() == this.RoleInstanceList.Count;
		}

		// Token: 0x0603ABD0 RID: 240592 RVA: 0x00DFDB41 File Offset: 0x00DFBD41
		public EDreamLinkStage GetInstStage()
		{
			if (this.GetFinishInstCount() >= 3)
			{
				return EDreamLinkStage.Second;
			}
			return EDreamLinkStage.First;
		}

		// Token: 0x0603ABD1 RID: 240593 RVA: 0x00DFDB50 File Offset: 0x00DFBD50
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

		// Token: 0x0603ABD2 RID: 240594 RVA: 0x00DFDC00 File Offset: 0x00DFBE00
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

		// Token: 0x0603ABD3 RID: 240595 RVA: 0x00DFDC6C File Offset: 0x00DFBE6C
		public void SaveDungeonRedDotStateByInstId(int instId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			ActivityModel.Instance.SaveActivityData(base.Id, 2, instId, 0, (int)serverTime);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0603ABD4 RID: 240596 RVA: 0x00DFDCA0 File Offset: 0x00DFBEA0
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

		// Token: 0x0603ABD5 RID: 240597 RVA: 0x00DFDCF8 File Offset: 0x00DFBEF8
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

		// Token: 0x0603ABD6 RID: 240598 RVA: 0x00DFDD5C File Offset: 0x00DFBF5C
		public bool GetQuestRedDotState()
		{
			int unFinishPreGuideQuestId = base.GetUnFinishPreGuideQuestId();
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 6, unFinishPreGuideQuestId, 0) == 0;
		}

		// Token: 0x0603ABD7 RID: 240599 RVA: 0x00DFDD88 File Offset: 0x00DFBF88
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

		// Token: 0x0603ABD8 RID: 240600 RVA: 0x00DFDDBF File Offset: 0x00DFBFBF
		public void SaveFirstCheckRedDotState(int functionId, int id = 0)
		{
			ActivityModel.Instance.SaveActivityData(base.Id, functionId, id, 0, 1);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0603ABD9 RID: 240601 RVA: 0x00DFDDDC File Offset: 0x00DFBFDC
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

		// Token: 0x0603ABDA RID: 240602 RVA: 0x00DFDE60 File Offset: 0x00DFC060
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

		// Token: 0x0603ABDB RID: 240603 RVA: 0x00DFDED8 File Offset: 0x00DFC0D8
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

		// Token: 0x0603ABDC RID: 240604 RVA: 0x00DFDF1F File Offset: 0x00DFC11F
		public List<DreamLinkBossInstanceData> GetAllBossInstData()
		{
			return (from a in this.BossInstDataMap.Values
			orderby a.TypeId
			select a).ToList<DreamLinkBossInstanceData>();
		}

		// Token: 0x0603ABDD RID: 240605 RVA: 0x00DFDF58 File Offset: 0x00DFC158
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

		// Token: 0x0603ABDE RID: 240606 RVA: 0x00DFDFBB File Offset: 0x00DFC1BB
		public int GetBossRoleId(int instId, int index)
		{
			return this.BossInstDataMap[instId].GetBossRoleIdByIndex(index);
		}

		// Token: 0x0603ABDF RID: 240607 RVA: 0x00DFDFCF File Offset: 0x00DFC1CF
		public void SetBossRoleId(int instId, int index, int roleId)
		{
			this.BossInstDataMap[instId].SetBossRoleIdByIndex(index, roleId);
			ActivityModel.Instance.SaveActivityData(base.Id, instId, index, 0, roleId);
		}

		// Token: 0x0603ABE0 RID: 240608 RVA: 0x00DFDFF8 File Offset: 0x00DFC1F8
		public List<int> GetAllBossRoleId(int instId)
		{
			return this.BossInstDataMap[instId].GetBossRoleIdList().ToList<int>();
		}

		// Token: 0x0603ABE1 RID: 240609 RVA: 0x00DFE010 File Offset: 0x00DFC210
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

		// Token: 0x0603ABE2 RID: 240610 RVA: 0x00DFE08C File Offset: 0x00DFC28C
		public bool GetBossInstRedDotState(int instId)
		{
			return this.BossInstDataMap[instId].IsUnlock && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, instId, 0) == 0;
		}

		// Token: 0x0603ABE3 RID: 240611 RVA: 0x00DFE0BA File Offset: 0x00DFC2BA
		public void SaveBossInstRedDotState(int instId)
		{
			if (!this.BossInstDataMap[instId].IsUnlock)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 3, instId, 0, 1);
			this.RefreshActivityRedDotState();
		}

		// Token: 0x0603ABE4 RID: 240612 RVA: 0x00DFE0EA File Offset: 0x00DFC2EA
		public void SetRunTaskDone(int id)
		{
			this.RunTaskMap[id].Status = EDreamLinkRunTaskState.FinishedAndClaimed;
		}

		// Token: 0x0603ABE5 RID: 240613 RVA: 0x00DFE0FE File Offset: 0x00DFC2FE
		public List<DreamLinkRunTaskData> GetDreamLinkRunTaskDataList()
		{
			return (from a in this.RunTaskMap.Values
			orderby a.Id
			select a).ToList<DreamLinkRunTaskData>();
		}

		// Token: 0x0603ABE6 RID: 240614 RVA: 0x00DFE134 File Offset: 0x00DFC334
		public bool IsDreamLinkRunMarkShow(int markId)
		{
			DreamLinkWorldRun? worldRunConfigByMarkId = DreamLinkConfig.Instance.GetWorldRunConfigByMarkId(markId);
			DreamLinkRunTaskData dreamLinkRunTaskData;
			return worldRunConfigByMarkId != null && this.RunTaskMap.TryGetValue(worldRunConfigByMarkId.Value.Id, out dreamLinkRunTaskData) && dreamLinkRunTaskData.Status > EDreamLinkRunTaskState.Lock;
		}

		// Token: 0x0603ABE7 RID: 240615 RVA: 0x00DFE184 File Offset: 0x00DFC384
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

		// Token: 0x0603ABE8 RID: 240616 RVA: 0x00DFE20C File Offset: 0x00DFC40C
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

		// Token: 0x0603ABE9 RID: 240617 RVA: 0x00DFE258 File Offset: 0x00DFC458
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

		// Token: 0x0603ABEA RID: 240618 RVA: 0x00DFE2C4 File Offset: 0x00DFC4C4
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

		// Token: 0x0603ABEB RID: 240619 RVA: 0x00DFE38C File Offset: 0x00DFC58C
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

		// Token: 0x0603ABEC RID: 240620 RVA: 0x00DFE414 File Offset: 0x00DFC614
		public int GetEnergyItemId()
		{
			return this.GetActivityConfig().EnergyId;
		}

		// Token: 0x0603ABED RID: 240621 RVA: 0x00DFE42F File Offset: 0x00DFC62F
		public int GetEnergyItemCount()
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.GetEnergyItemId(), 0);
		}

		// Token: 0x0603ABEE RID: 240622 RVA: 0x00DFE442 File Offset: 0x00DFC642
		public List<DreamLinkRewardData> GetEnergyRewardDataList()
		{
			return (from a in this.EnergyRewardMap.Values
			orderby a.Id
			select a).ToList<DreamLinkRewardData>();
		}

		// Token: 0x0603ABEF RID: 240623 RVA: 0x00DFE478 File Offset: 0x00DFC678
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

		// Token: 0x0603ABF0 RID: 240624 RVA: 0x00DFE4F4 File Offset: 0x00DFC6F4
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

		// Token: 0x0603ABF1 RID: 240625 RVA: 0x00DFE570 File Offset: 0x00DFC770
		private void RefreshEnergyDataState(List<SignState> rewardStateList)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			for (int i = 0; i < rewardStateList.Count; i++)
			{
				int id = activityConfig.Rewards(i);
				this.RefreshEnergyRewardData(id, DreamLinkDefine.signStateResolver[rewardStateList[i]]);
			}
		}

		// Token: 0x0603ABF2 RID: 240626 RVA: 0x00DFE5B8 File Offset: 0x00DFC7B8
		public void RefreshEnergyRewardData(int id, EActivityTaskState status)
		{
			DreamLinkRewardData dreamLinkRewardData;
			if (!this.EnergyRewardMap.TryGetValue(id, out dreamLinkRewardData))
			{
				return;
			}
			dreamLinkRewardData.Status = status;
		}

		// Token: 0x0603ABF3 RID: 240627 RVA: 0x00DFE5E0 File Offset: 0x00DFC7E0
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

		// Token: 0x0603ABF4 RID: 240628 RVA: 0x00DFE6A0 File Offset: 0x00DFC8A0
		private void RefreshBossRewardState(List<SignState> rewardStateList)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			for (int i = 0; i < rewardStateList.Count; i++)
			{
				int id = activityConfig.BossRewards(i);
				this.RefreshBossRewardData(id, DreamLinkDefine.signStateResolver[rewardStateList[i]]);
			}
		}

		// Token: 0x0603ABF5 RID: 240629 RVA: 0x00DFE6E8 File Offset: 0x00DFC8E8
		public void RefreshBossRewardData(int id, EActivityTaskState status)
		{
			DreamLinkRewardData dreamLinkRewardData;
			if (!this.BossRewardMap.TryGetValue(id, out dreamLinkRewardData))
			{
				return;
			}
			dreamLinkRewardData.Status = status;
		}

		// Token: 0x0603ABF6 RID: 240630 RVA: 0x00DFE710 File Offset: 0x00DFC910
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

		// Token: 0x0603ABF7 RID: 240631 RVA: 0x00DFE828 File Offset: 0x00DFCA28
		private string GetRewardTabNameByType(int type)
		{
			string text;
			return ConfigMultiTextLang.GetLocalTextNew(this.GetActivityConfig().BossTabText().TryGetValue(type, out text) ? text : "", null) ?? "";
		}

		// Token: 0x0603ABF8 RID: 240632 RVA: 0x00DFE864 File Offset: 0x00DFCA64
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

		// Token: 0x0603ABF9 RID: 240633 RVA: 0x00DFE9A8 File Offset: 0x00DFCBA8
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

		// Token: 0x0603ABFA RID: 240634 RVA: 0x00DFEA14 File Offset: 0x00DFCC14
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

		// Token: 0x0603ABFB RID: 240635 RVA: 0x00DFEA90 File Offset: 0x00DFCC90
		public int GetLimitTimeRewardTypeLength()
		{
			return this.GetActivityConfig().TabTextLength;
		}

		// Token: 0x0603ABFC RID: 240636 RVA: 0x00DFEAAC File Offset: 0x00DFCCAC
		public void RefreshAllLimitTimeReward(List<RogueLimitedAward> data)
		{
			foreach (RogueLimitedAward rogueLimitedAward in data)
			{
				this.RefreshLimitTimeRewardData(rogueLimitedAward.ConfigId, DreamLinkDefine.signStateResolver[rogueLimitedAward.SignState], new int?(rogueLimitedAward.CurProgress), new int?(rogueLimitedAward.MaxProgress));
			}
		}

		// Token: 0x0603ABFD RID: 240637 RVA: 0x00DFEB28 File Offset: 0x00DFCD28
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

		// Token: 0x0603ABFE RID: 240638 RVA: 0x00DFEBDE File Offset: 0x00DFCDDE
		private int SortTargetData(DreamLinkRewardData a, DreamLinkRewardData b)
		{
			if (a.Status == b.Status)
			{
				return a.Id - b.Id;
			}
			return a.Status - b.Status;
		}

		// Token: 0x0603ABFF RID: 240639 RVA: 0x00DFEC09 File Offset: 0x00DFCE09
		public long GetLimitTimeEndTime()
		{
			return this.LimitTimeRewardEndTime;
		}

		// Token: 0x0603AC00 RID: 240640 RVA: 0x00DFEC14 File Offset: 0x00DFCE14
		public bool IsLimitTimeRewardOn()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return serverTime >= (double)this.LimitTimeRewardOpenTime && serverTime <= (double)this.LimitTimeRewardEndTime;
		}

		// Token: 0x0603AC01 RID: 240641 RVA: 0x00DFEC50 File Offset: 0x00DFCE50
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

		// Token: 0x0603AC02 RID: 240642 RVA: 0x00DFECD4 File Offset: 0x00DFCED4
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

		// Token: 0x0603AC03 RID: 240643 RVA: 0x00DFED44 File Offset: 0x00DFCF44
		public Tuple<string, string> GetTypeInfoByTabId(int tabId)
		{
			RogueWhiteCat activityConfig = this.GetActivityConfig();
			string text;
			string item = activityConfig.TabText().TryGetValue(tabId, out text) ? text : "";
			string text2;
			string item2 = activityConfig.TabIcon().TryGetValue(tabId, out text2) ? text2 : "";
			return Tuple.Create<string, string>(item, item2);
		}

		// Token: 0x0603AC04 RID: 240644 RVA: 0x00DFED94 File Offset: 0x00DFCF94
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

		// Token: 0x0603AC05 RID: 240645 RVA: 0x00DFEDCC File Offset: 0x00DFCFCC
		public int GetPreviewWeaponId()
		{
			return this.GetActivityConfig().WeaponPreviewId;
		}

		// Token: 0x0401EA69 RID: 125545
		public List<RogueRoleInstData> RoleInstanceList = new List<RogueRoleInstData>();

		// Token: 0x0401EA6A RID: 125546
		public Dictionary<int, DreamLinkRunTaskData> RunTaskMap = new Dictionary<int, DreamLinkRunTaskData>();

		// Token: 0x0401EA6B RID: 125547
		public int MaxEnergy;

		// Token: 0x0401EA6C RID: 125548
		private long LimitTimeRewardOpenTime;

		// Token: 0x0401EA6D RID: 125549
		private long LimitTimeRewardEndTime;

		// Token: 0x0401EA6E RID: 125550
		private List<int> UnlockMainFunction = new List<int>();

		// Token: 0x0401EA6F RID: 125551
		private readonly Dictionary<int, DreamLinkRewardData> EnergyRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x0401EA70 RID: 125552
		private readonly Dictionary<int, DreamLinkRewardData> LimitTimeRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x0401EA71 RID: 125553
		private readonly Dictionary<int, DreamLinkRewardData> BossRewardMap = new Dictionary<int, DreamLinkRewardData>();

		// Token: 0x0401EA72 RID: 125554
		private readonly Dictionary<int, List<DreamLinkRewardData>> BossTypeRewardMap = new Dictionary<int, List<DreamLinkRewardData>>();

		// Token: 0x0401EA73 RID: 125555
		private readonly Dictionary<EDreamLinkRewardType, List<DreamLinkRewardData>> LimitTimeTypeRewardMap = new Dictionary<EDreamLinkRewardType, List<DreamLinkRewardData>>();

		// Token: 0x0401EA74 RID: 125556
		private readonly Dictionary<int, DreamLinkBossInstanceData> BossInstDataMap = new Dictionary<int, DreamLinkBossInstanceData>();

		// Token: 0x0401EA75 RID: 125557
		public int DungeonProgressRecord;
	}
}
