using System;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002760 RID: 10080
public class VideoResourceUpdateProxy : IResourceUpdateView
{
	// Token: 0x06014AD7 RID: 84695 RVA: 0x0053B07C File Offset: 0x0053927C
	public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
	{
		VideoResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
		<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<VideoResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
		return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
	}

	// Token: 0x06014AD8 RID: 84696 RVA: 0x0053B0BF File Offset: 0x005392BF
	public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
	{
	}
}
