using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.PreDownload
{
	// Token: 0x02000114 RID: 276
	[NullableContext(2)]
	[Nullable(0)]
	public class PreDownloadUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00040890 File Offset: 0x0003EA90
		[NullableContext(1)]
		public void SetView(IPreDownloadUiEvent uiView)
		{
			this.UiView = uiView;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00040899 File Offset: 0x0003EA99
		public void ClearView()
		{
			this.UiView = null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000408A2 File Offset: 0x0003EAA2
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000408A9 File Offset: 0x0003EAA9
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000408B0 File Offset: 0x0003EAB0
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

		// Token: 0x060008BB RID: 2235 RVA: 0x00040914 File Offset: 0x0003EB14
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

		// Token: 0x060008BC RID: 2236 RVA: 0x00040984 File Offset: 0x0003EB84
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00040A03 File Offset: 0x0003EC03
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00040A0B File Offset: 0x0003EC0B
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00040A14 File Offset: 0x0003EC14
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00040A1C File Offset: 0x0003EC1C
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x060008C1 RID: 2241 RVA: 0x00040A25 File Offset: 0x0003EC25
		public bool IsCompatible()
		{
			return false;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00040A28 File Offset: 0x0003EC28
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00040A30 File Offset: 0x0003EC30
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
		}

		// Token: 0x04000511 RID: 1297
		private IPreDownloadUiEvent UiView;
	}
}
