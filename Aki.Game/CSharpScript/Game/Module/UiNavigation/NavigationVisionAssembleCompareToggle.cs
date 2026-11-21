using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AB RID: 14507
	public class NavigationVisionAssembleCompareToggle : NavigationToggle
	{
		// Token: 0x06025A07 RID: 154119 RVA: 0x00A96C14 File Offset: 0x00A94E14
		[NullableContext(1)]
		public NavigationVisionAssembleCompareToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A08 RID: 154120 RVA: 0x00A96C1F File Offset: 0x00A94E1F
		protected override void OnToggleClick(EToggleState state)
		{
			(this.PanelHandle as VisionAssemblePanelHandle).IsInCompare = (state == EToggleState.ETT_Checked);
		}
	}
}
