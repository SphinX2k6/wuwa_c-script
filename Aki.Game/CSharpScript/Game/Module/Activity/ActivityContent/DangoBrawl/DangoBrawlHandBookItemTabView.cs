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
	// Token: 0x02005758 RID: 22360
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTabView : UiTabViewBase
	{
		// Token: 0x17006A72 RID: 27250
		// (get) Token: 0x0603720A RID: 225802 RVA: 0x00F6294D File Offset: 0x00F60B4D
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A73 RID: 27251
		// (get) Token: 0x0603720B RID: 225803 RVA: 0x00F62959 File Offset: 0x00F60B59
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x0603720C RID: 225804 RVA: 0x00F62966 File Offset: 0x00F60B66
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

		// Token: 0x0603720D RID: 225805 RVA: 0x00F6299B File Offset: 0x00F60B9B
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			if (fromToggle)
			{
				this.TryPlayUiSequence("Close");
			}
		}

		// Token: 0x0603720E RID: 225806 RVA: 0x00F629AC File Offset: 0x00F60BAC
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

		// Token: 0x0603720F RID: 225807 RVA: 0x00F629E0 File Offset: 0x00F60BE0
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

		// Token: 0x06037210 RID: 225808 RVA: 0x00F62B10 File Offset: 0x00F60D10
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookItemTabView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTabView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037211 RID: 225809 RVA: 0x00F62B54 File Offset: 0x00F60D54
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

		// Token: 0x06037212 RID: 225810 RVA: 0x00F62BBC File Offset: 0x00F60DBC
		private bool HasItemTypeRedDot(EDangoBrawlHandBookItemType itemType)
		{
			if (itemType != EDangoBrawlHandBookItemType.All)
			{
				return this.ActivityData.HasNewItemRedDot(new int?((int)itemType));
			}
			return this.ActivityData.HasNewItemRedDot(null);
		}

		// Token: 0x06037213 RID: 225811 RVA: 0x00F62BF4 File Offset: 0x00F60DF4
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

		// Token: 0x06037214 RID: 225812 RVA: 0x00F62CAC File Offset: 0x00F60EAC
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

		// Token: 0x06037215 RID: 225813 RVA: 0x00F62CFC File Offset: 0x00F60EFC
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

		// Token: 0x06037216 RID: 225814 RVA: 0x00F62F14 File Offset: 0x00F61114
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

		// Token: 0x06037217 RID: 225815 RVA: 0x00F62F9C File Offset: 0x00F6119C
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

		// Token: 0x06037218 RID: 225816 RVA: 0x00F63020 File Offset: 0x00F61220
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

		// Token: 0x06037219 RID: 225817 RVA: 0x00F63080 File Offset: 0x00F61280
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

		// Token: 0x0603721A RID: 225818 RVA: 0x00F631E4 File Offset: 0x00F613E4
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

		// Token: 0x0603721B RID: 225819 RVA: 0x00F63254 File Offset: 0x00F61454
		private DangoBrawlHandBookItemTabItem InitItemTypeTabItem()
		{
			return new DangoBrawlHandBookItemTabItem
			{
				OnClickToggleBack = new Action<int, DangoBrawlHandBookItemTabData>(this.ItemTypeToggleCallBack)
			};
		}

		// Token: 0x0603721C RID: 225820 RVA: 0x00F6326D File Offset: 0x00F6146D
		private void ItemTypeToggleCallBack(int gridIndex, DangoBrawlHandBookItemTabData itemData)
		{
			this.TryPlayUiSequence("Switch1");
			this.ItemTypeLayout.SelectGridProxy(gridIndex, false);
			this.OpenItemTypeTab(itemData.ItemType, true);
		}

		// Token: 0x0603721D RID: 225821 RVA: 0x00F63294 File Offset: 0x00F61494
		private void OpenFilterView()
		{
			DangoBrawlHandBookFilterOpenData param = new DangoBrawlHandBookFilterOpenData
			{
				SelectedOccupationIds = new List<int>(this.SelectedOccupationIds),
				OnConfirm = new Action<List<int>>(this.ApplyOccupationFilter)
			};
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookFilterView, param, null);
		}

		// Token: 0x0603721E RID: 225822 RVA: 0x00F632DB File Offset: 0x00F614DB
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

		// Token: 0x0603721F RID: 225823 RVA: 0x00F63318 File Offset: 0x00F61518
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

		// Token: 0x06037220 RID: 225824 RVA: 0x00F6334C File Offset: 0x00F6154C
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

		// Token: 0x06037221 RID: 225825 RVA: 0x00F6347C File Offset: 0x00F6167C
		private void OnItemClick(DangoBrawlHandBookItemData data, int index)
		{
			this.SelectItemByGridIndex(index);
		}

		// Token: 0x06037222 RID: 225826 RVA: 0x00F63485 File Offset: 0x00F61685
		private void OnUnlockAnimPlayed(int itemId)
		{
			this.ActivityData.RemoveNewItemUnlockAnim(itemId);
		}

		// Token: 0x06037223 RID: 225827 RVA: 0x00F63494 File Offset: 0x00F61694
		private bool IsSelected(int itemId)
		{
			return this.SelectedItemId == itemId;
		}

		// Token: 0x06037224 RID: 225828 RVA: 0x00F634A0 File Offset: 0x00F616A0
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

		// Token: 0x06037225 RID: 225829 RVA: 0x00F63518 File Offset: 0x00F61718
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

		// Token: 0x06037226 RID: 225830 RVA: 0x00F63550 File Offset: 0x00F61750
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

		// Token: 0x06037227 RID: 225831 RVA: 0x00F635F0 File Offset: 0x00F617F0
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

		// Token: 0x0401D243 RID: 119363
		private readonly EDangoBrawlHandBookItemType[] HandBookItemTypeList = new EDangoBrawlHandBookItemType[]
		{
			EDangoBrawlHandBookItemType.All,
			EDangoBrawlHandBookItemType.Bag,
			EDangoBrawlHandBookItemType.Weapon,
			EDangoBrawlHandBookItemType.Decorate,
			EDangoBrawlHandBookItemType.Gem,
			EDangoBrawlHandBookItemType.Others
		};

		// Token: 0x0401D244 RID: 119364
		[Nullable(2)]
		private DangoBrawlHandBookFilterItem FilterItem;

		// Token: 0x0401D245 RID: 119365
		[Nullable(2)]
		private DangoBrawlHandBookItemTips ItemTips;

		// Token: 0x0401D246 RID: 119366
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlHandBookItemTabItem, DangoBrawlHandBookItemTabData> ItemTypeLayout;

		// Token: 0x0401D247 RID: 119367
		private List<DangoBrawlHandBookItemTabData> ItemTypeTabDataList = new List<DangoBrawlHandBookItemTabData>();

		// Token: 0x0401D248 RID: 119368
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x0401D249 RID: 119369
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401D24A RID: 119370
		private readonly List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x0401D24B RID: 119371
		private EDangoBrawlHandBookItemType CurrentItemType;

		// Token: 0x0401D24C RID: 119372
		private int SelectedIndex = -1;

		// Token: 0x0401D24D RID: 119373
		private int SelectedItemId;

		// Token: 0x0401D24E RID: 119374
		private bool EnableUiSequence;

		// Token: 0x0401D24F RID: 119375
		private readonly Dictionary<int, Dictionary<int, DangoBrawlHandBookTitleTemplateData>> TitleMap = new Dictionary<int, Dictionary<int, DangoBrawlHandBookTitleTemplateData>>();

		// Token: 0x0401D250 RID: 119376
		private readonly Dictionary<int, Dictionary<int, List<DangoBrawlHandBookItemTemplateData>>> ItemMap = new Dictionary<int, Dictionary<int, List<DangoBrawlHandBookItemTemplateData>>>();

		// Token: 0x0200B348 RID: 45896
		[NullableContext(0)]
		private enum ETabViewComponent
		{
			// Token: 0x04037665 RID: 226917
			ItemTabContent,
			// Token: 0x04037666 RID: 226918
			ItemTabTogItem,
			// Token: 0x04037667 RID: 226919
			ItemMultiScrollView,
			// Token: 0x04037668 RID: 226920
			ScrollTitleItem,
			// Token: 0x04037669 RID: 226921
			ScrollNormalItem,
			// Token: 0x0403766A RID: 226922
			TxtTotalGet,
			// Token: 0x0403766B RID: 226923
			FilterItem,
			// Token: 0x0403766C RID: 226924
			ItemDetailTips
		}
	}
}
