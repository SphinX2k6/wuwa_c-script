using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004937 RID: 18743
	public class NavigationVisionTabViewToggle : NavigationDragComponent, INavigationInteractClick, INavigationInteractFailClick
	{
		// Token: 0x06030EE3 RID: 200419 RVA: 0x00B5C0EB File Offset: 0x00B5A2EB
		[NullableContext(1)]
		public NavigationVisionTabViewToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EE4 RID: 200420 RVA: 0x00B5C0F6 File Offset: 0x00B5A2F6
		public void InteractClickFailHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = false;
		}

		// Token: 0x06030EE5 RID: 200421 RVA: 0x00B5C0FE File Offset: 0x00B5A2FE
		public void InteractClickHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = false;
		}
	}
}
