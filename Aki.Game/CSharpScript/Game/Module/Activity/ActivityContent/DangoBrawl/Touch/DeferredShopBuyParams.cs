using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006855 RID: 26709
	public class DeferredShopBuyParams
	{
		// Token: 0x04022B7A RID: 142202
		public int SlotUid;

		// Token: 0x04022B7B RID: 142203
		public int ConfigId;

		// Token: 0x04022B7C RID: 142204
		public bool ToBench;

		// Token: 0x04022B7D RID: 142205
		[Nullable(2)]
		public DangoBrawlBagSlotInfo BagSlot;
	}
}
