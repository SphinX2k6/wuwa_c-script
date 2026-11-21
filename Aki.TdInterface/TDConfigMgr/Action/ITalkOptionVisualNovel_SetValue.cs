using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C2 RID: 8642
	public class ITalkOptionVisualNovel_SetValue
	{
		// Token: 0x04007142 RID: 28994
		public ETalkOptionParamType Type;

		// Token: 0x04007143 RID: 28995
		public int? PlotOptionId;

		// Token: 0x04007144 RID: 28996
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> OptionPerformances;

		// Token: 0x04007145 RID: 28997
		[Nullable(2)]
		public ITalkOptionVisualNovelDoubleConfirm DoubleConfirm;
	}
}
