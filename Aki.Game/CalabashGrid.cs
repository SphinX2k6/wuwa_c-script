using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001749 RID: 5961
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashGrid : AutoAttachItem<CalabashGridData>
{
	// Token: 0x0600AC69 RID: 44137 RVA: 0x0026AA84 File Offset: 0x00268C84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.SelectedItem))
		};
	}

	// Token: 0x0600AC6A RID: 44138 RVA: 0x0026ABF9 File Offset: 0x00268DF9
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x0600AC6B RID: 44139 RVA: 0x0026AC1E File Offset: 0x00268E1E
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x0600AC6C RID: 44140 RVA: 0x0026AC38 File Offset: 0x00268E38
	[NullableContext(1)]
	protected override void OnRefreshItem(CalabashGridData data)
	{
		int level = data.Level;
		ECalabashRewardState receiveRewardStateByLevel = CalabashModel.Instance.GetReceiveRewardStateByLevel(level);
		bool levelReach = CalabashModel.Instance.GetCalabashLevel() >= level;
		this.LevelReach = levelReach;
		base.GetItem(4).SetUIActive(receiveRewardStateByLevel == ECalabashRewardState.CanReceive);
		base.GetItem(8).SetUIActive(receiveRewardStateByLevel == ECalabashRewardState.HasReceived);
		if (data.IsMaxLevel)
		{
			base.GetItem(5).SetUIActive(false);
		}
		else
		{
			base.GetItem(5).SetUIActive(true);
			int maxExp = data.MaxExp;
			int overFlowExp = data.OverFlowExp;
			base.GetSprite(6).SetFillAmount((float)overFlowExp / (float)maxExp);
			base.GetSprite(7).SetFillAmount((float)data.LimitExp / (float)maxExp);
		}
		bool currentSelectedState = base.GetCurrentSelectedState();
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(currentSelectedState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		this.SetSelectState(currentSelectedState);
		this.RefreshLevelText(level);
		this.RefreshLevelTextColor(currentSelectedState, levelReach);
		this.RefreshSpecialUi(level, levelReach);
		this.RefreshSpecialActiveEffectItem(levelReach, data.IsMaxLevel);
	}

	// Token: 0x0600AC6D RID: 44141 RVA: 0x0026AD40 File Offset: 0x00268F40
	private void RefreshSpecialReachItem(int level, bool levelReach)
	{
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(levelReach);
	}

	// Token: 0x0600AC6E RID: 44142 RVA: 0x0026AD62 File Offset: 0x00268F62
	private void RefreshSpecialActiveEffectItem(bool levelReach, bool isMaxLevel)
	{
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(levelReach && isMaxLevel);
		}
		UUIItem item2 = base.GetItem(13);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(levelReach && isMaxLevel);
	}

	// Token: 0x0600AC6F RID: 44143 RVA: 0x0026AD90 File Offset: 0x00268F90
	private void RefreshSpecialInActiveItem(int level, bool levelReach)
	{
		bool uiactive = !levelReach;
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600AC70 RID: 44144 RVA: 0x0026ADB8 File Offset: 0x00268FB8
	private void RefreshSpecialUi(int level, bool levelReach)
	{
		if (CalabashConfig.Instance.GetCalabashConfigByLevel(level) == null)
		{
			this.RefreshSpecialReachItem(0, levelReach);
			this.RefreshSpecialInActiveItem(0, levelReach);
			return;
		}
		this.RefreshSpecialReachItem(level, levelReach);
		this.RefreshSpecialInActiveItem(level, levelReach);
	}

	// Token: 0x0600AC71 RID: 44145 RVA: 0x0026ADFC File Offset: 0x00268FFC
	private void RefreshLevelText(int level)
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(level.ToString(), true);
		}
	}

	// Token: 0x0600AC72 RID: 44146 RVA: 0x0026AE24 File Offset: 0x00269024
	private void RefreshLevelTextColor(bool isSelected, bool levelReach)
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = !isSelected && !levelReach;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
	}

	// Token: 0x0600AC73 RID: 44147 RVA: 0x0026AE56 File Offset: 0x00269056
	private void SelectedItem(EToggleState toggleState)
	{
		Action<int> buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction(this.CurrentShowItemIndex);
	}

	// Token: 0x0600AC74 RID: 44148 RVA: 0x0026AE6E File Offset: 0x0026906E
	public override void OnSelect()
	{
		this.SetSelectState(true);
		this.SelectedItem(EToggleState.ETT_Checked);
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		this.RefreshLevelTextColor(true, this.LevelReach);
	}

	// Token: 0x0600AC75 RID: 44149 RVA: 0x0026AEA4 File Offset: 0x002690A4
	protected override void OnUnSelect()
	{
		this.SetSelectState(false);
		bool bIngnoreAnim = true;
		if (base.GetCurrentSelectedState())
		{
			bIngnoreAnim = false;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, bIngnoreAnim, false);
		}
		this.RefreshLevelTextColor(false, this.LevelReach);
	}

	// Token: 0x0600AC76 RID: 44150 RVA: 0x0026AEE9 File Offset: 0x002690E9
	public void SetSelectState(bool isSelected)
	{
	}

	// Token: 0x0600AC77 RID: 44151 RVA: 0x0026AEEB File Offset: 0x002690EB
	protected override void OnMoveItem()
	{
	}

	// Token: 0x0600AC78 RID: 44152 RVA: 0x0026AEED File Offset: 0x002690ED
	public CalabashGrid() : base(null)
	{
	}

	// Token: 0x04004E4F RID: 20047
	public Action<int> ButtonFunction;

	// Token: 0x04004E50 RID: 20048
	public Func<bool> CheckToggleCanClick;

	// Token: 0x04004E51 RID: 20049
	public UCurveFloat ItemCurve;

	// Token: 0x04004E52 RID: 20050
	private bool LevelReach;
}
