using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02005198 RID: 20888
	internal class RhythmShipChoseStarItem : UiPanelBase
	{
		// Token: 0x06034273 RID: 213619 RVA: 0x00E9746B File Offset: 0x00E9566B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06034274 RID: 213620 RVA: 0x00E974A4 File Offset: 0x00E956A4
		public void SetLightItemActive(bool value)
		{
			base.GetItem(1).SetUIActive(value);
		}
	}
}
