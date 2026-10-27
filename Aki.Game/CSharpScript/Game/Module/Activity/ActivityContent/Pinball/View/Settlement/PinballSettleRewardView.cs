using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062FA RID: 25338
	public class PinballSettleRewardView : UiPanelBase
	{
		// Token: 0x0603FC44 RID: 261188 RVA: 0x00F6DEF0 File Offset: 0x00F6C0F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FC45 RID: 261189 RVA: 0x00F6DF59 File Offset: 0x00F6C159
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603FC46 RID: 261190 RVA: 0x00F6DF60 File Offset: 0x00F6C160
		public void ShowRewardGot()
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0603FC47 RID: 261191 RVA: 0x00F6DFA0 File Offset: 0x00F6C1A0
		[NullableContext(1)]
		public void ShowRewardList(List<TItem> items)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(true);
			}
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(1), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
			this.RewardScroll.RefreshByData(items, null, false);
		}

		// Token: 0x04021497 RID: 136343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0200C4F4 RID: 50420
		private enum EComponent
		{
			// Token: 0x0403B705 RID: 243461
			TextRewardGot,
			// Token: 0x0403B706 RID: 243462
			ScrollReward
		}
	}
}
