using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EBC RID: 20156
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleTopPanel : UiPanelBase
	{
		// Token: 0x06033C10 RID: 211984 RVA: 0x00C204C4 File Offset: 0x00C1E6C4
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

		// Token: 0x06033C11 RID: 211985 RVA: 0x00C205C9 File Offset: 0x00C1E7C9
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseBtnActive(false);
			this.PopupCaptionItem.SetHelpBtnActive(false);
		}

		// Token: 0x06033C12 RID: 211986 RVA: 0x00C205F5 File Offset: 0x00C1E7F5
		protected override void OnBeforeShow()
		{
			this.RefreshTabBtn();
		}

		// Token: 0x06033C13 RID: 211987 RVA: 0x00C20600 File Offset: 0x00C1E800
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

		// Token: 0x06033C14 RID: 211988 RVA: 0x00C20634 File Offset: 0x00C1E834
		protected override void OnBeforeDestroy()
		{
			this.CloseCallback = null;
		}

		// Token: 0x06033C15 RID: 211989 RVA: 0x00C2063D File Offset: 0x00C1E83D
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

		// Token: 0x06033C16 RID: 211990 RVA: 0x00C20669 File Offset: 0x00C1E869
		public void EmptySelectTipsText()
		{
			base.GetText(5).SetText(string.Empty, true);
		}

		// Token: 0x06033C17 RID: 211991 RVA: 0x00C2067D File Offset: 0x00C1E87D
		private void BackBtn()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06033C18 RID: 211992 RVA: 0x00C2068F File Offset: 0x00C1E88F
		private void TabBtn(EToggleState state)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06033C19 RID: 211993 RVA: 0x00C2069C File Offset: 0x00C1E89C
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

		// Token: 0x06033C1A RID: 211994 RVA: 0x00C206D8 File Offset: 0x00C1E8D8
		public void SetCloseBtnActive(bool isActive)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem != null)
			{
				popupCaptionItem.SetCloseBtnActive(isActive);
			}
			base.GetButton(1).RootUIComp.Get().SetUIActive(isActive);
		}

		// Token: 0x06033C1B RID: 211995 RVA: 0x00C20711 File Offset: 0x00C1E911
		private void TotalInfoBtn()
		{
			Action clickDetailCallback = this.ClickDetailCallback;
			if (clickDetailCallback == null)
			{
				return;
			}
			clickDetailCallback();
		}

		// Token: 0x0401B811 RID: 112657
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0401B812 RID: 112658
		public Action CloseCallback;

		// Token: 0x0401B813 RID: 112659
		public Action ClickDetailCallback;
	}
}
