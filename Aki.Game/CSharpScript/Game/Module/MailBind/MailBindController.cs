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
	// Token: 0x020056A3 RID: 22179
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MailBindController : UiControllerBase
	{
		// Token: 0x060386EC RID: 231148 RVA: 0x00D66092 File Offset: 0x00D64292
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
		}

		// Token: 0x060386ED RID: 231149 RVA: 0x00D660CC File Offset: 0x00D642CC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
		}

		// Token: 0x060386EE RID: 231150 RVA: 0x00D66106 File Offset: 0x00D64306
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MailBindInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMailBindInfoNotify));
		}

		// Token: 0x060386EF RID: 231151 RVA: 0x00D66124 File Offset: 0x00D64324
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MailBindInfoNotify);
		}

		// Token: 0x060386F0 RID: 231152 RVA: 0x00D66136 File Offset: 0x00D64336
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

		// Token: 0x060386F1 RID: 231153 RVA: 0x00D66164 File Offset: 0x00D64364
		[NullableContext(0)]
		public UniTask<bool> MailBindInfoRequestAsync()
		{
			MailBindController.<MailBindInfoRequestAsync>d__5 <MailBindInfoRequestAsync>d__;
			<MailBindInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MailBindInfoRequestAsync>d__.<>1__state = -1;
			<MailBindInfoRequestAsync>d__.<>t__builder.Start<MailBindController.<MailBindInfoRequestAsync>d__5>(ref <MailBindInfoRequestAsync>d__);
			return <MailBindInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386F2 RID: 231154 RVA: 0x00D661A0 File Offset: 0x00D643A0
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

		// Token: 0x060386F3 RID: 231155 RVA: 0x00D661E4 File Offset: 0x00D643E4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(mailBindRewardResponse.ErrorCode, 19056, null, true, true);
					return;
				}
				EventSystem.Instance.Emit(EEventName.OnMailBindRewardResponse);
			}, 0);
		}

		// Token: 0x060386F4 RID: 231156 RVA: 0x00D66228 File Offset: 0x00D64428
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

		// Token: 0x060386F5 RID: 231157 RVA: 0x00D66260 File Offset: 0x00D64460
		private void OnWorldDone()
		{
			this.MainBindInfoRequest();
		}

		// Token: 0x060386F6 RID: 231158 RVA: 0x00D66268 File Offset: 0x00D64468
		private void OnCrossDay()
		{
			if (!MailBindModel.Instance.GetIsBind())
			{
				EventSystem.Instance.Emit(EEventName.RefreshMailBindRedDot);
			}
		}

		// Token: 0x060386F7 RID: 231159 RVA: 0x00D66288 File Offset: 0x00D64488
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

		// Token: 0x060386F8 RID: 231160 RVA: 0x00D66350 File Offset: 0x00D64550
		public void RecordMailBindClick()
		{
			MailBindClickEvent mailBindClickEvent = new MailBindClickEvent();
			mailBindClickEvent.i_language = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
			mailBindClickEvent.i_if_binded = ((MailBindModel.Instance.GetIsBind() > false) ? 1 : 0);
			LogReportController.Instance.LogReport(mailBindClickEvent);
		}

		// Token: 0x060386F9 RID: 231161 RVA: 0x00D663A0 File Offset: 0x00D645A0
		public void RecordMailBindJumpToWebView()
		{
			MailBindJumpToWebViewEvent mailBindJumpToWebViewEvent = new MailBindJumpToWebViewEvent();
			mailBindJumpToWebViewEvent.i_language = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
			LogReportController.Instance.LogReport(mailBindJumpToWebViewEvent);
		}

		// Token: 0x1700878C RID: 34700
		// (get) Token: 0x060386FA RID: 231162 RVA: 0x00D663DD File Offset: 0x00D645DD
		public static MailBindController Instance
		{
			get
			{
				return MailBindController._Instance;
			}
		}

		// Token: 0x060386FB RID: 231163 RVA: 0x00D663E4 File Offset: 0x00D645E4
		public static MailBindController GetOrCreateInstance()
		{
			if (MailBindController._Instance == null)
			{
				MailBindController.CreateInstance();
			}
			return MailBindController._Instance;
		}

		// Token: 0x060386FC RID: 231164 RVA: 0x00D663F8 File Offset: 0x00D645F8
		public static bool CreateInstance()
		{
			if (MailBindController._Instance != null)
			{
				return true;
			}
			MailBindController._Instance = new MailBindController();
			return true;
		}

		// Token: 0x060386FD RID: 231165 RVA: 0x00D6640E File Offset: 0x00D6460E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060386FE RID: 231166 RVA: 0x00D66410 File Offset: 0x00D64610
		public static void ResetStaticDefaultValue()
		{
			MailBindController._Instance = null;
		}

		// Token: 0x060386FF RID: 231167 RVA: 0x00D66418 File Offset: 0x00D64618
		static MailBindController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MailBindController.CreateStaticDefaultValue), new Action(MailBindController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DA34 RID: 121396
		[Nullable(2)]
		private static MailBindController _Instance;
	}
}
