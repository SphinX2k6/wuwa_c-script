using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448E RID: 17550
	public class IQuestStatisticsT
	{
		// Token: 0x170079E0 RID: 31200
		// (get) Token: 0x0601942E RID: 103470 RVA: 0x0039AD02 File Offset: 0x00398F02
		// (set) Token: 0x0601942F RID: 103471 RVA: 0x0039AD0A File Offset: 0x00398F0A
		public List<TQuestStatisticsUnion> StatisticsConfig { get; set; }

		// Token: 0x170079E1 RID: 31201
		// (get) Token: 0x06019430 RID: 103472 RVA: 0x0039AD13 File Offset: 0x00398F13
		// (set) Token: 0x06019431 RID: 103473 RVA: 0x0039AD1B File Offset: 0x00398F1B
		public List<ICommonCalculateVarT> CalculationOnTriggeringStatistics { get; set; }

		// Token: 0x170079E2 RID: 31202
		// (get) Token: 0x06019432 RID: 103474 RVA: 0x0039AD24 File Offset: 0x00398F24
		// (set) Token: 0x06019433 RID: 103475 RVA: 0x0039AD2C File Offset: 0x00398F2C
		public byte NullMask { get; set; }

		// Token: 0x06019434 RID: 103476 RVA: 0x0039AD35 File Offset: 0x00398F35
		public IQuestStatisticsT()
		{
			this.StatisticsConfig = null;
			this.CalculationOnTriggeringStatistics = null;
			this.NullMask = 0;
		}
	}
}
