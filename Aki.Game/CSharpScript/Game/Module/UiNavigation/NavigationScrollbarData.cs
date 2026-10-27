using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F8 RID: 18680
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigationScrollbarData
	{
		// Token: 0x06030D92 RID: 200082 RVA: 0x00B58218 File Offset: 0x00B56418
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

		// Token: 0x06030D93 RID: 200083 RVA: 0x00B58290 File Offset: 0x00B56490
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

		// Token: 0x06030D94 RID: 200084 RVA: 0x00B582E8 File Offset: 0x00B564E8
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

		// Token: 0x06030D95 RID: 200085 RVA: 0x00B583B0 File Offset: 0x00B565B0
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

		// Token: 0x06030D96 RID: 200086 RVA: 0x00B5843C File Offset: 0x00B5663C
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

		// Token: 0x06030D97 RID: 200087 RVA: 0x00B58472 File Offset: 0x00B56672
		[NullableContext(1)]
		public TsUiNavigationBehaviorListener GetCurrentListener()
		{
			return this.CurrentListener;
		}

		// Token: 0x06030D98 RID: 200088 RVA: 0x00B5847A File Offset: 0x00B5667A
		[NullableContext(1)]
		public UUIScrollViewComponent GetCurrentScrollbar()
		{
			return this.CurrentScrollbar;
		}

		// Token: 0x06030D99 RID: 200089 RVA: 0x00B58482 File Offset: 0x00B56682
		public bool HasActiveScrollbarList()
		{
			return this.ScrollbarList.FindAll((TsUiNavigationBehaviorListener listener) => listener.IsListenerActive()).Count > 1;
		}

		// Token: 0x06030D9A RID: 200090 RVA: 0x00B584B8 File Offset: 0x00B566B8
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

		// Token: 0x06030D9B RID: 200091 RVA: 0x00B58554 File Offset: 0x00B56754
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

		// Token: 0x06030D9C RID: 200092 RVA: 0x00B585EB File Offset: 0x00B567EB
		public void TryFindScrollbar()
		{
			this.FindSuitableScrollbar();
		}

		// Token: 0x0401A3B0 RID: 107440
		[Nullable(1)]
		private List<TsUiNavigationBehaviorListener> ScrollbarList = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3B1 RID: 107441
		private TsUiNavigationBehaviorListener CurrentListener;

		// Token: 0x0401A3B2 RID: 107442
		private UUIScrollViewComponent CurrentScrollbar;

		// Token: 0x0401A3B3 RID: 107443
		private TsUiNavigationBehaviorListener LastListener;
	}
}
