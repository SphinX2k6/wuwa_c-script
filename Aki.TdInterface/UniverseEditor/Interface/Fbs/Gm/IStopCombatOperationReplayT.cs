using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B1A RID: 19226
	public class IStopCombatOperationReplayT
	{
		// Token: 0x170086CB RID: 34507
		// (get) Token: 0x0601CFD4 RID: 118740 RVA: 0x0041376E File Offset: 0x0041196E
		// (set) Token: 0x0601CFD5 RID: 118741 RVA: 0x00413776 File Offset: 0x00411976
		public EGmCommand Type { get; set; }

		// Token: 0x0601CFD6 RID: 118742 RVA: 0x0041377F File Offset: 0x0041197F
		public IStopCombatOperationReplayT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
