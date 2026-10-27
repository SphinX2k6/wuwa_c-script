using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200514C RID: 20812
	[NullableContext(1)]
	public interface IPhantomArenaDeckBuilderTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170080CF RID: 32975
		// (get) Token: 0x06035308 RID: 217864
		// (set) Token: 0x06035309 RID: 217865
		Dictionary<int, int> QuicklyBuildDeckUseTimes { get; set; }

		// Token: 0x170080D0 RID: 32976
		// (get) Token: 0x0603530A RID: 217866
		// (set) Token: 0x0603530B RID: 217867
		int LastQuicklyBuildId { get; set; }

		// Token: 0x0603530C RID: 217868
		[NullableContext(2)]
		DeckInfo GetCurEditDeck();

		// Token: 0x0603530D RID: 217869
		bool CheckCurEditDeckHasChange();

		// Token: 0x0603530E RID: 217870
		[NullableContext(2)]
		PhantomArenaMainViewSwitchItem GetSwitchItem();

		// Token: 0x0603530F RID: 217871
		void UpdateEditableDeckList();

		// Token: 0x06035310 RID: 217872
		void SetOverrideCloseFunc(Action func);

		// Token: 0x06035311 RID: 217873
		void ResetOverrideCloseFunc();

		// Token: 0x170080D1 RID: 32977
		// (get) Token: 0x06035312 RID: 217874
		// (set) Token: 0x06035313 RID: 217875
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170080D2 RID: 32978
		// (get) Token: 0x06035314 RID: 217876
		// (set) Token: 0x06035315 RID: 217877
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170080D3 RID: 32979
		// (get) Token: 0x06035316 RID: 217878
		// (set) Token: 0x06035317 RID: 217879
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170080D4 RID: 32980
		// (get) Token: 0x06035318 RID: 217880
		// (set) Token: 0x06035319 RID: 217881
		Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x0603531A RID: 217882
		void EndEditDeck();

		// Token: 0x0603531B RID: 217883
		void RecordQuicklyBuildClick(int quicklyBuildId);

		// Token: 0x0603531C RID: 217884
		void ReportDeckCreate(DeckInfo deckInfo);

		// Token: 0x0603531D RID: 217885
		void ReportDeckCover(DeckInfo deckInfo);
	}
}
