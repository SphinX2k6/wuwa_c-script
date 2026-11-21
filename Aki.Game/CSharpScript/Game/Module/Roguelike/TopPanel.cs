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
	// Token: 0x02003E0F RID: 15887
	[NullableContext(2)]
	[Nullable(0)]
	public class TopPanel : UiPanelBase
	{
		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x060288F2 RID: 166130 RVA: 0x00B6167B File Offset: 0x00B5F87B
		// (set) Token: 0x060288F3 RID: 166131 RVA: 0x00B61683 File Offset: 0x00B5F883
		public Action CloseCallback { get; set; }

		// Token: 0x060288F4 RID: 166132 RVA: 0x00B6168C File Offset: 0x00B5F88C
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

		// Token: 0x060288F5 RID: 166133 RVA: 0x00B61811 File Offset: 0x00B5FA11
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseBtnActive(false);
			this.PopupCaptionItem.SetHelpBtnActive(false);
		}

		// Token: 0x060288F6 RID: 166134 RVA: 0x00B6183D File Offset: 0x00B5FA3D
		protected override void OnBeforeShow()
		{
			this.RefreshTabBtn();
		}

		// Token: 0x060288F7 RID: 166135 RVA: 0x00B61848 File Offset: 0x00B5FA48
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

		// Token: 0x060288F8 RID: 166136 RVA: 0x00B6187C File Offset: 0x00B5FA7C
		protected override void OnBeforeDestroy()
		{
			this.CloseCallback = null;
		}

		// Token: 0x060288F9 RID: 166137 RVA: 0x00B61885 File Offset: 0x00B5FA85
		[NullableContext(1)]
		public void RefreshTitle(string titleText)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArgNew(titleText, Array.Empty<object>());
		}

		// Token: 0x060288FA RID: 166138 RVA: 0x00B61898 File Offset: 0x00B5FA98
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

		// Token: 0x060288FB RID: 166139 RVA: 0x00B618E3 File Offset: 0x00B5FAE3
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

		// Token: 0x060288FC RID: 166140 RVA: 0x00B6190F File Offset: 0x00B5FB0F
		public void EmptySelectTipsText()
		{
			base.GetText(5).SetText("", true);
		}

		// Token: 0x060288FD RID: 166141 RVA: 0x00B61923 File Offset: 0x00B5FB23
		private void BackBtn()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x060288FE RID: 166142 RVA: 0x00B61938 File Offset: 0x00B5FB38
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

		// Token: 0x04016010 RID: 90128
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x04016012 RID: 90130
		[Nullable(1)]
		private readonly Action<EToggleState> TabBtn = delegate(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		};

		// Token: 0x04016013 RID: 90131
		[Nullable(1)]
		private readonly Action TotalInfoBtn = delegate()
		{
			RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
		};

		// Token: 0x02009A36 RID: 39478
		[NullableContext(0)]
		private class ETopPanelCom
		{
			// Token: 0x04030140 RID: 196928
			public const int PopupCaptionItem = 0;

			// Token: 0x04030141 RID: 196929
			public const int BackBtn = 1;

			// Token: 0x04030142 RID: 196930
			public const int TabToggle = 2;

			// Token: 0x04030143 RID: 196931
			public const int DescText = 3;

			// Token: 0x04030144 RID: 196932
			public const int TotalInfoBtn = 4;

			// Token: 0x04030145 RID: 196933
			public const int SelectTipsText = 5;

			// Token: 0x04030146 RID: 196934
			public const int SelectTipsText2 = 6;
		}
	}
}
