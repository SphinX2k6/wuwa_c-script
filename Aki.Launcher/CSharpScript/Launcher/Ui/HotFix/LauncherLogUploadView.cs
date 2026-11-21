using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.LogUpload;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000ED RID: 237
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherLogUploadView : LaunchComponentsAction
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0003E682 File Offset: 0x0003C882
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0003E68A File Offset: 0x0003C88A
		public int? ErrorCode { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0003E693 File Offset: 0x0003C893
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0003E69B File Offset: 0x0003C89B
		public bool AutoStartUpload { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		[Nullable(2)]
		private UUITexture ProgressBarTexture
		{
			[NullableContext(2)]
			get
			{
				if (this._progressBarTexture == null)
				{
					this._progressBarTexture = base.GetTexture(2);
				}
				return this._progressBarTexture;
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(5);
			if (texture != null)
			{
				UTexture2D utexture2D = LauncherResourceLib.Instance.Load<UTexture2D>(path, 0, "js_call_launch");
				if (utexture2D != null)
				{
					texture.SetTexture(utexture2D);
				}
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0003E6F8 File Offset: 0x0003C8F8
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.OnClickCallBack.Bind(new Action(this.OnConfirm));
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 != null)
			{
				UUIItem uuiitem = button2.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			UUIButtonComponent button3 = base.GetButton(7);
			if (button3 != null)
			{
				button3.OnClickCallBack.Bind(new Action(this.OnClose));
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnUploadConfirmToggleClick));
			}
			this.UploadState = LauncherLogUploadView.EUploadState.Wait;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0003E798 File Offset: 0x0003C998
		protected override void OnShow()
		{
			base.OnShow();
			this.RefreshConsentText();
			if (this.AutoStartUpload)
			{
				this.IsConfirmUpload = true;
				this.ClearDelegate();
				this.Rate = 0f;
				this.UploadSendState = null;
				this.UploadState = LauncherLogUploadView.EUploadState.Uploading;
				this.StartUploadLog();
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0003E7EC File Offset: 0x0003C9EC
		private void RefreshConsentText()
		{
			UUIText text = base.GetText(8);
			if (text != null)
			{
				HotFixManager.SetLocalText(text, "CustomerDescText", Array.Empty<string>());
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0003E814 File Offset: 0x0003CA14
		protected override void OnBeforeDestroy()
		{
			this.ClearDelegate();
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.OnClickCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 != null)
			{
				button2.OnClickCallBack.Unbind();
			}
			UUIButtonComponent button3 = base.GetButton(7);
			if (button3 != null)
			{
				button3.OnClickCallBack.Unbind();
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnUploadConfirmToggleClick));
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0003E88B File Offset: 0x0003CA8B
		private void OnUploadConfirmToggleClick(EToggleState state)
		{
			if (this.AutoStartUpload)
			{
				return;
			}
			this.IsConfirmUpload = (state == EToggleState.ETT_Checked);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
		private void OnClose()
		{
			base.SetActive(false);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		private void OnConfirm()
		{
			switch (this.UploadState)
			{
			case LauncherLogUploadView.EUploadState.Wait:
				if (!this.IsConfirmUpload)
				{
					LauncherLog.Instance.Info("[LauncherLogUpload] Please confirm upload first", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.UploadState = LauncherLogUploadView.EUploadState.Uploading;
				this.StartUploadLog();
				return;
			case LauncherLogUploadView.EUploadState.Uploading:
				if (this.InterruptUploadLog())
				{
					this.UploadState = LauncherLogUploadView.EUploadState.Wait;
					this.ClearDelegate();
					this.Rate = 0f;
					this.UploadSendState = null;
					return;
				}
				break;
			case LauncherLogUploadView.EUploadState.FinishAndSuccess:
				base.SetActive(false);
				return;
			case LauncherLogUploadView.EUploadState.FinishAndFailed:
				this.UploadState = LauncherLogUploadView.EUploadState.Uploading;
				this.StartUploadLog();
				break;
			default:
				return;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0003E948 File Offset: 0x0003CB48
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0003E950 File Offset: 0x0003CB50
		private LauncherLogUploadView.EUploadState UploadState
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
				UUIText text = base.GetText(9);
				UUIText text2 = base.GetText(0);
				switch (this.InnerUploadState)
				{
				case LauncherLogUploadView.EUploadState.Wait:
					this.SetIcon("/Game/Aki/UI/Module/HotFix/Image/T_UpLoadA.T_UpLoadA");
					if (text != null)
					{
						HotFixManager.SetLocalText(text, "LogUpload_Upload", Array.Empty<string>());
					}
					if (text2 != null)
					{
						HotFixManager.SetLocalText(text2, "LogUpload_ConfirmDesc", Array.Empty<string>());
						text2.SetUIActive(true);
					}
					if (extendToggle != null)
					{
						UUIItem uuiitem = extendToggle.RootUIComp.Get();
						if (uuiitem != null)
						{
							uuiitem.SetUIActive(!this.AutoStartUpload);
						}
					}
					if (item != null)
					{
						item.SetUIActive(false);
						return;
					}
					break;
				case LauncherLogUploadView.EUploadState.Uploading:
					this.SetIcon("/Game/Aki/UI/Module/HotFix/Image/T_UpLoadB.T_UpLoadB");
					if (text != null)
					{
						HotFixManager.SetLocalText(text, "LogUpload_Cancel", Array.Empty<string>());
					}
					if (text2 != null)
					{
						text2.SetText("", true);
						text2.SetUIActive(true);
					}
					if (extendToggle != null)
					{
						UUIItem uuiitem2 = extendToggle.RootUIComp.Get();
						if (uuiitem2 != null)
						{
							uuiitem2.SetUIActive(false);
						}
					}
					if (item != null)
					{
						item.SetUIActive(true);
						return;
					}
					break;
				case LauncherLogUploadView.EUploadState.FinishAndSuccess:
					this.SetIcon("/Game/Aki/UI/Module/HotFix/Image/T_UpLoadC.T_UpLoadC");
					if (text != null)
					{
						HotFixManager.SetLocalText(text, "LogUpload_Confirm", Array.Empty<string>());
					}
					if (text2 != null)
					{
						HotFixManager.SetLocalText(text2, "LogUpload_Success", Array.Empty<string>());
						text2.SetUIActive(true);
					}
					if (extendToggle != null)
					{
						UUIItem uuiitem3 = extendToggle.RootUIComp.Get();
						if (uuiitem3 != null)
						{
							uuiitem3.SetUIActive(false);
						}
					}
					if (item != null)
					{
						item.SetUIActive(false);
						return;
					}
					break;
				case LauncherLogUploadView.EUploadState.FinishAndFailed:
					this.SetIcon("/Game/Aki/UI/Module/HotFix/Image/T_UpLoadA.T_UpLoadA");
					if (text != null)
					{
						HotFixManager.SetLocalText(text, "LogUpload_Retry", Array.Empty<string>());
					}
					if (text2 != null)
					{
						int allFileNumNeedToSend = UKuroTencentCOSLibrary.GetAllFileNumNeedToSend();
						int sendedFileNum = UKuroTencentCOSLibrary.GetSendedFileNum();
						HotFixManager.SetLocalText(text2, "LogUpload_Failed", new string[]
						{
							(allFileNumNeedToSend - sendedFileNum).ToString(),
							allFileNumNeedToSend.ToString()
						});
						text2.SetUIActive(true);
					}
					if (extendToggle != null)
					{
						UUIItem uuiitem4 = extendToggle.RootUIComp.Get();
						if (uuiitem4 != null)
						{
							uuiitem4.SetUIActive(false);
						}
					}
					if (item != null)
					{
						item.SetUIActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0003EB60 File Offset: 0x0003CD60
		private void StartUploadLog()
		{
			this.Rate = 0f;
			UUITexture progressBarTexture = this.ProgressBarTexture;
			if (progressBarTexture != null)
			{
				progressBarTexture.SetFillAmount(0f);
			}
			this.ClearDelegate();
			if (this.UploadDelegate == null)
			{
				this.UploadDelegate = DelegateUtils.ToManualReleaseDelegate<FOnProgress>(new Action<ESendState, float>(this.UploadEventCallBack));
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

		// Token: 0x06000806 RID: 2054 RVA: 0x0003EC40 File Offset: 0x0003CE40
		private bool InterruptUploadLog()
		{
			if (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Compressing)
			{
				LauncherLog.Instance.Info("[LauncherLogUpload] Cannot interrupt during compression", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (UKuroTencentCOSLibrary.IsSending())
			{
				UKuroTencentCOSLibrary.InterruptSending();
				LauncherLog.Instance.Info("[LauncherLogUpload] Upload interrupted", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			return false;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		private void FinishUploadLog()
		{
			this.ClearDelegate();
			bool flag = this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Done;
			this.UploadState = (flag ? LauncherLogUploadView.EUploadState.FinishAndSuccess : LauncherLogUploadView.EUploadState.FinishAndFailed);
			LauncherLog instance = LauncherLog.Instance;
			string message = "[LauncherLogUpload] Upload finished";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Success", flag);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
		private void UploadEventCallBack(ESendState state, float rate)
		{
			if (this.UploadState != LauncherLogUploadView.EUploadState.Uploading)
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
			int value = (int)(rate * 100f);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetUIActive(true);
				if (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Compressing)
				{
					HotFixManager.SetLocalText(text2, "LogUpload_Compressing", new string[]
					{
						text
					});
				}
				else
				{
					HotFixManager.SetLocalText(text2, "LogUpload_Uploading", new string[]
					{
						text
					});
				}
			}
			UUITexture progressBarTexture = this.ProgressBarTexture;
			if (progressBarTexture != null)
			{
				progressBarTexture.SetFillAmount(rate);
			}
			this.Rate = rate;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0003EDF4 File Offset: 0x0003CFF4
		private void ClearDelegate()
		{
			UKuroTencentCOSLibrary.ClearAllProgressCallback();
			if (this.UploadDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<ESendState, float>(this.UploadEventCallBack));
				this.UploadDelegate = null;
			}
		}

		// Token: 0x040004C8 RID: 1224
		private bool IsConfirmUpload;

		// Token: 0x040004C9 RID: 1225
		private LauncherLogUploadView.EUploadState InnerUploadState;

		// Token: 0x040004CA RID: 1226
		private float Rate;

		// Token: 0x040004CB RID: 1227
		[Nullable(2)]
		private FOnProgress UploadDelegate;

		// Token: 0x040004CC RID: 1228
		private ESendState? UploadSendState;

		// Token: 0x040004CF RID: 1231
		private const string ICON_UPLOAD = "/Game/Aki/UI/Module/HotFix/Image/T_UpLoadA.T_UpLoadA";

		// Token: 0x040004D0 RID: 1232
		private const string ICON_UPLOADING = "/Game/Aki/UI/Module/HotFix/Image/T_UpLoadB.T_UpLoadB";

		// Token: 0x040004D1 RID: 1233
		private const string ICON_SUCCESS = "/Game/Aki/UI/Module/HotFix/Image/T_UpLoadC.T_UpLoadC";

		// Token: 0x040004D2 RID: 1234
		[Nullable(2)]
		private UUITexture _progressBarTexture;

		// Token: 0x02000398 RID: 920
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040012B1 RID: 4785
			public const int TextDescription = 0;

			// Token: 0x040012B2 RID: 4786
			public const int ProgressBar = 1;

			// Token: 0x040012B3 RID: 4787
			public const int SpriteBar = 2;

			// Token: 0x040012B4 RID: 4788
			public const int ButtonContact = 3;

			// Token: 0x040012B5 RID: 4789
			public const int ButtonConfirm = 4;

			// Token: 0x040012B6 RID: 4790
			public const int SpriteIcon = 5;

			// Token: 0x040012B7 RID: 4791
			public const int ToggleConfirm = 6;

			// Token: 0x040012B8 RID: 4792
			public const int ButtonClose = 7;

			// Token: 0x040012B9 RID: 4793
			public const int TxtConsent = 8;

			// Token: 0x040012BA RID: 4794
			public const int ConfirmTxt = 9;
		}

		// Token: 0x02000399 RID: 921
		[NullableContext(0)]
		private enum EUploadState
		{
			// Token: 0x040012BC RID: 4796
			Wait,
			// Token: 0x040012BD RID: 4797
			Uploading,
			// Token: 0x040012BE RID: 4798
			FinishAndSuccess,
			// Token: 0x040012BF RID: 4799
			FinishAndFailed
		}
	}
}
