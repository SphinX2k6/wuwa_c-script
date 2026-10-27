using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001114 RID: 4372
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AvignonTaskItem : GridProxyAbstract<AvignonTaskData>
{
	// Token: 0x06007256 RID: 29270 RVA: 0x00176688 File Offset: 0x00174888
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJump));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007257 RID: 29271 RVA: 0x001767F6 File Offset: 0x001749F6
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06007258 RID: 29272 RVA: 0x00176819 File Offset: 0x00174A19
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007259 RID: 29273 RVA: 0x00176820 File Offset: 0x00174A20
	public override void Refresh(AvignonTaskData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RewardScrollView.RefreshByData(data.RewardList, null, false);
		bool uiactive = data.Status == EActivityTaskState.FinishedAndClaimed;
		bool uiactive2 = data.Status == EActivityTaskState.FinishedAndUnclaimed;
		bool flag = data.Status == EActivityTaskState.Active;
		base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetItem(3).SetUIActive(uiactive);
		base.GetItem(2).SetUIActive(flag && data.JumpId == 0);
		base.GetButton(0).RootUIComp.Get().SetUIActive(flag && data.JumpId > 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TitleTextId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "BlackCoastTheme_TaskProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x0600725A RID: 29274 RVA: 0x00176928 File Offset: 0x00174B28
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x0600725B RID: 29275 RVA: 0x0017693B File Offset: 0x00174B3B
	private void OnClickGetButton()
	{
		Action<int> receiveDelegate = this.Data.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.Data.TaskId);
	}

	// Token: 0x040034F6 RID: 13558
	[Nullable(2)]
	private AvignonTaskData Data;

	// Token: 0x040034F7 RID: 13559
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x020076D7 RID: 30423
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027379 RID: 160633
		public const int JumpBtn = 0;

		// Token: 0x0402737A RID: 160634
		public const int GetBtn = 1;

		// Token: 0x0402737B RID: 160635
		public const int DoingText = 2;

		// Token: 0x0402737C RID: 160636
		public const int FinishItem = 3;

		// Token: 0x0402737D RID: 160637
		public const int TxtName = 4;

		// Token: 0x0402737E RID: 160638
		public const int ProgressText = 5;

		// Token: 0x0402737F RID: 160639
		public const int RewardScroll = 6;
	}
}
