using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x02005278 RID: 21112
	public interface IDamageData
	{
		// Token: 0x17008279 RID: 33401
		// (get) Token: 0x06035FF0 RID: 221168
		// (set) Token: 0x06035FF1 RID: 221169
		long EntityId { get; set; }

		// Token: 0x1700827A RID: 33402
		// (get) Token: 0x06035FF2 RID: 221170
		// (set) Token: 0x06035FF3 RID: 221171
		int Damage { get; set; }
	}
}
