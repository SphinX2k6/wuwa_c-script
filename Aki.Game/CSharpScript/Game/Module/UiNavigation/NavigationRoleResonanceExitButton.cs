using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A3 RID: 14499
	public class NavigationRoleResonanceExitButton : NavigationButton
	{
		// Token: 0x060259F0 RID: 154096 RVA: 0x00A967F2 File Offset: 0x00A949F2
		[NullableContext(1)]
		public NavigationRoleResonanceExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259F1 RID: 154097 RVA: 0x00A96800 File Offset: 0x00A94A00
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
