using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200514F RID: 20815
	[NullableContext(1)]
	public interface IPhantomArenaMainViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170080F6 RID: 33014
		// (get) Token: 0x06035362 RID: 217954
		// (set) Token: 0x06035363 RID: 217955
		int SelectedCardRoleId { get; set; }

		// Token: 0x170080F7 RID: 33015
		// (get) Token: 0x06035364 RID: 217956
		// (set) Token: 0x06035365 RID: 217957
		int TextureCardRoleId { get; set; }

		// Token: 0x06035366 RID: 217958
		void Init(int challengeId);

		// Token: 0x06035367 RID: 217959
		void SetGetSwitchItemFunc(Func<PhantomArenaMainViewSwitchItem> getSwitchItemFunc);

		// Token: 0x170080F8 RID: 33016
		// (get) Token: 0x06035368 RID: 217960
		// (set) Token: 0x06035369 RID: 217961
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170080F9 RID: 33017
		// (get) Token: 0x0603536A RID: 217962
		// (set) Token: 0x0603536B RID: 217963
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170080FA RID: 33018
		// (get) Token: 0x0603536C RID: 217964
		// (set) Token: 0x0603536D RID: 217965
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170080FB RID: 33019
		// (get) Token: 0x0603536E RID: 217966
		// (set) Token: 0x0603536F RID: 217967
		Action PlayRoleTextureShowAnim { get; set; }

		// Token: 0x170080FC RID: 33020
		// (get) Token: 0x06035370 RID: 217968
		// (set) Token: 0x06035371 RID: 217969
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170080FD RID: 33021
		// (get) Token: 0x06035372 RID: 217970
		// (set) Token: 0x06035373 RID: 217971
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170080FE RID: 33022
		// (get) Token: 0x06035374 RID: 217972
		// (set) Token: 0x06035375 RID: 217973
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170080FF RID: 33023
		// (get) Token: 0x06035376 RID: 217974
		// (set) Token: 0x06035377 RID: 217975
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x17008100 RID: 33024
		// (get) Token: 0x06035378 RID: 217976
		// (set) Token: 0x06035379 RID: 217977
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
