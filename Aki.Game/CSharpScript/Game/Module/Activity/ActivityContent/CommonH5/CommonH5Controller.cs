using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x02005842 RID: 22594
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonH5Controller : ActivityControllerBase
	{
		// Token: 0x06037B70 RID: 228208 RVA: 0x00F93BD5 File Offset: 0x00F91DD5
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06037B71 RID: 228209 RVA: 0x00F93BD7 File Offset: 0x00F91DD7
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_H5Main";
		}

		// Token: 0x06037B72 RID: 228210 RVA: 0x00F93BDE File Offset: 0x00F91DDE
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new CommonH5Data();
		}

		// Token: 0x06037B73 RID: 228211 RVA: 0x00F93BF1 File Offset: 0x00F91DF1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06037B74 RID: 228212 RVA: 0x00F93BF4 File Offset: 0x00F91DF4
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new CommonH5SubView();
		}

		// Token: 0x06037B75 RID: 228213 RVA: 0x00F93BFB File Offset: 0x00F91DFB
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.H5ViewActivityDataNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
		}

		// Token: 0x06037B76 RID: 228214 RVA: 0x00F93C19 File Offset: 0x00F91E19
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.H5ViewActivityDataNotify);
		}

		// Token: 0x06037B77 RID: 228215 RVA: 0x00F93C2C File Offset: 0x00F91E2C
		[NullableContext(2)]
		private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			H5ViewActivityDataNotify data = (H5ViewActivityDataNotify)msg;
			CommonH5Model.Instance.OnActivityDataNotify(data);
		}

		// Token: 0x06037B78 RID: 228216 RVA: 0x00F93C4C File Offset: 0x00F91E4C
		private void RequestSaveReadState()
		{
			H5ViewActivityReadRequest message = H5ViewActivityReadRequest.Create();
			Net.Instance.Call(ERequestMessageId.H5ViewActivityReadRequest, message, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06037B79 RID: 228217 RVA: 0x00F93C8F File Offset: 0x00F91E8F
		[NullableContext(2)]
		public void HandleOnEnterClick(CommonH5Data activityData)
		{
			if (activityData != null)
			{
				activityData.SetCurrentLoginClickState(true);
			}
			this.OpenUrl(activityData);
		}

		// Token: 0x06037B7A RID: 228218 RVA: 0x00F93CA4 File Offset: 0x00F91EA4
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

		// Token: 0x17006B25 RID: 27429
		// (get) Token: 0x06037B7B RID: 228219 RVA: 0x00F93D9C File Offset: 0x00F91F9C
		public static CommonH5Controller Instance
		{
			get
			{
				return CommonH5Controller._Instance;
			}
		}

		// Token: 0x06037B7C RID: 228220 RVA: 0x00F93DA3 File Offset: 0x00F91FA3
		public static CommonH5Controller GetOrCreateInstance()
		{
			if (CommonH5Controller._Instance == null)
			{
				CommonH5Controller.CreateInstance();
			}
			return CommonH5Controller._Instance;
		}

		// Token: 0x06037B7D RID: 228221 RVA: 0x00F93DB7 File Offset: 0x00F91FB7
		public static bool CreateInstance()
		{
			if (CommonH5Controller._Instance != null)
			{
				return true;
			}
			CommonH5Controller._Instance = new CommonH5Controller();
			return true;
		}

		// Token: 0x06037B7E RID: 228222 RVA: 0x00F93DCD File Offset: 0x00F91FCD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037B7F RID: 228223 RVA: 0x00F93DCF File Offset: 0x00F91FCF
		public static void ResetStaticDefaultValue()
		{
			CommonH5Controller._Instance = null;
		}

		// Token: 0x06037B80 RID: 228224 RVA: 0x00F93DD7 File Offset: 0x00F91FD7
		static CommonH5Controller()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonH5Controller.CreateStaticDefaultValue), new Action(CommonH5Controller.ResetStaticDefaultValue));
		}

		// Token: 0x0401D686 RID: 120454
		public int ActivityId;

		// Token: 0x0401D687 RID: 120455
		[Nullable(2)]
		private static CommonH5Controller _Instance;
	}
}
