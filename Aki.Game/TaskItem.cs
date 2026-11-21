using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020006A3 RID: 1699
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TaskItem : GridProxyAbstract<TaskData>
{
	// Token: 0x06004E1F RID: 19999 RVA: 0x001A5880 File Offset: 0x001A3A80
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

	// Token: 0x06004E20 RID: 20000 RVA: 0x001A596D File Offset: 0x001A3B6D
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06004E21 RID: 20001 RVA: 0x001A5990 File Offset: 0x001A3B90
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06004E22 RID: 20002 RVA: 0x001A5997 File Offset: 0x001A3B97
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
	}

	// Token: 0x06004E23 RID: 20003 RVA: 0x001A59AA File Offset: 0x001A3BAA
	private void OnClickGetButton()
	{
		TaskReceive receiveDelegate = this.TaskData.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.TaskData.TaskId);
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x001A59CC File Offset: 0x001A3BCC
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

	// Token: 0x040038C7 RID: 14535
	private TaskData TaskData;

	// Token: 0x040038C8 RID: 14536
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0200695F RID: 26975
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022B41 RID: 142145
		public const int JumpBtn = 0;

		// Token: 0x04022B42 RID: 142146
		public const int GetBtn = 1;

		// Token: 0x04022B43 RID: 142147
		public const int FinishItem = 2;

		// Token: 0x04022B44 RID: 142148
		public const int TxtName = 3;

		// Token: 0x04022B45 RID: 142149
		public const int ProgressText = 4;

		// Token: 0x04022B46 RID: 142150
		public const int RewardScroll = 5;

		// Token: 0x04022B47 RID: 142151
		public const int DoingText = 6;
	}
}
