using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041AF RID: 16815
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardAllInDeckComponent : CardComponentBase<ICardAllInDeckComponentData>
	{
		// Token: 0x0602A914 RID: 174356 RVA: 0x00C02122 File Offset: 0x00C00322
		public override void Refresh(ICardAllInDeckComponentData data)
		{
			this.SetActive(data.IsAllInDeck && data.ShowComponent);
		}
	}
}
