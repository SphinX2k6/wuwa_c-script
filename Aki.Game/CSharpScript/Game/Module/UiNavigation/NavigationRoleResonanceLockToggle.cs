using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A4 RID: 14500
	public class NavigationRoleResonanceLockToggle : NavigationToggle
	{
		// Token: 0x060259F2 RID: 154098 RVA: 0x00A9684F File Offset: 0x00A94A4F
		[NullableContext(1)]
		public NavigationRoleResonanceLockToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259F3 RID: 154099 RVA: 0x00A9685C File Offset: 0x00A94A5C
		protected override void OnStart()
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			RoleResonancePanelHandle roleResonancePanelHandle = this.PanelHandle as RoleResonancePanelHandle;
			if (roleResonancePanelHandle != null)
			{
				roleResonancePanelHandle.AddLockNavigationListener(this.Listener);
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

		// Token: 0x060259F4 RID: 154100 RVA: 0x00A968C4 File Offset: 0x00A94AC4
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
