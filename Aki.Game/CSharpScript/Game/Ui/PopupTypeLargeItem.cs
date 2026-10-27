using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004652 RID: 18002
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeLargeItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E78D RID: 190349 RVA: 0x00ABC672 File Offset: 0x00ABA872
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E78E RID: 190350 RVA: 0x00ABC67B File Offset: 0x00ABA87B
		public override UUIItem GetCostParent()
		{
			return base.GetItem(2);
		}

		// Token: 0x0602E78F RID: 190351 RVA: 0x00ABC684 File Offset: 0x00ABA884
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

		// Token: 0x0602E790 RID: 190352 RVA: 0x00ABC76C File Offset: 0x00ABA96C
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(3));
			this.PopupCaptionItem.SetCloseCallBack(new Action(base.TryHideSelf));
		}

		// Token: 0x0602E791 RID: 190353 RVA: 0x00ABC797 File Offset: 0x00ABA997
		public override void OnSetHelpButtonActive(bool state)
		{
			this.PopupCaptionItem.SetHelpBtnActive(state);
		}

		// Token: 0x0602E792 RID: 190354 RVA: 0x00ABC7A5 File Offset: 0x00ABA9A5
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x0602E793 RID: 190355 RVA: 0x00ABC7B4 File Offset: 0x00ABA9B4
		public override void OnSetBackBtnShowState(bool state)
		{
			this.PopupCaptionItem.SetCloseBtnActive(state);
		}

		// Token: 0x0602E794 RID: 190356 RVA: 0x00ABC7C2 File Offset: 0x00ABA9C2
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E795 RID: 190357 RVA: 0x00ABC7C4 File Offset: 0x00ABA9C4
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			for (int i = 0; i < commonCurrencyItemList.Length; i++)
			{
				commonCurrencyItemList[i].GetRootItem().SetUIParent(base.GetItem(2), false);
			}
		}

		// Token: 0x04018E30 RID: 101936
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0200A8B7 RID: 43191
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335C0 RID: 210368
			public const int Mask = 0;

			// Token: 0x040335C1 RID: 210369
			public const int Content = 1;

			// Token: 0x040335C2 RID: 210370
			public const int CostContent = 2;

			// Token: 0x040335C3 RID: 210371
			public const int CaptionItem = 3;
		}
	}
}
