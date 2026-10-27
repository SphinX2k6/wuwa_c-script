using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011EF RID: 4591
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TaskItem : GridProxyAbstract<TaskData>
{
	// Token: 0x06007A88 RID: 31368 RVA: 0x0019CBD8 File Offset: 0x0019ADD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickJump)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton))
		};
	}

	// Token: 0x06007A89 RID: 31369 RVA: 0x0019CCC5 File Offset: 0x0019AEC5
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06007A8A RID: 31370 RVA: 0x0019CCE8 File Offset: 0x0019AEE8
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007A8B RID: 31371 RVA: 0x0019CCEF File Offset: 0x0019AEEF
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
	}

	// Token: 0x06007A8C RID: 31372 RVA: 0x0019CD02 File Offset: 0x0019AF02
	private void OnClickGetButton()
	{
		TaskReceive receiveDelegate = this.TaskData.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.TaskData.TaskId);
	}

	// Token: 0x06007A8D RID: 31373 RVA: 0x0019CD24 File Offset: 0x0019AF24
	public override void Refresh(TaskData data, bool isSelected, int gridIndex)
	{
		this.TaskData = data;
		this.RewardScrollView.RefreshByData(data.RewardList, null, false);
		base.GetButton(1).RootUIComp.Get().SetUIActive(data.IsFinished && !data.IsTaken);
		base.GetItem(2).SetUIActive(data.IsTaken);
		base.GetText(6).SetUIActive(!data.IsTaken && !data.IsFinished && data.JumpId == 0);
		if (!StringUtils.IsEmpty(data.DoingTextId))
		{
			base.GetText(6).ShowTextNew("Moonfiesta_TargetDone");
		}
		else
		{
			base.GetText(6).ShowTextNew("Moonfiesta_TargetOn");
		}
		base.GetButton(0).RootUIComp.Get().SetUIActive(!data.IsFinished && !data.IsTaken && data.JumpId > 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TitleTextId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "LongShanStage_Progress", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x0400382E RID: 14382
	private TaskData TaskData;

	// Token: 0x0400382F RID: 14383
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x020077D4 RID: 30676
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402780F RID: 161807
		public const int JumpBtn = 0;

		// Token: 0x04027810 RID: 161808
		public const int GetBtn = 1;

		// Token: 0x04027811 RID: 161809
		public const int FinishItem = 2;

		// Token: 0x04027812 RID: 161810
		public const int TxtName = 3;

		// Token: 0x04027813 RID: 161811
		public const int ProgressText = 4;

		// Token: 0x04027814 RID: 161812
		public const int RewardScroll = 5;

		// Token: 0x04027815 RID: 161813
		public const int DoingText = 6;
	}
}
