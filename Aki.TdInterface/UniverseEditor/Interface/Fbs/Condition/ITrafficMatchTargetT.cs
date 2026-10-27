using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CFB RID: 19707
	public class ITrafficMatchTargetT
	{
		// Token: 0x17008EFF RID: 36607
		// (get) Token: 0x0601F47E RID: 128126 RVA: 0x0045D377 File Offset: 0x0045B577
		// (set) Token: 0x0601F47F RID: 128127 RVA: 0x0045D37F File Offset: 0x0045B57F
		public bool MatchPlayer { get; set; }

		// Token: 0x17008F00 RID: 36608
		// (get) Token: 0x0601F480 RID: 128128 RVA: 0x0045D388 File Offset: 0x0045B588
		// (set) Token: 0x0601F481 RID: 128129 RVA: 0x0045D390 File Offset: 0x0045B590
		public ITrafficMatchTargetByEntityLogicT MatchTargetType { get; set; }

		// Token: 0x0601F482 RID: 128130 RVA: 0x0045D399 File Offset: 0x0045B599
		public ITrafficMatchTargetT()
		{
			this.MatchPlayer = false;
			this.MatchTargetType = null;
		}
	}
}
