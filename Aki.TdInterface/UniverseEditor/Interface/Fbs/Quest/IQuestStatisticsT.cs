using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404D RID: 16461
	public class IQuestStatisticsT
	{
		// Token: 0x170073DE RID: 29662
		// (get) Token: 0x06017D95 RID: 97685 RVA: 0x00370F0E File Offset: 0x0036F10E
		// (set) Token: 0x06017D96 RID: 97686 RVA: 0x00370F16 File Offset: 0x0036F116
		public List<TQuestStatisticsUnion> StatisticsConfig { get; set; }

		// Token: 0x170073DF RID: 29663
		// (get) Token: 0x06017D97 RID: 97687 RVA: 0x00370F1F File Offset: 0x0036F11F
		// (set) Token: 0x06017D98 RID: 97688 RVA: 0x00370F27 File Offset: 0x0036F127
		public List<ICommonCalculateVarT> CalculationOnTriggeringStatistics { get; set; }

		// Token: 0x170073E0 RID: 29664
		// (get) Token: 0x06017D99 RID: 97689 RVA: 0x00370F30 File Offset: 0x0036F130
		// (set) Token: 0x06017D9A RID: 97690 RVA: 0x00370F38 File Offset: 0x0036F138
		public byte NullMask { get; set; }

		// Token: 0x06017D9B RID: 97691 RVA: 0x00370F41 File Offset: 0x0036F141
		public IQuestStatisticsT()
		{
			this.StatisticsConfig = null;
			this.CalculationOnTriggeringStatistics = null;
			this.NullMask = 0;
		}
	}
}
