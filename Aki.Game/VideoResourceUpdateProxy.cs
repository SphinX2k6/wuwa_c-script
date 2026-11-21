using System;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C4B RID: 7243
public class VideoResourceUpdateProxy : IResourceUpdateView
{
	// Token: 0x06011FBA RID: 73658 RVA: 0x00549E8C File Offset: 0x0054808C
	public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
	{
		VideoResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
		<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<VideoResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
		return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
	}

	// Token: 0x06011FBB RID: 73659 RVA: 0x00549ECF File Offset: 0x005480CF
	public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
	{
	}
}
