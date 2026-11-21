using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AA RID: 14506
	public class NavigationRouletteExitButton : NavigationButton, INavigationInteractPrevGroup
	{
		// Token: 0x06025A05 RID: 154117 RVA: 0x00A96BD5 File Offset: 0x00A94DD5
		[NullableContext(1)]
		public NavigationRouletteExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A06 RID: 154118 RVA: 0x00A96BE0 File Offset: 0x00A94DE0
		public void InteractClickPrevGroup()
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (((currentNavigationFocusListener != null) ? currentNavigationFocusListener.GroupName : null) == "Group1")
			{
				EventSystem.Instance.Emit(EEventName.OnRouletteItemUnlock);
			}
		}
	}
}
