using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003882 RID: 14466
	public class NavigationReFindMultipleScrollGridToggle : NavigationToggle
	{
		// Token: 0x0602594F RID: 153935 RVA: 0x00A94F7A File Offset: 0x00A9317A
		[NullableContext(1)]
		public NavigationReFindMultipleScrollGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025950 RID: 153936 RVA: 0x00A94F85 File Offset: 0x00A93185
		protected override bool OnCanFocusInScrollOrLayout()
		{
			return false;
		}

		// Token: 0x06025951 RID: 153937 RVA: 0x00A94F88 File Offset: 0x00A93188
		protected override void OnToggleClick(EToggleState state)
		{
			if (this.Listener == null)
			{
				return;
			}
			if (!this.Listener.HasMultiTemplateScrollView())
			{
				return;
			}
			if (this.Listener.PanelConfig == null)
			{
				return;
			}
			int gridIndexByChildComponent = (this.Listener.ScrollProxy.ScrollView as UUIMultiTemplateScrollViewComponent).GetGridIndexByChildComponent(this.Listener.GetSelectableComponent());
			FindMultiTemplateNavigationListener findMultiTemplateNavigationListener = new FindMultiTemplateNavigationListener();
			findMultiTemplateNavigationListener.PanelConfig = this.Listener.PanelConfig;
			findMultiTemplateNavigationListener.AddParam(new object[]
			{
				this.Listener,
				gridIndexByChildComponent
			});
			findMultiTemplateNavigationListener.AddParam(new object[]
			{
				this.Listener
			});
			this.Listener.PanelConfig.SetFindNavigationAction(findMultiTemplateNavigationListener);
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}
	}
}
