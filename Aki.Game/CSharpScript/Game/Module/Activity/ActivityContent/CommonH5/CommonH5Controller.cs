using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x020068F2 RID: 26866
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonH5Controller : ActivityControllerBase
	{
		// Token: 0x06043018 RID: 274456 RVA: 0x010525AD File Offset: 0x010507AD
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06043019 RID: 274457 RVA: 0x010525AF File Offset: 0x010507AF
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_H5Main";
		}

		// Token: 0x0604301A RID: 274458 RVA: 0x010525B6 File Offset: 0x010507B6
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new CommonH5Data();
		}

		// Token: 0x0604301B RID: 274459 RVA: 0x010525C9 File Offset: 0x010507C9
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0604301C RID: 274460 RVA: 0x010525CC File Offset: 0x010507CC
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CommonH5SubView();
		}

		// Token: 0x0604301D RID: 274461 RVA: 0x010525D3 File Offset: 0x010507D3
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.H5ViewActivityDataNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
		}

		// Token: 0x0604301E RID: 274462 RVA: 0x010525F1 File Offset: 0x010507F1
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.H5ViewActivityDataNotify);
		}

		// Token: 0x0604301F RID: 274463 RVA: 0x01052604 File Offset: 0x01050804
		[NullableContext(2)]
		private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			H5ViewActivityDataNotify data = (H5ViewActivityDataNotify)msg;
			CommonH5Model.Instance.OnActivityDataNotify(data);
		}

		// Token: 0x06043020 RID: 274464 RVA: 0x01052624 File Offset: 0x01050824
		private void RequestSaveReadState()
		{
			H5ViewActivityReadRequest message = H5ViewActivityReadRequest.Create();
			Net.Instance.Call(ERequestMessageId.H5ViewActivityReadRequest, message, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06043021 RID: 274465 RVA: 0x01052667 File Offset: 0x01050867
		[NullableContext(2)]
		public void HandleOnEnterClick(CommonH5Data activityData)
		{
			if (activityData != null)
			{
				activityData.SetCurrentLoginClickState(true);
			}
			this.OpenUrl(activityData);
		}

		// Token: 0x06043022 RID: 274466 RVA: 0x0105267C File Offset: 0x0105087C
		[NullableContext(2)]
		private void OpenUrl(CommonH5Data data)
		{
			if (data == null)
			{
				return;
			}
			string text = data.GetRootUrl();
			if (text == null)
			{
				Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "无法获取根链接", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			text = PublicUtil.Instance.GetExternalUrl(text, PublicUtil.EExternalUrlReason.CommonH5);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "打开外部链接";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (text != null)
			{
				CommonH5Model.Instance.SaveClickRedDotState();
				this.RequestSaveReadState();
				EventSystem.Instance.Emit(EEventName.RefreshCommonH5ActivityRedDot);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
				if (KuroSdkController.Instance.CanUseSdk())
				{
					text = PublicUtil.Instance.GetExtendExternalUrl(text, true);
					KuroSdkController.Instance.OpenWebView("", text, true, true, true, "Default");
					return;
				}
				text = PublicUtil.Instance.GetExtendExternalUrl(text, false);
				KuroSdkController.Instance.OpenExternalUrl(text);
			}
		}

		// Token: 0x170097E5 RID: 38885
		// (get) Token: 0x06043023 RID: 274467 RVA: 0x01052774 File Offset: 0x01050974
		public static CommonH5Controller Instance
		{
			get
			{
				return CommonH5Controller._Instance;
			}
		}

		// Token: 0x06043024 RID: 274468 RVA: 0x0105277B File Offset: 0x0105097B
		public static CommonH5Controller GetOrCreateInstance()
		{
			if (CommonH5Controller._Instance == null)
			{
				CommonH5Controller.CreateInstance();
			}
			return CommonH5Controller._Instance;
		}

		// Token: 0x06043025 RID: 274469 RVA: 0x0105278F File Offset: 0x0105098F
		public static bool CreateInstance()
		{
			if (CommonH5Controller._Instance != null)
			{
				return true;
			}
			CommonH5Controller._Instance = new CommonH5Controller();
			return true;
		}

		// Token: 0x06043026 RID: 274470 RVA: 0x010527A5 File Offset: 0x010509A5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043027 RID: 274471 RVA: 0x010527A7 File Offset: 0x010509A7
		public static void ResetStaticDefaultValue()
		{
			CommonH5Controller._Instance = null;
		}

		// Token: 0x06043028 RID: 274472 RVA: 0x010527AF File Offset: 0x010509AF
		static CommonH5Controller()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonH5Controller.CreateStaticDefaultValue), new Action(CommonH5Controller.ResetStaticDefaultValue));
		}

		// Token: 0x04022E2A RID: 142890
		public int ActivityId;

		// Token: 0x04022E2B RID: 142891
		[Nullable(2)]
		private static CommonH5Controller _Instance;
	}
}
