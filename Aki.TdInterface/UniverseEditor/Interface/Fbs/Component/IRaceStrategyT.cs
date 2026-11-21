using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDD RID: 24029
	public class IRaceStrategyT
	{
		// Token: 0x1700B105 RID: 45317
		// (get) Token: 0x06028142 RID: 164162 RVA: 0x0057B19B File Offset: 0x0057939B
		// (set) Token: 0x06028143 RID: 164163 RVA: 0x0057B1A3 File Offset: 0x005793A3
		public EAiGearStrategy Type { get; set; }

		// Token: 0x1700B106 RID: 45318
		// (get) Token: 0x06028144 RID: 164164 RVA: 0x0057B1AC File Offset: 0x005793AC
		// (set) Token: 0x06028145 RID: 164165 RVA: 0x0057B1B4 File Offset: 0x005793B4
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B107 RID: 45319
		// (get) Token: 0x06028146 RID: 164166 RVA: 0x0057B1BD File Offset: 0x005793BD
		// (set) Token: 0x06028147 RID: 164167 RVA: 0x0057B1C5 File Offset: 0x005793C5
		public int SplineEntityId { get; set; }

		// Token: 0x1700B108 RID: 45320
		// (get) Token: 0x06028148 RID: 164168 RVA: 0x0057B1CE File Offset: 0x005793CE
		// (set) Token: 0x06028149 RID: 164169 RVA: 0x0057B1D6 File Offset: 0x005793D6
		public string CommonConfig { get; set; }

		// Token: 0x0602814A RID: 164170 RVA: 0x0057B1DF File Offset: 0x005793DF
		public IRaceStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
			this.SplineEntityId = 0;
			this.CommonConfig = null;
		}
	}
}
