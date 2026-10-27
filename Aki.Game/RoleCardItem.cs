using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B01 RID: 11009
public class RoleCardItem : UiPanelBase
{
	// Token: 0x06016E52 RID: 93778 RVA: 0x005CF1B0 File Offset: 0x005CD3B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06016E53 RID: 93779 RVA: 0x005CF20C File Offset: 0x005CD40C
	public void RefreshBySurvivorRoleId(int survivorRoleId)
	{
		int trialRoleId = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorRoleId).Value.TrialRoleId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(trialRoleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleConfig.Value.Name ?? "", Array.Empty<object>());
		base.SetTextureShowUntilLoaded(roleConfig.Value.FormationRoleCard, base.GetTexture(0), null);
	}

	// Token: 0x06016E54 RID: 93780 RVA: 0x005CF28E File Offset: 0x005CD48E
	public void SetLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x0200910F RID: 37135
	private static class ERoleCard
	{
		// Token: 0x0402EFCA RID: 192458
		public const int TexIcon = 0;

		// Token: 0x0402EFCB RID: 192459
		public const int TxtName = 1;

		// Token: 0x0402EFCC RID: 192460
		public const int TxtLv = 2;
	}
}
