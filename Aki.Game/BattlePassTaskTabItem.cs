using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200181A RID: 6170
public class BattlePassTaskTabItem : UiPanelBase, IGridProxy<EBattlePassTaskUpdateState>
{
	// Token: 0x170016FE RID: 5886
	// (get) Token: 0x0600F217 RID: 61975 RVA: 0x0047236F File Offset: 0x0047056F
	// (set) Token: 0x0600F218 RID: 61976 RVA: 0x00472377 File Offset: 0x00470577
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

	// Token: 0x170016FF RID: 5887
	// (get) Token: 0x0600F219 RID: 61977 RVA: 0x00472380 File Offset: 0x00470580
	// (set) Token: 0x0600F21A RID: 61978 RVA: 0x00472388 File Offset: 0x00470588
	public int GridIndex { get; set; }

	// Token: 0x17001700 RID: 5888
	// (get) Token: 0x0600F21B RID: 61979 RVA: 0x00472391 File Offset: 0x00470591
	// (set) Token: 0x0600F21C RID: 61980 RVA: 0x00472399 File Offset: 0x00470599
	public int DisplayIndex { get; set; }

	// Token: 0x0600F21D RID: 61981 RVA: 0x004723A4 File Offset: 0x004705A4
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

	// Token: 0x0600F21E RID: 61982 RVA: 0x0047248C File Offset: 0x0047068C
	protected override void OnStart()
	{
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600F21F RID: 61983 RVA: 0x004724AB File Offset: 0x004706AB
	private bool CanExecuteChange()
	{
		Func<int, bool> onCanExecuteChange = this.OnCanExecuteChange;
		return onCanExecuteChange == null || onCanExecuteChange(this.GridIndex);
	}

	// Token: 0x0600F220 RID: 61984 RVA: 0x004724C4 File Offset: 0x004706C4
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

	// Token: 0x0600F221 RID: 61985 RVA: 0x004724E2 File Offset: 0x004706E2
	public void SetForceSwitch(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(2).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600F222 RID: 61986 RVA: 0x004724F5 File Offset: 0x004706F5
	[NullableContext(1)]
	public void SetSelectedCallBack(Action<int> callback)
	{
		this.SelectedCallBack = callback;
	}

	// Token: 0x0600F223 RID: 61987 RVA: 0x004724FE File Offset: 0x004706FE
	[NullableContext(1)]
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.OnCanExecuteChange = callback;
	}

	// Token: 0x0600F224 RID: 61988 RVA: 0x00472507 File Offset: 0x00470707
	public void Refresh(EBattlePassTaskUpdateState data, bool isSelected, int gridIndex)
	{
		this.UpdateView(data);
	}

	// Token: 0x0600F225 RID: 61989 RVA: 0x00472510 File Offset: 0x00470710
	[NullableContext(1)]
	public object GetKey(EBattlePassTaskUpdateState data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600F226 RID: 61990 RVA: 0x00472518 File Offset: 0x00470718
	public void Clear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600F227 RID: 61991 RVA: 0x00472520 File Offset: 0x00470720
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F228 RID: 61992 RVA: 0x00472522 File Offset: 0x00470722
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F229 RID: 61993 RVA: 0x00472524 File Offset: 0x00470724
	public void OnSelected()
	{
	}

	// Token: 0x0600F22A RID: 61994 RVA: 0x00472526 File Offset: 0x00470726
	public void OnDeselected()
	{
	}

	// Token: 0x0600F22B RID: 61995 RVA: 0x00472528 File Offset: 0x00470728
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

	// Token: 0x0600F22C RID: 61996 RVA: 0x00472699 File Offset: 0x00470899
	private void BindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(3), null, 0);
		}
	}

	// Token: 0x0600F22D RID: 61997 RVA: 0x004726C6 File Offset: 0x004708C6
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0400887D RID: 34941
	private ERedDotName? RedDotName;

	// Token: 0x0400887E RID: 34942
	[Nullable(2)]
	protected Action<int> SelectedCallBack;

	// Token: 0x0400887F RID: 34943
	[Nullable(2)]
	protected Func<int, bool> OnCanExecuteChange;

	// Token: 0x02007A40 RID: 31296
	private enum EComponents
	{
		// Token: 0x04027A04 RID: 162308
		TitleText,
		// Token: 0x04027A05 RID: 162309
		TimeText,
		// Token: 0x04027A06 RID: 162310
		ExtendToggle,
		// Token: 0x04027A07 RID: 162311
		RedDot
	}
}
