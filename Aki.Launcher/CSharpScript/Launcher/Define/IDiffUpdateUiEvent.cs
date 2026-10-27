using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000247 RID: 583
	[NullableContext(2)]
	public interface IDiffUpdateUiEvent
	{
		// Token: 0x06000EA8 RID: 3752
		UniTask WaitFrame(int? num = null);

		// Token: 0x06000EA9 RID: 3753
		UniTask ShowInfo(bool bWithProgress, string textId, bool bUseTag = false);

		// Token: 0x06000EAA RID: 3754
		[NullableContext(1)]
		UniTask UpdateProgress(bool bNeedWait, float rate, string textId, params string[] args);

		// Token: 0x06000EAB RID: 3755
		[NullableContext(1)]
		UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal);

		// Token: 0x06000EAC RID: 3756
		[NullableContext(1)]
		[return: Nullable(0)]
		UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, [Nullable(2)] string leftId, [Nullable(2)] string rightId, [Nullable(2)] string middleId, params string[] contentArgs);

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000EAD RID: 3757
		// (set) Token: 0x06000EAE RID: 3758
		bool? ShouldShowNoticeWindow { get; set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000EAF RID: 3759
		// (set) Token: 0x06000EB0 RID: 3760
		Action<long, string> TryShowNoticeWindowOnce { get; set; }

		// Token: 0x06000EB1 RID: 3761
		bool IsCompatible();

		// Token: 0x06000EB2 RID: 3762
		[NullableContext(0)]
		UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize);

		// Token: 0x06000EB3 RID: 3763
		void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed);
	}
}
