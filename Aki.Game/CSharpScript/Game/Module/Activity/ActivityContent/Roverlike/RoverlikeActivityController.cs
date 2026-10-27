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
	// Token: 0x020060E4 RID: 24804
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class RoverlikeActivityController : ActivityControllerBase
	{
		// Token: 0x0603EB70 RID: 256880 RVA: 0x00F263E1 File Offset: 0x00F245E1
		protected override void OnOpenView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeMainView, data, null);
		}

		// Token: 0x0603EB71 RID: 256881 RVA: 0x00F263F4 File Offset: 0x00F245F4
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_RoverlikeActivity";
		}

		// Token: 0x0603EB72 RID: 256882 RVA: 0x00F263FB File Offset: 0x00F245FB
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRoverlike();
		}

		// Token: 0x0603EB73 RID: 256883 RVA: 0x00F26402 File Offset: 0x00F24602
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new RoverlikeActivityData();
		}

		// Token: 0x0603EB74 RID: 256884 RVA: 0x00F2640C File Offset: 0x00F2460C
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

		// Token: 0x0603EB75 RID: 256885 RVA: 0x00F26450 File Offset: 0x00F24650
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

		// Token: 0x0603EB76 RID: 256886 RVA: 0x00F264F4 File Offset: 0x00F246F4
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

		// Token: 0x0603EB77 RID: 256887 RVA: 0x00F2655C File Offset: 0x00F2475C
		public int? GetCurrentActivityId()
		{
			RoverlikeActivityData currentActivityData = this.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return null;
			}
			return new int?(currentActivityData.Id);
		}

		// Token: 0x0603EB78 RID: 256888 RVA: 0x00F26587 File Offset: 0x00F24787
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoverRogueTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueTaskUpdateNotify));
		}

		// Token: 0x0603EB79 RID: 256889 RVA: 0x00F265A5 File Offset: 0x00F247A5
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueTaskUpdateNotify);
		}

		// Token: 0x0603EB7A RID: 256890 RVA: 0x00F265B8 File Offset: 0x00F247B8
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

		// Token: 0x0603EB7B RID: 256891 RVA: 0x00F26611 File Offset: 0x00F24811
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeUnlockTipView, null, null);
		}

		// Token: 0x17009142 RID: 37186
		// (get) Token: 0x0603EB7C RID: 256892 RVA: 0x00F26624 File Offset: 0x00F24824
		public static RoverlikeActivityController Instance
		{
			get
			{
				return RoverlikeActivityController._Instance;
			}
		}

		// Token: 0x0603EB7D RID: 256893 RVA: 0x00F2662B File Offset: 0x00F2482B
		public static RoverlikeActivityController GetOrCreateInstance()
		{
			if (RoverlikeActivityController._Instance == null)
			{
				RoverlikeActivityController.CreateInstance();
			}
			return RoverlikeActivityController._Instance;
		}

		// Token: 0x0603EB7E RID: 256894 RVA: 0x00F2663F File Offset: 0x00F2483F
		public static bool CreateInstance()
		{
			if (RoverlikeActivityController._Instance != null)
			{
				return true;
			}
			RoverlikeActivityController._Instance = new RoverlikeActivityController();
			return true;
		}

		// Token: 0x0603EB7F RID: 256895 RVA: 0x00F26655 File Offset: 0x00F24855
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603EB80 RID: 256896 RVA: 0x00F26657 File Offset: 0x00F24857
		public static void ResetStaticDefaultValue()
		{
			RoverlikeActivityController._Instance = null;
		}

		// Token: 0x0603EB81 RID: 256897 RVA: 0x00F2665F File Offset: 0x00F2485F
		static RoverlikeActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeActivityController.CreateStaticDefaultValue), new Action(RoverlikeActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04020C89 RID: 134281
		[Nullable(2)]
		private static RoverlikeActivityController _Instance;
	}
}
