using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004936 RID: 18742
	public class NavigationVisionTabViewReplaceButton : NavigationButton, INavigationInteractClick
	{
		// Token: 0x06030EE1 RID: 200417 RVA: 0x00B5C0D8 File Offset: 0x00B5A2D8
		[NullableContext(1)]
		public NavigationVisionTabViewReplaceButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EE2 RID: 200418 RVA: 0x00B5C0E3 File Offset: 0x00B5A2E3
		public void InteractClickHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = true;
		}
	}
}
