using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004904 RID: 18692
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SpecialPanelHandleBase
	{
		// Token: 0x06030DD1 RID: 200145 RVA: 0x00B5922B File Offset: 0x00B5742B
		public SpecialPanelHandleBase(string type)
		{
			this.Type = ESpecialPanelHandleDefine.FromString(type);
		}

		// Token: 0x06030DD2 RID: 200146 RVA: 0x00B5926C File Offset: 0x00B5746C
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

		// Token: 0x06030DD3 RID: 200147 RVA: 0x00B5930C File Offset: 0x00B5750C
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

		// Token: 0x06030DD4 RID: 200148 RVA: 0x00B59333 File Offset: 0x00B57533
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06030DD5 RID: 200149 RVA: 0x00B5933B File Offset: 0x00B5753B
		public void SetGroupMap(Dictionary<string, NavigationGroup> groupMap)
		{
			this.GroupMap = groupMap;
		}

		// Token: 0x06030DD6 RID: 200150 RVA: 0x00B59344 File Offset: 0x00B57544
		public void AddListener(TsUiNavigationBehaviorListener listener)
		{
			this.ListenerSet.Add(listener);
		}

		// Token: 0x06030DD7 RID: 200151 RVA: 0x00B59353 File Offset: 0x00B57553
		public void DeleteListener(TsUiNavigationBehaviorListener listener)
		{
			this.ListenerSet.Remove(listener);
		}

		// Token: 0x06030DD8 RID: 200152 RVA: 0x00B59364 File Offset: 0x00B57564
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

		// Token: 0x06030DD9 RID: 200153 RVA: 0x00B593D4 File Offset: 0x00B575D4
		public HashSet<TsUiNavigationBehaviorListener> GetListenerSet()
		{
			return this.ListenerSet;
		}

		// Token: 0x06030DDA RID: 200154 RVA: 0x00B593DC File Offset: 0x00B575DC
		public void SetDefaultNavigationListenerList(TArray<AActor> actorArray)
		{
			this.OnDefaultNavigationListenerList(actorArray);
		}

		// Token: 0x06030DDB RID: 200155 RVA: 0x00B593E5 File Offset: 0x00B575E5
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

		// Token: 0x06030DDC RID: 200156 RVA: 0x00B59418 File Offset: 0x00B57618
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

		// Token: 0x06030DDD RID: 200157 RVA: 0x00B5944B File Offset: 0x00B5764B
		public int GetDefaultListenerIndex(TsUiNavigationBehaviorListener listener)
		{
			return this.DefaultNavigationListener.IndexOf(listener);
		}

		// Token: 0x06030DDE RID: 200158 RVA: 0x00B59459 File Offset: 0x00B57659
		public List<TsUiNavigationBehaviorListener> GetSuitableNavigationListenerList(bool isDefault)
		{
			return this.OnGetSuitableNavigationListenerList(isDefault);
		}

		// Token: 0x06030DDF RID: 200159 RVA: 0x00B59462 File Offset: 0x00B57662
		public void NotifyFindResult(FindNavigationResult result)
		{
			this.OnNotifyFindResult(result);
		}

		// Token: 0x06030DE0 RID: 200160 RVA: 0x00B5946B File Offset: 0x00B5766B
		public TsUiNavigationBehaviorListener GetLoopOrLayoutListener(TsUiNavigationBehaviorListener listener)
		{
			return this.OnGetLoopOrLayoutListener(listener);
		}

		// Token: 0x06030DE1 RID: 200161 RVA: 0x00B59474 File Offset: 0x00B57674
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

		// Token: 0x06030DE2 RID: 200162 RVA: 0x00B594A0 File Offset: 0x00B576A0
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

		// Token: 0x06030DE3 RID: 200163 RVA: 0x00B59500 File Offset: 0x00B57700
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

		// Token: 0x06030DE4 RID: 200164 RVA: 0x00B595AF File Offset: 0x00B577AF
		public bool IsFirstFindFromSubPanel()
		{
			return this.OnIsFirstFindFromSubPanel();
		}

		// Token: 0x06030DE5 RID: 200165 RVA: 0x00B595B7 File Offset: 0x00B577B7
		public bool CanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
		{
			return this.OnCanOverrideFindNavigation(direction, lastListener, targetListener);
		}

		// Token: 0x06030DE6 RID: 200166 RVA: 0x00B595C2 File Offset: 0x00B577C2
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener HandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
		{
			return this.OnHandleOverrideFindNavigation(direction, lastListener, targetListener);
		}

		// Token: 0x06030DE7 RID: 200167 RVA: 0x00B595CD File Offset: 0x00B577CD
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener HandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
		{
			return this.OnHandleAfterFindOpposite(direction, lastListener, targetListener, isPositive);
		}

		// Token: 0x06030DE8 RID: 200168 RVA: 0x00B595DA File Offset: 0x00B577DA
		protected virtual List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			return this.DefaultNavigationListener;
		}

		// Token: 0x06030DE9 RID: 200169 RVA: 0x00B595E4 File Offset: 0x00B577E4
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

		// Token: 0x06030DEA RID: 200170 RVA: 0x00B59644 File Offset: 0x00B57844
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

		// Token: 0x06030DEB RID: 200171 RVA: 0x00B5966E File Offset: 0x00B5786E
		protected virtual void OnNotifyFindResult(FindNavigationResult result)
		{
		}

		// Token: 0x06030DEC RID: 200172 RVA: 0x00B59670 File Offset: 0x00B57870
		protected virtual bool OnIsFirstFindFromSubPanel()
		{
			return false;
		}

		// Token: 0x06030DED RID: 200173 RVA: 0x00B59673 File Offset: 0x00B57873
		protected virtual bool OnCanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
		{
			return false;
		}

		// Token: 0x06030DEE RID: 200174 RVA: 0x00B59676 File Offset: 0x00B57876
		[NullableContext(2)]
		protected virtual TsUiNavigationBehaviorListener OnHandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
		{
			return null;
		}

		// Token: 0x06030DEF RID: 200175 RVA: 0x00B59679 File Offset: 0x00B57879
		[NullableContext(2)]
		protected virtual TsUiNavigationBehaviorListener OnHandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
		{
			return targetListener;
		}

		// Token: 0x06030DF0 RID: 200176 RVA: 0x00B5967C File Offset: 0x00B5787C
		public void Clear()
		{
			this.OnClear();
			this.GroupMap.Clear();
			this.ListenerSet.Clear();
		}

		// Token: 0x06030DF1 RID: 200177 RVA: 0x00B5969A File Offset: 0x00B5789A
		public new ESpecialPanelHandleDefine GetType()
		{
			return this.Type;
		}

		// Token: 0x06030DF2 RID: 200178 RVA: 0x00B596A2 File Offset: 0x00B578A2
		protected virtual void OnInit()
		{
		}

		// Token: 0x06030DF3 RID: 200179 RVA: 0x00B596A4 File Offset: 0x00B578A4
		protected virtual void OnClear()
		{
		}

		// Token: 0x0401A3C6 RID: 107462
		protected List<TsUiNavigationBehaviorListener> DefaultNavigationListener = new List<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3C7 RID: 107463
		private readonly HashSet<TsUiNavigationBehaviorListener> ListenerSet = new HashSet<TsUiNavigationBehaviorListener>();

		// Token: 0x0401A3C8 RID: 107464
		private Dictionary<string, NavigationGroup> GroupMap = new Dictionary<string, NavigationGroup>();

		// Token: 0x0401A3C9 RID: 107465
		private readonly ESpecialPanelHandleDefine Type = ESpecialPanelHandleDefine.Default;
	}
}
