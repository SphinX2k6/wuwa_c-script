using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004615 RID: 17941
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeDangoBrawlItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E3C5 RID: 189381 RVA: 0x00AB1381 File Offset: 0x00AAF581
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E3C6 RID: 189382 RVA: 0x00AB138A File Offset: 0x00AAF58A
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602E3C7 RID: 189383 RVA: 0x00AB1394 File Offset: 0x00AAF594
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

		// Token: 0x0602E3C8 RID: 189384 RVA: 0x00AB14E4 File Offset: 0x00AAF6E4
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E3C9 RID: 189385 RVA: 0x00AB1510 File Offset: 0x00AAF710
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E3CA RID: 189386 RVA: 0x00AB1512 File Offset: 0x00AAF712
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E3CB RID: 189387 RVA: 0x00AB1514 File Offset: 0x00AAF714
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			base.GetText(4).SetUIActive(!StringUtils.IsBlank(textId));
			base.GetText(5).SetUIActive(!StringUtils.IsBlank(textId));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, args);
		}

		// Token: 0x0602E3CC RID: 189388 RVA: 0x00AB1574 File Offset: 0x00AAF774
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

		// Token: 0x0602E3CD RID: 189389 RVA: 0x00AB15B2 File Offset: 0x00AAF7B2
		protected override void OnBeforeShow()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(true, "PopupTypeDangoBrawlItem");
		}

		// Token: 0x0602E3CE RID: 189390 RVA: 0x00AB15CF File Offset: 0x00AAF7CF
		protected override void OnBeforeHide()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			if (battleManager == null)
			{
				return;
			}
			battleManager.SetIsPauseByView(false, "PopupTypeDangoBrawlItem");
		}

		// Token: 0x0200A84D RID: 43085
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040333BF RID: 209855
			public const int Mask = 0;

			// Token: 0x040333C0 RID: 209856
			public const int Content = 1;

			// Token: 0x040333C1 RID: 209857
			public const int BackBtn = 2;

			// Token: 0x040333C2 RID: 209858
			public const int CostContent = 3;

			// Token: 0x040333C3 RID: 209859
			public const int TxtTitle = 4;

			// Token: 0x040333C4 RID: 209860
			public const int TxtExtraTitle = 5;
		}
	}
}
