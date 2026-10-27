using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004918 RID: 18712
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationScrollbar : NavigationSelectableBase
	{
		// Token: 0x06030E41 RID: 200257 RVA: 0x00B5A5A8 File Offset: 0x00B587A8
		public NavigationScrollbar(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E42 RID: 200258 RVA: 0x00B5A5B3 File Offset: 0x00B587B3
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
