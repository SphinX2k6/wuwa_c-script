using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x02004249 RID: 16969
	public class DamageData : IDamageData
	{
		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x0602AEEF RID: 175855 RVA: 0x00C149F3 File Offset: 0x00C12BF3
		// (set) Token: 0x0602AEF0 RID: 175856 RVA: 0x00C149FB File Offset: 0x00C12BFB
		public long EntityId { get; set; }

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x0602AEF1 RID: 175857 RVA: 0x00C14A04 File Offset: 0x00C12C04
		// (set) Token: 0x0602AEF2 RID: 175858 RVA: 0x00C14A0C File Offset: 0x00C12C0C
		public int Damage { get; set; }
	}
}
