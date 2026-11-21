using System;

namespace CSharpScript.Game.Module.Sheriff.View.Shop
{
	// Token: 0x02003C10 RID: 15376
	public class SheriffShopItem : PayShopItem
	{
		// Token: 0x0602765E RID: 161374 RVA: 0x00B0B3D2 File Offset: 0x00B095D2
		protected override void OnStart()
		{
			base.OnStart();
			base.SetRedDotState(false);
		}
	}
}
