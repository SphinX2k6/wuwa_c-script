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
	// Token: 0x020054E1 RID: 21729
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossEntranceView : UiViewBase
	{
		// Token: 0x06035D7A RID: 220538 RVA: 0x00F0A975 File Offset: 0x00F08B75
		public LineCrossEntranceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035D7B RID: 220539 RVA: 0x00F0A980 File Offset: 0x00F08B80
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

		// Token: 0x06035D7C RID: 220540 RVA: 0x00F0AA0C File Offset: 0x00F08C0C
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossEntranceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossEntranceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D7D RID: 220541 RVA: 0x00F0AA4F File Offset: 0x00F08C4F
		private LineCrossItem CreateItem()
		{
			return new LineCrossItem();
		}

		// Token: 0x06035D7E RID: 220542 RVA: 0x00F0AA56 File Offset: 0x00F08C56
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035D7F RID: 220543 RVA: 0x00F0AA5F File Offset: 0x00F08C5F
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06035D80 RID: 220544 RVA: 0x00F0AA67 File Offset: 0x00F08C67
		private void RefreshView()
		{
			this.RefreshScroller();
		}

		// Token: 0x06035D81 RID: 220545 RVA: 0x00F0AA70 File Offset: 0x00F08C70
		private UniTask RefreshScroller()
		{
			LineCrossEntranceView.<RefreshScroller>d__10 <RefreshScroller>d__;
			<RefreshScroller>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshScroller>d__.<>4__this = this;
			<RefreshScroller>d__.<>1__state = -1;
			<RefreshScroller>d__.<>t__builder.Start<LineCrossEntranceView.<RefreshScroller>d__10>(ref <RefreshScroller>d__);
			return <RefreshScroller>d__.<>t__builder.Task;
		}

		// Token: 0x06035D82 RID: 220546 RVA: 0x00F0AAB3 File Offset: 0x00F08CB3
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LineCrossActivityData.Id);
		}

		// Token: 0x06035D83 RID: 220547 RVA: 0x00F0AAD0 File Offset: 0x00F08CD0
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

		// Token: 0x0401C7AB RID: 116651
		private LineCrossActivityData LineCrossActivityData;

		// Token: 0x0401C7AC RID: 116652
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C7AD RID: 116653
		protected GenericScrollViewNew<LineCrossItem, ItemData> ScrollView;

		// Token: 0x0200B13E RID: 45374
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036CF9 RID: 224505
			public const int CaptionItem = 0;

			// Token: 0x04036CFA RID: 224506
			public const int Scroller = 1;

			// Token: 0x04036CFB RID: 224507
			public const int Item = 2;
		}
	}
}
