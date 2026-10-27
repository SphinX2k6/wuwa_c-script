using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EDF RID: 7903
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryPermanentTaskItem : GridProxyAbstract<HonamiStoryPermanentTaskData>
{
	// Token: 0x0600F32F RID: 62255 RVA: 0x003A9F7C File Offset: 0x003A817C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnJumpBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnGetBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F330 RID: 62256 RVA: 0x003AA10B File Offset: 0x003A830B
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x0600F331 RID: 62257 RVA: 0x003AA12E File Offset: 0x003A832E
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F332 RID: 62258 RVA: 0x003AA138 File Offset: 0x003A8338
	public override void Refresh(HonamiStoryPermanentTaskData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.Data.DropId);
		this.RewardScroll.RefreshByData(dropPackagePreviewItemList, delegate
		{
			this.RewardScroll.ScrollToLeft(0);
		}, false);
		bool uiactive = data.Status == EActivityTaskState.FinishedAndClaimed;
		bool uiactive2 = data.Status == EActivityTaskState.FinishedAndUnclaimed;
		bool flag = data.Status == EActivityTaskState.Active;
		base.GetItem(7).SetUIActive(uiactive2);
		base.GetItem(3).SetUIActive(uiactive);
		base.GetText(2).SetUIActive(flag && data.JumpId == 0);
		base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetButton(0).RootUIComp.Get().SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TaskName, new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x0600F333 RID: 62259 RVA: 0x003AA242 File Offset: 0x003A8442
	private void OnJumpBtnClick()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x0600F334 RID: 62260 RVA: 0x003AA255 File Offset: 0x003A8455
	private void OnGetBtnClick()
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Data.Id);
	}

	// Token: 0x040070A4 RID: 28836
	[Nullable(2)]
	private HonamiStoryPermanentTaskData Data;

	// Token: 0x040070A5 RID: 28837
	public Action<int> OnClickToGet = delegate(int _)
	{
	};

	// Token: 0x040070A6 RID: 28838
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;
}
