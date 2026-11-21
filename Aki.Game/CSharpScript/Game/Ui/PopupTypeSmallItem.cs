using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003586 RID: 13702
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeSmallItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022EF6 RID: 143094 RVA: 0x009EA17F File Offset: 0x009E837F
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022EF7 RID: 143095 RVA: 0x009EA188 File Offset: 0x009E8388
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x06022EF8 RID: 143096 RVA: 0x009EA194 File Offset: 0x009E8394
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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

		// Token: 0x06022EF9 RID: 143097 RVA: 0x009EA29F File Offset: 0x009E849F
		public override void OnSetCloseBtnInteractive(bool state)
		{
			base.GetButton(2).SetSelfInteractive(state);
		}

		// Token: 0x06022EFA RID: 143098 RVA: 0x009EA2B0 File Offset: 0x009E84B0
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022EFB RID: 143099 RVA: 0x009EA2DC File Offset: 0x009E84DC
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022EFC RID: 143100 RVA: 0x009EA2DE File Offset: 0x009E84DE
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x06022EFD RID: 143101 RVA: 0x009EA2E0 File Offset: 0x009E84E0
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x02009276 RID: 37494
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD64 RID: 187748
			public const int Mask = 0;

			// Token: 0x0402DD65 RID: 187749
			public const int Content = 1;

			// Token: 0x0402DD66 RID: 187750
			public const int BackBtn = 2;

			// Token: 0x0402DD67 RID: 187751
			public const int CostContent = 3;
		}
	}
}
