using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F6 RID: 18678
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationGroup
	{
		// Token: 0x06030D68 RID: 200040 RVA: 0x00B57833 File Offset: 0x00B55A33
		public void AddListener(TsUiNavigationBehaviorListener value)
		{
			this.ListenerListInternal.Add(value);
			this.IsListenerListDirty = true;
		}

		// Token: 0x06030D69 RID: 200041 RVA: 0x00B57848 File Offset: 0x00B55A48
		public void RemoveListenerByIndex(int index)
		{
			this.ListenerListInternal.RemoveAt(index);
		}

		// Token: 0x170079A5 RID: 31141
		// (get) Token: 0x06030D6A RID: 200042 RVA: 0x00B57856 File Offset: 0x00B55A56
		public List<TsUiNavigationBehaviorListener> ListenerList
		{
			get
			{
				if (this.IsListenerListDirty)
				{
					this.IsListenerListDirty = false;
					this.SortListenerListByFlattenHierarchyIndex();
				}
				return this.ListenerListInternal;
			}
		}

		// Token: 0x06030D6B RID: 200043 RVA: 0x00B57874 File Offset: 0x00B55A74
		private void SortListenerListByFlattenHierarchyIndex()
		{
			TArray<UUIItem> tarray = new TArray<UUIItem>();
			Dictionary<UUIItem, TsUiNavigationBehaviorListener> dictionary = new Dictionary<UUIItem, TsUiNavigationBehaviorListener>();
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			int i = 0;
			int count = this.ListenerListInternal.Count;
			while (i < count)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.ListenerListInternal[i];
				if (!tsUiNavigationBehaviorListener.IsValid())
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
				else
				{
					TWeakObjectPtr<UUIItem> rootUIComp = tsUiNavigationBehaviorListener.RootUIComp;
					tarray.Add(rootUIComp);
					dictionary[rootUIComp] = tsUiNavigationBehaviorListener;
				}
				i++;
			}
			TArray<UUIItem> sortedItemsWithFlattenHierarchyIndex = ULGUIBPLibrary.GetSortedItemsWithFlattenHierarchyIndex(tarray, true);
			this.ListenerListInternal.Clear();
			int j = 0;
			int count2 = sortedItemsWithFlattenHierarchyIndex.Count;
			while (j < count2)
			{
				TsUiNavigationBehaviorListener item;
				if (dictionary.TryGetValue(sortedItemsWithFlattenHierarchyIndex[j], out item))
				{
					this.ListenerListInternal.Add(item);
				}
				j++;
			}
			int k = 0;
			int count3 = list.Count;
			while (k < count3)
			{
				this.ListenerListInternal.Add(list[k]);
				k++;
			}
		}

		// Token: 0x06030D6C RID: 200044 RVA: 0x00B57970 File Offset: 0x00B55B70
		private Dictionary<TsUiNavigationBehaviorListener, int> BuildHierarchyRankMap(IReadOnlyList<TsUiNavigationBehaviorListener> listenerList)
		{
			Dictionary<TsUiNavigationBehaviorListener, int> dictionary = new Dictionary<TsUiNavigationBehaviorListener, int>();
			int i = 0;
			int count = listenerList.Count;
			while (i < count)
			{
				dictionary[listenerList[i]] = i;
				i++;
			}
			return dictionary;
		}

		// Token: 0x170079A6 RID: 31142
		// (get) Token: 0x06030D6D RID: 200045 RVA: 0x00B579A8 File Offset: 0x00B55BA8
		public List<TsUiNavigationBehaviorListener> LoopScrollSortListenerList
		{
			get
			{
				List<TsUiNavigationBehaviorListener> listenerList = this.ListenerList;
				Dictionary<TsUiNavigationBehaviorListener, int> hierarchyRankMap = this.BuildHierarchyRankMap(listenerList);
				List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>(listenerList);
				list.Sort(delegate(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
				{
					int num = 0;
					int num2 = 0;
					if (aListener.HasLoopScrollView() && bListener.HasLoopScrollView())
					{
						if (aListener.IsValid())
						{
							num = aListener.LoopScrollViewGridIndex;
						}
						if (bListener.IsValid())
						{
							num2 = bListener.LoopScrollViewGridIndex;
						}
						if (num != num2)
						{
							return num - num2;
						}
					}
					return hierarchyRankMap[aListener] - hierarchyRankMap[bListener];
				});
				return list;
			}
		}

		// Token: 0x170079A7 RID: 31143
		// (get) Token: 0x06030D6E RID: 200046 RVA: 0x00B579E8 File Offset: 0x00B55BE8
		public List<TsUiNavigationBehaviorListener> MultiTemplateScrollSortListenerList
		{
			get
			{
				List<TsUiNavigationBehaviorListener> listenerList = this.ListenerList;
				Dictionary<TsUiNavigationBehaviorListener, int> hierarchyRankMap = this.BuildHierarchyRankMap(listenerList);
				List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>(listenerList);
				list.Sort(delegate(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
				{
					int num = 0;
					int num2 = 0;
					if (aListener.HasMultiTemplateScrollView() && bListener.HasMultiTemplateScrollView())
					{
						if (aListener.IsValid())
						{
							num = aListener.LoopScrollViewGridIndex;
						}
						if (bListener.IsValid())
						{
							num2 = bListener.LoopScrollViewGridIndex;
						}
						if (num != num2)
						{
							return num - num2;
						}
					}
					return hierarchyRankMap[aListener] - hierarchyRankMap[bListener];
				});
				return list;
			}
		}

		// Token: 0x170079A8 RID: 31144
		// (get) Token: 0x06030D6F RID: 200047 RVA: 0x00B57A28 File Offset: 0x00B55C28
		public List<TsUiNavigationBehaviorListener> ActiveListenerList
		{
			get
			{
				List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
				int i = 0;
				int count = this.ListenerList.Count;
				while (i < count)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.ListenerList[i];
					if (tsUiNavigationBehaviorListener.IsListenerActive())
					{
						list.Add(tsUiNavigationBehaviorListener);
					}
					i++;
				}
				return list;
			}
		}

		// Token: 0x06030D70 RID: 200048 RVA: 0x00B57A70 File Offset: 0x00B55C70
		[NullableContext(2)]
		[return: Nullable(1)]
		public List<TsUiNavigationBehaviorListener> GetOppositeListenerListByListener(AActor srcScrollViewActor, AActor layoutViewActor)
		{
			if (this.AllowNavigationInSelfDynamic)
			{
				return new List<TsUiNavigationBehaviorListener>(this.ListenerList);
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			int i = 0;
			int count = this.ListenerList.Count;
			while (i < count)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.ListenerList[i];
				if ((srcScrollViewActor != null || tsUiNavigationBehaviorListener.ScrollViewActor != null || layoutViewActor != null || tsUiNavigationBehaviorListener.LayoutActor != null) && srcScrollViewActor == tsUiNavigationBehaviorListener.ScrollViewActor && layoutViewActor == tsUiNavigationBehaviorListener.LayoutActor)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
				i++;
			}
			return list;
		}

		// Token: 0x06030D71 RID: 200049 RVA: 0x00B57AEC File Offset: 0x00B55CEC
		public NavigationGroup(SNavigationGroup config)
		{
			this.Config = config;
			if (!string.IsNullOrEmpty(this.Config.InsideGroupName))
			{
				this.InsideGroupNameSetInternal.Add(this.Config.InsideGroupName);
			}
			int i = 0;
			int num = this.Config.ExtraInsideGroupNameList.Num();
			while (i < num)
			{
				string text = this.Config.ExtraInsideGroupNameList.Get(i);
				if (!string.IsNullOrEmpty(text))
				{
					this.InsideGroupNameSetInternal.Add(text);
				}
				i++;
			}
		}

		// Token: 0x170079A9 RID: 31145
		// (get) Token: 0x06030D72 RID: 200050 RVA: 0x00B57B89 File Offset: 0x00B55D89
		public bool AllowNavigationInSelfDynamic
		{
			get
			{
				return this.Config.AllowNavigationInSelfDynamic;
			}
		}

		// Token: 0x170079AA RID: 31146
		// (get) Token: 0x06030D73 RID: 200051 RVA: 0x00B57B96 File Offset: 0x00B55D96
		// (set) Token: 0x06030D74 RID: 200052 RVA: 0x00B57B9E File Offset: 0x00B55D9E
		[Nullable(2)]
		public TsUiNavigationBehaviorListener DefaultListener
		{
			[NullableContext(2)]
			get
			{
				return this.DefaultListenerInternal;
			}
			[NullableContext(2)]
			set
			{
				this.DefaultListenerInternal = value;
			}
		}

		// Token: 0x170079AB RID: 31147
		// (get) Token: 0x06030D75 RID: 200053 RVA: 0x00B57BA7 File Offset: 0x00B55DA7
		public string GroupName
		{
			get
			{
				return this.Config.GroupName;
			}
		}

		// Token: 0x170079AC RID: 31148
		// (get) Token: 0x06030D76 RID: 200054 RVA: 0x00B57BB4 File Offset: 0x00B55DB4
		public TMap<string, string> GroupNameMap
		{
			get
			{
				return this.Config.GroupNameMap;
			}
		}

		// Token: 0x170079AD RID: 31149
		// (get) Token: 0x06030D77 RID: 200055 RVA: 0x00B57BC1 File Offset: 0x00B55DC1
		public int GroupType
		{
			get
			{
				return this.Config.GroupType;
			}
		}

		// Token: 0x170079AE RID: 31150
		// (get) Token: 0x06030D78 RID: 200056 RVA: 0x00B57BCE File Offset: 0x00B55DCE
		public UINavigationPriorityMode HorizontalPriorityMode
		{
			get
			{
				return this.Config.HorizontalPriorityMode;
			}
		}

		// Token: 0x170079AF RID: 31151
		// (get) Token: 0x06030D79 RID: 200057 RVA: 0x00B57BDB File Offset: 0x00B55DDB
		public UINavigationWrapMode HorizontalWrapMode
		{
			get
			{
				return this.Config.HorizontalWrapMode;
			}
		}

		// Token: 0x170079B0 RID: 31152
		// (get) Token: 0x06030D7A RID: 200058 RVA: 0x00B57BE8 File Offset: 0x00B55DE8
		public string InsideGroupName
		{
			get
			{
				return this.Config.InsideGroupName;
			}
		}

		// Token: 0x170079B1 RID: 31153
		// (get) Token: 0x06030D7B RID: 200059 RVA: 0x00B57BF5 File Offset: 0x00B55DF5
		public HashSet<string> InsideGroupNameSet
		{
			get
			{
				return this.InsideGroupNameSetInternal;
			}
		}

		// Token: 0x170079B2 RID: 31154
		// (get) Token: 0x06030D7C RID: 200060 RVA: 0x00B57BFD File Offset: 0x00B55DFD
		// (set) Token: 0x06030D7D RID: 200061 RVA: 0x00B57C05 File Offset: 0x00B55E05
		[Nullable(2)]
		public TsUiNavigationBehaviorListener LastSelectListener
		{
			[NullableContext(2)]
			get
			{
				return this.LastListenerInternal;
			}
			[NullableContext(2)]
			set
			{
				this.LastListenerInternal = value;
			}
		}

		// Token: 0x170079B3 RID: 31155
		// (get) Token: 0x06030D7E RID: 200062 RVA: 0x00B57C0E File Offset: 0x00B55E0E
		public string NextGroupName
		{
			get
			{
				return this.Config.NextGroupName;
			}
		}

		// Token: 0x170079B4 RID: 31156
		// (get) Token: 0x06030D7F RID: 200063 RVA: 0x00B57C1B File Offset: 0x00B55E1B
		// (set) Token: 0x06030D80 RID: 200064 RVA: 0x00B57C28 File Offset: 0x00B55E28
		public string PrevGroupName
		{
			get
			{
				return this.Config.PrevGroupName;
			}
			set
			{
				this.Config.PrevGroupName = value;
			}
		}

		// Token: 0x170079B5 RID: 31157
		// (get) Token: 0x06030D81 RID: 200065 RVA: 0x00B57C36 File Offset: 0x00B55E36
		public bool RefreshNavigation
		{
			get
			{
				return this.Config.RefreshNavigation;
			}
		}

		// Token: 0x170079B6 RID: 31158
		// (get) Token: 0x06030D82 RID: 200066 RVA: 0x00B57C43 File Offset: 0x00B55E43
		public bool SelectableMemory
		{
			get
			{
				return this.Config.SelectableMemory;
			}
		}

		// Token: 0x170079B7 RID: 31159
		// (get) Token: 0x06030D83 RID: 200067 RVA: 0x00B57C50 File Offset: 0x00B55E50
		public bool SuitableListenerByNoDynamic
		{
			get
			{
				return this.Config.SuitableListenerByNoDynamic;
			}
		}

		// Token: 0x170079B8 RID: 31160
		// (get) Token: 0x06030D84 RID: 200068 RVA: 0x00B57C5D File Offset: 0x00B55E5D
		public UINavigationPriorityMode VerticalPriorityMode
		{
			get
			{
				return this.Config.VerticalPriorityMode;
			}
		}

		// Token: 0x170079B9 RID: 31161
		// (get) Token: 0x06030D85 RID: 200069 RVA: 0x00B57C6A File Offset: 0x00B55E6A
		public UINavigationWrapMode VerticalWrapMode
		{
			get
			{
				return this.Config.VerticalWrapMode;
			}
		}

		// Token: 0x170079BA RID: 31162
		// (get) Token: 0x06030D86 RID: 200070 RVA: 0x00B57C77 File Offset: 0x00B55E77
		public bool SlideToLeftOrTop
		{
			get
			{
				return this.Config.SlideToLeftOrTop;
			}
		}

		// Token: 0x170079BB RID: 31163
		// (get) Token: 0x06030D87 RID: 200071 RVA: 0x00B57C84 File Offset: 0x00B55E84
		public bool SlideToRightOrDown
		{
			get
			{
				return this.Config.SlideToRightOrDown;
			}
		}

		// Token: 0x170079BC RID: 31164
		// (get) Token: 0x06030D88 RID: 200072 RVA: 0x00B57C91 File Offset: 0x00B55E91
		public bool WaitScrollAnimation
		{
			get
			{
				return this.Config.WaitScrollAnimation;
			}
		}

		// Token: 0x0401A3A8 RID: 107432
		private readonly SNavigationGroup Config;

		// Token: 0x0401A3A9 RID: 107433
		private readonly HashSet<string> InsideGroupNameSetInternal = new HashSet<string>();

		// Token: 0x0401A3AA RID: 107434
		[Nullable(2)]
		private TsUiNavigationBehaviorListener DefaultListenerInternal;

		// Token: 0x0401A3AB RID: 107435
		[Nullable(2)]
		private TsUiNavigationBehaviorListener LastListenerInternal;

		// Token: 0x0401A3AC RID: 107436
		private bool IsListenerListDirty;

		// Token: 0x0401A3AD RID: 107437
		private readonly List<TsUiNavigationBehaviorListener> ListenerListInternal = new List<TsUiNavigationBehaviorListener>();
	}
}
