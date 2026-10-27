using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200621A RID: 25114
	internal class RhythmShipChoseStarItem : UiPanelBase
	{
		// Token: 0x0603F5B2 RID: 259506 RVA: 0x00F50513 File Offset: 0x00F4E713
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F5B3 RID: 259507 RVA: 0x00F5054C File Offset: 0x00F4E74C
		public void SetLightItemActive(bool value)
		{
			base.GetItem(1).SetUIActive(value);
		}
	}
}
