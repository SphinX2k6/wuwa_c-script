using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006563 RID: 25955
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossEntranceView : UiViewBase
	{
		// Token: 0x060410B5 RID: 266421 RVA: 0x00FC3991 File Offset: 0x00FC1B91
		public LineCrossEntranceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060410B6 RID: 266422 RVA: 0x00FC399C File Offset: 0x00FC1B9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060410B7 RID: 266423 RVA: 0x00FC3A28 File Offset: 0x00FC1C28
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossEntranceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossEntranceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060410B8 RID: 266424 RVA: 0x00FC3A6B File Offset: 0x00FC1C6B
		private LineCrossItem CreateItem()
		{
			return new LineCrossItem();
		}

		// Token: 0x060410B9 RID: 266425 RVA: 0x00FC3A72 File Offset: 0x00FC1C72
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060410BA RID: 266426 RVA: 0x00FC3A7B File Offset: 0x00FC1C7B
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x060410BB RID: 266427 RVA: 0x00FC3A83 File Offset: 0x00FC1C83
		private void RefreshView()
		{
			this.RefreshScroller();
		}

		// Token: 0x060410BC RID: 266428 RVA: 0x00FC3A8C File Offset: 0x00FC1C8C
		private UniTask RefreshScroller()
		{
			LineCrossEntranceView.<RefreshScroller>d__10 <RefreshScroller>d__;
			<RefreshScroller>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshScroller>d__.<>4__this = this;
			<RefreshScroller>d__.<>1__state = -1;
			<RefreshScroller>d__.<>t__builder.Start<LineCrossEntranceView.<RefreshScroller>d__10>(ref <RefreshScroller>d__);
			return <RefreshScroller>d__.<>t__builder.Task;
		}

		// Token: 0x060410BD RID: 266429 RVA: 0x00FC3ACF File Offset: 0x00FC1CCF
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LineCrossActivityData.Id);
		}

		// Token: 0x060410BE RID: 266430 RVA: 0x00FC3AEC File Offset: 0x00FC1CEC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "FirstLevel"))
			{
				return null;
			}
			GenericScrollViewNew<LineCrossItem, ItemData> scrollView = this.ScrollView;
			UUIItem uuiitem = (scrollView != null) ? scrollView.GetItemByIndex(0) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04021E7A RID: 138874
		private LineCrossActivityData LineCrossActivityData;

		// Token: 0x04021E7B RID: 138875
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021E7C RID: 138876
		protected GenericScrollViewNew<LineCrossItem, ItemData> ScrollView;

		// Token: 0x0200C759 RID: 51033
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403C3A7 RID: 246695
			public const int CaptionItem = 0;

			// Token: 0x0403C3A8 RID: 246696
			public const int Scroller = 1;

			// Token: 0x0403C3A9 RID: 246697
			public const int Item = 2;
		}
	}
}
