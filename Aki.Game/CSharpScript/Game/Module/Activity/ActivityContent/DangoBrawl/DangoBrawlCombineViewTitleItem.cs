using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F0 RID: 26608
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlCombineViewTitleItem : UiPanelBase
	{
		// Token: 0x060424C6 RID: 271558 RVA: 0x010189B0 File Offset: 0x01016BB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060424C7 RID: 271559 RVA: 0x01018A3A File Offset: 0x01016C3A
		protected override void OnStart()
		{
			this.ListLoopScroll = new LoopScrollView<DangoBrawlCombineViewListItem, DangoBrawlCombineViewListItemData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<DangoBrawlCombineViewListItem>(this.CreateListItem), true);
		}

		// Token: 0x060424C8 RID: 271560 RVA: 0x01018A6C File Offset: 0x01016C6C
		[NullableContext(1)]
		public UniTask RefreshAsync(DangoBrawlCombineViewTitleData data)
		{
			DangoBrawlCombineViewTitleItem.<RefreshAsync>d__9 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DangoBrawlCombineViewTitleItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060424C9 RID: 271561 RVA: 0x01018AB7 File Offset: 0x01016CB7
		public UUIItem GetFirstNavigationItem()
		{
			if (this.ListLoopScroll == null)
			{
				return null;
			}
			this.ListLoopScroll.ScrollToGridIndex(0, false);
			DangoBrawlCombineViewListItem dangoBrawlCombineViewListItem = this.ListLoopScroll.UnsafeGetGridProxy(0, false);
			if (dangoBrawlCombineViewListItem == null)
			{
				return null;
			}
			return dangoBrawlCombineViewListItem.GetRootItem();
		}

		// Token: 0x060424CA RID: 271562 RVA: 0x01018AE8 File Offset: 0x01016CE8
		public void RefreshGridSelection()
		{
			if (this.ListLoopScroll == null)
			{
				return;
			}
			int displayGridStartIndex = this.ListLoopScroll.GetDisplayGridStartIndex();
			int displayGridNum = this.ListLoopScroll.GetDisplayGridNum();
			if (displayGridStartIndex < 0 || displayGridNum <= 0)
			{
				return;
			}
			for (int i = displayGridStartIndex; i < displayGridStartIndex + displayGridNum; i++)
			{
				DangoBrawlCombineViewListItem dangoBrawlCombineViewListItem = this.ListLoopScroll.UnsafeGetGridProxy(i, false);
				if (dangoBrawlCombineViewListItem != null)
				{
					dangoBrawlCombineViewListItem.RefreshGridSelection();
				}
			}
		}

		// Token: 0x060424CB RID: 271563 RVA: 0x01018B48 File Offset: 0x01016D48
		[NullableContext(1)]
		private void ApplyLoopScrollHeight(DangoBrawlCombineViewTitleData data)
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
			UUIItem uuiitem = (loopScrollViewComponent != null) ? loopScrollViewComponent.RootUIComp.Get() : null;
			if (uuiitem == null)
			{
				return;
			}
			if (!this.HasOriginalScrollHeight)
			{
				this.OriginalScrollHeight = uuiitem.GetHeight();
				this.HasOriginalScrollHeight = true;
			}
			int count = data.RowDataList.Count;
			int loopItemInterval = data.LoopItemInterval;
			int loopLimitNum = data.LoopLimitNum;
			bool flag = loopLimitNum > 0 && count > loopLimitNum;
			float num = this.OriginalScrollHeight * (float)count + (float)((count - 1) * loopItemInterval);
			uuiitem.SetHeight(flag ? ((float)data.LoopMaxHeight) : num);
		}

		// Token: 0x060424CC RID: 271564 RVA: 0x01018BDF File Offset: 0x01016DDF
		[NullableContext(1)]
		private DangoBrawlCombineViewListItem CreateListItem()
		{
			return new DangoBrawlCombineViewListItem
			{
				OnCombineClick = this.OnCombineClick,
				OnGridClick = this.OnGridClick,
				IsGridSelected = this.IsGridSelected
			};
		}

		// Token: 0x0402296A RID: 141674
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlCombineViewListItem, DangoBrawlCombineViewListItemData> ListLoopScroll;

		// Token: 0x0402296B RID: 141675
		private float OriginalScrollHeight;

		// Token: 0x0402296C RID: 141676
		private bool HasOriginalScrollHeight;

		// Token: 0x0402296D RID: 141677
		public Action<DangoBrawlCombineRowData> OnCombineClick;

		// Token: 0x0402296E RID: 141678
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x0402296F RID: 141679
		public Func<int, bool> IsGridSelected;

		// Token: 0x0200C930 RID: 51504
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x0403CBD5 RID: 248789
			TxtTitle,
			// Token: 0x0403CBD6 RID: 248790
			ListLoopScroll,
			// Token: 0x0403CBD7 RID: 248791
			ListItem
		}
	}
}
