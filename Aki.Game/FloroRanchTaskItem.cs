using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200105F RID: 4191
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchTaskItem : GridProxyAbstract<FloroRanchTaskData>
{
	// Token: 0x0600A6A2 RID: 42658 RVA: 0x00311288 File Offset: 0x0030F488
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, this.OnGetBtnClick);
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnJumpBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A6A3 RID: 42659 RVA: 0x00311433 File Offset: 0x0030F633
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x0600A6A4 RID: 42660 RVA: 0x00311456 File Offset: 0x0030F656
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600A6A5 RID: 42661 RVA: 0x00311460 File Offset: 0x0030F660
	public override void Refresh(FloroRanchTaskData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RewardScroll.RefreshByData(data.RewardList, delegate
		{
			this.RewardScroll.ScrollToLeft(0);
		}, false);
		bool uiactive = data.Status == EActivityTaskState.FinishedAndClaimed;
		bool uiactive2 = data.Status == EActivityTaskState.FinishedAndUnclaimed;
		bool flag = data.Status == EActivityTaskState.Active;
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetItem(7).SetUIActive(uiactive2);
		base.GetSprite(6).SetUIActive(uiactive);
		base.GetText(5).SetUIActive(flag && data.JumpId == 0);
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && data.JumpId > 0);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TaskName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BlackCoastTheme_TaskProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x0600A6A6 RID: 42662 RVA: 0x00311586 File Offset: 0x0030F786
	private void OnJumpBtnClick()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x04006157 RID: 24919
	[Nullable(2)]
	private FloroRanchTaskData Data;

	// Token: 0x04006158 RID: 24920
	public Action OnGetBtnClick = delegate()
	{
	};

	// Token: 0x04006159 RID: 24921
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x020072C9 RID: 29385
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025620 RID: 153120
		public const int TextName = 0;

		// Token: 0x04025621 RID: 153121
		public const int TextProgress = 1;

		// Token: 0x04025622 RID: 153122
		public const int ScrollReward = 2;

		// Token: 0x04025623 RID: 153123
		public const int ItemReward = 3;

		// Token: 0x04025624 RID: 153124
		public const int ButtonGet = 4;

		// Token: 0x04025625 RID: 153125
		public const int TextDoing = 5;

		// Token: 0x04025626 RID: 153126
		public const int SpriteFinish = 6;

		// Token: 0x04025627 RID: 153127
		public const int ItemRedDot = 7;

		// Token: 0x04025628 RID: 153128
		public const int ButtonJump = 8;
	}
}
