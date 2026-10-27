using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB6 RID: 23734
	[NullableContext(1)]
	public interface IBattleTopPanelHook
	{
		// Token: 0x0603BF82 RID: 245634
		UniTask OnInitAsync(TopPanel topPanel);

		// Token: 0x0603BF83 RID: 245635
		void OnShow(TopPanel topPanel);

		// Token: 0x0603BF84 RID: 245636
		void OnHide(TopPanel topPanel);

		// Token: 0x0603BF85 RID: 245637
		void OnAddEventListener(TopPanel topPanel);

		// Token: 0x0603BF86 RID: 245638
		void OnRemoveEventListener(TopPanel topPanel);

		// Token: 0x0603BF87 RID: 245639
		void OnRefresh(TopPanel topPanel);

		// Token: 0x0603BF88 RID: 245640
		void OnReset(TopPanel topPanel);
	}
}
