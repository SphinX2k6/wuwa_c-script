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
	// Token: 0x0200684C RID: 26700
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlBackpackOptionProxy
	{
		// Token: 0x17009758 RID: 38744
		// (get) Token: 0x06042A5A RID: 272986 RVA: 0x01034B05 File Offset: 0x01032D05
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17009759 RID: 38745
		// (get) Token: 0x06042A5B RID: 272987 RVA: 0x01034B11 File Offset: 0x01032D11
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

		// Token: 0x1700975A RID: 38746
		// (get) Token: 0x06042A5C RID: 272988 RVA: 0x01034B28 File Offset: 0x01032D28
		private DangoBrawlOperationDispatcher Operations
		{
			get
			{
				return DangoBrawlModel.Instance.GetOperationDispatcher();
			}
		}

		// Token: 0x06042A5D RID: 272989 RVA: 0x01034B34 File Offset: 0x01032D34
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

		// Token: 0x06042A5E RID: 272990 RVA: 0x01034B71 File Offset: 0x01032D71
		public void Start()
		{
			this.InitSequencePlayer();
			this.BindEvents();
		}

		// Token: 0x06042A5F RID: 272991 RVA: 0x01034B7F File Offset: 0x01032D7F
		public void Destroy()
		{
			this.UnBindEvents();
			this.ClearSequencePlayer();
		}

		// Token: 0x06042A60 RID: 272992 RVA: 0x01034B90 File Offset: 0x01032D90
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

		// Token: 0x06042A61 RID: 272993 RVA: 0x01034C78 File Offset: 0x01032E78
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

		// Token: 0x06042A62 RID: 272994 RVA: 0x01034D30 File Offset: 0x01032F30
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

		// Token: 0x06042A63 RID: 272995 RVA: 0x01034D65 File Offset: 0x01032F65
		private void ClearSequencePlayer()
		{
			UiSequencePlayer btnConfimSequencePlayer = this.BtnConfimSequencePlayer;
			if (btnConfimSequencePlayer != null)
			{
				btnConfimSequencePlayer.Clear();
			}
			this.BtnConfimSequencePlayer = null;
		}

		// Token: 0x06042A64 RID: 272996 RVA: 0x01034D80 File Offset: 0x01032F80
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

		// Token: 0x06042A65 RID: 272997 RVA: 0x01034DC4 File Offset: 0x01032FC4
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

		// Token: 0x06042A66 RID: 272998 RVA: 0x01034F58 File Offset: 0x01033158
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

		// Token: 0x06042A67 RID: 272999 RVA: 0x01035006 File Offset: 0x01033206
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

		// Token: 0x06042A68 RID: 273000 RVA: 0x01035028 File Offset: 0x01033228
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

		// Token: 0x06042A69 RID: 273001 RVA: 0x01035080 File Offset: 0x01033280
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

		// Token: 0x06042A6A RID: 273002 RVA: 0x0103510C File Offset: 0x0103330C
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

		// Token: 0x06042A6B RID: 273003 RVA: 0x01035143 File Offset: 0x01033343
		private void OnSelectionChanged()
		{
			this.RefreshOptionButtons();
		}

		// Token: 0x06042A6C RID: 273004 RVA: 0x0103514B File Offset: 0x0103334B
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RefreshOptionButtons();
		}

		// Token: 0x06042A6D RID: 273005 RVA: 0x01035153 File Offset: 0x01033353
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

		// Token: 0x04022B53 RID: 142163
		[Nullable(1)]
		private readonly ActivityDangoBrawlData ActData;

		// Token: 0x04022B54 RID: 142164
		private readonly UUIItem ContentOption;

		// Token: 0x04022B55 RID: 142165
		private readonly UUIButtonComponent BtnRevert;

		// Token: 0x04022B56 RID: 142166
		private readonly UUIButtonComponent BtnSell;

		// Token: 0x04022B57 RID: 142167
		private readonly UUIButtonComponent BtnRotate;

		// Token: 0x04022B58 RID: 142168
		private readonly UUIButtonComponent BtnConfirm;

		// Token: 0x04022B59 RID: 142169
		private readonly UUIText TxtSellNum;

		// Token: 0x04022B5A RID: 142170
		protected UiSequencePlayer BtnConfimSequencePlayer;
	}
}
