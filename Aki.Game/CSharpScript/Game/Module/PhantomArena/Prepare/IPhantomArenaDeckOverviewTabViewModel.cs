using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200514B RID: 20811
	[NullableContext(1)]
	public interface IPhantomArenaDeckOverviewTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170080C4 RID: 32964
		// (get) Token: 0x060352E9 RID: 217833
		// (set) Token: 0x060352EA RID: 217834
		int UsedDeckIndex { get; set; }

		// Token: 0x170080C5 RID: 32965
		// (get) Token: 0x060352EB RID: 217835
		// (set) Token: 0x060352EC RID: 217836
		int SelectedDeckIndex { get; set; }

		// Token: 0x170080C6 RID: 32966
		// (get) Token: 0x060352ED RID: 217837
		// (set) Token: 0x060352EE RID: 217838
		[Nullable(2)]
		DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170080C7 RID: 32967
		// (get) Token: 0x060352EF RID: 217839
		// (set) Token: 0x060352F0 RID: 217840
		List<DeckInfo> EditableDeckList { get; set; }

		// Token: 0x170080C8 RID: 32968
		// (get) Token: 0x060352F1 RID: 217841
		// (set) Token: 0x060352F2 RID: 217842
		bool CanShowSelectBtnInDeckOverviewTabView { get; set; }

		// Token: 0x170080C9 RID: 32969
		// (get) Token: 0x060352F3 RID: 217843
		// (set) Token: 0x060352F4 RID: 217844
		bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x060352F5 RID: 217845
		DeckInfo CreateEmptyTempDeck();

		// Token: 0x060352F6 RID: 217846
		DeckInfo CreateTempDeckFromDeck(DeckInfo srcDeck);

		// Token: 0x060352F7 RID: 217847
		void StartEditDeck(DeckInfo deck);

		// Token: 0x060352F8 RID: 217848
		void UpdateEditableDeckList();

		// Token: 0x170080CA RID: 32970
		// (get) Token: 0x060352F9 RID: 217849
		// (set) Token: 0x060352FA RID: 217850
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170080CB RID: 32971
		// (get) Token: 0x060352FB RID: 217851
		// (set) Token: 0x060352FC RID: 217852
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170080CC RID: 32972
		// (get) Token: 0x060352FD RID: 217853
		// (set) Token: 0x060352FE RID: 217854
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170080CD RID: 32973
		// (get) Token: 0x060352FF RID: 217855
		// (set) Token: 0x06035300 RID: 217856
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170080CE RID: 32974
		// (get) Token: 0x06035301 RID: 217857
		// (set) Token: 0x06035302 RID: 217858
		Action<bool> SetViewHelpBtnActive { get; set; }

		// Token: 0x06035303 RID: 217859
		void ReportDeckCreate(DeckInfo deckInfo);

		// Token: 0x06035304 RID: 217860
		void ReportDeckCover(DeckInfo deckInfo);

		// Token: 0x06035305 RID: 217861
		void ReportDeckDelete(DeckInfo deckInfo);

		// Token: 0x06035306 RID: 217862
		void SetOverrideCloseFunc(Action func);

		// Token: 0x06035307 RID: 217863
		void ResetOverrideCloseFunc();
	}
}
