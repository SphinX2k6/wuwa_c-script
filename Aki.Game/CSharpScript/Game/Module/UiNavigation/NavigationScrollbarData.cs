using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200386F RID: 14447
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationScrollbarData
	{
		// Token: 0x060258BF RID: 153791 RVA: 0x00A93088 File Offset: 0x00A91288
		private void FindSuitableScrollbar()
		{
			TsUiNavigationBehaviorListener currentListener = this.CurrentListener;
			if (currentListener != null && currentListener.IsListenerActive())
			{
				return;
			}
			TsUiNavigationBehaviorListener currentScrollbar = null;
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in this.ScrollbarList)
			{
				if (tsUiNavigationBehaviorListener.IsListenerActive())
				{
					currentScrollbar = tsUiNavigationBehaviorListener;
					break;
				}
			}
			this.SetCurrentScrollbar(currentScrollbar);
		}

		// Token: 0x060258C0 RID: 153792 RVA: 0x00A93100 File Offset: 0x00A91300
		private void SetCurrentScrollbar(TsUiNavigationBehaviorListener listener)
		{
			if (this.CurrentListener != null)
			{
				this.CurrentListener.IsFocusScrollbar = false;
			}
			if (listener != null)
			{
				listener.IsFocusScrollbar = true;
			}
			this.LastListener = this.CurrentListener;
			this.CurrentListener = listener;
			this.CurrentScrollbar = (((listener != null) ? listener.GetBehaviorComponent() : null) as UUIScrollViewComponent);
		}

		// Token: 0x060258C1 RID: 153793 RVA: 0x00A93158 File Offset: 0x00A91358
		[NullableContext(1)]
		public void AddScrollbar(List<NavigationGroup> groupArray)
		{
			this.ScrollbarList.Clear();
			foreach (NavigationGroup navigationGroup in groupArray)
			{
				foreach (TsUiNavigationBehaviorListener item in navigationGroup.ListenerList)
				{
					this.ScrollbarList.Add(item);
				}
			}
			this.ScrollbarList.Sort((TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener) => (int)(aListener.ScrollbarIndex - bListener.ScrollbarIndex));
			this.FindSuitableScrollbar();
		}

		// Token: 0x060258C2 RID: 153794 RVA: 0x00A93220 File Offset: 0x00A91420
		public void DeleteScrollbar(NavigationGroup group)
		{
			List<TsUiNavigationBehaviorListener> list = (group != null) ? group.ListenerList : null;
			if (list == null)
			{
				return;
			}
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in list)
			{
				int num = this.ScrollbarList.IndexOf(tsUiNavigationBehaviorListener);
				if (num >= 0)
				{
					this.ScrollbarList.RemoveAt(num);
				}
				if (this.CurrentListener == tsUiNavigationBehaviorListener)
				{
					this.SetCurrentScrollbar(null);
				}
			}
			this.FindSuitableScrollbar();
		}

		// Token: 0x060258C3 RID: 153795 RVA: 0x00A932AC File Offset: 0x00A914AC
		public void ResumeLastListener()
		{
			TsUiNavigationBehaviorListener lastListener = this.LastListener;
			if (lastListener != null && lastListener.IsValid() && this.LastListener.IsListenerActive())
			{
				this.SetCurrentScrollbar(this.LastListener);
				return;
			}
			this.FindSuitableScrollbar();
		}

		// Token: 0x060258C4 RID: 153796 RVA: 0x00A932E2 File Offset: 0x00A914E2
		[NullableContext(1)]
		public TsUiNavigationBehaviorListener GetCurrentListener()
		{
			return this.CurrentListener;
		}

		// Token: 0x060258C5 RID: 153797 RVA: 0x00A932EA File Offset: 0x00A914EA
		[NullableContext(1)]
		public UUIScrollViewComponent GetCurrentScrollbar()
		{
			return this.CurrentScrollbar;
		}

		// Token: 0x060258C6 RID: 153798 RVA: 0x00A932F2 File Offset: 0x00A914F2
		public bool HasActiveScrollbarList()
		{
			return this.ScrollbarList.FindAll((TsUiNavigationBehaviorListener listener) => listener.IsListenerActive()).Count > 1;
		}

		// Token: 0x060258C7 RID: 153799 RVA: 0x00A93328 File Offset: 0x00A91528
		public void FindNextScrollbar()
		{
			if (this.CurrentListener == null)
			{
				this.FindSuitableScrollbar();
			}
			else
			{
				int count = this.ScrollbarList.Count;
				if (count == 1)
				{
					this.SetCurrentScrollbar(null);
					return;
				}
				int num = this.ScrollbarList.IndexOf(this.CurrentListener);
				int num2 = (num + 1 < count) ? (num + 1) : 0;
				while (num != num2)
				{
					if (this.ScrollbarList[num2].IsListenerActive())
					{
						this.SetCurrentScrollbar(this.ScrollbarList[num2]);
						break;
					}
					num2 = ((num2 + 1 < count) ? (num2 + 1) : 0);
				}
			}
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x060258C8 RID: 153800 RVA: 0x00A933C4 File Offset: 0x00A915C4
		public void FindPrevScrollbar()
		{
			if (this.CurrentListener == null)
			{
				this.FindSuitableScrollbar();
			}
			else
			{
				int count = this.ScrollbarList.Count;
				if (count == 1)
				{
					return;
				}
				int num = this.ScrollbarList.IndexOf(this.CurrentListener);
				int num2 = (num - 1 >= 0) ? (num - 1) : (count - 1);
				while (num != num2)
				{
					if (this.ScrollbarList[num2].IsListenerActive())
					{
						this.SetCurrentScrollbar(this.ScrollbarList[num2]);
						break;
					}
					num2 = ((num2 - 1 >= 0) ? (num2 - 1) : (count - 1));
				}
			}
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x060258C9 RID: 153801 RVA: 0x00A9345B File Offset: 0x00A9165B
		public void TryFindScrollbar()
		{
			this.FindSuitableScrollbar();
		}

		// Token: 0x04014C23 RID: 85027
		[Nullable(1)]
		private List<TsUiNavigationBehaviorListener> ScrollbarList = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C24 RID: 85028
		private TsUiNavigationBehaviorListener CurrentListener;

		// Token: 0x04014C25 RID: 85029
		private UUIScrollViewComponent CurrentScrollbar;

		// Token: 0x04014C26 RID: 85030
		private TsUiNavigationBehaviorListener LastListener;
	}
}
