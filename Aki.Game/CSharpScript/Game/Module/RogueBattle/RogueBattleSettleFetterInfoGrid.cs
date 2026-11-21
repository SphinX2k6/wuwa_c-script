using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E60 RID: 15968
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleSettleFetterInfoGrid : GridProxyAbstract<RoleBondInfo>
	{
		// Token: 0x060289F8 RID: 166392 RVA: 0x00B670D8 File Offset: 0x00B652D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x060289F9 RID: 166393 RVA: 0x00B67134 File Offset: 0x00B65334
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
