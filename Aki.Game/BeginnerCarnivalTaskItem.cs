using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011A4 RID: 4516
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalTaskItem : GridProxyAbstract<int>
{
	// Token: 0x0600778C RID: 30604 RVA: 0x0018FE14 File Offset: 0x0018E014
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetBtn)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickCanNotJumpBtn)),
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpBtn))
		};
	}

	// Token: 0x0600778D RID: 30605 RVA: 0x0018FF5C File Offset: 0x0018E15C
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x0600778E RID: 30606 RVA: 0x0018FF7F File Offset: 0x0018E17F
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600778F RID: 30607 RVA: 0x0018FF88 File Offset: 0x0018E188
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TaskId = data;
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		ActivityTask taskDataById = beginnerCarnivalData.GetTaskDataById(this.TaskId);
		NewbieCarnivalTask? newbieCarnivalTask = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTask(this.TaskId);
		this.SkipId = newbieCarnivalTask.Value.JumpId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), newbieCarnivalTask.Value.TaskName, Array.Empty<object>());
		UUIText text = base.GetText(5);
		int num = taskDataById.Current;
		text.SetText(num.ToString() + "/" + taskDataById.Target.ToString(), true);
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(newbieCarnivalTask.Value.TaskReward);
		this.ScrollView.RefreshByData(dropPackagePreviewItemList, null, false);
		bool uiactive = taskDataById.Status == ActivityTaskState.ActivityTaskTaken;
		base.GetItem(3).SetUIActive(uiactive);
		bool uiactive2 = taskDataById.Status == ActivityTaskState.ActivityTaskFinish;
		base.GetButton(1).RootUIComp.Get().SetUIActive(uiactive2);
		base.GetItem(9).SetUIActive(uiactive2);
		bool flag = taskDataById.Status == ActivityTaskState.ActivityTaskRunning;
		bool flag2 = newbieCarnivalTask.Value.JumpId > 0;
		List<int> list;
		if (!beginnerCarnivalData.JumpTaskMap.TryGetValue(this.TaskId, out list) || list == null)
		{
			list = new List<int>();
		}
		bool flag3 = list.Count >= newbieCarnivalTask.Value.JumpConditionGroupsLength;
		this.HaveDoneConditionGroupList = list;
		base.GetButton(0).RootUIComp.Get().SetUIActive(flag && flag2 && flag3);
		base.GetItem(7).SetUIActive(flag && flag2 && !flag3);
		base.GetText(2).SetUIActive(flag && !flag2);
	}

	// Token: 0x06007790 RID: 30608 RVA: 0x00190165 File Offset: 0x0018E365
	private void OnClickGetBtn()
	{
		BeginnerCarnivalController.Instance.NewbieCarnivalAwardRequest(this.TaskId);
	}

	// Token: 0x06007791 RID: 30609 RVA: 0x00190178 File Offset: 0x0018E378
	private void OnClickCanNotJumpBtn()
	{
		List<IActivityConditionData> list = new List<IActivityConditionData>();
		NewbieCarnivalTask value = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalTask(this.TaskId).Value;
		for (int i = 0; i < value.JumpConditionGroupsLength; i++)
		{
			int conditionGroupId = value.JumpConditionGroups(i);
			foreach (int num in ConditionConfig.Instance.GetGroupConditionIds(conditionGroupId))
			{
				Condition value2 = ConditionConfig.Instance.GetConditionConfig(num).Value;
				int accessType = -1;
				if (value2.AccessId != 0)
				{
					accessType = GetWayConfig.Instance.GetConfigById(value2.AccessId).Value.SkipName;
				}
				ActivityConditionData item = new ActivityConditionData
				{
					ConditionId = num,
					ConditionTextId = value2.Description,
					IsFinished = this.IsConditionFinished(num),
					AccessId = value2.AccessId,
					AccessType = accessType
				};
				list.Add(item);
			}
		}
		ConditionGroupData param = new ConditionGroupData(value.JumpConditionGroup, list, "", false);
		UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
	}

	// Token: 0x06007792 RID: 30610 RVA: 0x001902AD File Offset: 0x0018E4AD
	private bool IsConditionFinished(int conditionGroupId)
	{
		return this.HaveDoneConditionGroupList.Contains(conditionGroupId);
	}

	// Token: 0x06007793 RID: 30611 RVA: 0x001902BB File Offset: 0x0018E4BB
	private void OnClickJumpBtn()
	{
		if (this.SkipId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.SkipId, null);
	}

	// Token: 0x0400370A RID: 14090
	private int TaskId;

	// Token: 0x0400370B RID: 14091
	private int SkipId;

	// Token: 0x0400370C RID: 14092
	private List<int> HaveDoneConditionGroupList = new List<int>();

	// Token: 0x0400370D RID: 14093
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ScrollView;
}
