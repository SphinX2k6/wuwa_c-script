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
	// Token: 0x02004ED7 RID: 20183
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GuQinActivityController : ActivityControllerBase
	{
		// Token: 0x06032BBB RID: 207803 RVA: 0x00E3F692 File Offset: 0x00E3D892
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.QingXiaoTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQingXiaoTaskUpdateNotify));
		}

		// Token: 0x06032BBC RID: 207804 RVA: 0x00E3F6B0 File Offset: 0x00E3D8B0
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.QingXiaoTaskUpdateNotify);
		}

		// Token: 0x06032BBD RID: 207805 RVA: 0x00E3F6C2 File Offset: 0x00E3D8C2
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06032BBE RID: 207806 RVA: 0x00E3F6E0 File Offset: 0x00E3D8E0
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06032BBF RID: 207807 RVA: 0x00E3F700 File Offset: 0x00E3D900
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

		// Token: 0x06032BC0 RID: 207808 RVA: 0x00E3F844 File Offset: 0x00E3DA44
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

		// Token: 0x06032BC1 RID: 207809 RVA: 0x00E3F928 File Offset: 0x00E3DB28
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06032BC2 RID: 207810 RVA: 0x00E3F92C File Offset: 0x00E3DB2C
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

		// Token: 0x06032BC3 RID: 207811 RVA: 0x00E3F977 File Offset: 0x00E3DB77
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_QingxiaoActivityMain";
		}

		// Token: 0x06032BC4 RID: 207812 RVA: 0x00E3F97E File Offset: 0x00E3DB7E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new GuQinActivitySubView();
		}

		// Token: 0x06032BC5 RID: 207813 RVA: 0x00E3F985 File Offset: 0x00E3DB85
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new GuQinActivityData();
			return this.Data;
		}

		// Token: 0x06032BC6 RID: 207814 RVA: 0x00E3F998 File Offset: 0x00E3DB98
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.GuQinActivityMainView);
		}

		// Token: 0x06032BC7 RID: 207815 RVA: 0x00E3F9AC File Offset: 0x00E3DBAC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(qingXiaoTaskRewardResponse.ErrCode, 29336, null, true, true);
					return;
				}
				taskData.TaskState = ConditionTaskState.ConditionTaskTaken;
				callback();
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
			}, 0);
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x06032BC8 RID: 207816 RVA: 0x00E3FA1E File Offset: 0x00E3DC1E
		public static GuQinActivityController Instance
		{
			get
			{
				return GuQinActivityController._Instance;
			}
		}

		// Token: 0x06032BC9 RID: 207817 RVA: 0x00E3FA25 File Offset: 0x00E3DC25
		public static GuQinActivityController GetOrCreateInstance()
		{
			if (GuQinActivityController._Instance == null)
			{
				GuQinActivityController.CreateInstance();
			}
			return GuQinActivityController._Instance;
		}

		// Token: 0x06032BCA RID: 207818 RVA: 0x00E3FA39 File Offset: 0x00E3DC39
		public static bool CreateInstance()
		{
			if (GuQinActivityController._Instance != null)
			{
				return true;
			}
			GuQinActivityController._Instance = new GuQinActivityController();
			return true;
		}

		// Token: 0x06032BCB RID: 207819 RVA: 0x00E3FA4F File Offset: 0x00E3DC4F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032BCC RID: 207820 RVA: 0x00E3FA51 File Offset: 0x00E3DC51
		public static void ResetStaticDefaultValue()
		{
			GuQinActivityController._Instance = null;
		}

		// Token: 0x06032BCD RID: 207821 RVA: 0x00E3FA59 File Offset: 0x00E3DC59
		static GuQinActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuQinActivityController.CreateStaticDefaultValue), new Action(GuQinActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF28 RID: 110376
		[Nullable(2)]
		public GuQinActivityData Data;

		// Token: 0x0401AF29 RID: 110377
		[Nullable(2)]
		private static GuQinActivityController _Instance;
	}
}
