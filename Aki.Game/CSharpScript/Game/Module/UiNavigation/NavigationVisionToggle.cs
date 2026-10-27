using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004938 RID: 18744
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationVisionToggle : NavigationToggle
	{
		// Token: 0x06030EE6 RID: 200422 RVA: 0x00B5C106 File Offset: 0x00B5A306
		public NavigationVisionToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EE7 RID: 200423 RVA: 0x00B5C114 File Offset: 0x00B5A314
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

		// Token: 0x06030EE8 RID: 200424 RVA: 0x00B5C16B File Offset: 0x00B5A36B
		protected override bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return true;
		}
	}
}
