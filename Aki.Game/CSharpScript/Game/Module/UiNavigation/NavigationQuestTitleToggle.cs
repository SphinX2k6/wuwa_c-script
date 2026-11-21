using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A1 RID: 14497
	public class NavigationQuestTitleToggle : NavigationToggle
	{
		// Token: 0x060259EB RID: 154091 RVA: 0x00A96778 File Offset: 0x00A94978
		[NullableContext(1)]
		public NavigationQuestTitleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259EC RID: 154092 RVA: 0x00A96783 File Offset: 0x00A94983
		protected override bool OnCanFocusInScrollOrLayout()
		{
			bool isInteractive = this.IsInteractive;
			return false;
		}
	}
}
