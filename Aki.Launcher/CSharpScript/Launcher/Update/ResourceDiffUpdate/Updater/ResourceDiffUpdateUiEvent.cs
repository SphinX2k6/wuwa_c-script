using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(2)]
	[Nullable(0)]
	public class ResourceDiffUpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000335B0 File Offset: 0x000317B0
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000335B8 File Offset: 0x000317B8
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x060005BE RID: 1470 RVA: 0x000335C1 File Offset: 0x000317C1
		public bool IsCompatible()
		{
			return true;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000335C4 File Offset: 0x000317C4
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			ResourceDiffUpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__6 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>4__this = this;
			<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<ResourceDiffUpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__6>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0003360F File Offset: 0x0003180F
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			ResourceUpdateViewAgent uiAgent = this.UiAgent;
			if (uiAgent == null)
			{
				return;
			}
			uiAgent.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00033626 File Offset: 0x00031826
		[NullableContext(1)]
		public void InitEvent(ResourceUpdateViewAgent uiAgent)
		{
			this.UiAgent = uiAgent;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0003362F File Offset: 0x0003182F
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00033636 File Offset: 0x00031836
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0003363D File Offset: 0x0003183D
		[NullableContext(1)]
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00033644 File Offset: 0x00031844
		[NullableContext(1)]
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.FileName = fileName;
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0003365F File Offset: 0x0003185F
		[NullableContext(1)]
		[return: Nullable(0)]
		public virtual UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00033667 File Offset: 0x00031867
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0003366F File Offset: 0x0003186F
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x04000398 RID: 920
		private ResourceUpdateViewAgent UiAgent;
	}
}
