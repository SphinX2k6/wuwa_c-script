using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;
using UnrealEngine;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001BE RID: 446
	[NullableContext(2)]
	[Nullable(0)]
	public class NetworkDetectionLogUploadHandle
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0004B2AD File Offset: 0x000494AD
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0004B2B5 File Offset: 0x000494B5
		private EUploadState UploadState
		{
			get
			{
				return this.UpdateStateInner;
			}
			set
			{
				this.UpdateStateInner = value;
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0004B2C0 File Offset: 0x000494C0
		public void UploadLog()
		{
			switch (this.UploadState)
			{
			case EUploadState.Wait:
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
				break;
			case EUploadState.FinishAndFailed:
				this.UploadState = EUploadState.Uploading;
				this.StartUploadLog();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0004B318 File Offset: 0x00049518
		protected void UploadEventCallBack(int inState, float rate)
		{
			if (this.UploadState != EUploadState.Uploading)
			{
				return;
			}
			this.UploadSendState = new ESendState?((ESendState)inState);
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
			this.Rate = rate;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0004B390 File Offset: 0x00049590
		private void FinishUploadLog()
		{
			this.ClearDelegate();
			this.UploadState = ((this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Done) ? EUploadState.FinishAndSuccess : EUploadState.FinishAndFailed);
			TNetworkDetectionLogUploadFinishCallBack logUploadFinishCallBack = this.LogUploadFinishCallBack;
			if (logUploadFinishCallBack == null)
			{
				return;
			}
			logUploadFinishCallBack();
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0004B3CF File Offset: 0x000495CF
		private void ClearDelegate()
		{
			UKuroTencentCOSLibrary.ClearAllProgressCallback();
			if (this.UploadDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int, float>(this.UploadEventCallBack));
				this.UploadDelegate = null;
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0004B3F6 File Offset: 0x000495F6
		public bool InterruptUploadLog()
		{
			if (this.UploadSendState.GetValueOrDefault() == ESendState.ESS_Compressing)
			{
				return false;
			}
			if (UKuroTencentCOSLibrary.IsSending())
			{
				UKuroTencentCOSLibrary.InterruptSending();
				return true;
			}
			return false;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0004B418 File Offset: 0x00049618
		private void StartUploadLog()
		{
			this.Rate = 0f;
			this.ClearDelegate();
			if (this.UploadDelegate == null)
			{
				this.UploadDelegate = DelegateUtils.ToManualReleaseDelegate<FOnProgress>(new Action<int, float>(this.UploadEventCallBack));
			}
			LauncherLogUpload.Instance.SendLog(this.UploadDelegate, new SendLogReason
			{
				Reason = ELauncherLogUploadReason.Manual
			});
		}

		// Token: 0x0400079B RID: 1947
		private EUploadState UpdateStateInner;

		// Token: 0x0400079C RID: 1948
		private ESendState? UploadSendState;

		// Token: 0x0400079D RID: 1949
		private float Rate;

		// Token: 0x0400079E RID: 1950
		protected FOnProgress UploadDelegate;

		// Token: 0x0400079F RID: 1951
		public TNetworkDetectionLogUploadFinishCallBack LogUploadFinishCallBack;
	}
}
