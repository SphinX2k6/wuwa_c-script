using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012A4 RID: 4772
public class LongShanStageItem : UiPanelBase
{
	// Token: 0x060082E5 RID: 33509 RVA: 0x001BD018 File Offset: 0x001BB218
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickStageDetailInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060082E6 RID: 33510 RVA: 0x001BD1A6 File Offset: 0x001BB3A6
	[NullableContext(1)]
	public LongShanStageItem(ActivityLongShanData activityData, int id)
	{
		this.ActivityData = activityData;
		this.StageId = id;
	}

	// Token: 0x060082E7 RID: 33511 RVA: 0x001BD1BC File Offset: 0x001BB3BC
	protected override void OnStart()
	{
		this.RefreshState();
	}

	// Token: 0x060082E8 RID: 33512 RVA: 0x001BD1C4 File Offset: 0x001BB3C4
	public void RefreshState()
	{
		LongShanStage value = ConfigLongShanStageById.GetConfig(this.StageId, true).Value;
		LongShanStageInfo stageInfoById = this.ActivityData.GetStageInfoById(this.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Title, Array.Empty<object>());
		bool flag = stageInfoById == null;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(8).SetUIActive(!flag);
		int progress = this.ActivityData.GetProgress(this.StageId);
		base.GetItem(4).SetUIActive(progress == 100);
		if (stageInfoById == null)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(value.OpenConditionId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), conditionGroupHintText, Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "LongShanStage_ProgressPercentage02", new <>z__ReadOnlySingleElementList<object>(progress));
		base.GetItem(7).SetUIActive(this.ActivityData.CheckStageRed(this.StageId));
	}

	// Token: 0x060082E9 RID: 33513 RVA: 0x001BD2BF File Offset: 0x001BB4BF
	private void OnClickStageDetailInternal()
	{
		Action<int> onClickStageDetail = this.OnClickStageDetail;
		if (onClickStageDetail == null)
		{
			return;
		}
		onClickStageDetail(this.StageId);
	}

	// Token: 0x060082EA RID: 33514 RVA: 0x001BD2D7 File Offset: 0x001BB4D7
	public void SetButtonInteractive(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(value);
	}

	// Token: 0x060082EB RID: 33515 RVA: 0x001BD2EB File Offset: 0x001BB4EB
	[NullableContext(1)]
	public UUIItem GetLongShanButton()
	{
		return base.GetButton(0).RootUIComp;
	}

	// Token: 0x04003B06 RID: 15110
	private int StageId;

	// Token: 0x04003B07 RID: 15111
	[Nullable(2)]
	private ActivityLongShanData ActivityData;

	// Token: 0x04003B08 RID: 15112
	[Nullable(2)]
	public Action<int> OnClickStageDetail;

	// Token: 0x020078BE RID: 30910
	private class EComponents
	{
		// Token: 0x04027C71 RID: 162929
		public const int BtnInfo = 0;

		// Token: 0x04027C72 RID: 162930
		public const int ItemState = 1;

		// Token: 0x04027C73 RID: 162931
		public const int TxtName = 2;

		// Token: 0x04027C74 RID: 162932
		public const int TxtProgress = 3;

		// Token: 0x04027C75 RID: 162933
		public const int LabelFinish = 4;

		// Token: 0x04027C76 RID: 162934
		public const int LockItem = 5;

		// Token: 0x04027C77 RID: 162935
		public const int TxtLockTip = 6;

		// Token: 0x04027C78 RID: 162936
		public const int RedDot = 7;

		// Token: 0x04027C79 RID: 162937
		public const int MaskItem = 8;
	}
}
