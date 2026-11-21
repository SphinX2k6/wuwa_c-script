using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003579 RID: 13689
	[NullableContext(1)]
	public interface ICommonPopView
	{
		// Token: 0x06022E3A RID: 142906
		UUIItem GetAttachParent();

		// Token: 0x06022E3B RID: 142907
		void OnSetCloseBtnInteractive(bool state);

		// Token: 0x06022E3C RID: 142908
		void OnSetHelpButtonActive(bool state);

		// Token: 0x06022E3D RID: 142909
		void OnSetTitleByTextIdAndArg(string textId, params object[] args);

		// Token: 0x06022E3E RID: 142910
		void OnSetBackBtnShowState(bool state);

		// Token: 0x06022E3F RID: 142911
		void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList);
	}
}
