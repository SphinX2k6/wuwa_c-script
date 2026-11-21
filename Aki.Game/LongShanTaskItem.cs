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

// Token: 0x02000759 RID: 1881
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LongShanTaskItem : GridProxyAbstract<LongShanTaskInfo>
{
	// Token: 0x06005683 RID: 22147 RVA: 0x001C6090 File Offset: 0x001C4290
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

	// Token: 0x06005684 RID: 22148 RVA: 0x001C6220 File Offset: 0x001C4420
	protected override UniTask OnBeforeStartAsync()
	{
		LongShanTaskItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LongShanTaskItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005685 RID: 22149 RVA: 0x001C6263 File Offset: 0x001C4463
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06005686 RID: 22150 RVA: 0x001C626C File Offset: 0x001C446C
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

	// Token: 0x06005687 RID: 22151 RVA: 0x001C6438 File Offset: 0x001C4638
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

	// Token: 0x06005688 RID: 22152 RVA: 0x001C6490 File Offset: 0x001C4690
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

	// Token: 0x06005689 RID: 22153 RVA: 0x001C65A0 File Offset: 0x001C47A0
	private void OnClickJump()
	{
		SkipTaskManager.RunByConfigId(ConfigLongShanTaskById.GetConfig(this.TaskId, true).Value.JumpId, null);
	}

	// Token: 0x0600568A RID: 22154 RVA: 0x001C65CF File Offset: 0x001C47CF
	private void OnClickGetButton()
	{
		ActivityLongShanController.Instance.TakeTaskReward(this.TaskId);
	}

	// Token: 0x04003BA1 RID: 15265
	private int TaskId;

	// Token: 0x04003BA2 RID: 15266
	[Nullable(2)]
	private LongShanTaskInfo TaskInfo;

	// Token: 0x04003BA3 RID: 15267
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04003BA4 RID: 15268
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x02006A49 RID: 27209
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022FA8 RID: 143272
		public const int JumpBtn = 0;

		// Token: 0x04022FA9 RID: 143273
		public const int GetBtn = 1;

		// Token: 0x04022FAA RID: 143274
		public const int DoingText = 2;

		// Token: 0x04022FAB RID: 143275
		public const int FinishItem = 3;

		// Token: 0x04022FAC RID: 143276
		public const int TxtName = 4;

		// Token: 0x04022FAD RID: 143277
		public const int ProgressText = 5;

		// Token: 0x04022FAE RID: 143278
		public const int RewardScroll = 6;

		// Token: 0x04022FAF RID: 143279
		public const int ItemLockPanel = 7;
	}
}
