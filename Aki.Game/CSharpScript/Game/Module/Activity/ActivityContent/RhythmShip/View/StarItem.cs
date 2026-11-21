using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051A5 RID: 20901
	internal class StarItem : GridProxyAbstract<bool>
	{
		// Token: 0x060342AB RID: 213675 RVA: 0x00E98B0A File Offset: 0x00E96D0A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060342AC RID: 213676 RVA: 0x00E98B2D File Offset: 0x00E96D2D
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(1).SetUIActive(data);
		}
	}
}
