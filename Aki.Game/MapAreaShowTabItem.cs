using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F83 RID: 3971
[NullableContext(1)]
[Nullable(0)]
public class MapAreaShowTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06009F36 RID: 40758 RVA: 0x002F0118 File Offset: 0x002EE318
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009F37 RID: 40759 RVA: 0x002F01DF File Offset: 0x002EE3DF
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06009F38 RID: 40760 RVA: 0x002F01ED File Offset: 0x002EE3ED
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> selectedCallBack = this.SelectedCallBack;
			if (selectedCallBack == null)
			{
				return;
			}
			selectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06009F39 RID: 40761 RVA: 0x002F020B File Offset: 0x002EE40B
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x06009F3A RID: 40762 RVA: 0x002F021D File Offset: 0x002EE41D
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x06009F3B RID: 40763 RVA: 0x002F0238 File Offset: 0x002EE438
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06009F3C RID: 40764 RVA: 0x002F023A File Offset: 0x002EE43A
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06009F3D RID: 40765 RVA: 0x002F0243 File Offset: 0x002EE443
	public void UpdateView(ExploreStateData stateData)
	{
		base.GetText(1).ShowTextNew(stateData.StateNameKey);
		this.RootItem.SetUIActive(!stateData.IsNoneState);
		this.UpdateTabRedDot(stateData);
	}

	// Token: 0x06009F3E RID: 40766 RVA: 0x002F0274 File Offset: 0x002EE474
	public void UpdateTabRedDot(ExploreStateData stateData)
	{
		if (stateData.IsNoneState)
		{
			return;
		}
		bool uiactive = stateData.HasCanTakeStageReward();
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x020071A9 RID: 29097
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402505F RID: 151647
		SwitchToggle,
		// Token: 0x04025060 RID: 151648
		Name,
		// Token: 0x04025061 RID: 151649
		RedDot
	}
}
