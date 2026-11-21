using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003883 RID: 14467
	public class NavigationFunctionPageButton : NavigationButton
	{
		// Token: 0x06025952 RID: 153938 RVA: 0x00A95045 File Offset: 0x00A93245
		[NullableContext(1)]
		public NavigationFunctionPageButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025953 RID: 153939 RVA: 0x00A95050 File Offset: 0x00A93250
		protected override void OnStart()
		{
			SpecialPanelHandleBase panelHandle = this.PanelHandle;
			if (((panelHandle != null) ? new ESpecialPanelHandleDefine?(panelHandle.GetType()) : null) == ESpecialPanelHandleDefine.FunctionView)
			{
				FunctionViewPanelHandle functionViewPanelHandle = this.PanelHandle as FunctionViewPanelHandle;
				if (functionViewPanelHandle == null)
				{
					return;
				}
				functionViewPanelHandle.AddNavigationListener(this.Listener);
			}
		}

		// Token: 0x06025954 RID: 153940 RVA: 0x00A950BC File Offset: 0x00A932BC
		protected override bool OnCheckFindOpposite()
		{
			ULGUIBehaviour selectable = this.Selectable;
			UUIItem uuiitem = (selectable != null) ? selectable.GetRootComponent() : null;
			ULGUICanvas ulguicanvas = (uuiitem != null) ? uuiitem.GetRenderCanvas() : null;
			return ulguicanvas != null && ulguicanvas.IsUIVisible(uuiitem);
		}
	}
}
