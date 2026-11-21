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
	// Token: 0x0200530D RID: 21261
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MultiMotorController : ActivityControllerBase
	{
		// Token: 0x06034E4A RID: 216650 RVA: 0x00ECA03C File Offset: 0x00EC823C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.OnlineMotorSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorSettleNotify));
			Net.Instance.Register(ENotifyMessageId.MotorOnlineRankSnapshotNotify, new Action<IMessage, Net.CallbackStatus>(this.MotorOnlineRankSnapshotNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorStartNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorStartNotify));
			Net.Instance.Register(ENotifyMessageId.OnlineMotorEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnlineMotorEndNotify));
			Net.Instance.Register(ENotifyMessageId.MotorOnlineRankRuleIdsNotify, new Action<IMessage, Net.CallbackStatus>(this.MotorOnlineRankRuleIdsNotify));
		}

		// Token: 0x06034E4B RID: 216651 RVA: 0x00ECA0F4 File Offset: 0x00EC82F4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorSettleNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorOnlineRankSnapshotNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorStartNotify);
			Net.Instance.UnRegister(ENotifyMessageId.OnlineMotorEndNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MotorOnlineRankRuleIdsNotify);
		}

		// Token: 0x06034E4C RID: 216652 RVA: 0x00ECA161 File Offset: 0x00EC8361
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06034E4D RID: 216653 RVA: 0x00ECA17F File Offset: 0x00EC837F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06034E4E RID: 216654 RVA: 0x00ECA19D File Offset: 0x00EC839D
		public void OnMultiMotorDataInit()
		{
			if (!this.IsPendingWorldDoneHandle)
			{
				return;
			}
			this.IsPendingWorldDoneHandle = false;
			this.OnWorldDone();
		}

		// Token: 0x06034E4F RID: 216655 RVA: 0x00ECA1B5 File Offset: 0x00EC83B5
		public void OnMultiMotorMainViewOpened()
		{
			if (!this.HasPendingStartNotify)
			{
				return;
			}
			this.HasPendingStartNotify = false;
			EventSystem.Instance.Emit(EEventName.MultiMotorStart);
		}

		// Token: 0x06034E50 RID: 216656 RVA: 0x00ECA1D8 File Offset: 0x00EC83D8
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

		// Token: 0x06034E51 RID: 216657 RVA: 0x00ECA270 File Offset: 0x00EC8470
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

		// Token: 0x06034E52 RID: 216658 RVA: 0x00ECA2B4 File Offset: 0x00EC84B4
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

		// Token: 0x06034E53 RID: 216659 RVA: 0x00ECA304 File Offset: 0x00EC8504
		private MultiMotorData GetActivityDataById(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as MultiMotorData;
		}

		// Token: 0x06034E54 RID: 216660 RVA: 0x00ECA318 File Offset: 0x00EC8518
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

		// Token: 0x06034E55 RID: 216661 RVA: 0x00ECA364 File Offset: 0x00EC8564
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

		// Token: 0x06034E56 RID: 216662 RVA: 0x00ECA3E4 File Offset: 0x00EC85E4
		public void MotorOnlineProgressReportPush(int instId, float progress)
		{
			MotorOnlineProgressReportPush motorOnlineProgressReportPush = Aki.Protocol.MotorOnlineProgressReportPush.Create();
			motorOnlineProgressReportPush.InstId = instId;
			motorOnlineProgressReportPush.Progress = (int)progress;
			Net.Instance.Send(EPushMessageId.MotorOnlineProgressReportPush, motorOnlineProgressReportPush);
		}

		// Token: 0x06034E57 RID: 216663 RVA: 0x00ECA418 File Offset: 0x00EC8618
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(onlineMotorActivityLevelResponse.ErrorCode, 18856, null, true, true);
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

		// Token: 0x06034E58 RID: 216664 RVA: 0x00ECA5A0 File Offset: 0x00EC87A0
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

		// Token: 0x06034E59 RID: 216665 RVA: 0x00ECA7B0 File Offset: 0x00EC89B0
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

		// Token: 0x06034E5A RID: 216666 RVA: 0x00ECA808 File Offset: 0x00EC8A08
		[NullableContext(2)]
		private void OnlineMotorEndNotify(IMessage msg, Net.CallbackStatus status)
		{
			OnlineMotorEndNotify onlineMotorEndNotify = (OnlineMotorEndNotify)msg;
			EventSystem.Instance.Emit<int>(EEventName.MultiMotorPassLine, onlineMotorEndNotify.PlayerId);
		}

		// Token: 0x06034E5B RID: 216667 RVA: 0x00ECA834 File Offset: 0x00EC8A34
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

		// Token: 0x06034E5C RID: 216668 RVA: 0x00ECA8CC File Offset: 0x00EC8ACC
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06034E5D RID: 216669 RVA: 0x00ECA8CE File Offset: 0x00EC8ACE
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivityMotorRace";
		}

		// Token: 0x06034E5E RID: 216670 RVA: 0x00ECA8D5 File Offset: 0x00EC8AD5
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MultiMotorSubView();
		}

		// Token: 0x06034E5F RID: 216671 RVA: 0x00ECA8DC File Offset: 0x00EC8ADC
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			MultiMotorModel.Instance.ActivityId = data.Id;
			return new MultiMotorData();
		}

		// Token: 0x06034E60 RID: 216672 RVA: 0x00ECA8F3 File Offset: 0x00EC8AF3
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x06034E61 RID: 216673 RVA: 0x00ECA8F6 File Offset: 0x00EC8AF6
		public static MultiMotorController Instance
		{
			get
			{
				return MultiMotorController._Instance;
			}
		}

		// Token: 0x06034E62 RID: 216674 RVA: 0x00ECA8FD File Offset: 0x00EC8AFD
		public static MultiMotorController GetOrCreateInstance()
		{
			if (MultiMotorController._Instance == null)
			{
				MultiMotorController.CreateInstance();
			}
			return MultiMotorController._Instance;
		}

		// Token: 0x06034E63 RID: 216675 RVA: 0x00ECA911 File Offset: 0x00EC8B11
		public static bool CreateInstance()
		{
			if (MultiMotorController._Instance != null)
			{
				return true;
			}
			MultiMotorController._Instance = new MultiMotorController();
			return true;
		}

		// Token: 0x06034E64 RID: 216676 RVA: 0x00ECA927 File Offset: 0x00EC8B27
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034E65 RID: 216677 RVA: 0x00ECA929 File Offset: 0x00EC8B29
		public static void ResetStaticDefaultValue()
		{
			MultiMotorController._Instance = null;
		}

		// Token: 0x06034E66 RID: 216678 RVA: 0x00ECA931 File Offset: 0x00EC8B31
		static MultiMotorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorController.CreateStaticDefaultValue), new Action(MultiMotorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF82 RID: 114562
		private bool IsPendingWorldDoneHandle;

		// Token: 0x0401BF83 RID: 114563
		private bool HasPendingStartNotify;

		// Token: 0x0401BF84 RID: 114564
		[Nullable(2)]
		private static MultiMotorController _Instance;
	}
}
