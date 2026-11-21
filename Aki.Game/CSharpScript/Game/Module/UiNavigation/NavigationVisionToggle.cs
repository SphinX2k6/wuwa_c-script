using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AF RID: 14511
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationVisionToggle : NavigationToggle
	{
		// Token: 0x06025A13 RID: 154131 RVA: 0x00A96F76 File Offset: 0x00A95176
		public NavigationVisionToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A14 RID: 154132 RVA: 0x00A96F84 File Offset: 0x00A95184
		protected override bool OnHandlePointerSelect(ULGUIPointerEventData eventData)
		{
			UUIExtendToggle uuiextendToggle = this.Selectable as UUIExtendToggle;
			if (uuiextendToggle.ToggleState == EToggleState.ETT_UnChecked && eventData != null && eventData.inputType == ELGUIPointerInputType.Navigation && uuiextendToggle.bToggleOnSelect)
			{
				UiNavigationNewController.Instance.InteractClickByListener(this.Listener);
			}
			base.ScrollToSelectableComponent(uuiextendToggle);
			return base.IsAllowNavigationByGroup();
		}

		// Token: 0x06025A15 RID: 154133 RVA: 0x00A96FDB File Offset: 0x00A951DB
		protected override bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return true;
		}
	}
}
