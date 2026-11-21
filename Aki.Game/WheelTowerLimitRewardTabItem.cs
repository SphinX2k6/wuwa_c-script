using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A8A RID: 2698
public class WheelTowerLimitRewardTabItem : UiPanelBase
{
	// Token: 0x06007205 RID: 29189 RVA: 0x00230D20 File Offset: 0x0022EF20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007206 RID: 29190 RVA: 0x00230E08 File Offset: 0x0022F008
	protected override void OnStart()
	{
		UUIExtendToggle toggle = base.GetExtendToggle(0);
		toggle.CanExecuteChange.Bind(() => toggle.ToggleState != EToggleState.ETT_Checked);
		WheelTowerModel.Instance.ActivityData.RecordReadReward();
	}

	// Token: 0x06007207 RID: 29191 RVA: 0x00230E54 File Offset: 0x0022F054
	public void Refresh(int diff)
	{
		this.Diff = diff;
		bool flag = diff == 1;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(flag ? "WheelBattleMode_Endless" : "WheelBattleMode_Normal");
		}
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		EFilterMode filterMode = flag ? EFilterMode.Endless : EFilterMode.Normal;
		int totalRewardProgress = activityData.GetTotalRewardProgress(filterMode);
		int currentRewardProgress = activityData.GetCurrentRewardProgress(filterMode);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "WheelBattleMode_Progress", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentRewardProgress,
			totalRewardProgress
		}));
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(activityData.HasAnyRewardCanReceive(filterMode));
	}

	// Token: 0x06007208 RID: 29192 RVA: 0x00230EFE File Offset: 0x0022F0FE
	[NullableContext(1)]
	public void SetToggleClickCallback(Action<int, UUIExtendToggle> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x00230F07 File Offset: 0x0022F107
	public void SetToggleStateForce(bool isSelected, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600720A RID: 29194 RVA: 0x00230F24 File Offset: 0x0022F124
	public void OnDeselected(bool fireEvent)
	{
		this.SetToggleStateForce(false, false);
	}

	// Token: 0x0600720B RID: 29195 RVA: 0x00230F2E File Offset: 0x0022F12E
	private void OnClickToggle(EToggleState state)
	{
		Action<int, UUIExtendToggle> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback(this.Diff, base.GetExtendToggle(0));
	}

	// Token: 0x040046F5 RID: 18165
	private int Diff = -1;

	// Token: 0x040046F6 RID: 18166
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleClickCallback;
}
