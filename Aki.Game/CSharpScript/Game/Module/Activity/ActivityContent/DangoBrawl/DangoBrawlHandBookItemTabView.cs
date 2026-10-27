using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006808 RID: 26632
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTabView : UiTabViewBase
	{
		// Token: 0x17009731 RID: 38705
		// (get) Token: 0x060426B5 RID: 272053 RVA: 0x01021409 File Offset: 0x0101F609
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17009732 RID: 38706
		// (get) Token: 0x060426B6 RID: 272054 RVA: 0x01021415 File Offset: 0x0101F615
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x060426B7 RID: 272055 RVA: 0x01021422 File Offset: 0x0101F622
		protected override void OnShowUiTabViewFromToggle()
		{
			this.EnableUiSequence = true;
			this.TryPlayUiSequence("Start");
			GenericLayout<DangoBrawlHandBookItemTabItem, DangoBrawlHandBookItemTabData> itemTypeLayout = this.ItemTypeLayout;
			if (itemTypeLayout == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = itemTypeLayout.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}

		// Token: 0x060426B8 RID: 272056 RVA: 0x01021457 File Offset: 0x0101F657
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			if (fromToggle)
			{
				this.TryPlayUiSequence("Close");
			}
		}

		// Token: 0x060426B9 RID: 272057 RVA: 0x01021468 File Offset: 0x0101F668
		private void TryPlayUiSequence(string sequenceName)
		{
			if (!this.EnableUiSequence)
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence(sequenceName, false, null);
		}

		// Token: 0x060426BA RID: 272058 RVA: 0x0102149C File Offset: 0x0101F69C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060426BB RID: 272059 RVA: 0x010215CC File Offset: 0x0101F7CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookItemTabView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTabView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060426BC RID: 272060 RVA: 0x01021610 File Offset: 0x0101F810
		private List<DangoBrawlHandBookItemTabData> CreateItemTypeTabDataList()
		{
			List<DangoBrawlHandBookItemTabData> list = new List<DangoBrawlHandBookItemTabData>();
			for (int i = 0; i < this.HandBookItemTypeList.Length; i++)
			{
				EDangoBrawlHandBookItemType itemType = this.HandBookItemTypeList[i];
				list.Add(new DangoBrawlHandBookItemTabData
				{
					ItemType = itemType,
					IsShowLine = (i != this.HandBookItemTypeList.Length - 1),
					HasNew = this.HasItemTypeRedDot(itemType)
				});
			}
			return list;
		}

		// Token: 0x060426BD RID: 272061 RVA: 0x01021678 File Offset: 0x0101F878
		private bool HasItemTypeRedDot(EDangoBrawlHandBookItemType itemType)
		{
			if (itemType != EDangoBrawlHandBookItemType.All)
			{
				return this.ActivityData.HasNewItemRedDot(new int?((int)itemType));
			}
			return this.ActivityData.HasNewItemRedDot(null);
		}

		// Token: 0x060426BE RID: 272062 RVA: 0x010216B0 File Offset: 0x0101F8B0
		private void RefreshItemTypeTabRedDots()
		{
			foreach (DangoBrawlHandBookItemTabData dangoBrawlHandBookItemTabData in this.ItemTypeTabDataList)
			{
				dangoBrawlHandBookItemTabData.HasNew = this.HasItemTypeRedDot(dangoBrawlHandBookItemTabData.ItemType);
			}
			GenericLayout<DangoBrawlHandBookItemTabItem, DangoBrawlHandBookItemTabData> itemTypeLayout = this.ItemTypeLayout;
			int num = (itemTypeLayout != null) ? itemTypeLayout.GetSelectedGridIndex() : -1;
			for (int i = 0; i < this.ItemTypeTabDataList.Count; i++)
			{
				GenericLayout<DangoBrawlHandBookItemTabItem, DangoBrawlHandBookItemTabData> itemTypeLayout2 = this.ItemTypeLayout;
				if (itemTypeLayout2 != null)
				{
					DangoBrawlHandBookItemTabItem layoutItemByIndex = itemTypeLayout2.GetLayoutItemByIndex(i);
					if (layoutItemByIndex != null)
					{
						layoutItemByIndex.Refresh(this.ItemTypeTabDataList[i], i == num, i);
					}
				}
			}
		}

		// Token: 0x060426BF RID: 272063 RVA: 0x01021768 File Offset: 0x0101F968
		private void OpenItemTypeTab(EDangoBrawlHandBookItemType itemType, bool collectRedDot)
		{
			this.CurrentItemType = itemType;
			if (collectRedDot)
			{
				int? itemType2 = (itemType == EDangoBrawlHandBookItemType.All) ? null : new int?((int)itemType);
				this.ActivityData.CollectNewItemRedDotOnTabOpen(itemType2);
				this.RefreshItemTypeTabRedDots();
			}
			this.InitScrollViewData(this.CurrentItemType);
			this.RefreshMultiScrollView();
		}

		// Token: 0x060426C0 RID: 272064 RVA: 0x010217B8 File Offset: 0x0101F9B8
		private void InitAllHandBookMap()
		{
			this.TitleMap.Clear();
			this.ItemMap.Clear();
			IEnumerable<DangoBrawlItem> itemConfigList = DangoBrawlConfig.Instance.GetItemConfigList();
			List<DangoBrawlHandBookItemSortData> list = new List<DangoBrawlHandBookItemSortData>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (DangoBrawlItem dangoBrawlItem in itemConfigList)
			{
				if (dangoBrawlItem.IsShowInHandBook)
				{
					DangoBrawlHandBookItemSortData item = new DangoBrawlHandBookItemSortData
					{
						ItemId = dangoBrawlItem.Id,
						ItemType = dangoBrawlItem.Type,
						ItemSubType = dangoBrawlItem.SubType,
						ItemName = dangoBrawlItem.Name,
						ItemIcon = dangoBrawlItem.IconHandBook,
						Quality = dangoBrawlItem.Quality,
						IsUnlocked = this.OutGameData.IsItemUnlocked(dangoBrawlItem.Id)
					};
					list.Add(item);
					dictionary[dangoBrawlItem.Id] = dangoBrawlItem.OccupationId;
				}
			}
			list.Sort(new Comparison<DangoBrawlHandBookItemSortData>(this.SortHandBookItemDataFunc));
			foreach (DangoBrawlHandBookItemSortData dangoBrawlHandBookItemSortData in list)
			{
				int itemType = dangoBrawlHandBookItemSortData.ItemType;
				int itemSubType = dangoBrawlHandBookItemSortData.ItemSubType;
				int occupationId;
				dictionary.TryGetValue(dangoBrawlHandBookItemSortData.ItemId, out occupationId);
				DangoBrawlHandBookItemTemplateData item2 = this.CreateHandBookItemData(dangoBrawlHandBookItemSortData, occupationId);
				Dictionary<int, DangoBrawlHandBookTitleTemplateData> dictionary2;
				if (!this.TitleMap.TryGetValue(itemType, out dictionary2))
				{
					dictionary2 = new Dictionary<int, DangoBrawlHandBookTitleTemplateData>();
					this.TitleMap[itemType] = dictionary2;
				}
				if (!dictionary2.ContainsKey(itemSubType))
				{
					dictionary2[itemSubType] = this.CreateHandBookTitleData(itemSubType);
				}
				Dictionary<int, List<DangoBrawlHandBookItemTemplateData>> dictionary3;
				if (!this.ItemMap.TryGetValue(itemType, out dictionary3))
				{
					dictionary3 = new Dictionary<int, List<DangoBrawlHandBookItemTemplateData>>();
					this.ItemMap[itemType] = dictionary3;
				}
				List<DangoBrawlHandBookItemTemplateData> list2;
				if (!dictionary3.TryGetValue(itemSubType, out list2))
				{
					list2 = new List<DangoBrawlHandBookItemTemplateData>();
					dictionary3[itemSubType] = list2;
				}
				list2.Add(item2);
			}
		}

		// Token: 0x060426C1 RID: 272065 RVA: 0x010219D0 File Offset: 0x0101FBD0
		private int SortHandBookItemDataFunc(DangoBrawlHandBookItemSortData a, DangoBrawlHandBookItemSortData b)
		{
			if (a.ItemType != b.ItemType)
			{
				return a.ItemType - b.ItemType;
			}
			if (a.ItemSubType != b.ItemSubType)
			{
				return a.ItemSubType - b.ItemSubType;
			}
			if (a.IsUnlocked != b.IsUnlocked)
			{
				if (!a.IsUnlocked)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (a.Quality != b.Quality)
				{
					return b.Quality - a.Quality;
				}
				return a.ItemId - b.ItemId;
			}
		}

		// Token: 0x060426C2 RID: 272066 RVA: 0x01021A58 File Offset: 0x0101FC58
		private DangoBrawlHandBookTitleTemplateData CreateHandBookTitleData(int itemSubType)
		{
			DangoBrawlItemSubType? itemSubTypeConfigById = DangoBrawlConfig.Instance.GetItemSubTypeConfigById(itemSubType);
			return new DangoBrawlHandBookTitleTemplateData
			{
				Data = new DangBrawlHandBookTitleData
				{
					Title = (((itemSubTypeConfigById != null) ? itemSubTypeConfigById.GetValueOrDefault().Name : null) ?? string.Empty),
					Icon = (((itemSubTypeConfigById != null) ? itemSubTypeConfigById.GetValueOrDefault().Icon : null) ?? string.Empty)
				}
			};
		}

		// Token: 0x060426C3 RID: 272067 RVA: 0x01021ADC File Offset: 0x0101FCDC
		private DangoBrawlHandBookItemTemplateData CreateHandBookItemData(DangoBrawlHandBookItemSortData itemData, int occupationId)
		{
			return new DangoBrawlHandBookItemTemplateData
			{
				Data = new DangoBrawlHandBookItemData
				{
					ItemId = itemData.ItemId,
					OccupationId = occupationId,
					ItemName = itemData.ItemName,
					ItemIcon = itemData.ItemIcon,
					ItemQuality = itemData.Quality,
					IsUnlocked = itemData.IsUnlocked
				}
			};
		}

		// Token: 0x060426C4 RID: 272068 RVA: 0x01021B3C File Offset: 0x0101FD3C
		private List<IMultiTemplateGridData> CollectGridDataListByItemType(int itemType)
		{
			Dictionary<int, DangoBrawlHandBookTitleTemplateData> dictionary;
			Dictionary<int, List<DangoBrawlHandBookItemTemplateData>> dictionary2;
			if (!this.TitleMap.TryGetValue(itemType, out dictionary) || !this.ItemMap.TryGetValue(itemType, out dictionary2))
			{
				return new List<IMultiTemplateGridData>();
			}
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			foreach (int key in dictionary.Keys)
			{
				List<DangoBrawlHandBookItemTemplateData> list2;
				if (dictionary2.TryGetValue(key, out list2))
				{
					List<DangoBrawlHandBookItemTemplateData> list3;
					if (this.SelectedOccupationIds.Count > 0)
					{
						list3 = new List<DangoBrawlHandBookItemTemplateData>();
						foreach (DangoBrawlHandBookItemTemplateData dangoBrawlHandBookItemTemplateData in list2)
						{
							if (this.SelectedOccupationIds.Contains(dangoBrawlHandBookItemTemplateData.Data.OccupationId))
							{
								list3.Add(dangoBrawlHandBookItemTemplateData);
							}
						}
						if (list3.Count == 0)
						{
							continue;
						}
					}
					else
					{
						list3 = list2;
					}
					DangoBrawlHandBookTitleTemplateData item;
					if (dictionary.TryGetValue(key, out item))
					{
						list.Add(item);
					}
					foreach (DangoBrawlHandBookItemTemplateData item2 in list3)
					{
						list.Add(item2);
					}
				}
			}
			return list;
		}

		// Token: 0x060426C5 RID: 272069 RVA: 0x01021CA0 File Offset: 0x0101FEA0
		private List<IMultiTemplateGridData> GetItemGridDataList(EDangoBrawlHandBookItemType itemType)
		{
			if (itemType == EDangoBrawlHandBookItemType.All)
			{
				List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
				foreach (int itemType2 in this.TitleMap.Keys)
				{
					list.AddRange(this.CollectGridDataListByItemType(itemType2));
				}
				return list;
			}
			return this.CollectGridDataListByItemType((int)itemType);
		}

		// Token: 0x060426C6 RID: 272070 RVA: 0x01021D10 File Offset: 0x0101FF10
		private DangoBrawlHandBookItemTabItem InitItemTypeTabItem()
		{
			return new DangoBrawlHandBookItemTabItem
			{
				OnClickToggleBack = new Action<int, DangoBrawlHandBookItemTabData>(this.ItemTypeToggleCallBack)
			};
		}

		// Token: 0x060426C7 RID: 272071 RVA: 0x01021D29 File Offset: 0x0101FF29
		private void ItemTypeToggleCallBack(int gridIndex, DangoBrawlHandBookItemTabData itemData)
		{
			this.TryPlayUiSequence("Switch1");
			this.ItemTypeLayout.SelectGridProxy(gridIndex, false);
			this.OpenItemTypeTab(itemData.ItemType, true);
		}

		// Token: 0x060426C8 RID: 272072 RVA: 0x01021D50 File Offset: 0x0101FF50
		private void OpenFilterView()
		{
			DangoBrawlHandBookFilterOpenData param = new DangoBrawlHandBookFilterOpenData
			{
				SelectedOccupationIds = new List<int>(this.SelectedOccupationIds),
				OnConfirm = new Action<List<int>>(this.ApplyOccupationFilter)
			};
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookFilterView, param, null);
		}

		// Token: 0x060426C9 RID: 272073 RVA: 0x01021D97 File Offset: 0x0101FF97
		private void ApplyOccupationFilter(List<int> occupationIds)
		{
			this.SelectedOccupationIds.Clear();
			this.SelectedOccupationIds.AddRange(occupationIds);
			DangoBrawlHandBookFilterItem filterItem = this.FilterItem;
			if (filterItem != null)
			{
				filterItem.RefreshFilterInfo(this.SelectedOccupationIds);
			}
			this.OpenItemTypeTab(this.CurrentItemType, false);
		}

		// Token: 0x060426CA RID: 272074 RVA: 0x01021DD4 File Offset: 0x0101FFD4
		private void ClearOccupationFilter()
		{
			this.SelectedOccupationIds.Clear();
			DangoBrawlHandBookFilterItem filterItem = this.FilterItem;
			if (filterItem != null)
			{
				filterItem.RefreshFilterInfo(this.SelectedOccupationIds);
			}
			this.OpenItemTypeTab(this.CurrentItemType, false);
		}

		// Token: 0x060426CB RID: 272075 RVA: 0x01021E08 File Offset: 0x01020008
		private void InitScrollViewData(EDangoBrawlHandBookItemType itemType)
		{
			this.CurrentItemType = itemType;
			this.ScrollDataList.Clear();
			this.ScrollDataList.AddRange(this.GetItemGridDataList(itemType));
			int num = 0;
			int num2 = 0;
			foreach (IMultiTemplateGridData multiTemplateGridData in this.ScrollDataList)
			{
				DangoBrawlHandBookItemTemplateData dangoBrawlHandBookItemTemplateData = multiTemplateGridData as DangoBrawlHandBookItemTemplateData;
				if (dangoBrawlHandBookItemTemplateData != null)
				{
					DangoBrawlHandBookItemData data = dangoBrawlHandBookItemTemplateData.Data;
					dangoBrawlHandBookItemTemplateData.OnClickCb = new Action<DangoBrawlHandBookItemData, int>(this.OnItemClick);
					dangoBrawlHandBookItemTemplateData.IsSelected = new Func<int, bool>(this.IsSelected);
					dangoBrawlHandBookItemTemplateData.OnUnlockAnimPlayed = new Action<int>(this.OnUnlockAnimPlayed);
					data.IsNew = new bool?(data.IsUnlocked && this.ActivityData.HasNewItemUnlockAnim(data.ItemId));
					if (data.IsUnlocked)
					{
						num++;
					}
					num2++;
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "DangoBrawlGeneral_1014", new <>z__ReadOnlyArray<object>(new object[]
			{
				num.ToString(),
				num2.ToString()
			}));
		}

		// Token: 0x060426CC RID: 272076 RVA: 0x01021F38 File Offset: 0x01020138
		private void OnItemClick(DangoBrawlHandBookItemData data, int index)
		{
			this.SelectItemByGridIndex(index);
		}

		// Token: 0x060426CD RID: 272077 RVA: 0x01021F41 File Offset: 0x01020141
		private void OnUnlockAnimPlayed(int itemId)
		{
			this.ActivityData.RemoveNewItemUnlockAnim(itemId);
		}

		// Token: 0x060426CE RID: 272078 RVA: 0x01021F50 File Offset: 0x01020150
		private bool IsSelected(int itemId)
		{
			return this.SelectedItemId == itemId;
		}

		// Token: 0x060426CF RID: 272079 RVA: 0x01021F5C File Offset: 0x0102015C
		private int GetDefaultSelectedIndex()
		{
			for (int i = 0; i < this.ScrollDataList.Count; i++)
			{
				DangoBrawlHandBookItemTemplateData dangoBrawlHandBookItemTemplateData = this.ScrollDataList[i] as DangoBrawlHandBookItemTemplateData;
				if (dangoBrawlHandBookItemTemplateData != null && dangoBrawlHandBookItemTemplateData.Data.IsNew.GetValueOrDefault())
				{
					return i;
				}
			}
			for (int j = 0; j < this.ScrollDataList.Count; j++)
			{
				if (this.ScrollDataList[j] is DangoBrawlHandBookItemTemplateData)
				{
					return j;
				}
			}
			return -1;
		}

		// Token: 0x060426D0 RID: 272080 RVA: 0x01021FD4 File Offset: 0x010201D4
		private int GetScrollToGridIndex(int itemIndex)
		{
			if (itemIndex < 0)
			{
				return -1;
			}
			for (int i = itemIndex; i >= 0; i--)
			{
				if (this.ScrollDataList[i] is DangoBrawlHandBookTitleTemplateData)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060426D1 RID: 272081 RVA: 0x0102200C File Offset: 0x0102020C
		private void SelectItemByGridIndex(int index)
		{
			if (index < 0 || index >= this.ScrollDataList.Count)
			{
				return;
			}
			DangoBrawlHandBookItemTemplateData dangoBrawlHandBookItemTemplateData = this.ScrollDataList[index] as DangoBrawlHandBookItemTemplateData;
			if (dangoBrawlHandBookItemTemplateData == null)
			{
				return;
			}
			this.TryPlayUiSequence("Switch2");
			int selectedIndex = this.SelectedIndex;
			this.SelectedItemId = dangoBrawlHandBookItemTemplateData.Data.ItemId;
			this.SelectedIndex = index;
			if (selectedIndex >= 0 && selectedIndex != index)
			{
				this.ItemMultiTemplateScrollView.RefreshProxyDirectly(selectedIndex);
			}
			this.ItemMultiTemplateScrollView.RefreshProxyDirectly(index);
			DangoBrawlHandBookItemTips itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return;
			}
			itemTips.RefreshAsync(dangoBrawlHandBookItemTemplateData.Data).Forget();
		}

		// Token: 0x060426D2 RID: 272082 RVA: 0x010220AC File Offset: 0x010202AC
		private void RefreshMultiScrollView()
		{
			int defaultSelectedIndex = this.GetDefaultSelectedIndex();
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList)
			{
				ScrollToGridIndex = this.GetScrollToGridIndex(defaultSelectedIndex),
				PlayGridAnim = true
			};
			this.SelectedIndex = -1;
			this.SelectedItemId = 0;
			this.ItemMultiTemplateScrollView.RefreshByData(context);
			if (defaultSelectedIndex >= 0)
			{
				this.SelectItemByGridIndex(defaultSelectedIndex);
			}
		}

		// Token: 0x040229E6 RID: 141798
		private readonly EDangoBrawlHandBookItemType[] HandBookItemTypeList = new EDangoBrawlHandBookItemType[]
		{
			EDangoBrawlHandBookItemType.All,
			EDangoBrawlHandBookItemType.Bag,
			EDangoBrawlHandBookItemType.Weapon,
			EDangoBrawlHandBookItemType.Decorate,
			EDangoBrawlHandBookItemType.Gem,
			EDangoBrawlHandBookItemType.Others
		};

		// Token: 0x040229E7 RID: 141799
		[Nullable(2)]
		private DangoBrawlHandBookFilterItem FilterItem;

		// Token: 0x040229E8 RID: 141800
		[Nullable(2)]
		private DangoBrawlHandBookItemTips ItemTips;

		// Token: 0x040229E9 RID: 141801
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlHandBookItemTabItem, DangoBrawlHandBookItemTabData> ItemTypeLayout;

		// Token: 0x040229EA RID: 141802
		private List<DangoBrawlHandBookItemTabData> ItemTypeTabDataList = new List<DangoBrawlHandBookItemTabData>();

		// Token: 0x040229EB RID: 141803
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x040229EC RID: 141804
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x040229ED RID: 141805
		private readonly List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x040229EE RID: 141806
		private EDangoBrawlHandBookItemType CurrentItemType;

		// Token: 0x040229EF RID: 141807
		private int SelectedIndex = -1;

		// Token: 0x040229F0 RID: 141808
		private int SelectedItemId;

		// Token: 0x040229F1 RID: 141809
		private bool EnableUiSequence;

		// Token: 0x040229F2 RID: 141810
		private readonly Dictionary<int, Dictionary<int, DangoBrawlHandBookTitleTemplateData>> TitleMap = new Dictionary<int, Dictionary<int, DangoBrawlHandBookTitleTemplateData>>();

		// Token: 0x040229F3 RID: 141811
		private readonly Dictionary<int, Dictionary<int, List<DangoBrawlHandBookItemTemplateData>>> ItemMap = new Dictionary<int, Dictionary<int, List<DangoBrawlHandBookItemTemplateData>>>();

		// Token: 0x0200C97B RID: 51579
		[NullableContext(0)]
		private enum ETabViewComponent
		{
			// Token: 0x0403CD78 RID: 249208
			ItemTabContent,
			// Token: 0x0403CD79 RID: 249209
			ItemTabTogItem,
			// Token: 0x0403CD7A RID: 249210
			ItemMultiScrollView,
			// Token: 0x0403CD7B RID: 249211
			ScrollTitleItem,
			// Token: 0x0403CD7C RID: 249212
			ScrollNormalItem,
			// Token: 0x0403CD7D RID: 249213
			TxtTotalGet,
			// Token: 0x0403CD7E RID: 249214
			FilterItem,
			// Token: 0x0403CD7F RID: 249215
			ItemDetailTips
		}
	}
}
