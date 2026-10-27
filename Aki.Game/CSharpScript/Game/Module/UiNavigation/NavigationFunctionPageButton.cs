using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200490C RID: 18700
	public class NavigationFunctionPageButton : NavigationButton
	{
		// Token: 0x06030E25 RID: 200229 RVA: 0x00B5A1D5 File Offset: 0x00B583D5
		[NullableContext(1)]
		public NavigationFunctionPageButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E26 RID: 200230 RVA: 0x00B5A1E0 File Offset: 0x00B583E0
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

		// Token: 0x06030E27 RID: 200231 RVA: 0x00B5A24C File Offset: 0x00B5844C
		protected override bool OnCheckFindOpposite()
		{
			ULGUIBehaviour selectable = this.Selectable;
			UUIItem uuiitem = (selectable != null) ? selectable.GetRootComponent() : null;
			ULGUICanvas ulguicanvas = (uuiitem != null) ? uuiitem.GetRenderCanvas() : null;
			return ulguicanvas != null && ulguicanvas.IsUIVisible(uuiitem);
		}
	}
}
