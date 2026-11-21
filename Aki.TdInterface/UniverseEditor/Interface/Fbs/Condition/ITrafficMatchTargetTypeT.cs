using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051FD RID: 20989
	public class ITrafficMatchTargetTypeT
	{
		// Token: 0x17009641 RID: 38465
		// (get) Token: 0x060210F5 RID: 135413 RVA: 0x0049180E File Offset: 0x0048FA0E
		// (set) Token: 0x060210F6 RID: 135414 RVA: 0x00491816 File Offset: 0x0048FA16
		public ETrafficMatchTargetType Type { get; set; }

		// Token: 0x060210F7 RID: 135415 RVA: 0x0049181F File Offset: 0x0048FA1F
		public ITrafficMatchTargetTypeT()
		{
			this.Type = ETrafficMatchTargetType.MatchByEntityLogic;
		}
	}
}
