using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004551 RID: 17745
	public class ISheriffAnomalyProgressBoardConfigT
	{
		// Token: 0x17007C07 RID: 31751
		// (get) Token: 0x06019CEC RID: 105708 RVA: 0x003AEE96 File Offset: 0x003AD096
		// (set) Token: 0x06019CED RID: 105709 RVA: 0x003AEE9E File Offset: 0x003AD09E
		public int AnomalyId { get; set; }

		// Token: 0x06019CEE RID: 105710 RVA: 0x003AEEA7 File Offset: 0x003AD0A7
		public ISheriffAnomalyProgressBoardConfigT()
		{
			this.AnomalyId = 0;
		}
	}
}
