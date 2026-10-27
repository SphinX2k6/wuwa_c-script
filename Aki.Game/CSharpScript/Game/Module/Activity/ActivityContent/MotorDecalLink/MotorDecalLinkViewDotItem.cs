using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006443 RID: 25667
	public class MotorDecalLinkViewDotItem : GridProxyAbstract<bool>
	{
		// Token: 0x06040842 RID: 264258 RVA: 0x00F9E05E File Offset: 0x00F9C25E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06040843 RID: 264259 RVA: 0x00F9E081 File Offset: 0x00F9C281
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
