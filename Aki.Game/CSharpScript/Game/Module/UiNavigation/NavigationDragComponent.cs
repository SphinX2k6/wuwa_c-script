using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004917 RID: 18711
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationDragComponent : NavigationSelectableBase
	{
		// Token: 0x06030E3F RID: 200255 RVA: 0x00B5A59A File Offset: 0x00B5879A
		public NavigationDragComponent(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E40 RID: 200256 RVA: 0x00B5A5A5 File Offset: 0x00B587A5
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
