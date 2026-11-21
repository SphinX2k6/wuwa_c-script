using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;
using UnrealEngine;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C2 RID: 450
	[NullableContext(2)]
	[Nullable(0)]
	public class NetworkDetectionLogUploadHandle
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0004DAC1 File Offset: 0x0004BCC1
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x0004DAC9 File Offset: 0x0004BCC9
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

		// Token: 0x06000C3C RID: 3132 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
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

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004DB2C File Offset: 0x0004BD2C
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

		// Token: 0x06000C3E RID: 3134 RVA: 0x0004DBA4 File Offset: 0x0004BDA4
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

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004DBE3 File Offset: 0x0004BDE3
		private void ClearDelegate()
		{
			UKuroTencentCOSLibrary.ClearAllProgressCallback();
			if (this.UploadDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int, float>(this.UploadEventCallBack));
				this.UploadDelegate = null;
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0004DC0A File Offset: 0x0004BE0A
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

		// Token: 0x06000C41 RID: 3137 RVA: 0x0004DC2C File Offset: 0x0004BE2C
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

		// Token: 0x040007D8 RID: 2008
		private EUploadState UpdateStateInner;

		// Token: 0x040007D9 RID: 2009
		private ESendState? UploadSendState;

		// Token: 0x040007DA RID: 2010
		private float Rate;

		// Token: 0x040007DB RID: 2011
		protected FOnProgress UploadDelegate;

		// Token: 0x040007DC RID: 2012
		public TNetworkDetectionLogUploadFinishCallBack LogUploadFinishCallBack;
	}
}
