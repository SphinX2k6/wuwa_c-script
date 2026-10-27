using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000209 RID: 521
	[NullableContext(1)]
	[Nullable(0)]
	public class UpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x06000D6B RID: 3435 RVA: 0x0005189E File Offset: 0x0004FA9E
		public UpdateUiEvent(HotFixManager uiMgr, string tag)
		{
			this.UiMgr = uiMgr;
			this.Tag = tag;
			this.TryShowNoticeWindowOnce = new Action<long, string>(this.OnTryShowNoticeWindowOnce);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000518C8 File Offset: 0x0004FAC8
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

		// Token: 0x06000D6D RID: 3437 RVA: 0x00051914 File Offset: 0x0004FB14
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

		// Token: 0x06000D6E RID: 3438 RVA: 0x00051970 File Offset: 0x0004FB70
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

		// Token: 0x06000D6F RID: 3439 RVA: 0x000519D4 File Offset: 0x0004FBD4
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

		// Token: 0x06000D70 RID: 3440 RVA: 0x00051A4C File Offset: 0x0004FC4C
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00051ACB File Offset: 0x0004FCCB
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00051AD3 File Offset: 0x0004FCD3
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00051ADC File Offset: 0x0004FCDC
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00051AE4 File Offset: 0x0004FCE4
		[Nullable(2)]
		public Action<long, string> TryShowNoticeWindowOnce { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06000D75 RID: 3445 RVA: 0x00051AF0 File Offset: 0x0004FCF0
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

		// Token: 0x06000D76 RID: 3446 RVA: 0x00051B20 File Offset: 0x0004FD20
		public bool IsCompatible()
		{
			return false;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00051B24 File Offset: 0x0004FD24
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			UpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__18 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<UpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__18>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00051B5F File Offset: 0x0004FD5F
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
		}

		// Token: 0x04000867 RID: 2151
		private readonly HotFixManager UiMgr;

		// Token: 0x04000868 RID: 2152
		private readonly string Tag;
	}
}
