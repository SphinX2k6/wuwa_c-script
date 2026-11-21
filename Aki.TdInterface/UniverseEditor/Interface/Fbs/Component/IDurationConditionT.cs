using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005635 RID: 22069
	public class IDurationConditionT
	{
		// Token: 0x17009E7E RID: 40574
		// (get) Token: 0x060233DF RID: 144351 RVA: 0x004D9778 File Offset: 0x004D7978
		// (set) Token: 0x060233E0 RID: 144352 RVA: 0x004D9780 File Offset: 0x004D7980
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x17009E7F RID: 40575
		// (get) Token: 0x060233E1 RID: 144353 RVA: 0x004D9789 File Offset: 0x004D7989
		// (set) Token: 0x060233E2 RID: 144354 RVA: 0x004D9791 File Offset: 0x004D7991
		public float Duration { get; set; }

		// Token: 0x17009E80 RID: 40576
		// (get) Token: 0x060233E3 RID: 144355 RVA: 0x004D979A File Offset: 0x004D799A
		// (set) Token: 0x060233E4 RID: 144356 RVA: 0x004D97A2 File Offset: 0x004D79A2
		public bool Refill { get; set; }

		// Token: 0x17009E81 RID: 40577
		// (get) Token: 0x060233E5 RID: 144357 RVA: 0x004D97AB File Offset: 0x004D79AB
		// (set) Token: 0x060233E6 RID: 144358 RVA: 0x004D97B3 File Offset: 0x004D79B3
		public byte NullMask { get; set; }

		// Token: 0x060233E7 RID: 144359 RVA: 0x004D97BC File Offset: 0x004D79BC
		public IDurationConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
			this.Duration = 0f;
			this.Refill = false;
			this.NullMask = 0;
		}
	}
}
