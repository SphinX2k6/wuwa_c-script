using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AD RID: 14509
	public class NavigationVisionTabViewReplaceButton : NavigationButton, INavigationInteractClick
	{
		// Token: 0x06025A0E RID: 154126 RVA: 0x00A96F48 File Offset: 0x00A95148
		[NullableContext(1)]
		public NavigationVisionTabViewReplaceButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A0F RID: 154127 RVA: 0x00A96F53 File Offset: 0x00A95153
		public void InteractClickHandle()
		{
			UiNavigationGlobalData.VisionReplaceViewFindDefault = true;
		}
	}
}
