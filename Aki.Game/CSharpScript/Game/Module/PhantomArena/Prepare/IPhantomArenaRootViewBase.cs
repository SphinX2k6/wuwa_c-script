using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005148 RID: 20808
	public interface IPhantomArenaRootViewBase
	{
		// Token: 0x060352CC RID: 217804
		void OpenChildView(EPhantomArenaChildViewName viewName);

		// Token: 0x060352CD RID: 217805
		UniTask OpenChildViewAsync(EPhantomArenaChildViewName viewName);

		// Token: 0x060352CE RID: 217806
		UniTask<bool> CloseCurChildViewAsync();

		// Token: 0x060352CF RID: 217807
		void CloseCurChildView();

		// Token: 0x060352D0 RID: 217808
		void Back();
	}
}
