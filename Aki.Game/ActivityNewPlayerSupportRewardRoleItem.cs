using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000872 RID: 2162
public class ActivityNewPlayerSupportRewardRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06006226 RID: 25126 RVA: 0x001F4ECF File Offset: 0x001F30CF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x001F4F08 File Offset: 0x001F3108
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

	// Token: 0x02006BB9 RID: 27577
	private static class EComponentType
	{
		// Token: 0x040236B8 RID: 145080
		public const int RoleTex = 0;

		// Token: 0x040236B9 RID: 145081
		public const int IconSprite = 1;
	}
}
