using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007736 RID: 30518
	public class ISendClientEventT
	{
		// Token: 0x1700DFBD RID: 57277
		// (get) Token: 0x060358C3 RID: 219331 RVA: 0x0072D72B File Offset: 0x0072B92B
		// (set) Token: 0x060358C4 RID: 219332 RVA: 0x0072D733 File Offset: 0x0072B933
		public string EventName { get; set; }

		// Token: 0x1700DFBE RID: 57278
		// (get) Token: 0x060358C5 RID: 219333 RVA: 0x0072D73C File Offset: 0x0072B93C
		// (set) Token: 0x060358C6 RID: 219334 RVA: 0x0072D744 File Offset: 0x0072B944
		public TClientEventUnion Target { get; set; }

		// Token: 0x060358C7 RID: 219335 RVA: 0x0072D74D File Offset: 0x0072B94D
		public ISendClientEventT()
		{
			this.EventName = null;
			this.Target = null;
		}
	}
}
