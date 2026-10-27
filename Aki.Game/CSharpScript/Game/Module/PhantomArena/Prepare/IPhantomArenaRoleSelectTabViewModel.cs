using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200514D RID: 20813
	[NullableContext(1)]
	public interface IPhantomArenaRoleSelectTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170080D5 RID: 32981
		// (get) Token: 0x0603531E RID: 217886
		// (set) Token: 0x0603531F RID: 217887
		int SelectedCardRoleId { get; set; }

		// Token: 0x170080D6 RID: 32982
		// (get) Token: 0x06035320 RID: 217888
		// (set) Token: 0x06035321 RID: 217889
		int TextureCardRoleId { get; set; }

		// Token: 0x170080D7 RID: 32983
		// (get) Token: 0x06035322 RID: 217890
		// (set) Token: 0x06035323 RID: 217891
		bool RoleTextureActive { get; set; }

		// Token: 0x170080D8 RID: 32984
		// (get) Token: 0x06035324 RID: 217892
		// (set) Token: 0x06035325 RID: 217893
		List<int> CardRoleList { get; set; }

		// Token: 0x170080D9 RID: 32985
		// (get) Token: 0x06035326 RID: 217894
		// (set) Token: 0x06035327 RID: 217895
		bool CanShowRewardInRoleSelectTabView { get; set; }

		// Token: 0x170080DA RID: 32986
		// (get) Token: 0x06035328 RID: 217896
		// (set) Token: 0x06035329 RID: 217897
		bool CanShowSelectBtnInRoleSelectTabView { get; set; }

		// Token: 0x170080DB RID: 32987
		// (get) Token: 0x0603532A RID: 217898
		// (set) Token: 0x0603532B RID: 217899
		bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x170080DC RID: 32988
		// (get) Token: 0x0603532C RID: 217900
		// (set) Token: 0x0603532D RID: 217901
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170080DD RID: 32989
		// (get) Token: 0x0603532E RID: 217902
		// (set) Token: 0x0603532F RID: 217903
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170080DE RID: 32990
		// (get) Token: 0x06035330 RID: 217904
		// (set) Token: 0x06035331 RID: 217905
		Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x170080DF RID: 32991
		// (get) Token: 0x06035332 RID: 217906
		// (set) Token: 0x06035333 RID: 217907
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170080E0 RID: 32992
		// (get) Token: 0x06035334 RID: 217908
		// (set) Token: 0x06035335 RID: 217909
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170080E1 RID: 32993
		// (get) Token: 0x06035336 RID: 217910
		// (set) Token: 0x06035337 RID: 217911
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170080E2 RID: 32994
		// (get) Token: 0x06035338 RID: 217912
		// (set) Token: 0x06035339 RID: 217913
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170080E3 RID: 32995
		// (get) Token: 0x0603533A RID: 217914
		// (set) Token: 0x0603533B RID: 217915
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
