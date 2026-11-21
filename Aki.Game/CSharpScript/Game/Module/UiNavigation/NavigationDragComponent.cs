using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388E RID: 14478
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationDragComponent : NavigationSelectableBase
	{
		// Token: 0x0602596C RID: 153964 RVA: 0x00A9540A File Offset: 0x00A9360A
		public NavigationDragComponent(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602596D RID: 153965 RVA: 0x00A95415 File Offset: 0x00A93615
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
