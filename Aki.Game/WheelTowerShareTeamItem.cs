using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000AC0 RID: 2752
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerShareTeamItem : GridProxyAbstract<TeamChallengeInfo>
{
	// Token: 0x060072C3 RID: 29379 RVA: 0x00235BF4 File Offset: 0x00233DF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x060072C4 RID: 29380 RVA: 0x00235C7A File Offset: 0x00233E7A
	protected override void OnStart()
	{
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), new Func<WheelTowerRoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x060072C5 RID: 29381 RVA: 0x00235CA0 File Offset: 0x00233EA0
	public override void Refresh(TeamChallengeInfo data, bool isSelected, int gridIndex)
	{
		string icon = WheelTowerConfig.Instance.GetBuffConfigById(data.BuffIds[0]).Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Share_NewTowerTotal_1004", new <>z__ReadOnlySingleElementList<object>(data.TeamScore));
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		foreach (RoleSaveInfo roleSaveInfo in data.RoleSaveInfos)
		{
			list.Add(new RoleDataWithBranch(roleSaveInfo.RoleId, roleSaveInfo.SkillBranchId));
		}
		int teamMaxRoleCount = WheelTowerModel.Instance.GetTeamMaxRoleCount();
		while (list.Count < teamMaxRoleCount)
		{
			list.Add(new RoleDataWithBranch(0, 0));
		}
		GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> roleIconLayout = this.RoleIconLayout;
		if (roleIconLayout == null)
		{
			return;
		}
		roleIconLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060072C6 RID: 29382 RVA: 0x00235DA8 File Offset: 0x00233FA8
	private WheelTowerRoleItem CreateRoleItem()
	{
		return new WheelTowerRoleItem
		{
			IsOnlyShowIcon = true,
			CanClick = false
		};
	}

	// Token: 0x040047D0 RID: 18384
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;

	// Token: 0x02006D5A RID: 27994
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04023E27 RID: 146983
		PnlItem,
		// Token: 0x04023E28 RID: 146984
		LayoutRole,
		// Token: 0x04023E29 RID: 146985
		ItemRole,
		// Token: 0x04023E2A RID: 146986
		TextureSkillIcon,
		// Token: 0x04023E2B RID: 146987
		SkillEmpty,
		// Token: 0x04023E2C RID: 146988
		TextScore
	}
}
