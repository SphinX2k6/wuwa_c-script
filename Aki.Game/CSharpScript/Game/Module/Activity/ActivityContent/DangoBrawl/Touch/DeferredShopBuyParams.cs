using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A5 RID: 22437
	public class DeferredShopBuyParams
	{
		// Token: 0x0401D3D7 RID: 119767
		public int SlotUid;

		// Token: 0x0401D3D8 RID: 119768
		public int ConfigId;

		// Token: 0x0401D3D9 RID: 119769
		public bool ToBench;

		// Token: 0x0401D3DA RID: 119770
		[Nullable(2)]
		public DangoBrawlBagSlotInfo BagSlot;
	}
}
