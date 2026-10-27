using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008C RID: 140
	public class LanguageUpdateViewAgent : IResourceUpdateView
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x0002F598 File Offset: 0x0002D798
		public UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize)
		{
			LanguageUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__0 <ShowNotEnoughSpaceConfirmation>d__;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowNotEnoughSpaceConfirmation>d__.<>1__state = -1;
			<ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Start<LanguageUpdateViewAgent.<ShowNotEnoughSpaceConfirmation>d__0>(ref <ShowNotEnoughSpaceConfirmation>d__);
			return <ShowNotEnoughSpaceConfirmation>d__.<>t__builder.Task;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002F5D3 File Offset: 0x0002D7D3
		public void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed)
		{
			if (this.Implement != null)
			{
				this.Implement.UpdatePatchProgress(receiveSize, curProgress, totalProgress, downloadSpeed);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002F5ED File Offset: 0x0002D7ED
		[NullableContext(2)]
		public void SetImplement(IResourceUpdateView implement)
		{
			this.Implement = implement;
		}

		// Token: 0x040002E8 RID: 744
		[Nullable(2)]
		private IResourceUpdateView Implement;
	}
}
