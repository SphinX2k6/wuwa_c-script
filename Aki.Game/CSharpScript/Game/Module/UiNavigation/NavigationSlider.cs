using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491C RID: 18716
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationSlider : NavigationSelectableBase
	{
		// Token: 0x06030E76 RID: 200310 RVA: 0x00B5AE11 File Offset: 0x00B59011
		public NavigationSlider(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E77 RID: 200311 RVA: 0x00B5AE1C File Offset: 0x00B5901C
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
