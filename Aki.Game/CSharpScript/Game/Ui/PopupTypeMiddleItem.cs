using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003584 RID: 13700
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeMiddleItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022EE1 RID: 143073 RVA: 0x009E9E2E File Offset: 0x009E802E
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022EE2 RID: 143074 RVA: 0x009E9E37 File Offset: 0x009E8037
		public override UUIItem GetCostParent()
		{
			return base.GetItem(3);
		}

		// Token: 0x06022EE3 RID: 143075 RVA: 0x009E9E40 File Offset: 0x009E8040
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

		// Token: 0x06022EE4 RID: 143076 RVA: 0x009E9F6C File Offset: 0x009E816C
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022EE5 RID: 143077 RVA: 0x009E9F98 File Offset: 0x009E8198
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022EE6 RID: 143078 RVA: 0x009E9F9A File Offset: 0x009E819A
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022EE7 RID: 143079 RVA: 0x009E9F9C File Offset: 0x009E819C
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
		}

		// Token: 0x06022EE8 RID: 143080 RVA: 0x009E9FB4 File Offset: 0x009E81B4
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(3), false);
			}
		}

		// Token: 0x02009274 RID: 37492
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD5A RID: 187738
			public const int Mask = 0;

			// Token: 0x0402DD5B RID: 187739
			public const int Content = 1;

			// Token: 0x0402DD5C RID: 187740
			public const int BackBtn = 2;

			// Token: 0x0402DD5D RID: 187741
			public const int CostContent = 3;

			// Token: 0x0402DD5E RID: 187742
			public const int TxtTitle = 4;
		}
	}
}
