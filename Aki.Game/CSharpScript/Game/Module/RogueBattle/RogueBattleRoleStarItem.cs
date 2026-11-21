using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E5A RID: 15962
	public class RogueBattleRoleStarItem : GridProxyAbstract<ERogueRoleStarState>
	{
		// Token: 0x060289EE RID: 166382 RVA: 0x00B66B5C File Offset: 0x00B64D5C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x060289EF RID: 166383 RVA: 0x00B66BE2 File Offset: 0x00B64DE2
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(true);
		}

		// Token: 0x060289F0 RID: 166384 RVA: 0x00B66BF4 File Offset: 0x00B64DF4
		public override void Refresh(ERogueRoleStarState state, bool isSelected, int gridIndex)
		{
			base.GetSprite(1).SetUIActive(state == ERogueRoleStarState.Active);
			base.GetSprite(2).SetUIActive(state == ERogueRoleStarState.LightOn);
			base.GetItem(3).SetUIActive(state == ERogueRoleStarState.Active);
			base.GetItem(4).SetUIActive(state == ERogueRoleStarState.LightOn);
		}
	}
}
