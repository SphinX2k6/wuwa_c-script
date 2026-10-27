using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C8 RID: 8648
	[NullableContext(1)]
	[Nullable(0)]
	public class SetNpcGroupPerform_SetValue
	{
		// Token: 0x04007156 RID: 29014
		public string Key;

		// Token: 0x04007157 RID: 29015
		public ISetNpcGroupPerformType PerformType;

		// Token: 0x04007158 RID: 29016
		public bool? IsWaitActionFinish;
	}
}
