using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051C6 RID: 20934
	public abstract class CardComponentBase<[Nullable(2)] TData> : UiPanelBase, ICardComponentBase
	{
		// Token: 0x06035999 RID: 219545
		[NullableContext(1)]
		public abstract void Refresh(TData data);
	}
}
