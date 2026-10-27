using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BED RID: 11245
public class TowerDetailSwitchItem : UiPanelBase
{
	// Token: 0x060175AE RID: 95662 RVA: 0x005F0B86 File Offset: 0x005EED86
	[NullableContext(1)]
	public TowerDetailSwitchItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060175AF RID: 95663 RVA: 0x005F0B9C File Offset: 0x005EED9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickSwitchToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060175B0 RID: 95664 RVA: 0x005F0C42 File Offset: 0x005EEE42
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleGroup(null);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x060175B1 RID: 95665 RVA: 0x005F0C73 File Offset: 0x005EEE73
	private bool CanExecuteChange()
	{
		return TowerDetailModel.Instance.CurrentSelectDetailId != this.TowerSwitchData.Index;
	}

	// Token: 0x060175B2 RID: 95666 RVA: 0x005F0C90 File Offset: 0x005EEE90
	[NullableContext(1)]
	public void Update(TowerSwitchData data)
	{
		this.TowerSwitchData = data;
		string name = data.Name;
		base.GetText(1).SetText(name, true);
		this.RefreshView();
	}

	// Token: 0x060175B3 RID: 95667 RVA: 0x005F0CBF File Offset: 0x005EEEBF
	private void RefreshView()
	{
		if (TowerDetailModel.Instance.CurrentSelectDetailId != this.TowerSwitchData.Index)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060175B4 RID: 95668 RVA: 0x005F0CF9 File Offset: 0x005EEEF9
	private void OnClickSwitchToggle(EToggleState toggleState)
	{
		TowerDetailModel.Instance.CurrentSelectDetailId = this.TowerSwitchData.Index;
		EventSystem.Instance.Emit(EEventName.OnClickSingleTimeTowerDetailSwitchBtn);
	}

	// Token: 0x0400AECC RID: 44748
	[Nullable(2)]
	private TowerSwitchData TowerSwitchData;

	// Token: 0x020091AA RID: 37290
	private class EChildType
	{
		// Token: 0x0402F216 RID: 193046
		public const int SwitchToggle = 0;

		// Token: 0x0402F217 RID: 193047
		public const int TitleText = 1;
	}
}
