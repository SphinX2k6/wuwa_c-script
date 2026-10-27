using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005182 RID: 20866
	public interface IDeckBuilderCardDeleteFilterItemData
	{
		// Token: 0x17008139 RID: 33081
		// (get) Token: 0x06035603 RID: 218627
		ECardElement Element { get; }

		// Token: 0x1700813A RID: 33082
		// (get) Token: 0x06035604 RID: 218628
		bool Enabled { get; }

		// Token: 0x1700813B RID: 33083
		// (get) Token: 0x06035605 RID: 218629
		bool Selected { get; }
	}
}
