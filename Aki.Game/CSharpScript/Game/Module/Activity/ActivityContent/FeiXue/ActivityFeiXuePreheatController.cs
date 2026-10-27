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
	// Token: 0x02006633 RID: 26163
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFeiXuePreheatController : ActivityControllerBase
	{
		// Token: 0x0604195B RID: 268635 RVA: 0x00FE8385 File Offset: 0x00FE6585
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0604195C RID: 268636 RVA: 0x00FE8387 File Offset: 0x00FE6587
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FeixueMain";
		}

		// Token: 0x0604195D RID: 268637 RVA: 0x00FE838E File Offset: 0x00FE658E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewFeiXuePreheat();
		}

		// Token: 0x0604195E RID: 268638 RVA: 0x00FE8395 File Offset: 0x00FE6595
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityFeiXuePreheatData();
		}

		// Token: 0x0604195F RID: 268639 RVA: 0x00FE83A8 File Offset: 0x00FE65A8
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06041960 RID: 268640 RVA: 0x00FE83AB File Offset: 0x00FE65AB
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FeiXuePreheatInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFeiXuePreheatInfoUpdateNotify));
		}

		// Token: 0x06041961 RID: 268641 RVA: 0x00FE83C9 File Offset: 0x00FE65C9
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FeiXuePreheatInfoUpdateNotify);
		}

		// Token: 0x06041962 RID: 268642 RVA: 0x00FE83DC File Offset: 0x00FE65DC
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

		// Token: 0x06041963 RID: 268643 RVA: 0x00FE843C File Offset: 0x00FE663C
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

		// Token: 0x06041964 RID: 268644 RVA: 0x00FE84B4 File Offset: 0x00FE66B4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(feiXuePreheatInfoRewardResponse.ErrorCode, 22363, null, true, true);
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

		// Token: 0x06041965 RID: 268645 RVA: 0x00FE8520 File Offset: 0x00FE6720
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

		// Token: 0x1700960B RID: 38411
		// (get) Token: 0x06041966 RID: 268646 RVA: 0x00FE856B File Offset: 0x00FE676B
		public static ActivityFeiXuePreheatController Instance
		{
			get
			{
				return ActivityFeiXuePreheatController._Instance;
			}
		}

		// Token: 0x06041967 RID: 268647 RVA: 0x00FE8572 File Offset: 0x00FE6772
		public static ActivityFeiXuePreheatController GetOrCreateInstance()
		{
			if (ActivityFeiXuePreheatController._Instance == null)
			{
				ActivityFeiXuePreheatController.CreateInstance();
			}
			return ActivityFeiXuePreheatController._Instance;
		}

		// Token: 0x06041968 RID: 268648 RVA: 0x00FE8586 File Offset: 0x00FE6786
		public static bool CreateInstance()
		{
			if (ActivityFeiXuePreheatController._Instance != null)
			{
				return true;
			}
			ActivityFeiXuePreheatController._Instance = new ActivityFeiXuePreheatController();
			return true;
		}

		// Token: 0x06041969 RID: 268649 RVA: 0x00FE859C File Offset: 0x00FE679C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604196A RID: 268650 RVA: 0x00FE859E File Offset: 0x00FE679E
		public static void ResetStaticDefaultValue()
		{
			ActivityFeiXuePreheatController._Instance = null;
		}

		// Token: 0x0604196B RID: 268651 RVA: 0x00FE85A6 File Offset: 0x00FE67A6
		static ActivityFeiXuePreheatController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFeiXuePreheatController.CreateStaticDefaultValue), new Action(ActivityFeiXuePreheatController.ResetStaticDefaultValue));
		}

		// Token: 0x040221EE RID: 139758
		public int ActivityId;

		// Token: 0x040221EF RID: 139759
		[Nullable(2)]
		private static ActivityFeiXuePreheatController _Instance;
	}
}
