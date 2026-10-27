using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519B RID: 20891
	[NullableContext(1)]
	public interface ICardTabItemData
	{
		// Token: 0x1700818F RID: 33167
		// (get) Token: 0x0603573C RID: 218940
		// (set) Token: 0x0603573D RID: 218941
		ECardTabType TabType { get; set; }

		// Token: 0x17008190 RID: 33168
		// (get) Token: 0x0603573E RID: 218942
		// (set) Token: 0x0603573F RID: 218943
		ECardElement? ElementConfigId { get; set; }

		// Token: 0x17008191 RID: 33169
		// (get) Token: 0x06035740 RID: 218944
		// (set) Token: 0x06035741 RID: 218945
		string TabTexturePath { get; set; }

		// Token: 0x17008192 RID: 33170
		// (get) Token: 0x06035742 RID: 218946
		// (set) Token: 0x06035743 RID: 218947
		string TabElementColor { get; set; }

		// Token: 0x17008193 RID: 33171
		// (get) Token: 0x06035744 RID: 218948
		// (set) Token: 0x06035745 RID: 218949
		bool ShowRedDot { get; set; }

		// Token: 0x17008194 RID: 33172
		// (get) Token: 0x06035746 RID: 218950
		// (set) Token: 0x06035747 RID: 218951
		bool IsDisable { get; set; }

		// Token: 0x17008195 RID: 33173
		// (get) Token: 0x06035748 RID: 218952
		// (set) Token: 0x06035749 RID: 218953
		bool IsArrivedMax { get; set; }
	}
}
