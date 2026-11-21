using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200517E RID: 20862
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RhythmShipController : ActivityControllerBase
	{
		// Token: 0x0603418C RID: 213388 RVA: 0x00E92A00 File Offset: 0x00E90C00
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603418D RID: 213389 RVA: 0x00E92A02 File Offset: 0x00E90C02
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_RhythmShipActivityMain";
		}

		// Token: 0x0603418E RID: 213390 RVA: 0x00E92A09 File Offset: 0x00E90C09
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new RhythmShipSubView();
		}

		// Token: 0x0603418F RID: 213391 RVA: 0x00E92A10 File Offset: 0x00E90C10
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			RhythmShipModel.Instance.ActivityId = data.Id;
			return new RhythmShipData();
		}

		// Token: 0x06034190 RID: 213392 RVA: 0x00E92A27 File Offset: 0x00E90C27
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06034191 RID: 213393 RVA: 0x00E92A2A File Offset: 0x00E90C2A
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06034192 RID: 213394 RVA: 0x00E92A48 File Offset: 0x00E90C48
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06034193 RID: 213395 RVA: 0x00E92A66 File Offset: 0x00E90C66
		private void OnWorldDone()
		{
			RhythmShipModel.Instance.InitLocalCalibrationValue();
		}

		// Token: 0x06034194 RID: 213396 RVA: 0x00E92A74 File Offset: 0x00E90C74
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RhythmRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmRoleUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmSubLevelUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmSubLevelUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmShipStartNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmShipStartNotify));
		}

		// Token: 0x06034195 RID: 213397 RVA: 0x00E92AF4 File Offset: 0x00E90CF4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RhythmRoleUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmSubLevelUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmShipStartNotify);
		}

		// Token: 0x06034196 RID: 213398 RVA: 0x00E92B44 File Offset: 0x00E90D44
		[NullableContext(2)]
		public void RhythmSetRedDotRequest(List<int> planetId = null, List<int> subLevelId = null, List<int> roleId = null)
		{
			int activityId = 0;
			if (subLevelId != null)
			{
				activityId = RhythmShipModel.Instance.GetSubLevelActivityId(subLevelId[0]);
			}
			else if (planetId != null)
			{
				activityId = RhythmShipModel.Instance.GetPlanetActivityId(planetId[0]);
			}
			else if (roleId != null)
			{
				RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
				activityId = ((activityData != null) ? activityData.Id : 0);
			}
			RhythmSetRedDotRequest rhythmSetRedDotRequest = Aki.Protocol.RhythmSetRedDotRequest.Create();
			rhythmSetRedDotRequest.ActivityId = activityId;
			rhythmSetRedDotRequest.RedDot = RhythmRedDotPb.Create();
			rhythmSetRedDotRequest.RedDot.ReadPlanet.AddRange(planetId ?? new List<int>());
			rhythmSetRedDotRequest.RedDot.ReadSubLevel.AddRange(subLevelId ?? new List<int>());
			rhythmSetRedDotRequest.RedDot.ReadRole.AddRange(roleId ?? new List<int>());
			Net.Instance.Call(ERequestMessageId.RhythmSetRedDotRequest, rhythmSetRedDotRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RhythmSetRedDotResponse rhythmSetRedDotResponse = (RhythmSetRedDotResponse)msg;
				if (rhythmSetRedDotResponse == null || rhythmSetRedDotResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
				{
					return;
				}
				RhythmShipData activityData2 = RhythmShipModel.Instance.ActivityData;
				if (activityData2 != null)
				{
					if (planetId != null)
					{
						RhythmRedDotPb redDotInfo = activityData2.RedDotInfo;
						if (redDotInfo != null)
						{
							redDotInfo.ReadPlanet.AddRange(planetId);
						}
					}
					if (subLevelId != null)
					{
						RhythmRedDotPb redDotInfo2 = activityData2.RedDotInfo;
						if (redDotInfo2 != null)
						{
							redDotInfo2.ReadSubLevel.AddRange(subLevelId);
						}
					}
					if (roleId != null)
					{
						RhythmRedDotPb redDotInfo3 = activityData2.RedDotInfo;
						if (redDotInfo3 != null)
						{
							redDotInfo3.ReadRole.AddRange(roleId);
						}
					}
					EventSystem.Instance.Emit<List<int>, List<int>, List<int>>(EEventName.OnRhythmShipRedDotRefresh, planetId, subLevelId, roleId);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, RhythmShipModel.Instance.ActivityId);
				}
			}, 0);
		}

		// Token: 0x06034197 RID: 213399 RVA: 0x00E92C64 File Offset: 0x00E90E64
		public void RhythmChangePartnerRoleRequest(int roleId)
		{
			RhythmChangePartnerRoleRequest rhythmChangePartnerRoleRequest = Aki.Protocol.RhythmChangePartnerRoleRequest.Create();
			rhythmChangePartnerRoleRequest.RhythmRoleId = roleId;
			Net.Instance.Call(ERequestMessageId.RhythmChangePartnerRoleRequest, rhythmChangePartnerRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RhythmChangePartnerRoleResponse rhythmChangePartnerRoleResponse = (RhythmChangePartnerRoleResponse)msg;
				if (rhythmChangePartnerRoleResponse == null || rhythmChangePartnerRoleResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
				{
					return;
				}
				RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
				if (activityData != null)
				{
					activityData.CurrentRole = roleId;
				}
				EventSystem.Instance.Emit(EEventName.OnRhythmShipSelectRoleRefresh);
			}, 0);
		}

		// Token: 0x06034198 RID: 213400 RVA: 0x00E92CB0 File Offset: 0x00E90EB0
		public void RhythmTaskOneKeyRewardRequest(int taskId)
		{
			RhythmTaskOneKeyRewardRequest rhythmTaskOneKeyRewardRequest = Aki.Protocol.RhythmTaskOneKeyRewardRequest.Create();
			RhythmTask? rhythmShipTaskById = RhythmShipConfig.Instance.GetRhythmShipTaskById(taskId);
			rhythmTaskOneKeyRewardRequest.TaskId.AddRange(RhythmShipModel.Instance.GetAllCanGetRewardTaskByType((RhythmTaskTypePb)rhythmShipTaskById.Value.TaskType, rhythmShipTaskById.Value.TaskTab));
			rhythmTaskOneKeyRewardRequest.TaskType = (RhythmTaskTypePb)rhythmShipTaskById.Value.TaskType;
			Net.Instance.Call(ERequestMessageId.RhythmTaskOneKeyRewardRequest, rhythmTaskOneKeyRewardRequest, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06034199 RID: 213401 RVA: 0x00E92D48 File Offset: 0x00E90F48
		public UniTask RhythmRankListRequest()
		{
			RhythmShipController.<RhythmRankListRequest>d__15 <RhythmRankListRequest>d__;
			<RhythmRankListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmRankListRequest>d__.<>4__this = this;
			<RhythmRankListRequest>d__.<>1__state = -1;
			<RhythmRankListRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmRankListRequest>d__15>(ref <RhythmRankListRequest>d__);
			return <RhythmRankListRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603419A RID: 213402 RVA: 0x00E92D8C File Offset: 0x00E90F8C
		public UniTask RhythmRankListSelfDataRequest()
		{
			RhythmShipController.<RhythmRankListSelfDataRequest>d__16 <RhythmRankListSelfDataRequest>d__;
			<RhythmRankListSelfDataRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmRankListSelfDataRequest>d__.<>1__state = -1;
			<RhythmRankListSelfDataRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmRankListSelfDataRequest>d__16>(ref <RhythmRankListSelfDataRequest>d__);
			return <RhythmRankListSelfDataRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603419B RID: 213403 RVA: 0x00E92DC8 File Offset: 0x00E90FC8
		public void RhythmSettleRequest(int subLevelId, RhythmSettleReasonPb reason, RhythmResultPayload payload, Dictionary<ERhythmShipSettlementType, int> settlementItemMap, bool isDisableRecordUpLoad, bool isQuit = false)
		{
			int score = payload.Score;
			RhythmShipRank rank = payload.Rank;
			if (isDisableRecordUpLoad)
			{
				payload.Score = 0;
				payload.Rank = RhythmShipRank.B;
				payload.Accuracy = 0;
			}
			RhythmSettleRequest rhythmSettleRequest = Aki.Protocol.RhythmSettleRequest.Create();
			rhythmSettleRequest.SubLevelId = subLevelId;
			rhythmSettleRequest.SettleReason = reason;
			rhythmSettleRequest.Payload = payload;
			Net.Instance.Call(ERequestMessageId.RhythmSettleRequest, rhythmSettleRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RhythmSettleResponse rhythmSettleResponse = (RhythmSettleResponse)msg;
				if (rhythmSettleResponse == null || rhythmSettleResponse.ErrCode > Aki.Protocol.ErrorCode.Success)
				{
					return;
				}
				if (isQuit)
				{
					return;
				}
				payload.Score = score;
				payload.Rank = rank;
				RhythmShipSettlementViewData param = new RhythmShipSettlementViewData
				{
					SubLevelId = subLevelId,
					Reason = reason,
					Payload = payload,
					SettlementItemMap = settlementItemMap
				};
				UiManager.Instance.OpenView(EUiViewName.RhythmShipSettlementView, param, null);
			}, 0);
		}

		// Token: 0x0603419C RID: 213404 RVA: 0x00E92E94 File Offset: 0x00E91094
		public void StartRequest(int subLevelId, int levelId)
		{
			if (this.IsStartRequesting)
			{
				return;
			}
			this.IsStartRequesting = true;
			RhythmCtx rhythmCtx = RhythmCtx.Create();
			rhythmCtx.SubLevelId = subLevelId;
			InstanceDungeonModel.Instance.InstanceEnterContentText.RhythmCtx = rhythmCtx;
			int instId = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(subLevelId).Value.InstId;
			this.StartRequestAsync(instId, subLevelId, levelId).Forget();
		}

		// Token: 0x0603419D RID: 213405 RVA: 0x00E92EF8 File Offset: 0x00E910F8
		private UniTask StartRequestAsync(int instanceId, int subLevelId, int levelId)
		{
			RhythmShipController.<StartRequestAsync>d__19 <StartRequestAsync>d__;
			<StartRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartRequestAsync>d__.<>4__this = this;
			<StartRequestAsync>d__.instanceId = instanceId;
			<StartRequestAsync>d__.subLevelId = subLevelId;
			<StartRequestAsync>d__.levelId = levelId;
			<StartRequestAsync>d__.<>1__state = -1;
			<StartRequestAsync>d__.<>t__builder.Start<RhythmShipController.<StartRequestAsync>d__19>(ref <StartRequestAsync>d__);
			return <StartRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603419E RID: 213406 RVA: 0x00E92F54 File Offset: 0x00E91154
		public UniTask RhythmMainLineInfoRequest()
		{
			RhythmShipController.<RhythmMainLineInfoRequest>d__20 <RhythmMainLineInfoRequest>d__;
			<RhythmMainLineInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmMainLineInfoRequest>d__.<>1__state = -1;
			<RhythmMainLineInfoRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmMainLineInfoRequest>d__20>(ref <RhythmMainLineInfoRequest>d__);
			return <RhythmMainLineInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603419F RID: 213407 RVA: 0x00E92F90 File Offset: 0x00E91190
		[NullableContext(2)]
		private void RhythmRoleUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RhythmRoleUpdateNotify rhythmRoleUpdateNotify = (RhythmRoleUpdateNotify)msg;
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData != null)
			{
				activityData.RoleUnlockList.AddRange(rhythmRoleUpdateNotify.UnlockedRole);
			}
		}

		// Token: 0x060341A0 RID: 213408 RVA: 0x00E92FC4 File Offset: 0x00E911C4
		[NullableContext(2)]
		private void RhythmTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RhythmTaskUpdateNotify rhythmTaskUpdateNotify = (RhythmTaskUpdateNotify)msg;
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			foreach (RhythmTaskPb rhythmTaskPb in rhythmTaskUpdateNotify.RhythmTask)
			{
				if (rhythmTaskPb.TaskType == RhythmTaskTypePb.Resident)
				{
					foreach (ConditionTask conditionTask in rhythmTaskPb.Task)
					{
						activityData.TaskInfoMap[conditionTask.Id] = conditionTask;
					}
				}
				if (rhythmTaskPb.TaskType == RhythmTaskTypePb.Limit)
				{
					foreach (ConditionTask conditionTask2 in rhythmTaskPb.Task)
					{
						activityData.LimitTaskInfoMap[conditionTask2.Id] = conditionTask2;
					}
				}
				EventSystem.Instance.Emit(EEventName.OnRhythmShipTaskRefresh);
				foreach (int p in activityData.TaskTabList)
				{
					EventSystem.Instance.Emit<int>(EEventName.OnRhythmShipTaskTabRefresh, p);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, RhythmShipModel.Instance.ActivityId);
			}
		}

		// Token: 0x060341A1 RID: 213409 RVA: 0x00E93180 File Offset: 0x00E91380
		[NullableContext(2)]
		private void RhythmSubLevelUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (RhythmSubLevelPb rhythmSubLevelPb in ((RhythmSubLevelUpdateNotify)msg).UpdateSubLevelPb)
			{
				if (RhythmShipModel.Instance.GetSubLevelActivityId(rhythmSubLevelPb.SubLevelId) != 0)
				{
					RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
					if (activityData != null)
					{
						activityData.SubLevelInfoMap[rhythmSubLevelPb.SubLevelId] = rhythmSubLevelPb;
					}
				}
				else
				{
					RhythmShipModel.Instance.MainLineSubLevelInfoMap[rhythmSubLevelPb.SubLevelId] = rhythmSubLevelPb;
				}
			}
		}

		// Token: 0x060341A2 RID: 213410 RVA: 0x00E93218 File Offset: 0x00E91418
		[NullableContext(2)]
		private void RhythmShipStartNotify(IMessage msg, Net.CallbackStatus status)
		{
			RhythmShipStartNotify rhythmShipStartNotify = (RhythmShipStartNotify)msg;
			RhythmShipModel.Instance.RhythmShipLevelRole = rhythmShipStartNotify.RhythmRoleId;
		}

		// Token: 0x060341A3 RID: 213411 RVA: 0x00E9323C File Offset: 0x00E9143C
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			RhythmShipController.<OnOpenSubView>d__25 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<RhythmShipController.<OnOpenSubView>d__25>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x060341A4 RID: 213412 RVA: 0x00E93280 File Offset: 0x00E91480
		public void PlayLoopAudioEvent(string @event)
		{
			if (StringUtils.IsEmpty(this.LastLoopAudio))
			{
				this.LastLoopAudio = @event;
				AudioSystem.Instance.PostEvent(@event);
				return;
			}
			if (@event != this.LastLoopAudio)
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio, EAudioActionType.Stop, null);
				this.LastLoopAudio = @event;
				AudioSystem.Instance.PostEvent(@event);
				return;
			}
			this.LastLoopAudio = @event;
			AudioSystem.Instance.ExecuteAction(this.LastLoopAudio, EAudioActionType.Resume, null);
		}

		// Token: 0x060341A5 RID: 213413 RVA: 0x00E9330C File Offset: 0x00E9150C
		public void StopLoopAudioEvent()
		{
			if (!StringUtils.IsEmpty(this.LastLoopAudio))
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio, EAudioActionType.Stop, null);
				this.LastLoopAudio = "";
			}
		}

		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x060341A6 RID: 213414 RVA: 0x00E9334B File Offset: 0x00E9154B
		public static RhythmShipController Instance
		{
			get
			{
				return RhythmShipController._Instance;
			}
		}

		// Token: 0x060341A7 RID: 213415 RVA: 0x00E93352 File Offset: 0x00E91552
		public static RhythmShipController GetOrCreateInstance()
		{
			if (RhythmShipController._Instance == null)
			{
				RhythmShipController.CreateInstance();
			}
			return RhythmShipController._Instance;
		}

		// Token: 0x060341A8 RID: 213416 RVA: 0x00E93366 File Offset: 0x00E91566
		public static bool CreateInstance()
		{
			if (RhythmShipController._Instance != null)
			{
				return true;
			}
			RhythmShipController._Instance = new RhythmShipController();
			return true;
		}

		// Token: 0x060341A9 RID: 213417 RVA: 0x00E9337C File Offset: 0x00E9157C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060341AA RID: 213418 RVA: 0x00E9337E File Offset: 0x00E9157E
		public static void ResetStaticDefaultValue()
		{
			RhythmShipController._Instance = null;
		}

		// Token: 0x060341AB RID: 213419 RVA: 0x00E93386 File Offset: 0x00E91586
		static RhythmShipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipController.CreateStaticDefaultValue), new Action(RhythmShipController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B96B RID: 113003
		private bool IsStartRequesting;

		// Token: 0x0401B96C RID: 113004
		public double NextCanRhythmRankListRequestTime;

		// Token: 0x0401B96D RID: 113005
		public string LastLoopAudio = "";

		// Token: 0x0401B96E RID: 113006
		[Nullable(2)]
		private static RhythmShipController _Instance;
	}
}
