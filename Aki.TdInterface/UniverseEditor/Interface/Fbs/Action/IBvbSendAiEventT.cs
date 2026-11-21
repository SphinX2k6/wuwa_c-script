using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CF RID: 26831
	public class IBvbSendAiEventT
	{
		// Token: 0x1700C537 RID: 50487
		// (get) Token: 0x0602DE85 RID: 188037 RVA: 0x00645F71 File Offset: 0x00644171
		// (set) Token: 0x0602DE86 RID: 188038 RVA: 0x00645F79 File Offset: 0x00644179
		public TBvbEventDataUnion EventData { get; set; }

		// Token: 0x0602DE87 RID: 188039 RVA: 0x00645F82 File Offset: 0x00644182
		public IBvbSendAiEventT()
		{
			this.EventData = null;
		}
	}
}
