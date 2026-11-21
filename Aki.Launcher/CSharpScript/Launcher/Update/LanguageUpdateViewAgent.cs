using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008F RID: 143
	public class LanguageUpdateViewAgent : IResourceUpdateView
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00030B00 File Offset: 0x0002ED00
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			LanguageUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<LanguageUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00030B3B File Offset: 0x0002ED3B
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			if (this.Implement != null)
			{
				this.Implement.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00030B55 File Offset: 0x0002ED55
		[NullableContext(2)]
		public void SetImplement(IResourceUpdateView implement)
		{
			this.Implement = implement;
		}

		// Token: 0x04000316 RID: 790
		[Nullable(2)]
		private IResourceUpdateView Implement;
	}
}
