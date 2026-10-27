using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EA RID: 234
	public interface IResourceUpdateView
	{
		// Token: 0x060007D7 RID: 2007
		UniTask<bool> ShowNotEnoughSpaceConfirmation(long totalSize);

		// Token: 0x060007D8 RID: 2008
		void UpdatePatchProgress(long receiveSize, long curProgress, long totalProgress, long downloadSpeed);
	}
}
