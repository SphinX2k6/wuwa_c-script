using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EB RID: 235
	public class ResourceUpdateViewBase : IResourceUpdateView
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x0003CA84 File Offset: 0x0003AC84
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			ResourceUpdateViewBase.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<ResourceUpdateViewBase.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0003CABF File Offset: 0x0003ACBF
		public virtual void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
		}
	}
}
