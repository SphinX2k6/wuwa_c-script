using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020005C8 RID: 1480
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AvignonTaskItem : GridProxyAbstract<AvignonTaskData>
{
	// Token: 0x060045EC RID: 17900 RVA: 0x0017F044 File Offset: 0x0017D244
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

	// Token: 0x060045ED RID: 17901 RVA: 0x0017F1B2 File Offset: 0x0017D3B2
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x060045EE RID: 17902 RVA: 0x0017F1D5 File Offset: 0x0017D3D5
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x0017F1DC File Offset: 0x0017D3DC
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

	// Token: 0x060045F0 RID: 17904 RVA: 0x0017F2E4 File Offset: 0x0017D4E4
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x060045F1 RID: 17905 RVA: 0x0017F2F7 File Offset: 0x0017D4F7
	private void OnClickGetButton()
	{
		Action<int> receiveDelegate = this.Data.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.Data.TaskId);
	}

	// Token: 0x0400358F RID: 13711
	[Nullable(2)]
	private AvignonTaskData Data;

	// Token: 0x04003590 RID: 13712
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0200686B RID: 26731
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040226C2 RID: 140994
		public const int JumpBtn = 0;

		// Token: 0x040226C3 RID: 140995
		public const int GetBtn = 1;

		// Token: 0x040226C4 RID: 140996
		public const int DoingText = 2;

		// Token: 0x040226C5 RID: 140997
		public const int FinishItem = 3;

		// Token: 0x040226C6 RID: 140998
		public const int TxtName = 4;

		// Token: 0x040226C7 RID: 140999
		public const int ProgressText = 5;

		// Token: 0x040226C8 RID: 141000
		public const int RewardScroll = 6;
	}
}
