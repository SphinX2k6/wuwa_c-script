using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004934 RID: 18740
	public class NavigationVisionAssembleCompareToggle : NavigationToggle
	{
		// Token: 0x06030EDA RID: 200410 RVA: 0x00B5BDA4 File Offset: 0x00B59FA4
		[NullableContext(1)]
		public NavigationVisionAssembleCompareToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EDB RID: 200411 RVA: 0x00B5BDAF File Offset: 0x00B59FAF
		protected override void OnToggleClick(EToggleState state)
		{
			(this.PanelHandle as VisionAssemblePanelHandle).IsInCompare = (state == EToggleState.ETT_Checked);
		}
	}
}
