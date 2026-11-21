using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AE RID: 14510
	public class NavigationVisionTabViewToggle : NavigationDragComponent, INavigationInteractClick, INavigationInteractFailClick
	{
		// Token: 0x06025A10 RID: 154128 RVA: 0x00A96F5B File Offset: 0x00A9515B
		[NullableContext(1)]
		public NavigationVisionTabViewToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A11 RID: 154129 RVA: 0x00A96F66 File Offset: 0x00A95166
		public void InteractClickFailHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = false;
		}

		// Token: 0x06025A12 RID: 154130 RVA: 0x00A96F6E File Offset: 0x00A9516E
		public void InteractClickHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = false;
		}
	}
}
