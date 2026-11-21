using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038A2 RID: 14498
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRoguelikeGridToggle : NavigationToggle
	{
		// Token: 0x060259ED RID: 154093 RVA: 0x00A9678D File Offset: 0x00A9498D
		public NavigationRoguelikeGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259EE RID: 154094 RVA: 0x00A96798 File Offset: 0x00A94998
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

		// Token: 0x060259EF RID: 154095 RVA: 0x00A967EF File Offset: 0x00A949EF
		protected override bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return true;
		}
	}
}
