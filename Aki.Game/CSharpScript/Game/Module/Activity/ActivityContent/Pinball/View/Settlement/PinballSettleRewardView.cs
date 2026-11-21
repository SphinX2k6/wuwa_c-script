using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005278 RID: 21112
	public class PinballSettleRewardView : UiPanelBase
	{
		// Token: 0x06034905 RID: 215301 RVA: 0x00EB4E4C File Offset: 0x00EB304C
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

		// Token: 0x06034906 RID: 215302 RVA: 0x00EB4EB5 File Offset: 0x00EB30B5
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06034907 RID: 215303 RVA: 0x00EB4EBC File Offset: 0x00EB30BC
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

		// Token: 0x06034908 RID: 215304 RVA: 0x00EB4EFC File Offset: 0x00EB30FC
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

		// Token: 0x0401BDC6 RID: 114118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0200AEDB RID: 44763
		private enum EComponent
		{
			// Token: 0x04036067 RID: 221287
			TextRewardGot,
			// Token: 0x04036068 RID: 221288
			ScrollReward
		}
	}
}
