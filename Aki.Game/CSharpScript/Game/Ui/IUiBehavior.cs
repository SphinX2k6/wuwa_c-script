using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003552 RID: 13650
	public interface IUiBehavior
	{
		// Token: 0x06022B49 RID: 142153
		UniTask OnUiCreateAsync();

		// Token: 0x06022B4A RID: 142154
		void OnUiStart();

		// Token: 0x06022B4B RID: 142155
		void OnUiShow();

		// Token: 0x06022B4C RID: 142156
		void OnUiHide();

		// Token: 0x06022B4D RID: 142157
		void OnDestroy();
	}
}
