using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004909 RID: 18697
	public class NavigationCantFocusInScrollOrLayoutByJumpGroupButton : NavigationButton
	{
		// Token: 0x06030E1E RID: 200222 RVA: 0x00B5A0DF File Offset: 0x00B582DF
		[NullableContext(1)]
		public NavigationCantFocusInScrollOrLayoutByJumpGroupButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E1F RID: 200223 RVA: 0x00B5A0EA File Offset: 0x00B582EA
		protected override bool OnCanFocusInScrollOrLayout()
		{
			return false;
		}
	}
}
