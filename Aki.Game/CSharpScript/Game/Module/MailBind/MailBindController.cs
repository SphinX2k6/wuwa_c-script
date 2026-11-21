using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.MailBind
{
	// Token: 0x02004679 RID: 18041
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MailBindController : UiControllerBase
	{
		// Token: 0x0602D5E9 RID: 185833 RVA: 0x00CB41E2 File Offset: 0x00CB23E2
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
		}

		// Token: 0x0602D5EA RID: 185834 RVA: 0x00CB421C File Offset: 0x00CB241C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
		}

		// Token: 0x0602D5EB RID: 185835 RVA: 0x00CB4256 File Offset: 0x00CB2456
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MailBindInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMailBindInfoNotify));
		}

		// Token: 0x0602D5EC RID: 185836 RVA: 0x00CB4274 File Offset: 0x00CB2474
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MailBindInfoNotify);
		}

		// Token: 0x0602D5ED RID: 185837 RVA: 0x00CB4286 File Offset: 0x00CB2486
		public void MainBindInfoRequest()
		{
			this.MailBindInfoRequestAsync().ContinueWith(delegate(bool result)
			{
				if (!result)
				{
					Log.Instance.Error(ELogModule.Activity, ELogAuthor.LZK, "请求邮箱绑定信息出错", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			});
		}

		// Token: 0x0602D5EE RID: 185838 RVA: 0x00CB42B4 File Offset: 0x00CB24B4
		[NullableContext(0)]
		public UniTask<bool> MailBindInfoRequestAsync()
		{
			MailBindController.<MailBindInfoRequestAsync>d__5 <MailBindInfoRequestAsync>d__;
			<MailBindInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MailBindInfoRequestAsync>d__.<>1__state = -1;
			<MailBindInfoRequestAsync>d__.<>t__builder.Start<MailBindController.<MailBindInfoRequestAsync>d__5>(ref <MailBindInfoRequestAsync>d__);
			return <MailBindInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D5EF RID: 185839 RVA: 0x00CB42F0 File Offset: 0x00CB24F0
		public void MailBindRequest()
		{
			MailBindRequest message = Aki.Protocol.MailBindRequest.Create();
			Net.Instance.Call(ERequestMessageId.MailBindRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if ((MailBindResponse)msg == null)
				{
					return;
				}
				EventSystem.Instance.Emit(EEventName.OnMailBindResponse);
			}, 0);
		}

		// Token: 0x0602D5F0 RID: 185840 RVA: 0x00CB4334 File Offset: 0x00CB2534
		public void MailBindRewardRequest()
		{
			MailBindRewardRequest message = Aki.Protocol.MailBindRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.MailBindRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MailBindRewardResponse mailBindRewardResponse = (MailBindRewardResponse)msg;
				if (mailBindRewardResponse == null)
				{
					return;
				}
				if (mailBindRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(mailBindRewardResponse.ErrorCode, 28271, null, true, true);
					return;
				}
				EventSystem.Instance.Emit(EEventName.OnMailBindRewardResponse);
			}, 0);
		}

		// Token: 0x0602D5F1 RID: 185841 RVA: 0x00CB4378 File Offset: 0x00CB2578
		[NullableContext(2)]
		private void OnMailBindInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			MailBindInfo mailBindInfo = ((MailBindInfoNotify)msg).MailBindInfo;
			if (mailBindInfo == null)
			{
				return;
			}
			MailBindModel.Instance.UpdateByProtoMailBindInfo(mailBindInfo);
			EventSystem.Instance.Emit(EEventName.OnMailBindInfoNotify);
		}

		// Token: 0x0602D5F2 RID: 185842 RVA: 0x00CB43B0 File Offset: 0x00CB25B0
		private void OnWorldDone()
		{
			this.MainBindInfoRequest();
		}

		// Token: 0x0602D5F3 RID: 185843 RVA: 0x00CB43B8 File Offset: 0x00CB25B8
		private void OnCrossDay()
		{
			if (!MailBindModel.Instance.GetIsBind())
			{
				EventSystem.Instance.Emit(EEventName.RefreshMailBindRedDot);
			}
		}

		// Token: 0x0602D5F4 RID: 185844 RVA: 0x00CB43D8 File Offset: 0x00CB25D8
		public void RecordMailBindNextShowRedDotTime()
		{
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			long? nextShowRedDotTime = MailBindModel.Instance.GetNextShowRedDotTime();
			if (nextShowRedDotTime != null && serverTimeStamp < (double)nextShowRedDotTime.Value)
			{
				return;
			}
			DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)serverTimeStamp).DateTime;
			dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 4, 0, 0, DateTimeKind.Utc);
			int dayOfWeek = (int)dateTime.DayOfWeek;
			int num = (dayOfWeek < 1) ? (1 - dayOfWeek) : (7 - (dayOfWeek - 1));
			DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime, TimeSpan.Zero);
			long nextShowRedDotTime2 = dateTimeOffset.ToUnixTimeMilliseconds() + (long)(num * 86400 * 1000);
			MailBindModel.Instance.SetNextShowRedDotTime(nextShowRedDotTime2);
			EventSystem.Instance.Emit(EEventName.RefreshMailBindRedDot);
		}

		// Token: 0x0602D5F5 RID: 185845 RVA: 0x00CB44A0 File Offset: 0x00CB26A0
		public void RecordMailBindClick()
		{
			MailBindClickEvent mailBindClickEvent = new MailBindClickEvent();
			mailBindClickEvent.i_language = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
			mailBindClickEvent.i_if_binded = ((MailBindModel.Instance.GetIsBind() > false) ? 1 : 0);
			LogReportController.Instance.LogReport(mailBindClickEvent);
		}

		// Token: 0x0602D5F6 RID: 185846 RVA: 0x00CB44F0 File Offset: 0x00CB26F0
		public void RecordMailBindJumpToWebView()
		{
			MailBindJumpToWebViewEvent mailBindJumpToWebViewEvent = new MailBindJumpToWebViewEvent();
			mailBindJumpToWebViewEvent.i_language = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
			LogReportController.Instance.LogReport(mailBindJumpToWebViewEvent);
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x0602D5F7 RID: 185847 RVA: 0x00CB452D File Offset: 0x00CB272D
		public static MailBindController Instance
		{
			get
			{
				return MailBindController._Instance;
			}
		}

		// Token: 0x0602D5F8 RID: 185848 RVA: 0x00CB4534 File Offset: 0x00CB2734
		public static MailBindController GetOrCreateInstance()
		{
			if (MailBindController._Instance == null)
			{
				MailBindController.CreateInstance();
			}
			return MailBindController._Instance;
		}

		// Token: 0x0602D5F9 RID: 185849 RVA: 0x00CB4548 File Offset: 0x00CB2748
		public static bool CreateInstance()
		{
			if (MailBindController._Instance != null)
			{
				return true;
			}
			MailBindController._Instance = new MailBindController();
			return true;
		}

		// Token: 0x0602D5FA RID: 185850 RVA: 0x00CB455E File Offset: 0x00CB275E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D5FB RID: 185851 RVA: 0x00CB4560 File Offset: 0x00CB2760
		public static void ResetStaticDefaultValue()
		{
			MailBindController._Instance = null;
		}

		// Token: 0x0602D5FC RID: 185852 RVA: 0x00CB4568 File Offset: 0x00CB2768
		static MailBindController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MailBindController.CreateStaticDefaultValue), new Action(MailBindController.ResetStaticDefaultValue));
		}

		// Token: 0x040184BF RID: 99519
		[Nullable(2)]
		private static MailBindController _Instance;
	}
}
