using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005518 RID: 21784
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardWareHouseViewModelBase : IDockyardBackpackInterface
	{
		// Token: 0x06036036 RID: 221238 RVA: 0x00F14F61 File Offset: 0x00F13161
		public void RegisterView(DockyardWareHouseView view)
		{
			this.View = view;
			this.BackpackPanelModel.RegisterViewModel(this);
			this.ListPanelModel.RegisterBackpackPanelModel(this.BackpackPanelModel);
			this.OnInit();
		}

		// Token: 0x06036037 RID: 221239 RVA: 0x00F14F8D File Offset: 0x00F1318D
		public void CloseClick()
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			this.OnCloseClick();
		}

		// Token: 0x06036038 RID: 221240 RVA: 0x00F14FB7 File Offset: 0x00F131B7
		public bool CheckCurrencyItemClick(int itemId)
		{
			if (this.BackpackPanelModel.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06036039 RID: 221241 RVA: 0x00F14FDD File Offset: 0x00F131DD
		public void ItemBlockClick(int id)
		{
			DockyardWareHouseView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowTipsPanel(id);
		}

		// Token: 0x0603603A RID: 221242 RVA: 0x00F14FF0 File Offset: 0x00F131F0
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

		// Token: 0x0603603B RID: 221243 RVA: 0x00F1501C File Offset: 0x00F1321C
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

		// Token: 0x0603603C RID: 221244 RVA: 0x00F150A4 File Offset: 0x00F132A4
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

		// Token: 0x0603603D RID: 221245 RVA: 0x00F1512D File Offset: 0x00F1332D
		public void RotateClick()
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				this.BackpackPanelModel.Panel.RotateClick();
			}
		}

		// Token: 0x0603603E RID: 221246 RVA: 0x00F1514C File Offset: 0x00F1334C
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

		// Token: 0x0603603F RID: 221247 RVA: 0x00F151A4 File Offset: 0x00F133A4
		public void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			this.ListPanelModel.SetItemBlockToWareHouse(data);
		}

		// Token: 0x06036040 RID: 221248 RVA: 0x00F151B2 File Offset: 0x00F133B2
		public void BackpackTick(float deltaTime)
		{
			this.BackpackPanelModel.Tick();
			this.ListPanelModel.RefreshDragTips(this.BackpackPanelModel.IsInDragState, !this.BackpackPanelModel.IsDragFail);
		}

		// Token: 0x06036041 RID: 221249 RVA: 0x00F151E3 File Offset: 0x00F133E3
		public UUIItem GetQuicklySellPanelParentItem()
		{
			return this.View.GetPanelParentItem();
		}

		// Token: 0x06036042 RID: 221250 RVA: 0x00F151F0 File Offset: 0x00F133F0
		public void NotifyQuicklySellActive(bool isActive)
		{
			this.View.NotifyQuicklySellActive(isActive);
		}

		// Token: 0x06036043 RID: 221251 RVA: 0x00F15200 File Offset: 0x00F13400
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

		// Token: 0x06036044 RID: 221252 RVA: 0x00F15244 File Offset: 0x00F13444
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

		// Token: 0x06036045 RID: 221253 RVA: 0x00F15288 File Offset: 0x00F13488
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

		// Token: 0x06036046 RID: 221254 RVA: 0x00F15300 File Offset: 0x00F13500
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

		// Token: 0x06036047 RID: 221255 RVA: 0x00F1538C File Offset: 0x00F1358C
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

		// Token: 0x06036048 RID: 221256 RVA: 0x00F153CF File Offset: 0x00F135CF
		public void HandleDragBegin()
		{
		}

		// Token: 0x06036049 RID: 221257 RVA: 0x00F153D1 File Offset: 0x00F135D1
		public bool IsConfirmInteractive()
		{
			return true;
		}

		// Token: 0x0603604A RID: 221258 RVA: 0x00F153D4 File Offset: 0x00F135D4
		public bool IsConfirmNiagaraActive()
		{
			return true;
		}

		// Token: 0x0603604B RID: 221259 RVA: 0x00F153D7 File Offset: 0x00F135D7
		public bool IsTrawlInteractive()
		{
			return false;
		}

		// Token: 0x0603604C RID: 221260 RVA: 0x00F153DA File Offset: 0x00F135DA
		public void TrawlClick(bool isSelected)
		{
		}

		// Token: 0x0603604D RID: 221261 RVA: 0x00F153DC File Offset: 0x00F135DC
		public void AllSellClick()
		{
		}

		// Token: 0x170068CB RID: 26827
		// (get) Token: 0x0603604E RID: 221262
		public abstract DockyardBackpackPanelModelBase BackpackPanelModel { get; }

		// Token: 0x170068CC RID: 26828
		// (get) Token: 0x0603604F RID: 221263
		public abstract DockyardItemListPanelModel ListPanelModel { get; }

		// Token: 0x170068CD RID: 26829
		// (get) Token: 0x06036050 RID: 221264
		protected abstract CabinType RequestCabinType { get; }

		// Token: 0x06036051 RID: 221265
		[NullableContext(2)]
		public abstract DockyardItemBlockOriginalData GetItemBlockData(int id);

		// Token: 0x06036052 RID: 221266 RVA: 0x00F153DE File Offset: 0x00F135DE
		protected virtual void OnInit()
		{
		}

		// Token: 0x06036053 RID: 221267 RVA: 0x00F153E0 File Offset: 0x00F135E0
		public virtual UniTask BeforeStartAsync()
		{
			DockyardWareHouseViewModelBase.<BeforeStartAsync>d__34 <BeforeStartAsync>d__;
			<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeStartAsync>d__.<>4__this = this;
			<BeforeStartAsync>d__.<>1__state = -1;
			<BeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseViewModelBase.<BeforeStartAsync>d__34>(ref <BeforeStartAsync>d__);
			return <BeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036054 RID: 221268 RVA: 0x00F15423 File Offset: 0x00F13623
		protected virtual void OnCloseClick()
		{
			DockyardWareHouseView view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMe(null);
		}

		// Token: 0x170068CE RID: 26830
		// (get) Token: 0x06036055 RID: 221269 RVA: 0x00F15436 File Offset: 0x00F13636
		protected virtual int RequestId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0401C878 RID: 116856
		[Nullable(2)]
		protected DockyardWareHouseView View;

		// Token: 0x0401C879 RID: 116857
		public string ViewTitle = "";
	}
}
