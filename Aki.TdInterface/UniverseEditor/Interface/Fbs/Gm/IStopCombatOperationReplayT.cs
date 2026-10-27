using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B2 RID: 18098
	public class IStopCombatOperationReplayT
	{
		// Token: 0x1700808A RID: 32906
		// (get) Token: 0x0601B7FF RID: 112639 RVA: 0x003E74D2 File Offset: 0x003E56D2
		// (set) Token: 0x0601B800 RID: 112640 RVA: 0x003E74DA File Offset: 0x003E56DA
		public EGmCommand Type { get; set; }

		// Token: 0x0601B801 RID: 112641 RVA: 0x003E74E3 File Offset: 0x003E56E3
		public IStopCombatOperationReplayT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
