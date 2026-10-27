using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E5B RID: 20059
	public class FetterItem : GridProxyAbstract<FetterData>
	{
		// Token: 0x06033AD7 RID: 211671 RVA: 0x00C197C8 File Offset: 0x00C179C8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06033AD8 RID: 211672 RVA: 0x00C19822 File Offset: 0x00C17A22
		public override void Refresh(FetterData data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x06033AD9 RID: 211673 RVA: 0x00C1982C File Offset: 0x00C17A2C
		public void Refresh(FetterData data)
		{
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(data.Id);
			RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(data.Lv);
			if (rogueResBond == null || bondLvConfigByLv == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = data.Lv == 0;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			UUISprite sprite = base.GetSprite(0);
			FColor color = FColor.FromHex(bondLvConfigByLv.Value.LvColor);
			sprite.SetColor(color);
			sprite.SetUIActive(data.Lv > 0);
			base.GetText(2).SetText(data.Star.ToString(), true);
		}
	}
}
