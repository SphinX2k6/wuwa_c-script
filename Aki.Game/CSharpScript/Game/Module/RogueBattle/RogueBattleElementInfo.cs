using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC0 RID: 20160
	public class RogueBattleElementInfo : IRogueBattleElementInfo
	{
		// Token: 0x17007EE4 RID: 32484
		// (get) Token: 0x06033C56 RID: 212054 RVA: 0x00C20E38 File Offset: 0x00C1F038
		// (set) Token: 0x06033C57 RID: 212055 RVA: 0x00C20E40 File Offset: 0x00C1F040
		public int ElementId { get; set; }

		// Token: 0x17007EE5 RID: 32485
		// (get) Token: 0x06033C58 RID: 212056 RVA: 0x00C20E49 File Offset: 0x00C1F049
		// (set) Token: 0x06033C59 RID: 212057 RVA: 0x00C20E51 File Offset: 0x00C1F051
		public int Count { get; set; }

		// Token: 0x17007EE6 RID: 32486
		// (get) Token: 0x06033C5A RID: 212058 RVA: 0x00C20E5A File Offset: 0x00C1F05A
		// (set) Token: 0x06033C5B RID: 212059 RVA: 0x00C20E62 File Offset: 0x00C1F062
		public bool IsPreview { get; set; }
	}
}
