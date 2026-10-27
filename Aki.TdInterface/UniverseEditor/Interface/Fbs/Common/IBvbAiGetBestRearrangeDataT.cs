using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D32 RID: 23858
	public class IBvbAiGetBestRearrangeDataT
	{
		// Token: 0x1700B2D6 RID: 45782
		// (get) Token: 0x06028CB5 RID: 167093 RVA: 0x0059ADC1 File Offset: 0x00598FC1
		// (set) Token: 0x06028CB6 RID: 167094 RVA: 0x0059ADC9 File Offset: 0x00598FC9
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2D7 RID: 45783
		// (get) Token: 0x06028CB7 RID: 167095 RVA: 0x0059ADD2 File Offset: 0x00598FD2
		// (set) Token: 0x06028CB8 RID: 167096 RVA: 0x0059ADDA File Offset: 0x00598FDA
		public TVarRefUnion BoardCardStored { get; set; }

		// Token: 0x1700B2D8 RID: 45784
		// (get) Token: 0x06028CB9 RID: 167097 RVA: 0x0059ADE3 File Offset: 0x00598FE3
		// (set) Token: 0x06028CBA RID: 167098 RVA: 0x0059ADEB File Offset: 0x00598FEB
		public TVarRefUnion BoardPosStored { get; set; }

		// Token: 0x06028CBB RID: 167099 RVA: 0x0059ADF4 File Offset: 0x00598FF4
		public IBvbAiGetBestRearrangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCardStored = null;
			this.BoardPosStored = null;
		}
	}
}
