using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x02006553 RID: 25939
	internal sealed class LinkageRewardActivityTitle : ActivityTitleTypeA
	{
		// Token: 0x06040FFF RID: 266239 RVA: 0x00FC05E8 File Offset: 0x00FBE7E8
		public void ApplyLinkageSubTitleVisible(bool bVisible)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(bVisible);
		}

		// Token: 0x04021E47 RID: 138823
		private const int SubTitleComponentId = 3;
	}
}
