using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004651 RID: 18001
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeBigItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E784 RID: 190340 RVA: 0x00ABC4E4 File Offset: 0x00ABA6E4
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E785 RID: 190341 RVA: 0x00ABC4ED File Offset: 0x00ABA6ED
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602E786 RID: 190342 RVA: 0x00ABC4F8 File Offset: 0x00ABA6F8
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

		// Token: 0x0602E787 RID: 190343 RVA: 0x00ABC604 File Offset: 0x00ABA804
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E788 RID: 190344 RVA: 0x00ABC630 File Offset: 0x00ABA830
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E789 RID: 190345 RVA: 0x00ABC632 File Offset: 0x00ABA832
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E78A RID: 190346 RVA: 0x00ABC634 File Offset: 0x00ABA834
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x0602E78B RID: 190347 RVA: 0x00ABC638 File Offset: 0x00ABA838
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x0200A8B6 RID: 43190
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335BC RID: 210364
			public const int Mask = 0;

			// Token: 0x040335BD RID: 210365
			public const int Content = 1;

			// Token: 0x040335BE RID: 210366
			public const int BackBtn = 2;

			// Token: 0x040335BF RID: 210367
			public const int CostContent = 3;
		}
	}
}
