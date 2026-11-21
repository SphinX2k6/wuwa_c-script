using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200579C RID: 22428
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackOptionProxy
	{
		// Token: 0x17006A99 RID: 27289
		// (get) Token: 0x060375AF RID: 226735 RVA: 0x00F7602D File Offset: 0x00F7422D
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A9A RID: 27290
		// (get) Token: 0x060375B0 RID: 226736 RVA: 0x00F76039 File Offset: 0x00F74239
		private InteractionStateMachine Fsm
		{
			get
			{
				DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
				if (touchController == null)
				{
					return null;
				}
				return touchController.GetInteractionFsm();
			}
		}

		// Token: 0x17006A9B RID: 27291
		// (get) Token: 0x060375B1 RID: 226737 RVA: 0x00F76050 File Offset: 0x00F74250
		private DangoBrawlOperationDispatcher Operations
		{
			get
			{
				return DangoBrawlModel.Instance.GetOperationDispatcher();
			}
		}

		// Token: 0x060375B2 RID: 226738 RVA: 0x00F7605C File Offset: 0x00F7425C
		public DangoBrawlBackpackOptionProxy([Nullable(1)] ActivityDangoBrawlData actData, UUIItem contentOption, UUIButtonComponent btnRevert, UUIButtonComponent btnSell, UUIButtonComponent btnRotate, UUIButtonComponent btnConfirm, UUIText txtSellNum)
		{
			this.ActData = actData;
			this.ContentOption = contentOption;
			this.BtnRevert = btnRevert;
			this.BtnSell = btnSell;
			this.BtnRotate = btnRotate;
			this.BtnConfirm = btnConfirm;
			this.TxtSellNum = txtSellNum;
		}

		// Token: 0x060375B3 RID: 226739 RVA: 0x00F76099 File Offset: 0x00F74299
		public void Start()
		{
			this.InitSequencePlayer();
			this.BindEvents();
		}

		// Token: 0x060375B4 RID: 226740 RVA: 0x00F760A7 File Offset: 0x00F742A7
		public void Destroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x060375B5 RID: 226741 RVA: 0x00F760B8 File Offset: 0x00F742B8
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShortcutKey, new Action<EDangoBrawlOptionType>(this.OnShortcutKey));
			UUIButtonComponent btnRevert = this.BtnRevert;
			if (btnRevert != null)
			{
				btnRevert.OnClickCallBack.Bind(new Action(this.OnClickOptionRevert));
			}
			UUIButtonComponent btnSell = this.BtnSell;
			if (btnSell != null)
			{
				btnSell.OnClickCallBack.Bind(new Action(this.OnClickOptionSell));
			}
			UUIButtonComponent btnRotate = this.BtnRotate;
			if (btnRotate != null)
			{
				btnRotate.OnClickCallBack.Bind(new Action(this.OnClickOptionRotate));
			}
			UUIButtonComponent btnConfirm = this.BtnConfirm;
			if (btnConfirm == null)
			{
				return;
			}
			btnConfirm.OnClickCallBack.Bind(new Action(this.OnClickOptionConfim));
		}

		// Token: 0x060375B6 RID: 226742 RVA: 0x00F761A0 File Offset: 0x00F743A0
		private void UnBindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShortcutKey, new Action<EDangoBrawlOptionType>(this.OnShortcutKey));
			UUIButtonComponent btnRevert = this.BtnRevert;
			if (btnRevert != null)
			{
				btnRevert.OnClickCallBack.Unbind();
			}
			UUIButtonComponent btnSell = this.BtnSell;
			if (btnSell != null)
			{
				btnSell.OnClickCallBack.Unbind();
			}
			UUIButtonComponent btnRotate = this.BtnRotate;
			if (btnRotate != null)
			{
				btnRotate.OnClickCallBack.Unbind();
			}
			UUIButtonComponent btnConfirm = this.BtnConfirm;
			if (btnConfirm == null)
			{
				return;
			}
			btnConfirm.OnClickCallBack.Unbind();
		}

		// Token: 0x060375B7 RID: 226743 RVA: 0x00F76258 File Offset: 0x00F74458
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIButtonComponent btnConfirm = this.BtnConfirm;
			UUIItem uuiitem = (btnConfirm != null) ? btnConfirm.GetRootComponent() : null;
			if (uuiitem != null)
			{
				this.BtnConfimSequencePlayer = new UiSequencePlayer(uuiitem);
			}
		}

		// Token: 0x060375B8 RID: 226744 RVA: 0x00F7628D File Offset: 0x00F7448D
		private void ClearSequencePlayer()
		{
			UiSequencePlayer btnConfimSequencePlayer = this.BtnConfimSequencePlayer;
			if (btnConfimSequencePlayer != null)
			{
				btnConfimSequencePlayer.Clear();
			}
			this.BtnConfimSequencePlayer = null;
		}

		// Token: 0x060375B9 RID: 226745 RVA: 0x00F762A8 File Offset: 0x00F744A8
		private int GetSelectedBagUid()
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlSelection dangoBrawlSelection;
			if (instance == null)
			{
				dangoBrawlSelection = null;
			}
			else
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				dangoBrawlSelection = ((touchController != null) ? touchController.GetContext().GetSelection() : null);
			}
			DangoBrawlSelection dangoBrawlSelection2 = dangoBrawlSelection;
			if (dangoBrawlSelection2 == null || dangoBrawlSelection2.Source != EDragSourceKind.Bag)
			{
				return -1;
			}
			return dangoBrawlSelection2.Id;
		}

		// Token: 0x060375BA RID: 226746 RVA: 0x00F762EC File Offset: 0x00F744EC
		public void RefreshOptionButtons()
		{
			int selectedBagUid = this.GetSelectedBagUid();
			bool flag = selectedBagUid != -1;
			InteractionStateMachine fsm = this.Fsm;
			bool flag2 = fsm != null && fsm.IsHolding();
			InteractionStateMachine fsm2 = this.Fsm;
			bool flag3 = fsm2 != null && fsm2.IsSticky();
			bool flag4;
			if (flag2)
			{
				DangoBrawlTouchController touch = this.Touch;
				flag4 = (touch == null || touch.FsmPayLoadSource.GetValueOrDefault() != EDragSourceKind.Bag);
			}
			else
			{
				flag4 = false;
			}
			bool flag5 = flag4;
			bool flag6;
			if (flag2)
			{
				DangoBrawlOperationDispatcher operations = this.Operations;
				flag6 = (operations != null && operations.CanExecute(EDangoBrawlOptionType.Confim, -1));
			}
			else
			{
				flag6 = false;
			}
			bool flag7 = flag6;
			UUIButtonComponent btnRevert = this.BtnRevert;
			if (btnRevert != null)
			{
				UUIItem rootComponent = btnRevert.GetRootComponent();
				if (rootComponent != null)
				{
					rootComponent.SetUIActive(flag2);
				}
			}
			UUIButtonComponent btnConfirm = this.BtnConfirm;
			if (btnConfirm != null)
			{
				UUIItem rootComponent2 = btnConfirm.GetRootComponent();
				if (rootComponent2 != null)
				{
					rootComponent2.SetUIActive(flag2);
				}
			}
			UUIButtonComponent btnConfirm2 = this.BtnConfirm;
			if (btnConfirm2 != null)
			{
				UUIItem rootComponent3 = btnConfirm2.GetRootComponent();
				if (rootComponent3 != null)
				{
					rootComponent3.SetUIItemAlpha(flag7 ? 1f : 0.5f);
				}
			}
			UiSequencePlayer btnConfimSequencePlayer = this.BtnConfimSequencePlayer;
			if (btnConfimSequencePlayer != null)
			{
				btnConfimSequencePlayer.PlaySequencePurely(flag7 ? "Usable" : "Unusable", false, false);
			}
			DangoBrawlOperationDispatcher operations2 = this.Operations;
			bool flag8 = operations2 != null && operations2.CanExecute(EDangoBrawlOptionType.Sell, selectedBagUid);
			UUIButtonComponent btnSell = this.BtnSell;
			if (btnSell != null)
			{
				UUIItem rootComponent4 = btnSell.GetRootComponent();
				if (rootComponent4 != null)
				{
					rootComponent4.SetUIActive(flag && !flag5 && flag8);
				}
			}
			this.RefreshSellNum(selectedBagUid);
			UUIButtonComponent btnRotate = this.BtnRotate;
			if (btnRotate != null)
			{
				UUIItem rootComponent5 = btnRotate.GetRootComponent();
				if (rootComponent5 != null)
				{
					rootComponent5.SetUIActive(flag || flag2);
				}
			}
			UUIItem contentOption = this.ContentOption;
			if (contentOption == null)
			{
				return;
			}
			contentOption.SetUIActive(!flag3 && (flag || flag5 || flag2));
		}

		// Token: 0x060375BB RID: 226747 RVA: 0x00F76480 File Offset: 0x00F74680
		private void RefreshSellNum(int selectedUid)
		{
			if (this.TxtSellNum == null)
			{
				return;
			}
			if (selectedUid == -1)
			{
				this.TxtSellNum.SetText("0", true);
				return;
			}
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(selectedUid) : null;
			if (dangoBrawlBackpackItemData == null)
			{
				this.TxtSellNum.SetText("0", true);
				return;
			}
			DangoBrawlItem? dangoBrawlItem;
			int num = (DangoBrawlConfig.Instance.GetDangoBrawlItemById(dangoBrawlBackpackItemData.MyConfigId) != null) ? dangoBrawlItem.GetValueOrDefault().Price : 0;
			this.TxtSellNum.SetText(((int)Math.Floor((double)num / 2.0)).ToString(), true);
		}

		// Token: 0x060375BC RID: 226748 RVA: 0x00F7652E File Offset: 0x00F7472E
		public void OnClickOptionRevert()
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			DangoBrawlOperationDispatcher operations = this.Operations;
			if (operations == null)
			{
				return;
			}
			operations.Execute(EDangoBrawlOptionType.Revoke, -1).Forget<bool>();
		}

		// Token: 0x060375BD RID: 226749 RVA: 0x00F76550 File Offset: 0x00F74750
		public void OnClickOptionSell()
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true) || DangoBrawlViewManager.TryBlockIfLayerMode(true))
			{
				return;
			}
			int selectedBagUid = this.GetSelectedBagUid();
			if (selectedBagUid == -1)
			{
				return;
			}
			DangoBrawlOperationDispatcher operations = this.Operations;
			if (operations == null || !operations.CanExecute(EDangoBrawlOptionType.Sell, selectedBagUid))
			{
				return;
			}
			this.Operations.Execute(EDangoBrawlOptionType.Sell, selectedBagUid).Forget<bool>();
		}

		// Token: 0x060375BE RID: 226750 RVA: 0x00F765A8 File Offset: 0x00F747A8
		public void OnClickOptionRotate()
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			int num;
			if (touch == null || !touch.IsFsmBlocking)
			{
				num = this.GetSelectedBagUid();
			}
			else
			{
				DangoBrawlTouchController touch2 = this.Touch;
				num = ((touch2 != null) ? touch2.FsmSourceUid : null).GetValueOrDefault(-1);
			}
			int num2 = num;
			if (num2 == -1)
			{
				return;
			}
			DangoBrawlOperationDispatcher operations = this.Operations;
			if (operations == null || !operations.CanExecute(EDangoBrawlOptionType.Rotate, num2))
			{
				return;
			}
			DangoBrawlOperationDispatcher operations2 = this.Operations;
			if (operations2 == null)
			{
				return;
			}
			operations2.Execute(EDangoBrawlOptionType.Rotate, num2).Forget<bool>();
		}

		// Token: 0x060375BF RID: 226751 RVA: 0x00F76634 File Offset: 0x00F74834
		public void OnClickOptionConfim()
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			DangoBrawlOperationDispatcher operations = this.Operations;
			if (operations == null || !operations.CanExecute(EDangoBrawlOptionType.Confim, -1))
			{
				return;
			}
			this.Operations.Execute(EDangoBrawlOptionType.Confim, -1).Forget<bool>();
		}

		// Token: 0x060375C0 RID: 226752 RVA: 0x00F7666B File Offset: 0x00F7486B
		private void OnSelectionChanged()
		{
			this.RefreshOptionButtons();
		}

		// Token: 0x060375C1 RID: 226753 RVA: 0x00F76673 File Offset: 0x00F74873
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshOptionButtons();
		}

		// Token: 0x060375C2 RID: 226754 RVA: 0x00F7667B File Offset: 0x00F7487B
		private void OnShortcutKey(EDangoBrawlOptionType type)
		{
			switch (type)
			{
			case EDangoBrawlOptionType.Revoke:
				this.OnClickOptionRevert();
				return;
			case EDangoBrawlOptionType.Sell:
				this.OnClickOptionSell();
				return;
			case EDangoBrawlOptionType.Rotate:
				this.OnClickOptionRotate();
				return;
			case EDangoBrawlOptionType.Confim:
				this.OnClickOptionConfim();
				return;
			default:
				return;
			}
		}

		// Token: 0x0401D3B0 RID: 119728
		[Nullable(1)]
		private readonly ActivityDangoBrawlData ActData;

		// Token: 0x0401D3B1 RID: 119729
		private readonly UUIItem ContentOption;

		// Token: 0x0401D3B2 RID: 119730
		private readonly UUIButtonComponent BtnRevert;

		// Token: 0x0401D3B3 RID: 119731
		private readonly UUIButtonComponent BtnSell;

		// Token: 0x0401D3B4 RID: 119732
		private readonly UUIButtonComponent BtnRotate;

		// Token: 0x0401D3B5 RID: 119733
		private readonly UUIButtonComponent BtnConfirm;

		// Token: 0x0401D3B6 RID: 119734
		private readonly UUIText TxtSellNum;

		// Token: 0x0401D3B7 RID: 119735
		protected UiSequencePlayer BtnConfimSequencePlayer;
	}
}
