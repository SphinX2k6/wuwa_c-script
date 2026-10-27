using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7D RID: 27517
	public class IMp4FrameEventT
	{
		// Token: 0x1700CC89 RID: 52361
		// (get) Token: 0x0603052D RID: 197933 RVA: 0x00690CCB File Offset: 0x0068EECB
		// (set) Token: 0x0603052E RID: 197934 RVA: 0x00690CD3 File Offset: 0x0068EED3
		public float Second { get; set; }

		// Token: 0x1700CC8A RID: 52362
		// (get) Token: 0x0603052F RID: 197935 RVA: 0x00690CDC File Offset: 0x0068EEDC
		// (set) Token: 0x06030530 RID: 197936 RVA: 0x00690CE4 File Offset: 0x0068EEE4
		public List<IActionInfoT> EventActions { get; set; }

		// Token: 0x06030531 RID: 197937 RVA: 0x00690CED File Offset: 0x0068EEED
		public IMp4FrameEventT()
		{
			this.Second = 0f;
			this.EventActions = null;
		}
	}
}
