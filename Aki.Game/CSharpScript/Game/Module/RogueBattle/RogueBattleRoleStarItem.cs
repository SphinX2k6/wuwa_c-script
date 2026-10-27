using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E91 RID: 20113
	public class RogueBattleRoleStarItem : GridProxyAbstract<ERogueRoleStarState>
	{
		// Token: 0x06033B83 RID: 211843 RVA: 0x00C1D640 File Offset: 0x00C1B840
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

		// Token: 0x06033B84 RID: 211844 RVA: 0x00C1D6C6 File Offset: 0x00C1B8C6
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(true);
		}

		// Token: 0x06033B85 RID: 211845 RVA: 0x00C1D6D8 File Offset: 0x00C1B8D8
		public override void Refresh(ERogueRoleStarState state, bool isSelected, int gridIndex)
		{
			base.GetSprite(1).SetUIActive(state == ERogueRoleStarState.Active);
			base.GetSprite(2).SetUIActive(state == ERogueRoleStarState.LightOn);
			base.GetItem(3).SetUIActive(state == ERogueRoleStarState.Active);
			base.GetItem(4).SetUIActive(state == ERogueRoleStarState.LightOn);
		}
	}
}
