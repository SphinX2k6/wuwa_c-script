using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014B3 RID: 5299
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityRegressCultivateTaskSubViewLoopItem : GridProxyAbstract<IActivityRegressRoleCultivateSubViewLoopData>
{
	// Token: 0x06009628 RID: 38440 RVA: 0x0020699C File Offset: 0x00204B9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06009629 RID: 38441 RVA: 0x00206A5C File Offset: 0x00204C5C
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		UUIItem item = base.GetItem(4);
		this.ButtonItemE = new ButtonItem(item);
		this.ButtonItemE.SetFunction(new Action<int>(this.OnConfirmBtnClick));
		this.ButtonItemE.SetShowText("RecallActivity_Go");
		UUIItem item2 = base.GetItem(6);
		this.ButtonItemB = new ButtonItem(item2);
		this.ButtonItemB.SetShowText("CollectActivity_state_CanRecive");
		this.ButtonItemB.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x0600962A RID: 38442 RVA: 0x00206B00 File Offset: 0x00204D00
	[NullableContext(1)]
	public override void Refresh(IActivityRegressRoleCultivateSubViewLoopData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshProgress();
		this.RefreshState();
		this.RefreshRewardLayout();
	}

	// Token: 0x0600962B RID: 38443 RVA: 0x00206B24 File Offset: 0x00204D24
	private void RefreshName()
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, this.Data.Config.TargetName, Array.Empty<object>());
	}

	// Token: 0x0600962C RID: 38444 RVA: 0x00206B5C File Offset: 0x00204D5C
	private void RefreshProgress()
	{
		int id = this.Data.Config.Id;
		ValueTuple<int, int> taskProgressTuple = ActivityRegressModel.Instance.ActivityData.GetTaskProgressTuple(id);
		int item = taskProgressTuple.Item1;
		int item2 = taskProgressTuple.Item2;
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600962D RID: 38445 RVA: 0x00206BD4 File Offset: 0x00204DD4
	private void RefreshState()
	{
		int id = this.Data.Config.Id;
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(5).SetUIActive(taskRewardState == ERegressRewardState.Claim);
		this.ButtonItemE.SetUiActive(taskRewardState == ERegressRewardState.UnReach);
		this.ButtonItemB.SetUiActive(taskRewardState == ERegressRewardState.Reached);
	}

	// Token: 0x0600962E RID: 38446 RVA: 0x00206C44 File Offset: 0x00204E44
	private void RefreshRewardLayout()
	{
		List<TItem> dropPreviewRewardItemListForPreview = ActivityRegressModel.Instance.GetDropPreviewRewardItemListForPreview(this.Data.Config.TargetReward);
		this.RewardScrollView.RefreshByData(dropPreviewRewardItemListForPreview, null, false);
	}

	// Token: 0x0600962F RID: 38447 RVA: 0x00206C7D File Offset: 0x00204E7D
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06009630 RID: 38448 RVA: 0x00206C84 File Offset: 0x00204E84
	private void OnConfirmBtnClick(int _)
	{
		RegressQuest config = this.Data.Config;
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(config.Id);
		if (taskRewardState == ERegressRewardState.UnReach)
		{
			SkipTaskManager.RunByConfigId(config.AccessPathId, null);
			return;
		}
		if (taskRewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestClaimTaskReward(config.Id);
		}
	}

	// Token: 0x04004251 RID: 16977
	private IActivityRegressRoleCultivateSubViewLoopData Data;

	// Token: 0x04004252 RID: 16978
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004253 RID: 16979
	private ButtonItem ButtonItemE;

	// Token: 0x04004254 RID: 16980
	private ButtonItem ButtonItemB;

	// Token: 0x02007AED RID: 31469
	[NullableContext(0)]
	private class EActivityRegressCultivateTaskSubViewLoopItemComponents
	{
		// Token: 0x040286FB RID: 165627
		public const int TxtName = 0;

		// Token: 0x040286FC RID: 165628
		public const int TxtNum = 1;

		// Token: 0x040286FD RID: 165629
		public const int SVRoot = 2;

		// Token: 0x040286FE RID: 165630
		public const int SVItem = 3;

		// Token: 0x040286FF RID: 165631
		public const int BtnSecConfirmE2 = 4;

		// Token: 0x04028700 RID: 165632
		public const int DoneRoot = 5;

		// Token: 0x04028701 RID: 165633
		public const int BtnSecConfirmB2 = 6;

		// Token: 0x04028702 RID: 165634
		public const int DoingRoot = 7;
	}
}
