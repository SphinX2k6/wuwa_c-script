using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003893 RID: 14483
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationSlider : NavigationSelectableBase
	{
		// Token: 0x060259A3 RID: 154019 RVA: 0x00A95C81 File Offset: 0x00A93E81
		public NavigationSlider(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259A4 RID: 154020 RVA: 0x00A95C8C File Offset: 0x00A93E8C
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return false;
		}
	}
}
