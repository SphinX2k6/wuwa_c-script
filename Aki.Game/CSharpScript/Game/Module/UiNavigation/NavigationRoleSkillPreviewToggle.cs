using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A7 RID: 14503
	public class NavigationRoleSkillPreviewToggle : NavigationToggle
	{
		// Token: 0x060259FA RID: 154106 RVA: 0x00A96A3E File Offset: 0x00A94C3E
		[NullableContext(1)]
		public NavigationRoleSkillPreviewToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259FB RID: 154107 RVA: 0x00A96A4C File Offset: 0x00A94C4C
		protected override void OnToggleClick(EToggleState state)
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = (currentViewHandle != null) ? currentViewHandle.GetPanelConfigByType(ESpecialPanelHandleDefine.RoleSkill) : null;
			if (tsUiNavigationPanelConfig == null)
			{
				return;
			}
			RoleSkillPanelHandle roleSkillPanelHandle = tsUiNavigationPanelConfig.GetPanelHandle() as RoleSkillPanelHandle;
			if (roleSkillPanelHandle != null)
			{
				roleSkillPanelHandle.IsInPreview = (state == EToggleState.ETT_Checked);
				roleSkillPanelHandle.SetSkillTreeToggleCursorActive(state != EToggleState.ETT_Checked);
			}
		}
	}
}
