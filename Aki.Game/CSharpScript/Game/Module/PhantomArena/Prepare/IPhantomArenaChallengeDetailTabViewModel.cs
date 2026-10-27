using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x0200514E RID: 20814
	[NullableContext(1)]
	public interface IPhantomArenaChallengeDetailTabViewModel : IPhantomArenaTabViewModelBase
	{
		// Token: 0x170080E4 RID: 32996
		// (get) Token: 0x0603533C RID: 217916
		// (set) Token: 0x0603533D RID: 217917
		int NpcId { get; set; }

		// Token: 0x170080E5 RID: 32997
		// (get) Token: 0x0603533E RID: 217918
		// (set) Token: 0x0603533F RID: 217919
		int NpcDeckConfigId { get; set; }

		// Token: 0x170080E6 RID: 32998
		// (get) Token: 0x06035340 RID: 217920
		// (set) Token: 0x06035341 RID: 217921
		int SelectedCardRoleId { get; set; }

		// Token: 0x170080E7 RID: 32999
		// (get) Token: 0x06035342 RID: 217922
		// (set) Token: 0x06035343 RID: 217923
		int TextureCardRoleId { get; set; }

		// Token: 0x170080E8 RID: 33000
		// (get) Token: 0x06035344 RID: 217924
		// (set) Token: 0x06035345 RID: 217925
		bool RoleTextureActive { get; set; }

		// Token: 0x170080E9 RID: 33001
		// (get) Token: 0x06035346 RID: 217926
		// (set) Token: 0x06035347 RID: 217927
		bool RoleSelectedConfirmFlag { get; set; }

		// Token: 0x170080EA RID: 33002
		// (get) Token: 0x06035348 RID: 217928
		// (set) Token: 0x06035349 RID: 217929
		bool DeckSelectedConfirmFlag { get; set; }

		// Token: 0x170080EB RID: 33003
		// (get) Token: 0x0603534A RID: 217930
		// (set) Token: 0x0603534B RID: 217931
		int UsedDeckIndex { get; set; }

		// Token: 0x170080EC RID: 33004
		// (get) Token: 0x0603534C RID: 217932
		// (set) Token: 0x0603534D RID: 217933
		int SelectedDeckIndex { get; set; }

		// Token: 0x170080ED RID: 33005
		// (get) Token: 0x0603534E RID: 217934
		// (set) Token: 0x0603534F RID: 217935
		[Nullable(2)]
		DeckInfo RecommendDeck { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06035350 RID: 217936
		[NullableContext(2)]
		DeckInfo GetUsedDeck();

		// Token: 0x06035351 RID: 217937
		int GetChallengeId();

		// Token: 0x170080EE RID: 33006
		// (get) Token: 0x06035352 RID: 217938
		// (set) Token: 0x06035353 RID: 217939
		Action<int, bool> ChangeRoleTexture { get; set; }

		// Token: 0x170080EF RID: 33007
		// (get) Token: 0x06035354 RID: 217940
		// (set) Token: 0x06035355 RID: 217941
		Action<bool> ShowRoleTexture { get; set; }

		// Token: 0x170080F0 RID: 33008
		// (get) Token: 0x06035356 RID: 217942
		// (set) Token: 0x06035357 RID: 217943
		Action<bool> HideRoleTexture { get; set; }

		// Token: 0x170080F1 RID: 33009
		// (get) Token: 0x06035358 RID: 217944
		// (set) Token: 0x06035359 RID: 217945
		Action RefreshRoleTexture { get; set; }

		// Token: 0x170080F2 RID: 33010
		// (get) Token: 0x0603535A RID: 217946
		// (set) Token: 0x0603535B RID: 217947
		Action<string> SetViewTitle { get; set; }

		// Token: 0x170080F3 RID: 33011
		// (get) Token: 0x0603535C RID: 217948
		// (set) Token: 0x0603535D RID: 217949
		Action<string> SetViewIcon { get; set; }

		// Token: 0x170080F4 RID: 33012
		// (get) Token: 0x0603535E RID: 217950
		// (set) Token: 0x0603535F RID: 217951
		Action<int> SetViewHelpId { get; set; }

		// Token: 0x170080F5 RID: 33013
		// (get) Token: 0x06035360 RID: 217952
		// (set) Token: 0x06035361 RID: 217953
		Action<bool> SetViewHelpBtnActive { get; set; }
	}
}
