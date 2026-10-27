using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004908 RID: 18696
	public class NavigationCalabashDetailExitButton : NavigationButton
	{
		// Token: 0x06030E1C RID: 200220 RVA: 0x00B5A0C8 File Offset: 0x00B582C8
		[NullableContext(1)]
		public NavigationCalabashDetailExitButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E1D RID: 200221 RVA: 0x00B5A0D3 File Offset: 0x00B582D3
		protected override void OnButtonClick()
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}
	}
}
