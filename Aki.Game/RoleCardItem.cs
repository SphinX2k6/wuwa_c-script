using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200207D RID: 8317
public class RoleCardItem : UiPanelBase
{
	// Token: 0x06014883 RID: 84099 RVA: 0x005FBD30 File Offset: 0x005F9F30
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06014884 RID: 84100 RVA: 0x005FBD8C File Offset: 0x005F9F8C
	public void RefreshBySurvivorRoleId(int survivorRoleId)
	{
		int trialRoleId = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorRoleId).Value.TrialRoleId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(trialRoleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleConfig.Value.Name ?? "", Array.Empty<object>());
		base.SetTextureShowUntilLoaded(roleConfig.Value.FormationRoleCard, base.GetTexture(0), null);
	}

	// Token: 0x06014885 RID: 84101 RVA: 0x005FBE0E File Offset: 0x005FA00E
	public void SetLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x02008352 RID: 33618
	private static class ERoleCard
	{
		// Token: 0x0402A6CF RID: 173775
		public const int TexIcon = 0;

		// Token: 0x0402A6D0 RID: 173776
		public const int TxtName = 1;

		// Token: 0x0402A6D1 RID: 173777
		public const int TxtLv = 2;
	}
}
