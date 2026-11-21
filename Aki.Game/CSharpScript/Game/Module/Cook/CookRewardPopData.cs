using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004ADE RID: 19166
	public class CookRewardPopData : UiPopViewData
	{
		// Token: 0x0602FF0F RID: 196367 RVA: 0x00D61C32 File Offset: 0x00D5FE32
		public CookRewardPopData()
		{
			this.CookRewardPopType = ECookPopType.Unlock;
		}

		// Token: 0x04019734 RID: 104244
		public ECookPopType CookRewardPopType;
	}
}
