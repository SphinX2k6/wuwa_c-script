using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200492B RID: 18731
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRoguelikeGridToggle : NavigationToggle
	{
		// Token: 0x06030EC0 RID: 200384 RVA: 0x00B5B91D File Offset: 0x00B59B1D
		public NavigationRoguelikeGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EC1 RID: 200385 RVA: 0x00B5B928 File Offset: 0x00B59B28
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

		// Token: 0x06030EC2 RID: 200386 RVA: 0x00B5B97F File Offset: 0x00B59B7F
		protected override bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return true;
		}
	}
}
