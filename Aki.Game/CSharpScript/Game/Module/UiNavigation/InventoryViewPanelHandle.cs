using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003874 RID: 14452
	public class InventoryViewPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258D6 RID: 153814 RVA: 0x00A935F9 File Offset: 0x00A917F9
		[NullableContext(1)]
		public InventoryViewPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x060258D7 RID: 153815 RVA: 0x00A93602 File Offset: 0x00A91802
		public bool IsInDestroyMode
		{
			get
			{
				return this.IsInDestroyModeInternal;
			}
		}

		// Token: 0x060258D8 RID: 153816 RVA: 0x00A9360C File Offset: 0x00A9180C
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

		// Token: 0x060258D9 RID: 153817 RVA: 0x00A93680 File Offset: 0x00A91880
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

		// Token: 0x04014C2B RID: 85035
		private bool IsInDestroyModeInternal;
	}
}
