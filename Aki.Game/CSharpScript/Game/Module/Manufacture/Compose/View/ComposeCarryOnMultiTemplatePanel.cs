using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200463B RID: 17979
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeCarryOnMultiTemplatePanel
	{
		// Token: 0x0602D330 RID: 185136 RVA: 0x00CA3724 File Offset: 0x00CA1924
		public ComposeCarryOnMultiTemplatePanel(UUIMultiTemplateScrollViewComponent scrollViewComponent)
		{
			this.ScrollView = new MultiTemplateScrollView(scrollViewComponent);
		}

		// Token: 0x0602D331 RID: 185137 RVA: 0x00CA374A File Offset: 0x00CA194A
		public void RefreshByData(List<IBaseItemData> itemList, bool scrollToTop = true)
		{
			this.SelectedGridIndex = -1;
			this.DataList = this.BuildSingleGroupDataList(itemList);
			this.DoRefresh(scrollToTop);
		}

		// Token: 0x0602D332 RID: 185138 RVA: 0x00CA3767 File Offset: 0x00CA1967
		public void RefreshByExchangeData(List<IExchangeData> exchangeList, bool scrollToTop = true, bool useExternalSort = false)
		{
			this.SelectedGridIndex = -1;
			this.DataList = this.BuildExchangeDataList(exchangeList, useExternalSort);
			this.DoRefresh(scrollToTop);
		}

		// Token: 0x0602D333 RID: 185139 RVA: 0x00CA3788 File Offset: 0x00CA1988
		private void DoRefresh(bool scrollToTop)
		{
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.DataList);
			if (scrollToTop)
			{
				multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			}
			multiTemplateScrollViewRefreshContext.PlayGridAnim = true;
			MultiTemplateScrollView scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0602D334 RID: 185140 RVA: 0x00CA37C4 File Offset: 0x00CA19C4
		private List<IMultiTemplateGridData> BuildSingleGroupDataList(List<IBaseItemData> itemList)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			foreach (IBaseItemData itemData in itemList)
			{
				list.Add(new ComposeItemGridTemplateData
				{
					Data = new ComposeItemGridData
					{
						ItemData = itemData,
						OnToggleStateChanged = new Action<MediumItemGridExtendCallback>(this.OnItemToggleStateChanged),
						IsSelectedProvider = new Func<int, bool>(this.IsGridSelected)
					}
				});
			}
			return list;
		}

		// Token: 0x0602D335 RID: 185141 RVA: 0x00CA3858 File Offset: 0x00CA1A58
		private List<IMultiTemplateGridData> BuildExchangeDataList(List<IExchangeData> exchangeList, bool useExternalSort = false)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			Dictionary<int, List<IExchangeData>> dictionary = new Dictionary<int, List<IExchangeData>>();
			foreach (IExchangeData exchangeData in exchangeList)
			{
				if (!exchangeData.IsSingleDirection || exchangeData.ConfigId == exchangeData.ExchangeTarget)
				{
					List<IExchangeData> list2;
					if (!dictionary.TryGetValue(exchangeData.ExchangeTypeId, out list2))
					{
						list2 = new List<IExchangeData>();
						dictionary[exchangeData.ExchangeTypeId] = list2;
					}
					list2.Add(exchangeData);
				}
			}
			IReadOnlyList<ExchangeType> exchangeTypeList = ComposeConfig.Instance.GetExchangeTypeList();
			if (exchangeTypeList == null)
			{
				return list;
			}
			List<ValueTuple<string, List<IBaseItemData>>> list3 = new List<ValueTuple<string, List<IBaseItemData>>>();
			foreach (ExchangeType exchangeType in exchangeTypeList)
			{
				List<IExchangeData> list4;
				if (dictionary.TryGetValue(exchangeType.Id, out list4))
				{
					List<IBaseItemData> list5 = list4.ConvertAll<IBaseItemData>(([Nullable(1)] IExchangeData data) => data);
					List<IBaseItemData> item = useExternalSort ? list5 : this.SortItemList(list5);
					list3.Add(new ValueTuple<string, List<IBaseItemData>>(exchangeType.Desc ?? "", item));
				}
			}
			NoLinq.SortStable<ValueTuple<string, List<IBaseItemData>>>(list3, ([TupleElementNames(new string[]
			{
				"title",
				"items"
			})] ValueTuple<string, List<IBaseItemData>> left, [TupleElementNames(new string[]
			{
				"title",
				"items"
			})] ValueTuple<string, List<IBaseItemData>> right) => left.Item2.Count.CompareTo(right.Item2.Count));
			foreach (ValueTuple<string, List<IBaseItemData>> valueTuple in list3)
			{
				if (valueTuple.Item2.Count > 0)
				{
					list.Add(new ComposeGroupTitleData
					{
						Data = new ComposeGroupTitleData_Data
						{
							TitleTextId = valueTuple.Item1,
							TitleParam = valueTuple.Item2.Count.ToString(),
							IsEmpty = false
						}
					});
					foreach (IBaseItemData itemData in valueTuple.Item2)
					{
						list.Add(new ComposeItemGridTemplateData
						{
							Data = new ComposeItemGridData
							{
								ItemData = itemData,
								OnToggleStateChanged = new Action<MediumItemGridExtendCallback>(this.OnItemToggleStateChanged),
								IsSelectedProvider = new Func<int, bool>(this.IsGridSelected)
							}
						});
					}
				}
			}
			return list;
		}

		// Token: 0x0602D336 RID: 185142 RVA: 0x00CA3AF0 File Offset: 0x00CA1CF0
		private bool IsGridSelected(int gridIndex)
		{
			return gridIndex >= 0 && gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x0602D337 RID: 185143 RVA: 0x00CA3B01 File Offset: 0x00CA1D01
		private List<IBaseItemData> SortItemList(List<IBaseItemData> itemList)
		{
			itemList.Sort(delegate(IBaseItemData a, IBaseItemData b)
			{
				bool flag = this.CanComposeOrOwned(a);
				bool flag2 = this.CanComposeOrOwned(b);
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.Quality != b.Quality)
					{
						return a.Quality - b.Quality;
					}
					int sortId = this.GetSortId(a);
					int sortId2 = this.GetSortId(b);
					if (sortId != sortId2)
					{
						return sortId2 - sortId;
					}
					return 0;
				}
			});
			return itemList;
		}

		// Token: 0x0602D338 RID: 185144 RVA: 0x00CA3B18 File Offset: 0x00CA1D18
		private bool CanComposeOrOwned(IBaseItemData data)
		{
			if (data.IsUnlock <= 0)
			{
				return false;
			}
			EComposeListType mainType = data.MainType;
			if (mainType != EComposeListType.Exchange)
			{
				return mainType == EComposeListType.Collect && ComposeController.Instance.CheckCanCollect(data.ConfigId);
			}
			return ComposeController.Instance.CheckCanExchange(data.ConfigId);
		}

		// Token: 0x0602D339 RID: 185145 RVA: 0x00CA3B64 File Offset: 0x00CA1D64
		private int GetSortId(IBaseItemData data)
		{
			if (data.MainType == EComposeListType.Exchange)
			{
				return data.ConfigId;
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
			if (synthesisFormulaById == null)
			{
				return 0;
			}
			return synthesisFormulaById.GetValueOrDefault().SortId;
		}

		// Token: 0x0602D33A RID: 185146 RVA: 0x00CA3BAC File Offset: 0x00CA1DAC
		private void OnItemToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
		{
			Action<MediumItemGridExtendCallback> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(callbackParameter);
		}

		// Token: 0x0602D33B RID: 185147 RVA: 0x00CA3BC0 File Offset: 0x00CA1DC0
		public void SelectGridProxy(int gridIndex, bool fireEvent = false)
		{
			if (gridIndex < 0 || gridIndex >= this.DataList.Count)
			{
				return;
			}
			if (this.DataList[gridIndex].GetTemplateIndex() != 1)
			{
				return;
			}
			this.DeselectCurrentGridProxy(false);
			this.SelectedGridIndex = gridIndex;
			MultiTemplateScrollView scrollView = this.ScrollView;
			ComposeItemGridProxy composeItemGridProxy = ((scrollView != null) ? scrollView.GetProxyByGridIndex(gridIndex) : null) as ComposeItemGridProxy;
			if (composeItemGridProxy == null)
			{
				return;
			}
			composeItemGridProxy.SetSelected(true);
		}

		// Token: 0x0602D33C RID: 185148 RVA: 0x00CA3C28 File Offset: 0x00CA1E28
		public void DeselectCurrentGridProxy(bool fireEvent = false)
		{
			if (this.SelectedGridIndex < 0)
			{
				return;
			}
			int selectedGridIndex = this.SelectedGridIndex;
			MultiTemplateScrollView scrollView = this.ScrollView;
			ComposeItemGridProxy composeItemGridProxy = ((scrollView != null) ? scrollView.GetProxyByGridIndex(this.SelectedGridIndex) : null) as ComposeItemGridProxy;
			if (composeItemGridProxy != null)
			{
				composeItemGridProxy.SetSelected(false);
			}
			this.SelectedGridIndex = -1;
		}

		// Token: 0x0602D33D RID: 185149 RVA: 0x00CA3C76 File Offset: 0x00CA1E76
		public void RefreshGridProxy(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.DataList.Count)
			{
				return;
			}
			MultiTemplateScrollView scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshProxyByData(gridIndex, this.DataList[gridIndex]);
		}

		// Token: 0x0602D33E RID: 185150 RVA: 0x00CA3CAC File Offset: 0x00CA1EAC
		public void ScrollToGridIndex(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.DataList.Count)
			{
				return;
			}
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.DataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = gridIndex;
			MultiTemplateScrollView scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0602D33F RID: 185151 RVA: 0x00CA3CF0 File Offset: 0x00CA1EF0
		public int GetScrollAnchorGridIndex(int itemGridIndex)
		{
			if (itemGridIndex <= 0 || itemGridIndex >= this.DataList.Count)
			{
				return itemGridIndex;
			}
			if (this.DataList[itemGridIndex - 1].GetTemplateIndex() == 0)
			{
				return itemGridIndex - 1;
			}
			return itemGridIndex;
		}

		// Token: 0x0602D340 RID: 185152 RVA: 0x00CA3D20 File Offset: 0x00CA1F20
		public int GetFirstItemConfigId()
		{
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].GetTemplateIndex() == 1)
				{
					ComposeItemGridData data = ((ComposeItemGridTemplateData)this.DataList[i]).Data;
					int? num;
					if (data == null)
					{
						num = null;
					}
					else
					{
						IBaseItemData itemData = data.ItemData;
						num = ((itemData != null) ? new int?(itemData.ConfigId) : null);
					}
					int? num2 = num;
					return num2.GetValueOrDefault();
				}
			}
			return 0;
		}

		// Token: 0x0602D341 RID: 185153 RVA: 0x00CA3DA4 File Offset: 0x00CA1FA4
		public int GetGridIndexByConfigId(int configId)
		{
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].GetTemplateIndex() == 1)
				{
					ComposeItemGridData data = ((ComposeItemGridTemplateData)this.DataList[i]).Data;
					bool flag;
					if (data == null)
					{
						flag = false;
					}
					else
					{
						IBaseItemData itemData = data.ItemData;
						int? num = (itemData != null) ? new int?(itemData.ConfigId) : null;
						flag = (num.GetValueOrDefault() == configId & num != null);
					}
					if (flag)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0602D342 RID: 185154 RVA: 0x00CA3E30 File Offset: 0x00CA2030
		public int GetGridIndexByItemIndex(int itemIndex)
		{
			int num = 0;
			for (int i = 0; i < this.DataList.Count; i++)
			{
				if (this.DataList[i].GetTemplateIndex() == 1)
				{
					if (num == itemIndex)
					{
						return i;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x0602D343 RID: 185155 RVA: 0x00CA3E74 File Offset: 0x00CA2074
		[NullableContext(2)]
		public IBaseItemData GetSelectedItemData()
		{
			if (this.SelectedGridIndex < 0 || this.SelectedGridIndex >= this.DataList.Count)
			{
				return null;
			}
			if (this.DataList[this.SelectedGridIndex].GetTemplateIndex() != 1)
			{
				return null;
			}
			ComposeItemGridData data = ((ComposeItemGridTemplateData)this.DataList[this.SelectedGridIndex]).Data;
			if (data == null)
			{
				return null;
			}
			return data.ItemData;
		}

		// Token: 0x0602D344 RID: 185156 RVA: 0x00CA3EE0 File Offset: 0x00CA20E0
		[NullableContext(2)]
		public ComposeItemGridProxy GetGridProxy(int gridIndex)
		{
			MultiTemplateScrollView scrollView = this.ScrollView;
			return ((scrollView != null) ? scrollView.GetProxyByGridIndex(gridIndex) : null) as ComposeItemGridProxy;
		}

		// Token: 0x0602D345 RID: 185157 RVA: 0x00CA3EFA File Offset: 0x00CA20FA
		public bool IsGridDisplaying(int gridIndex)
		{
			MultiTemplateScrollView scrollView = this.ScrollView;
			return scrollView != null && scrollView.IsGridDisplaying(gridIndex);
		}

		// Token: 0x0602D346 RID: 185158 RVA: 0x00CA3F0E File Offset: 0x00CA210E
		public int GetSelectedGridIndex()
		{
			return this.SelectedGridIndex;
		}

		// Token: 0x0602D347 RID: 185159 RVA: 0x00CA3F16 File Offset: 0x00CA2116
		public int GetDataCount()
		{
			return this.DataList.Count;
		}

		// Token: 0x0602D348 RID: 185160 RVA: 0x00CA3F24 File Offset: 0x00CA2124
		public List<IBaseItemData> GetAllItemDataList()
		{
			List<IBaseItemData> list = new List<IBaseItemData>();
			foreach (IMultiTemplateGridData multiTemplateGridData in this.DataList)
			{
				if (multiTemplateGridData.GetTemplateIndex() == 1)
				{
					ComposeItemGridTemplateData composeItemGridTemplateData = (ComposeItemGridTemplateData)multiTemplateGridData;
					ComposeItemGridData data = composeItemGridTemplateData.Data;
					if (((data != null) ? data.ItemData : null) != null)
					{
						list.Add(composeItemGridTemplateData.Data.ItemData);
					}
				}
			}
			return list;
		}

		// Token: 0x040183E6 RID: 99302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MediumItemGridExtendCallback> OnItemClick;

		// Token: 0x040183E7 RID: 99303
		[Nullable(2)]
		private MultiTemplateScrollView ScrollView;

		// Token: 0x040183E8 RID: 99304
		private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

		// Token: 0x040183E9 RID: 99305
		private int SelectedGridIndex = -1;
	}
}
