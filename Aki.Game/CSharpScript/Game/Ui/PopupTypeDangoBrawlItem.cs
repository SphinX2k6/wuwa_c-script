using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200353E RID: 13630
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeDangoBrawlItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022ABA RID: 142010 RVA: 0x009DDA75 File Offset: 0x009DBC75
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022ABB RID: 142011 RVA: 0x009DDA7E File Offset: 0x009DBC7E
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x06022ABC RID: 142012 RVA: 0x009DDA88 File Offset: 0x009DBC88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickMaskButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(base.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022ABD RID: 142013 RVA: 0x009DDBD8 File Offset: 0x009DBDD8
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022ABE RID: 142014 RVA: 0x009DDC04 File Offset: 0x009DBE04
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022ABF RID: 142015 RVA: 0x009DDC06 File Offset: 0x009DBE06
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022AC0 RID: 142016 RVA: 0x009DDC08 File Offset: 0x009DBE08
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			base.GetText(4).SetUIActive(!StringUtils.IsBlank(textId));
			base.GetText(5).SetUIActive(!StringUtils.IsBlank(textId));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, args);
		}

		// Token: 0x06022AC1 RID: 142017 RVA: 0x009DDC68 File Offset: 0x009DBE68
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			foreach (CommonCurrencyItem commonCurrencyItem in commonCurrencyItemList)
			{
				if (commonCurrencyItem != null)
				{
					UUIItem rootItem = commonCurrencyItem.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetUIParent(base.GetItem(3), false);
					}
				}
			}
		}

		// Token: 0x06022AC2 RID: 142018 RVA: 0x009DDCA6 File Offset: 0x009DBEA6
		protected override void OnBeforeShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(true, "PopupTypeDangoBrawlItem");
		}

		// Token: 0x06022AC3 RID: 142019 RVA: 0x009DDCC3 File Offset: 0x009DBEC3
		protected override void OnBeforeHide()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(false, "PopupTypeDangoBrawlItem");
		}

		// Token: 0x02009205 RID: 37381
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DB4D RID: 187213
			public const int Mask = 0;

			// Token: 0x0402DB4E RID: 187214
			public const int Content = 1;

			// Token: 0x0402DB4F RID: 187215
			public const int BackBtn = 2;

			// Token: 0x0402DB50 RID: 187216
			public const int CostContent = 3;

			// Token: 0x0402DB51 RID: 187217
			public const int TxtTitle = 4;

			// Token: 0x0402DB52 RID: 187218
			public const int TxtExtraTitle = 5;
		}
	}
}
