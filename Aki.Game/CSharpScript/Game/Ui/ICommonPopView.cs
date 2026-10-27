using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004648 RID: 17992
	[NullableContext(1)]
	public interface ICommonPopView
	{
		// Token: 0x0602E6F0 RID: 190192
		UUIItem GetAttachParent();

		// Token: 0x0602E6F1 RID: 190193
		void OnSetCloseBtnInteractive(bool state);

		// Token: 0x0602E6F2 RID: 190194
		void OnSetHelpButtonActive(bool state);

		// Token: 0x0602E6F3 RID: 190195
		void OnSetTitleByTextIdAndArg(string textId, params object[] args);

		// Token: 0x0602E6F4 RID: 190196
		void OnSetBackBtnShowState(bool state);

		// Token: 0x0602E6F5 RID: 190197
		void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList);
	}
}
