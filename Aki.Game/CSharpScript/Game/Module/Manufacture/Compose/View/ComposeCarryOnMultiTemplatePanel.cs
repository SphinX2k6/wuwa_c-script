using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005665 RID: 22117
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeCarryOnMultiTemplatePanel
	{
		// Token: 0x06038432 RID: 230450 RVA: 0x00D557A4 File Offset: 0x00D539A4
		public ComposeCarryOnMultiTemplatePanel(UUIMultiTemplateScrollViewComponent scrollViewComponent)
		{
			this.ScrollView = new MultiTemplateScrollView(scrollViewComponent);
		}

		// Token: 0x06038433 RID: 230451 RVA: 0x00D557CA File Offset: 0x00D539CA
		public void RefreshByData(List<IBaseItemData> itemList, bool scrollToTop = true)
		{
			this.SelectedGridIndex = -1;
			this.DataList = this.BuildSingleGroupDataList(itemList);
			this.DoRefresh(scrollToTop);
		}

		// Token: 0x06038434 RID: 230452 RVA: 0x00D557E7 File Offset: 0x00D539E7
		public void RefreshByExchangeData(List<IExchangeData> exchangeList, bool scrollToTop = true, bool useExternalSort = false)
		{
			this.SelectedGridIndex = -1;
			this.DataList = this.BuildExchangeDataList(exchangeList, useExternalSort);
			this.DoRefresh(scrollToTop);
		}

		// Token: 0x06038435 RID: 230453 RVA: 0x00D55808 File Offset: 0x00D53A08
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

		// Token: 0x06038436 RID: 230454 RVA: 0x00D55844 File Offset: 0x00D53A44
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

		// Token: 0x06038437 RID: 230455 RVA: 0x00D558D8 File Offset: 0x00D53AD8
		private List<IMultiTemplateGridData> BuildExchangeDataList(List<IExchangeData> exchangeList, bool useExternalSort = false)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			Dictionary<int, List<IExchangeData>> dictionary = (from data in (from data in exchangeList
			where !data.IsSingleDirection || data.ConfigId == data.ExchangeTarget
			select data).ToList<IExchangeData>()
			group data by data.ExchangeTypeId).ToDictionary((IGrouping<int, IExchangeData> group) => group.Key, (IGrouping<int, IExchangeData> group) => group.ToList<IExchangeData>());
			IReadOnlyList<ExchangeType> exchangeTypeList = ComposeConfig.Instance.GetExchangeTypeList();
			if (exchangeTypeList == null)
			{
				return list;
			}
			List<ValueTuple<string, List<IBaseItemData>>> list2 = new List<ValueTuple<string, List<IBaseItemData>>>();
			foreach (ExchangeType exchangeType in exchangeTypeList)
			{
				List<IExchangeData> source;
				if (dictionary.TryGetValue(exchangeType.Id, out source))
				{
					List<IBaseItemData> list3 = source.Cast<IBaseItemData>().ToList<IBaseItemData>();
					List<IBaseItemData> item = useExternalSort ? list3 : this.SortItemList(list3);
					list2.Add(new ValueTuple<string, List<IBaseItemData>>(exchangeType.Desc ?? "", item));
				}
			}
			foreach (ValueTuple<string, List<IBaseItemData>> valueTuple in (from @group in list2
			orderby @group.Item2.Count
			select @group).ToList<ValueTuple<string, List<IBaseItemData>>>())
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

		// Token: 0x06038438 RID: 230456 RVA: 0x00D55B64 File Offset: 0x00D53D64
		private bool IsGridSelected(int gridIndex)
		{
			return gridIndex >= 0 && gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x06038439 RID: 230457 RVA: 0x00D55B75 File Offset: 0x00D53D75
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

		// Token: 0x0603843A RID: 230458 RVA: 0x00D55B8C File Offset: 0x00D53D8C
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

		// Token: 0x0603843B RID: 230459 RVA: 0x00D55BD8 File Offset: 0x00D53DD8
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

		// Token: 0x0603843C RID: 230460 RVA: 0x00D55C20 File Offset: 0x00D53E20
		private void OnItemToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
		{
			Action<MediumItemGridExtendCallback> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(callbackParameter);
		}

		// Token: 0x0603843D RID: 230461 RVA: 0x00D55C34 File Offset: 0x00D53E34
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

		// Token: 0x0603843E RID: 230462 RVA: 0x00D55C9C File Offset: 0x00D53E9C
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

		// Token: 0x0603843F RID: 230463 RVA: 0x00D55CEA File Offset: 0x00D53EEA
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

		// Token: 0x06038440 RID: 230464 RVA: 0x00D55D20 File Offset: 0x00D53F20
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

		// Token: 0x06038441 RID: 230465 RVA: 0x00D55D64 File Offset: 0x00D53F64
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

		// Token: 0x06038442 RID: 230466 RVA: 0x00D55D94 File Offset: 0x00D53F94
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

		// Token: 0x06038443 RID: 230467 RVA: 0x00D55E18 File Offset: 0x00D54018
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

		// Token: 0x06038444 RID: 230468 RVA: 0x00D55EA4 File Offset: 0x00D540A4
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

		// Token: 0x06038445 RID: 230469 RVA: 0x00D55EE8 File Offset: 0x00D540E8
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

		// Token: 0x06038446 RID: 230470 RVA: 0x00D55F54 File Offset: 0x00D54154
		[NullableContext(2)]
		public ComposeItemGridProxy GetGridProxy(int gridIndex)
		{
			MultiTemplateScrollView scrollView = this.ScrollView;
			return ((scrollView != null) ? scrollView.GetProxyByGridIndex(gridIndex) : null) as ComposeItemGridProxy;
		}

		// Token: 0x06038447 RID: 230471 RVA: 0x00D55F6E File Offset: 0x00D5416E
		public bool IsGridDisplaying(int gridIndex)
		{
			MultiTemplateScrollView scrollView = this.ScrollView;
			return scrollView != null && scrollView.IsGridDisplaying(gridIndex);
		}

		// Token: 0x06038448 RID: 230472 RVA: 0x00D55F82 File Offset: 0x00D54182
		public int GetSelectedGridIndex()
		{
			return this.SelectedGridIndex;
		}

		// Token: 0x06038449 RID: 230473 RVA: 0x00D55F8A File Offset: 0x00D5418A
		public int GetDataCount()
		{
			return this.DataList.Count;
		}

		// Token: 0x0603844A RID: 230474 RVA: 0x00D55F98 File Offset: 0x00D54198
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

		// Token: 0x0401D95B RID: 121179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MediumItemGridExtendCallback> OnItemClick;

		// Token: 0x0401D95C RID: 121180
		[Nullable(2)]
		private MultiTemplateScrollView ScrollView;

		// Token: 0x0401D95D RID: 121181
		private List<IMultiTemplateGridData> DataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401D95E RID: 121182
		private int SelectedGridIndex = -1;
	}
}
