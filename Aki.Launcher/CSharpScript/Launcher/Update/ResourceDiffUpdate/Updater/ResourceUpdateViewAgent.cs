using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000AA RID: 170
	public class ResourceUpdateViewAgent : IResourceUpdateView
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00034B88 File Offset: 0x00032D88
		public long SavedSize
		{
			get
			{
				return this.TotalSize + this.CurProgress - this.TotalProgress;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00034BA0 File Offset: 0x00032DA0
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

		// Token: 0x060005D1 RID: 1489 RVA: 0x00034BEB File Offset: 0x00032DEB
		[NullableContext(2)]
		public void SetImplement(IResourceUpdateView implement)
		{
			this.Implement = implement;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00034BF4 File Offset: 0x00032DF4
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

		// Token: 0x040003BC RID: 956
		public long ReceiveSize;

		// Token: 0x040003BD RID: 957
		public long CurProgress;

		// Token: 0x040003BE RID: 958
		public long TotalProgress;

		// Token: 0x040003BF RID: 959
		public long TotalSize;

		// Token: 0x040003C0 RID: 960
		public bool NotEnoughSpace;

		// Token: 0x040003C1 RID: 961
		public long DownloadSpeed;

		// Token: 0x040003C2 RID: 962
		public long DownloadSpeedMax;

		// Token: 0x040003C3 RID: 963
		public bool HasShowNotEnoughSpace;

		// Token: 0x040003C4 RID: 964
		[Nullable(1)]
		public string FileName = "";

		// Token: 0x040003C5 RID: 965
		[Nullable(2)]
		protected IResourceUpdateView Implement;
	}
}
