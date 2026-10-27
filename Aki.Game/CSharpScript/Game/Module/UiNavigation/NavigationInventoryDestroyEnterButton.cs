using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004913 RID: 18707
	public class NavigationInventoryDestroyEnterButton : NavigationButton
	{
		// Token: 0x06030E30 RID: 200240 RVA: 0x00B5A372 File Offset: 0x00B58572
		[NullableContext(1)]
		public NavigationInventoryDestroyEnterButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E31 RID: 200241 RVA: 0x00B5A37D File Offset: 0x00B5857D
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
