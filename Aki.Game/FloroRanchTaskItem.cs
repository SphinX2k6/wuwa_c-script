using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001BA0 RID: 7072
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchTaskItem : GridProxyAbstract<FloroRanchTaskData>
{
	// Token: 0x0600D291 RID: 53905 RVA: 0x003061A8 File Offset: 0x003043A8
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

	// Token: 0x0600D292 RID: 53906 RVA: 0x00306353 File Offset: 0x00304553
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x0600D293 RID: 53907 RVA: 0x00306376 File Offset: 0x00304576
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600D294 RID: 53908 RVA: 0x00306380 File Offset: 0x00304580
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

	// Token: 0x0600D295 RID: 53909 RVA: 0x003064A6 File Offset: 0x003046A6
	private void OnJumpBtnClick()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x04006088 RID: 24712
	[Nullable(2)]
	private FloroRanchTaskData Data;

	// Token: 0x04006089 RID: 24713
	public Action OnGetBtnClick = delegate()
	{
	};

	// Token: 0x0400608A RID: 24714
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x0200813B RID: 33083
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A2EC RID: 172780
		public const int TextName = 0;

		// Token: 0x0402A2ED RID: 172781
		public const int TextProgress = 1;

		// Token: 0x0402A2EE RID: 172782
		public const int ScrollReward = 2;

		// Token: 0x0402A2EF RID: 172783
		public const int ItemReward = 3;

		// Token: 0x0402A2F0 RID: 172784
		public const int ButtonGet = 4;

		// Token: 0x0402A2F1 RID: 172785
		public const int TextDoing = 5;

		// Token: 0x0402A2F2 RID: 172786
		public const int SpriteFinish = 6;

		// Token: 0x0402A2F3 RID: 172787
		public const int ItemRedDot = 7;

		// Token: 0x0402A2F4 RID: 172788
		public const int ButtonJump = 8;
	}
}
