using System;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002669 RID: 9833
public class QuestResourceUpdateProxy : IResourceUpdateView
{
	// Token: 0x06014215 RID: 82453 RVA: 0x00515E68 File Offset: 0x00514068
	public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
	{
		QuestResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowNotEnoughSpaceConfirmation>d__.totalSize = totalSize;
		<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
		<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<QuestResourceUpdateProxy.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
		return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
	}

	// Token: 0x06014216 RID: 82454 RVA: 0x00515EAB File Offset: 0x005140AB
	public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
	{
	}
}
