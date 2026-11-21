using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024C RID: 588
	[NullableContext(2)]
	public interface IDiffUpdateUiEvent
	{
		// Token: 0x06000EE9 RID: 3817
		UniTask WaitFrame(int? num = null);

		// Token: 0x06000EEA RID: 3818
		UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false);

		// Token: 0x06000EEB RID: 3819
		[NullableContext(1)]
		UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args);

		// Token: 0x06000EEC RID: 3820
		[NullableContext(1)]
		UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal);

		// Token: 0x06000EED RID: 3821
		[NullableContext(1)]
		[return: Nullable(0)]
		UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs);

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000EEE RID: 3822
		// (set) Token: 0x06000EEF RID: 3823
		bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000EF0 RID: 3824
		// (set) Token: 0x06000EF1 RID: 3825
		Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x06000EF2 RID: 3826
		bool IsCompatible();

		// Token: 0x06000EF3 RID: 3827
		[NullableContext(0)]
		UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize);

		// Token: 0x06000EF4 RID: 3828
		void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed);
	}
}
