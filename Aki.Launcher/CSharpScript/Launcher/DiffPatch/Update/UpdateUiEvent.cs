using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020E RID: 526
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x06000DAC RID: 3500 RVA: 0x00054392 File Offset: 0x00052592
		public UpdateUiEvent(HotFixManager uiMgr, string tag)
		{
			this.UiMgr = uiMgr;
			this.Tag = tag;
			this.TryShowNoticeWindowOnce = new Action<long, string>(this.OnTryShowNoticeWindowOnce);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000543BC File Offset: 0x000525BC
		public UniTask WaitFrame(int? num = null)
		{
			UpdateUiEvent.<WaitFrame>d__3 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>4__this = this;
			<WaitFrame>d__.num = num;
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<UpdateUiEvent.<WaitFrame>d__3>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00054408 File Offset: 0x00052608
		[NullableContext(2)]
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			UpdateUiEvent.<ShowInfo>d__4 <ShowInfo>d__;
			<ShowInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowInfo>d__.<>4__this = this;
			<ShowInfo>d__.bWithProgress = bWithProgress;
			<ShowInfo>d__.textId = textId;
			<ShowInfo>d__.bUseTag = bUseTag;
			<ShowInfo>d__.<>1__state = -1;
			<ShowInfo>d__.<>t__builder.Start<UpdateUiEvent.<ShowInfo>d__4>(ref <ShowInfo>d__);
			return <ShowInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00054464 File Offset: 0x00052664
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			UpdateUiEvent.<UpdateProgress>d__5 <UpdateProgress>d__;
			<UpdateProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateProgress>d__.<>4__this = this;
			<UpdateProgress>d__.bNeedWait = bNeedWait;
			<UpdateProgress>d__.rate = rate;
			<UpdateProgress>d__.textId = textId;
			<UpdateProgress>d__.args = args;
			<UpdateProgress>d__.<>1__state = -1;
			<UpdateProgress>d__.<>t__builder.Start<UpdateUiEvent.<UpdateProgress>d__5>(ref <UpdateProgress>d__);
			return <UpdateProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000544C8 File Offset: 0x000526C8
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			UpdateUiEvent.<UpdatePatchDownProgress>d__6 <UpdatePatchDownProgress>d__;
			<UpdatePatchDownProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdatePatchDownProgress>d__.<>4__this = this;
			<UpdatePatchDownProgress>d__.bNeedWait = bNeedWait;
			<UpdatePatchDownProgress>d__.rate = rate;
			<UpdatePatchDownProgress>d__.fileName = fileName;
			<UpdatePatchDownProgress>d__.speedText = speedText;
			<UpdatePatchDownProgress>d__.sizeCurrent = sizeCurrent;
			<UpdatePatchDownProgress>d__.sizeTotal = sizeTotal;
			<UpdatePatchDownProgress>d__.<>1__state = -1;
			<UpdatePatchDownProgress>d__.<>t__builder.Start<UpdateUiEvent.<UpdatePatchDownProgress>d__6>(ref <UpdatePatchDownProgress>d__);
			return <UpdatePatchDownProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00054540 File Offset: 0x00052740
		[return: Nullable(0)]
		public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			UpdateUiEvent.<ShowDialog>d__7 <ShowDialog>d__;
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
			<ShowDialog>d__.<>t__builder.Start<UpdateUiEvent.<ShowDialog>d__7>(ref <ShowDialog>d__);
			return <ShowDialog>d__.<>t__builder.Task;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000545BF File Offset: 0x000527BF
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x000545C7 File Offset: 0x000527C7
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x000545D0 File Offset: 0x000527D0
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x000545D8 File Offset: 0x000527D8
		[Nullable(2)]
		public Action<long, string> TryShowNoticeWindowOnce { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000545E4 File Offset: 0x000527E4
		[NullableContext(2)]
		private void OnTryShowNoticeWindowOnce(long downloadSize, string logMsg = null)
		{
			double num = (double)downloadSize / 1048576.0;
			int num2 = 500;
			if (num < (double)num2)
			{
				return;
			}
			this.UiMgr.ShowNoticeWindow(logMsg);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00054614 File Offset: 0x00052814
		public bool IsCompatible()
		{
			return false;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00054618 File Offset: 0x00052818
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			UpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__18 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<UpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__18>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00054653 File Offset: 0x00052853
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
		}

		// Token: 0x040008A8 RID: 2216
		private readonly HotFixManager UiMgr;

		// Token: 0x040008A9 RID: 2217
		private readonly string Tag;
	}
}
