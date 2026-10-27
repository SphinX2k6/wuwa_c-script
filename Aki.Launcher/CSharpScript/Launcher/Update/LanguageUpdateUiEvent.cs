using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008B RID: 139
	[NullableContext(2)]
	[Nullable(0)]
	public class LanguageUpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0002F4E0 File Offset: 0x0002D6E0
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x06000501 RID: 1281 RVA: 0x0002F4E9 File Offset: 0x0002D6E9
		public bool IsCompatible()
		{
			return true;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002F4EC File Offset: 0x0002D6EC
		[NullableContext(0)]
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			LanguageUpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__6 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>4__this = this;
			<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<LanguageUpdateUiEvent.<ShowNotEnoughSpaceConfirmation>d__6>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002F537 File Offset: 0x0002D737
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			LanguageUpdateViewAgent uiAgent = this.UiAgent;
			if (uiAgent == null)
			{
				return;
			}
			uiAgent.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002F54E File Offset: 0x0002D74E
		[NullableContext(1)]
		public void InitEvent(LanguageUpdateViewAgent uiAgent)
		{
			this.UiAgent = uiAgent;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002F557 File Offset: 0x0002D757
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002F55E File Offset: 0x0002D75E
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002F565 File Offset: 0x0002D765
		[NullableContext(1)]
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002F56C File Offset: 0x0002D76C
		[NullableContext(1)]
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0002F573 File Offset: 0x0002D773
		[NullableContext(1)]
		[return: Nullable(0)]
		public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			throw new Exception("语言下载不实现，弹对话框。需要弹对话框，即失败！");
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0002F57F File Offset: 0x0002D77F
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0002F587 File Offset: 0x0002D787
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x040002E5 RID: 741
		private LanguageUpdateViewAgent UiAgent;
	}
}
