using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EB4 RID: 20148
	public class RogueBattleTokenElement : GridProxyAbstract<int>
	{
		// Token: 0x06033BF9 RID: 211961 RVA: 0x00C1FD24 File Offset: 0x00C1DF24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x06033BFA RID: 211962 RVA: 0x00C1FD60 File Offset: 0x00C1DF60
		public override void Refresh(int elementId, bool isSelected, int gridIndex)
		{
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
			if (elementConfig == null)
			{
				return;
			}
			FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
			base.GetSprite(0).SetColor(color);
			base.SetTextureByPath(elementConfig.Value.Icon5, base.GetTexture(1), null, null);
		}
	}
}
