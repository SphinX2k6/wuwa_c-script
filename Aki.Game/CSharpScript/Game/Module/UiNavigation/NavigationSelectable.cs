using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003890 RID: 14480
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationSelectable : NavigationSelectableBase
	{
		// Token: 0x06025970 RID: 153968 RVA: 0x00A95426 File Offset: 0x00A93626
		public NavigationSelectable(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025971 RID: 153969 RVA: 0x00A95431 File Offset: 0x00A93631
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
