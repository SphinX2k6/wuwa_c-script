using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.NetworkDetection;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004405 RID: 17413
	[NullableContext(2)]
	[Nullable(0)]
	public class LogUploadView : UiViewBase
	{
		// Token: 0x0602BFCB RID: 180171 RVA: 0x00C596DB File Offset: 0x00C578DB
		[NullableContext(1)]
		public LogUploadView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BFCC RID: 180172 RVA: 0x00C596EC File Offset: 0x00C578EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnUploadConfirmToggleClick))
			};
		}

		// Token: 0x0602BFCD RID: 180173 RVA: 0x00C597C1 File Offset: 0x00C579C1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SdkCustomerRedPointRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0602BFCE RID: 180174 RVA: 0x00C597DF File Offset: 0x00C579DF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SdkCustomerRedPointRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0602BFCF RID: 180175 RVA: 0x00C59800 File Offset: 0x00C57A00
		protected void RefreshRedDot()
		{
			bool customerServiceRedPointState = global::KuroSdkController.Instance.GetCustomerServiceRedPointState();
			ButtonItem contactButton = this.ContactButton;
			if (contactButton == null)
			{
				return;
			}
			contactButton.SetRedDotVisible(customerServiceRedPointState);
		}

		// Token: 0x0602BFD0 RID: 180176 RVA: 0x00C5982C File Offset: 0x00C57A2C
		protected override void OnStart()
		{
			if (this.OpenParam != null)
			{
				ILogUploadOpenParam logUploadOpenParam = this.OpenParam as ILogUploadOpenParam;
				if (logUploadOpenParam != null)
				{
					this.OpenSourceType = logUploadOpenParam.OpenSourceType.GetValueOrDefault(EKuroSdkOpenCustomerServerType.Login);
					this.AutoStartUpload = logUploadOpenParam.AutoStartUpload.GetValueOrDefault();
					this.ErrorCode = logUploadOpenParam.ErrorCode;
				}
			}
			this.TextDescription = base.GetText(0);
			this.SpriteProgress = base.GetSprite(2);
			this.ContactButton = new ButtonItem(base.GetItem(3));
			this.ContactButton.SetFunction(new Action<int>(this.OnOpenCustomerService));
			this.ContactButton.SetShowText("Text_LogUploadService_Text");
			this.ContactButton.SetActive(false);
			this.RefreshRedDot();
			this.ConfirmButton = new ButtonItem(base.GetItem(4));
			this.ConfirmButton.SetFunction(new Action<int>(this.OnConfirm));
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
			}
			if (!this.AutoStartUpload)
			{
				this.UploadState = EUploadState.Wait;
				return;
			}
			this.IsConfirmUpload = true;
			if (this.CheckTimeIntervalLegal())
			{
				this.UploadState = EUploadState.Uploading;
				this.StartUploadLog();
				return;
			}
			this.UploadState = EUploadState.Wait;
		}

		// Token: 0x0602BFD1 RID: 180177 RVA: 0x00C59969 File Offset: 0x00C57B69
		protected override void OnBeforeDestroy()
		{
			this.ClearDelegate();
			this.TextDescription = null;
			this.SpriteProgress = null;
			ButtonItem contactButton = this.ContactButton;
			if (contactButton == null)
			{
				return;
			}
			contactButton.Destroy(null);
		}

		// Token: 0x0602BFD2 RID: 180178 RVA: 0x00C59990 File Offset: 0x00C57B90
		private void OnUploadConfirmToggleClick(EToggleState state)
		{
			if (this.AutoStartUpload)
			{
				return;
			}
			this.IsConfirmUpload = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x0602BFD3 RID: 180179 RVA: 0x00C599A5 File Offset: 0x00C57BA5
		private void OnOpenCustomerService(int _)
		{
			if (this.OpenSourceType == EKuroSdkOpenCustomerServerType.Setting)
			{
				LogController.Instance.RequestOutputDebugInfo();
			}
			global::KuroSdkController.Instance.OpenCustomerService(this.OpenSourceType);
		}

		// Token: 0x0602BFD4 RID: 180180 RVA: 0x00C599CC File Offset: 0x00C57BCC
		private void OnConfirm(int _)
		{
			switch (this.UploadState)
			{
			case EUploadState.Wait:
				if (!this.IsConfirmUpload)
				{
					GenericPromptController.Instance.ShowPromptByCode("LogUploadConfirmTip", Array.Empty<object>());
					return;
				}
				if (!this.CheckTimeIntervalLegal())
				{
					GenericPromptController.Instance.ShowPromptByCode("LogUploadLimited", Array.Empty<object>());
					return;
				}
				this.UploadState = EUploadState.Uploading;
				this.StartUploadLog();
				return;
			case EUploadState.Uploading:
				if (this.InterruptUploadLog())
				{
					this.UploadState = EUploadState.Wait;
					return;
				}
				break;
			case EUploadState.FinishAndSuccess:
				this.OnClose();
				return;
			case EUploadState.FinishAndFailed:
				this.UploadState = EUploadState.Uploading;
				this.StartUploadLog();
				break;
			default:
				return;
			}
		}

		// Token: 0x0602BFD5 RID: 180181 RVA: 0x00C59A63 File Offset: 0x00C57C63
		private void OnClose()
		{
			if (this.UploadState == EUploadState.Uploading && !this.InterruptUploadLog())
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602BFD6 RID: 180182 RVA: 0x00C59A7E File Offset: 0x00C57C7E
		private void TrySetContactButtonVisible(bool bVisible)
		{
			if (!bVisible)
			{
				this.ContactButton.SetActive(false);
				return;
			}
			if (!global::KuroSdkController.Instance.NeedShowCustomerService())
			{
				this.ContactButton.SetActive(false);
				return;
			}
			this.ContactButton.SetActive(true);
		}

		// Token: 0x0602BFD7 RID: 180183 RVA: 0x00C59AB5 File Offset: 0x00C57CB5
		private void ClearDelegate()
		{
			UKuroTencentCOSLibrary.ClearAllProgressCallback();
			if (this.UploadDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<ESendState, float>(this.UploadEventCallBack));
				this.UploadDelegate = null;
			}
		}

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x0602BFD8 RID: 180184 RVA: 0x00C59ADC File Offset: 0x00C57CDC
		// (set) Token: 0x0602BFD9 RID: 180185 RVA: 0x00C59AE4 File Offset: 0x00C57CE4
		private EUploadState UploadState
		{
			get
			{
				return this.InnerUploadState;
			}
			set
			{
				this.InnerUploadState = value;
				UUIExtendToggle extendToggle = base.GetExtendToggle(6);
				UUIItem item = base.GetItem(1);
				UUISprite sprite = base.GetSprite(5);
				switch (this.InnerUploadState)
				{
				case EUploadState.Wait:
				{
					this.TrySetContactButtonVisible(true);
					this.ConfirmButton.SetShowText("Text_LogUpload_Text");
					this.TextDescription.ShowTextNew("Text_LogUploadConfirm_Text");
					this.TextDescription.SetUIActive(true);
					string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_UploadState1");
					this.SetSpriteByPath(resourcePath, sprite, false, null, null);
					extendToggle.RootUIComp.Get().SetUIActive(!this.AutoStartUpload);
					item.SetUIActive(false);
					return;
				}
				case EUploadState.Uploading:
				{
					this.TrySetContactButtonVisible(false);
					this.ConfirmButton.SetShowText("Text_LogUploadCancel_Text");
					this.TextDescription.SetText("", true);
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_UploadState2");
					this.SetSpriteByPath(resourcePath2, sprite, false, null, null);
					extendToggle.RootUIComp.Get().SetUIActive(false);
					item.SetUIActive(true);
					return;
				}
				case EUploadState.FinishAndSuccess:
				{
					this.TrySetContactButtonVisible(true);
					this.ConfirmButton.SetShowText("Text_LogUploadYes_Text");
					this.TextDescription.ShowTextNew("Text_LogUploadSuccess_Text");
					string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("SP_UploadState3");
					this.SetSpriteByPath(resourcePath3, sprite, false, null, null);
					extendToggle.RootUIComp.Get().SetUIActive(false);
					item.SetUIActive(false);
					return;
				}
				case EUploadState.FinishAndFailed:
				{
					this.TrySetContactButtonVisible(true);
					this.ConfirmButton.SetShowText("Text_LogUploadRetry_Text");
					int allFileNumNeedToSend = UKuroTencentCOSLibrary.GetAllFileNumNeedToSend();
					int sendedFileNum = UKuroTencentCOSLibrary.GetSendedFileNum();
					int num = allFileNumNeedToSend - sendedFileNum;
					LguiUtil.Instance.SetLocalTextNew(this.TextDescription, "Text_LogUploadFail_Text", new <>z__ReadOnlyArray<object>(new object[]
					{
						num,
						allFileNumNeedToSend
					}));
					string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("SP_UploadState1");
					this.SetSpriteByPath(resourcePath4, sprite, false, null, null);
					extendToggle.RootUIComp.Get().SetUIActive(false);
					item.SetUIActive(false);
					return;
				}
				default:
					return;
				}
			}
		}

		// Token: 0x0602BFDA RID: 180186 RVA: 0x00C59D24 File Offset: 0x00C57F24
		private unsafe bool CheckTimeIntervalLegal()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("LogUploadTimeInterval");
			double serverTime = TimeUtil.Instance.GetServerTime();
			double? num = null;
			if (global::Net.Instance.IsServerConnected())
			{
				num = new double?(CSharpScript.Game.Common.LocalStorage.GetPlayer<double>(ELocalStoragePlayerKey.LastTimeUploadStamp, 0.0));
			}
			else
			{
				num = new double?(CSharpScript.Game.Common.LocalStorage.GetGlobal<double>(ELocalStorageGlobalKey.LastTimeUploadStamp, 0.0));
			}
			if (num == null)
			{
				return true;
			}
			double num2 = serverTime - num.Value;
			int? num3 = intConfig;
			double? num4 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
			if (num2 > num4.GetValueOrDefault() & num4 != null)
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[LogUpload] 上传时间不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastTimeStamp", num.Value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentTimeStamp", serverTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x0602BFDB RID: 180187 RVA: 0x00C59E44 File Offset: 0x00C58044
		private void StartUploadLog()
		{
			this.Rate = 0f;
			this.SpriteProgress.SetFillAmount(0f);
			this.ClearDelegate();
			if (this.UploadDelegate == null)
			{
				this.UploadDelegate = DelegateUtils.ToManualReleaseDelegate<FOnProgress>(new Action<ESendState, float>(this.UploadEventCallBack));
			}
			if (this.OpenSourceType == EKuroSdkOpenCustomerServerType.Setting)
			{
				LogController.Instance.RequestOutputDebugInfo();
			}
			if (this.ErrorCode != null)
			{
				LauncherLogUpload.Instance.SendLog(this.UploadDelegate, new SendLogReason
				{
					Reason = ELauncherLogUploadReason.ErrorPopupWithCode,
					Info = this.ErrorCode.Value.ToString()
				});
				return;
			}
			if (this.AutoStartUpload)
			{
				LauncherLogUpload.Instance.SendLog(this.UploadDelegate, new SendLogReason
				{
					Reason = ELauncherLogUploadReason.ErrorPopup
				});
				return;
			}
			LauncherLogUpload.Instance.SendLog(this.UploadDelegate, new SendLogReason
			{
				Reason = ELauncherLogUploadReason.Manual
			});
		}

		// Token: 0x0602BFDC RID: 180188 RVA: 0x00C59F28 File Offset: 0x00C58128
		private bool InterruptUploadLog()
		{
			if (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Compressing)
			{
				GenericPromptController.Instance.ShowPromptByCode("LogUploadCompressingTip", Array.Empty<object>());
				return false;
			}
			if (UKuroTencentCOSLibrary.IsSending())
			{
				UKuroTencentCOSLibrary.InterruptSending();
				GenericPromptController.Instance.ShowPromptByCode("LogUploadCancelTip", Array.Empty<object>());
				return true;
			}
			return false;
		}

		// Token: 0x0602BFDD RID: 180189 RVA: 0x00C59F7C File Offset: 0x00C5817C
		private unsafe void FinishUploadLog()
		{
			this.ClearDelegate();
			bool flag = this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Done;
			this.UploadState = (flag ? EUploadState.FinishAndSuccess : EUploadState.FinishAndFailed);
			double serverTime = TimeUtil.Instance.GetServerTime();
			bool flag2 = global::Net.Instance.IsServerConnected();
			if (flag)
			{
				if (flag2)
				{
					CSharpScript.Game.Common.LocalStorage.SetPlayer<double>(ELocalStoragePlayerKey.LastTimeUploadStamp, serverTime);
				}
				else
				{
					CSharpScript.Game.Common.LocalStorage.SetGlobal<double>(ELocalStorageGlobalKey.LastTimeUploadStamp, serverTime);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[LogUpload] 上传结束";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsLogin", flag2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Success", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TimeStamp", serverTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0602BFDE RID: 180190 RVA: 0x00C5A054 File Offset: 0x00C58254
		protected void UploadEventCallBack(ESendState state, float rate)
		{
			if (this.UploadState != EUploadState.Uploading)
			{
				return;
			}
			this.UploadSendState = new ESendState?(state);
			if (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Done || this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Fail)
			{
				this.FinishUploadLog();
				return;
			}
			if (this.Rate == rate)
			{
				return;
			}
			if (this.UploadSendState.GetValueOrDefault() != ESendState.ESS_Compressing && this.UploadSendState.GetValueOrDefault() != ESendState.ESS_Sending)
			{
				return;
			}
			string item = Math.Round((double)(rate * 100f)).ToString() + "%";
			string textStringId = (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Compressing) ? "Text_LogCompressing_Text" : "Text_LogUploading_Text";
			LguiUtil.Instance.SetLocalTextNew(this.TextDescription, textStringId, new <>z__ReadOnlySingleElementList<object>(item));
			this.SpriteProgress.SetFillAmount(rate);
			this.Rate = rate;
		}

		// Token: 0x04017B27 RID: 97063
		private bool IsConfirmUpload;

		// Token: 0x04017B28 RID: 97064
		private EUploadState InnerUploadState;

		// Token: 0x04017B29 RID: 97065
		private float Rate;

		// Token: 0x04017B2A RID: 97066
		private UUIText TextDescription;

		// Token: 0x04017B2B RID: 97067
		private UUISprite SpriteProgress;

		// Token: 0x04017B2C RID: 97068
		private ButtonItem ContactButton;

		// Token: 0x04017B2D RID: 97069
		private ButtonItem ConfirmButton;

		// Token: 0x04017B2E RID: 97070
		protected FOnProgress UploadDelegate;

		// Token: 0x04017B2F RID: 97071
		private ESendState? UploadSendState;

		// Token: 0x04017B30 RID: 97072
		private EKuroSdkOpenCustomerServerType OpenSourceType = EKuroSdkOpenCustomerServerType.Login;

		// Token: 0x04017B31 RID: 97073
		private bool AutoStartUpload;

		// Token: 0x04017B32 RID: 97074
		private int? ErrorCode;
	}
}
