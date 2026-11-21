using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388A RID: 14474
	public class NavigationInventoryDestroyEnterButton : NavigationButton
	{
		// Token: 0x0602595D RID: 153949 RVA: 0x00A951E2 File Offset: 0x00A933E2
		[NullableContext(1)]
		public NavigationInventoryDestroyEnterButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602595E RID: 153950 RVA: 0x00A951ED File Offset: 0x00A933ED
		protected override void OnButtonClick()
		{
			InventoryViewPanelHandle inventoryViewPanelHandle = this.PanelHandle as InventoryViewPanelHandle;
			if (inventoryViewPanelHandle == null)
			{
				return;
			}
			inventoryViewPanelHandle.SetItemGridDestroyMode(true);
		}
	}
}
