using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004933 RID: 18739
	public class NavigationRouletteExitButton : NavigationButton, INavigationInteractPrevGroup
	{
		// Token: 0x06030ED8 RID: 200408 RVA: 0x00B5BD65 File Offset: 0x00B59F65
		[NullableContext(1)]
		public NavigationRouletteExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030ED9 RID: 200409 RVA: 0x00B5BD70 File Offset: 0x00B59F70
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
