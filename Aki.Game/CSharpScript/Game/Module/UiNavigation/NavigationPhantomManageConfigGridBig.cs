using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004926 RID: 18726
	public class NavigationPhantomManageConfigGridBig : NavigationButton
	{
		// Token: 0x06030EB1 RID: 200369 RVA: 0x00B5B6DC File Offset: 0x00B598DC
		[NullableContext(1)]
		public NavigationPhantomManageConfigGridBig(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EB2 RID: 200370 RVA: 0x00B5B6E8 File Offset: 0x00B598E8
		protected override void OnStart()
		{
			SpecialPanelHandleBase panelHandle = this.PanelHandle;
			if (((panelHandle != null) ? new ESpecialPanelHandleDefine?(panelHandle.GetType()) : null) == ESpecialPanelHandleDefine.PhantomManageConfig)
			{
				PhantomManageConfigPanelHandle phantomManageConfigPanelHandle = this.PanelHandle as PhantomManageConfigPanelHandle;
				TsUiNavigationBehaviorListener listener = this.Listener;
				AActor aactor = (listener != null) ? listener.LayoutActor : null;
				TWeakObjectPtr<UUIItem> rootUIComp = this.Selectable.RootUIComp;
				if (phantomManageConfigPanelHandle != null && this.Listener != null && aactor != null)
				{
					phantomManageConfigPanelHandle.AddNavigationListener(aactor, this.Listener, rootUIComp);
				}
			}
		}

		// Token: 0x06030EB3 RID: 200371 RVA: 0x00B5B788 File Offset: 0x00B59988
		protected override void OnButtonClick()
		{
			PhantomManageConfigPanelHandle phantomManageConfigPanelHandle = this.PanelHandle as PhantomManageConfigPanelHandle;
			TsUiNavigationBehaviorListener listener = this.Listener;
			AActor aactor = (listener != null) ? listener.LayoutActor : null;
			if (phantomManageConfigPanelHandle != null && this.Listener != null && aactor != null)
			{
				phantomManageConfigPanelHandle.FindNextFocusListener(aactor, this.Listener);
			}
		}
	}
}
