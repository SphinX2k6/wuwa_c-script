using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004110 RID: 16656
	public class ISheriffAnomalyProgressBoardConfigT
	{
		// Token: 0x17007601 RID: 30209
		// (get) Token: 0x06018649 RID: 99913 RVA: 0x00384E8E File Offset: 0x0038308E
		// (set) Token: 0x0601864A RID: 99914 RVA: 0x00384E96 File Offset: 0x00383096
		public int AnomalyId { get; set; }

		// Token: 0x0601864B RID: 99915 RVA: 0x00384E9F File Offset: 0x0038309F
		public ISheriffAnomalyProgressBoardConfigT()
		{
			this.AnomalyId = 0;
		}
	}
}
