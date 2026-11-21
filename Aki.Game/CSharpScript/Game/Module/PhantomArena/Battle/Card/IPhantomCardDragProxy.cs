using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x0200428A RID: 17034
	[NullableContext(1)]
	public interface IPhantomCardDragProxy : IPhantomCardProxyBase
	{
		// Token: 0x0602B1AF RID: 176559
		void PointerBeginDrag(int id, ULGUIPointerEventData eventData);

		// Token: 0x0602B1B0 RID: 176560
		void PointerDragCard(int id, ULGUIPointerEventData eventData);

		// Token: 0x0602B1B1 RID: 176561
		void PointerEndDrag(int id, ULGUIPointerEventData eventData);
	}
}
