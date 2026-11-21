using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200411B RID: 16667
	[NullableContext(1)]
	public interface IPhantomArenaDeckOverviewTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x0602A1E5 RID: 172517
		// (set) Token: 0x0602A1E6 RID: 172518
		int UsedDeckIndex { get; set; }

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x0602A1E7 RID: 172519
		// (set) Token: 0x0602A1E8 RID: 172520
		int SelectedDeckIndex { get; set; }

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x0602A1E9 RID: 172521
		// (set) Token: 0x0602A1EA RID: 172522
		[Nullable(2)]
		DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x0602A1EB RID: 172523
		// (set) Token: 0x0602A1EC RID: 172524
		List<DeckInfo> EditableDeckList { get; set; }

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x0602A1ED RID: 172525
		// (set) Token: 0x0602A1EE RID: 172526
		bool CanShowSelectBtnInDeckOverviewTabView { get; set; }

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x0602A1EF RID: 172527
		// (set) Token: 0x0602A1F0 RID: 172528
		bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x0602A1F1 RID: 172529
		DeckInfo CreateEmptyTempDeck();

		// Token: 0x0602A1F2 RID: 172530
		DeckInfo CreateTempDeckFromDeck(DeckInfo srcDeck);

		// Token: 0x0602A1F3 RID: 172531
		void StartEditDeck(DeckInfo deck);

		// Token: 0x0602A1F4 RID: 172532
		void UpdateEditableDeckList();

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x0602A1F5 RID: 172533
		// (set) Token: 0x0602A1F6 RID: 172534
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x0602A1F7 RID: 172535
		// (set) Token: 0x0602A1F8 RID: 172536
		Action<string> SetViewTitle { get; set; }

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x0602A1F9 RID: 172537
		// (set) Token: 0x0602A1FA RID: 172538
		Action<string> SetViewIcon { get; set; }

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x0602A1FB RID: 172539
		// (set) Token: 0x0602A1FC RID: 172540
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x0602A1FD RID: 172541
		// (set) Token: 0x0602A1FE RID: 172542
		Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x0602A1FF RID: 172543
		void ReportDeckCreate(DeckInfo deckInfo);

		// Token: 0x0602A200 RID: 172544
		void ReportDeckCover(DeckInfo deckInfo);

		// Token: 0x0602A201 RID: 172545
		void ReportDeckDelete(DeckInfo deckInfo);

		// Token: 0x0602A202 RID: 172546
		void SetOverrideCloseFunc(Action func);

		// Token: 0x0602A203 RID: 172547
		void ResetOverrideCloseFunc();
	}
}
