using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020BC RID: 8380
internal class RoleItemComponent : UiPanelBase
{
	// Token: 0x060149B8 RID: 84408 RVA: 0x00601794 File Offset: 0x005FF994
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickRoleIcon))
		};
	}

	// Token: 0x060149B9 RID: 84409 RVA: 0x00601840 File Offset: 0x005FFA40
	private void OnClickRoleIcon()
	{
		SurvivorsRogueCharacterCard param = SurvivorsRogueCardDataFactory.CreateGeneralCharacter(this.CachedSurvivorRoleId);
		UiManager.Instance.OpenView(EUiViewName.SurvivorsCardTips, param, null);
	}

	// Token: 0x060149BA RID: 84410 RVA: 0x0060186A File Offset: 0x005FFA6A
	protected override void OnStart()
	{
	}

	// Token: 0x060149BB RID: 84411 RVA: 0x0060186C File Offset: 0x005FFA6C
	public void Refresh(int survivorRoleId)
	{
		this.CachedSurvivorRoleId = survivorRoleId;
		int trialRoleId = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorRoleId).Value.TrialRoleId;
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(trialRoleId).Value;
		string roleHeadIconCircle = value.RoleHeadIconCircle;
		base.SetTextureShowUntilLoaded(roleHeadIconCircle, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value.Name, Array.Empty<object>());
	}

	// Token: 0x0400AF47 RID: 44871
	private int CachedSurvivorRoleId = -1;
}
