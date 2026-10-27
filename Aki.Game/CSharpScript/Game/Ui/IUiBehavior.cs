using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004628 RID: 17960
	public interface IUiBehavior
	{
		// Token: 0x0602E436 RID: 189494
		UniTask OnUiCreateAsync();

		// Token: 0x0602E437 RID: 189495
		void OnAfterUiStart();

		// Token: 0x0602E438 RID: 189496
		void OnAfterUiShow();

		// Token: 0x0602E439 RID: 189497
		void OnBeforeUiHide();

		// Token: 0x0602E43A RID: 189498
		void OnBeforeDestroy();
	}
}
