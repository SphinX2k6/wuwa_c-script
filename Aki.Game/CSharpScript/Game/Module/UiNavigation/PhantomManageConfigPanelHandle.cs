using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004900 RID: 18688
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigPanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DBD RID: 200125 RVA: 0x00B58BF8 File Offset: 0x00B56DF8
		public PhantomManageConfigPanelHandle(string type) : base(type)
		{
		}

		// Token: 0x06030DBE RID: 200126 RVA: 0x00B58C0C File Offset: 0x00B56E0C
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

		// Token: 0x06030DBF RID: 200127 RVA: 0x00B58C60 File Offset: 0x00B56E60
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

		// Token: 0x06030DC0 RID: 200128 RVA: 0x00B58CC8 File Offset: 0x00B56EC8
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

		// Token: 0x06030DC1 RID: 200129 RVA: 0x00B58CF8 File Offset: 0x00B56EF8
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

		// Token: 0x0401A3BB RID: 107451
		private readonly Dictionary<AActor, List<TsUiNavigationBehaviorListener>> LayoutListenerListMap = new Dictionary<AActor, List<TsUiNavigationBehaviorListener>>();
	}
}
