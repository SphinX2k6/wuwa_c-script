using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003582 RID: 13698
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeBigItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022ECE RID: 143054 RVA: 0x009E9B14 File Offset: 0x009E7D14
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022ECF RID: 143055 RVA: 0x009E9B1D File Offset: 0x009E7D1D
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x06022ED0 RID: 143056 RVA: 0x009E9B28 File Offset: 0x009E7D28
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

		// Token: 0x06022ED1 RID: 143057 RVA: 0x009E9C34 File Offset: 0x009E7E34
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022ED2 RID: 143058 RVA: 0x009E9C60 File Offset: 0x009E7E60
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022ED3 RID: 143059 RVA: 0x009E9C62 File Offset: 0x009E7E62
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022ED4 RID: 143060 RVA: 0x009E9C64 File Offset: 0x009E7E64
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x06022ED5 RID: 143061 RVA: 0x009E9C68 File Offset: 0x009E7E68
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x02009272 RID: 37490
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD52 RID: 187730
			public const int Mask = 0;

			// Token: 0x0402DD53 RID: 187731
			public const int Content = 1;

			// Token: 0x0402DD54 RID: 187732
			public const int BackBtn = 2;

			// Token: 0x0402DD55 RID: 187733
			public const int CostContent = 3;
		}
	}
}
