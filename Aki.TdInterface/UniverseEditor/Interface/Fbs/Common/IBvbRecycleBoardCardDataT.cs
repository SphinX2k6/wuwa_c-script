using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006393 RID: 25491
	public class IBvbRecycleBoardCardDataT
	{
		// Token: 0x1700BC74 RID: 48244
		// (get) Token: 0x0602B4AA RID: 177322 RVA: 0x005E6EF2 File Offset: 0x005E50F2
		// (set) Token: 0x0602B4AB RID: 177323 RVA: 0x005E6EFA File Offset: 0x005E50FA
		public EGoalActType Type { get; set; }

		// Token: 0x0602B4AC RID: 177324 RVA: 0x005E6F03 File Offset: 0x005E5103
		public IBvbRecycleBoardCardDataT()
		{
			this.Type = EGoalActType.Deploy;
		}
	}
}
