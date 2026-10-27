using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015CD RID: 5581
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerTeamItem : UiPanelBase
{
	// Token: 0x17000D80 RID: 3456
	// (get) Token: 0x06009E12 RID: 40466 RVA: 0x00226667 File Offset: 0x00224867
	// (set) Token: 0x06009E13 RID: 40467 RVA: 0x0022666F File Offset: 0x0022486F
	public Action ClickCallback { get; set; }

	// Token: 0x06009E14 RID: 40468 RVA: 0x00226678 File Offset: 0x00224878
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

	// Token: 0x06009E15 RID: 40469 RVA: 0x00226781 File Offset: 0x00224981
	protected override void OnStart()
	{
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), () => new WheelTowerRoleItem(), null, false, true);
	}

	// Token: 0x06009E16 RID: 40470 RVA: 0x002267B8 File Offset: 0x002249B8
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

	// Token: 0x06009E17 RID: 40471 RVA: 0x0022684C File Offset: 0x00224A4C
	private void OnClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x0400463C RID: 17980
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;
}
