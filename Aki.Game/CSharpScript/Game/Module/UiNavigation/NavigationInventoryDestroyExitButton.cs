using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388B RID: 14475
	public class NavigationInventoryDestroyExitButton : NavigationButton
	{
		// Token: 0x0602595F RID: 153951 RVA: 0x00A95205 File Offset: 0x00A93405
		[NullableContext(1)]
		public NavigationInventoryDestroyExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025960 RID: 153952 RVA: 0x00A95210 File Offset: 0x00A93410
		protected override void OnButtonClick()
		{
			InventoryViewPanelHandle inventoryViewPanelHandle = this.PanelHandle as InventoryViewPanelHandle;
			if (inventoryViewPanelHandle == null)
			{
				return;
			}
			inventoryViewPanelHandle.SetItemGridDestroyMode(false);
		}
	}
}
