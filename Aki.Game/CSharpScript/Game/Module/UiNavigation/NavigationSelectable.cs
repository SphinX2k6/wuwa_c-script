using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004919 RID: 18713
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationSelectable : NavigationSelectableBase
	{
		// Token: 0x06030E43 RID: 200259 RVA: 0x00B5A5B6 File Offset: 0x00B587B6
		public NavigationSelectable(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E44 RID: 200260 RVA: 0x00B5A5C1 File Offset: 0x00B587C1
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
