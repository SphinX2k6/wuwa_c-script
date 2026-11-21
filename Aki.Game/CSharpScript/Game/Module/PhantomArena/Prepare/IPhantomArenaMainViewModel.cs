using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200411F RID: 16671
	[NullableContext(1)]
	public interface IPhantomArenaMainViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x0602A25E RID: 172638
		// (set) Token: 0x0602A25F RID: 172639
		int SelectedCardRoleId { get; set; }

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x0602A260 RID: 172640
		// (set) Token: 0x0602A261 RID: 172641
		int TextureCardRoleId { get; set; }

		// Token: 0x0602A262 RID: 172642
		void Init(int challengeId);

		// Token: 0x0602A263 RID: 172643
		void SetGetSwitchItemFunc(Func<PhantomArenaMainViewSwitchItem> getSwitchItemFunc);

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x0602A264 RID: 172644
		// (set) Token: 0x0602A265 RID: 172645
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x0602A266 RID: 172646
		// (set) Token: 0x0602A267 RID: 172647
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x0602A268 RID: 172648
		// (set) Token: 0x0602A269 RID: 172649
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x0602A26A RID: 172650
		// (set) Token: 0x0602A26B RID: 172651
		Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x0602A26C RID: 172652
		// (set) Token: 0x0602A26D RID: 172653
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x0602A26E RID: 172654
		// (set) Token: 0x0602A26F RID: 172655
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x0602A270 RID: 172656
		// (set) Token: 0x0602A271 RID: 172657
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x0602A272 RID: 172658
		// (set) Token: 0x0602A273 RID: 172659
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x0602A274 RID: 172660
		// (set) Token: 0x0602A275 RID: 172661
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
