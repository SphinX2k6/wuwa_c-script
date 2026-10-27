using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.New.Vision
{
	// Token: 0x02004A06 RID: 18950
	public class NavigationVisionReplaceSortTabToggle : NavigationToggle
	{
		// Token: 0x060312E5 RID: 201445 RVA: 0x00B682FB File Offset: 0x00B664FB
		[NullableContext(1)]
		public NavigationVisionReplaceSortTabToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060312E6 RID: 201446 RVA: 0x00B68308 File Offset: 0x00B66508
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
