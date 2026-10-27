using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AC4 RID: 6852
[NullableContext(1)]
[Nullable(0)]
public class MapAreaShowTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x0600CB25 RID: 52005 RVA: 0x002E4F94 File Offset: 0x002E3194
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

	// Token: 0x0600CB26 RID: 52006 RVA: 0x002E505B File Offset: 0x002E325B
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600CB27 RID: 52007 RVA: 0x002E5069 File Offset: 0x002E3269
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

	// Token: 0x0600CB28 RID: 52008 RVA: 0x002E5087 File Offset: 0x002E3287
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600CB29 RID: 52009 RVA: 0x002E5099 File Offset: 0x002E3299
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x0600CB2A RID: 52010 RVA: 0x002E50B4 File Offset: 0x002E32B4
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600CB2B RID: 52011 RVA: 0x002E50B6 File Offset: 0x002E32B6
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600CB2C RID: 52012 RVA: 0x002E50BF File Offset: 0x002E32BF
	public void UpdateView(ExploreStateData stateData)
	{
		base.GetText(1).ShowTextNew(stateData.StateNameKey);
		this.RootItem.SetUIActive(!stateData.IsNoneState);
		this.UpdateTabRedDot(stateData);
	}

	// Token: 0x0600CB2D RID: 52013 RVA: 0x002E50F0 File Offset: 0x002E32F0
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

	// Token: 0x0200801A RID: 32794
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D26 RID: 171302
		SwitchToggle,
		// Token: 0x04029D27 RID: 171303
		Name,
		// Token: 0x04029D28 RID: 171304
		RedDot
	}
}
