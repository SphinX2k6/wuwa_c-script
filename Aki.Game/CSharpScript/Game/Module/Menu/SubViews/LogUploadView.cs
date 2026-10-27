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
	// Token: 0x02005422 RID: 21538
	[NullableContext(2)]
	[Nullable(0)]
	public class LogUploadView : UiViewBase
	{
		// Token: 0x06037082 RID: 225410 RVA: 0x00D0A2BB File Offset: 0x00D084BB
		[NullableContext(1)]
		public LogUploadView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037083 RID: 225411 RVA: 0x00D0A2CC File Offset: 0x00D084CC
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

		// Token: 0x06037084 RID: 225412 RVA: 0x00D0A3A1 File Offset: 0x00D085A1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SdkCustomerRedPointRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x06037085 RID: 225413 RVA: 0x00D0A3BF File Offset: 0x00D085BF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SdkCustomerRedPointRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x06037086 RID: 225414 RVA: 0x00D0A3E0 File Offset: 0x00D085E0
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

		// Token: 0x06037087 RID: 225415 RVA: 0x00D0A40C File Offset: 0x00D0860C
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

		// Token: 0x06037088 RID: 225416 RVA: 0x00D0A549 File Offset: 0x00D08749
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

		// Token: 0x06037089 RID: 225417 RVA: 0x00D0A570 File Offset: 0x00D08770
		private void OnUploadConfirmToggleClick(EToggleState state)
		{
			if (this.AutoStartUpload)
			{
				return;
			}
			this.IsConfirmUpload = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x0603708A RID: 225418 RVA: 0x00D0A585 File Offset: 0x00D08785
		private void OnOpenCustomerService(int _)
		{
			if (this.OpenSourceType == EKuroSdkOpenCustomerServerType.Setting)
			{
				LogController.Instance.RequestOutputDebugInfo();
			}
			global::KuroSdkController.Instance.OpenCustomerService(this.OpenSourceType);
		}

		// Token: 0x0603708B RID: 225419 RVA: 0x00D0A5AC File Offset: 0x00D087AC
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

		// Token: 0x0603708C RID: 225420 RVA: 0x00D0A643 File Offset: 0x00D08843
		private void OnClose()
		{
			if (this.UploadState == EUploadState.Uploading && !this.InterruptUploadLog())
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0603708D RID: 225421 RVA: 0x00D0A65E File Offset: 0x00D0885E
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

		// Token: 0x0603708E RID: 225422 RVA: 0x00D0A695 File Offset: 0x00D08895
		private void ClearDelegate()
		{
			UKuroTencentCOSLibrary.ClearAllProgressCallback();
			if (this.UploadDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<ESendState, float>(this.UploadEventCallBack));
				this.UploadDelegate = null;
			}
		}

		// Token: 0x1700843C RID: 33852
		// (get) Token: 0x0603708F RID: 225423 RVA: 0x00D0A6BC File Offset: 0x00D088BC
		// (set) Token: 0x06037090 RID: 225424 RVA: 0x00D0A6C4 File Offset: 0x00D088C4
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

		// Token: 0x06037091 RID: 225425 RVA: 0x00D0A904 File Offset: 0x00D08B04
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

		// Token: 0x06037092 RID: 225426 RVA: 0x00D0AA24 File Offset: 0x00D08C24
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

		// Token: 0x06037093 RID: 225427 RVA: 0x00D0AB08 File Offset: 0x00D08D08
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

		// Token: 0x06037094 RID: 225428 RVA: 0x00D0AB5C File Offset: 0x00D08D5C
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

		// Token: 0x06037095 RID: 225429 RVA: 0x00D0AC34 File Offset: 0x00D08E34
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

		// Token: 0x0401D08E RID: 118926
		private bool IsConfirmUpload;

		// Token: 0x0401D08F RID: 118927
		private EUploadState InnerUploadState;

		// Token: 0x0401D090 RID: 118928
		private float Rate;

		// Token: 0x0401D091 RID: 118929
		private UUIText TextDescription;

		// Token: 0x0401D092 RID: 118930
		private UUISprite SpriteProgress;

		// Token: 0x0401D093 RID: 118931
		private ButtonItem ContactButton;

		// Token: 0x0401D094 RID: 118932
		private ButtonItem ConfirmButton;

		// Token: 0x0401D095 RID: 118933
		protected FOnProgress UploadDelegate;

		// Token: 0x0401D096 RID: 118934
		private ESendState? UploadSendState;

		// Token: 0x0401D097 RID: 118935
		private EKuroSdkOpenCustomerServerType OpenSourceType = EKuroSdkOpenCustomerServerType.Login;

		// Token: 0x0401D098 RID: 118936
		private bool AutoStartUpload;

		// Token: 0x0401D099 RID: 118937
		private int? ErrorCode;
	}
}
