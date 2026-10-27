using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492F RID: 18735
	public class NavigationRoleSkillPreviewExitButton : NavigationButton
	{
		// Token: 0x06030ECB RID: 200395 RVA: 0x00B5BB77 File Offset: 0x00B59D77
		[NullableContext(1)]
		public NavigationRoleSkillPreviewExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030ECC RID: 200396 RVA: 0x00B5BB84 File Offset: 0x00B59D84
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
