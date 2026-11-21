using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004136 RID: 16694
	public class PhantomArenaEntranceShopItem : PayShopItem
	{
		// Token: 0x0602A36F RID: 172911 RVA: 0x00BEB2E6 File Offset: 0x00BE94E6
		protected override void OnStart()
		{
			base.OnStart();
			base.SetRedDotState(false);
			base.SetResellShowState(true);
		}
	}
}
