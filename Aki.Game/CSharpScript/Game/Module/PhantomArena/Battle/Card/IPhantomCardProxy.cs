using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x02004289 RID: 17033
	public interface IPhantomCardProxy : IPhantomCardProxyBase
	{
		// Token: 0x0602B1AC RID: 176556
		void PointerClickCard(int id, EToggleState state);

		// Token: 0x0602B1AD RID: 176557
		void PointerEnterCard(int id);

		// Token: 0x0602B1AE RID: 176558
		[NullableContext(1)]
		void PointerDownCard(int id, ULGUIPointerEventData eventData);
	}
}
