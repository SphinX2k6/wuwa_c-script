using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003884 RID: 14468
	public class NavigationFunctionPageLeftButton : NavigationButton
	{
		// Token: 0x06025955 RID: 153941 RVA: 0x00A950F8 File Offset: 0x00A932F8
		[NullableContext(1)]
		public NavigationFunctionPageLeftButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025956 RID: 153942 RVA: 0x00A95104 File Offset: 0x00A93304
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
