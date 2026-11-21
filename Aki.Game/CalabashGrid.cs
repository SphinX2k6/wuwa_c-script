using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02000C02 RID: 3074
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashGrid : AutoAttachItem<CalabashGridData>
{
	// Token: 0x06008050 RID: 32848 RVA: 0x00274ECC File Offset: 0x002730CC
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

	// Token: 0x06008051 RID: 32849 RVA: 0x00275041 File Offset: 0x00273241
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x06008052 RID: 32850 RVA: 0x00275066 File Offset: 0x00273266
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x06008053 RID: 32851 RVA: 0x00275080 File Offset: 0x00273280
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

	// Token: 0x06008054 RID: 32852 RVA: 0x00275188 File Offset: 0x00273388
	private void RefreshSpecialReachItem(int level, bool levelReach)
	{
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(levelReach);
	}

	// Token: 0x06008055 RID: 32853 RVA: 0x002751AA File Offset: 0x002733AA
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

	// Token: 0x06008056 RID: 32854 RVA: 0x002751D8 File Offset: 0x002733D8
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

	// Token: 0x06008057 RID: 32855 RVA: 0x00275200 File Offset: 0x00273400
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

	// Token: 0x06008058 RID: 32856 RVA: 0x00275244 File Offset: 0x00273444
	private void RefreshLevelText(int level)
	{
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(level.ToString(), true);
		}
	}

	// Token: 0x06008059 RID: 32857 RVA: 0x0027526C File Offset: 0x0027346C
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

	// Token: 0x0600805A RID: 32858 RVA: 0x0027529E File Offset: 0x0027349E
	private void SelectedItem(EToggleState toggleState)
	{
		Action<int> buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction(this.CurrentShowItemIndex);
	}

	// Token: 0x0600805B RID: 32859 RVA: 0x002752B6 File Offset: 0x002734B6
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

	// Token: 0x0600805C RID: 32860 RVA: 0x002752EC File Offset: 0x002734EC
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

	// Token: 0x0600805D RID: 32861 RVA: 0x00275331 File Offset: 0x00273531
	public void SetSelectState(bool isSelected)
	{
	}

	// Token: 0x0600805E RID: 32862 RVA: 0x00275333 File Offset: 0x00273533
	protected override void OnMoveItem()
	{
	}

	// Token: 0x0600805F RID: 32863 RVA: 0x00275335 File Offset: 0x00273535
	public CalabashGrid() : base(null)
	{
	}

	// Token: 0x04004EF8 RID: 20216
	public Action<int> ButtonFunction;

	// Token: 0x04004EF9 RID: 20217
	public Func<bool> CheckToggleCanClick;

	// Token: 0x04004EFA RID: 20218
	public UCurveFloat ItemCurve;

	// Token: 0x04004EFB RID: 20219
	private bool LevelReach;
}
