using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200490D RID: 18701
	public class NavigationFunctionPageLeftButton : NavigationButton
	{
		// Token: 0x06030E28 RID: 200232 RVA: 0x00B5A288 File Offset: 0x00B58488
		[NullableContext(1)]
		public NavigationFunctionPageLeftButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E29 RID: 200233 RVA: 0x00B5A294 File Offset: 0x00B58494
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
				functionViewPanelHandle.FindPrevFocusListener();
			}
		}
	}
}
