using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005166 RID: 20838
	public class PhantomArenaEntranceShopItem : PayShopItem
	{
		// Token: 0x06035473 RID: 218227 RVA: 0x00C9DDB6 File Offset: 0x00C9BFB6
		protected override void OnStart()
		{
			base.OnStart();
			base.SetRedDotState(false);
			base.SetResellShowState(true);
		}
	}
}
