using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006599 RID: 26009
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardViewModelBase : IDockyardBackpackInterface
	{
		// Token: 0x17009566 RID: 38246
		// (get) Token: 0x06041353 RID: 267091 RVA: 0x00FCDA45 File Offset: 0x00FCBC45
		protected CabinType RequestCabinType
		{
			get
			{
				if (!this.IsInTrawlState)
				{
					return CabinType.ShipCabin;
				}
				return CabinType.NetCabin;
			}
		}

		// Token: 0x06041354 RID: 267092 RVA: 0x00FCDA52 File Offset: 0x00FCBC52
		public void RegisterView(IDockyardViewInterface view)
		{
			this.View = view;
			this.BackpackPanelModel.RegisterViewModel(this);
			this.ListPanelModel.RegisterBackpackPanelModel(this.BackpackPanelModel);
		}

		// Token: 0x06041355 RID: 267093 RVA: 0x00FCDA78 File Offset: 0x00FCBC78
		public void CloseClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			IDockyardViewInterface view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMe(null);
		}

		// Token: 0x06041356 RID: 267094 RVA: 0x00FCDAAD File Offset: 0x00FCBCAD
		public bool CheckCurrencyItemClick(int itemId)
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06041357 RID: 267095 RVA: 0x00FCDAD3 File Offset: 0x00FCBCD3
		public virtual void AllSellClick()
		{
		}

		// Token: 0x06041358 RID: 267096 RVA: 0x00FCDAD5 File Offset: 0x00FCBCD5
		public bool IsTrawlInteractive()
		{
			return this.IsInTrawlState;
		}

		// Token: 0x06041359 RID: 267097 RVA: 0x00FCDADD File Offset: 0x00FCBCDD
		public bool IsConfirmInteractive()
		{
			return true;
		}

		// Token: 0x0604135A RID: 267098 RVA: 0x00FCDAE0 File Offset: 0x00FCBCE0
		public bool IsConfirmNiagaraActive()
		{
			return true;
		}

		// Token: 0x0604135B RID: 267099 RVA: 0x00FCDAE3 File Offset: 0x00FCBCE3
		public void SetInSelectState(bool inSelectState)
		{
			if (!inSelectState)
			{
				IDockyardViewInterface view = this.View;
				if (view != null)
				{
					view.HideTipsPanel();
				}
				DockyardItemListPanel panel = this.ListPanelModel.Panel;
				if (panel == null)
				{
					return;
				}
				panel.SetDragTipsActive(false);
			}
		}

		// Token: 0x0604135C RID: 267100 RVA: 0x00FCDB0F File Offset: 0x00FCBD0F
		public void TrawlClick(bool isSelected)
		{
			this.IsInTrawlState = isSelected;
			IDockyardViewInterface view = this.View;
			if (view == null)
			{
				return;
			}
			view.SetTrawlState(isSelected);
		}

		// Token: 0x0604135D RID: 267101 RVA: 0x00FCDB29 File Offset: 0x00FCBD29
		public virtual void ItemBlockClick(int id)
		{
			IDockyardViewInterface view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x0604135E RID: 267102 RVA: 0x00FCDB3C File Offset: 0x00FCBD3C
		public void DeleteClick()
		{
			List<FishingItemInfo> leftPanelItemBlockDataListExcludeSelected = this.GetLeftPanelItemBlockDataListExcludeSelected();
			List<FishingItemInfo> itemBlockDataListExcludeSelected = this.BackpackPanelModel.Panel.GetItemBlockDataListExcludeSelected();
			RequestCabinPut requestData = new RequestCabinPut
			{
				Type = this.RequestCabinType,
				LeftDataList = leftPanelItemBlockDataListExcludeSelected,
				RightDataList = itemBlockDataListExcludeSelected,
				RemoveIncId = new int?(this.BackpackPanelModel.InSelectedBlockId),
				Callback = delegate(bool isSuccess)
				{
					if (isSuccess)
					{
						this.ListPanelModel.DeleteSelectedItemBlockAndRefresh();
						this.BackpackPanelModel.Panel.DestroySelectItemBlock();
					}
				}
			};
			FishingController.Instance.RequestFishingCabinPut(requestData);
		}

		// Token: 0x0604135F RID: 267103 RVA: 0x00FCDBB4 File Offset: 0x00FCBDB4
		public void RotateClick()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.BackpackPanelModel.Panel.RotateClick();
			}
		}

		// Token: 0x06041360 RID: 267104 RVA: 0x00FCDBD4 File Offset: 0x00FCBDD4
		public void ConfirmClick()
		{
			if (!this.BackpackPanelModel.CanConfirm())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_CantPutDown", Array.Empty<object>());
				return;
			}
			if (this.BackpackPanelModel.IsOverlap())
			{
				this.BackpackPanelModel.Panel.HandleOverlapConfirm();
				return;
			}
			this.TrySetSelectedItemBlockToBackpack().Forget<bool>();
		}

		// Token: 0x06041361 RID: 267105 RVA: 0x00FCDC2C File Offset: 0x00FCBE2C
		public void HandleDragResult()
		{
			if (this.BackpackPanelModel.IsDragFail)
			{
				if (this.IsInTrawlState)
				{
					if (this.BackpackPanelModel.Panel.IsWareHouseDragToBackpack())
					{
						this.BackpackPanelModel.Panel.SetItemBlockToWareHouse();
						return;
					}
					if (this.ListPanelModel.CanDragToListPanel(false))
					{
						this.TryAddToWareHouse().Forget<bool>();
						return;
					}
					this.ListPanelModel.RefreshDragTips(false, true);
				}
				this.BackpackPanelModel.Panel.HandleDragFail();
				return;
			}
			DockyardBackpackPanelModelBase backpackPanelModel = this.BackpackPanelModel;
			if (backpackPanelModel == null)
			{
				return;
			}
			backpackPanelModel.Panel.HandleDragSuccess();
		}

		// Token: 0x06041362 RID: 267106 RVA: 0x00FCDCBE File Offset: 0x00FCBEBE
		public void BackpackTick(float deltaTime)
		{
			this.BackpackPanelModel.Tick();
			this.ListPanelModel.RefreshDragTips(this.BackpackPanelModel.IsInDragState, !this.BackpackPanelModel.IsDragFail);
		}

		// Token: 0x06041363 RID: 267107 RVA: 0x00FCDCEF File Offset: 0x00FCBEEF
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			this.ListPanelModel.SetItemBlockToWareHouse(data);
		}

		// Token: 0x06041364 RID: 267108 RVA: 0x00FCDCFD File Offset: 0x00FCBEFD
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return this.View.GetQuicklySellPanelParentItem();
		}

		// Token: 0x06041365 RID: 267109 RVA: 0x00FCDD0A File Offset: 0x00FCBF0A
		public void NotifyQuicklySellActive(bool isActive)
		{
			this.View.NotifyQuicklySellActive(isActive);
		}

		// Token: 0x06041366 RID: 267110 RVA: 0x00FCDD18 File Offset: 0x00FCBF18
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToWareHouse()
		{
			DockyardViewModelBase.<TrySetSelectedItemBlockToWareHouse>d__22 <TrySetSelectedItemBlockToWareHouse>d__;
			<TrySetSelectedItemBlockToWareHouse>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetSelectedItemBlockToWareHouse>d__.<>4__this = this;
			<TrySetSelectedItemBlockToWareHouse>d__.<>1__state = -1;
			<TrySetSelectedItemBlockToWareHouse>d__.<>t__builder.Start<DockyardViewModelBase.<TrySetSelectedItemBlockToWareHouse>d__22>(ref <TrySetSelectedItemBlockToWareHouse>d__);
			return <TrySetSelectedItemBlockToWareHouse>d__.<>t__builder.Task;
		}

		// Token: 0x06041367 RID: 267111 RVA: 0x00FCDD5B File Offset: 0x00FCBF5B
		public void HandleDragBegin()
		{
		}

		// Token: 0x06041368 RID: 267112 RVA: 0x00FCDD60 File Offset: 0x00FCBF60
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToBackpack()
		{
			DockyardViewModelBase.<TrySetSelectedItemBlockToBackpack>d__24 <TrySetSelectedItemBlockToBackpack>d__;
			<TrySetSelectedItemBlockToBackpack>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetSelectedItemBlockToBackpack>d__.<>4__this = this;
			<TrySetSelectedItemBlockToBackpack>d__.<>1__state = -1;
			<TrySetSelectedItemBlockToBackpack>d__.<>t__builder.Start<DockyardViewModelBase.<TrySetSelectedItemBlockToBackpack>d__24>(ref <TrySetSelectedItemBlockToBackpack>d__);
			return <TrySetSelectedItemBlockToBackpack>d__.<>t__builder.Task;
		}

		// Token: 0x06041369 RID: 267113 RVA: 0x00FCDDA4 File Offset: 0x00FCBFA4
		protected List<FishingItemInfo> GetLeftPanelItemBlockDataList()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			if (this.IsInTrawlState)
			{
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ListPanelModel.ShowItemList)
				{
					if (dockyardItemBlockOriginalData.IncId != this.ListPanelModel.InSelectedBlockId)
					{
						list.Add(dockyardItemBlockOriginalData.GetServerData());
					}
				}
			}
			return list;
		}

		// Token: 0x0604136A RID: 267114 RVA: 0x00FCDE24 File Offset: 0x00FCC024
		private List<FishingItemInfo> GetLeftPanelItemBlockDataListExcludeSelected()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			if (this.IsInTrawlState)
			{
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ListPanelModel.ShowItemList)
				{
					if (dockyardItemBlockOriginalData.IncId != this.ListPanelModel.InSelectedBlockId && dockyardItemBlockOriginalData.IncId != this.BackpackPanelModel.InSelectedBlockId)
					{
						list.Add(dockyardItemBlockOriginalData.GetServerData());
					}
				}
			}
			return list;
		}

		// Token: 0x0604136B RID: 267115 RVA: 0x00FCDEB8 File Offset: 0x00FCC0B8
		[NullableContext(0)]
		private UniTask<bool> TryAddToWareHouse()
		{
			DockyardViewModelBase.<TryAddToWareHouse>d__27 <TryAddToWareHouse>d__;
			<TryAddToWareHouse>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryAddToWareHouse>d__.<>4__this = this;
			<TryAddToWareHouse>d__.<>1__state = -1;
			<TryAddToWareHouse>d__.<>t__builder.Start<DockyardViewModelBase.<TryAddToWareHouse>d__27>(ref <TryAddToWareHouse>d__);
			return <TryAddToWareHouse>d__.<>t__builder.Task;
		}

		// Token: 0x0604136C RID: 267116 RVA: 0x00FCDEFC File Offset: 0x00FCC0FC
		public DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = DockyardModel.Instance.GetItemBlockData(id);
			if (itemBlockData != null)
			{
				return itemBlockData;
			}
			return DockyardModel.Instance.GetDataByTrawl(id);
		}

		// Token: 0x17009567 RID: 38247
		// (get) Token: 0x0604136D RID: 267117
		public abstract DockyardBackpackPanelModelBase BackpackPanelModel { get; }

		// Token: 0x17009568 RID: 38248
		// (get) Token: 0x0604136E RID: 267118
		public abstract DockyardItemListPanelModel ListPanelModel { get; }

		// Token: 0x04021F45 RID: 139077
		private IDockyardViewInterface View;

		// Token: 0x04021F46 RID: 139078
		public bool IsInTrawlState;
	}
}
