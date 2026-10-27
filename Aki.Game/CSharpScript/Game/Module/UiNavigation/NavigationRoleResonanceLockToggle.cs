using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492D RID: 18733
	public class NavigationRoleResonanceLockToggle : NavigationToggle
	{
		// Token: 0x06030EC5 RID: 200389 RVA: 0x00B5B9DF File Offset: 0x00B59BDF
		[NullableContext(1)]
		public NavigationRoleResonanceLockToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EC6 RID: 200390 RVA: 0x00B5B9EC File Offset: 0x00B59BEC
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

		// Token: 0x06030EC7 RID: 200391 RVA: 0x00B5BA54 File Offset: 0x00B59C54
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
