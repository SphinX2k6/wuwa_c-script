using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004915 RID: 18709
	public class NavigationInventoryItemGridToggle : NavigationToggle
	{
		// Token: 0x06030E34 RID: 200244 RVA: 0x00B5A3B8 File Offset: 0x00B585B8
		[NullableContext(1)]
		public NavigationInventoryItemGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E35 RID: 200245 RVA: 0x00B5A3C4 File Offset: 0x00B585C4
		protected override void OnStart()
		{
			SpecialPanelHandleBase panelHandle = this.PanelHandle;
			if (((panelHandle != null) ? new ESpecialPanelHandleDefine?(panelHandle.GetType()) : null) == ESpecialPanelHandleDefine.Inventory)
			{
				InventoryViewPanelHandle inventoryViewPanelHandle = this.PanelHandle as InventoryViewPanelHandle;
				(this.Selectable as UUIExtendToggle).bToggleOnSelect = !inventoryViewPanelHandle.IsInDestroyMode;
			}
		}
	}
}
