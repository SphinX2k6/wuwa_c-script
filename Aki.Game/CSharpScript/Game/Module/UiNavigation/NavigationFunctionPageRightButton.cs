using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003885 RID: 14469
	public class NavigationFunctionPageRightButton : NavigationButton
	{
		// Token: 0x06025957 RID: 153943 RVA: 0x00A95167 File Offset: 0x00A93367
		[NullableContext(1)]
		public NavigationFunctionPageRightButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025958 RID: 153944 RVA: 0x00A95174 File Offset: 0x00A93374
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
