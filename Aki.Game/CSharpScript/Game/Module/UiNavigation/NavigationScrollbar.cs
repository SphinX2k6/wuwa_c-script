using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388F RID: 14479
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationScrollbar : NavigationSelectableBase
	{
		// Token: 0x0602596E RID: 153966 RVA: 0x00A95418 File Offset: 0x00A93618
		public NavigationScrollbar(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602596F RID: 153967 RVA: 0x00A95423 File Offset: 0x00A93623
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
