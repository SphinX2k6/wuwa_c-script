using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006227 RID: 25127
	internal class StarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603F5EA RID: 259562 RVA: 0x00F51BB2 File Offset: 0x00F4FDB2
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F5EB RID: 259563 RVA: 0x00F51BD5 File Offset: 0x00F4FDD5
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(1).SetUIActive(data);
		}
	}
}
