using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004655 RID: 18005
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeSmallItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E7AC RID: 190380 RVA: 0x00ABCB4F File Offset: 0x00ABAD4F
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E7AD RID: 190381 RVA: 0x00ABCB58 File Offset: 0x00ABAD58
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602E7AE RID: 190382 RVA: 0x00ABCB64 File Offset: 0x00ABAD64
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

		// Token: 0x0602E7AF RID: 190383 RVA: 0x00ABCC6F File Offset: 0x00ABAE6F
		public override void OnSetCloseBtnInteractive(bool state)
		{
			base.GetButton(2).SetSelfInteractive(state);
		}

		// Token: 0x0602E7B0 RID: 190384 RVA: 0x00ABCC80 File Offset: 0x00ABAE80
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E7B1 RID: 190385 RVA: 0x00ABCCAC File Offset: 0x00ABAEAC
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E7B2 RID: 190386 RVA: 0x00ABCCAE File Offset: 0x00ABAEAE
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x0602E7B3 RID: 190387 RVA: 0x00ABCCB0 File Offset: 0x00ABAEB0
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x0200A8BA RID: 43194
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335CE RID: 210382
			public const int Mask = 0;

			// Token: 0x040335CF RID: 210383
			public const int Content = 1;

			// Token: 0x040335D0 RID: 210384
			public const int BackBtn = 2;

			// Token: 0x040335D1 RID: 210385
			public const int CostContent = 3;
		}
	}
}
