using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001ECE RID: 7886
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryLimitTaskItem : GridProxyAbstract<HonamiStoryLimitTaskData>
{
	// Token: 0x0600F274 RID: 62068 RVA: 0x003A70AC File Offset: 0x003A52AC
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

	// Token: 0x0600F275 RID: 62069 RVA: 0x003A723B File Offset: 0x003A543B
	protected override void OnStart()
	{
		this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x0600F276 RID: 62070 RVA: 0x003A725E File Offset: 0x003A545E
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F277 RID: 62071 RVA: 0x003A7268 File Offset: 0x003A5468
	public override void Refresh(HonamiStoryLimitTaskData data, bool isSelected, int gridIndex)
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
		base.GetButton(0).RootUIComp.Get().SetUIActive(flag && data.JumpId > 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TaskName, new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x0600F278 RID: 62072 RVA: 0x003A7380 File Offset: 0x003A5580
	private void OnJumpBtnClick()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x0600F279 RID: 62073 RVA: 0x003A7393 File Offset: 0x003A5593
	private void OnGetBtnClick()
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Data.Id);
	}

	// Token: 0x04007051 RID: 28753
	[Nullable(2)]
	private HonamiStoryLimitTaskData Data;

	// Token: 0x04007052 RID: 28754
	public Action<int> OnClickToGet = delegate(int _)
	{
	};

	// Token: 0x04007053 RID: 28755
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;
}
