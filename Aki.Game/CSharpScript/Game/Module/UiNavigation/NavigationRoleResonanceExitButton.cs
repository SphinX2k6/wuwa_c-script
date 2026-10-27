using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492C RID: 18732
	public class NavigationRoleResonanceExitButton : NavigationButton
	{
		// Token: 0x06030EC3 RID: 200387 RVA: 0x00B5B982 File Offset: 0x00B59B82
		[NullableContext(1)]
		public NavigationRoleResonanceExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EC4 RID: 200388 RVA: 0x00B5B990 File Offset: 0x00B59B90
		protected override void OnButtonClick()
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = (currentViewHandle != null) ? currentViewHandle.GetPanelConfigByType(ESpecialPanelHandleDefine.RoleResonance) : null;
			if (tsUiNavigationPanelConfig == null)
			{
				return;
			}
			RoleResonancePanelHandle roleResonancePanelHandle = tsUiNavigationPanelConfig.GetPanelHandle() as RoleResonancePanelHandle;
			if (roleResonancePanelHandle != null)
			{
				roleResonancePanelHandle.ResetToggleSelect();
			}
			if (roleResonancePanelHandle == null)
			{
				return;
			}
			roleResonancePanelHandle.SetDefaultNavigationListener(null);
		}
	}
}
