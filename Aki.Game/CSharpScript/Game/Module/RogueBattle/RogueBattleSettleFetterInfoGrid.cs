using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E97 RID: 20119
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleSettleFetterInfoGrid : GridProxyAbstract<RoleBondInfo>
	{
		// Token: 0x06033B8D RID: 211853 RVA: 0x00C1DBBC File Offset: 0x00C1BDBC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06033B8E RID: 211854 RVA: 0x00C1DC18 File Offset: 0x00C1BE18
		public override void Refresh(RoleBondInfo data, bool isSelected, int gridIndex)
		{
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(data.ConfigId);
			if (rogueResBond == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, base.GetTexture(1), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RogueRes_FightFormation_RoleLevel", new <>z__ReadOnlySingleElementList<object>(data.Level.ToString()));
		}
	}
}
