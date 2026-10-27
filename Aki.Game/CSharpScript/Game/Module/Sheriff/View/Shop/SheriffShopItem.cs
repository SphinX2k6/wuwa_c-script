using System;

namespace CSharpScript.Game.Module.Sheriff.View.Shop
{
	// Token: 0x02004C5F RID: 19551
	public class SheriffShopItem : PayShopItem
	{
		// Token: 0x060328AB RID: 207019 RVA: 0x00BC6786 File Offset: 0x00BC4986
		protected override void OnStart()
		{
			base.OnStart();
			base.SetRedDotState(false);
		}
	}
}
