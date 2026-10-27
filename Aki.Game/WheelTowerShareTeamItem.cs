using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001608 RID: 5640
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerShareTeamItem : GridProxyAbstract<TeamChallengeInfo>
{
	// Token: 0x06009EE5 RID: 40677 RVA: 0x0022BDF4 File Offset: 0x00229FF4
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

	// Token: 0x06009EE6 RID: 40678 RVA: 0x0022BE7A File Offset: 0x0022A07A
	protected override void OnStart()
	{
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), new Func<WheelTowerRoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x06009EE7 RID: 40679 RVA: 0x0022BEA0 File Offset: 0x0022A0A0
	public override void Refresh(TeamChallengeInfo data, bool isSelected, int gridIndex)
	{
		string icon = WheelTowerConfig.Instance.GetBuffConfigById(data.BuffIds[0]).Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Share_NewTowerTotal_1004", new <>z__ReadOnlySingleElementList<object>(data.TeamScore));
		List<RoleDataWithBranch> list = (from info in data.RoleSaveInfos
		select new RoleDataWithBranch(info.RoleId, info.SkillBranchId)).ToList<RoleDataWithBranch>();
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

	// Token: 0x06009EE8 RID: 40680 RVA: 0x0022BF7A File Offset: 0x0022A17A
	private WheelTowerRoleItem CreateRoleItem()
	{
		return new WheelTowerRoleItem
		{
			IsOnlyShowIcon = true,
			CanClick = false
		};
	}

	// Token: 0x0400472A RID: 18218
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;

	// Token: 0x02007BD1 RID: 31697
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04028AF0 RID: 166640
		PnlItem,
		// Token: 0x04028AF1 RID: 166641
		LayoutRole,
		// Token: 0x04028AF2 RID: 166642
		ItemRole,
		// Token: 0x04028AF3 RID: 166643
		TextureSkillIcon,
		// Token: 0x04028AF4 RID: 166644
		SkillEmpty,
		// Token: 0x04028AF5 RID: 166645
		TextScore
	}
}
