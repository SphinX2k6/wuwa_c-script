using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001285 RID: 4741
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FishingRewardTaskItem : GridProxyAbstract<FishingTaskData>
{
	// Token: 0x06008174 RID: 33140 RVA: 0x001B7620 File Offset: 0x001B5820
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickJump));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickGetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008175 RID: 33141 RVA: 0x001B77AF File Offset: 0x001B59AF
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData>(base.GetScrollViewWithScrollbar(6), new Func<ActivitySmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06008176 RID: 33142 RVA: 0x001B77D2 File Offset: 0x001B59D2
	private ActivitySmallItemGrid CreatePropItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x06008177 RID: 33143 RVA: 0x001B77D9 File Offset: 0x001B59D9
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
	}

	// Token: 0x06008178 RID: 33144 RVA: 0x001B77EC File Offset: 0x001B59EC
	private void OnClickGetButton()
	{
		Action<int> receiveDelegate = this.TaskData.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.TaskData.TaskId);
	}

	// Token: 0x06008179 RID: 33145 RVA: 0x001B7810 File Offset: 0x001B5A10
	public override void Refresh(FishingTaskData data, bool isSelected, int gridIndex)
	{
		this.TaskData = data;
		bool flag = data.Status == EActivityTaskState.FinishedAndClaimed;
		bool uiactive = data.Status == EActivityTaskState.FinishedAndUnclaimed;
		bool flag2 = data.Status == EActivityTaskState.Active;
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in data.RewardList)
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = flag
			};
			list.Add(item2);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
		base.GetButton(0).RootUIComp.Get().SetUIActive(uiactive);
		base.GetItem(3).SetUIActive(flag);
		base.GetText(2).SetUIActive(flag2 && data.JumpId == 0);
		base.GetButton(1).RootUIComp.Get().SetUIActive(flag2 && data.JumpId != 0);
		float alpha = flag ? 0.6f : 1f;
		base.GetItem(7).SetAlpha(alpha);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TitleTextId, Array.Empty<object>());
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x04003AA6 RID: 15014
	private const float FINISHED_ITEM_ALPHA = 0.6f;

	// Token: 0x04003AA7 RID: 15015
	private const float NORMAL_ITEM_ALPHA = 1f;

	// Token: 0x04003AA8 RID: 15016
	private FishingTaskData TaskData;

	// Token: 0x04003AA9 RID: 15017
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0200789D RID: 30877
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027BD7 RID: 162775
		public const int GetBtn = 0;

		// Token: 0x04027BD8 RID: 162776
		public const int JumpBtn = 1;

		// Token: 0x04027BD9 RID: 162777
		public const int DoingText = 2;

		// Token: 0x04027BDA RID: 162778
		public const int FinishItem = 3;

		// Token: 0x04027BDB RID: 162779
		public const int TxtName = 4;

		// Token: 0x04027BDC RID: 162780
		public const int ProgressText = 5;

		// Token: 0x04027BDD RID: 162781
		public const int RewardScroll = 6;

		// Token: 0x04027BDE RID: 162782
		public const int Item = 7;
	}
}
