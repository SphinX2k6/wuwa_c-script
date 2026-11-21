using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C0 RID: 8640
	public class ITalkOptionSystemCondition_SetValue
	{
		// Token: 0x04007139 RID: 28985
		public ETalkOptionPreConditionType Type;

		// Token: 0x0400713A RID: 28986
		public ITalkOptionConditionSolarSchool System;

		// Token: 0x0400713B RID: 28987
		public bool? HideWhenUnmet;

		// Token: 0x0400713C RID: 28988
		public bool? HideConditionTextWhenUnmet;

		// Token: 0x0400713D RID: 28989
		[Nullable(2)]
		public string TidReplaceTextWhenUnmet;
	}
}
