using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200638F RID: 25487
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MultiMotorController : ActivityControllerBase
	{
		// Token: 0x06040189 RID: 262537 RVA: 0x00F830C8 File Offset: 0x00F812C8
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.OnlineMotorSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorSettleNotify));
			Net.Instance.Register(ENotifyMessageId.MotorOnlineRankSnapshotNotify, new Action<IMessage, Net.CallbackStatus>(this.MotorOnlineRankSnapshotNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorStartNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorStartNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorEndNotify));
			Net.Instance.Register(ENotifyMessageId.MotorOnlineRankRuleIdsNotify, new Action<IMessage, Net.CallbackStatus>(this.MotorOnlineRankRuleIdsNotify));
		}

		// Token: 0x0604018A RID: 262538 RVA: 0x00F83180 File Offset: 0x00F81380
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorOnlineRankSnapshotNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorStartNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorEndNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorOnlineRankRuleIdsNotify);
		}

		// Token: 0x0604018B RID: 262539 RVA: 0x00F831ED File Offset: 0x00F813ED
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0604018C RID: 262540 RVA: 0x00F8320B File Offset: 0x00F8140B
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0604018D RID: 262541 RVA: 0x00F83229 File Offset: 0x00F81429
		public void OnMultiMotorDataInit()
		{
			if (!this.IsPendingWorldDoneHandle)
			{
				return;
			}
			this.IsPendingWorldDoneHandle = false;
			this.OnWorldDone();
		}

		// Token: 0x0604018E RID: 262542 RVA: 0x00F83241 File Offset: 0x00F81441
		public void OnMultiMotorMainViewOpened()
		{
			if (!this.HasPendingStartNotify)
			{
				return;
			}
			this.HasPendingStartNotify = false;
			EventSystem.Instance.Emit(EEventName.MultiMotorStart);
		}

		// Token: 0x0604018F RID: 262543 RVA: 0x00F83264 File Offset: 0x00F81464
		private void OnWorldDone()
		{
			if (this.CheckInMultiMotorParkourDungeon())
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.MultiMotorMainView))
				{
					return;
				}
				int instanceId = CreatureModel.Instance.GetInstanceId();
				OnlineMotorLevel? motorMultiParkourLevelByInstId = MultiMotorConfig.Instance.GetMotorMultiParkourLevelByInstId(instanceId);
				MultiMotorData activityDataById = this.GetActivityDataById(motorMultiParkourLevelByInstId.Value.ActivityId);
				if (activityDataById == null)
				{
					this.IsPendingWorldDoneHandle = true;
					return;
				}
				activityDataById.InitLevelRankData();
				MultiMotorLevelData param;
				activityDataById.LevelDataMap.TryGetValue(motorMultiParkourLevelByInstId.Value.Id, out param);
				UiManager.Instance.OpenView(EUiViewName.MultiMotorMainView, param, null);
			}
		}

		// Token: 0x06040190 RID: 262544 RVA: 0x00F832FC File Offset: 0x00F814FC
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			MultiMotorController.<OnOpenSubView>d__9 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<MultiMotorController.<OnOpenSubView>d__9>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06040191 RID: 262545 RVA: 0x00F83340 File Offset: 0x00F81540
		public bool CheckInMultiMotorParkourDungeon()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
				return config != null && config.GetValueOrDefault().InstSubType == 57;
			}
			return false;
		}

		// Token: 0x06040192 RID: 262546 RVA: 0x00F83390 File Offset: 0x00F81590
		private MultiMotorData GetActivityDataById(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as MultiMotorData;
		}

		// Token: 0x06040193 RID: 262547 RVA: 0x00F833A4 File Offset: 0x00F815A4
		[NullableContext(2)]
		private void OnlineMotorSettleNotify(IMessage msg, Net.CallbackStatus status)
		{
			RepeatedField<OnlineMotorSettleInfo> settleInfos = ((OnlineMotorSettleNotify)msg).SettleInfos;
			UiManager.Instance.OpenView(EUiViewName.MultiMotorSettlementView, settleInfos, null);
			if (UiManager.Instance.IsViewShow(EUiViewName.MultiMotorMainView))
			{
				UiManager.Instance.CloseView(EUiViewName.MultiMotorMainView, null);
			}
		}

		// Token: 0x06040194 RID: 262548 RVA: 0x00F833F0 File Offset: 0x00F815F0
		[NullableContext(2)]
		private void MotorOnlineRankSnapshotNotify(IMessage msg, Net.CallbackStatus status)
		{
			MotorOnlineRankSnapshotNotify motorOnlineRankSnapshotNotify = (MotorOnlineRankSnapshotNotify)msg;
			MultiMotorData activityData = MultiMotorModel.Instance.ActivityData;
			foreach (MotorOnlineRankPlayerInfo motorOnlineRankPlayerInfo in motorOnlineRankSnapshotNotify.MotorOnlinePlayerInfoList)
			{
				if (activityData != null)
				{
					activityData.LevelBattleRankMap[motorOnlineRankPlayerInfo.PlayerId] = motorOnlineRankPlayerInfo.Rank;
				}
			}
			EventSystem.Instance.Emit(EEventName.MultiMotorRankInfoRefresh);
		}

		// Token: 0x06040195 RID: 262549 RVA: 0x00F83470 File Offset: 0x00F81670
		public void MotorOnlineProgressReportPush(int instId, float progress)
		{
			MotorOnlineProgressReportPush motorOnlineProgressReportPush = Aki.Protocol.MotorOnlineProgressReportPush.Create();
			motorOnlineProgressReportPush.InstId = instId;
			motorOnlineProgressReportPush.Progress = (int)progress;
			Net.Instance.Send(EPushMessageId.MotorOnlineProgressReportPush, motorOnlineProgressReportPush);
		}

		// Token: 0x06040196 RID: 262550 RVA: 0x00F834A4 File Offset: 0x00F816A4
		public void MotorOnlineRewardRequest(int levelId)
		{
			bool isGlobalTask = levelId < 0;
			MultiMotorData activityData = isGlobalTask ? MultiMotorModel.Instance.ActivityData : this.GetActivityDataById(MultiMotorConfig.Instance.GetMotorMultiParkourLevelById(levelId).Value.ActivityId);
			if (activityData == null)
			{
				Log.Instance.Error(ELogModule.MotorParkour, ELogAuthor.LJQ, "联机摩托跑酷活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			OnlineMotorActivityLevelRequest onlineMotorActivityLevelRequest = OnlineMotorActivityLevelRequest.Create();
			List<int> taskList = new List<int>();
			foreach (KeyValuePair<int, MultiMotorTaskData> keyValuePair in activityData.TaskDataMap)
			{
				MultiMotorTaskData value = keyValuePair.Value;
				if (isGlobalTask && value.IsGlobalTask && value.IsFinished)
				{
					taskList.Add(-keyValuePair.Key);
				}
				else if (!isGlobalTask && !value.IsGlobalTask && value.LevelId == levelId && value.IsFinished)
				{
					taskList.Add(keyValuePair.Key);
				}
			}
			onlineMotorActivityLevelRequest.RewardIds.AddRange(taskList);
			onlineMotorActivityLevelRequest.RewardType = (isGlobalTask ? OnlineMotorRewardType.GlobalReward : OnlineMotorRewardType.LevelReward);
			Net.Instance.Call(ERequestMessageId.OnlineMotorActivityLevelRequest, onlineMotorActivityLevelRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				OnlineMotorActivityLevelResponse onlineMotorActivityLevelResponse = (OnlineMotorActivityLevelResponse)msg;
				if (onlineMotorActivityLevelResponse == null)
				{
					return;
				}
				if (onlineMotorActivityLevelResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(onlineMotorActivityLevelResponse.ErrorCode, 22472, null, true, true);
					return;
				}
				foreach (int num in taskList)
				{
					int key = isGlobalTask ? (-num) : num;
					MultiMotorTaskData multiMotorTaskData;
					if (activityData.TaskDataMap.TryGetValue(key, out multiMotorTaskData))
					{
						multiMotorTaskData.RefreshState(EActivityTaskState.FinishedAndClaimed);
					}
				}
				EventSystem.Instance.Emit(EEventName.MultiMotorRefresh);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}, 0);
		}

		// Token: 0x06040197 RID: 262551 RVA: 0x00F8362C File Offset: 0x00F8182C
		[NullableContext(2)]
		private void OnlineMotorUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			OnlineMotorUpdateNotify onlineMotorUpdateNotify = (OnlineMotorUpdateNotify)msg;
			MultiMotorModel instance = MultiMotorModel.Instance;
			MultiMotorData multiMotorData = (instance != null) ? instance.ActivityData : null;
			if (multiMotorData == null)
			{
				Log.Instance.Error(ELogModule.MotorParkour, ELogAuthor.LJQ, "联机摩托跑酷活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (onlineMotorUpdateNotify.LevelInfo != null)
			{
				OnlineMotorLevelInfo levelInfo = onlineMotorUpdateNotify.LevelInfo;
				MultiMotorLevelData multiMotorLevelData;
				if (!multiMotorData.LevelDataMap.TryGetValue(levelInfo.LevelId, out multiMotorLevelData))
				{
					MultiMotorLevelData multiMotorLevelData2 = new MultiMotorLevelData(levelInfo.LevelId);
					multiMotorLevelData2.RefreshByLevelInfo(levelInfo);
					multiMotorData.LevelDataMap[levelInfo.LevelId] = multiMotorLevelData2;
				}
				else
				{
					multiMotorLevelData.RefreshByLevelInfo(levelInfo);
				}
			}
			if (onlineMotorUpdateNotify.ActivityTasks != null)
			{
				foreach (OnlineMotorTask onlineMotorTask in onlineMotorUpdateNotify.ActivityTasks.GlobalTasks)
				{
					MultiMotorTaskData multiMotorTaskData;
					if (!multiMotorData.TaskDataMap.TryGetValue(-onlineMotorTask.TaskId, out multiMotorTaskData))
					{
						MultiMotorTaskData multiMotorTaskData2 = new MultiMotorTaskData(-onlineMotorTask.TaskId);
						multiMotorTaskData2.LevelId = -1;
						multiMotorData.TaskDataMap[-onlineMotorTask.TaskId] = multiMotorTaskData2;
					}
					else
					{
						multiMotorTaskData.RefreshByTaskInfo(onlineMotorTask);
					}
				}
				foreach (OnlineMotorTask onlineMotorTask2 in onlineMotorUpdateNotify.ActivityTasks.LevelTasks)
				{
					MultiMotorTaskData multiMotorTaskData3;
					if (!multiMotorData.TaskDataMap.TryGetValue(onlineMotorTask2.TaskId, out multiMotorTaskData3))
					{
						MultiMotorTaskData multiMotorTaskData4 = new MultiMotorTaskData(onlineMotorTask2.TaskId);
						OnlineMotorLevelTask? motorLevelTaskByTaskId = MultiMotorConfig.Instance.GetMotorLevelTaskByTaskId(onlineMotorTask2.TaskId);
						multiMotorTaskData4.LevelId = ((motorLevelTaskByTaskId != null) ? motorLevelTaskByTaskId.GetValueOrDefault().LevelId : 0);
						multiMotorData.TaskDataMap[onlineMotorTask2.TaskId] = multiMotorTaskData4;
					}
					else
					{
						multiMotorTaskData3.RefreshByTaskInfo(onlineMotorTask2);
					}
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, multiMotorData.Id);
		}

		// Token: 0x06040198 RID: 262552 RVA: 0x00F8383C File Offset: 0x00F81A3C
		[NullableContext(2)]
		private void OnlineMotorStartNotify(IMessage msg, Net.CallbackStatus status)
		{
			OnlineMotorStartNotify onlineMotorStartNotify = (OnlineMotorStartNotify)msg;
			MultiMotorModel.Instance.StartFlowTime = MathUtils.Instance.LongToBigInt(onlineMotorStartNotify.BeginTime);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.MultiMotorMainView))
			{
				this.HasPendingStartNotify = true;
				return;
			}
			EventSystem.Instance.Emit(EEventName.MultiMotorStart);
		}

		// Token: 0x06040199 RID: 262553 RVA: 0x00F83894 File Offset: 0x00F81A94
		[NullableContext(2)]
		private void OnlineMotorEndNotify(IMessage msg, Net.CallbackStatus status)
		{
			OnlineMotorEndNotify onlineMotorEndNotify = (OnlineMotorEndNotify)msg;
			EventSystem.Instance.Emit<int>(EEventName.MultiMotorPassLine, onlineMotorEndNotify.PlayerId);
		}

		// Token: 0x0604019A RID: 262554 RVA: 0x00F838C0 File Offset: 0x00F81AC0
		[NullableContext(2)]
		private void MotorOnlineRankRuleIdsNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (MotorOnlineParkPlayerRuleInfo motorOnlineParkPlayerRuleInfo in ((MotorOnlineRankRuleIdsNotify)msg).MotorOnlinePlayerInfoList)
			{
				foreach (int p in motorOnlineParkPlayerRuleInfo.RuleIds)
				{
					EventSystem.Instance.Emit<int, int>(EEventName.MultiMotorBuffRefresh, motorOnlineParkPlayerRuleInfo.PlayerId, p);
				}
			}
		}

		// Token: 0x0604019B RID: 262555 RVA: 0x00F83958 File Offset: 0x00F81B58
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0604019C RID: 262556 RVA: 0x00F8395A File Offset: 0x00F81B5A
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivityMotorRace";
		}

		// Token: 0x0604019D RID: 262557 RVA: 0x00F83961 File Offset: 0x00F81B61
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MultiMotorSubView();
		}

		// Token: 0x0604019E RID: 262558 RVA: 0x00F83968 File Offset: 0x00F81B68
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MultiMotorModel.Instance.ActivityId = data.Id;
			return new MultiMotorData();
		}

		// Token: 0x0604019F RID: 262559 RVA: 0x00F8397F File Offset: 0x00F81B7F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17009354 RID: 37716
		// (get) Token: 0x060401A0 RID: 262560 RVA: 0x00F83982 File Offset: 0x00F81B82
		public static MultiMotorController Instance
		{
			get
			{
				return MultiMotorController._Instance;
			}
		}

		// Token: 0x060401A1 RID: 262561 RVA: 0x00F83989 File Offset: 0x00F81B89
		public static MultiMotorController GetOrCreateInstance()
		{
			if (MultiMotorController._Instance == null)
			{
				MultiMotorController.CreateInstance();
			}
			return MultiMotorController._Instance;
		}

		// Token: 0x060401A2 RID: 262562 RVA: 0x00F8399D File Offset: 0x00F81B9D
		public static bool CreateInstance()
		{
			if (MultiMotorController._Instance != null)
			{
				return true;
			}
			MultiMotorController._Instance = new MultiMotorController();
			return true;
		}

		// Token: 0x060401A3 RID: 262563 RVA: 0x00F839B3 File Offset: 0x00F81BB3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060401A4 RID: 262564 RVA: 0x00F839B5 File Offset: 0x00F81BB5
		public static void ResetStaticDefaultValue()
		{
			MultiMotorController._Instance = null;
		}

		// Token: 0x060401A5 RID: 262565 RVA: 0x00F839BD File Offset: 0x00F81BBD
		static MultiMotorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorController.CreateStaticDefaultValue), new Action(MultiMotorController.ResetStaticDefaultValue));
		}

		// Token: 0x04021653 RID: 136787
		private bool IsPendingWorldDoneHandle;

		// Token: 0x04021654 RID: 136788
		private bool HasPendingStartNotify;

		// Token: 0x04021655 RID: 136789
		[Nullable(2)]
		private static MultiMotorController _Instance;
	}
}
