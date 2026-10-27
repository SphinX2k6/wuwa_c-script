using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E75 RID: 20085
	public class RougeBattleAttributeStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06033B21 RID: 211745 RVA: 0x00C1B471 File Offset: 0x00C19671
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06033B22 RID: 211746 RVA: 0x00C1B4AA File Offset: 0x00C196AA
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
