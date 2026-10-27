using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006591 RID: 26001
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardBackpackPanelModelBase : IDockyardGridInterface, IDockyardWareHouseInterface
	{
		// Token: 0x17009556 RID: 38230
		// (get) Token: 0x060412F2 RID: 266994 RVA: 0x00FCD190 File Offset: 0x00FCB390
		// (set) Token: 0x060412F3 RID: 266995 RVA: 0x00FCD198 File Offset: 0x00FCB398
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

		// Token: 0x17009557 RID: 38231
		// (get) Token: 0x060412F4 RID: 266996 RVA: 0x00FCD1E5 File Offset: 0x00FCB3E5
		public bool IsInHighlight
		{
			get
			{
				return !this.IsInCanConfirm;
			}
		}

		// Token: 0x17009558 RID: 38232
		// (get) Token: 0x060412F5 RID: 266997 RVA: 0x00FCD1F0 File Offset: 0x00FCB3F0
		public bool IsInCanConfirm
		{
			get
			{
				return !this.IsSetFail && !this.IsOverlap();
			}
		}

		// Token: 0x060412F6 RID: 266998 RVA: 0x00FCD207 File Offset: 0x00FCB407
		public DockyardBackpackPanelModelBase()
		{
			this.BackpackData = new DockyardBackpackData(this.IsQuickSellOpen());
		}

		// Token: 0x060412F7 RID: 266999 RVA: 0x00FCD244 File Offset: 0x00FCB444
		private void InitPreviewBackpackData()
		{
			foreach (IPanelPos key in this.BackpackData.GetBackpackDataList())
			{
				this.PreviewBackpackMap.Add(key, -1);
			}
		}

		// Token: 0x060412F8 RID: 267000 RVA: 0x00FCD2A4 File Offset: 0x00FCB4A4
		public void SetPreviewBackpackData(IPanelPos pos, int id)
		{
			this.PreviewBackpackMap[pos] = id;
		}

		// Token: 0x060412F9 RID: 267001 RVA: 0x00FCD2B3 File Offset: 0x00FCB4B3
		public int GetPreviewBackpackData(IPanelPos pos)
		{
			return this.PreviewBackpackMap[pos];
		}

		// Token: 0x060412FA RID: 267002 RVA: 0x00FCD2C1 File Offset: 0x00FCB4C1
		public void RefreshBackpackQuicklySellData()
		{
			this.BackpackData.RefreshQuicklySellOpen(this.IsQuickSellOpen());
		}

		// Token: 0x060412FB RID: 267003 RVA: 0x00FCD2D4 File Offset: 0x00FCB4D4
		public void InitPanel(DockyardBackpackPanel panel)
		{
			this.Panel = panel;
			this.InitPreviewBackpackData();
		}

		// Token: 0x060412FC RID: 267004 RVA: 0x00FCD2E3 File Offset: 0x00FCB4E3
		public void RegisterViewModel(IDockyardBackpackInterface viewModel)
		{
			this.ViewModel = viewModel;
		}

		// Token: 0x060412FD RID: 267005 RVA: 0x00FCD2EC File Offset: 0x00FCB4EC
		public void SetItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.NotifyItemBlockToWareHouse(data);
		}

		// Token: 0x060412FE RID: 267006 RVA: 0x00FCD300 File Offset: 0x00FCB500
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

		// Token: 0x060412FF RID: 267007 RVA: 0x00FCD35C File Offset: 0x00FCB55C
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

		// Token: 0x06041300 RID: 267008 RVA: 0x00FCD374 File Offset: 0x00FCB574
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

		// Token: 0x06041301 RID: 267009 RVA: 0x00FCD3C0 File Offset: 0x00FCB5C0
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

		// Token: 0x06041302 RID: 267010 RVA: 0x00FCD3F4 File Offset: 0x00FCB5F4
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

		// Token: 0x06041303 RID: 267011 RVA: 0x00FCD456 File Offset: 0x00FCB656
		public void OnRotateClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.RotateClick();
		}

		// Token: 0x06041304 RID: 267012 RVA: 0x00FCD468 File Offset: 0x00FCB668
		public void OnConfirmClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.ConfirmClick();
		}

		// Token: 0x06041305 RID: 267013 RVA: 0x00FCD47A File Offset: 0x00FCB67A
		public void OnAllSellClick()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.AllSellClick();
		}

		// Token: 0x06041306 RID: 267014 RVA: 0x00FCD48C File Offset: 0x00FCB68C
		public void OnBackToWareHouseClick()
		{
			this.TrySetItemBlockBackToWareHouse().Forget<bool>();
		}

		// Token: 0x06041307 RID: 267015 RVA: 0x00FCD499 File Offset: 0x00FCB699
		public void OnMaskClick()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SelectingQuit", Array.Empty<object>());
		}

		// Token: 0x06041308 RID: 267016 RVA: 0x00FCD4AF File Offset: 0x00FCB6AF
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

		// Token: 0x06041309 RID: 267017 RVA: 0x00FCD4DE File Offset: 0x00FCB6DE
		public void Tick()
		{
			this.RefreshPanel(true);
		}

		// Token: 0x0604130A RID: 267018 RVA: 0x00FCD4E8 File Offset: 0x00FCB6E8
		public void RefreshPanel(bool checkRangeChange = true)
		{
			this.Panel.RefreshAllBackpackGridState(checkRangeChange);
			IDockyardConfirmProvider dockyardConfirmProvider = (this.ViewModel is IDockyardConfirmProvider) ? (this.ViewModel as IDockyardConfirmProvider) : null;
			bool confirmInteractive = (dockyardConfirmProvider != null) ? dockyardConfirmProvider.IsConfirmInteractive() : (!this.IsSetFail);
			this.Panel.SetConfirmInteractive(confirmInteractive);
			bool confirmNiagaraActive = (dockyardConfirmProvider != null) ? dockyardConfirmProvider.IsConfirmNiagaraActive() : this.IsInCanConfirm;
			this.Panel.SetConfirmNiagaraActive(confirmNiagaraActive);
		}

		// Token: 0x0604130B RID: 267019 RVA: 0x00FCD55C File Offset: 0x00FCB75C
		public bool CanConfirm()
		{
			return this.Panel.CanConfirm();
		}

		// Token: 0x0604130C RID: 267020 RVA: 0x00FCD569 File Offset: 0x00FCB769
		public bool IsOverlap()
		{
			return this.Panel.IsOverlap();
		}

		// Token: 0x0604130D RID: 267021 RVA: 0x00FCD576 File Offset: 0x00FCB776
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

		// Token: 0x0604130E RID: 267022 RVA: 0x00FCD589 File Offset: 0x00FCB789
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

		// Token: 0x0604130F RID: 267023 RVA: 0x00FCD5B1 File Offset: 0x00FCB7B1
		public bool CanDrag(int id)
		{
			return this.Panel.CanDrag(id);
		}

		// Token: 0x06041310 RID: 267024 RVA: 0x00FCD5BF File Offset: 0x00FCB7BF
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

		// Token: 0x06041311 RID: 267025 RVA: 0x00FCD5F7 File Offset: 0x00FCB7F7
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

		// Token: 0x06041312 RID: 267026 RVA: 0x00FCD61C File Offset: 0x00FCB81C
		public void WareHouseItemClick(DockyardItemBlockOriginalData itemData)
		{
			this.Panel.CreateItemBlockByView(itemData).Forget();
		}

		// Token: 0x06041313 RID: 267027 RVA: 0x00FCD62F File Offset: 0x00FCB82F
		public void WareHouseItemDragBegin(DockyardItemBlockOriginalData itemData)
		{
			this.Panel.CreateItemBlockByViewAndFollow(itemData).Forget();
		}

		// Token: 0x06041314 RID: 267028 RVA: 0x00FCD642 File Offset: 0x00FCB842
		public bool IsWareHouseItemCanClick(int id)
		{
			return !this.IsInSelectState;
		}

		// Token: 0x06041315 RID: 267029 RVA: 0x00FCD64D File Offset: 0x00FCB84D
		public int GetSelectedId()
		{
			return this.InSelectedBlockId;
		}

		// Token: 0x06041316 RID: 267030 RVA: 0x00FCD658 File Offset: 0x00FCB858
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

		// Token: 0x06041317 RID: 267031 RVA: 0x00FCD69C File Offset: 0x00FCB89C
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

		// Token: 0x06041318 RID: 267032 RVA: 0x00FCD6DF File Offset: 0x00FCB8DF
		public virtual bool IsQuickSellOpen()
		{
			return !FishingModel.Instance.IsInDock && DockyardModel.Instance.IsQuicklySellOpen;
		}

		// Token: 0x06041319 RID: 267033 RVA: 0x00FCD6F9 File Offset: 0x00FCB8F9
		public virtual bool GetIsTrawlOpen()
		{
			return false;
		}

		// Token: 0x0604131A RID: 267034 RVA: 0x00FCD6FC File Offset: 0x00FCB8FC
		public virtual bool GetIsBackToWareHouseOpen()
		{
			return true;
		}

		// Token: 0x17009559 RID: 38233
		// (get) Token: 0x0604131B RID: 267035 RVA: 0x00FCD6FF File Offset: 0x00FCB8FF
		// (set) Token: 0x0604131C RID: 267036 RVA: 0x00FCD707 File Offset: 0x00FCB907
		public virtual bool IsAllSellOpen { get; set; }

		// Token: 0x1700955A RID: 38234
		// (get) Token: 0x0604131D RID: 267037 RVA: 0x00FCD710 File Offset: 0x00FCB910
		// (set) Token: 0x0604131E RID: 267038 RVA: 0x00FCD718 File Offset: 0x00FCB918
		public virtual bool IsDeleteOpen { get; set; } = true;

		// Token: 0x04021F31 RID: 139057
		private bool IsInSelectStateInternal;

		// Token: 0x04021F32 RID: 139058
		public int InSelectedBlockId = -1;

		// Token: 0x04021F33 RID: 139059
		public bool IsInDragState;

		// Token: 0x04021F34 RID: 139060
		public bool IsOutOfRange;

		// Token: 0x04021F35 RID: 139061
		public bool IsSetFail;

		// Token: 0x04021F36 RID: 139062
		public DockyardBackpackPanel Panel;

		// Token: 0x04021F37 RID: 139063
		[Nullable(2)]
		protected IDockyardBackpackInterface ViewModel;

		// Token: 0x04021F38 RID: 139064
		protected Dictionary<IPanelPos, int> PreviewBackpackMap = new Dictionary<IPanelPos, int>();

		// Token: 0x04021F39 RID: 139065
		public EBackpackQuicklySellType TempQuicklySellType;

		// Token: 0x04021F3A RID: 139066
		public HashSet<int> TempQuicklySellIncIdSet = new HashSet<int>();

		// Token: 0x04021F3B RID: 139067
		public DockyardBackpackData BackpackData;

		// Token: 0x04021F3C RID: 139068
		public bool IsDragFail;

		// Token: 0x04021F3D RID: 139069
		public bool IsMoved;
	}
}
