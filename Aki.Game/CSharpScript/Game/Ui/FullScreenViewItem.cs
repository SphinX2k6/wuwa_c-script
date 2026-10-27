using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200464B RID: 17995
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenViewItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E718 RID: 190232 RVA: 0x00ABB068 File Offset: 0x00AB9268
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

		// Token: 0x0602E719 RID: 190233 RVA: 0x00ABB0D1 File Offset: 0x00AB92D1
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaptionItem.SetCloseCallBack(new Action(base.TryHideSelf));
		}

		// Token: 0x0602E71A RID: 190234 RVA: 0x00ABB0FC File Offset: 0x00AB92FC
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E71B RID: 190235 RVA: 0x00ABB105 File Offset: 0x00AB9305
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			this.PopupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x0602E71C RID: 190236 RVA: 0x00ABB113 File Offset: 0x00AB9313
		public void SetCaptionTitleVisible(bool bVisible)
		{
			this.PopupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x0602E71D RID: 190237 RVA: 0x00ABB121 File Offset: 0x00AB9321
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopupCaptionItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x0602E71E RID: 190238 RVA: 0x00ABB130 File Offset: 0x00AB9330
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E71F RID: 190239 RVA: 0x00ABB132 File Offset: 0x00AB9332
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E720 RID: 190240 RVA: 0x00ABB134 File Offset: 0x00AB9334
		public override void OnSetBackBtnShowState(bool state)
		{
		}

		// Token: 0x0602E721 RID: 190241 RVA: 0x00ABB136 File Offset: 0x00AB9336
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x04018E22 RID: 101922
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0200A8A6 RID: 43174
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403357E RID: 210302
			public const int CaptionItem = 0;

			// Token: 0x0403357F RID: 210303
			public const int ContentItem = 1;
		}
	}
}
