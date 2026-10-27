using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B1E RID: 11038
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRewardTaskItem : GridProxyAbstract<ActivityTaskData>
{
	// Token: 0x06016ED9 RID: 93913 RVA: 0x005D19EC File Offset: 0x005CFBEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnGetBtnClickInternal)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnJumpBtnClick))
		};
	}

	// Token: 0x06016EDA RID: 93914 RVA: 0x005D1B05 File Offset: 0x005CFD05
	protected override void OnStart()
	{
		this.RewardScroll = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
	}

	// Token: 0x06016EDB RID: 93915 RVA: 0x005D1B28 File Offset: 0x005CFD28
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06016EDC RID: 93916 RVA: 0x005D1B30 File Offset: 0x005CFD30
	public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
	{
		this.TaskData = taskData;
		SurvivorsTask? survivorsTask = SurvivorsRogueConfig.Instance.GetSurvivorsTask(taskData.Id);
		if (survivorsTask == null)
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(survivorsTask.Value.DropId);
		this.RewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
		bool uiactive = taskData.Status == EActivityTaskState.FinishedAndClaimed;
		bool uiactive2 = taskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		bool flag = taskData.Status == EActivityTaskState.Active;
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetItem(7).SetUIActive(uiactive2);
		base.GetSprite(6).SetUIActive(uiactive);
		base.GetText(5).SetUIActive(flag && survivorsTask.Value.JumpId == 0);
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && survivorsTask.Value.JumpId > 0);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), survivorsTask.Value.TaskName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SurvivorsNowProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			taskData.Current.ToString(),
			taskData.Target.ToString()
		}));
	}

	// Token: 0x06016EDD RID: 93917 RVA: 0x005D1CA1 File Offset: 0x005CFEA1
	private void OnGetBtnClickInternal()
	{
		this.OnGetBtnClick();
	}

	// Token: 0x06016EDE RID: 93918 RVA: 0x005D1CB0 File Offset: 0x005CFEB0
	private void OnJumpBtnClick()
	{
		if (this.TaskData == null)
		{
			return;
		}
		SurvivorsTask? survivorsTask = SurvivorsRogueConfig.Instance.GetSurvivorsTask(this.TaskData.Id);
		if (survivorsTask == null)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(survivorsTask.Value.JumpId, null);
	}

	// Token: 0x06016EDF RID: 93919 RVA: 0x005D1CFB File Offset: 0x005CFEFB
	public override object GetKey(ActivityTaskData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0400AA96 RID: 43670
	[Nullable(2)]
	private ActivityTaskData TaskData;

	// Token: 0x0400AA97 RID: 43671
	public Action OnGetBtnClick = delegate()
	{
	};

	// Token: 0x0400AA98 RID: 43672
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardScroll;
}
