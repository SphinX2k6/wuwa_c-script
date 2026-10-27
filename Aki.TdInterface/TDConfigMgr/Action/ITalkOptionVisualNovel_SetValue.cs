using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F87 RID: 8071
	public class ITalkOptionVisualNovel_SetValue
	{
		// Token: 0x04006B58 RID: 27480
		public ETalkOptionParamType Type;

		// Token: 0x04006B59 RID: 27481
		public int? PlotOptionId;

		// Token: 0x04006B5A RID: 27482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> OptionPerformances;
	}
}
