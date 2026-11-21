using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005633 RID: 22067
	public class DropCatchRewardStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603689A RID: 223386 RVA: 0x00F38621 File Offset: 0x00F36821
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0603689B RID: 223387 RVA: 0x00F3865A File Offset: 0x00F3685A
		public override void Refresh(bool visible, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(visible);
		}
	}
}
