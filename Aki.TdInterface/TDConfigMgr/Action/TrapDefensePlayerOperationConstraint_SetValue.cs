using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C2 RID: 9410
	public class TrapDefensePlayerOperationConstraint_SetValue
	{
		// Token: 0x04007935 RID: 31029
		public ITrapDefensePlayerOperationType DisableOperation;

		// Token: 0x04007936 RID: 31030
		public bool IsConstrained;

		// Token: 0x04007937 RID: 31031
		public string TidPromptTxt;

		// Token: 0x04007938 RID: 31032
		[Nullable(2)]
		public string EdTidPromptTxt;
	}
}
