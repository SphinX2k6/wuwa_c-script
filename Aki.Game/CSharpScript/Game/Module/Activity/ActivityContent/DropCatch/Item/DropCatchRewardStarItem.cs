using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066E3 RID: 26339
	public class DropCatchRewardStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06041D4E RID: 269646 RVA: 0x00FF721D File Offset: 0x00FF541D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06041D4F RID: 269647 RVA: 0x00FF7256 File Offset: 0x00FF5456
		public override void Refresh(bool visible, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(visible);
		}
	}
}
