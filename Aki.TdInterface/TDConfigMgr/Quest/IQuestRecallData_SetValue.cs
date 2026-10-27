using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001096 RID: 4246
	public class IQuestRecallData_SetValue
	{
		// Token: 0x040039BD RID: 14781
		public ERecallDataType Type;

		// Token: 0x040039BE RID: 14782
		public int Id;

		// Token: 0x040039BF RID: 14783
		[Nullable(1)]
		public IQuestRecallConfig RecallConfig;
	}
}
