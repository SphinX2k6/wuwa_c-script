using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater
{
	// Token: 0x020000AB RID: 171
	[NullableContext(2)]
	[Nullable(0)]
	public class ResourceDiffUpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00034C40 File Offset: 0x00032E40
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00034C48 File Offset: 0x00032E48
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x060005D6 RID: 1494 RVA: 0x00034C51 File Offset: 0x00032E51
		public bool IsCompatible()
		{
			return true;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00034C54 File Offset: 0x00032E54
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

		// Token: 0x060005D8 RID: 1496 RVA: 0x00034C9F File Offset: 0x00032E9F
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			ResourceUpdateViewAgent uiAgent = this.UiAgent;
			if (uiAgent == null)
			{
				return;
			}
			uiAgent.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00034CB6 File Offset: 0x00032EB6
		[NullableContext(1)]
		public void InitEvent(ResourceUpdateViewAgent uiAgent)
		{
			this.UiAgent = uiAgent;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00034CBF File Offset: 0x00032EBF
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00034CC6 File Offset: 0x00032EC6
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00034CCD File Offset: 0x00032ECD
		[NullableContext(1)]
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00034CD4 File Offset: 0x00032ED4
		[NullableContext(1)]
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			if (this.UiAgent != null)
			{
				this.UiAgent.FileName = fileName;
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00034CEF File Offset: 0x00032EEF
		[NullableContext(1)]
		[return: Nullable(0)]
		public virtual UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00034CF7 File Offset: 0x00032EF7
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00034CFF File Offset: 0x00032EFF
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x040003C6 RID: 966
		private ResourceUpdateViewAgent UiAgent;
	}
}
