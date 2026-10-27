using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x020052B9 RID: 21177
	public interface IPhantomCardProxy : IPhantomCardProxyBase
	{
		// Token: 0x060362B1 RID: 221873
		void PointerClickCard(int id, EToggleState state);

		// Token: 0x060362B2 RID: 221874
		void PointerEnterCard(int id);

		// Token: 0x060362B3 RID: 221875
		[NullableContext(1)]
		void PointerDownCard(int id, ULGUIPointerEventData eventData);
	}
}
