using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D9 RID: 4313
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByEntityType_SetValue
	{
		// Token: 0x04003AB3 RID: 15027
		public ERecallConditionType Type;

		// Token: 0x04003AB4 RID: 15028
		public ERecallOperation Operation;

		// Token: 0x04003AB5 RID: 15029
		public List<string> EntityTypes;

		// Token: 0x04003AB6 RID: 15030
		public List<int> AreaIds;
	}
}
