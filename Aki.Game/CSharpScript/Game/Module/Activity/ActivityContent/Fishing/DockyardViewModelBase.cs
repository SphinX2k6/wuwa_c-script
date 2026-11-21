using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005517 RID: 21783
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardViewModelBase : IDockyardBackpackInterface
	{
		// Token: 0x170068C8 RID: 26824
		// (get) Token: 0x06036018 RID: 221208 RVA: 0x00F14A59 File Offset: 0x00F12C59
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

		// Token: 0x06036019 RID: 221209 RVA: 0x00F14A66 File Offset: 0x00F12C66
		public void RegisterView(IDockyardViewInterface view)
		{
			this.View = view;
			this.BackpackPanelModel.RegisterViewModel(this);
			this.ListPanelModel.RegisterBackpackPanelModel(this.BackpackPanelModel);
		}

		// Token: 0x0603601A RID: 221210 RVA: 0x00F14A8C File Offset: 0x00F12C8C
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

		// Token: 0x0603601B RID: 221211 RVA: 0x00F14AC1 File Offset: 0x00F12CC1
		public bool CheckCurrencyItemClick(int itemId)
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0603601C RID: 221212 RVA: 0x00F14AE7 File Offset: 0x00F12CE7
		public virtual void AllSellClick()
		{
		}

		// Token: 0x0603601D RID: 221213 RVA: 0x00F14AE9 File Offset: 0x00F12CE9
		public bool IsTrawlInteractive()
		{
			return this.IsInTrawlState;
		}

		// Token: 0x0603601E RID: 221214 RVA: 0x00F14AF1 File Offset: 0x00F12CF1
		public bool IsConfirmInteractive()
		{
			return true;
		}

		// Token: 0x0603601F RID: 221215 RVA: 0x00F14AF4 File Offset: 0x00F12CF4
		public bool IsConfirmNiagaraActive()
		{
			return true;
		}

		// Token: 0x06036020 RID: 221216 RVA: 0x00F14AF7 File Offset: 0x00F12CF7
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

		// Token: 0x06036021 RID: 221217 RVA: 0x00F14B23 File Offset: 0x00F12D23
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

		// Token: 0x06036022 RID: 221218 RVA: 0x00F14B3D File Offset: 0x00F12D3D
		public virtual void ItemBlockClick(int id)
		{
			IDockyardViewInterface view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x06036023 RID: 221219 RVA: 0x00F14B50 File Offset: 0x00F12D50
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

		// Token: 0x06036024 RID: 221220 RVA: 0x00F14BC8 File Offset: 0x00F12DC8
		public void RotateClick()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.BackpackPanelModel.Panel.RotateClick();
			}
		}

		// Token: 0x06036025 RID: 221221 RVA: 0x00F14BE8 File Offset: 0x00F12DE8
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

		// Token: 0x06036026 RID: 221222 RVA: 0x00F14C40 File Offset: 0x00F12E40
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

		// Token: 0x06036027 RID: 221223 RVA: 0x00F14CD2 File Offset: 0x00F12ED2
		public void BackpackTick(float deltaTime)
		{
			this.BackpackPanelModel.Tick();
			this.ListPanelModel.RefreshDragTips(this.BackpackPanelModel.IsInDragState, !this.BackpackPanelModel.IsDragFail);
		}

		// Token: 0x06036028 RID: 221224 RVA: 0x00F14D03 File Offset: 0x00F12F03
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			this.ListPanelModel.SetItemBlockToWareHouse(data);
		}

		// Token: 0x06036029 RID: 221225 RVA: 0x00F14D11 File Offset: 0x00F12F11
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return this.View.GetQuicklySellPanelParentItem();
		}

		// Token: 0x0603602A RID: 221226 RVA: 0x00F14D1E File Offset: 0x00F12F1E
		public void NotifyQuicklySellActive(bool isActive)
		{
			this.View.NotifyQuicklySellActive(isActive);
		}

		// Token: 0x0603602B RID: 221227 RVA: 0x00F14D2C File Offset: 0x00F12F2C
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

		// Token: 0x0603602C RID: 221228 RVA: 0x00F14D6F File Offset: 0x00F12F6F
		public void HandleDragBegin()
		{
		}

		// Token: 0x0603602D RID: 221229 RVA: 0x00F14D74 File Offset: 0x00F12F74
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

		// Token: 0x0603602E RID: 221230 RVA: 0x00F14DB8 File Offset: 0x00F12FB8
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

		// Token: 0x0603602F RID: 221231 RVA: 0x00F14E38 File Offset: 0x00F13038
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

		// Token: 0x06036030 RID: 221232 RVA: 0x00F14ECC File Offset: 0x00F130CC
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

		// Token: 0x06036031 RID: 221233 RVA: 0x00F14F10 File Offset: 0x00F13110
		public DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = DockyardModel.Instance.GetItemBlockData(id);
			if (itemBlockData != null)
			{
				return itemBlockData;
			}
			return DockyardModel.Instance.GetDataByTrawl(id);
		}

		// Token: 0x170068C9 RID: 26825
		// (get) Token: 0x06036032 RID: 221234
		public abstract DockyardBackpackPanelModelBase BackpackPanelModel { get; }

		// Token: 0x170068CA RID: 26826
		// (get) Token: 0x06036033 RID: 221235
		public abstract DockyardItemListPanelModel ListPanelModel { get; }

		// Token: 0x0401C876 RID: 116854
		private IDockyardViewInterface View;

		// Token: 0x0401C877 RID: 116855
		public bool IsInTrawlState;
	}
}
