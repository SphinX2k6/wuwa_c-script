using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012A5 RID: 4773
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LongShanTaskItem : GridProxyAbstract<LongShanTaskInfo>
{
	// Token: 0x060082EC RID: 33516 RVA: 0x001BD300 File Offset: 0x001BB500
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJump));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060082ED RID: 33517 RVA: 0x001BD490 File Offset: 0x001BB690
	protected override UniTask OnBeforeStartAsync()
	{
		LongShanTaskItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LongShanTaskItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060082EE RID: 33518 RVA: 0x001BD4D3 File Offset: 0x001BB6D3
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060082EF RID: 33519 RVA: 0x001BD4DC File Offset: 0x001BB6DC
	public override void Refresh(LongShanTaskInfo data, bool isSelected, int gridIndex)
	{
		this.TaskInfo = data;
		this.TaskId = data.Id;
		LongShanTask value = ConfigLongShanTaskById.GetConfig(this.TaskId, true).Value;
		List<TItem> list = new List<TItem>();
		for (int i = 0; i < value.TaskRewardLength; i++)
		{
			int key = value.TaskReward(i).Value.Key;
			int value2 = value.TaskReward(i).Value.Value;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value2);
			list.Add(item);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
		base.GetButton(1).RootUIComp.Get().SetUIActive(data.IsFinished && !data.IsTaken);
		base.GetItem(3).SetUIActive(data.IsTaken);
		base.GetItem(2).SetUIActive(!data.IsFinished && value.JumpId == 0);
		base.GetButton(0).RootUIComp.Get().SetUIActive(!data.IsFinished && data.UnlockConditionFinish && value.JumpId > 0);
		FunctionalPanelConditionLock panelLock = this.PanelLock;
		if (panelLock != null)
		{
			panelLock.SetUiActive(!data.IsFinished && !data.UnlockConditionFinish && value.JumpId > 0);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value.TaskName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "LongShanStage_Progress", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.Current,
			data.Target
		}));
	}

	// Token: 0x060082F0 RID: 33520 RVA: 0x001BD6A8 File Offset: 0x001BB8A8
	private bool IsConditionFinished(int conditionId)
	{
		foreach (int num in this.TaskInfo.FinishConditions)
		{
			if (conditionId == num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060082F1 RID: 33521 RVA: 0x001BD700 File Offset: 0x001BB900
	private void OnClickLockButton()
	{
		LongShanTaskInfo taskInfo = this.TaskInfo;
		if (taskInfo == null || !taskInfo.UnlockConditionFinish)
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(this.TaskInfo.UnlockConditionId))
			{
				Condition value = ConditionConfig.Instance.GetConditionConfig(conditionId).Value;
				int accessType = -1;
				if (value.AccessId != 0)
				{
					accessType = GetWayConfig.Instance.GetConfigById(value.AccessId).Value.SkipName;
				}
				ActivityConditionData item = new ActivityConditionData
				{
					ConditionId = conditionId,
					ConditionTextId = value.Description,
					IsFinished = this.IsConditionFinished(conditionId),
					AccessId = value.AccessId,
					AccessType = accessType
				};
				list.Add(item);
			}
			ConditionGroupData param = new ConditionGroupData(this.TaskInfo.UnlockConditionId, list, null, false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}
	}

	// Token: 0x060082F2 RID: 33522 RVA: 0x001BD810 File Offset: 0x001BBA10
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(ConfigLongShanTaskById.GetConfig(this.TaskId, true).Value.JumpId, null);
	}

	// Token: 0x060082F3 RID: 33523 RVA: 0x001BD83F File Offset: 0x001BBA3F
	private void OnClickGetButton()
	{
		ActivityLongShanController.Instance.TakeTaskReward(this.TaskId);
	}

	// Token: 0x04003B09 RID: 15113
	private int TaskId;

	// Token: 0x04003B0A RID: 15114
	[Nullable(2)]
	private LongShanTaskInfo TaskInfo;

	// Token: 0x04003B0B RID: 15115
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04003B0C RID: 15116
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x020078BF RID: 30911
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C7A RID: 162938
		public const int JumpBtn = 0;

		// Token: 0x04027C7B RID: 162939
		public const int GetBtn = 1;

		// Token: 0x04027C7C RID: 162940
		public const int DoingText = 2;

		// Token: 0x04027C7D RID: 162941
		public const int FinishItem = 3;

		// Token: 0x04027C7E RID: 162942
		public const int TxtName = 4;

		// Token: 0x04027C7F RID: 162943
		public const int ProgressText = 5;

		// Token: 0x04027C80 RID: 162944
		public const int RewardScroll = 6;

		// Token: 0x04027C81 RID: 162945
		public const int ItemLockPanel = 7;
	}
}
