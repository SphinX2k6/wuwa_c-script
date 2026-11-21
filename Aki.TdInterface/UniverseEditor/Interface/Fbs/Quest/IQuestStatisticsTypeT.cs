using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004497 RID: 17559
	public class IQuestStatisticsTypeT
	{
		// Token: 0x170079FA RID: 31226
		// (get) Token: 0x0601949F RID: 103583 RVA: 0x0039BFB3 File Offset: 0x0039A1B3
		// (set) Token: 0x060194A0 RID: 103584 RVA: 0x0039BFBB File Offset: 0x0039A1BB
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170079FB RID: 31227
		// (get) Token: 0x060194A1 RID: 103585 RVA: 0x0039BFC4 File Offset: 0x0039A1C4
		// (set) Token: 0x060194A2 RID: 103586 RVA: 0x0039BFCC File Offset: 0x0039A1CC
		public TVarRefUnion Var { get; set; }

		// Token: 0x060194A3 RID: 103587 RVA: 0x0039BFD5 File Offset: 0x0039A1D5
		public IQuestStatisticsTypeT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
		}
	}
}
