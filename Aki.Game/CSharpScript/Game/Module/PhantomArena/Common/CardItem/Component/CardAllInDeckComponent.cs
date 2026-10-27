using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051DF RID: 20959
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardAllInDeckComponent : CardComponentBase<ICardAllInDeckComponentData>
	{
		// Token: 0x06035A19 RID: 219673 RVA: 0x00CB4AE6 File Offset: 0x00CB2CE6
		public override void Refresh(ICardAllInDeckComponentData data)
		{
			this.SetActive(data.IsAllInDeck && data.ShowComponent);
		}
	}
}
