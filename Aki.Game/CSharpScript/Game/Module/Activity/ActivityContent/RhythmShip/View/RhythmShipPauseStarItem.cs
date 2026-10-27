using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006230 RID: 25136
	internal class RhythmShipPauseStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603F605 RID: 259589 RVA: 0x00F523F0 File Offset: 0x00F505F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F606 RID: 259590 RVA: 0x00F52413 File Offset: 0x00F50613
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(1).SetUIActive(data);
		}
	}
}
