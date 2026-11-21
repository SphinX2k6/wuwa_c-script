using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200075F RID: 1887
public class RoleGrowingStageItem : UiPanelBase
{
	// Token: 0x060056C5 RID: 22213 RVA: 0x001C75AF File Offset: 0x001C57AF
	public RoleGrowingStageItem(int StageId)
	{
		this.StageId = StageId;
	}

	// Token: 0x060056C6 RID: 22214 RVA: 0x001C75C0 File Offset: 0x001C57C0
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

	// Token: 0x060056C7 RID: 22215 RVA: 0x001C76D0 File Offset: 0x001C58D0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetCanClickWhenDisable(true);
		extendToggle.CanExecuteChange.Bind(() => false);
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnClickStageDetailInternal));
	}

	// Token: 0x060056C8 RID: 22216 RVA: 0x001C772C File Offset: 0x001C592C
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

	// Token: 0x060056C9 RID: 22217 RVA: 0x001C7835 File Offset: 0x001C5A35
	private void OnClickStageDetailInternal(EToggleState toggleState)
	{
		Action<int> onClickStageDetail = this.OnClickStageDetail;
		if (onClickStageDetail == null)
		{
			return;
		}
		onClickStageDetail(this.StageId);
	}

	// Token: 0x04003BB5 RID: 15285
	[Nullable(2)]
	public Action<int> OnClickStageDetail;

	// Token: 0x04003BB6 RID: 15286
	protected readonly int StageId;

	// Token: 0x02006A54 RID: 27220
	private class EComponents
	{
		// Token: 0x04022FDE RID: 143326
		public const int Toggle = 0;

		// Token: 0x04022FDF RID: 143327
		public const int FinishItem = 1;

		// Token: 0x04022FE0 RID: 143328
		public const int TxtProgress = 2;

		// Token: 0x04022FE1 RID: 143329
		public const int TxtName = 3;

		// Token: 0x04022FE2 RID: 143330
		public const int RedDot = 4;

		// Token: 0x04022FE3 RID: 143331
		public const int PanelLock = 5;

		// Token: 0x04022FE4 RID: 143332
		public const int PanelUnlock = 6;
	}
}
