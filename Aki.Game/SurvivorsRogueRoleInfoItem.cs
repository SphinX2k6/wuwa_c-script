using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B67 RID: 11111
public class SurvivorsRogueRoleInfoItem : UiPanelBase
{
	// Token: 0x06017066 RID: 94310 RVA: 0x005D87A0 File Offset: 0x005D69A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06017067 RID: 94311 RVA: 0x005D87FA File Offset: 0x005D69FA
	protected override void OnStart()
	{
	}

	// Token: 0x06017068 RID: 94312 RVA: 0x005D87FC File Offset: 0x005D69FC
	public void Refresh(int roleId, int lv)
	{
		SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(roleId);
		if (survivorsRole == null)
		{
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(survivorsRole.Value.TrialRoleId, true);
		RoleInfo? roleInfo = (roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : null;
		if (roleInfo == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(roleInfo.Value.FormationRoleCard, base.GetTexture(0), null);
		base.GetText(1).SetText(roleDataById.GetName(null), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(lv));
		base.GetText(2).SetUIActive(true);
	}
}
