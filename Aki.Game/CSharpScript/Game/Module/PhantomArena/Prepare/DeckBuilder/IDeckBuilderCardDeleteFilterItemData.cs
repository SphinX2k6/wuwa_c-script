using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004152 RID: 16722
	public interface IDeckBuilderCardDeleteFilterItemData
	{
		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x0602A4FE RID: 173310
		ECardElement Element { get; }

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x0602A4FF RID: 173311
		bool Enabled { get; }

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x0602A500 RID: 173312
		bool Selected { get; }
	}
}
