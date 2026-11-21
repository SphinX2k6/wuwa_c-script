using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387F RID: 14463
	public class NavigationCalabashDetailExitButton : NavigationButton
	{
		// Token: 0x06025949 RID: 153929 RVA: 0x00A94F38 File Offset: 0x00A93138
		[NullableContext(1)]
		public NavigationCalabashDetailExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602594A RID: 153930 RVA: 0x00A94F43 File Offset: 0x00A93143
		protected override void OnButtonClick()
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}
	}
}
