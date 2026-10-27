using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C3 RID: 22211
	public class IPasserbyNpcFixIntervalSpawnT
	{
		// Token: 0x1700A54D RID: 42317
		// (get) Token: 0x060251A6 RID: 151974 RVA: 0x0051F7E2 File Offset: 0x0051D9E2
		// (set) Token: 0x060251A7 RID: 151975 RVA: 0x0051F7EA File Offset: 0x0051D9EA
		public EPasserbyNpcSpawnType Type { get; set; }

		// Token: 0x1700A54E RID: 42318
		// (get) Token: 0x060251A8 RID: 151976 RVA: 0x0051F7F3 File Offset: 0x0051D9F3
		// (set) Token: 0x060251A9 RID: 151977 RVA: 0x0051F7FB File Offset: 0x0051D9FB
		public int MaxSpawnCount { get; set; }

		// Token: 0x1700A54F RID: 42319
		// (get) Token: 0x060251AA RID: 151978 RVA: 0x0051F804 File Offset: 0x0051DA04
		// (set) Token: 0x060251AB RID: 151979 RVA: 0x0051F80C File Offset: 0x0051DA0C
		public int MinDistance { get; set; }

		// Token: 0x1700A550 RID: 42320
		// (get) Token: 0x060251AC RID: 151980 RVA: 0x0051F815 File Offset: 0x0051DA15
		// (set) Token: 0x060251AD RID: 151981 RVA: 0x0051F81D File Offset: 0x0051DA1D
		public float Interval { get; set; }

		// Token: 0x1700A551 RID: 42321
		// (get) Token: 0x060251AE RID: 151982 RVA: 0x0051F826 File Offset: 0x0051DA26
		// (set) Token: 0x060251AF RID: 151983 RVA: 0x0051F82E File Offset: 0x0051DA2E
		public byte NullMask { get; set; }

		// Token: 0x060251B0 RID: 151984 RVA: 0x0051F837 File Offset: 0x0051DA37
		public IPasserbyNpcFixIntervalSpawnT()
		{
			this.Type = EPasserbyNpcSpawnType.FixInterval;
			this.MaxSpawnCount = 0;
			this.MinDistance = 0;
			this.Interval = 0f;
			this.NullMask = 0;
		}
	}
}
