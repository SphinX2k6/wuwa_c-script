using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200388C RID: 14476
	public class NavigationInventoryItemGridToggle : NavigationToggle
	{
		// Token: 0x06025961 RID: 153953 RVA: 0x00A95228 File Offset: 0x00A93428
		[NullableContext(1)]
		public NavigationInventoryItemGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025962 RID: 153954 RVA: 0x00A95234 File Offset: 0x00A93434
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
