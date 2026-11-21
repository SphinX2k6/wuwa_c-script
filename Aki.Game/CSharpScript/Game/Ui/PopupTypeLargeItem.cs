using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003583 RID: 13699
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeLargeItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022ED7 RID: 143063 RVA: 0x009E9CA2 File Offset: 0x009E7EA2
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022ED8 RID: 143064 RVA: 0x009E9CAB File Offset: 0x009E7EAB
		public override UUIItem GetCostParent()
		{
			return base.GetItem(2);
		}

		// Token: 0x06022ED9 RID: 143065 RVA: 0x009E9CB4 File Offset: 0x009E7EB4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022EDA RID: 143066 RVA: 0x009E9D9C File Offset: 0x009E7F9C
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(3));
			this.PopupCaptionItem.SetCloseCallBack(new Action(base.TryHideSelf));
		}

		// Token: 0x06022EDB RID: 143067 RVA: 0x009E9DC7 File Offset: 0x009E7FC7
		public override void OnSetHelpButtonActive(bool state)
		{
			this.PopupCaptionItem.SetHelpBtnActive(state);
		}

		// Token: 0x06022EDC RID: 143068 RVA: 0x009E9DD5 File Offset: 0x009E7FD5
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x06022EDD RID: 143069 RVA: 0x009E9DE4 File Offset: 0x009E7FE4
		public override void OnSetBackBtnShowState(bool state)
		{
			this.PopupCaptionItem.SetCloseBtnActive(state);
		}

		// Token: 0x06022EDE RID: 143070 RVA: 0x009E9DF2 File Offset: 0x009E7FF2
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022EDF RID: 143071 RVA: 0x009E9DF4 File Offset: 0x009E7FF4
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(2), false);
			}
		}

		// Token: 0x04013489 RID: 78985
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x02009273 RID: 37491
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD56 RID: 187734
			public const int Mask = 0;

			// Token: 0x0402DD57 RID: 187735
			public const int Content = 1;

			// Token: 0x0402DD58 RID: 187736
			public const int CostContent = 2;

			// Token: 0x0402DD59 RID: 187737
			public const int CaptionItem = 3;
		}
	}
}
