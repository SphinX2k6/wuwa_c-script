using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054D1 RID: 21713
	internal sealed class LinkageRewardActivityTitle : ActivityTitleTypeA
	{
		// Token: 0x06035CC4 RID: 220356 RVA: 0x00F075D8 File Offset: 0x00F057D8
		public void ApplyLinkageSubTitleVisible(bool bVisible)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(bVisible);
		}

		// Token: 0x0401C778 RID: 116600
		private const int SubTitleComponentId = 3;
	}
}
