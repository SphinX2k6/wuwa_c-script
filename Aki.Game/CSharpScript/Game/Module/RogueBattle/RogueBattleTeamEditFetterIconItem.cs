using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E76 RID: 15990
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTeamEditFetterIconItem : GridProxyAbstract<IRogueBattleRoleBondUpdateInfo>
	{
		// Token: 0x06028A35 RID: 166453 RVA: 0x00B682B8 File Offset: 0x00B664B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06028A36 RID: 166454 RVA: 0x00B68328 File Offset: 0x00B66528
		public override void Refresh(IRogueBattleRoleBondUpdateInfo data, bool isSelected, int gridIndex)
		{
			RoleBondInfo newRoleBondInfo = data.NewRoleBondInfo;
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(newRoleBondInfo.ConfigId);
			RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(newRoleBondInfo.Level);
			if (rogueResBond == null || bondLvConfigByLv == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = newRoleBondInfo.Level == 0;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			UUIItem sprite = base.GetSprite(0);
			FColor color = FColor.FromHex((newRoleBondInfo.Level > 0) ? bondLvConfigByLv.Value.LvColor : "FFFFFF7F");
			sprite.SetColor(color);
			this.SetLinkEffectOn(false);
		}

		// Token: 0x06028A37 RID: 166455 RVA: 0x00B683EB File Offset: 0x00B665EB
		public void SetLinkEffectOn(bool bOn)
		{
			base.GetItem(2).SetUIActive(bOn);
			base.GetItem(3).SetUIActive(bOn);
		}

		// Token: 0x06028A38 RID: 166456 RVA: 0x00B68407 File Offset: 0x00B66607
		public override object GetKey(IRogueBattleRoleBondUpdateInfo data, int displayIndex)
		{
			return data.NewRoleBondInfo.ConfigId;
		}
	}
}
