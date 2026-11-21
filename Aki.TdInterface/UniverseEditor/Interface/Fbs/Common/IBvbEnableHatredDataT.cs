using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006381 RID: 25473
	public class IBvbEnableHatredDataT
	{
		// Token: 0x1700BC63 RID: 48227
		// (get) Token: 0x0602B416 RID: 177174 RVA: 0x005E6082 File Offset: 0x005E4282
		// (set) Token: 0x0602B417 RID: 177175 RVA: 0x005E608A File Offset: 0x005E428A
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B418 RID: 177176 RVA: 0x005E6093 File Offset: 0x005E4293
		public IBvbEnableHatredDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
