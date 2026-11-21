using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200550F RID: 21775
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardBackpackPanelModelBase : IDockyardGridInterface, IDockyardWareHouseInterface
	{
		// Token: 0x170068B8 RID: 26808
		// (get) Token: 0x06035FB7 RID: 221111 RVA: 0x00F141A4 File Offset: 0x00F123A4
		// (set) Token: 0x06035FB8 RID: 221112 RVA: 0x00F141AC File Offset: 0x00F123AC
		public bool IsInSelectState
		{
			get
			{
				return this.IsInSelectStateInternal;
			}
			set
			{
				this.IsInSelectStateInternal = value;
				this.Panel.SetAllSellBtnState(value);
				this.Panel.SetItemBlockTextureMaskActive(value);
				IDockyardBackpackInterface viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.SetInSelectState(value);
				}
				if (!value)
				{
					this.Panel.SetButtonsState(false);
				}
			}
		}

		// Token: 0x170068B9 RID: 26809
		// (get) Token: 0x06035FB9 RID: 221113 RVA: 0x00F141F9 File Offset: 0x00F123F9
		public bool IsInHighlight
		{
			get
			{
				return !this.IsInCanConfirm;
			}
		}

		// Token: 0x170068BA RID: 26810
		// (get) Token: 0x06035FBA RID: 221114 RVA: 0x00F14204 File Offset: 0x00F12404
		public bool IsInCanConfirm
		{
			get
			{
				return !this.IsSetFail && !this.IsOverlap();
			}
		}

		// Token: 0x06035FBB RID: 221115 RVA: 0x00F1421B File Offset: 0x00F1241B
		public DockyardBackpackPanelModelBase()
		{
			this.BackpackData = new DockyardBackpackData(this.IsQuickSellOpen());
		}

		// Token: 0x06035FBC RID: 221116 RVA: 0x00F14258 File Offset: 0x00F12458
		private void InitPreviewBackpackData()
		{
			foreach (IPanelPos key in this.BackpackData.GetBackpackDataList())
			{
				this.PreviewBackpackMap.Add(key, -1);
			}
		}

		// Token: 0x06035FBD RID: 221117 RVA: 0x00F142B8 File Offset: 0x00F124B8
		public void SetPreviewBackpackData(IPanelPos pos, int id)
		{
			this.PreviewBackpackMap[pos] = id;
		}

		// Token: 0x06035FBE RID: 221118 RVA: 0x00F142C7 File Offset: 0x00F124C7
		public int GetPreviewBackpackData(IPanelPos pos)
		{
			return this.PreviewBackpackMap[pos];
		}

		// Token: 0x06035FBF RID: 221119 RVA: 0x00F142D5 File Offset: 0x00F124D5
		public void RefreshBackpackQuicklySellData()
		{
			this.BackpackData.RefreshQuicklySellOpen(this.IsQuickSellOpen());
		}

		// Token: 0x06035FC0 RID: 221120 RVA: 0x00F142E8 File Offset: 0x00F124E8
		public void InitPanel(DockyardBackpackPanel panel)
		{
			this.Panel = panel;
			this.InitPreviewBackpackData();
		}

		// Token: 0x06035FC1 RID: 221121 RVA: 0x00F142F7 File Offset: 0x00F124F7
		public void RegisterViewModel(IDockyardBackpackInterface viewModel)
		{
			this.ViewModel = viewModel;
		}

		// Token: 0x06035FC2 RID: 221122 RVA: 0x00F14300 File Offset: 0x00F12500
		public void SetItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.NotifyItemBlockToWareHouse(data);
		}

		// Token: 0x06035FC3 RID: 221123 RVA: 0x00F14314 File Offset: 0x00F12514
		public void QuicklySellClick()
		{
			if (this.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			List<int> quicklySellItemIdList = this.Panel.GetQuicklySellItemIdList();
			if (FishingQuestModel.Instance.OnFishingItemSell(quicklySellItemIdList, this.IsInSelectState, new Action(this.RequestFinishingQuickSell)))
			{
				return;
			}
			this.RequestFinishingQuickSell();
		}

		// Token: 0x06035FC4 RID: 221124 RVA: 0x00F14370 File Offset: 0x00F12570
		private void RequestFinishingQuickSell()
		{
			FishingController.Instance.RequestFishingQuickSell(delegate(bool isSuccess)
			{
				if (isSuccess)
				{
					this.Panel.CloseQuicklySellPanel();
					foreach (int id in this.TempQuicklySellIncIdSet)
					{
						this.Panel.DestroyItemBlockById(id);
					}
					this.TempQuicklySellIncIdSet.Clear();
				}
			});
		}

		// Token: 0x06035FC5 RID: 221125 RVA: 0x00F14388 File Offset: 0x00F12588
		public void OnSellClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				IDockyardBackpackInterface viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.NotifyQuicklySellActive(true);
				}
				this.Panel.ShowQuicklySellPanel();
				return;
			}
			IDockyardBackpackInterface viewModel2 = this.ViewModel;
			if (viewModel2 != null)
			{
				viewModel2.NotifyQuicklySellActive(false);
			}
			this.Panel.HideQuicklySellPanel();
		}

		// Token: 0x06035FC6 RID: 221126 RVA: 0x00F143D4 File Offset: 0x00F125D4
		public void OnTrawlClick(EToggleState state)
		{
			if (this.IsInSelectState)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
				return;
			}
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.TrawlClick(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06035FC7 RID: 221127 RVA: 0x00F14408 File Offset: 0x00F12608
		public void OnDeleteClick()
		{
			if (!FunctionModel.Instance.IsOpen(10076))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DockyardDeleteItem);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				IDockyardBackpackInterface viewModel = this.ViewModel;
				if (viewModel == null)
				{
					return;
				}
				viewModel.DeleteClick();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06035FC8 RID: 221128 RVA: 0x00F1446A File Offset: 0x00F1266A
		public void OnRotateClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.RotateClick();
		}

		// Token: 0x06035FC9 RID: 221129 RVA: 0x00F1447C File Offset: 0x00F1267C
		public void OnConfirmClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.ConfirmClick();
		}

		// Token: 0x06035FCA RID: 221130 RVA: 0x00F1448E File Offset: 0x00F1268E
		public void OnAllSellClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.AllSellClick();
		}

		// Token: 0x06035FCB RID: 221131 RVA: 0x00F144A0 File Offset: 0x00F126A0
		public void OnBackToWareHouseClick()
		{
			this.TrySetItemBlockBackToWareHouse().Forget<bool>();
		}

		// Token: 0x06035FCC RID: 221132 RVA: 0x00F144AD File Offset: 0x00F126AD
		public void OnMaskClick()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
		}

		// Token: 0x06035FCD RID: 221133 RVA: 0x00F144C3 File Offset: 0x00F126C3
		public void BackpackTick(float deltaTime)
		{
			if (!this.IsInSelectState)
			{
				return;
			}
			if (!this.IsInDragState)
			{
				return;
			}
			if (this.InSelectedBlockId == -1)
			{
				return;
			}
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.BackpackTick(deltaTime);
		}

		// Token: 0x06035FCE RID: 221134 RVA: 0x00F144F2 File Offset: 0x00F126F2
		public void Tick()
		{
			this.RefreshPanel(true);
		}

		// Token: 0x06035FCF RID: 221135 RVA: 0x00F144FC File Offset: 0x00F126FC
		public void RefreshPanel(bool checkRangeChange = true)
		{
			this.Panel.RefreshAllBackpackGridState(checkRangeChange);
			IDockyardConfirmProvider dockyardConfirmProvider = (this.ViewModel is IDockyardConfirmProvider) ? (this.ViewModel as IDockyardConfirmProvider) : null;
			bool confirmInteractive = (dockyardConfirmProvider != null) ? dockyardConfirmProvider.IsConfirmInteractive() : (!this.IsSetFail);
			this.Panel.SetConfirmInteractive(confirmInteractive);
			bool confirmNiagaraActive = (dockyardConfirmProvider != null) ? dockyardConfirmProvider.IsConfirmNiagaraActive() : this.IsInCanConfirm;
			this.Panel.SetConfirmNiagaraActive(confirmNiagaraActive);
		}

		// Token: 0x06035FD0 RID: 221136 RVA: 0x00F14570 File Offset: 0x00F12770
		public bool CanConfirm()
		{
			return this.Panel.CanConfirm();
		}

		// Token: 0x06035FD1 RID: 221137 RVA: 0x00F1457D File Offset: 0x00F1277D
		public bool IsOverlap()
		{
			return this.Panel.IsOverlap();
		}

		// Token: 0x06035FD2 RID: 221138 RVA: 0x00F1458A File Offset: 0x00F1278A
		[NullableContext(2)]
		public UUIItem GetQuicklySellPanelParentItem()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return null;
			}
			return viewModel.GetQuicklySellPanelParentItem();
		}

		// Token: 0x06035FD3 RID: 221139 RVA: 0x00F1459D File Offset: 0x00F1279D
		public void OnItemBlockClick(int id)
		{
			if (this.IsInSelectState)
			{
				return;
			}
			this.Panel.ItemBlockClick(id);
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.ItemBlockClick(id);
		}

		// Token: 0x06035FD4 RID: 221140 RVA: 0x00F145C5 File Offset: 0x00F127C5
		public bool CanDrag(int id)
		{
			return this.Panel.CanDrag(id);
		}

		// Token: 0x06035FD5 RID: 221141 RVA: 0x00F145D3 File Offset: 0x00F127D3
		public bool DragBegin(int id)
		{
			if (!this.IsInDragState)
			{
				this.IsInDragState = true;
				this.IsMoved = false;
				IDockyardBackpackInterface viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.HandleDragBegin();
				}
				this.Panel.SetButtonsState(false);
				return true;
			}
			return false;
		}

		// Token: 0x06035FD6 RID: 221142 RVA: 0x00F1460B File Offset: 0x00F1280B
		public bool DragEnd(int id)
		{
			if (this.IsInDragState)
			{
				this.IsInDragState = false;
				IDockyardBackpackInterface viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.HandleDragResult();
				}
				return true;
			}
			return false;
		}

		// Token: 0x06035FD7 RID: 221143 RVA: 0x00F14630 File Offset: 0x00F12830
		public void WareHouseItemClick(DockyardItemBlockOriginalData itemData)
		{
			this.Panel.CreateItemBlockByView(itemData).Forget();
		}

		// Token: 0x06035FD8 RID: 221144 RVA: 0x00F14643 File Offset: 0x00F12843
		public void WareHouseItemDragBegin(DockyardItemBlockOriginalData itemData)
		{
			this.Panel.CreateItemBlockByViewAndFollow(itemData).Forget();
		}

		// Token: 0x06035FD9 RID: 221145 RVA: 0x00F14656 File Offset: 0x00F12856
		public bool IsWareHouseItemCanClick(int id)
		{
			return !this.IsInSelectState;
		}

		// Token: 0x06035FDA RID: 221146 RVA: 0x00F14661 File Offset: 0x00F12861
		public int GetSelectedId()
		{
			return this.InSelectedBlockId;
		}

		// Token: 0x06035FDB RID: 221147 RVA: 0x00F1466C File Offset: 0x00F1286C
		[NullableContext(0)]
		public UniTask<bool> TrySetItemBlockBackToWareHouse()
		{
			DockyardBackpackPanelModelBase.<TrySetItemBlockBackToWareHouse>d__52 <TrySetItemBlockBackToWareHouse>d__;
			<TrySetItemBlockBackToWareHouse>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetItemBlockBackToWareHouse>d__.<>4__this = this;
			<TrySetItemBlockBackToWareHouse>d__.<>1__state = -1;
			<TrySetItemBlockBackToWareHouse>d__.<>t__builder.Start<DockyardBackpackPanelModelBase.<TrySetItemBlockBackToWareHouse>d__52>(ref <TrySetItemBlockBackToWareHouse>d__);
			return <TrySetItemBlockBackToWareHouse>d__.<>t__builder.Task;
		}

		// Token: 0x06035FDC RID: 221148 RVA: 0x00F146B0 File Offset: 0x00F128B0
		[NullableContext(0)]
		public UniTask<bool> TrySetSelectedItemBlockConfirm()
		{
			DockyardBackpackPanelModelBase.<TrySetSelectedItemBlockConfirm>d__53 <TrySetSelectedItemBlockConfirm>d__;
			<TrySetSelectedItemBlockConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TrySetSelectedItemBlockConfirm>d__.<>4__this = this;
			<TrySetSelectedItemBlockConfirm>d__.<>1__state = -1;
			<TrySetSelectedItemBlockConfirm>d__.<>t__builder.Start<DockyardBackpackPanelModelBase.<TrySetSelectedItemBlockConfirm>d__53>(ref <TrySetSelectedItemBlockConfirm>d__);
			return <TrySetSelectedItemBlockConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x06035FDD RID: 221149 RVA: 0x00F146F3 File Offset: 0x00F128F3
		public virtual bool IsQuickSellOpen()
		{
			return !FishingModel.Instance.IsInDock && DockyardModel.Instance.IsQuicklySellOpen;
		}

		// Token: 0x06035FDE RID: 221150 RVA: 0x00F1470D File Offset: 0x00F1290D
		public virtual bool GetIsTrawlOpen()
		{
			return false;
		}

		// Token: 0x06035FDF RID: 221151 RVA: 0x00F14710 File Offset: 0x00F12910
		public virtual bool GetIsBackToWareHouseOpen()
		{
			return true;
		}

		// Token: 0x170068BB RID: 26811
		// (get) Token: 0x06035FE0 RID: 221152 RVA: 0x00F14713 File Offset: 0x00F12913
		// (set) Token: 0x06035FE1 RID: 221153 RVA: 0x00F1471B File Offset: 0x00F1291B
		public virtual bool IsAllSellOpen { get; set; }

		// Token: 0x170068BC RID: 26812
		// (get) Token: 0x06035FE2 RID: 221154 RVA: 0x00F14724 File Offset: 0x00F12924
		// (set) Token: 0x06035FE3 RID: 221155 RVA: 0x00F1472C File Offset: 0x00F1292C
		public virtual bool IsDeleteOpen { get; set; } = true;

		// Token: 0x0401C862 RID: 116834
		private bool IsInSelectStateInternal;

		// Token: 0x0401C863 RID: 116835
		public int InSelectedBlockId = -1;

		// Token: 0x0401C864 RID: 116836
		public bool IsInDragState;

		// Token: 0x0401C865 RID: 116837
		public bool IsOutOfRange;

		// Token: 0x0401C866 RID: 116838
		public bool IsSetFail;

		// Token: 0x0401C867 RID: 116839
		public DockyardBackpackPanel Panel;

		// Token: 0x0401C868 RID: 116840
		[Nullable(2)]
		protected IDockyardBackpackInterface ViewModel;

		// Token: 0x0401C869 RID: 116841
		protected Dictionary<IPanelPos, int> PreviewBackpackMap = new Dictionary<IPanelPos, int>();

		// Token: 0x0401C86A RID: 116842
		public EBackpackQuicklySellType TempQuicklySellType;

		// Token: 0x0401C86B RID: 116843
		public HashSet<int> TempQuicklySellIncIdSet = new HashSet<int>();

		// Token: 0x0401C86C RID: 116844
		public DockyardBackpackData BackpackData;

		// Token: 0x0401C86D RID: 116845
		public bool IsDragFail;

		// Token: 0x0401C86E RID: 116846
		public bool IsMoved;
	}
}
