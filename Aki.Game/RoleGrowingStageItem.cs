using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012AB RID: 4779
public class RoleGrowingStageItem : UiPanelBase
{
	// Token: 0x0600832E RID: 33582 RVA: 0x001BE81F File Offset: 0x001BCA1F
	public RoleGrowingStageItem(int StageId)
	{
		this.StageId = StageId;
	}

	// Token: 0x0600832F RID: 33583 RVA: 0x001BE830 File Offset: 0x001BCA30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
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
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008330 RID: 33584 RVA: 0x001BE940 File Offset: 0x001BCB40
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetCanClickWhenDisable(true);
		extendToggle.CanExecuteChange.Bind(() => false);
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnClickStageDetailInternal));
	}

	// Token: 0x06008331 RID: 33585 RVA: 0x001BE99C File Offset: 0x001BCB9C
	[NullableContext(1)]
	public void Refresh(ActivityLongShanData actData)
	{
		object stageInfoById = actData.GetStageInfoById(this.StageId);
		LongShanStage value = ConfigLongShanStageById.GetConfig(this.StageId, true).Value;
		bool flag = stageInfoById == null;
		int progress = actData.GetProgress(this.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "LongShanStage_ProgressPercentage02", new <>z__ReadOnlySingleElementList<object>(progress.ToString()));
		base.GetItem(1).SetUIActive(progress == 100);
		EToggleState state = flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		if (flag)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(value.OpenConditionId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), conditionGroupHintText, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Title, Array.Empty<object>());
		}
		base.GetItem(4).SetUIActive(actData.CheckStageRed(this.StageId));
	}

	// Token: 0x06008332 RID: 33586 RVA: 0x001BEAA5 File Offset: 0x001BCCA5
	private void OnClickStageDetailInternal(EToggleState toggleState)
	{
		Action<int> onClickStageDetail = this.OnClickStageDetail;
		if (onClickStageDetail == null)
		{
			return;
		}
		onClickStageDetail(this.StageId);
	}

	// Token: 0x04003B1D RID: 15133
	[Nullable(2)]
	public Action<int> OnClickStageDetail;

	// Token: 0x04003B1E RID: 15134
	protected readonly int StageId;

	// Token: 0x020078CA RID: 30922
	private class EComponents
	{
		// Token: 0x04027CB0 RID: 162992
		public const int Toggle = 0;

		// Token: 0x04027CB1 RID: 162993
		public const int FinishItem = 1;

		// Token: 0x04027CB2 RID: 162994
		public const int TxtProgress = 2;

		// Token: 0x04027CB3 RID: 162995
		public const int TxtName = 3;

		// Token: 0x04027CB4 RID: 162996
		public const int RedDot = 4;

		// Token: 0x04027CB5 RID: 162997
		public const int PanelLock = 5;

		// Token: 0x04027CB6 RID: 162998
		public const int PanelUnlock = 6;
	}
}
