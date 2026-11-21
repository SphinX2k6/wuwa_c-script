using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A85 RID: 2693
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerTeamItem : UiPanelBase
{
	// Token: 0x17000DA1 RID: 3489
	// (get) Token: 0x060071F0 RID: 29168 RVA: 0x00230417 File Offset: 0x0022E617
	// (set) Token: 0x060071F1 RID: 29169 RVA: 0x0023041F File Offset: 0x0022E61F
	public Action ClickCallback { get; set; }

	// Token: 0x060071F2 RID: 29170 RVA: 0x00230428 File Offset: 0x0022E628
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060071F3 RID: 29171 RVA: 0x00230531 File Offset: 0x0022E731
	protected override void OnStart()
	{
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), () => new WheelTowerRoleItem(), null, false, true);
	}

	// Token: 0x060071F4 RID: 29172 RVA: 0x00230568 File Offset: 0x0022E768
	[NullableContext(1)]
	public void Refresh(List<RoleDataWithBranch> roleDataList)
	{
		GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> roleIconLayout = this.RoleIconLayout;
		if (roleIconLayout != null)
		{
			roleIconLayout.RefreshByData(roleDataList, null, false);
		}
		List<IConflictInfo> list = WheelTowerModel.Instance.CheckCurrentSelectConflict();
		bool uiactive = false;
		foreach (IConflictInfo conflictInfo in list)
		{
			if (WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(conflictInfo.RoleId) > 0)
			{
				uiactive = true;
				break;
			}
		}
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x060071F5 RID: 29173 RVA: 0x002305FC File Offset: 0x0022E7FC
	private void OnClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x040046E2 RID: 18146
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;
}
