using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.New.Vision
{
	// Token: 0x02003982 RID: 14722
	public class NavigationVisionReplaceSortTabToggle : NavigationToggle
	{
		// Token: 0x06025E33 RID: 155187 RVA: 0x00AA3A63 File Offset: 0x00AA1C63
		[NullableContext(1)]
		public NavigationVisionReplaceSortTabToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025E34 RID: 155188 RVA: 0x00AA3A70 File Offset: 0x00AA1C70
		protected override void OnToggleClick(EToggleState _)
		{
			VisionChooseMainPanelHandle visionChooseMainPanelHandle = this.PanelHandle as VisionChooseMainPanelHandle;
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener == null || visionChooseMainPanelHandle == null)
			{
				return;
			}
			if (currentNavigationFocusListener.GroupName == visionChooseMainPanelHandle.ChangeListenerList[0].GroupName)
			{
				visionChooseMainPanelHandle.IsFindChangeListenerList = true;
				UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			}
		}
	}
}
