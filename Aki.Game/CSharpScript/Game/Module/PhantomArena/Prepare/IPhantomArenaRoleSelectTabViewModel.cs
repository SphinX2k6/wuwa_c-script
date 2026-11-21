using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200411D RID: 16669
	[NullableContext(1)]
	public interface IPhantomArenaRoleSelectTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x0602A21A RID: 172570
		// (set) Token: 0x0602A21B RID: 172571
		int SelectedCardRoleId { get; set; }

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x0602A21C RID: 172572
		// (set) Token: 0x0602A21D RID: 172573
		int TextureCardRoleId { get; set; }

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x0602A21E RID: 172574
		// (set) Token: 0x0602A21F RID: 172575
		bool RoleTextureActive { get; set; }

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x0602A220 RID: 172576
		// (set) Token: 0x0602A221 RID: 172577
		List<int> CardRoleList { get; set; }

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x0602A222 RID: 172578
		// (set) Token: 0x0602A223 RID: 172579
		bool CanShowRewardInRoleSelectTabView { get; set; }

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x0602A224 RID: 172580
		// (set) Token: 0x0602A225 RID: 172581
		bool CanShowSelectBtnInRoleSelectTabView { get; set; }

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x0602A226 RID: 172582
		// (set) Token: 0x0602A227 RID: 172583
		bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x0602A228 RID: 172584
		// (set) Token: 0x0602A229 RID: 172585
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x0602A22A RID: 172586
		// (set) Token: 0x0602A22B RID: 172587
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x0602A22C RID: 172588
		// (set) Token: 0x0602A22D RID: 172589
		Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x0602A22E RID: 172590
		// (set) Token: 0x0602A22F RID: 172591
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x0602A230 RID: 172592
		// (set) Token: 0x0602A231 RID: 172593
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x0602A232 RID: 172594
		// (set) Token: 0x0602A233 RID: 172595
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x0602A234 RID: 172596
		// (set) Token: 0x0602A235 RID: 172597
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x0602A236 RID: 172598
		// (set) Token: 0x0602A237 RID: 172599
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
