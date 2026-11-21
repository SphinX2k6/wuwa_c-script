using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200209A RID: 8346
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRewardTaskItem : GridProxyAbstract<ActivityTaskData>
{
	// Token: 0x0601490A RID: 84234 RVA: 0x005FE568 File Offset: 0x005FC768
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

	// Token: 0x0601490B RID: 84235 RVA: 0x005FE681 File Offset: 0x005FC881
	protected override void OnStart()
	{
		this.RewardScroll = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
	}

	// Token: 0x0601490C RID: 84236 RVA: 0x005FE6A4 File Offset: 0x005FC8A4
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0601490D RID: 84237 RVA: 0x005FE6AC File Offset: 0x005FC8AC
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

	// Token: 0x0601490E RID: 84238 RVA: 0x005FE81D File Offset: 0x005FCA1D
	private void OnGetBtnClickInternal()
	{
		this.OnGetBtnClick();
	}

	// Token: 0x0601490F RID: 84239 RVA: 0x005FE82C File Offset: 0x005FCA2C
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

	// Token: 0x06014910 RID: 84240 RVA: 0x005FE877 File Offset: 0x005FCA77
	public override object GetKey(ActivityTaskData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0400AE9C RID: 44700
	[Nullable(2)]
	private ActivityTaskData TaskData;

	// Token: 0x0400AE9D RID: 44701
	public Action OnGetBtnClick = delegate()
	{
	};

	// Token: 0x0400AE9E RID: 44702
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardScroll;
}
