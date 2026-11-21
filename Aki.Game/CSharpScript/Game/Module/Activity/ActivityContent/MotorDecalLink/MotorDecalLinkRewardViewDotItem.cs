using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053BD RID: 21437
	public class MotorDecalLinkRewardViewDotItem : GridProxyAbstract<bool>
	{
		// Token: 0x060354EF RID: 218351 RVA: 0x00EE49AE File Offset: 0x00EE2BAE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060354F0 RID: 218352 RVA: 0x00EE49D1 File Offset: 0x00EE2BD1
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
