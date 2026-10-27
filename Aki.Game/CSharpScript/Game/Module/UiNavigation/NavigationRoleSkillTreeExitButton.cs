using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004931 RID: 18737
	public class NavigationRoleSkillTreeExitButton : NavigationButton
	{
		// Token: 0x06030ECF RID: 200399 RVA: 0x00B5BC2F File Offset: 0x00B59E2F
		[NullableContext(1)]
		public NavigationRoleSkillTreeExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030ED0 RID: 200400 RVA: 0x00B5BC3C File Offset: 0x00B59E3C
		protected override void OnButtonClick()
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = (currentViewHandle != null) ? currentViewHandle.GetPanelConfigByType(ESpecialPanelHandleDefine.RoleSkill) : null;
			if (tsUiNavigationPanelConfig == null)
			{
				return;
			}
			RoleSkillPanelHandle roleSkillPanelHandle = tsUiNavigationPanelConfig.GetPanelHandle() as RoleSkillPanelHandle;
			if (roleSkillPanelHandle == null)
			{
				return;
			}
			roleSkillPanelHandle.ResetToggleSelect();
		}
	}
}
