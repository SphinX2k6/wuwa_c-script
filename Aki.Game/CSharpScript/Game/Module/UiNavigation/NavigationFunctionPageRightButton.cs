using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200490E RID: 18702
	public class NavigationFunctionPageRightButton : NavigationButton
	{
		// Token: 0x06030E2A RID: 200234 RVA: 0x00B5A2F7 File Offset: 0x00B584F7
		[NullableContext(1)]
		public NavigationFunctionPageRightButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E2B RID: 200235 RVA: 0x00B5A304 File Offset: 0x00B58504
		protected override void OnButtonClick()
		{
			SpecialPanelHandleBase panelHandle = this.PanelHandle;
			if (((panelHandle != null) ? new ESpecialPanelHandleDefine?(panelHandle.GetType()) : null) == ESpecialPanelHandleDefine.FunctionView)
			{
				FunctionViewPanelHandle functionViewPanelHandle = this.PanelHandle as FunctionViewPanelHandle;
				if (functionViewPanelHandle == null)
				{
					return;
				}
				functionViewPanelHandle.FindNextFocusListener();
			}
		}
	}
}
