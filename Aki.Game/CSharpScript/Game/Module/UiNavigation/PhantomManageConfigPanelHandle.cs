using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003877 RID: 14455
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258EA RID: 153834 RVA: 0x00A93A68 File Offset: 0x00A91C68
		public PhantomManageConfigPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x060258EB RID: 153835 RVA: 0x00A93A7C File Offset: 0x00A91C7C
		public void AddNavigationListener(AActor layout, TsUiNavigationBehaviorListener listener, UUIItem item)
		{
			List<TsUiNavigationBehaviorListener> list;
			if (!this.LayoutListenerListMap.TryGetValue(layout, out list))
			{
				list = new List<TsUiNavigationBehaviorListener>();
				this.LayoutListenerListMap[layout] = list;
			}
			if (!list.Contains(listener))
			{
				list.Add(listener);
				list.Sort(new Comparison<TsUiNavigationBehaviorListener>(this.ListenerListSortFunction));
			}
		}

		// Token: 0x060258EC RID: 153836 RVA: 0x00A93AD0 File Offset: 0x00A91CD0
		public void FindNextFocusListener(AActor layout, TsUiNavigationBehaviorListener listener)
		{
			List<TsUiNavigationBehaviorListener> list;
			if (!this.LayoutListenerListMap.TryGetValue(layout, out list))
			{
				return;
			}
			if (listener.IsCanFocus())
			{
				return;
			}
			if (list.Count == 0)
			{
				return;
			}
			int num = list.IndexOf(listener);
			if (num <= 0)
			{
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.FindActiveListener(list, num - 1, -1, -1);
			if (tsUiNavigationBehaviorListener == null)
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(tsUiNavigationBehaviorListener.RootUIComp, true, false, false);
		}

		// Token: 0x060258ED RID: 153837 RVA: 0x00A93B38 File Offset: 0x00A91D38
		[return: Nullable(2)]
		private TsUiNavigationBehaviorListener FindActiveListener(List<TsUiNavigationBehaviorListener> list, int start, int end, int step)
		{
			for (int num = start; num != end; num += step)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = list[num];
				if (tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsCanFocus())
				{
					return tsUiNavigationBehaviorListener;
				}
			}
			return null;
		}

		// Token: 0x060258EE RID: 153838 RVA: 0x00A93B68 File Offset: 0x00A91D68
		private int ListenerListSortFunction(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
		{
			int num = aListener.IsValid() ? aListener.RootUIComp.Get().hierarchyIndex : 0;
			int num2 = bListener.IsValid() ? bListener.RootUIComp.Get().hierarchyIndex : 0;
			if (num != num2)
			{
				return num - num2;
			}
			return -1;
		}

		// Token: 0x04014C2E RID: 85038
		private readonly Dictionary<AActor, List<TsUiNavigationBehaviorListener>> LayoutListenerListMap = new Dictionary<AActor, List<TsUiNavigationBehaviorListener>>();
	}
}
