using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AFD RID: 23293
	public class CookRewardPopData : UiPopViewData
	{
		// Token: 0x0603AF9D RID: 241565 RVA: 0x00E10F1A File Offset: 0x00E0F11A
		public CookRewardPopData()
		{
			this.CookRewardPopType = ECookPopType.Unlock;
		}

		// Token: 0x0401EC78 RID: 126072
		public ECookPopType CookRewardPopType;
	}
}
