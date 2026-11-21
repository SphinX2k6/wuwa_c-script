using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A5F RID: 2655
public class WheelTowerRecordTeamInfoPanel : UiPanelBase
{
	// Token: 0x0600717C RID: 29052 RVA: 0x0022D6BC File Offset: 0x0022B8BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600717D RID: 29053 RVA: 0x0022D728 File Offset: 0x0022B928
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<WheelTowerRecordRoleGridItem, RoleDataWithBranch>(base.GetHorizontalLayout(0), new Func<WheelTowerRecordRoleGridItem>(this.CreateRoleItem), null, false, true);
		this.BuffLayout = new GenericLayout<WheelTowerBuffGridItem, int>(base.GetHorizontalLayout(2), () => new WheelTowerBuffGridItem(), null, false, true);
	}

	// Token: 0x0600717E RID: 29054 RVA: 0x0022D78C File Offset: 0x0022B98C
	public void Refresh()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		NewTowerClimbingLevelRecord currentLevelRecord = instance.GetCurrentLevelRecord(null);
		int selectedRound = instance.SelectedRound;
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		foreach (RoleSaveInfo roleSaveInfo in currentLevelRecord.TeamChallengeInfos[selectedRound].RoleSaveInfos)
		{
			list.Add(new RoleDataWithBranch(roleSaveInfo.RoleId, roleSaveInfo.SkillBranchId));
		}
		GenericLayout<WheelTowerRecordRoleGridItem, RoleDataWithBranch> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(list, null, false);
		}
		GenericLayout<WheelTowerBuffGridItem, int> buffLayout = this.BuffLayout;
		if (buffLayout == null)
		{
			return;
		}
		buffLayout.RefreshByData(instance.GetRoundSelectBuffList(instance.SelectedRound), null, false);
	}

	// Token: 0x0600717F RID: 29055 RVA: 0x0022D850 File Offset: 0x0022BA50
	[NullableContext(1)]
	private WheelTowerRecordRoleGridItem CreateRoleItem()
	{
		return new WheelTowerRecordRoleGridItem();
	}

	// Token: 0x04004631 RID: 17969
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecordRoleGridItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x04004632 RID: 17970
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBuffGridItem, int> BuffLayout;
}
