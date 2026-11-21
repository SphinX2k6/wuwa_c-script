using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A6 RID: 14502
	public class NavigationRoleSkillPreviewExitButton : NavigationButton
	{
		// Token: 0x060259F8 RID: 154104 RVA: 0x00A969E7 File Offset: 0x00A94BE7
		[NullableContext(1)]
		public NavigationRoleSkillPreviewExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259F9 RID: 154105 RVA: 0x00A969F4 File Offset: 0x00A94BF4
		protected override void OnButtonClick()
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
				roleSkillPanelHandle.IsInPreview = false;
				roleSkillPanelHandle.SetSkillTreeToggleCursorActive(true);
			}
		}
	}
}
