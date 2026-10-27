using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B40 RID: 11072
internal class RoleItemComponent : UiPanelBase
{
	// Token: 0x06016F87 RID: 94087 RVA: 0x005D4C28 File Offset: 0x005D2E28
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

	// Token: 0x06016F88 RID: 94088 RVA: 0x005D4CD4 File Offset: 0x005D2ED4
	private void OnClickRoleIcon()
	{
		SurvivorsRogueCharacterCard param = SurvivorsRogueCardDataFactory.CreateGeneralCharacter(this.CachedSurvivorRoleId);
		UiManager.Instance.OpenView(EUiViewName.SurvivorsCardTips, param, null);
	}

	// Token: 0x06016F89 RID: 94089 RVA: 0x005D4CFE File Offset: 0x005D2EFE
	protected override void OnStart()
	{
	}

	// Token: 0x06016F8A RID: 94090 RVA: 0x005D4D00 File Offset: 0x005D2F00
	public void Refresh(int survivorRoleId)
	{
		this.CachedSurvivorRoleId = survivorRoleId;
		int trialRoleId = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorRoleId).Value.TrialRoleId;
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(trialRoleId).Value;
		string roleHeadIconCircle = value.RoleHeadIconCircle;
		base.SetTextureShowUntilLoaded(roleHeadIconCircle, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value.Name, Array.Empty<object>());
	}

	// Token: 0x0400AB41 RID: 43841
	private int CachedSurvivorRoleId = -1;
}
