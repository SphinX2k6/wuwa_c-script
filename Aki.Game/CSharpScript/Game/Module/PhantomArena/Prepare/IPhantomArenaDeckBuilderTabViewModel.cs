using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200411C RID: 16668
	[NullableContext(1)]
	public interface IPhantomArenaDeckBuilderTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x0602A204 RID: 172548
		// (set) Token: 0x0602A205 RID: 172549
		Dictionary<int, int> QuicklyBuildDeckUseTimes { get; set; }

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x0602A206 RID: 172550
		// (set) Token: 0x0602A207 RID: 172551
		int LastQuicklyBuildId { get; set; }

		// Token: 0x0602A208 RID: 172552
		[NullableContext(2)]
		DeckInfo GetCurEditDeck();

		// Token: 0x0602A209 RID: 172553
		bool CheckCurEditDeckHasChange();

		// Token: 0x0602A20A RID: 172554
		[NullableContext(2)]
		PhantomArenaMainViewSwitchItem GetSwitchItem();

		// Token: 0x0602A20B RID: 172555
		void UpdateEditableDeckList();

		// Token: 0x0602A20C RID: 172556
		void SetOverrideCloseFunc(Action func);

		// Token: 0x0602A20D RID: 172557
		void ResetOverrideCloseFunc();

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x0602A20E RID: 172558
		// (set) Token: 0x0602A20F RID: 172559
		Action<string> SetViewTitle { get; set; }

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x0602A210 RID: 172560
		// (set) Token: 0x0602A211 RID: 172561
		Action<string> SetViewIcon { get; set; }

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x0602A212 RID: 172562
		// (set) Token: 0x0602A213 RID: 172563
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x0602A214 RID: 172564
		// (set) Token: 0x0602A215 RID: 172565
		Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x0602A216 RID: 172566
		void EndEditDeck();

		// Token: 0x0602A217 RID: 172567
		void RecordQuicklyBuildClick(int quicklyBuildId);

		// Token: 0x0602A218 RID: 172568
		void ReportDeckCreate(DeckInfo deckInfo);

		// Token: 0x0602A219 RID: 172569
		void ReportDeckCover(DeckInfo deckInfo);
	}
}
