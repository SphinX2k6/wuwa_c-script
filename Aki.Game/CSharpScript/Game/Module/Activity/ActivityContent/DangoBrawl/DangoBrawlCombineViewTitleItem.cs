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
	// Token: 0x02005740 RID: 22336
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlCombineViewTitleItem : UiPanelBase
	{
		// Token: 0x0603701B RID: 225307 RVA: 0x00F59E40 File Offset: 0x00F58040
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

		// Token: 0x0603701C RID: 225308 RVA: 0x00F59ECA File Offset: 0x00F580CA
		protected override void OnStart()
		{
			this.ListLoopScroll = new LoopScrollView<DangoBrawlCombineViewListItem, DangoBrawlCombineViewListItemData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<DangoBrawlCombineViewListItem>(this.CreateListItem), true);
		}

		// Token: 0x0603701D RID: 225309 RVA: 0x00F59EFC File Offset: 0x00F580FC
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

		// Token: 0x0603701E RID: 225310 RVA: 0x00F59F47 File Offset: 0x00F58147
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

		// Token: 0x0603701F RID: 225311 RVA: 0x00F59F78 File Offset: 0x00F58178
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

		// Token: 0x06037020 RID: 225312 RVA: 0x00F59FD8 File Offset: 0x00F581D8
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

		// Token: 0x06037021 RID: 225313 RVA: 0x00F5A06F File Offset: 0x00F5826F
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

		// Token: 0x0401D1C7 RID: 119239
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlCombineViewListItem, DangoBrawlCombineViewListItemData> ListLoopScroll;

		// Token: 0x0401D1C8 RID: 119240
		private float OriginalScrollHeight;

		// Token: 0x0401D1C9 RID: 119241
		private bool HasOriginalScrollHeight;

		// Token: 0x0401D1CA RID: 119242
		public Action<DangoBrawlCombineRowData> OnCombineClick;

		// Token: 0x0401D1CB RID: 119243
		public Action<int, UUIItem> OnGridClick;

		// Token: 0x0401D1CC RID: 119244
		public Func<int, bool> IsGridSelected;

		// Token: 0x0200B2FD RID: 45821
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x040374C5 RID: 226501
			TxtTitle,
			// Token: 0x040374C6 RID: 226502
			ListLoopScroll,
			// Token: 0x040374C7 RID: 226503
			ListItem
		}
	}
}
