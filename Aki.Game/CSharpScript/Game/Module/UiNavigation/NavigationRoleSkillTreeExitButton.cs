using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A8 RID: 14504
	public class NavigationRoleSkillTreeExitButton : NavigationButton
	{
		// Token: 0x060259FC RID: 154108 RVA: 0x00A96A9F File Offset: 0x00A94C9F
		[NullableContext(1)]
		public NavigationRoleSkillTreeExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259FD RID: 154109 RVA: 0x00A96AAC File Offset: 0x00A94CAC
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
