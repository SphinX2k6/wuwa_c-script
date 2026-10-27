using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED6 RID: 7894
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenCustomInitData_SetValue
	{
		// Token: 0x04006493 RID: 25747
		public ESubScreenInitDataType Type;

		// Token: 0x04006494 RID: 25748
		public string SubScreenKey;

		// Token: 0x04006495 RID: 25749
		public ISubScreenConfig InitConfig;
	}
}
