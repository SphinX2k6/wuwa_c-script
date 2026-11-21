using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006161 RID: 24929
	public class IWalkingPatternStayAwayConfigT
	{
		// Token: 0x1700B9C0 RID: 47552
		// (get) Token: 0x0602A52F RID: 173359 RVA: 0x005C6466 File Offset: 0x005C4666
		// (set) Token: 0x0602A530 RID: 173360 RVA: 0x005C646E File Offset: 0x005C466E
		public int SplineDistance { get; set; }

		// Token: 0x1700B9C1 RID: 47553
		// (get) Token: 0x0602A531 RID: 173361 RVA: 0x005C6477 File Offset: 0x005C4677
		// (set) Token: 0x0602A532 RID: 173362 RVA: 0x005C647F File Offset: 0x005C467F
		public int StayAwayTime { get; set; }

		// Token: 0x1700B9C2 RID: 47554
		// (get) Token: 0x0602A533 RID: 173363 RVA: 0x005C6488 File Offset: 0x005C4688
		// (set) Token: 0x0602A534 RID: 173364 RVA: 0x005C6490 File Offset: 0x005C4690
		public byte NullMask { get; set; }

		// Token: 0x0602A535 RID: 173365 RVA: 0x005C6499 File Offset: 0x005C4699
		public IWalkingPatternStayAwayConfigT()
		{
			this.SplineDistance = 0;
			this.StayAwayTime = 0;
			this.NullMask = 0;
		}
	}
}
