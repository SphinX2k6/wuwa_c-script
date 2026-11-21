using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200411E RID: 16670
	[NullableContext(1)]
	public interface IPhantomArenaChallengeDetailTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x0602A238 RID: 172600
		// (set) Token: 0x0602A239 RID: 172601
		int NpcId { get; set; }

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x0602A23A RID: 172602
		// (set) Token: 0x0602A23B RID: 172603
		int NpcDeckConfigId { get; set; }

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x0602A23C RID: 172604
		// (set) Token: 0x0602A23D RID: 172605
		int SelectedCardRoleId { get; set; }

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x0602A23E RID: 172606
		// (set) Token: 0x0602A23F RID: 172607
		int TextureCardRoleId { get; set; }

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x0602A240 RID: 172608
		// (set) Token: 0x0602A241 RID: 172609
		bool RoleTextureActive { get; set; }

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x0602A242 RID: 172610
		// (set) Token: 0x0602A243 RID: 172611
		bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x0602A244 RID: 172612
		// (set) Token: 0x0602A245 RID: 172613
		bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x0602A246 RID: 172614
		// (set) Token: 0x0602A247 RID: 172615
		int UsedDeckIndex { get; set; }

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x0602A248 RID: 172616
		// (set) Token: 0x0602A249 RID: 172617
		int SelectedDeckIndex { get; set; }

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x0602A24A RID: 172618
		// (set) Token: 0x0602A24B RID: 172619
		[Nullable(2)]
		DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602A24C RID: 172620
		[NullableContext(2)]
		DeckInfo GetUsedDeck();

		// Token: 0x0602A24D RID: 172621
		int GetChallengeId();

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x0602A24E RID: 172622
		// (set) Token: 0x0602A24F RID: 172623
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x0602A250 RID: 172624
		// (set) Token: 0x0602A251 RID: 172625
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x0602A252 RID: 172626
		// (set) Token: 0x0602A253 RID: 172627
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x0602A254 RID: 172628
		// (set) Token: 0x0602A255 RID: 172629
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x0602A256 RID: 172630
		// (set) Token: 0x0602A257 RID: 172631
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x0602A258 RID: 172632
		// (set) Token: 0x0602A259 RID: 172633
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x0602A25A RID: 172634
		// (set) Token: 0x0602A25B RID: 172635
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x0602A25C RID: 172636
		// (set) Token: 0x0602A25D RID: 172637
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
