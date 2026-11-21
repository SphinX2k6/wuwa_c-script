using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E85 RID: 16005
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleTopPanel : UiPanelBase
	{
		// Token: 0x06028A7B RID: 166523 RVA: 0x00B699DC File Offset: 0x00B67BDC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.BackBtn)),
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.TabBtn)),
				new ValueTuple<int, Delegate>(4, new Action(this.TotalInfoBtn))
			};
		}

		// Token: 0x06028A7C RID: 166524 RVA: 0x00B69AE1 File Offset: 0x00B67CE1
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseBtnActive(false);
			this.PopupCaptionItem.SetHelpBtnActive(false);
		}

		// Token: 0x06028A7D RID: 166525 RVA: 0x00B69B0D File Offset: 0x00B67D0D
		protected override void OnBeforeShow()
		{
			this.RefreshTabBtn();
		}

		// Token: 0x06028A7E RID: 166526 RVA: 0x00B69B18 File Offset: 0x00B67D18
		public void RefreshTabBtn()
		{
			EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x06028A7F RID: 166527 RVA: 0x00B69B4C File Offset: 0x00B67D4C
		protected override void OnBeforeDestroy()
		{
			this.CloseCallback = null;
		}

		// Token: 0x06028A80 RID: 166528 RVA: 0x00B69B55 File Offset: 0x00B67D55
		[NullableContext(1)]
		public void RefreshSelectTipsText(string selectTipsText, bool isUseTypeB = false, params object[] args)
		{
			if (isUseTypeB)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), selectTipsText, args);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), selectTipsText, args);
		}

		// Token: 0x06028A81 RID: 166529 RVA: 0x00B69B81 File Offset: 0x00B67D81
		public void EmptySelectTipsText()
		{
			base.GetText(5).SetText(string.Empty, true);
		}

		// Token: 0x06028A82 RID: 166530 RVA: 0x00B69B95 File Offset: 0x00B67D95
		private void BackBtn()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06028A83 RID: 166531 RVA: 0x00B69BA7 File Offset: 0x00B67DA7
		private void TabBtn(EToggleState state)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06028A84 RID: 166532 RVA: 0x00B69BB4 File Offset: 0x00B67DB4
		public UUIItem GetCostItemByIndex(int index)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			List<CommonCurrencyItem> list = (popupCaptionItem != null) ? popupCaptionItem.GetCurrencyItemList() : null;
			if (list != null && list.Count > index)
			{
				return list[index].GetRootItem();
			}
			return null;
		}

		// Token: 0x06028A85 RID: 166533 RVA: 0x00B69BF0 File Offset: 0x00B67DF0
		public void SetCloseBtnActive(bool isActive)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem != null)
			{
				popupCaptionItem.SetCloseBtnActive(isActive);
			}
			base.GetButton(1).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x06028A86 RID: 166534 RVA: 0x00B69C29 File Offset: 0x00B67E29
		private void TotalInfoBtn()
		{
			Action clickDetailCallback = this.ClickDetailCallback;
			if (clickDetailCallback == null)
			{
				return;
			}
			clickDetailCallback();
		}

		// Token: 0x040161E4 RID: 90596
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x040161E5 RID: 90597
		public Action CloseCallback;

		// Token: 0x040161E6 RID: 90598
		public Action ClickDetailCallback;
	}
}
