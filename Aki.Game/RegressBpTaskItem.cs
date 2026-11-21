using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200093B RID: 2363
internal class RegressBpTaskItem : GridProxyAbstract<RegressQuest>
{
	// Token: 0x06006857 RID: 26711 RVA: 0x00209C8C File Offset: 0x00207E8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtn))
		};
	}

	// Token: 0x06006858 RID: 26712 RVA: 0x00209DEA File Offset: 0x00207FEA
	protected override void OnStart()
	{
		this.RewardListView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x06006859 RID: 26713 RVA: 0x00209E0D File Offset: 0x0020800D
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600685A RID: 26714 RVA: 0x00209E14 File Offset: 0x00208014
	public override void Refresh(RegressQuest data, bool isSelected, int gridIndex)
	{
		this.Data = new RegressQuest?(data);
		base.GridIndex = gridIndex;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, data.TargetName, Array.Empty<object>());
		int id = data.Id;
		ValueTuple<int, int> taskProgressTuple = ActivityRegressModel.Instance.ActivityData.GetTaskProgressTuple(id);
		int item = taskProgressTuple.Item1;
		int item2 = taskProgressTuple.Item2;
		UUIText text2 = base.GetText(1);
		if (this.IsShowTag() && data.TaskType == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "Recall_BP_Task_Repeat", new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
		}
		else
		{
			UUIText uuitext = text2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		this.RefreshRewardLayout();
		base.GetButton(4).RootUIComp.Get().SetUIActive(taskRewardState == ERegressRewardState.UnReach);
		base.GetButton(6).RootUIComp.Get().SetUIActive(taskRewardState == ERegressRewardState.Reached);
		base.GetSprite(5).SetUIActive(taskRewardState == ERegressRewardState.Claim);
		this.RefreshTag();
	}

	// Token: 0x0600685B RID: 26715 RVA: 0x00209F64 File Offset: 0x00208164
	private void RefreshRewardLayout()
	{
		List<TItem> dropPreviewRewardItemListForPreview = ActivityRegressModel.Instance.GetDropPreviewRewardItemListForPreview(this.Data.Value.TargetReward);
		this.RewardListView.RefreshByData(dropPreviewRewardItemListForPreview, null, false);
	}

	// Token: 0x0600685C RID: 26716 RVA: 0x00209FA0 File Offset: 0x002081A0
	private bool IsShowTag()
	{
		RegressQuest value = this.Data.Value;
		ERegressTaskType taskType = (ERegressTaskType)value.TaskType;
		ERegressConstantTaskSubType taskSubType = (ERegressConstantTaskSubType)value.TaskSubType;
		bool flag = taskType == ERegressTaskType.Cultivate || taskType == ERegressTaskType.Once;
		if (taskType == ERegressTaskType.Constant && taskSubType != ERegressConstantTaskSubType.Explore && taskSubType != ERegressConstantTaskSubType.MainQuestAndRole)
		{
			flag = true;
		}
		return !flag;
	}

	// Token: 0x0600685D RID: 26717 RVA: 0x00209FE8 File Offset: 0x002081E8
	private void RefreshTag()
	{
		RegressQuest value = this.Data.Value;
		UUIItem item = base.GetItem(8);
		ERegressTaskType taskType = (ERegressTaskType)value.TaskType;
		if (!this.IsShowTag())
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		UUISprite sprite = base.GetSprite(9);
		UUISprite sprite2 = base.GetSprite(10);
		UUIText text = base.GetText(11);
		if (taskType == ERegressTaskType.Constant)
		{
			sprite.SetUIActive(true);
			sprite2.SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(text, "Recall_BP_Task_Type_2", Array.Empty<object>());
			return;
		}
		if (taskType == ERegressTaskType.Daily)
		{
			sprite.SetUIActive(false);
			sprite2.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, "Recall_BP_Task_Type_1", Array.Empty<object>());
		}
	}

	// Token: 0x0600685E RID: 26718 RVA: 0x0020A098 File Offset: 0x00208298
	private void OnClickBtn()
	{
		RegressQuest value = this.Data.Value;
		int id = value.Id;
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		if (taskRewardState == ERegressRewardState.UnReach)
		{
			ActivityRegressController.Instance.JumpByQuestConfig(value);
			return;
		}
		if (taskRewardState == ERegressRewardState.Reached)
		{
			if (ActivityRegressModel.Instance.ActivityData.IsRegressTaskScoreOverExp())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Task_Max", Array.Empty<object>());
			}
			ActivityRegressController.Instance.RequestClaimTaskReward(id);
		}
	}

	// Token: 0x0400427E RID: 17022
	private RegressQuest? Data;

	// Token: 0x0400427F RID: 17023
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardListView;

	// Token: 0x02006C36 RID: 27702
	private class EMissionComponents
	{
		// Token: 0x040238F4 RID: 145652
		public const int TxtName = 0;

		// Token: 0x040238F5 RID: 145653
		public const int TxtProgress = 1;

		// Token: 0x040238F6 RID: 145654
		public const int RewardScroll = 2;

		// Token: 0x040238F7 RID: 145655
		public const int ItemReward = 3;

		// Token: 0x040238F8 RID: 145656
		public const int BtnJump = 4;

		// Token: 0x040238F9 RID: 145657
		public const int SpriteMask = 5;

		// Token: 0x040238FA RID: 145658
		public const int BtnGetReward = 6;

		// Token: 0x040238FB RID: 145659
		public const int TxtDoing = 7;

		// Token: 0x040238FC RID: 145660
		public const int PanelTag = 8;

		// Token: 0x040238FD RID: 145661
		public const int SpriteTagBlue = 9;

		// Token: 0x040238FE RID: 145662
		public const int SpriteTagYellow = 10;

		// Token: 0x040238FF RID: 145663
		public const int TxtTagDesc = 11;
	}
}
