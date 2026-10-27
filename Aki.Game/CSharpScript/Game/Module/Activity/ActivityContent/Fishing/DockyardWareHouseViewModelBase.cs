using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200659A RID: 26010
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardWareHouseViewModelBase : IDockyardBackpackInterface
	{
		// Token: 0x06041371 RID: 267121 RVA: 0x00FCDF4D File Offset: 0x00FCC14D
		public void RegisterView(DockyardWareHouseView view)
		{
			this.View = view;
			this.BackpackPanelModel.RegisterViewModel(this);
			this.ListPanelModel.RegisterBackpackPanelModel(this.BackpackPanelModel);
			this.OnInit();
		}

		// Token: 0x06041372 RID: 267122 RVA: 0x00FCDF79 File Offset: 0x00FCC179
		public void CloseClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			this.OnCloseClick();
		}

		// Token: 0x06041373 RID: 267123 RVA: 0x00FCDFA3 File Offset: 0x00FCC1A3
		public bool CheckCurrencyItemClick(int itemId)
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06041374 RID: 267124 RVA: 0x00FCDFC9 File Offset: 0x00FCC1C9
		public void ItemBlockClick(int id)
		{
			DockyardWareHouseView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x06041375 RID: 267125 RVA: 0x00FCDFDC File Offset: 0x00FCC1DC
		public void SetInSelectState(bool inSelectState)
		{
			if (!inSelectState)
			{
				DockyardWareHouseView view = this.View;
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

		// Token: 0x06041376 RID: 267126 RVA: 0x00FCE008 File Offset: 0x00FCC208
		public void HandleDragResult()
		{
			if (!this.BackpackPanelModel.IsDragFail)
			{
				this.BackpackPanelModel.Panel.HandleDragSuccess();
				return;
			}
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
			this.BackpackPanelModel.Panel.HandleDragFail();
			this.ListPanelModel.RefreshDragTips(false, true);
		}

		// Token: 0x06041377 RID: 267127 RVA: 0x00FCE090 File Offset: 0x00FCC290
		public void DeleteClick()
		{
			List<FishingItemInfo> leftPanelItemBlockDataListExcludeSelected = this.GetLeftPanelItemBlockDataListExcludeSelected();
			List<FishingItemInfo> itemBlockDataListExcludeSelected = this.BackpackPanelModel.Panel.GetItemBlockDataListExcludeSelected();
			RequestCabinPut requestData = new RequestCabinPut
			{
				Type = this.RequestCabinType,
				RequestId = new int?(this.RequestId),
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

		// Token: 0x06041378 RID: 267128 RVA: 0x00FCE119 File Offset: 0x00FCC319
		public void RotateClick()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.BackpackPanelModel.Panel.RotateClick();
			}
		}

		// Token: 0x06041379 RID: 267129 RVA: 0x00FCE138 File Offset: 0x00FCC338
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

		// Token: 0x0604137A RID: 267130 RVA: 0x00FCE190 File Offset: 0x00FCC390
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			this.ListPanelModel.SetItemBlockToWareHouse(data);
		}

		// Token: 0x0604137B RID: 267131 RVA: 0x00FCE19E File Offset: 0x00FCC39E
		public void BackpackTick(float deltaTime)
		{
			this.BackpackPanelModel.Tick();
			this.ListPanelModel.RefreshDragTips(this.BackpackPanelModel.IsInDragState, !this.BackpackPanelModel.IsDragFail);
		}

		// Token: 0x0604137C RID: 267132 RVA: 0x00FCE1CF File Offset: 0x00FCC3CF
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return this.View.GetPanelParentItem();
		}

		// Token: 0x0604137D RID: 267133 RVA: 0x00FCE1DC File Offset: 0x00FCC3DC
		public void NotifyQuicklySellActive(bool isActive)
		{
			this.View.NotifyQuicklySellActive(isActive);
		}

		// Token: 0x0604137E RID: 267134 RVA: 0x00FCE1EC File Offset: 0x00FCC3EC
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToWareHouse()
		{
			DockyardWareHouseViewModelBase.<TrySetSelectedItemBlockToWareHouse>d__15 <TrySetSelectedItemBlockToWareHouse>d__;
			<TrySetSelectedItemBlockToWareHouse>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetSelectedItemBlockToWareHouse>d__.<>4__this = this;
			<TrySetSelectedItemBlockToWareHouse>d__.<>1__state = -1;
			<TrySetSelectedItemBlockToWareHouse>d__.<>t__builder.Start<DockyardWareHouseViewModelBase.<TrySetSelectedItemBlockToWareHouse>d__15>(ref <TrySetSelectedItemBlockToWareHouse>d__);
			return <TrySetSelectedItemBlockToWareHouse>d__.<>t__builder.Task;
		}

		// Token: 0x0604137F RID: 267135 RVA: 0x00FCE230 File Offset: 0x00FCC430
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockToBackpack()
		{
			DockyardWareHouseViewModelBase.<TrySetSelectedItemBlockToBackpack>d__16 <TrySetSelectedItemBlockToBackpack>d__;
			<TrySetSelectedItemBlockToBackpack>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetSelectedItemBlockToBackpack>d__.<>4__this = this;
			<TrySetSelectedItemBlockToBackpack>d__.<>1__state = -1;
			<TrySetSelectedItemBlockToBackpack>d__.<>t__builder.Start<DockyardWareHouseViewModelBase.<TrySetSelectedItemBlockToBackpack>d__16>(ref <TrySetSelectedItemBlockToBackpack>d__);
			return <TrySetSelectedItemBlockToBackpack>d__.<>t__builder.Task;
		}

		// Token: 0x06041380 RID: 267136 RVA: 0x00FCE274 File Offset: 0x00FCC474
		private List<FishingItemInfo> GetLeftPanelItemBlockDataList()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ListPanelModel.ShowItemList)
			{
				if (dockyardItemBlockOriginalData.IncId != this.ListPanelModel.InSelectedBlockId)
				{
					list.Add(dockyardItemBlockOriginalData.GetServerData());
				}
			}
			return list;
		}

		// Token: 0x06041381 RID: 267137 RVA: 0x00FCE2EC File Offset: 0x00FCC4EC
		private List<FishingItemInfo> GetLeftPanelItemBlockDataListExcludeSelected()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ListPanelModel.ShowItemList)
			{
				if (dockyardItemBlockOriginalData.IncId != this.ListPanelModel.InSelectedBlockId && dockyardItemBlockOriginalData.IncId != this.BackpackPanelModel.InSelectedBlockId)
				{
					list.Add(dockyardItemBlockOriginalData.GetServerData());
				}
			}
			return list;
		}

		// Token: 0x06041382 RID: 267138 RVA: 0x00FCE378 File Offset: 0x00FCC578
		[NullableContext(0)]
		private UniTask<bool> TryAddToWareHouse()
		{
			DockyardWareHouseViewModelBase.<TryAddToWareHouse>d__19 <TryAddToWareHouse>d__;
			<TryAddToWareHouse>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryAddToWareHouse>d__.<>4__this = this;
			<TryAddToWareHouse>d__.<>1__state = -1;
			<TryAddToWareHouse>d__.<>t__builder.Start<DockyardWareHouseViewModelBase.<TryAddToWareHouse>d__19>(ref <TryAddToWareHouse>d__);
			return <TryAddToWareHouse>d__.<>t__builder.Task;
		}

		// Token: 0x06041383 RID: 267139 RVA: 0x00FCE3BB File Offset: 0x00FCC5BB
		public void HandleDragBegin()
		{
		}

		// Token: 0x06041384 RID: 267140 RVA: 0x00FCE3BD File Offset: 0x00FCC5BD
		public bool IsConfirmInteractive()
		{
			return true;
		}

		// Token: 0x06041385 RID: 267141 RVA: 0x00FCE3C0 File Offset: 0x00FCC5C0
		public bool IsConfirmNiagaraActive()
		{
			return true;
		}

		// Token: 0x06041386 RID: 267142 RVA: 0x00FCE3C3 File Offset: 0x00FCC5C3
		public bool IsTrawlInteractive()
		{
			return false;
		}

		// Token: 0x06041387 RID: 267143 RVA: 0x00FCE3C6 File Offset: 0x00FCC5C6
		public void TrawlClick(bool isSelected)
		{
		}

		// Token: 0x06041388 RID: 267144 RVA: 0x00FCE3C8 File Offset: 0x00FCC5C8
		public void AllSellClick()
		{
		}

		// Token: 0x17009569 RID: 38249
		// (get) Token: 0x06041389 RID: 267145
		public abstract DockyardBackpackPanelModelBase BackpackPanelModel { get; }

		// Token: 0x1700956A RID: 38250
		// (get) Token: 0x0604138A RID: 267146
		public abstract DockyardItemListPanelModel ListPanelModel { get; }

		// Token: 0x1700956B RID: 38251
		// (get) Token: 0x0604138B RID: 267147
		protected abstract CabinType RequestCabinType { get; }

		// Token: 0x0604138C RID: 267148
		[NullableContext(2)]
		public abstract DockyardItemBlockOriginalData GetItemBlockData(int id);

		// Token: 0x0604138D RID: 267149 RVA: 0x00FCE3CA File Offset: 0x00FCC5CA
		protected virtual void OnInit()
		{
		}

		// Token: 0x0604138E RID: 267150 RVA: 0x00FCE3CC File Offset: 0x00FCC5CC
		public virtual UniTask BeforeStartAsync()
		{
			DockyardWareHouseViewModelBase.<BeforeStartAsync>d__34 <BeforeStartAsync>d__;
			<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeStartAsync>d__.<>4__this = this;
			<BeforeStartAsync>d__.<>1__state = -1;
			<BeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseViewModelBase.<BeforeStartAsync>d__34>(ref <BeforeStartAsync>d__);
			return <BeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604138F RID: 267151 RVA: 0x00FCE40F File Offset: 0x00FCC60F
		protected virtual void OnCloseClick()
		{
			DockyardWareHouseView view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMe(null);
		}

		// Token: 0x1700956C RID: 38252
		// (get) Token: 0x06041390 RID: 267152 RVA: 0x00FCE422 File Offset: 0x00FCC622
		protected virtual int RequestId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x04021F47 RID: 139079
		[Nullable(2)]
		protected DockyardWareHouseView View;

		// Token: 0x04021F48 RID: 139080
		public string ViewTitle = "";
	}
}
