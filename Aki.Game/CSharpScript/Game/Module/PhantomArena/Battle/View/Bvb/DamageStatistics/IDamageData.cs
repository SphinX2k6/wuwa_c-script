using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x02004248 RID: 16968
	public interface IDamageData
	{
		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x0602AEEB RID: 175851
		// (set) Token: 0x0602AEEC RID: 175852
		long EntityId { get; set; }

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x0602AEED RID: 175853
		// (set) Token: 0x0602AEEE RID: 175854
		int Damage { get; set; }
	}
}
