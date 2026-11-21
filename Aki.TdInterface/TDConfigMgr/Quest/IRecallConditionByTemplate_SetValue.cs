using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120B RID: 4619
	public class IRecallConditionByTemplate_SetValue
	{
		// Token: 0x04003E0B RID: 15883
		public ERecallConditionType Type;

		// Token: 0x04003E0C RID: 15884
		public ERecallOperation Operation;

		// Token: 0x04003E0D RID: 15885
		public List<string> Templates;

		// Token: 0x04003E0E RID: 15886
		public List<int> AreaIds;
	}
}
