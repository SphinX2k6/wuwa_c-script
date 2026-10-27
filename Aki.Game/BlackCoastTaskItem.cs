using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011B4 RID: 4532
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BlackCoastTaskItem : GridProxyAbstract<BlackCoastTaskData>
{
	// Token: 0x06007847 RID: 30791 RVA: 0x001934D0 File Offset: 0x001916D0
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

	// Token: 0x06007848 RID: 30792 RVA: 0x0019363E File Offset: 0x0019183E
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06007849 RID: 30793 RVA: 0x00193661 File Offset: 0x00191861
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600784A RID: 30794 RVA: 0x00193668 File Offset: 0x00191868
	public override void Refresh(BlackCoastTaskData data, bool isSelected, int gridIndex)
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

	// Token: 0x0600784B RID: 30795 RVA: 0x00193770 File Offset: 0x00191970
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
	}

	// Token: 0x0600784C RID: 30796 RVA: 0x00193783 File Offset: 0x00191983
	private void OnClickGetButton()
	{
		Action<int> receiveDelegate = this.Data.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.Data.TaskId);
	}

	// Token: 0x04003760 RID: 14176
	private BlackCoastTaskData Data;

	// Token: 0x04003761 RID: 14177
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0200779B RID: 30619
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027712 RID: 161554
		public const int JumpBtn = 0;

		// Token: 0x04027713 RID: 161555
		public const int GetBtn = 1;

		// Token: 0x04027714 RID: 161556
		public const int DoingText = 2;

		// Token: 0x04027715 RID: 161557
		public const int FinishItem = 3;

		// Token: 0x04027716 RID: 161558
		public const int TxtName = 4;

		// Token: 0x04027717 RID: 161559
		public const int ProgressText = 5;

		// Token: 0x04027718 RID: 161560
		public const int RewardScroll = 6;
	}
}
