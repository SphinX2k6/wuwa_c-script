using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007748 RID: 30536
	public class ISequenceFrameEventT
	{
		// Token: 0x1700DFD3 RID: 57299
		// (get) Token: 0x0603594C RID: 219468 RVA: 0x0072E6A4 File Offset: 0x0072C8A4
		// (set) Token: 0x0603594D RID: 219469 RVA: 0x0072E6AC File Offset: 0x0072C8AC
		public string EventKey { get; set; }

		// Token: 0x1700DFD4 RID: 57300
		// (get) Token: 0x0603594E RID: 219470 RVA: 0x0072E6B5 File Offset: 0x0072C8B5
		// (set) Token: 0x0603594F RID: 219471 RVA: 0x0072E6BD File Offset: 0x0072C8BD
		public List<IActionInfoT> EventActions { get; set; }

		// Token: 0x06035950 RID: 219472 RVA: 0x0072E6C6 File Offset: 0x0072C8C6
		public ISequenceFrameEventT()
		{
			this.EventKey = null;
			this.EventActions = null;
		}
	}
}
