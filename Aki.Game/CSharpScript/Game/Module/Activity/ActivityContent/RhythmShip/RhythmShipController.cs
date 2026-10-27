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
	// Token: 0x02006200 RID: 25088
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RhythmShipController : ActivityControllerBase
	{
		// Token: 0x0603F4CB RID: 259275 RVA: 0x00F4BAA8 File Offset: 0x00F49CA8
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F4CC RID: 259276 RVA: 0x00F4BAAA File Offset: 0x00F49CAA
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_RhythmShipActivityMain";
		}

		// Token: 0x0603F4CD RID: 259277 RVA: 0x00F4BAB1 File Offset: 0x00F49CB1
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new RhythmShipSubView();
		}

		// Token: 0x0603F4CE RID: 259278 RVA: 0x00F4BAB8 File Offset: 0x00F49CB8
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			RhythmShipModel.Instance.ActivityId = data.Id;
			return new RhythmShipData();
		}

		// Token: 0x0603F4CF RID: 259279 RVA: 0x00F4BACF File Offset: 0x00F49CCF
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F4D0 RID: 259280 RVA: 0x00F4BAD2 File Offset: 0x00F49CD2
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603F4D1 RID: 259281 RVA: 0x00F4BAF0 File Offset: 0x00F49CF0
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603F4D2 RID: 259282 RVA: 0x00F4BB0E File Offset: 0x00F49D0E
		private void OnWorldDone()
		{
			RhythmShipModel.Instance.InitLocalCalibrationValue();
		}

		// Token: 0x0603F4D3 RID: 259283 RVA: 0x00F4BB1C File Offset: 0x00F49D1C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RhythmRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmRoleUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmSubLevelUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmSubLevelUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RhythmShipStartNotify, new Action<IMessage, Net.CallbackStatus>(this.RhythmShipStartNotify));
		}

		// Token: 0x0603F4D4 RID: 259284 RVA: 0x00F4BB9C File Offset: 0x00F49D9C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RhythmRoleUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmSubLevelUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RhythmShipStartNotify);
		}

		// Token: 0x0603F4D5 RID: 259285 RVA: 0x00F4BBEC File Offset: 0x00F49DEC
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

		// Token: 0x0603F4D6 RID: 259286 RVA: 0x00F4BD0C File Offset: 0x00F49F0C
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

		// Token: 0x0603F4D7 RID: 259287 RVA: 0x00F4BD58 File Offset: 0x00F49F58
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

		// Token: 0x0603F4D8 RID: 259288 RVA: 0x00F4BDF0 File Offset: 0x00F49FF0
		public UniTask RhythmRankListRequest()
		{
			RhythmShipController.<RhythmRankListRequest>d__15 <RhythmRankListRequest>d__;
			<RhythmRankListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmRankListRequest>d__.<>4__this = this;
			<RhythmRankListRequest>d__.<>1__state = -1;
			<RhythmRankListRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmRankListRequest>d__15>(ref <RhythmRankListRequest>d__);
			return <RhythmRankListRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603F4D9 RID: 259289 RVA: 0x00F4BE34 File Offset: 0x00F4A034
		public UniTask RhythmRankListSelfDataRequest()
		{
			RhythmShipController.<RhythmRankListSelfDataRequest>d__16 <RhythmRankListSelfDataRequest>d__;
			<RhythmRankListSelfDataRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmRankListSelfDataRequest>d__.<>1__state = -1;
			<RhythmRankListSelfDataRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmRankListSelfDataRequest>d__16>(ref <RhythmRankListSelfDataRequest>d__);
			return <RhythmRankListSelfDataRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603F4DA RID: 259290 RVA: 0x00F4BE70 File Offset: 0x00F4A070
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

		// Token: 0x0603F4DB RID: 259291 RVA: 0x00F4BF3C File Offset: 0x00F4A13C
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

		// Token: 0x0603F4DC RID: 259292 RVA: 0x00F4BFA0 File Offset: 0x00F4A1A0
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

		// Token: 0x0603F4DD RID: 259293 RVA: 0x00F4BFFC File Offset: 0x00F4A1FC
		public UniTask RhythmMainLineInfoRequest()
		{
			RhythmShipController.<RhythmMainLineInfoRequest>d__20 <RhythmMainLineInfoRequest>d__;
			<RhythmMainLineInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RhythmMainLineInfoRequest>d__.<>1__state = -1;
			<RhythmMainLineInfoRequest>d__.<>t__builder.Start<RhythmShipController.<RhythmMainLineInfoRequest>d__20>(ref <RhythmMainLineInfoRequest>d__);
			return <RhythmMainLineInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603F4DE RID: 259294 RVA: 0x00F4C038 File Offset: 0x00F4A238
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

		// Token: 0x0603F4DF RID: 259295 RVA: 0x00F4C06C File Offset: 0x00F4A26C
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

		// Token: 0x0603F4E0 RID: 259296 RVA: 0x00F4C228 File Offset: 0x00F4A428
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

		// Token: 0x0603F4E1 RID: 259297 RVA: 0x00F4C2C0 File Offset: 0x00F4A4C0
		[NullableContext(2)]
		private void RhythmShipStartNotify(IMessage msg, Net.CallbackStatus status)
		{
			RhythmShipStartNotify rhythmShipStartNotify = (RhythmShipStartNotify)msg;
			RhythmShipModel.Instance.RhythmShipLevelRole = rhythmShipStartNotify.RhythmRoleId;
		}

		// Token: 0x0603F4E2 RID: 259298 RVA: 0x00F4C2E4 File Offset: 0x00F4A4E4
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

		// Token: 0x0603F4E3 RID: 259299 RVA: 0x00F4C328 File Offset: 0x00F4A528
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

		// Token: 0x0603F4E4 RID: 259300 RVA: 0x00F4C3B4 File Offset: 0x00F4A5B4
		public void StopLoopAudioEvent()
		{
			if (!StringUtils.IsEmpty(this.LastLoopAudio))
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio, EAudioActionType.Stop, null);
				this.LastLoopAudio = "";
			}
		}

		// Token: 0x1700922F RID: 37423
		// (get) Token: 0x0603F4E5 RID: 259301 RVA: 0x00F4C3F3 File Offset: 0x00F4A5F3
		public static RhythmShipController Instance
		{
			get
			{
				return RhythmShipController._Instance;
			}
		}

		// Token: 0x0603F4E6 RID: 259302 RVA: 0x00F4C3FA File Offset: 0x00F4A5FA
		public static RhythmShipController GetOrCreateInstance()
		{
			if (RhythmShipController._Instance == null)
			{
				RhythmShipController.CreateInstance();
			}
			return RhythmShipController._Instance;
		}

		// Token: 0x0603F4E7 RID: 259303 RVA: 0x00F4C40E File Offset: 0x00F4A60E
		public static bool CreateInstance()
		{
			if (RhythmShipController._Instance != null)
			{
				return true;
			}
			RhythmShipController._Instance = new RhythmShipController();
			return true;
		}

		// Token: 0x0603F4E8 RID: 259304 RVA: 0x00F4C424 File Offset: 0x00F4A624
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F4E9 RID: 259305 RVA: 0x00F4C426 File Offset: 0x00F4A626
		public static void ResetStaticDefaultValue()
		{
			RhythmShipController._Instance = null;
		}

		// Token: 0x0603F4EA RID: 259306 RVA: 0x00F4C42E File Offset: 0x00F4A62E
		static RhythmShipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipController.CreateStaticDefaultValue), new Action(RhythmShipController.ResetStaticDefaultValue));
		}

		// Token: 0x0402103C RID: 135228
		private bool IsStartRequesting;

		// Token: 0x0402103D RID: 135229
		public double NextCanRhythmRankListRequestTime;

		// Token: 0x0402103E RID: 135230
		public string LastLoopAudio = "";

		// Token: 0x0402103F RID: 135231
		[Nullable(2)]
		private static RhythmShipController _Instance;
	}
}
