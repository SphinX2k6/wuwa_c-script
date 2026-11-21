using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200386D RID: 14445
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationGroup
	{
		// Token: 0x06025895 RID: 153749 RVA: 0x00A926A3 File Offset: 0x00A908A3
		public void AddListener(TsUiNavigationBehaviorListener value)
		{
			this.ListenerListInternal.Add(value);
			this.IsListenerListDirty = true;
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x00A926B8 File Offset: 0x00A908B8
		public void RemoveListenerByIndex(int index)
		{
			this.ListenerListInternal.RemoveAt(index);
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x06025897 RID: 153751 RVA: 0x00A926C6 File Offset: 0x00A908C6
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

		// Token: 0x06025898 RID: 153752 RVA: 0x00A926E4 File Offset: 0x00A908E4
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

		// Token: 0x06025899 RID: 153753 RVA: 0x00A927E0 File Offset: 0x00A909E0
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

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x0602589A RID: 153754 RVA: 0x00A92818 File Offset: 0x00A90A18
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

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x0602589B RID: 153755 RVA: 0x00A92858 File Offset: 0x00A90A58
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

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x0602589C RID: 153756 RVA: 0x00A92898 File Offset: 0x00A90A98
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

		// Token: 0x0602589D RID: 153757 RVA: 0x00A928E0 File Offset: 0x00A90AE0
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

		// Token: 0x0602589E RID: 153758 RVA: 0x00A9295C File Offset: 0x00A90B5C
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

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x0602589F RID: 153759 RVA: 0x00A929F9 File Offset: 0x00A90BF9
		public bool AllowNavigationInSelfDynamic
		{
			get
			{
				return this.Config.AllowNavigationInSelfDynamic;
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x060258A0 RID: 153760 RVA: 0x00A92A06 File Offset: 0x00A90C06
		// (set) Token: 0x060258A1 RID: 153761 RVA: 0x00A92A0E File Offset: 0x00A90C0E
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

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x060258A2 RID: 153762 RVA: 0x00A92A17 File Offset: 0x00A90C17
		public string GroupName
		{
			get
			{
				return this.Config.GroupName;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x060258A3 RID: 153763 RVA: 0x00A92A24 File Offset: 0x00A90C24
		public TMap<string, string> GroupNameMap
		{
			get
			{
				return this.Config.GroupNameMap;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x060258A4 RID: 153764 RVA: 0x00A92A31 File Offset: 0x00A90C31
		public int GroupType
		{
			get
			{
				return this.Config.GroupType;
			}
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x060258A5 RID: 153765 RVA: 0x00A92A3E File Offset: 0x00A90C3E
		public UINavigationPriorityMode HorizontalPriorityMode
		{
			get
			{
				return this.Config.HorizontalPriorityMode;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x060258A6 RID: 153766 RVA: 0x00A92A4B File Offset: 0x00A90C4B
		public UINavigationWrapMode HorizontalWrapMode
		{
			get
			{
				return this.Config.HorizontalWrapMode;
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x060258A7 RID: 153767 RVA: 0x00A92A58 File Offset: 0x00A90C58
		public string InsideGroupName
		{
			get
			{
				return this.Config.InsideGroupName;
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x060258A8 RID: 153768 RVA: 0x00A92A65 File Offset: 0x00A90C65
		public HashSet<string> InsideGroupNameSet
		{
			get
			{
				return this.InsideGroupNameSetInternal;
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x060258A9 RID: 153769 RVA: 0x00A92A6D File Offset: 0x00A90C6D
		// (set) Token: 0x060258AA RID: 153770 RVA: 0x00A92A75 File Offset: 0x00A90C75
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

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x060258AB RID: 153771 RVA: 0x00A92A7E File Offset: 0x00A90C7E
		public string NextGroupName
		{
			get
			{
				return this.Config.NextGroupName;
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x060258AC RID: 153772 RVA: 0x00A92A8B File Offset: 0x00A90C8B
		// (set) Token: 0x060258AD RID: 153773 RVA: 0x00A92A98 File Offset: 0x00A90C98
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

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x060258AE RID: 153774 RVA: 0x00A92AA6 File Offset: 0x00A90CA6
		public bool RefreshNavigation
		{
			get
			{
				return this.Config.RefreshNavigation;
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x060258AF RID: 153775 RVA: 0x00A92AB3 File Offset: 0x00A90CB3
		public bool SelectableMemory
		{
			get
			{
				return this.Config.SelectableMemory;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x060258B0 RID: 153776 RVA: 0x00A92AC0 File Offset: 0x00A90CC0
		public bool SuitableListenerByNoDynamic
		{
			get
			{
				return this.Config.SuitableListenerByNoDynamic;
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x060258B1 RID: 153777 RVA: 0x00A92ACD File Offset: 0x00A90CCD
		public UINavigationPriorityMode VerticalPriorityMode
		{
			get
			{
				return this.Config.VerticalPriorityMode;
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x060258B2 RID: 153778 RVA: 0x00A92ADA File Offset: 0x00A90CDA
		public UINavigationWrapMode VerticalWrapMode
		{
			get
			{
				return this.Config.VerticalWrapMode;
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x060258B3 RID: 153779 RVA: 0x00A92AE7 File Offset: 0x00A90CE7
		public bool SlideToLeftOrTop
		{
			get
			{
				return this.Config.SlideToLeftOrTop;
			}
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x060258B4 RID: 153780 RVA: 0x00A92AF4 File Offset: 0x00A90CF4
		public bool SlideToRightOrDown
		{
			get
			{
				return this.Config.SlideToRightOrDown;
			}
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x060258B5 RID: 153781 RVA: 0x00A92B01 File Offset: 0x00A90D01
		public bool WaitScrollAnimation
		{
			get
			{
				return this.Config.WaitScrollAnimation;
			}
		}

		// Token: 0x04014C1B RID: 85019
		private readonly SNavigationGroup Config;

		// Token: 0x04014C1C RID: 85020
		private readonly HashSet<string> InsideGroupNameSetInternal = new HashSet<string>();

		// Token: 0x04014C1D RID: 85021
		[Nullable(2)]
		private TsUiNavigationBehaviorListener DefaultListenerInternal;

		// Token: 0x04014C1E RID: 85022
		[Nullable(2)]
		private TsUiNavigationBehaviorListener LastListenerInternal;

		// Token: 0x04014C1F RID: 85023
		private bool IsListenerListDirty;

		// Token: 0x04014C20 RID: 85024
		private readonly List<TsUiNavigationBehaviorListener> ListenerListInternal = new List<TsUiNavigationBehaviorListener>();
	}
}
