using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057FD RID: 22525
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CyberPunkController : ActivityControllerBase
	{
		// Token: 0x06037956 RID: 227670 RVA: 0x00F89507 File Offset: 0x00F87707
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06037957 RID: 227671 RVA: 0x00F89509 File Offset: 0x00F87709
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06037958 RID: 227672 RVA: 0x00F8950C File Offset: 0x00F8770C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityGuideCyberpunk";
		}

		// Token: 0x06037959 RID: 227673 RVA: 0x00F89513 File Offset: 0x00F87713
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CyberPunkSubView();
		}

		// Token: 0x0603795A RID: 227674 RVA: 0x00F8951A File Offset: 0x00F8771A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.CurrentActivityId = data.Id;
			return new CyberPunkData();
		}

		// Token: 0x0603795B RID: 227675 RVA: 0x00F8952D File Offset: 0x00F8772D
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEdgeRunnerUpdate));
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerPreUnlockAvailableNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEdgeRunnerFunctionPreUnlock));
		}

		// Token: 0x0603795C RID: 227676 RVA: 0x00F89567 File Offset: 0x00F87767
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerPreUnlockAvailableNotify);
		}

		// Token: 0x0603795D RID: 227677 RVA: 0x00F8958C File Offset: 0x00F8778C
		[NullableContext(2)]
		private void OnEdgeRunnerUpdate(IMessage msg, Net.CallbackStatus _)
		{
			EdgeRunnerUpdateNotify edgeRunnerUpdateNotify = (EdgeRunnerUpdateNotify)msg;
			CyberPunkData currentActivityDataStatic = this.GetCurrentActivityDataStatic();
			if (currentActivityDataStatic == null)
			{
				return;
			}
			if (edgeRunnerUpdateNotify.HasFunctionId)
			{
				currentActivityDataStatic.AddUnlockedFunctionId(edgeRunnerUpdateNotify.FunctionId);
				EventSystem.Instance.Emit(EEventName.OnCyberPunkItemUnLock);
			}
			if (edgeRunnerUpdateNotify.Task != null)
			{
				currentActivityDataStatic.RefreshSingleTaskData(edgeRunnerUpdateNotify.Task);
			}
			EventSystem.Instance.Emit(EEventName.OnCyberPunkTaskRefresh);
		}

		// Token: 0x0603795E RID: 227678 RVA: 0x00F895F4 File Offset: 0x00F877F4
		[NullableContext(2)]
		private void OnEdgeRunnerFunctionPreUnlock(IMessage msg, Net.CallbackStatus _)
		{
			EdgeRunnerPreUnlockAvailableNotify notify = (EdgeRunnerPreUnlockAvailableNotify)msg;
			CyberPunkData currentActivityDataStatic = this.GetCurrentActivityDataStatic();
			if (currentActivityDataStatic == null)
			{
				return;
			}
			currentActivityDataStatic.AddPreUnlockedQuestIds(notify);
		}

		// Token: 0x0603795F RID: 227679 RVA: 0x00F8961C File Offset: 0x00F8781C
		[NullableContext(2)]
		public CyberPunkData GetCurrentActivityDataStatic()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.EdgeRunnerActivity);
			if (currentActivitiesByType == null || currentActivitiesByType.Count == 0)
			{
				return null;
			}
			return currentActivitiesByType[0] as CyberPunkData;
		}

		// Token: 0x06037960 RID: 227680 RVA: 0x00F89650 File Offset: 0x00F87850
		[NullableContext(2)]
		public void RequestScoreReward(int scoreId, Action callback = null)
		{
			EdgeRunnerScoreRewardRequest edgeRunnerScoreRewardRequest = EdgeRunnerScoreRewardRequest.Create();
			edgeRunnerScoreRewardRequest.ScoreId = scoreId;
			Net.Instance.Call(ERequestMessageId.EdgeRunnerScoreRewardRequest, edgeRunnerScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EdgeRunnerScoreRewardResponse edgeRunnerScoreRewardResponse = (EdgeRunnerScoreRewardResponse)msg;
				if (edgeRunnerScoreRewardResponse == null)
				{
					return;
				}
				if (edgeRunnerScoreRewardResponse.ErrCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerScoreRewardResponse.ErrCode, 20097, null, true, true);
					return;
				}
				CyberPunkData currentActivityDataStatic = this.GetCurrentActivityDataStatic();
				if (currentActivityDataStatic != null)
				{
					currentActivityDataStatic.UpdateRewardScoreId(scoreId);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityDataStatic.Id);
					EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, currentActivityDataStatic.Id);
					EventSystem.Instance.Emit(EEventName.OnCyberPunkTaskRefresh);
				}
				List<int> list = ((currentActivityDataStatic != null) ? currentActivityDataStatic.GetClaimableTaskIds() : null) ?? new List<int>();
				if (list.Count > 0)
				{
					this.RequestTaskReward(list.ToArray(), null);
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, 0);
		}

		// Token: 0x06037961 RID: 227681 RVA: 0x00F896A8 File Offset: 0x00F878A8
		public void RequestTaskReward(int[] taskIds, [Nullable(2)] Action callback = null)
		{
			EdgeRunnerTaskRewardRequest edgeRunnerTaskRewardRequest = EdgeRunnerTaskRewardRequest.Create();
			edgeRunnerTaskRewardRequest.TaskIds.AddRange(taskIds);
			CyberPunkData currentActivityDataStatic = this.GetCurrentActivityDataStatic();
			if (currentActivityDataStatic != null)
			{
				edgeRunnerTaskRewardRequest.ActivityId = currentActivityDataStatic.Id;
			}
			Net.Instance.Call(ERequestMessageId.EdgeRunnerTaskRewardRequest, edgeRunnerTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EdgeRunnerTaskRewardResponse edgeRunnerTaskRewardResponse = (EdgeRunnerTaskRewardResponse)msg;
				if (edgeRunnerTaskRewardResponse == null)
				{
					return;
				}
				if (edgeRunnerTaskRewardResponse.ErrCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerTaskRewardResponse.ErrCode, 17834, null, true, true);
					return;
				}
				CyberPunkData currentActivityDataStatic2 = this.GetCurrentActivityDataStatic();
				if (currentActivityDataStatic2 != null)
				{
					foreach (int taskId in taskIds)
					{
						currentActivityDataStatic2.MarkTaskAsClaimed(taskId);
					}
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityDataStatic2.Id);
					EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, currentActivityDataStatic2.Id);
					EventSystem.Instance.Emit(EEventName.OnCyberPunkTaskRefresh);
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, 0);
		}

		// Token: 0x06037962 RID: 227682 RVA: 0x00F8971C File Offset: 0x00F8791C
		[NullableContext(2)]
		public void PreOpenStoryFunction(int functionId, Action callback = null)
		{
			EdgeRunnerFunctionPreUnlockRequest edgeRunnerFunctionPreUnlockRequest = EdgeRunnerFunctionPreUnlockRequest.Create();
			edgeRunnerFunctionPreUnlockRequest.FuncId = functionId;
			Net.Instance.Call(ERequestMessageId.EdgeRunnerFunctionPreUnlockRequest, edgeRunnerFunctionPreUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EdgeRunnerFunctionPreUnlockResponse edgeRunnerFunctionPreUnlockResponse = (EdgeRunnerFunctionPreUnlockResponse)msg;
				if (edgeRunnerFunctionPreUnlockResponse == null)
				{
					return;
				}
				if (edgeRunnerFunctionPreUnlockResponse.ErrCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerFunctionPreUnlockResponse.ErrCode, 20110, null, true, true);
					return;
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, 0);
		}

		// Token: 0x06037963 RID: 227683 RVA: 0x00F89760 File Offset: 0x00F87960
		[NullableContext(2)]
		public CyberPunkData GetCurrentActivityData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.EdgeRunnerActivity);
			CyberPunkData result = null;
			if (currentActivitiesByType.Count > 0)
			{
				result = (currentActivitiesByType.GetValueOrDefault(0) as CyberPunkData);
			}
			return result;
		}

		// Token: 0x06037964 RID: 227684 RVA: 0x00F89794 File Offset: 0x00F87994
		public string GetTimeVisibleAndRemainTimeText()
		{
			CyberPunkData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return "";
			}
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(currentActivityData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			if (!item)
			{
				return "";
			}
			return item2;
		}

		// Token: 0x17006B07 RID: 27399
		// (get) Token: 0x06037965 RID: 227685 RVA: 0x00F897D4 File Offset: 0x00F879D4
		public static CyberPunkController Instance
		{
			get
			{
				return CyberPunkController._Instance;
			}
		}

		// Token: 0x06037966 RID: 227686 RVA: 0x00F897DB File Offset: 0x00F879DB
		public static CyberPunkController GetOrCreateInstance()
		{
			if (CyberPunkController._Instance == null)
			{
				CyberPunkController.CreateInstance();
			}
			return CyberPunkController._Instance;
		}

		// Token: 0x06037967 RID: 227687 RVA: 0x00F897EF File Offset: 0x00F879EF
		public static bool CreateInstance()
		{
			if (CyberPunkController._Instance != null)
			{
				return true;
			}
			CyberPunkController._Instance = new CyberPunkController();
			return true;
		}

		// Token: 0x06037968 RID: 227688 RVA: 0x00F89805 File Offset: 0x00F87A05
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037969 RID: 227689 RVA: 0x00F89807 File Offset: 0x00F87A07
		public static void ResetStaticDefaultValue()
		{
			CyberPunkController._Instance = null;
		}

		// Token: 0x0603796A RID: 227690 RVA: 0x00F8980F File Offset: 0x00F87A0F
		static CyberPunkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CyberPunkController.CreateStaticDefaultValue), new Action(CyberPunkController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D513 RID: 120083
		public int CurrentActivityId;

		// Token: 0x0401D514 RID: 120084
		[Nullable(2)]
		private static CyberPunkController _Instance;
	}
}
