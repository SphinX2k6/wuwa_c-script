using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002168 RID: 8552
public class TowerDetailSwitchItem : UiPanelBase
{
	// Token: 0x06014FDF RID: 85983 RVA: 0x0061D6E6 File Offset: 0x0061B8E6
	[NullableContext(1)]
	public TowerDetailSwitchItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FE0 RID: 85984 RVA: 0x0061D6FC File Offset: 0x0061B8FC
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

	// Token: 0x06014FE1 RID: 85985 RVA: 0x0061D7A2 File Offset: 0x0061B9A2
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleGroup(null);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06014FE2 RID: 85986 RVA: 0x0061D7D3 File Offset: 0x0061B9D3
	private bool CanExecuteChange()
	{
		return TowerDetailModel.Instance.CurrentSelectDetailId != this.TowerSwitchData.Index;
	}

	// Token: 0x06014FE3 RID: 85987 RVA: 0x0061D7F0 File Offset: 0x0061B9F0
	[NullableContext(1)]
	public void Update(TowerSwitchData data)
	{
		this.TowerSwitchData = data;
		string name = data.Name;
		base.GetText(1).SetText(name, true);
		this.RefreshView();
	}

	// Token: 0x06014FE4 RID: 85988 RVA: 0x0061D81F File Offset: 0x0061BA1F
	private void RefreshView()
	{
		if (TowerDetailModel.Instance.CurrentSelectDetailId != this.TowerSwitchData.Index)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014FE5 RID: 85989 RVA: 0x0061D859 File Offset: 0x0061BA59
	private void OnClickSwitchToggle(EToggleState toggleState)
	{
		TowerDetailModel.Instance.CurrentSelectDetailId = this.TowerSwitchData.Index;
		EventSystem.Instance.Emit(EEventName.OnClickSingleTimeTowerDetailSwitchBtn);
	}

	// Token: 0x0400B2D1 RID: 45777
	[Nullable(2)]
	private TowerSwitchData TowerSwitchData;

	// Token: 0x020083ED RID: 33773
	private class EChildType
	{
		// Token: 0x0402A917 RID: 174359
		public const int SwitchToggle = 0;

		// Token: 0x0402A918 RID: 174360
		public const int TitleText = 1;
	}
}
