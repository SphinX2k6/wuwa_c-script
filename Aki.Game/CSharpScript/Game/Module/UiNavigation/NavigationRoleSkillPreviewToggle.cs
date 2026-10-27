using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004930 RID: 18736
	public class NavigationRoleSkillPreviewToggle : NavigationToggle
	{
		// Token: 0x06030ECD RID: 200397 RVA: 0x00B5BBCE File Offset: 0x00B59DCE
		[NullableContext(1)]
		public NavigationRoleSkillPreviewToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030ECE RID: 200398 RVA: 0x00B5BBDC File Offset: 0x00B59DDC
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
