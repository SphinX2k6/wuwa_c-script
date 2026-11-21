using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004118 RID: 16664
	public interface IPhantomArenaRootViewBase
	{
		// Token: 0x0602A1C8 RID: 172488
		void OpenChildView(EPhantomArenaChildViewName viewName);

		// Token: 0x0602A1C9 RID: 172489
		UniTask OpenChildViewAsync(EPhantomArenaChildViewName viewName);

		// Token: 0x0602A1CA RID: 172490
		UniTask<bool> CloseCurChildViewAsync();

		// Token: 0x0602A1CB RID: 172491
		void CloseCurChildView();

		// Token: 0x0602A1CC RID: 172492
		void Back();
	}
}
