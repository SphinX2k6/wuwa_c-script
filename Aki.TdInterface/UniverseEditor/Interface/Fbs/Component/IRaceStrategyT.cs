using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D6 RID: 22486
	public class IRaceStrategyT
	{
		// Token: 0x1700A7E1 RID: 42977
		// (get) Token: 0x06025C22 RID: 154658 RVA: 0x0053500F File Offset: 0x0053320F
		// (set) Token: 0x06025C23 RID: 154659 RVA: 0x00535017 File Offset: 0x00533217
		public EAiGearStrategy Type { get; set; }

		// Token: 0x1700A7E2 RID: 42978
		// (get) Token: 0x06025C24 RID: 154660 RVA: 0x00535020 File Offset: 0x00533220
		// (set) Token: 0x06025C25 RID: 154661 RVA: 0x00535028 File Offset: 0x00533228
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A7E3 RID: 42979
		// (get) Token: 0x06025C26 RID: 154662 RVA: 0x00535031 File Offset: 0x00533231
		// (set) Token: 0x06025C27 RID: 154663 RVA: 0x00535039 File Offset: 0x00533239
		public int SplineEntityId { get; set; }

		// Token: 0x1700A7E4 RID: 42980
		// (get) Token: 0x06025C28 RID: 154664 RVA: 0x00535042 File Offset: 0x00533242
		// (set) Token: 0x06025C29 RID: 154665 RVA: 0x0053504A File Offset: 0x0053324A
		public string CommonConfig { get; set; }

		// Token: 0x06025C2A RID: 154666 RVA: 0x00535053 File Offset: 0x00533253
		public IRaceStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
			this.SplineEntityId = 0;
			this.CommonConfig = null;
		}
	}
}
