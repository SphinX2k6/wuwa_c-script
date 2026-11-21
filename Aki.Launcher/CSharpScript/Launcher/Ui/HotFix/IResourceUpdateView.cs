using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EE RID: 238
	public interface IResourceUpdateView
	{
		// Token: 0x0600080B RID: 2059
		UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize);

		// Token: 0x0600080C RID: 2060
		void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed);
	}
}
