using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x0200643F RID: 25663
	public class MotorDecalLinkRewardViewDotItem : GridProxyAbstract<bool>
	{
		// Token: 0x0604082E RID: 264238 RVA: 0x00F9DA32 File Offset: 0x00F9BC32
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x0604082F RID: 264239 RVA: 0x00F9DA55 File Offset: 0x00F9BC55
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
