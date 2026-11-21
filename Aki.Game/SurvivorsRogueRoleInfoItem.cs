using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020E3 RID: 8419
public class SurvivorsRogueRoleInfoItem : UiPanelBase
{
	// Token: 0x06014A97 RID: 84631 RVA: 0x00605308 File Offset: 0x00603508
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06014A98 RID: 84632 RVA: 0x00605362 File Offset: 0x00603562
	protected override void OnStart()
	{
	}

	// Token: 0x06014A99 RID: 84633 RVA: 0x00605364 File Offset: 0x00603564
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
