using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015A7 RID: 5543
public class WheelTowerRecordTeamInfoPanel : UiPanelBase
{
	// Token: 0x06009D9E RID: 40350 RVA: 0x0022390C File Offset: 0x00221B0C
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

	// Token: 0x06009D9F RID: 40351 RVA: 0x00223978 File Offset: 0x00221B78
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<WheelTowerRecordRoleGridItem, RoleDataWithBranch>(base.GetHorizontalLayout(0), new Func<WheelTowerRecordRoleGridItem>(this.CreateRoleItem), null, false, true);
		this.BuffLayout = new GenericLayout<WheelTowerBuffGridItem, int>(base.GetHorizontalLayout(2), () => new WheelTowerBuffGridItem(), null, false, true);
	}

	// Token: 0x06009DA0 RID: 40352 RVA: 0x002239DC File Offset: 0x00221BDC
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

	// Token: 0x06009DA1 RID: 40353 RVA: 0x00223AA0 File Offset: 0x00221CA0
	[NullableContext(1)]
	private WheelTowerRecordRoleGridItem CreateRoleItem()
	{
		return new WheelTowerRecordRoleGridItem();
	}

	// Token: 0x0400458B RID: 17803
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecordRoleGridItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x0400458C RID: 17804
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBuffGridItem, int> BuffLayout;
}
