using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002335 RID: 9013
public class BattlePassTaskTabItem : UiPanelBase, IGridProxy<EBattlePassTaskUpdateState>
{
	// Token: 0x170016C4 RID: 5828
	// (get) Token: 0x06011D67 RID: 73063 RVA: 0x004652A7 File Offset: 0x004634A7
	// (set) Token: 0x06011D68 RID: 73064 RVA: 0x004652AF File Offset: 0x004634AF
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<EBattlePassTaskUpdateState>, EBattlePassTaskUpdateState> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170016C5 RID: 5829
	// (get) Token: 0x06011D69 RID: 73065 RVA: 0x004652B8 File Offset: 0x004634B8
	// (set) Token: 0x06011D6A RID: 73066 RVA: 0x004652C0 File Offset: 0x004634C0
	public int GridIndex { get; set; }

	// Token: 0x170016C6 RID: 5830
	// (get) Token: 0x06011D6B RID: 73067 RVA: 0x004652C9 File Offset: 0x004634C9
	// (set) Token: 0x06011D6C RID: 73068 RVA: 0x004652D1 File Offset: 0x004634D1
	public int DisplayIndex { get; set; }

	// Token: 0x06011D6D RID: 73069 RVA: 0x004652DC File Offset: 0x004634DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011D6E RID: 73070 RVA: 0x004653C4 File Offset: 0x004635C4
	protected override void OnStart()
	{
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06011D6F RID: 73071 RVA: 0x004653E3 File Offset: 0x004635E3
	private bool CanExecuteChange()
	{
		Func<int, bool> onCanExecuteChange = this.OnCanExecuteChange;
		return onCanExecuteChange == null || onCanExecuteChange(this.GridIndex);
	}

	// Token: 0x06011D70 RID: 73072 RVA: 0x004653FC File Offset: 0x004635FC
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(this.GridIndex);
		}
	}

	// Token: 0x06011D71 RID: 73073 RVA: 0x0046541A File Offset: 0x0046361A
	public void SetForceSwitch(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(2).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06011D72 RID: 73074 RVA: 0x0046542D File Offset: 0x0046362D
	[NullableContext(1)]
	public void SetSelectedCallBack(Action<int> callback)
	{
		this.SelectedCallBack = callback;
	}

	// Token: 0x06011D73 RID: 73075 RVA: 0x00465436 File Offset: 0x00463636
	[NullableContext(1)]
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.OnCanExecuteChange = callback;
	}

	// Token: 0x06011D74 RID: 73076 RVA: 0x0046543F File Offset: 0x0046363F
	public void Refresh(EBattlePassTaskUpdateState data, bool isSelected, int gridIndex)
	{
		this.UpdateView(data);
	}

	// Token: 0x06011D75 RID: 73077 RVA: 0x00465448 File Offset: 0x00463648
	[NullableContext(1)]
	public object GetKey(EBattlePassTaskUpdateState data, int gridIndex)
	{
		return data;
	}

	// Token: 0x06011D76 RID: 73078 RVA: 0x00465450 File Offset: 0x00463650
	public void Clear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06011D77 RID: 73079 RVA: 0x00465458 File Offset: 0x00463658
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06011D78 RID: 73080 RVA: 0x0046545A File Offset: 0x0046365A
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06011D79 RID: 73081 RVA: 0x0046545C File Offset: 0x0046365C
	public void OnSelected()
	{
	}

	// Token: 0x06011D7A RID: 73082 RVA: 0x0046545E File Offset: 0x0046365E
	public void OnDeselected()
	{
	}

	// Token: 0x06011D7B RID: 73083 RVA: 0x00465460 File Offset: 0x00463660
	public void UpdateView(EBattlePassTaskUpdateState type)
	{
		UUIText text = base.GetText(0);
		BattlePassModel instance = BattlePassModel.Instance;
		long num = instance.GetBattlePassEndTime();
		switch (type)
		{
		case EBattlePassTaskUpdateState.Always:
			this.RedDotName = new ERedDotName?(ERedDotName.BattlePassAlwaysTaskTab);
			LguiUtil.Instance.SetLocalTextNew(text, "Text_BattlePassAwalsTask_Text", Array.Empty<object>());
			break;
		case EBattlePassTaskUpdateState.EveryDay:
			num = Math.Min(num, instance.GetDayEndTime());
			LguiUtil.Instance.SetLocalText(text, "BattlePassDayTask", Array.Empty<object>());
			this.RedDotName = new ERedDotName?(ERedDotName.BattlePassDayTaskTab);
			break;
		case EBattlePassTaskUpdateState.EveryWeek:
			num = Math.Min(num, instance.GetWeekEndTime());
			LguiUtil.Instance.SetLocalText(text, "BattlePassWeekTask", Array.Empty<object>());
			this.RedDotName = new ERedDotName?(ERedDotName.BattlePassWeekTaskTab);
			break;
		}
		UUIText text2 = base.GetText(1);
		double num2 = TimeUtil.Instance.CalculateHourGapBetweenNow((double)num, true);
		int num3 = (int)Math.Floor(num2 / TimeUtil.Instance.OneDayHourCount);
		int num4 = (int)Math.Floor(num2 - (double)num3 * TimeUtil.Instance.OneDayHourCount);
		if (num3 > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "Text_BattlePassRefreshTime1_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				num3,
				num4
			}));
		}
		else if (num4 > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "Text_BattlePassRefreshTime2_Text", new <>z__ReadOnlySingleElementList<object>(num4));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "Text_BattlePassRefreshTime3_Text", Array.Empty<object>());
		}
		this.BindRedDot();
	}

	// Token: 0x06011D7C RID: 73084 RVA: 0x004655D1 File Offset: 0x004637D1
	private void BindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(3), null, 0);
		}
	}

	// Token: 0x06011D7D RID: 73085 RVA: 0x004655FE File Offset: 0x004637FE
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0400873A RID: 34618
	private ERedDotName? RedDotName;

	// Token: 0x0400873B RID: 34619
	[Nullable(2)]
	protected Action<int> SelectedCallBack;

	// Token: 0x0400873C RID: 34620
	[Nullable(2)]
	protected Func<int, bool> OnCanExecuteChange;

	// Token: 0x020088B7 RID: 34999
	private enum EComponents
	{
		// Token: 0x0402C6F0 RID: 182000
		TitleText,
		// Token: 0x0402C6F1 RID: 182001
		TimeText,
		// Token: 0x0402C6F2 RID: 182002
		ExtendToggle,
		// Token: 0x0402C6F3 RID: 182003
		RedDot
	}
}
