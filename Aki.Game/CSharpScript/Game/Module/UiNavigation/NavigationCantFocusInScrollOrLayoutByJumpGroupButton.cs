using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003880 RID: 14464
	public class NavigationCantFocusInScrollOrLayoutByJumpGroupButton : NavigationButton
	{
		// Token: 0x0602594B RID: 153931 RVA: 0x00A94F4F File Offset: 0x00A9314F
		[NullableContext(1)]
		public NavigationCantFocusInScrollOrLayoutByJumpGroupButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602594C RID: 153932 RVA: 0x00A94F5A File Offset: 0x00A9315A
		protected override bool OnCanFocusInScrollOrLayout()
		{
			return false;
		}
	}
}
