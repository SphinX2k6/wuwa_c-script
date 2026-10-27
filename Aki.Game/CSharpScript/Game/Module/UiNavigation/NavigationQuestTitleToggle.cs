using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492A RID: 18730
	public class NavigationQuestTitleToggle : NavigationToggle
	{
		// Token: 0x06030EBE RID: 200382 RVA: 0x00B5B908 File Offset: 0x00B59B08
		[NullableContext(1)]
		public NavigationQuestTitleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EBF RID: 200383 RVA: 0x00B5B913 File Offset: 0x00B59B13
		protected override bool OnCanFocusInScrollOrLayout()
		{
			bool isInteractive = this.IsInteractive;
			return false;
		}
	}
}
