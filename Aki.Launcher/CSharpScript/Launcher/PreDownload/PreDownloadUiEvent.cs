using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000118 RID: 280
	[NullableContext(2)]
	[Nullable(0)]
	public class PreDownloadUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00042C58 File Offset: 0x00040E58
		[NullableContext(1)]
		public void SetView(IPreDownloadUiEvent uiView)
		{
			this.UiView = uiView;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00042C61 File Offset: 0x00040E61
		public void ClearView()
		{
			this.UiView = null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00042C6A File Offset: 0x00040E6A
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00042C71 File Offset: 0x00040E71
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00042C78 File Offset: 0x00040E78
		[NullableContext(1)]
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			PreDownloadUiEvent.<UpdateProgress>d__5 <UpdateProgress>d__;
			<UpdateProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateProgress>d__.<>4__this = this;
			<UpdateProgress>d__.bNeedWait = bNeedWait;
			<UpdateProgress>d__.rate = rate;
			<UpdateProgress>d__.textId = textId;
			<UpdateProgress>d__.args = args;
			<UpdateProgress>d__.<>1__state = -1;
			<UpdateProgress>d__.<>t__builder.Start<PreDownloadUiEvent.<UpdateProgress>d__5>(ref <UpdateProgress>d__);
			return <UpdateProgress>d__.<>t__builder.Task;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00042CDC File Offset: 0x00040EDC
		[NullableContext(1)]
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			PreDownloadUiEvent.<UpdatePatchDownProgress>d__6 <UpdatePatchDownProgress>d__;
			<UpdatePatchDownProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdatePatchDownProgress>d__.<>4__this = this;
			<UpdatePatchDownProgress>d__.bNeedWait = bNeedWait;
			<UpdatePatchDownProgress>d__.rate = rate;
			<UpdatePatchDownProgress>d__.speedText = speedText;
			<UpdatePatchDownProgress>d__.sizeCurrent = sizeCurrent;
			<UpdatePatchDownProgress>d__.sizeTotal = sizeTotal;
			<UpdatePatchDownProgress>d__.<>1__state = -1;
			<UpdatePatchDownProgress>d__.<>t__builder.Start<PreDownloadUiEvent.<UpdatePatchDownProgress>d__6>(ref <UpdatePatchDownProgress>d__);
			return <UpdatePatchDownProgress>d__.<>t__builder.Task;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00042D4C File Offset: 0x00040F4C
		[NullableContext(1)]
		[return: Nullable(0)]
		public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			PreDownloadUiEvent.<ShowDialog>d__7 <ShowDialog>d__;
			<ShowDialog>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowDialog>d__.<>4__this = this;
			<ShowDialog>d__.bSelect = bSelect;
			<ShowDialog>d__.titleId = titleId;
			<ShowDialog>d__.contentId = contentId;
			<ShowDialog>d__.leftId = leftId;
			<ShowDialog>d__.rightId = rightId;
			<ShowDialog>d__.middleId = middleId;
			<ShowDialog>d__.contentArgs = contentArgs;
			<ShowDialog>d__.<>1__state = -1;
			<ShowDialog>d__.<>t__builder.Start<PreDownloadUiEvent.<ShowDialog>d__7>(ref <ShowDialog>d__);
			return <ShowDialog>d__.<>t__builder.Task;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00042DCB File Offset: 0x00040FCB
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00042DD3 File Offset: 0x00040FD3
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00042DDC File Offset: 0x00040FDC
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00042DE4 File Offset: 0x00040FE4
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x060008F5 RID: 2293 RVA: 0x00042DED File Offset: 0x00040FED
		public bool IsCompatible()
		{
			return false;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00042DF0 File Offset: 0x00040FF0
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00042DF8 File Offset: 0x00040FF8
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
		}

		// Token: 0x0400054C RID: 1356
		private IPreDownloadUiEvent UiView;
	}
}
