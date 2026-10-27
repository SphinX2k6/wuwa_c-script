using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048FD RID: 18685
	public class InventoryViewPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DA9 RID: 200105 RVA: 0x00B58789 File Offset: 0x00B56989
		[NullableContext(1)]
		public InventoryViewPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x170079BF RID: 31167
		// (get) Token: 0x06030DAA RID: 200106 RVA: 0x00B58792 File Offset: 0x00B56992
		public bool IsInDestroyMode
		{
			get
			{
				return this.IsInDestroyModeInternal;
			}
		}

		// Token: 0x06030DAB RID: 200107 RVA: 0x00B5879C File Offset: 0x00B5699C
		[NullableContext(2)]
		private NavigationGroup FindItemGridGroupConfig()
		{
			string groupName = "";
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in this.DefaultNavigationListener)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == ENavigationSelectableDefine.InventoryItemGridToggle)
				{
					groupName = tsUiNavigationBehaviorListener.GroupName;
					break;
				}
			}
			return base.GetNavigationGroup(groupName);
		}

		// Token: 0x06030DAC RID: 200108 RVA: 0x00B58810 File Offset: 0x00B56A10
		public void SetItemGridDestroyMode(bool isInDestroyMode)
		{
			this.IsInDestroyModeInternal = isInDestroyMode;
			NavigationGroup navigationGroup = this.FindItemGridGroupConfig();
			if (navigationGroup == null)
			{
				return;
			}
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				UUIExtendToggle uuiextendToggle = tsUiNavigationBehaviorListener.GetBehaviorComponent() as UUIExtendToggle;
				if (uuiextendToggle != null)
				{
					uuiextendToggle.bToggleOnSelect = !isInDestroyMode;
				}
			}
		}

		// Token: 0x0401A3B8 RID: 107448
		private bool IsInDestroyModeInternal;
	}
}
