using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200276C RID: 10092
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RogueBattleFetterIconItem : GridProxyAbstract<RogueBattleRoleBondUpdateInfo>
{
	// Token: 0x06014B16 RID: 84758 RVA: 0x0053C842 File Offset: 0x0053AA42
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06014B17 RID: 84759 RVA: 0x0053C87B File Offset: 0x0053AA7B
	public override void Refresh(RogueBattleRoleBondUpdateInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshSelectState(false);
	}

	// Token: 0x06014B18 RID: 84760 RVA: 0x0053C88C File Offset: 0x0053AA8C
	public void RefreshSelectState(bool isSelected)
	{
		RoleBondInfo roleBondInfo = isSelected ? this.Data.NewRoleBondInfo : this.Data.OldRoleBondInfo;
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(roleBondInfo.ConfigId);
		RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(roleBondInfo.Level);
		if (rogueResBond == null || bondLvConfigByLv == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(1);
		UUIItem uuiitem = texture;
		bool bUseChangeColor = roleBondInfo.Level == 0;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
		UUIItem sprite = base.GetSprite(0);
		FColor color = FColor.FromHex((roleBondInfo.Level > 0) ? bondLvConfigByLv.Value.LvColor : "FFFFFF7F");
		sprite.SetColor(color);
	}

	// Token: 0x04009B92 RID: 39826
	private RogueBattleRoleBondUpdateInfo Data;
}
