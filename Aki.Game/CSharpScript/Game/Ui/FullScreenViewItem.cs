using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200357C RID: 13692
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenViewItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022E62 RID: 142946 RVA: 0x009E8698 File Offset: 0x009E6898
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06022E63 RID: 142947 RVA: 0x009E8701 File Offset: 0x009E6901
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseCallBack(new Action(base.TryHideSelf));
		}

		// Token: 0x06022E64 RID: 142948 RVA: 0x009E872C File Offset: 0x009E692C
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022E65 RID: 142949 RVA: 0x009E8735 File Offset: 0x009E6935
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			this.PopupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x06022E66 RID: 142950 RVA: 0x009E8743 File Offset: 0x009E6943
		public void SetCaptionTitleVisible(bool bVisible)
		{
			this.PopupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x06022E67 RID: 142951 RVA: 0x009E8751 File Offset: 0x009E6951
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x06022E68 RID: 142952 RVA: 0x009E8760 File Offset: 0x009E6960
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022E69 RID: 142953 RVA: 0x009E8762 File Offset: 0x009E6962
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022E6A RID: 142954 RVA: 0x009E8764 File Offset: 0x009E6964
		public override void OnSetBackBtnShowState(bool state)
		{
		}

		// Token: 0x06022E6B RID: 142955 RVA: 0x009E8766 File Offset: 0x009E6966
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x0401347B RID: 78971
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x02009262 RID: 37474
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD14 RID: 187668
			public const int CaptionItem = 0;

			// Token: 0x0402DD15 RID: 187669
			public const int ContentItem = 1;
		}
	}
}
