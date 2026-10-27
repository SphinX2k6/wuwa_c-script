using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001487 RID: 5255
internal class RegressBpTaskItem : GridProxyAbstract<RegressQuest>
{
	// Token: 0x060094C2 RID: 38082 RVA: 0x00200D24 File Offset: 0x001FEF24
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

	// Token: 0x060094C3 RID: 38083 RVA: 0x00200E82 File Offset: 0x001FF082
	protected override void OnStart()
	{
		this.RewardListView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
	}

	// Token: 0x060094C4 RID: 38084 RVA: 0x00200EA5 File Offset: 0x001FF0A5
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060094C5 RID: 38085 RVA: 0x00200EAC File Offset: 0x001FF0AC
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

	// Token: 0x060094C6 RID: 38086 RVA: 0x00200FFC File Offset: 0x001FF1FC
	private void RefreshRewardLayout()
	{
		List<TItem> dropPreviewRewardItemListForPreview = ActivityRegressModel.Instance.GetDropPreviewRewardItemListForPreview(this.Data.Value.TargetReward);
		this.RewardListView.RefreshByData(dropPreviewRewardItemListForPreview, null, false);
	}

	// Token: 0x060094C7 RID: 38087 RVA: 0x00201038 File Offset: 0x001FF238
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

	// Token: 0x060094C8 RID: 38088 RVA: 0x00201080 File Offset: 0x001FF280
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

	// Token: 0x060094C9 RID: 38089 RVA: 0x00201130 File Offset: 0x001FF330
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

	// Token: 0x040041E6 RID: 16870
	private RegressQuest? Data;

	// Token: 0x040041E7 RID: 16871
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardListView;

	// Token: 0x02007AB2 RID: 31410
	private class EMissionComponents
	{
		// Token: 0x040285DA RID: 165338
		public const int TxtName = 0;

		// Token: 0x040285DB RID: 165339
		public const int TxtProgress = 1;

		// Token: 0x040285DC RID: 165340
		public const int RewardScroll = 2;

		// Token: 0x040285DD RID: 165341
		public const int ItemReward = 3;

		// Token: 0x040285DE RID: 165342
		public const int BtnJump = 4;

		// Token: 0x040285DF RID: 165343
		public const int SpriteMask = 5;

		// Token: 0x040285E0 RID: 165344
		public const int BtnGetReward = 6;

		// Token: 0x040285E1 RID: 165345
		public const int TxtDoing = 7;

		// Token: 0x040285E2 RID: 165346
		public const int PanelTag = 8;

		// Token: 0x040285E3 RID: 165347
		public const int SpriteTagBlue = 9;

		// Token: 0x040285E4 RID: 165348
		public const int SpriteTagYellow = 10;

		// Token: 0x040285E5 RID: 165349
		public const int TxtTagDesc = 11;
	}
}
