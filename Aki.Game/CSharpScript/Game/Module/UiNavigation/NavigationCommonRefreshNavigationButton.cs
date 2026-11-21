using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003881 RID: 14465
	public class NavigationCommonRefreshNavigationButton : NavigationButton
	{
		// Token: 0x0602594D RID: 153933 RVA: 0x00A94F5D File Offset: 0x00A9315D
		[NullableContext(1)]
		public NavigationCommonRefreshNavigationButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x0602594E RID: 153934 RVA: 0x00A94F68 File Offset: 0x00A93168
		protected override void OnButtonClick()
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirtyByListener(this.Listener);
		}
	}
}
