using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EF0 RID: 24304
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GuQinActivityController : ActivityControllerBase
	{
		// Token: 0x0603DC20 RID: 252960 RVA: 0x00EED9CE File Offset: 0x00EEBBCE
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.QingXiaoTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQingXiaoTaskUpdateNotify));
		}

		// Token: 0x0603DC21 RID: 252961 RVA: 0x00EED9EC File Offset: 0x00EEBBEC
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.QingXiaoTaskUpdateNotify);
		}

		// Token: 0x0603DC22 RID: 252962 RVA: 0x00EED9FE File Offset: 0x00EEBBFE
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603DC23 RID: 252963 RVA: 0x00EEDA1C File Offset: 0x00EEBC1C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603DC24 RID: 252964 RVA: 0x00EEDA3C File Offset: 0x00EEBC3C
		[NullableContext(2)]
		private void OnQingXiaoTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			QingXiaoTaskUpdateNotify qingXiaoTaskUpdateNotify = (QingXiaoTaskUpdateNotify)msg;
			if (this.Data == null)
			{
				return;
			}
			foreach (GuQinActivityTabData guQinActivityTabData in this.Data.GetTabDataMap().Values)
			{
				foreach (GuQinActivityTaskData guQinActivityTaskData in guQinActivityTabData.TaskList)
				{
					int id = guQinActivityTaskData.Id;
					ConditionTask task = qingXiaoTaskUpdateNotify.Task;
					int? num = (task != null) ? new int?(task.Id) : null;
					if (id == num.GetValueOrDefault() & num != null)
					{
						ConditionTaskState status2 = qingXiaoTaskUpdateNotify.Task.Status;
						if (guQinActivityTaskData.TaskState == ConditionTaskState.ConditionTaskTaken && status2 != ConditionTaskState.ConditionTaskTaken)
						{
							break;
						}
						guQinActivityTaskData.TaskState = status2;
						EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.Data.Id);
						EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
						break;
					}
				}
			}
		}

		// Token: 0x0603DC25 RID: 252965 RVA: 0x00EEDB80 File Offset: 0x00EEBD80
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (this.Data == null)
			{
				return;
			}
			foreach (GuQinActivityTabData guQinActivityTabData in this.Data.GetTabDataMap().Values)
			{
				using (List<GuQinActivityTaskData>.Enumerator enumerator2 = guQinActivityTabData.TaskList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.GetConfig().QuestId == questId)
						{
							EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.Data.Id);
							EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0603DC26 RID: 252966 RVA: 0x00EEDC64 File Offset: 0x00EEBE64
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603DC27 RID: 252967 RVA: 0x00EEDC68 File Offset: 0x00EEBE68
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			GuQinActivityController.<OnOpenSubView>d__8 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<GuQinActivityController.<OnOpenSubView>d__8>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x0603DC28 RID: 252968 RVA: 0x00EEDCB3 File Offset: 0x00EEBEB3
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_QingxiaoActivityMain";
		}

		// Token: 0x0603DC29 RID: 252969 RVA: 0x00EEDCBA File Offset: 0x00EEBEBA
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new GuQinActivitySubView();
		}

		// Token: 0x0603DC2A RID: 252970 RVA: 0x00EEDCC1 File Offset: 0x00EEBEC1
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new GuQinActivityData();
			return this.Data;
		}

		// Token: 0x0603DC2B RID: 252971 RVA: 0x00EEDCD4 File Offset: 0x00EEBED4
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.GuQinActivityMainView);
		}

		// Token: 0x0603DC2C RID: 252972 RVA: 0x00EEDCE8 File Offset: 0x00EEBEE8
		public void RequestReward(GuQinActivityTaskData taskData, Action callback)
		{
			QingXiaoTaskRewardRequest qingXiaoTaskRewardRequest = new QingXiaoTaskRewardRequest();
			qingXiaoTaskRewardRequest.ActivityId = this.Data.Id;
			qingXiaoTaskRewardRequest.TaskIds.Add(taskData.Id);
			Net.Instance.Call(ERequestMessageId.QingXiaoTaskRewardRequest, qingXiaoTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				QingXiaoTaskRewardResponse qingXiaoTaskRewardResponse = (QingXiaoTaskRewardResponse)msg;
				if (qingXiaoTaskRewardResponse.ErrCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(qingXiaoTaskRewardResponse.ErrCode, 26165, null, true, true);
					return;
				}
				taskData.TaskState = ConditionTaskState.ConditionTaskTaken;
				callback();
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
			}, 0);
		}

		// Token: 0x17008EEB RID: 36587
		// (get) Token: 0x0603DC2D RID: 252973 RVA: 0x00EEDD5A File Offset: 0x00EEBF5A
		public static GuQinActivityController Instance
		{
			get
			{
				return GuQinActivityController._Instance;
			}
		}

		// Token: 0x0603DC2E RID: 252974 RVA: 0x00EEDD61 File Offset: 0x00EEBF61
		public static GuQinActivityController GetOrCreateInstance()
		{
			if (GuQinActivityController._Instance == null)
			{
				GuQinActivityController.CreateInstance();
			}
			return GuQinActivityController._Instance;
		}

		// Token: 0x0603DC2F RID: 252975 RVA: 0x00EEDD75 File Offset: 0x00EEBF75
		public static bool CreateInstance()
		{
			if (GuQinActivityController._Instance != null)
			{
				return true;
			}
			GuQinActivityController._Instance = new GuQinActivityController();
			return true;
		}

		// Token: 0x0603DC30 RID: 252976 RVA: 0x00EEDD8B File Offset: 0x00EEBF8B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DC31 RID: 252977 RVA: 0x00EEDD8D File Offset: 0x00EEBF8D
		public static void ResetStaticDefaultValue()
		{
			GuQinActivityController._Instance = null;
		}

		// Token: 0x0603DC32 RID: 252978 RVA: 0x00EEDD95 File Offset: 0x00EEBF95
		static GuQinActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuQinActivityController.CreateStaticDefaultValue), new Action(GuQinActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04020456 RID: 132182
		[Nullable(2)]
		public GuQinActivityData Data;

		// Token: 0x04020457 RID: 132183
		[Nullable(2)]
		private static GuQinActivityController _Instance;
	}
}
