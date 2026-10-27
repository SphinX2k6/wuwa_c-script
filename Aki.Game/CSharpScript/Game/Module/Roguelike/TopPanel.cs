using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E46 RID: 20038
	[NullableContext(2)]
	[Nullable(0)]
	public class TopPanel : UiPanelBase
	{
		// Token: 0x17007ED4 RID: 32468
		// (get) Token: 0x06033A87 RID: 211591 RVA: 0x00C18153 File Offset: 0x00C16353
		// (set) Token: 0x06033A88 RID: 211592 RVA: 0x00C1815B File Offset: 0x00C1635B
		public Action CloseCallback { get; set; }

		// Token: 0x06033A89 RID: 211593 RVA: 0x00C18164 File Offset: 0x00C16364
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.BackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, this.TabBtn);
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, this.TotalInfoBtn);
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033A8A RID: 211594 RVA: 0x00C182E9 File Offset: 0x00C164E9
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseBtnActive(false);
			this.PopupCaptionItem.SetHelpBtnActive(false);
		}

		// Token: 0x06033A8B RID: 211595 RVA: 0x00C18315 File Offset: 0x00C16515
		protected override void OnBeforeShow()
		{
			this.RefreshTabBtn();
		}

		// Token: 0x06033A8C RID: 211596 RVA: 0x00C18320 File Offset: 0x00C16520
		public void RefreshTabBtn()
		{
			EToggleState state = (RoguelikeModel.Instance.GetDescModel() == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, true, false, false);
		}

		// Token: 0x06033A8D RID: 211597 RVA: 0x00C18354 File Offset: 0x00C16554
		protected override void OnBeforeDestroy()
		{
			this.CloseCallback = null;
		}

		// Token: 0x06033A8E RID: 211598 RVA: 0x00C1835D File Offset: 0x00C1655D
		[NullableContext(1)]
		public void RefreshTitle(string titleText)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArgNew(titleText, Array.Empty<object>());
		}

		// Token: 0x06033A8F RID: 211599 RVA: 0x00C18370 File Offset: 0x00C16570
		[NullableContext(1)]
		public UniTask RefreshCurrency(List<int> currencyList)
		{
			TopPanel.<RefreshCurrency>d__12 <RefreshCurrency>d__;
			<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCurrency>d__.<>4__this = this;
			<RefreshCurrency>d__.currencyList = currencyList;
			<RefreshCurrency>d__.<>1__state = -1;
			<RefreshCurrency>d__.<>t__builder.Start<TopPanel.<RefreshCurrency>d__12>(ref <RefreshCurrency>d__);
			return <RefreshCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x06033A90 RID: 211600 RVA: 0x00C183BB File Offset: 0x00C165BB
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

		// Token: 0x06033A91 RID: 211601 RVA: 0x00C183E7 File Offset: 0x00C165E7
		public void EmptySelectTipsText()
		{
			base.GetText(5).SetText("", true);
		}

		// Token: 0x06033A92 RID: 211602 RVA: 0x00C183FB File Offset: 0x00C165FB
		private void BackBtn()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06033A93 RID: 211603 RVA: 0x00C18410 File Offset: 0x00C16610
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

		// Token: 0x0401B63D RID: 112189
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0401B63F RID: 112191
		[Nullable(1)]
		private readonly Action<EToggleState> TabBtn = delegate(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		};

		// Token: 0x0401B640 RID: 112192
		[Nullable(1)]
		private readonly Action TotalInfoBtn = delegate()
		{
			RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
		};

		// Token: 0x0200B004 RID: 45060
		[NullableContext(0)]
		private class ETopPanelCom
		{
			// Token: 0x04035710 RID: 218896
			public const int PopupCaptionItem = 0;

			// Token: 0x04035711 RID: 218897
			public const int BackBtn = 1;

			// Token: 0x04035712 RID: 218898
			public const int TabToggle = 2;

			// Token: 0x04035713 RID: 218899
			public const int DescText = 3;

			// Token: 0x04035714 RID: 218900
			public const int TotalInfoBtn = 4;

			// Token: 0x04035715 RID: 218901
			public const int SelectTipsText = 5;

			// Token: 0x04035716 RID: 218902
			public const int SelectTipsText2 = 6;
		}
	}
}
