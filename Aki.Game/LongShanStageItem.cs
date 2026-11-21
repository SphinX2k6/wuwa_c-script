using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000758 RID: 1880
public class LongShanStageItem : UiPanelBase
{
	// Token: 0x0600567C RID: 22140 RVA: 0x001C5DA8 File Offset: 0x001C3FA8
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

	// Token: 0x0600567D RID: 22141 RVA: 0x001C5F36 File Offset: 0x001C4136
	[NullableContext(1)]
	public LongShanStageItem(ActivityLongShanData activityData, int id)
	{
		this.ActivityData = activityData;
		this.StageId = id;
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x001C5F4C File Offset: 0x001C414C
	protected override void OnStart()
	{
		this.RefreshState();
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x001C5F54 File Offset: 0x001C4154
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

	// Token: 0x06005680 RID: 22144 RVA: 0x001C604F File Offset: 0x001C424F
	private void OnClickStageDetailInternal()
	{
		Action<int> onClickStageDetail = this.OnClickStageDetail;
		if (onClickStageDetail == null)
		{
			return;
		}
		onClickStageDetail(this.StageId);
	}

	// Token: 0x06005681 RID: 22145 RVA: 0x001C6067 File Offset: 0x001C4267
	public void SetButtonInteractive(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(value);
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x001C607B File Offset: 0x001C427B
	[NullableContext(1)]
	public UUIItem GetLongShanButton()
	{
		return base.GetButton(0).RootUIComp;
	}

	// Token: 0x04003B9E RID: 15262
	private int StageId;

	// Token: 0x04003B9F RID: 15263
	[Nullable(2)]
	private ActivityLongShanData ActivityData;

	// Token: 0x04003BA0 RID: 15264
	[Nullable(2)]
	public Action<int> OnClickStageDetail;

	// Token: 0x02006A48 RID: 27208
	private class EComponents
	{
		// Token: 0x04022F9F RID: 143263
		public const int BtnInfo = 0;

		// Token: 0x04022FA0 RID: 143264
		public const int ItemState = 1;

		// Token: 0x04022FA1 RID: 143265
		public const int TxtName = 2;

		// Token: 0x04022FA2 RID: 143266
		public const int TxtProgress = 3;

		// Token: 0x04022FA3 RID: 143267
		public const int LabelFinish = 4;

		// Token: 0x04022FA4 RID: 143268
		public const int LockItem = 5;

		// Token: 0x04022FA5 RID: 143269
		public const int TxtLockTip = 6;

		// Token: 0x04022FA6 RID: 143270
		public const int RedDot = 7;

		// Token: 0x04022FA7 RID: 143271
		public const int MaskItem = 8;
	}
}
