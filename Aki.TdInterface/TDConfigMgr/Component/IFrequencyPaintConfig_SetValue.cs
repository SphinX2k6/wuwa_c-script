using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000416 RID: 1046
	public class IFrequencyPaintConfig_SetValue
	{
		// Token: 0x04001084 RID: 4228
		public string EntityState;

		// Token: 0x04001085 RID: 4229
		public IFrequencyPaintLineBase LineType;

		// Token: 0x04001086 RID: 4230
		public List<ActionInfo> SuccessActions;
	}
}
