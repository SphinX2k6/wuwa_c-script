using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C2 RID: 26050
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopTabViewModel : DockyardViewModelBase
	{
		// Token: 0x17009590 RID: 38288
		// (get) Token: 0x06041582 RID: 267650 RVA: 0x00FD59A8 File Offset: 0x00FD3BA8
		public virtual DockyardShopBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardShopBackpackPanelModel();

		// Token: 0x17009591 RID: 38289
		// (get) Token: 0x06041583 RID: 267651 RVA: 0x00FD59B0 File Offset: 0x00FD3BB0
		public virtual DockyardShopListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardShopListPanelModel();

		// Token: 0x06041584 RID: 267652 RVA: 0x00FD59B8 File Offset: 0x00FD3BB8
		public void RegisterMainView(DockyardShopMainView mainView)
		{
			this.MainView = mainView;
		}

		// Token: 0x06041585 RID: 267653 RVA: 0x00FD59C1 File Offset: 0x00FD3BC1
		public override void ItemBlockClick(int id)
		{
			base.ItemBlockClick(id);
			this.MainView.HidePlotPanel();
		}

		// Token: 0x06041586 RID: 267654 RVA: 0x00FD59D8 File Offset: 0x00FD3BD8
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

		// Token: 0x06041587 RID: 267655 RVA: 0x00FD5A8C File Offset: 0x00FD3C8C
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
			List<int> incIdList = leftIncIdList.Concat(rightIncIdList).ToList<int>();
			List<int> itemIdList = allSellItemIdList.Concat(allSellItemIdList2).ToList<int>();
			FishingController.Instance.TryRequestFishingSell(incIdList, itemIdList, isInSelectState, delegate(bool isSuccess)
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

		// Token: 0x06041588 RID: 267656 RVA: 0x00FD5B67 File Offset: 0x00FD3D67
		public void NotifyMainViewClose()
		{
			this.MainView.CloseMe(null);
		}

		// Token: 0x06041589 RID: 267657 RVA: 0x00FD5B78 File Offset: 0x00FD3D78
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

		// Token: 0x0604158A RID: 267658 RVA: 0x00FD5BDC File Offset: 0x00FD3DDC
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

		// Token: 0x0604158B RID: 267659 RVA: 0x00FD5C40 File Offset: 0x00FD3E40
		public void NotifyMainViewUiBlur(bool enable)
		{
			this.MainView.NotifyUiBlur(enable);
		}

		// Token: 0x17009592 RID: 38290
		// (get) Token: 0x0604158C RID: 267660 RVA: 0x00FD5C50 File Offset: 0x00FD3E50
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

		// Token: 0x0402200E RID: 139278
		private DockyardShopMainView MainView;
	}
}
