using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000967 RID: 2407
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityRegressCultivateTaskSubViewLoopItem : GridProxyAbstract<IActivityRegressRoleCultivateSubViewLoopData>
{
	// Token: 0x060069BD RID: 27069 RVA: 0x0020F908 File Offset: 0x0020DB08
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

	// Token: 0x060069BE RID: 27070 RVA: 0x0020F9C8 File Offset: 0x0020DBC8
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

	// Token: 0x060069BF RID: 27071 RVA: 0x0020FA6C File Offset: 0x0020DC6C
	[NullableContext(1)]
	public override void Refresh(IActivityRegressRoleCultivateSubViewLoopData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshProgress();
		this.RefreshState();
		this.RefreshRewardLayout();
	}

	// Token: 0x060069C0 RID: 27072 RVA: 0x0020FA90 File Offset: 0x0020DC90
	private void RefreshName()
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, this.Data.Config.TargetName, Array.Empty<object>());
	}

	// Token: 0x060069C1 RID: 27073 RVA: 0x0020FAC8 File Offset: 0x0020DCC8
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

	// Token: 0x060069C2 RID: 27074 RVA: 0x0020FB40 File Offset: 0x0020DD40
	private void RefreshState()
	{
		int id = this.Data.Config.Id;
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(5).SetUIActive(taskRewardState == ERegressRewardState.Claim);
		this.ButtonItemE.SetUiActive(taskRewardState == ERegressRewardState.UnReach);
		this.ButtonItemB.SetUiActive(taskRewardState == ERegressRewardState.Reached);
	}

	// Token: 0x060069C3 RID: 27075 RVA: 0x0020FBB0 File Offset: 0x0020DDB0
	private void RefreshRewardLayout()
	{
		List<TItem> dropPreviewRewardItemListForPreview = ActivityRegressModel.Instance.GetDropPreviewRewardItemListForPreview(this.Data.Config.TargetReward);
		this.RewardScrollView.RefreshByData(dropPreviewRewardItemListForPreview, null, false);
	}

	// Token: 0x060069C4 RID: 27076 RVA: 0x0020FBE9 File Offset: 0x0020DDE9
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060069C5 RID: 27077 RVA: 0x0020FBF0 File Offset: 0x0020DDF0
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

	// Token: 0x040042E9 RID: 17129
	private IActivityRegressRoleCultivateSubViewLoopData Data;

	// Token: 0x040042EA RID: 17130
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040042EB RID: 17131
	private ButtonItem ButtonItemE;

	// Token: 0x040042EC RID: 17132
	private ButtonItem ButtonItemB;

	// Token: 0x02006C71 RID: 27761
	[NullableContext(0)]
	private class EActivityRegressCultivateTaskSubViewLoopItemComponents
	{
		// Token: 0x04023A15 RID: 145941
		public const int TxtName = 0;

		// Token: 0x04023A16 RID: 145942
		public const int TxtNum = 1;

		// Token: 0x04023A17 RID: 145943
		public const int SVRoot = 2;

		// Token: 0x04023A18 RID: 145944
		public const int SVItem = 3;

		// Token: 0x04023A19 RID: 145945
		public const int BtnSecConfirmE2 = 4;

		// Token: 0x04023A1A RID: 145946
		public const int DoneRoot = 5;

		// Token: 0x04023A1B RID: 145947
		public const int BtnSecConfirmB2 = 6;

		// Token: 0x04023A1C RID: 145948
		public const int DoingRoot = 7;
	}
}
