using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013BE RID: 5054
public class ActivityNewPlayerSupportRewardRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06008E91 RID: 36497 RVA: 0x001EC3AF File Offset: 0x001EA5AF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x06008E92 RID: 36498 RVA: 0x001EC3E8 File Offset: 0x001EA5E8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		TrialRoleConfig instance = TrialRoleConfig.Instance;
		TrialRoleInfo? trialRoleInfo = (instance != null) ? instance.GetTrialRoleConfig(data) : null;
		int parentId = trialRoleInfo.Value.ParentId;
		UUITexture texture = base.GetTexture(0);
		string card = RoleConfig.Instance.GetRoleConfig(parentId).Value.Card;
		base.SetRoleIcon(card, texture, parentId, null, null);
		string trialRoleLabelIconByType = RoleUtils.GetTrialRoleLabelIconByType((ETrialRoleType)trialRoleInfo.Value.Type);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(trialRoleLabelIconByType);
		this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
	}

	// Token: 0x02007A33 RID: 31283
	private static class EComponentType
	{
		// Token: 0x0402839B RID: 164763
		public const int RoleTex = 0;

		// Token: 0x0402839C RID: 164764
		public const int IconSprite = 1;
	}
}
