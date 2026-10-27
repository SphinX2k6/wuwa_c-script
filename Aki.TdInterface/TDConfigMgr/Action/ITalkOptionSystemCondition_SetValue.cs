using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F85 RID: 8069
	public class ITalkOptionSystemCondition_SetValue
	{
		// Token: 0x04006B51 RID: 27473
		public ETalkOptionPreConditionType Type;

		// Token: 0x04006B52 RID: 27474
		[Nullable(1)]
		public ITalkOptionConditionSolarSchool System;

		// Token: 0x04006B53 RID: 27475
		public bool? HideWhenUnmet;

		// Token: 0x04006B54 RID: 27476
		public bool? HideConditionTextWhenUnmet;

		// Token: 0x04006B55 RID: 27477
		[Nullable(2)]
		public string TidReplaceTextWhenUnmet;
	}
}
