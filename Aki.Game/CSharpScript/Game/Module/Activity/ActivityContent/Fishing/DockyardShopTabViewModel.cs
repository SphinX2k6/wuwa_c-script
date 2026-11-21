using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005540 RID: 21824
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopTabViewModel : DockyardViewModelBase
	{
		// Token: 0x170068F2 RID: 26866
		// (get) Token: 0x06036247 RID: 221767 RVA: 0x00F1C9E4 File Offset: 0x00F1ABE4
		public virtual DockyardShopBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardShopBackpackPanelModel();

		// Token: 0x170068F3 RID: 26867
		// (get) Token: 0x06036248 RID: 221768 RVA: 0x00F1C9EC File Offset: 0x00F1ABEC
		public virtual DockyardShopListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardShopListPanelModel();

		// Token: 0x06036249 RID: 221769 RVA: 0x00F1C9F4 File Offset: 0x00F1ABF4
		public void RegisterMainView(DockyardShopMainView mainView)
		{
			this.MainView = mainView;
		}

		// Token: 0x0603624A RID: 221770 RVA: 0x00F1C9FD File Offset: 0x00F1ABFD
		public override void ItemBlockClick(int id)
		{
			base.ItemBlockClick(id);
			this.MainView.HidePlotPanel();
		}

		// Token: 0x0603624B RID: 221771 RVA: 0x00F1CA14 File Offset: 0x00F1AC14
		public unsafe void SellClick(int incId, int itemId)
		{
			if (this.BackpackPanelModel.IsInDragState || !this.BackpackPanelModel.IsInSelectState || this.BackpackPanelModel.InSelectedBlockId == -1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("GenericPrompt_NotAllowOpenPhotograph_TipsText", Array.Empty<object>());
				return;
			}
			bool isInSelectState = this.BackpackPanelModel.IsInSelectState;
			FishingController instance = FishingController.Instance;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int num2 = 0;
			*span[num2] = incId;
			num2 = 1;
			List<int> list2 = new List<int>(num2);
			CollectionsMarshal.SetCount<int>(list2, num2);
			span = CollectionsMarshal.AsSpan<int>(list2);
			num = 0;
			*span[num] = itemId;
			instance.TryRequestFishingSell(list, list2, isInSelectState, delegate(bool isSuccess)
			{
				if (isSuccess)
				{
					this.ListPanelModel.DeleteSelectedItemBlockAndRefresh();
					this.BackpackPanelModel.Panel.DestroySelectItemBlock();
					this.MainView.ShowPlotPanel("SellItem");
				}
			});
		}

		// Token: 0x0603624C RID: 221772 RVA: 0x00F1CAC8 File Offset: 0x00F1ACC8
		public override void AllSellClick()
		{
			List<FishingItemInfo> leftPanelItemBlockDataList = base.GetLeftPanelItemBlockDataList();
			List<int> leftIncIdList = this.GetAllSellIncIdList(leftPanelItemBlockDataList);
			List<int> allSellItemIdList = this.GetAllSellItemIdList(leftPanelItemBlockDataList);
			List<FishingItemInfo> itemBlockDataList = this.BackpackPanelModel.Panel.GetItemBlockDataList();
			List<int> rightIncIdList = this.GetAllSellIncIdList(itemBlockDataList);
			List<int> allSellItemIdList2 = this.GetAllSellItemIdList(itemBlockDataList);
			if (leftIncIdList.Count + rightIncIdList.Count == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SellAllFailed", Array.Empty<object>());
				return;
			}
			bool isInSelectState = this.BackpackPanelModel.IsInSelectState;
			List<int> list = new List<int>(leftIncIdList);
			list.AddRange(rightIncIdList);
			List<int> list2 = new List<int>(allSellItemIdList);
			list2.AddRange(allSellItemIdList2);
			FishingController.Instance.TryRequestFishingSell(list, list2, isInSelectState, delegate(bool isSuccess)
			{
				if (isSuccess)
				{
					if (leftIncIdList.Count > 0)
					{
						this.ListPanelModel.DeleteItemBlockListFromWareHouse(leftIncIdList);
					}
					foreach (int id in rightIncIdList)
					{
						this.BackpackPanelModel.Panel.DestroyItemBlockById(id);
					}
					this.MainView.ShowPlotPanel("SellAllItem");
				}
			});
		}

		// Token: 0x0603624D RID: 221773 RVA: 0x00F1CBA7 File Offset: 0x00F1ADA7
		public void NotifyMainViewClose()
		{
			this.MainView.CloseMe(null);
		}

		// Token: 0x0603624E RID: 221774 RVA: 0x00F1CBB8 File Offset: 0x00F1ADB8
		private List<int> GetAllSellIncIdList(List<FishingItemInfo> dataList)
		{
			List<int> list = new List<int>();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				if (fishingItemInfo.Price > 0)
				{
					list.Add(fishingItemInfo.IncrId);
				}
			}
			return list;
		}

		// Token: 0x0603624F RID: 221775 RVA: 0x00F1CC1C File Offset: 0x00F1AE1C
		private List<int> GetAllSellItemIdList(List<FishingItemInfo> dataList)
		{
			List<int> list = new List<int>();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				if (fishingItemInfo.Price > 0)
				{
					list.Add(fishingItemInfo.ItemId);
				}
			}
			return list;
		}

		// Token: 0x06036250 RID: 221776 RVA: 0x00F1CC80 File Offset: 0x00F1AE80
		public void NotifyMainViewUiBlur(bool enable)
		{
			this.MainView.NotifyUiBlur(enable);
		}

		// Token: 0x170068F4 RID: 26868
		// (get) Token: 0x06036251 RID: 221777 RVA: 0x00F1CC90 File Offset: 0x00F1AE90
		public bool HasFishingCanSell
		{
			get
			{
				List<DockyardItemBlockOriginalData> showItemList = this.ListPanelModel.GetShowItemList();
				List<DockyardItemBlockOriginalData> backpackItemList = DockyardModel.Instance.GetBackpackItemList();
				List<int> list = new List<int>();
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in showItemList)
				{
					if (dockyardItemBlockOriginalData.Price > 0)
					{
						list.Add(dockyardItemBlockOriginalData.IncId);
					}
				}
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData2 in backpackItemList)
				{
					if (dockyardItemBlockOriginalData2.Price > 0)
					{
						list.Add(dockyardItemBlockOriginalData2.IncId);
					}
				}
				return list.Count > 0;
			}
		}

		// Token: 0x0401C93F RID: 117055
		private DockyardShopMainView MainView;
	}
}
