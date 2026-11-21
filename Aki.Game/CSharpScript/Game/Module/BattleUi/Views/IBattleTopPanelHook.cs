using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C98 RID: 19608
	[NullableContext(1)]
	public interface IBattleTopPanelHook
	{
		// Token: 0x06030ED5 RID: 200405
		UniTask OnInitAsync(TopPanel topPanel);

		// Token: 0x06030ED6 RID: 200406
		void OnShow(TopPanel topPanel);

		// Token: 0x06030ED7 RID: 200407
		void OnHide(TopPanel topPanel);

		// Token: 0x06030ED8 RID: 200408
		void OnAddEventListener(TopPanel topPanel);

		// Token: 0x06030ED9 RID: 200409
		void OnRemoveEventListener(TopPanel topPanel);

		// Token: 0x06030EDA RID: 200410
		void OnRefresh(TopPanel topPanel);

		// Token: 0x06030EDB RID: 200411
		void OnReset(TopPanel topPanel);
	}
}
