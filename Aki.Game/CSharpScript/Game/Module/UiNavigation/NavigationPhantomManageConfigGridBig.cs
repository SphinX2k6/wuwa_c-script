using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200389D RID: 14493
	public class NavigationPhantomManageConfigGridBig : NavigationButton
	{
		// Token: 0x060259DE RID: 154078 RVA: 0x00A9654C File Offset: 0x00A9474C
		[NullableContext(1)]
		public NavigationPhantomManageConfigGridBig(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259DF RID: 154079 RVA: 0x00A96558 File Offset: 0x00A94758
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

		// Token: 0x060259E0 RID: 154080 RVA: 0x00A965F8 File Offset: 0x00A947F8
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
