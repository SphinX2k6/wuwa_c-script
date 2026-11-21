using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387B RID: 14459
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SpecialPanelHandleBase
	{
		// Token: 0x060258FE RID: 153854 RVA: 0x00A9409B File Offset: 0x00A9229B
		public SpecialPanelHandleBase(string type)
		{
			this.Type = ESpecialPanelHandleDefine.FromString(type);
		}

		// Token: 0x060258FF RID: 153855 RVA: 0x00A940DC File Offset: 0x00A922DC
		protected unsafe void SetNavigationGroupDefaultListener(TsUiNavigationBehaviorListener listener, bool isForce = false)
		{
			NavigationGroup navigationGroup = this.GetNavigationGroup(listener.GroupName);
			if (navigationGroup == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "找不到导航组信息";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("导航组名字", listener.GroupName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("导航监听对象", listener.RootUIComp.Get().displayName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (navigationGroup.DefaultListener == null || isForce)
			{
				navigationGroup.DefaultListener = listener;
			}
		}

		// Token: 0x06025900 RID: 153856 RVA: 0x00A9417C File Offset: 0x00A9237C
		[return: Nullable(2)]
		public NavigationGroup GetNavigationGroup(string groupName)
		{
			if (string.IsNullOrEmpty(groupName))
			{
				return null;
			}
			NavigationGroup result;
			this.GroupMap.TryGetValue(groupName, out result);
			return result;
		}

		// Token: 0x06025901 RID: 153857 RVA: 0x00A941A3 File Offset: 0x00A923A3
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06025902 RID: 153858 RVA: 0x00A941AB File Offset: 0x00A923AB
		public void SetGroupMap(Dictionary<string, NavigationGroup> groupMap)
		{
			this.GroupMap = groupMap;
		}

		// Token: 0x06025903 RID: 153859 RVA: 0x00A941B4 File Offset: 0x00A923B4
		public void AddListener(TsUiNavigationBehaviorListener listener)
		{
			this.ListenerSet.Add(listener);
		}

		// Token: 0x06025904 RID: 153860 RVA: 0x00A941C3 File Offset: 0x00A923C3
		public void DeleteListener(TsUiNavigationBehaviorListener listener)
		{
			this.ListenerSet.Remove(listener);
		}

		// Token: 0x06025905 RID: 153861 RVA: 0x00A941D4 File Offset: 0x00A923D4
		public List<TsUiNavigationBehaviorListener> GetListenerListByTag(string tag)
		{
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in this.ListenerSet)
			{
				TArray<string> tagArray = tsUiNavigationBehaviorListener.TagArray;
				if (tagArray != null && tagArray.Contains(tag))
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			return list;
		}

		// Token: 0x06025906 RID: 153862 RVA: 0x00A94244 File Offset: 0x00A92444
		public HashSet<TsUiNavigationBehaviorListener> GetListenerSet()
		{
			return this.ListenerSet;
		}

		// Token: 0x06025907 RID: 153863 RVA: 0x00A9424C File Offset: 0x00A9244C
		public void SetDefaultNavigationListenerList(TArray<AActor> actorArray)
		{
			this.OnDefaultNavigationListenerList(actorArray);
		}

		// Token: 0x06025908 RID: 153864 RVA: 0x00A94255 File Offset: 0x00A92455
		public void ReplaceDefaultNavigationListener(TsUiNavigationBehaviorListener listener, int index)
		{
			if (this.DefaultNavigationListener.Count <= index)
			{
				this.DefaultNavigationListener.Add(listener);
			}
			else
			{
				this.DefaultNavigationListener[index] = listener;
			}
			this.SetNavigationGroupDefaultListener(listener, false);
		}

		// Token: 0x06025909 RID: 153865 RVA: 0x00A94288 File Offset: 0x00A92488
		public void ForceReplaceDefaultNavigationListener(TsUiNavigationBehaviorListener listener, int index)
		{
			if (this.DefaultNavigationListener.Count <= index)
			{
				this.DefaultNavigationListener.Add(listener);
			}
			else
			{
				this.DefaultNavigationListener[index] = listener;
			}
			this.SetNavigationGroupDefaultListener(listener, true);
		}

		// Token: 0x0602590A RID: 153866 RVA: 0x00A942BB File Offset: 0x00A924BB
		public int GetDefaultListenerIndex(TsUiNavigationBehaviorListener listener)
		{
			return this.DefaultNavigationListener.IndexOf(listener);
		}

		// Token: 0x0602590B RID: 153867 RVA: 0x00A942C9 File Offset: 0x00A924C9
		public List<TsUiNavigationBehaviorListener> GetSuitableNavigationListenerList(bool isDefault)
		{
			return this.OnGetSuitableNavigationListenerList(isDefault);
		}

		// Token: 0x0602590C RID: 153868 RVA: 0x00A942D2 File Offset: 0x00A924D2
		public void NotifyFindResult(FindNavigationResult result)
		{
			this.OnNotifyFindResult(result);
		}

		// Token: 0x0602590D RID: 153869 RVA: 0x00A942DB File Offset: 0x00A924DB
		public TsUiNavigationBehaviorListener GetLoopOrLayoutListener(TsUiNavigationBehaviorListener listener)
		{
			return this.OnGetLoopOrLayoutListener(listener);
		}

		// Token: 0x0602590E RID: 153870 RVA: 0x00A942E4 File Offset: 0x00A924E4
		[return: Nullable(2)]
		public TsUiNavigationBehaviorListener GetSuitableListenerWithoutLayout(TsUiNavigationBehaviorListener listener)
		{
			NavigationGroup navigationGroup = this.GetNavigationGroup(listener.GroupName);
			if (navigationGroup == null)
			{
				return null;
			}
			return UiNavigationNewController.Instance.FindSuitableListenerWithoutLayout(navigationGroup);
		}

		// Token: 0x0602590F RID: 153871 RVA: 0x00A94310 File Offset: 0x00A92510
		public void ResetGroupConfigMemory()
		{
			foreach (NavigationGroup navigationGroup in this.GroupMap.Values)
			{
				if (navigationGroup.SelectableMemory)
				{
					navigationGroup.LastSelectListener = null;
				}
			}
		}

		// Token: 0x06025910 RID: 153872 RVA: 0x00A94370 File Offset: 0x00A92570
		public void TryRemoveListener(TsUiNavigationBehaviorListener listener)
		{
			this.DeleteListener(listener);
			NavigationGroup navigationGroup = this.GetNavigationGroup(listener.GroupName);
			if (navigationGroup == null)
			{
				return;
			}
			int i = 0;
			int count = navigationGroup.ListenerList.Count;
			while (i < count)
			{
				if (navigationGroup.ListenerList[i].GetOwner() == listener.GetOwner())
				{
					navigationGroup.RemoveListenerByIndex(i);
					break;
				}
				i++;
			}
			if (navigationGroup.ListenerList.Count > 0)
			{
				int defaultListenerIndex = this.GetDefaultListenerIndex(listener);
				if (defaultListenerIndex != -1)
				{
					this.ReplaceDefaultNavigationListener(navigationGroup.ListenerList[0], defaultListenerIndex);
				}
				if (navigationGroup.DefaultListener != null && navigationGroup.DefaultListener == listener)
				{
					navigationGroup.DefaultListener = navigationGroup.ListenerList[0];
				}
			}
		}

		// Token: 0x06025911 RID: 153873 RVA: 0x00A9441F File Offset: 0x00A9261F
		public bool IsFirstFindFromSubPanel()
		{
			return this.OnIsFirstFindFromSubPanel();
		}

		// Token: 0x06025912 RID: 153874 RVA: 0x00A94427 File Offset: 0x00A92627
		public bool CanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
		{
			return this.OnCanOverrideFindNavigation(direction, lastListener, targetListener);
		}

		// Token: 0x06025913 RID: 153875 RVA: 0x00A94432 File Offset: 0x00A92632
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener HandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
		{
			return this.OnHandleOverrideFindNavigation(direction, lastListener, targetListener);
		}

		// Token: 0x06025914 RID: 153876 RVA: 0x00A9443D File Offset: 0x00A9263D
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener HandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
		{
			return this.OnHandleAfterFindOpposite(direction, lastListener, targetListener, isPositive);
		}

		// Token: 0x06025915 RID: 153877 RVA: 0x00A9444A File Offset: 0x00A9264A
		protected virtual List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			return this.DefaultNavigationListener;
		}

		// Token: 0x06025916 RID: 153878 RVA: 0x00A94454 File Offset: 0x00A92654
		protected virtual void OnDefaultNavigationListenerList(TArray<AActor> actorArray)
		{
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			for (int i = 0; i < actorArray.Num(); i++)
			{
				AActor aactor = actorArray.Get(i);
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = ((aactor != null) ? aactor.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener;
				list.Add(tsUiNavigationBehaviorListener);
				if (tsUiNavigationBehaviorListener != null)
				{
					this.SetNavigationGroupDefaultListener(tsUiNavigationBehaviorListener, false);
				}
			}
			this.DefaultNavigationListener = list;
		}

		// Token: 0x06025917 RID: 153879 RVA: 0x00A944B4 File Offset: 0x00A926B4
		[return: Nullable(2)]
		protected virtual TsUiNavigationBehaviorListener OnGetLoopOrLayoutListener(TsUiNavigationBehaviorListener listener)
		{
			NavigationGroup navigationGroup = this.GetNavigationGroup(listener.GroupName);
			if (navigationGroup == null)
			{
				return null;
			}
			return UiNavigationNewController.Instance.FindLoopOrDynListener(navigationGroup);
		}

		// Token: 0x06025918 RID: 153880 RVA: 0x00A944DE File Offset: 0x00A926DE
		protected virtual void OnNotifyFindResult(FindNavigationResult result)
		{
		}

		// Token: 0x06025919 RID: 153881 RVA: 0x00A944E0 File Offset: 0x00A926E0
		protected virtual bool OnIsFirstFindFromSubPanel()
		{
			return false;
		}

		// Token: 0x0602591A RID: 153882 RVA: 0x00A944E3 File Offset: 0x00A926E3
		protected virtual bool OnCanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
		{
			return false;
		}

		// Token: 0x0602591B RID: 153883 RVA: 0x00A944E6 File Offset: 0x00A926E6
		[NullableContext(2)]
		protected virtual TsUiNavigationBehaviorListener OnHandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
		{
			return null;
		}

		// Token: 0x0602591C RID: 153884 RVA: 0x00A944E9 File Offset: 0x00A926E9
		[NullableContext(2)]
		protected virtual TsUiNavigationBehaviorListener OnHandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
		{
			return targetListener;
		}

		// Token: 0x0602591D RID: 153885 RVA: 0x00A944EC File Offset: 0x00A926EC
		public void Clear()
		{
			this.OnClear();
			this.GroupMap.Clear();
			this.ListenerSet.Clear();
		}

		// Token: 0x0602591E RID: 153886 RVA: 0x00A9450A File Offset: 0x00A9270A
		public new ESpecialPanelHandleDefine GetType()
		{
			return this.Type;
		}

		// Token: 0x0602591F RID: 153887 RVA: 0x00A94512 File Offset: 0x00A92712
		protected virtual void OnInit()
		{
		}

		// Token: 0x06025920 RID: 153888 RVA: 0x00A94514 File Offset: 0x00A92714
		protected virtual void OnClear()
		{
		}

		// Token: 0x04014C39 RID: 85049
		protected List<TsUiNavigationBehaviorListener> DefaultNavigationListener = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C3A RID: 85050
		private readonly HashSet<TsUiNavigationBehaviorListener> ListenerSet = new HashSet<TsUiNavigationBehaviorListener>();

		// Token: 0x04014C3B RID: 85051
		private Dictionary<string, NavigationGroup> GroupMap = new Dictionary<string, NavigationGroup>();

		// Token: 0x04014C3C RID: 85052
		private readonly ESpecialPanelHandleDefine Type = ESpecialPanelHandleDefine.Default;
	}
}
