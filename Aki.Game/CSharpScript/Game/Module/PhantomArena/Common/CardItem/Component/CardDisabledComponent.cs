using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B6 RID: 16822
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardDisabledComponent : CardComponentBase<ICardDisabledComponentData>
	{
		// Token: 0x0602A939 RID: 174393 RVA: 0x00C023BE File Offset: 0x00C005BE
		public override void Refresh(ICardDisabledComponentData data)
		{
			this.SetActive(data.Disabled && data.ShowComponent);
		}
	}
}
