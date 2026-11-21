using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038AC RID: 14508
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationVisionAssembleToggle : NavigationToggle
	{
		// Token: 0x06025A09 RID: 154121 RVA: 0x00A96C35 File Offset: 0x00A94E35
		[NullableContext(1)]
		public NavigationVisionAssembleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06025A0A RID: 154122 RVA: 0x00A96C40 File Offset: 0x00A94E40
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

		// Token: 0x06025A0B RID: 154123 RVA: 0x00A96CFA File Offset: 0x00A94EFA
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

		// Token: 0x06025A0C RID: 154124 RVA: 0x00A96D24 File Offset: 0x00A94F24
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

		// Token: 0x06025A0D RID: 154125 RVA: 0x00A96E2C File Offset: 0x00A9502C
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
