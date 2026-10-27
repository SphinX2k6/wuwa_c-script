using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200490A RID: 18698
	public class NavigationCommonRefreshNavigationButton : NavigationButton
	{
		// Token: 0x06030E20 RID: 200224 RVA: 0x00B5A0ED File Offset: 0x00B582ED
		[NullableContext(1)]
		public NavigationCommonRefreshNavigationButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E21 RID: 200225 RVA: 0x00B5A0F8 File Offset: 0x00B582F8
		protected override void OnButtonClick()
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirtyByListener(this.Listener);
		}
	}
}
