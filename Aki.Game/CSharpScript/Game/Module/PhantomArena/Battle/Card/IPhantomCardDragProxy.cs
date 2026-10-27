using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x020052BA RID: 21178
	[NullableContext(1)]
	public interface IPhantomCardDragProxy : IPhantomCardProxyBase
	{
		// Token: 0x060362B4 RID: 221876
		void PointerBeginDrag(int id, ULGUIPointerEventData eventData);

		// Token: 0x060362B5 RID: 221877
		void PointerDragCard(int id, ULGUIPointerEventData eventData);

		// Token: 0x060362B6 RID: 221878
		void PointerEndDrag(int id, ULGUIPointerEventData eventData);
	}
}
