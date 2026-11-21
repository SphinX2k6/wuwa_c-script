using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A8A RID: 23178
	[NullableContext(2)]
	public interface ICommonRootViewBase
	{
		// Token: 0x06039219 RID: 234009
		void OpenChildView(ECommonChildViewName viewName, object param = null);

		// Token: 0x0603921A RID: 234010
		UniTask OpenChildViewAsync(ECommonChildViewName viewName, object param = null);

		// Token: 0x0603921B RID: 234011
		[NullableContext(0)]
		UniTask<bool> CloseCurChildViewAsync();

		// Token: 0x0603921C RID: 234012
		void CloseCurChildView();

		// Token: 0x0603921D RID: 234013
		void Back();
	}
}
