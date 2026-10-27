using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004935 RID: 18741
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationVisionAssembleToggle : NavigationToggle
	{
		// Token: 0x06030EDC RID: 200412 RVA: 0x00B5BDC5 File Offset: 0x00B59FC5
		[NullableContext(1)]
		public NavigationVisionAssembleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EDD RID: 200413 RVA: 0x00B5BDD0 File Offset: 0x00B59FD0
		protected override UUISelectableComponent OnFindLoopScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode)
		{
			if (this.Listener == null)
			{
				return null;
			}
			int loopScrollViewGridIndex = this.Listener.LoopScrollViewGridIndex;
			int filterDataLength = VisionEquipGroupModel.Instance.FilterDataLength;
			bool flag = direction.X > 0f;
			if (loopScrollViewGridIndex == -1)
			{
				if (filterDataLength == 0)
				{
					return null;
				}
				if (flag)
				{
					return this.GetLoopScrollViewFirstComponent();
				}
				return this.GetLoopScrollViewLastComponent();
			}
			else if (!flag && loopScrollViewGridIndex == 0)
			{
				VisionAssemblePanelHandle visionAssemblePanelHandle = this.PanelHandle as VisionAssemblePanelHandle;
				if (visionAssemblePanelHandle != null && visionAssemblePanelHandle.IsInCompare)
				{
					return this.GetLoopScrollViewLastComponent();
				}
				return this.GetGroupFirstComponent();
			}
			else
			{
				if (!flag || loopScrollViewGridIndex != filterDataLength - 1)
				{
					return base.OnFindLoopScrollViewNavigationComponent(direction, wrapMode);
				}
				VisionAssemblePanelHandle visionAssemblePanelHandle2 = this.PanelHandle as VisionAssemblePanelHandle;
				if (visionAssemblePanelHandle2 != null && visionAssemblePanelHandle2.IsInCompare)
				{
					return this.GetLoopScrollViewFirstComponent();
				}
				return this.GetGroupFirstComponent();
			}
		}

		// Token: 0x06030EDE RID: 200414 RVA: 0x00B5BE8A File Offset: 0x00B5A08A
		private UUISelectableComponent GetGroupFirstComponent()
		{
			TsUiNavigationBehaviorListener listener = this.Listener;
			NavigationGroup navigationGroup = (listener != null) ? listener.GetNavigationGroup() : null;
			if (navigationGroup == null)
			{
				return null;
			}
			return navigationGroup.ActiveListenerList[0].GetSelectableComponent();
		}

		// Token: 0x06030EDF RID: 200415 RVA: 0x00B5BEB4 File Offset: 0x00B5A0B4
		private UUISelectableComponent GetLoopScrollViewFirstComponent()
		{
			TsUiNavigationBehaviorListener listener = this.Listener;
			List<TsUiNavigationBehaviorListener> list;
			if (listener == null)
			{
				list = null;
			}
			else
			{
				NavigationGroup navigationGroup = listener.GetNavigationGroup();
				list = ((navigationGroup != null) ? navigationGroup.ActiveListenerList : null);
			}
			List<TsUiNavigationBehaviorListener> list2 = list;
			if (list2 != null)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in list2)
				{
					if (tsUiNavigationBehaviorListener.HasLoopScrollView())
					{
						UiNavigationScrollProxy scrollProxy = tsUiNavigationBehaviorListener.ScrollProxy;
						UUILoopScrollViewComponent uuiloopScrollViewComponent = ((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUILoopScrollViewComponent;
						if (uuiloopScrollViewComponent == null)
						{
							break;
						}
						uuiloopScrollViewComponent.ScrollToGridIndex(0, false);
						break;
					}
				}
			}
			TsUiNavigationBehaviorListener listener2 = this.Listener;
			List<TsUiNavigationBehaviorListener> list3;
			if (listener2 == null)
			{
				list3 = null;
			}
			else
			{
				NavigationGroup navigationGroup2 = listener2.GetNavigationGroup();
				list3 = ((navigationGroup2 != null) ? navigationGroup2.ActiveListenerList : null);
			}
			List<TsUiNavigationBehaviorListener> list4 = list3;
			if (list4 != null)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 in list4)
				{
					if (tsUiNavigationBehaviorListener2.LoopScrollViewGridIndex == 0)
					{
						return tsUiNavigationBehaviorListener2.GetSelectableComponent();
					}
				}
			}
			return null;
		}

		// Token: 0x06030EE0 RID: 200416 RVA: 0x00B5BFBC File Offset: 0x00B5A1BC
		private UUISelectableComponent GetLoopScrollViewLastComponent()
		{
			int filterDataLength = VisionEquipGroupModel.Instance.FilterDataLength;
			TsUiNavigationBehaviorListener listener = this.Listener;
			List<TsUiNavigationBehaviorListener> list;
			if (listener == null)
			{
				list = null;
			}
			else
			{
				NavigationGroup navigationGroup = listener.GetNavigationGroup();
				list = ((navigationGroup != null) ? navigationGroup.ActiveListenerList : null);
			}
			List<TsUiNavigationBehaviorListener> list2 = list;
			if (list2 != null)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in list2)
				{
					if (tsUiNavigationBehaviorListener.HasLoopScrollView())
					{
						UiNavigationScrollProxy scrollProxy = tsUiNavigationBehaviorListener.ScrollProxy;
						UUILoopScrollViewComponent uuiloopScrollViewComponent = ((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUILoopScrollViewComponent;
						if (uuiloopScrollViewComponent == null)
						{
							break;
						}
						uuiloopScrollViewComponent.ScrollToGridIndex(filterDataLength - 1, false);
						break;
					}
				}
			}
			TsUiNavigationBehaviorListener listener2 = this.Listener;
			List<TsUiNavigationBehaviorListener> list3;
			if (listener2 == null)
			{
				list3 = null;
			}
			else
			{
				NavigationGroup navigationGroup2 = listener2.GetNavigationGroup();
				list3 = ((navigationGroup2 != null) ? navigationGroup2.ActiveListenerList : null);
			}
			List<TsUiNavigationBehaviorListener> list4 = list3;
			if (list4 != null)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 in list4)
				{
					if (tsUiNavigationBehaviorListener2.LoopScrollViewGridIndex == filterDataLength - 1)
					{
						return tsUiNavigationBehaviorListener2.GetSelectableComponent();
					}
				}
			}
			return null;
		}
	}
}
