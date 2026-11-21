using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055B1 RID: 21937
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFeiXuePreheatController : ActivityControllerBase
	{
		// Token: 0x06036620 RID: 222752 RVA: 0x00F2F43D File Offset: 0x00F2D63D
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06036621 RID: 222753 RVA: 0x00F2F43F File Offset: 0x00F2D63F
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FeixueMain";
		}

		// Token: 0x06036622 RID: 222754 RVA: 0x00F2F446 File Offset: 0x00F2D646
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewFeiXuePreheat();
		}

		// Token: 0x06036623 RID: 222755 RVA: 0x00F2F44D File Offset: 0x00F2D64D
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityFeiXuePreheatData();
		}

		// Token: 0x06036624 RID: 222756 RVA: 0x00F2F460 File Offset: 0x00F2D660
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06036625 RID: 222757 RVA: 0x00F2F463 File Offset: 0x00F2D663
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FeiXuePreheatInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFeiXuePreheatInfoUpdateNotify));
		}

		// Token: 0x06036626 RID: 222758 RVA: 0x00F2F481 File Offset: 0x00F2D681
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FeiXuePreheatInfoUpdateNotify);
		}

		// Token: 0x06036627 RID: 222759 RVA: 0x00F2F494 File Offset: 0x00F2D694
		[NullableContext(2)]
		public ActivityFeiXuePreheatData GetActivityData()
		{
			ActivityFeiXuePreheatData activityFeiXuePreheatData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityFeiXuePreheatData;
			if (activityFeiXuePreheatData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "飞雪预热活动数据更新错误，没有活动数据:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId:", this.ActivityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return activityFeiXuePreheatData;
		}

		// Token: 0x06036628 RID: 222760 RVA: 0x00F2F4F4 File Offset: 0x00F2D6F4
		[NullableContext(2)]
		protected void OnFeiXuePreheatInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			FeiXuePreheatInfoUpdateNotify feiXuePreheatInfoUpdateNotify = (FeiXuePreheatInfoUpdateNotify)msg;
			ActivityFeiXuePreheatData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			foreach (FeiXuePreheatInfo info in feiXuePreheatInfoUpdateNotify.FeiXuePreheatInfos)
			{
				activityData.UpdateFeiXuePreheatInfo(info);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06036629 RID: 222761 RVA: 0x00F2F56C File Offset: 0x00F2D76C
		[NullableContext(2)]
		public void RequestTaskReward(int actId, Action callback = null)
		{
			ActivityFeiXuePreheatData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			FeiXuePreheatInfoRewardRequest feiXuePreheatInfoRewardRequest = FeiXuePreheatInfoRewardRequest.Create();
			feiXuePreheatInfoRewardRequest.ActivityId = actId;
			List<int> claimableTaskIdList = activityData.GetClaimableTaskIdList();
			feiXuePreheatInfoRewardRequest.FeiXuePreheatInfoIds.AddRange(claimableTaskIdList);
			Net.Instance.Call(ERequestMessageId.FeiXuePreheatInfoRewardRequest, feiXuePreheatInfoRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FeiXuePreheatInfoRewardResponse feiXuePreheatInfoRewardResponse = (FeiXuePreheatInfoRewardResponse)msg;
				if (feiXuePreheatInfoRewardResponse == null)
				{
					return;
				}
				if (feiXuePreheatInfoRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(feiXuePreheatInfoRewardResponse.ErrorCode, 26680, null, true, true);
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, 0);
		}

		// Token: 0x0603662A RID: 222762 RVA: 0x00F2F5D8 File Offset: 0x00F2D7D8
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityFeiXuePreheatController.<OnOpenSubView>d__11 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityFeiXuePreheatController.<OnOpenSubView>d__11>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x1700696D RID: 26989
		// (get) Token: 0x0603662B RID: 222763 RVA: 0x00F2F623 File Offset: 0x00F2D823
		public static ActivityFeiXuePreheatController Instance
		{
			get
			{
				return ActivityFeiXuePreheatController._Instance;
			}
		}

		// Token: 0x0603662C RID: 222764 RVA: 0x00F2F62A File Offset: 0x00F2D82A
		public static ActivityFeiXuePreheatController GetOrCreateInstance()
		{
			if (ActivityFeiXuePreheatController._Instance == null)
			{
				ActivityFeiXuePreheatController.CreateInstance();
			}
			return ActivityFeiXuePreheatController._Instance;
		}

		// Token: 0x0603662D RID: 222765 RVA: 0x00F2F63E File Offset: 0x00F2D83E
		public static bool CreateInstance()
		{
			if (ActivityFeiXuePreheatController._Instance != null)
			{
				return true;
			}
			ActivityFeiXuePreheatController._Instance = new ActivityFeiXuePreheatController();
			return true;
		}

		// Token: 0x0603662E RID: 222766 RVA: 0x00F2F654 File Offset: 0x00F2D854
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603662F RID: 222767 RVA: 0x00F2F656 File Offset: 0x00F2D856
		public static void ResetStaticDefaultValue()
		{
			ActivityFeiXuePreheatController._Instance = null;
		}

		// Token: 0x06036630 RID: 222768 RVA: 0x00F2F65E File Offset: 0x00F2D85E
		static ActivityFeiXuePreheatController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFeiXuePreheatController.CreateStaticDefaultValue), new Action(ActivityFeiXuePreheatController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CB1F RID: 117535
		public int ActivityId;

		// Token: 0x0401CB20 RID: 117536
		[Nullable(2)]
		private static ActivityFeiXuePreheatController _Instance;
	}
}
