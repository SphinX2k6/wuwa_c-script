using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x02005279 RID: 21113
	public class DamageData : IDamageData
	{
		// Token: 0x1700827B RID: 33403
		// (get) Token: 0x06035FF4 RID: 221172 RVA: 0x00CC72F3 File Offset: 0x00CC54F3
		// (set) Token: 0x06035FF5 RID: 221173 RVA: 0x00CC72FB File Offset: 0x00CC54FB
		public long EntityId { get; set; }

		// Token: 0x1700827C RID: 33404
		// (get) Token: 0x06035FF6 RID: 221174 RVA: 0x00CC7304 File Offset: 0x00CC5504
		// (set) Token: 0x06035FF7 RID: 221175 RVA: 0x00CC730C File Offset: 0x00CC550C
		public int Damage { get; set; }
	}
}
