using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E6 RID: 20966
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardDisabledComponent : CardComponentBase<ICardDisabledComponentData>
	{
		// Token: 0x06035A3E RID: 219710 RVA: 0x00CB4D82 File Offset: 0x00CB2F82
		public override void Refresh(ICardDisabledComponentData data)
		{
			this.SetActive(data.Disabled && data.ShowComponent);
		}
	}
}
