using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004653 RID: 18003
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeMiddleItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E797 RID: 190359 RVA: 0x00ABC7FE File Offset: 0x00ABA9FE
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E798 RID: 190360 RVA: 0x00ABC807 File Offset: 0x00ABAA07
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602E799 RID: 190361 RVA: 0x00ABC810 File Offset: 0x00ABAA10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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

		// Token: 0x0602E79A RID: 190362 RVA: 0x00ABC93C File Offset: 0x00ABAB3C
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E79B RID: 190363 RVA: 0x00ABC968 File Offset: 0x00ABAB68
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E79C RID: 190364 RVA: 0x00ABC96A File Offset: 0x00ABAB6A
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E79D RID: 190365 RVA: 0x00ABC96C File Offset: 0x00ABAB6C
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
		}

		// Token: 0x0602E79E RID: 190366 RVA: 0x00ABC984 File Offset: 0x00ABAB84
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x0200A8B8 RID: 43192
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335C4 RID: 210372
			public const int Mask = 0;

			// Token: 0x040335C5 RID: 210373
			public const int Content = 1;

			// Token: 0x040335C6 RID: 210374
			public const int BackBtn = 2;

			// Token: 0x040335C7 RID: 210375
			public const int CostContent = 3;

			// Token: 0x040335C8 RID: 210376
			public const int TxtTitle = 4;
		}
	}
}
