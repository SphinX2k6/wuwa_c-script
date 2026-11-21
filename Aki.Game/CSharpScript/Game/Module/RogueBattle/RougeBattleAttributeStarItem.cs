using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E3E RID: 15934
	public class RougeBattleAttributeStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0602898C RID: 166284 RVA: 0x00B64995 File Offset: 0x00B62B95
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602898D RID: 166285 RVA: 0x00B649CE File Offset: 0x00B62BCE
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data);
		}
	}
}
