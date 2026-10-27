using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004914 RID: 18708
	public class NavigationInventoryDestroyExitButton : NavigationButton
	{
		// Token: 0x06030E32 RID: 200242 RVA: 0x00B5A395 File Offset: 0x00B58595
		[NullableContext(1)]
		public NavigationInventoryDestroyExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E33 RID: 200243 RVA: 0x00B5A3A0 File Offset: 0x00B585A0
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
