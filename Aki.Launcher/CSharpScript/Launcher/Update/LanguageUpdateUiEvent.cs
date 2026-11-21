using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008E RID: 142
	[NullableContext(2)]
	[Nullable(0)]
	public class LanguageUpdateUiEvent : IDiffUpdateUiEvent
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00030A40 File Offset: 0x0002EC40
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00030A48 File Offset: 0x0002EC48
		public Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x06000518 RID: 1304 RVA: 0x00030A51 File Offset: 0x0002EC51
		public bool IsCompatible()
		{
			return true;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00030A54 File Offset: 0x0002EC54
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

		// Token: 0x0600051A RID: 1306 RVA: 0x00030A9F File Offset: 0x0002EC9F
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			LanguageUpdateViewAgent uiAgent = this.UiAgent;
			if (uiAgent == null)
			{
				return;
			}
			uiAgent.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00030AB6 File Offset: 0x0002ECB6
		[NullableContext(1)]
		public void InitEvent(LanguageUpdateViewAgent uiAgent)
		{
			this.UiAgent = uiAgent;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00030ABF File Offset: 0x0002ECBF
		public UniTask WaitFrame(int? num = null)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00030AC6 File Offset: 0x0002ECC6
		public UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00030ACD File Offset: 0x0002ECCD
		[NullableContext(1)]
		public UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		[NullableContext(1)]
		public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00030ADB File Offset: 0x0002ECDB
		[NullableContext(1)]
		[return: Nullable(0)]
		public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs)
		{
			throw new Exception("语言下载不实现，弹对话框。需要弹对话框，即失败！");
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00030AE7 File Offset: 0x0002ECE7
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00030AEF File Offset: 0x0002ECEF
		public bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x04000313 RID: 787
		private LanguageUpdateViewAgent UiAgent;
	}
}
