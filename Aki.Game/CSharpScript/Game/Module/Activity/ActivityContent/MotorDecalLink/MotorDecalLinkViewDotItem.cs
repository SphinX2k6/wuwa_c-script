using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053C1 RID: 21441
	public class MotorDecalLinkViewDotItem : GridProxyAbstract<bool>
	{
		// Token: 0x06035503 RID: 218371 RVA: 0x00EE4FDA File Offset: 0x00EE31DA
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06035504 RID: 218372 RVA: 0x00EE4FFD File Offset: 0x00EE31FD
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data);
		}
	}
}
