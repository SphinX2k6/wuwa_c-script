using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492E RID: 18734
	public class NavigationRoleResonanceToggle : NavigationToggle
	{
		// Token: 0x06030EC8 RID: 200392 RVA: 0x00B5BAAB File Offset: 0x00B59CAB
		[NullableContext(1)]
		public NavigationRoleResonanceToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EC9 RID: 200393 RVA: 0x00B5BAB8 File Offset: 0x00B59CB8
		protected override void OnStart()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			RoleResonancePanelHandle roleResonancePanelHandle = this.PanelHandle as RoleResonancePanelHandle;
			if (roleResonancePanelHandle != null)
			{
				roleResonancePanelHandle.AddUnLockNavigationListener(this.Listener);
			}
			if (StringUtils.IsBlank((roleResonancePanelHandle != null) ? roleResonancePanelHandle.GroupName : null))
			{
				return;
			}
			uuiextendToggle.bToggleOnSelect = true;
			if (roleResonancePanelHandle != null)
			{
				roleResonancePanelHandle.SetDefaultNavigationListener(this.Listener);
			}
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x06030ECA RID: 200394 RVA: 0x00B5BB20 File Offset: 0x00B59D20
		protected override void OnToggleClick(EToggleState state)
		{
			RoleResonancePanelHandle roleResonancePanelHandle = this.PanelHandle as RoleResonancePanelHandle;
			if (roleResonancePanelHandle != null)
			{
				roleResonancePanelHandle.SetDefaultNavigationListener(this.Listener);
			}
			if (!StringUtils.IsBlank((roleResonancePanelHandle != null) ? roleResonancePanelHandle.GroupName : null))
			{
				return;
			}
			if (roleResonancePanelHandle != null)
			{
				RoleResonancePanelHandle roleResonancePanelHandle2 = roleResonancePanelHandle;
				TsUiNavigationBehaviorListener listener = this.Listener;
				roleResonancePanelHandle2.SetToggleSelectByGroupName((listener != null) ? listener.GroupName : null);
			}
		}
	}
}
