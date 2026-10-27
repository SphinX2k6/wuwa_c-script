using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015D2 RID: 5586
public class WheelTowerLimitRewardTabItem : UiPanelBase
{
	// Token: 0x06009E27 RID: 40487 RVA: 0x00226F70 File Offset: 0x00225170
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

	// Token: 0x06009E28 RID: 40488 RVA: 0x00227058 File Offset: 0x00225258
	protected override void OnStart()
	{
		UUIExtendToggle toggle = base.GetExtendToggle(0);
		toggle.CanExecuteChange.Bind(() => toggle.ToggleState != EToggleState.ETT_Checked);
		WheelTowerModel.Instance.ActivityData.RecordReadReward();
	}

	// Token: 0x06009E29 RID: 40489 RVA: 0x002270A4 File Offset: 0x002252A4
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

	// Token: 0x06009E2A RID: 40490 RVA: 0x0022714E File Offset: 0x0022534E
	[NullableContext(1)]
	public void SetToggleClickCallback(Action<int, UUIExtendToggle> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06009E2B RID: 40491 RVA: 0x00227157 File Offset: 0x00225357
	public void SetToggleStateForce(bool isSelected, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06009E2C RID: 40492 RVA: 0x00227174 File Offset: 0x00225374
	public void OnDeselected(bool fireEvent)
	{
		this.SetToggleStateForce(false, false);
	}

	// Token: 0x06009E2D RID: 40493 RVA: 0x0022717E File Offset: 0x0022537E
	private void OnClickToggle(EToggleState state)
	{
		Action<int, UUIExtendToggle> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback(this.Diff, base.GetExtendToggle(0));
	}

	// Token: 0x0400464F RID: 17999
	private int Diff = -1;

	// Token: 0x04004650 RID: 18000
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleClickCallback;
}
