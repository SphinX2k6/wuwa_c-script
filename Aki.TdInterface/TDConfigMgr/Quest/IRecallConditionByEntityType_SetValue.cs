using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001207 RID: 4615
	public class IRecallConditionByEntityType_SetValue
	{
		// Token: 0x04003E00 RID: 15872
		public ERecallConditionType Type;

		// Token: 0x04003E01 RID: 15873
		public ERecallOperation Operation;

		// Token: 0x04003E02 RID: 15874
		public List<string> EntityTypes;

		// Token: 0x04003E03 RID: 15875
		public List<int> AreaIds;
	}
}
