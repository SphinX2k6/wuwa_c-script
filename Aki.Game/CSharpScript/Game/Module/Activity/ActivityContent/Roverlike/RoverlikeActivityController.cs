using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005062 RID: 20578
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RoverlikeActivityController : ActivityControllerBase
	{
		// Token: 0x06033832 RID: 210994 RVA: 0x00E6D279 File Offset: 0x00E6B479
		protected override void OnOpenView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeMainView, data, null);
		}

		// Token: 0x06033833 RID: 210995 RVA: 0x00E6D28C File Offset: 0x00E6B48C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_RoverlikeActivity";
		}

		// Token: 0x06033834 RID: 210996 RVA: 0x00E6D293 File Offset: 0x00E6B493
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRoverlike();
		}

		// Token: 0x06033835 RID: 210997 RVA: 0x00E6D29A File Offset: 0x00E6B49A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new RoverlikeActivityData();
		}

		// Token: 0x06033836 RID: 210998 RVA: 0x00E6D2A4 File Offset: 0x00E6B4A4
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			RoverlikeActivityController.<OnOpenSubView>d__4 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<RoverlikeActivityController.<OnOpenSubView>d__4>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06033837 RID: 210999 RVA: 0x00E6D2E8 File Offset: 0x00E6B4E8
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			foreach (EUiViewName viewName in new List<EUiViewName>
			{
				EUiViewName.RoverlikeMainView,
				EUiViewName.RoverlikeLevelSelectView,
				EUiViewName.RoverlikeQuestRewardView,
				EUiViewName.RoverlikeShopView,
				EUiViewName.RoverlikeHandBookView,
				EUiViewName.RoverlikeTalentTreeView
			})
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033838 RID: 211000 RVA: 0x00E6D38C File Offset: 0x00E6B58C
		[NullableContext(2)]
		public RoverlikeActivityData GetCurrentActivityData()
		{
			ActivityModel instance = ActivityModel.Instance;
			List<ActivityBaseData> list = (instance != null) ? instance.GetActivitiesByType(112) : null;
			RoverlikeActivityData result = null;
			if (list != null)
			{
				foreach (ActivityBaseData activityBaseData in list)
				{
					result = (activityBaseData as RoverlikeActivityData);
				}
			}
			return result;
		}

		// Token: 0x06033839 RID: 211001 RVA: 0x00E6D3F4 File Offset: 0x00E6B5F4
		public int? GetCurrentActivityId()
		{
			RoverlikeActivityData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return null;
			}
			return new int?(currentActivityData.Id);
		}

		// Token: 0x0603383A RID: 211002 RVA: 0x00E6D41F File Offset: 0x00E6B61F
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoverRogueTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueTaskUpdateNotify));
		}

		// Token: 0x0603383B RID: 211003 RVA: 0x00E6D43D File Offset: 0x00E6B63D
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueTaskUpdateNotify);
		}

		// Token: 0x0603383C RID: 211004 RVA: 0x00E6D450 File Offset: 0x00E6B650
		[NullableContext(2)]
		private void OnRoverRogueTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoverRogueTaskUpdateNotify roverRogueTaskUpdateNotify = (RoverRogueTaskUpdateNotify)msg;
			RoverlikeActivityData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null || roverRogueTaskUpdateNotify == null)
			{
				return;
			}
			currentActivityData.QuestData.UpdateTasks(roverRogueTaskUpdateNotify.Tasks);
			EventSystem.Instance.Emit(EEventName.RoverlikeQuestTaskUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, currentActivityData.Id);
		}

		// Token: 0x0603383D RID: 211005 RVA: 0x00E6D4A9 File Offset: 0x00E6B6A9
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeUnlockTipView, null, null);
		}

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x0603383E RID: 211006 RVA: 0x00E6D4BC File Offset: 0x00E6B6BC
		public static RoverlikeActivityController Instance
		{
			get
			{
				return RoverlikeActivityController._Instance;
			}
		}

		// Token: 0x0603383F RID: 211007 RVA: 0x00E6D4C3 File Offset: 0x00E6B6C3
		public static RoverlikeActivityController GetOrCreateInstance()
		{
			if (RoverlikeActivityController._Instance == null)
			{
				RoverlikeActivityController.CreateInstance();
			}
			return RoverlikeActivityController._Instance;
		}

		// Token: 0x06033840 RID: 211008 RVA: 0x00E6D4D7 File Offset: 0x00E6B6D7
		public static bool CreateInstance()
		{
			if (RoverlikeActivityController._Instance != null)
			{
				return true;
			}
			RoverlikeActivityController._Instance = new RoverlikeActivityController();
			return true;
		}

		// Token: 0x06033841 RID: 211009 RVA: 0x00E6D4ED File Offset: 0x00E6B6ED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033842 RID: 211010 RVA: 0x00E6D4EF File Offset: 0x00E6B6EF
		public static void ResetStaticDefaultValue()
		{
			RoverlikeActivityController._Instance = null;
		}

		// Token: 0x06033843 RID: 211011 RVA: 0x00E6D4F7 File Offset: 0x00E6B6F7
		static RoverlikeActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeActivityController.CreateStaticDefaultValue), new Action(RoverlikeActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B5B6 RID: 112054
		[Nullable(2)]
		private static RoverlikeActivityController _Instance;
	}
}
