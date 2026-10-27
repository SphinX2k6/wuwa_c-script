using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000A7 RID: 167
	public class ResourceUpdateViewAgent : IResourceUpdateView
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000334F8 File Offset: 0x000316F8
		public long SavedSize
		{
			get
			{
				return this.TotalSize + this.CurProgress - this.TotalProgress;
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00033510 File Offset: 0x00031710
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			ResourceUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__12 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>4__this = this;
			<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<ResourceUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__12>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0003355B File Offset: 0x0003175B
		[NullableContext(2)]
		public void SetImplement(IResourceUpdateView implement)
		{
			this.Implement = implement;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00033564 File Offset: 0x00031764
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			this.ReceiveSize = receiveSize;
			this.CurProgress = curProgress;
			this.TotalProgress = totalProgress;
			this.DownloadSpeed = downloadSpeed;
			if (this.DownloadSpeed > this.DownloadSpeedMax)
			{
				this.DownloadSpeedMax = this.DownloadSpeed;
			}
		}

		// Token: 0x0400038E RID: 910
		public long ReceiveSize;

		// Token: 0x0400038F RID: 911
		public long CurProgress;

		// Token: 0x04000390 RID: 912
		public long TotalProgress;

		// Token: 0x04000391 RID: 913
		public long TotalSize;

		// Token: 0x04000392 RID: 914
		public bool NotEnoughSpace;

		// Token: 0x04000393 RID: 915
		public long DownloadSpeed;

		// Token: 0x04000394 RID: 916
		public long DownloadSpeedMax;

		// Token: 0x04000395 RID: 917
		public bool HasShowNotEnoughSpace;

		// Token: 0x04000396 RID: 918
		[Nullable(1)]
		public string FileName = "";

		// Token: 0x04000397 RID: 919
		[Nullable(2)]
		protected IResourceUpdateView Implement;
	}
}
