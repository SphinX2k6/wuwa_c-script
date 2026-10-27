using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068AD RID: 26797
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CyberPunkController : ActivityControllerBase
	{
		// Token: 0x06042DFE RID: 273918 RVA: 0x01047EF7 File Offset: 0x010460F7
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06042DFF RID: 273919 RVA: 0x01047EF9 File Offset: 0x010460F9
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06042E00 RID: 273920 RVA: 0x01047EFC File Offset: 0x010460FC
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityGuideCyberpunk";
		}

		// Token: 0x06042E01 RID: 273921 RVA: 0x01047F03 File Offset: 0x01046103
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CyberPunkSubView();
		}

		// Token: 0x06042E02 RID: 273922 RVA: 0x01047F0A File Offset: 0x0104610A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.CurrentActivityId = data.Id;
			return new CyberPunkData();
		}

		// Token: 0x06042E03 RID: 273923 RVA: 0x01047F1D File Offset: 0x0104611D
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEdgeRunnerUpdate));
			Net.Instance.Register(ENotifyMessageId.EdgeRunnerPreUnlockAvailableNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEdgeRunnerFunctionPreUnlock));
		}

		// Token: 0x06042E04 RID: 273924 RVA: 0x01047F57 File Offset: 0x01046157
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.EdgeRunnerPreUnlockAvailableNotify);
		}

		// Token: 0x06042E05 RID: 273925 RVA: 0x01047F7C File Offset: 0x0104617C
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

		// Token: 0x06042E06 RID: 273926 RVA: 0x01047FE4 File Offset: 0x010461E4
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

		// Token: 0x06042E07 RID: 273927 RVA: 0x0104800C File Offset: 0x0104620C
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

		// Token: 0x06042E08 RID: 273928 RVA: 0x01048040 File Offset: 0x01046240
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerScoreRewardResponse.ErrCode, 27370, null, true, true);
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

		// Token: 0x06042E09 RID: 273929 RVA: 0x01048098 File Offset: 0x01046298
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerTaskRewardResponse.ErrCode, 22840, null, true, true);
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

		// Token: 0x06042E0A RID: 273930 RVA: 0x0104810C File Offset: 0x0104630C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(edgeRunnerFunctionPreUnlockResponse.ErrCode, 22129, null, true, true);
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

		// Token: 0x06042E0B RID: 273931 RVA: 0x01048150 File Offset: 0x01046350
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

		// Token: 0x06042E0C RID: 273932 RVA: 0x01048184 File Offset: 0x01046384
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

		// Token: 0x170097C7 RID: 38855
		// (get) Token: 0x06042E0D RID: 273933 RVA: 0x010481C4 File Offset: 0x010463C4
		public static CyberPunkController Instance
		{
			get
			{
				return CyberPunkController._Instance;
			}
		}

		// Token: 0x06042E0E RID: 273934 RVA: 0x010481CB File Offset: 0x010463CB
		public static CyberPunkController GetOrCreateInstance()
		{
			if (CyberPunkController._Instance == null)
			{
				CyberPunkController.CreateInstance();
			}
			return CyberPunkController._Instance;
		}

		// Token: 0x06042E0F RID: 273935 RVA: 0x010481DF File Offset: 0x010463DF
		public static bool CreateInstance()
		{
			if (CyberPunkController._Instance != null)
			{
				return true;
			}
			CyberPunkController._Instance = new CyberPunkController();
			return true;
		}

		// Token: 0x06042E10 RID: 273936 RVA: 0x010481F5 File Offset: 0x010463F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042E11 RID: 273937 RVA: 0x010481F7 File Offset: 0x010463F7
		public static void ResetStaticDefaultValue()
		{
			CyberPunkController._Instance = null;
		}

		// Token: 0x06042E12 RID: 273938 RVA: 0x010481FF File Offset: 0x010463FF
		static CyberPunkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CyberPunkController.CreateStaticDefaultValue), new Action(CyberPunkController.ResetStaticDefaultValue));
		}

		// Token: 0x04022CB7 RID: 142519
		public int CurrentActivityId;

		// Token: 0x04022CB8 RID: 142520
		[Nullable(2)]
		private static CyberPunkController _Instance;
	}
}
