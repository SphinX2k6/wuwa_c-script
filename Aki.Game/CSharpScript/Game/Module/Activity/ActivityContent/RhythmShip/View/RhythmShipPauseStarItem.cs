using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051AE RID: 20910
	internal class RhythmShipPauseStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x060342C6 RID: 213702 RVA: 0x00E9934C File Offset: 0x00E9754C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060342C7 RID: 213703 RVA: 0x00E9936F File Offset: 0x00E9756F
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(1).SetUIActive(data);
		}
	}
}
