using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x02004196 RID: 16790
	public abstract class CardComponentBase<[Nullable(2)] TData> : UiPanelBase, ICardComponentBase
	{
		// Token: 0x0602A894 RID: 174228
		[NullableContext(1)]
		public abstract void Refresh(TData data);
	}
}
