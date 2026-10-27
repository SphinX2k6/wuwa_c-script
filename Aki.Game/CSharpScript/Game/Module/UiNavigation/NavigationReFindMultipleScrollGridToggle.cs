using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200490B RID: 18699
	public class NavigationReFindMultipleScrollGridToggle : NavigationToggle
	{
		// Token: 0x06030E22 RID: 200226 RVA: 0x00B5A10A File Offset: 0x00B5830A
		[NullableContext(1)]
		public NavigationReFindMultipleScrollGridToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E23 RID: 200227 RVA: 0x00B5A115 File Offset: 0x00B58315
		protected override bool OnCanFocusInScrollOrLayout()
		{
			return false;
		}

		// Token: 0x06030E24 RID: 200228 RVA: 0x00B5A118 File Offset: 0x00B58318
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
