using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB9 RID: 27577
	public class INpcGroupPerformInitiatorTypeT
	{
		// Token: 0x1700CCF9 RID: 52473
		// (get) Token: 0x06030727 RID: 198439 RVA: 0x0069445E File Offset: 0x0069265E
		// (set) Token: 0x06030728 RID: 198440 RVA: 0x00694466 File Offset: 0x00692666
		public ENpcGroupPerformInitiatorType Type { get; set; }

		// Token: 0x06030729 RID: 198441 RVA: 0x0069446F File Offset: 0x0069266F
		public INpcGroupPerformInitiatorTypeT()
		{
			this.Type = ENpcGroupPerformInitiatorType.Player;
		}
	}
}
