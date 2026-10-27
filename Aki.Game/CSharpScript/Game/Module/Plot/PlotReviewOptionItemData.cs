using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FEC RID: 20460
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewOptionItemData
	{
		// Token: 0x17007FD4 RID: 32724
		// (get) Token: 0x060345BE RID: 214462 RVA: 0x00C4D8FA File Offset: 0x00C4BAFA
		// (set) Token: 0x060345BF RID: 214463 RVA: 0x00C4D902 File Offset: 0x00C4BB02
		public ITalkItem TalkItem { get; set; } = new ITalkItem();

		// Token: 0x17007FD5 RID: 32725
		// (get) Token: 0x060345C0 RID: 214464 RVA: 0x00C4D90B File Offset: 0x00C4BB0B
		// (set) Token: 0x060345C1 RID: 214465 RVA: 0x00C4D913 File Offset: 0x00C4BB13
		public int OptionIndex { get; set; }
	}
}
